Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO


Public Class frmPrinc
    '    Dim NomFichierModele, NomFichierTrav, NomFichierEtud, Dossiers As String


    Private Sub frmPrinc_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load
        Dossiers = My.Application.Info.DirectoryPath
        Dim L As Integer = Dossiers.Length
        Try
            XlApp = New Excel.Application

            ExcelOuvert = True
            ExcelVisible = XlApp.Visible
        Catch ex As Exception
            ExcelOuvert = False
        End Try

        txtCorrDossier.Text = CheminAff(Dossiers)

    End Sub


    Private Sub btnCorrDossier_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnCorrDossier.Click
        Try

            FolderBrowserDialog1.SelectedPath = My.Application.Info.DirectoryPath
            FolderBrowserDialog1.ShowDialog()
            Dossiers = FolderBrowserDialog1.SelectedPath
            'Dossiers = "123456789a123456789b123456789c123456789d123456789e1234Z"
            Dim L As Integer = Dossiers.Length


        Catch ex As Exception
            MsgBox("Le dossier est mal défini")
            Exit Sub
        End Try
        txtCorrDossier.Text = CheminAff(Dossiers)
        DossierDefini = True
    End Sub

    Private Sub btnCorrFichier_Click(ByVal sender As Object, _
                ByVal e As EventArgs) _
                Handles btnCorrFichier.Click, btnPrepModel.Click
        Try

            OpenFileDialog1.InitialDirectory = Dossiers
            OpenFileDialog1.Filter = "Fichiers Excel|*.xls*|Tous les fichiers|*.*"
            OpenFileDialog1.ShowDialog()
            NomFichierModele = OpenFileDialog1.FileName
            UnFichier = New FileInfo(NomFichierModele)

            '''' On ouvre la feuille  '''''''''''''''''''''''''''''''''''''''''''''''''
            xlFichModel = XlApp.Workbooks.Open(NomFichierModele)

            ModeleOuvert = True

        Catch ex As Exception
            MsgBox("Le fichier modèle ne peut être ouvert")
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
            Me.Close()
            Exit Sub
        End Try
        txtPrepModel.Text = CheminAff(NomFichierModele)
        txtCorrFich.Text = txtPrepModel.Text
        LectureComm()

        ExcelVisible = xlFichModel.Application.Visible

    End Sub

    Private Sub btnCorr_Exec_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnCorr.Click
        If Not (ModeleOuvert And DossierDefini) Then
            MsgBox("Le fichier et le dossier doivent être définis")
            Exit Sub
        End If

        'Dossiers = "C:\Users\Francis_2\Desktop\VB_Correction_Excel\Fichiers_Excel\"
        'NomFichierModele = "C:\Users\Francis_2\Desktop\VB_Correction_Excel\Fichiers_Excel\Correction.xlsx"

        Dim ListeDoss() As String = Directory.GetFiles(Dossiers)
        Dim KLong As Integer = ListeDoss.Length + 1


        If KLong = 0 Then
            MsgBox("Le dossier de fichiers est vide")
            Me.Close()
            Exit Sub
        End If


        For Each UnNom As String In ListeDoss
            If UnNom = NomFichierModele Then Continue For
            If UnNom.Contains("~") Then Continue For
            If UnNom.Contains("\.") Then Continue For
            If Not UnNom.Contains("xls") Then Continue For
            Try
                xlFichEtud = XlApp.Workbooks.Open(UnNom)

                Dim L As Integer = UnNom.Length
                NbDossiers += 1
                lblDossEtud.Text = "Nombre de fichiers corrigés : " & NbDossiers
                lblDossFit.Text = CheminAff(UnNom)

            Catch ex As Exception
                MsgBox("Problème avec : " & ex.Message)
                Continue For
            End Try
            '''''''''''''''''''''''''''''''''''''
            Corriger()                          '
            '''''''''''''''''''''''''''''''''''''
            Try
                'xlFichEtud.Application.Visible = True

                xlFichEtud.Close(True)
                xlFichEtud = Nothing

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        Next
        MsgBox("Terminé")

Fin:
    End Sub

    Private Sub btnPrep_Exec_Click(sender As System.Object, e As System.EventArgs) Handles btnPrep_Exec.Click

        'MsgBox("Analyser")

        Dim frmBar As New frmBareme
        ' MsgBox("New..." & frmBar.dgQuest.ColumnCount)
        If Not (ModeleOuvert And TravOuvert) Then
            MsgBox("Les deux fichiers doivent être définis")
            Exit Sub
        End If
        Me.Hide()
        frmBar.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Corriger()
        'MsgBox("Corriger")
        Dim xlFeuilleCorr As Worksheet
        Dim UnRangeMod As Range
        Dim UnRangeEtud As Range
        Dim Directive As String
        Dim NoLigne As Integer = 4
        Dim LaCell As String

        Try
            xlFeuilleCorr = xlFichEtud.Sheets("_Résultats")
            With xlFeuilleCorr
                .Range("A1").Copy(.Range("A3:D79"))
                '.Selection.Copy()
                '.Range("A3:D79").Select()
                '.Paste()
                .Application.CutCopyMode = False
                '.Range("A1").Select()
            End With
        Catch ex As Exception
            Try
                xlFeuilleCorr = xlFichEtud.Sheets.Add(xlFichEtud.Sheets(1))
            Catch ex2 As Exception
                MsgBox(ex2.ToString)
                Exit Sub
            End Try

            With xlFeuilleCorr
                .Name = "_Résultats"
                .Range("D4:E59").Font.Bold = True
                .Range("A4:D4").Font.Bold = True
                .Columns("A:A").ColumnWidth = 12
                .Columns("B:B").ColumnWidth = 17
                .Columns("C:C").ColumnWidth = 13
                .Columns("D:D").ColumnWidth = 12
                .Columns("E:E").ColumnWidth = 45
            End With


        End Try

        With xlFeuilleCorr

            .Cells(NoLigne, 1).value = "Score"
            .Cells(NoLigne, 2).value = "Feuille"
            .Cells(NoLigne, 3).value = "Plage"
            .Cells(NoLigne, 4).value = "No Questions"
            NoLigne += 1
            For Each UnNom As clZone In MaCollCorr
                xlMafMod = xlFichModel.Sheets(UnNom.Feuille)
                'xlMafMod.Activate()
                NoLigne += 1
                .Cells(NoLigne, 2).value = UnNom.Feuille
                .Cells(NoLigne, 3).value = Stripper(UnNom.Zone)
                .Cells(NoLigne, 4).value = UnNom.Nom
                xlMafEtud = xlFichEtud.Sheets(UnNom.Feuille)
                'xlMafEtud.Activate()

                UnRangeMod = xlMafMod.Range(UnNom.Ancre)
                UnRangeEtud = xlMafEtud.Range(UnNom.Ancre)
                Directive = UnNom.Comm

                Dim LesDir() As String = Directive.Split("/")
                Dim NbDir As Integer = LesDir.Length
                .Cells(NoLigne, 1).value = " / " & LesDir(0)

                Dim ErrVal As Boolean = False
                Dim ValDiff As Boolean = False
                Dim Erreur As Boolean = False

                ValDiff = ValEgal(UnRangeEtud, UnRangeMod, 0.0001) = "S" _
                Or ValEgal(UnRangeEtud, UnRangeMod, 0.0001) = "P"
                For NumDir As Integer = 1 To NbDir - 2 Step 2
                    Dim LeCode As String = LesDir(NumDir).Substring(0, 1)
                    Select Case LeCode
                        Case "V"
                            If ValDiff Then
                                NoLigne += 1
                                LaCell = "E" & NoLigne.ToString
                                .Range(LaCell).Value = "Erreur : valeur non conforme."
                                .Range(LaCell).Interior.Color = Color.PaleGreen
                            End If
                        Case "A"
                            Dim ErreurA As Boolean = False
                            Dim ListErr As String = FormatEgal(UnRangeEtud, UnRangeMod)
                            If ListErr <> "" Then
                                NoLigne += 1
                                LaCell = "E" & NoLigne.ToString
                                .Cells(NoLigne, 5) = "Erreur : format non conforme."
                                .Range(LaCell).Interior.Color = Color.PaleGoldenrod
                            End If
                        Case "F"
                            Dim ErreurF As Boolean = ValDiff
                            Dim LaFonc As String
                            Dim TypFonc = LesDir(NumDir).Substring(1, 1)
                            Select Case TypFonc
                                Case "="
                                    LaFonc = LesDir(NumDir).Substring(2, LesDir(NumDir).Length - 2)
                                    Dim UneFonc As String = FormuleEgal(UnRangeEtud, UnRangeMod, LaFonc)
                                    If UneFonc <> "" Then ErreurF = True

                                Case "S"
                                    If Not IsFunc(UnRangeEtud) Then ErreurF = True

                                Case "A"
                                    If UnRangeEtud.Formula.ToString.Contains("$") OrElse _
                                        FormNom(UnRangeEtud.Formula.ToString) Then
                                    Else
                                        ErreurF = True
                                    End If

                            End Select
                            If ErreurF Then
                                NoLigne += 1
                                LaCell = "E" & NoLigne.ToString
                                .Cells(NoLigne, 5) = "Erreur : formule non conforme."
                                .Range(LaCell).Interior.Color = Color.Orchid
                            End If
                    End Select

                Next
            Next
        End With
    End Sub




    Private Sub btnQuit1_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) _
             Handles btnQuit1.Click, btnQuit2.Click


        Try


            With XlApp
                For Each UnBook As Excel.Workbook In .Workbooks
                    UnBook.Close(False)
                Next
                .Quit()
            End With
        Catch ex As Exception

        End Try
        XlApp = Nothing
        Me.Close()
    End Sub


    Private Function Stripper(ByVal UneZone As String) As String
        Dim K As Integer
        Do While UneZone.Contains("$")
            K = UneZone.IndexOf("$")
            UneZone = UneZone.Remove(K, 1)
        Loop
        Stripper = UneZone
    End Function

    Public Function Conv(ByVal St As String) As UnRange
        Dim PR As New UnRange
        Dim Part() As String
        Dim Ch As String
        Dim L As Integer
        Part = St.Split("$")
        L = Part.Length
        If L <> 3 And L <> 5 Then
            MsgBox("Adresse invalide : " & St)
            GoTo fin
        End If
        Ch = ""
        With PR

            For k As Integer = 0 To L - 1
                Ch = Part(k)
                Select Case k
                    Case 1
                        .ColMin = Asc(Ch.Chars(0)) - Asc("A") + 1
                        'Dim C As Char = 
                        'Dim l1 As Integer = Char.chr(Ch.Chars(0))
                        'Dim l2 As Integer = Char.GetNumericValue("A"c)
                        '.ColMin = l1 - l2 + 1
                        'If Ch.Length = 2 Then
                        '.ColMin = 26 * .ColMin _
                        '    + Char.GetNumericValue(Ch.Chars(1)) _
                        '    - Char.GetNumericValue("A") + 1
                        'End If
                        .ColMax = .ColMin

                    Case 2
                        Ch = Ch.Replace(":", "")
                        .LigMin = CInt(Ch)
                        .LigMax = .LigMin
                    Case 3
                        .ColMax = Char.GetNumericValue(Ch.Chars(0)) _
                            - Char.GetNumericValue("A") + 1
                        If Ch.Length = 2 Then
                            .ColMax = 26 * .ColMax _
                                + Char.GetNumericValue(Ch.Chars(1)) _
                                - Char.GetNumericValue("A") + 1
                        End If
                    Case 4
                        .LigMax = CInt(Ch)
                End Select
            Next
        End With
Fin:
        Conv = PR

    End Function

    Private Function CheminAff(ByVal Chaine As String) As String
        Dim Elem() As String
        Dim Num As Integer
        Elem = Chaine.Split("\")
        Dim K As Integer = Elem.Length
        Num = 2

        Dim L As Integer = Chaine.Length
        Do While L > 77 And Num < K - 1
            Elem(Num) = "..."
            Chaine = Elem(0)
            For J As Integer = 1 To K - 1
                Chaine &= "\" & Elem(J)

            Next
            Num += 1
            L = Chaine.Length
        Loop
        CheminAff = Chaine

    End Function


    Private Sub btnPrepTrav_Click(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) _
                                  Handles btnPrepTrav.Click


        Try
            OpenFileDialog1.InitialDirectory = Dossiers
            OpenFileDialog1.Filter = "Fichiers Excel|*.xls*|Tous les fichiers|*.*"
            OpenFileDialog1.ShowDialog()
            NomFichierTrav = OpenFileDialog1.FileName
            UnFichier = Nothing
            UnFichier = New FileInfo(NomFichierTrav)

            Dim L As Integer = NomFichierTrav.Length


            '''' On ouvre la feuille  '''''''''''''''''''''''''''''''''''''''''''''''''
            xlFichTrav = GetObject(NomFichierTrav)
            TravOuvert = True

        Catch ex As Exception
            MsgBox("Le fichier de travail ne peut être ouvert")
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
            Me.Close()
            Exit Sub
        End Try

        txtPrepTrav.Text = CheminAff(NomFichierTrav)
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub
End Class

Public Class UnRange
    Public ColMin As Integer
    Public ColMax As Integer
    Public LigMin As Integer
    Public LigMax As Integer
End Class


Public Class clZone

    ' Public PrenNom As String
    Public Nom As String
    Public Adresse As String
    Public Feuille As String
    Public Zone As String
    Public Ancre As String
    Public Comm, Formule As String
    Public ValeurDet As String
    Public FormuleDet As String
    Public FormatDet As String


    Public Sub New(ByVal LeNom As String, ByVal Ladresse As String)
        Nom = LeNom
        Adresse = Ladresse

        Dim Pos As Integer = Adresse.IndexOf("!")
        Dim L As Integer = Adresse.Length
        Feuille = Adresse.Substring(0, Pos)

        Zone = Adresse.Substring(Pos + 1, L - Pos - 1)
        Dim Partie() As String = Zone.Split(":")
        Ancre = Partie(0)
        L = Feuille.Length
        If Feuille.Contains("'") Then Feuille = Feuille.Substring(1, L - 2)
        ValeurDet = ""
        FormuleDet = ""
        FormatDet = ""
    End Sub

End Class
