Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Module Module1

    Friend NomFichierModele, NomFichierTrav, NomFichierEtud, Dossiers As String
    Friend ExcelOuvert, ExcelVisible As Boolean
    Friend TravOuvert, ModeleOuvert As Boolean
    Friend DossierDefini As Boolean
    Friend XlApp As Excel.Application
    Friend UnFichier As FileInfo
    Friend xlFichModel As Workbook = Nothing
    Friend xlFichEtud As Workbook = Nothing
    Friend xlFichTrav As Workbook = Nothing
    Friend OK As String = "OUI"
    Friend PasOK As String = ""
    Friend xlMafMod As Worksheet = Nothing
    Friend xlMafEtud As Worksheet = Nothing
    Friend xlMafTrav As Worksheet = Nothing


    Friend ColNom As Integer
    Friend ColSect As Integer
    Friend NbDossiers As Integer = 0
    Friend MaCollCorr As New Collection
    Friend LectureFaite As Boolean = False
    Friend MaCollTrim As New Collection
    Friend MaCollSectTrim As New Collection

    Public Function Inv(ByVal Msg As String) As String
        If Msg = PasOK Then
            Return OK
        Else
            Return PasOK
        End If
    End Function

    Public Function OKVal(ByVal Cond As Boolean) As String
        If Cond Then
            Return OK
        Else
            Return PasOK
        End If
    End Function

    Friend Function ValEgal(ByVal CellT As Range, _
                  ByVal CellM As Range, _
                  ByVal Diff As Single) _
           As String
        Dim VideT As Boolean = (CellT.Value Is Nothing)
        If Not VideT Then VideT = CStr(CellT.Value) = ""

        Dim VideM As Boolean = (CellM.Value Is Nothing)
        If Not VideM Then VideM = CStr(CellM.Value) = ""
        ValEgal = "S"

        If VideT And VideM Then
            Return ""
        End If

        If VideM Then Return "S"

        Dim NumM As Boolean = IsNumeric(CellM.Value.ToString)

        If VideT Then
            If NumM Then
                Return "P"
            Else
                Return "S"
            End If
        End If

        Dim NumT As Boolean = IsNumeric(CellT.Value.ToString)
        If CellT.Value.ToString = CellM.Value.ToString Then
            Return ""
        End If

        If NumM Then
            If NumT Then
                If Math.Abs(CInt(CellM.Value.ToString) - _
                                CInt(CellT.Value.ToString)) < 0.00001 Then
                    Return ""
                End If
                Return "P"
            Else
                Return "P"
            End If
        Else
            Return "S"
        End If

    End Function

    Friend Function FormuleEgal(ByVal CellT As Range, _
                        ByVal CellM As Range, _
                        ByVal Fonc As String) As String

        If Not IsFunc(CellM) Then Return ""

        If CellT.Formula.ToString = CellM.Formula.ToString Then Return ""

        FormuleEgal = "S"
        If CellM.Formula.ToString.Contains("$") OrElse _
           FormNom(CellM.Formula.ToString) Then
            FormuleEgal = "A"
        End If

        If Fonc <> "" Then
            Dim Formule As String = CellT.Formula.ToString.ToLower
            If Formule.Contains(Fonc.ToLower) Then
                Return ""
            End If
        End If

    End Function




    Friend Function FormNom(ByVal UneCh As String) As Boolean
        FormNom = False
        UneCh = UneCh.ToLower()

        Dim L As Integer = UneCh.Length
        If Char.IsLetter(UneCh(L - 1)) Then
            Return True
        End If
        Dim K As Integer = 1
        Dim CPrec As Char = UneCh.Chars(K)

        Do While K < L - 1
            K = K + 1
            Dim CCour As Char = UneCh.Chars(K)
            If Char.IsLetter(CPrec) And _
            Not (Char.IsLetter(CCour) _
                 Or Char.IsDigit(CCour) _
                 Or CCour = """" _
                 Or CCour = "(") Then
                Return True
            End If
            CPrec = CCour
        Loop

    End Function
    Friend Function IsFunc(ByVal Cellule As Range) As Boolean
        Dim Form As String = Cellule.Formula.ToString
        If Not Cellule.HasFormula Then Return False

        Dim L As Integer = Form.Length
        For K As Integer = 1 To L - 1
            Dim UnCar As Char = Form.Chars(K)
            UnCar = Char.ToLower(UnCar)
            If UnCar >= "a" _
                And UnCar <= "z" Then
                Return True
            End If
        Next
    End Function

    Friend Function ValForm(ByVal stDir As String, _
                                  ByVal stVal As String) As String
        Dim K As Integer = stDir.IndexOf(stVal)
        If K > 0 Then
            Dim L As Integer = stDir.IndexOf("/", K + 1)
            ValForm = stDir.Substring(K + 2, L - K - 2)
        Else
            ValForm = ""
        End If

    End Function

    Friend Function ValProche(ByVal stDir As String, _
                              ByVal stVal As String) As String
        Dim K As Integer = stDir.IndexOf(stVal & "=")
        If K > 0 Then
            ValProche = Str(Val(stDir.Substring(K + 3, 2)))
        Else
            ValProche = ""
        End If
    End Function

    Friend Function Egal(ByVal Cell1 As Range, _
                      ByVal Cell2 As Range, _
                      ByVal Diff As Single) _
                  As Boolean

        Egal = False
        Dim TypeCellule As String
        Select Case True

            Case IsNumeric(Cell2.Value)
                TypeCellule = "Numérique"
                If IsNumeric(Cell1.Value) Then
                    Egal = Math.Abs(Cell1.Value - Cell2.Value) < Diff
                End If

            Case Else
                Try
                    Egal = Cell1.Value = Cell2.Value
                Catch ex As Exception
                End Try

        End Select


    End Function

    Friend Function FormatEgal(ByVal RANGE1 As Range, _
                               ByVal range2 As Range) As String
        FormatEgal = ""  ' Premier niveau = Affichage
        'Ligne
        If RANGE1.RowHeight.ToString <> range2.RowHeight.ToString Then
            FormatEgal &= "L"  ' Changement de hauteur de ligne
        End If
        'Colonne
        If RANGE1.ColumnWidth.ToString <> range2.ColumnWidth.ToString Then
            FormatEgal &= "C" ' Changement de largeur de colonne
        End If
        If Not OKFont(RANGE1, range2) Then
            FormatEgal &= "P" ' Changement de police
        End If
        If Not RANGE1.NumberFormat.ToString = range2.NumberFormat.ToString Then
            FormatEgal &= "N"  ' Changement de format de nombre
        End If
        If Not RANGE1.Interior.ColorIndex = range2.Interior.ColorIndex Then
            FormatEgal &= "T"  ' Changement de couleur de trame
        End If
        If Not RANGE1.Borders.ColorIndex = range2.Borders.ColorIndex _
            Or Not RANGE1.Borders.Weight.ToString = range2.Borders.Weight.ToString Then
            FormatEgal &= "B"  ' Changement de bordure
        End If
        If Not RANGE1.HorizontalAlignment = range2.HorizontalAlignment _
            Or Not RANGE1.VerticalAlignment = range2.VerticalAlignment Then
            FormatEgal &= "A"  ' Changement d'alignement horizontal ou vertical
        End If


    End Function

    Friend Function OKFont(ByVal RANGE1 As Range, ByVal range2 As Range) As Boolean
        OKFont = True

        If RANGE1.Font.Bold <> range2.Font.Bold Then Return False
        If RANGE1.Font.Italic <> range2.Font.Italic Then Return False
        If RANGE1.Font.Size <> range2.Font.Size Then Return False
        If RANGE1.Font.Name <> range2.Font.Name Then Return False
        If RANGE1.Font.ColorIndex <> range2.Font.ColorIndex Then Return False
        ' If Not RANGE1.NumberFormat <> range2.NumberFormat Then Return False


    End Function


    Public Sub EcritureComm()
        Dim UnclZone As clZone = Nothing
        Dim UnePlage As Range
        Dim xlFeuilleCorr As Worksheet

        For Each Obj As Name In xlFichModel.Names
            If Obj.Name.Substring(0, 2) <> "Q_" Then Continue For
            ' MsgBox(Obj.Name & " / " & Obj.RefersTo)
            If Obj.Name = "Q_00" Then Continue For
            UnclZone = MaCollCorr(Obj.Name)

            xlFeuilleCorr = xlFichModel.Sheets(UnclZone.Feuille)

            UnePlage = xlFeuilleCorr.Range(UnclZone.Ancre)

            If Not UnePlage.Comment Is Nothing Then
                UnePlage.Comment.Delete()
            End If
            If UnclZone.Comm <> "" Then
                UnePlage.AddComment(UnclZone.Comm)
            End If


        Next
        'XlApp.Visible = True
        Exit Sub

fin:

    End Sub

    Public Sub LectureComm()
        Dim UnclZone As clZone = Nothing
        Dim UnePlage As Range
        Dim xlFeuilleCorr As Worksheet

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dim LeNom, LeNomTrim As String

        MaCollCorr.Clear()

        For Each Obj As Name In xlFichModel.Names
            If Obj.Name.Substring(0, 2) <> "Q_" Then Continue For
            ' MsgBox(Obj.Name & " / " & Obj.RefersTo)
            If Obj.Name = "Q_00" Then Continue For
            Dim L As Integer = Obj.RefersTo.ToString.Length
            UnclZone = New clZone(Obj.Name, Obj.RefersTo.ToString.Substring(1, L - 1))
            ' Obj.Visible = False
            xlFeuilleCorr = xlFichModel.Sheets(UnclZone.Feuille)

            UnePlage = xlFeuilleCorr.Range(UnclZone.Ancre)
            If Not UnePlage.Comment Is Nothing Then
                UnclZone.Comm = UnePlage.Comment.Text
            Else
                UnclZone.Comm = ""
            End If
            UnclZone.Formule = UnePlage.Formula
            MaCollCorr.Add(UnclZone, UnclZone.Nom)
        Next
        MsgBox(MaCollCorr.Count & " questions à corriger")
        LectureFaite = True

        Exit Sub

fin:

    End Sub
End Module
