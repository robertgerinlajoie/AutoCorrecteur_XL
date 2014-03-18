Public Class frmBareme
    Public MonForm As frmFormulaire
    Public SiModif As Boolean = False

    Private Sub Q00Ecr()
        Dim Q00Dir As String = ""

        Dim Ld As Integer = 0

        Q00Dir = Coder(Q00Dir, "L-", TextBox1)
        Q00Dir = Coder(Q00Dir, "C-", TextBox2)
        Q00Dir = Coder(Q00Dir, "C+", TextBox3)
        Q00Dir = Coder(Q00Dir, "L+", TextBox4)
        TextBox0.Text = Q00Dir
    End Sub

    Private Function Coder(ByVal Direc As String, _
                           ByVal Ch As String, _
                           ByRef Boxe As System.Windows.Forms.TextBox) _
                       As String
        Dim NumLC As String
        Coder = Direc
        If Boxe.Text = "" Then Exit Function
        Dim Decal() As String
        Dim Ld As Integer = 0

        Decal = Boxe.Text.Split("/")
        Ld = Decal.Length

        For K As Integer = 0 To Ld - 1
            NumLC = Decal(K)
            If Direc = "" Then
                Direc = Ch & NumLC
            Else
                Direc &= "/" & Ch & NumLC
            End If
        Next
        Coder = Direc
    End Function

    Private Sub Q00Lec()
        Dim Q00Dir As String
        Dim Decal() As String
        Dim Ld As Integer = 0
        Dim NumLC As Integer
        Q00Dir = TextBox0.Text

        If Q00Dir = "" Then Exit Sub
        Decal = Q00Dir.Split("/")
        If Q00Dir <> "" Then Ld = Decal.Length
        For K As Integer = 0 To Ld - 1
            Dim LC As String = Decal(K).Substring(0, 2)
            Dim LeTout As String = Decal(K) & " "

            NumLC = LeTout.Substring(2, 2).TrimEnd

            Select Case LC
                Case "L-"
                    AjoutLC(TextBox1, NumLC)

                Case "L+"
                    AjoutLC(TextBox4, NumLC)

                Case "C-"
                    AjoutLC(TextBox2, NumLC)

                Case "C+"
                    AjoutLC(TextBox3, NumLC)

            End Select
        Next

    End Sub

    Private Sub AjoutLC(ByRef Boxe As System.Windows.Forms.TextBox, ByVal Ch As String)
        If Boxe.Text = "" Then
            Boxe.Text = Ch
        Else
            Boxe.Text &= "/" & Ch
        End If

    End Sub

    Private Sub btnFermer_Click(sender As System.Object, _
                e As System.EventArgs) _
                Handles btnFermer.Click
        If SiModif Then
            xlFichModel.Names.Item("Q_00").Comment = TextBox0.Text
            EcritureComm()
            xlFichModel.Save()
        End If
        Me.Close()
    End Sub


    Private Sub frmBareme_Load(sender As Object, _
                          e As System.EventArgs) _
                          Handles Me.Load
        'MsgBox("Corriger")
        'XlApp.Visible = True
        SiModif = False
        Dim UnRangeMod As Range
        Dim UnRangeTrav As Range
        Dim Directive As String
        Dim NoLigne As Integer = 4
        ' Dim LaCell As String
        Dim Ld As Integer
        Dim Decal() As String = Nothing

        Try
            Dim objNom As Name = xlFichModel.Names.Item("Q_00")

            If Not objNom.Comment Is Nothing Then
                TextBox0.Text = objNom.Comment
                Q00Lec()
                Decal = TextBox0.Text.Split("/")
                Ld = Decal.Length
            Else
                TextBox0.Text = ""
            End If

        Catch ex As Exception
        End Try

        Dim StyleVide As DataGridViewCellStyle = New DataGridViewCellStyle
        StyleVide.BackColor = Color.Aqua

        Dim StyleNum As DataGridViewCellStyle = New DataGridViewCellStyle
        StyleNum.BackColor = dgQuest.DefaultCellStyle.BackColor
        Dim Direct_Decal As String
        Ld = 0
        Try
            Direct_Decal = MaCollCorr("Q_00").comm
        Catch ex As Exception
            Direct_Decal = ""
        End Try

        If Direct_Decal <> "" Then
            Decal = Direct_Decal.Split("/")
            Ld = Decal.Length
        End If

        Dim TotPts As Integer = 0
        Dim unnom As clZone

        For Each unnom In MaCollCorr

            xlMafMod = xlFichModel.Sheets(unnom.Feuille)
            'xlMafMod.Activate()

            Try
                xlMafTrav = xlFichTrav.Sheets(unnom.Feuille)
            Catch ex As Exception
                xlMafTrav = Nothing
                MsgBox("Attention : la feuille " & unnom.Feuille _
                      & " n'existe pas dans le fichier de travail")
                Continue For
            End Try
            'xlMafEtud.Activate()

            UnRangeMod = xlMafMod.Range(unnom.Ancre)

            If xlMafTrav Is Nothing Then
                UnRangeTrav = Nothing
            Else
                UnRangeTrav = xlMafTrav.Range(unnom.Ancre)

            End If


            If Ld > 0 Then ' OK ?????????????????????????????????????????????
                ' Ajuster adresse
                For Kd As Integer = 0 To Ld - 1
                    Dim Dec As String = Decal(Kd).Substring(0, 2)
                    Dim Num As Integer = CInt(Decal(Kd).Substring(2, 2))
                    Select Case Dec
                        Case "C+"
                            '    If UnRangeTrav.Address(ColumnAbsolute:=True) > num Then
                            '        UnRangeTrav = UnRangeTrav.Offset(num, 0)
                            'End If
                        Case "C-"
                            '    If UnRangeTrav.Address(RowAbsolute:=True) > num Then
                            '        UnRangeTrav = UnRangeTrav.Offset(num, 0)
                            'End If
                        Case "L+"
                            If CInt(UnRangeTrav.Row) >= Num Then
                                UnRangeTrav = UnRangeTrav.Offset(0, 1)
                            End If
                        Case "L-"
                            If CInt(UnRangeTrav.Row) >= Num Then
                                UnRangeTrav = UnRangeTrav.Offset(0, -1)
                            End If
                    End Select
                Next
            End If


            'MsgBox("Val : " & UnRangeMod.Text)
            'MsgBox("Form : " & UnRangeMod.Formula.ToString)
            'MsgBox("Val : " & UnRangeMod.HasFormula.ToString)


            Dim ValIdent As String = ValEgal(UnRangeTrav, UnRangeMod, 0.25)
            unnom.ValeurDet = ValIdent

            Dim FormIdent As String = FormuleEgal(UnRangeTrav, UnRangeMod, "")
            unnom.FormuleDet = FormIdent

            Dim FormatIdent As String

            FormatIdent = FormatEgal(UnRangeTrav, UnRangeMod)
            unnom.FormatDet = FormatIdent

            Directive = unnom.Comm
            Dim LesDir() As String = Directive.Split("/")

            Dim s1, s2, s3 As String
            If ValIdent = "" Then
                s1 = "Zéro"
            Else
                s1 = CStr(0)
            End If
            If FormIdent = "" Then
                s2 = "Zéro"
            Else
                s2 = CStr(0)
            End If
            If FormatIdent = "" Then
                s3 = "Zéro"
            Else
                s3 = CStr(0)
            End If
            For K As Integer = 1 To LesDir.Length - 2 Step 2
                If LesDir(K).StartsWith("V") Then
                    If IsNumeric(s1) Then s1 = CStr(LesDir(K + 1))
                End If
                If LesDir(K).StartsWith("F") Then
                    If IsNumeric(s2) Then s2 = CStr(LesDir(K + 1))
                End If
                If LesDir(K).StartsWith("A") Then
                    If IsNumeric(s3) Then s3 = CStr(LesDir(K + 1))
                End If
            Next
            With dgQuest
                .Rows.Add(New String() _
            {unnom.Nom, LesDir(0), s1, s2, s3, Directive})
                Dim L As Integer = .Rows.Count - 1
                For K As Integer = 2 To 4
                    If .Rows(L).Cells(K).Value = "Zéro" Then
                        .Rows(L).Cells(K).Style = StyleVide
                    Else
                        .Rows(L).Cells(K).Style = StyleNum
                    End If
                Next

            End With

            TotPts += Val(LesDir(0))

        Next
        Label3.Text = "Total : " & Str(TotPts)
        MonForm = New frmFormulaire
        MonForm.Popul()
    End Sub

    Private Sub dgQuest_CellClick(sender As Object, _
                                  e As System.Windows.Forms.DataGridViewCellEventArgs) _
                              Handles dgQuest.CellClick
        If e.ColumnIndex <> 6 Then Exit Sub
        Dim UneFormule As String = "Nil"
        Dim L As Integer = e.RowIndex
        If L < 0 Then Exit Sub
        Dim NomQst As String = dgQuest.Rows(L).Cells(0).Value
        'MsgBox(NomQst)
        If L < 0 Then Exit Sub

        With MonForm.DataGridView1
            Try
                Dim UnZone As clZone = MaCollCorr(NomQst)
                UneFormule = UnZone.Formule
                Dim Directive As String = dgQuest.Rows(L).Cells(5).Value
                Dim CodeVal, CodeFormule, CodeFormat As String
                CodeVal = UnZone.ValeurDet
                CodeFormule = UnZone.FormuleDet
                CodeFormat = UnZone.FormatDet

                .Rows(0).Cells(2).Value = OKVal(CodeVal <> PasOK)
                .Rows(0).Cells(3).Value = OKVal(Directive.Contains("VS") And _
                                            .Rows(0).Cells(2).Value = OK)
                .Rows(1).Cells(1).Value = "Proche +/- " & ValProche(Directive, "VP") & "%"

                .Rows(1).Cells(2).Value = OKVal(CodeVal <> PasOK)
                .Rows(1).Cells(3).Value = OKVal(Directive.Contains("VP") And _
                                            .Rows(1).Cells(2).Value = OK)

                Dim VF As Boolean = CodeFormule <> ""
                .Rows(2).Cells(2).Value = OKVal(VF)
                .Rows(2).Cells(3).Value = OKVal(VF And Directive.Contains("FS"))
                .Rows(3).Cells(2).Value = OKVal(CodeFormule.Contains("A"))
                .Rows(3).Cells(3).Value = OKVal(Directive.Contains("FA"))
                .Rows(4).Cells(1).Value = "Contient=" & ValForm(Directive, "F=")
                .Rows(4).Cells(2).Value = OKVal(VF)
                .Rows(4).Cells(3).Value = OKVal(Directive.Contains("F="))

                .Rows(5).Cells(1).Value = "Largeur +/- "
                .Rows(5).Cells(2).Value = OKVal(CodeFormat.Contains("C"))
                .Rows(5).Cells(3).Value = SiOui(Directive, "C")
                .Rows(6).Cells(1).Value = "Hauteur +/- "
                .Rows(6).Cells(2).Value = OKVal(CodeFormat.Contains("L"))
                .Rows(6).Cells(3).Value = SiOui(Directive, "L")
                .Rows(7).Cells(2).Value = OKVal(CodeFormat.Contains("P"))
                .Rows(7).Cells(3).Value = SiOui(Directive, "P")
                .Rows(8).Cells(2).Value = OKVal(CodeFormat.Contains("T"))
                .Rows(8).Cells(3).Value = SiOui(Directive, "T")
                .Rows(9).Cells(2).Value = OKVal(CodeFormat.Contains("N"))
                .Rows(9).Cells(3).Value = SiOui(Directive, "N")
                .Rows(10).Cells(2).Value = OKVal(CodeFormat.Contains("B"))
                .Rows(10).Cells(3).Value = SiOui(Directive, "B")
                .Rows(11).Cells(2).Value = OKVal(CodeFormat.Contains("A"))
                .Rows(11).Cells(3).Value = SiOui(Directive, "A")

            Catch ex As Exception
            End Try
        End With
        If UneFormule = "" Then UneFormule = "(Nil)"
        Dim K As Integer = Math.Min(UneFormule.Length, 56)
        MonForm.Label1.Text = "La formule est : " & UneFormule.Substring(0, K)
        Me.Hide()
        MonForm.ShowDialog()
        Me.Show()
        Dim NouvDir As String = CStr(Val(dgQuest.Rows(L).Cells(1).Value))

        Try

            With MonForm.DataGridView1
                If .Rows(0).Cells(3).Value = OK Then
                    NouvDir &= "/VS/" & CStr(Val(dgQuest.Rows(L).Cells(2).Value))
                ElseIf .Rows(1).Cells(3).Value = OK Then
                    NouvDir &= "/VP=" & ExtrVal(.Rows(1).Cells(1).Value) _
                        & "/" & CStr(Val(dgQuest.Rows(L).Cells(2).Value))
                End If

                If .Rows(4).Cells(3).Value = OK Then
                    Dim Fonc As String = .Rows(4).Cells(1).Value
                    Fonc = Fonc.Remove(0, 9)
                    NouvDir &= "/F=" & Fonc & "/" & CStr(Val(dgQuest.Rows(L).Cells(3).Value))
                ElseIf .Rows(3).Cells(3).Value = OK Then
                    NouvDir &= "/FA/" & CStr(Val(dgQuest.Rows(L).Cells(3).Value))
                ElseIf .Rows(2).Cells(3).Value = OK Then
                    NouvDir &= "/FS/" & CStr(Val(dgQuest.Rows(L).Cells(3).Value))
                End If
                ' CLPTNBA
                Dim CodeForm As String = ""
                'MsgBox(.Rows(5).Cells(3).Value)
                If .Rows(5).Cells(3).Value = OK Then CodeForm &= "C"
                If .Rows(6).Cells(3).Value = OK Then CodeForm &= "L"
                If .Rows(7).Cells(3).Value = OK Then CodeForm &= "P"
                If .Rows(8).Cells(3).Value = OK Then CodeForm &= "T"
                If .Rows(9).Cells(3).Value = OK Then CodeForm &= "N"
                If .Rows(10).Cells(3).Value = OK Then CodeForm &= "B"
                If .Rows(11).Cells(3).Value = OK Then CodeForm &= "A"
                If CodeForm <> "" Then
                    NouvDir &= "/A" & CodeForm & "/" & CStr(Val(dgQuest.Rows(L).Cells(4).Value))
                End If
                dgQuest.Rows(L).Cells(5).Value = NouvDir
                Dim Qst As String = dgQuest.Rows(L).Cells(0).Value
                Dim unzone As clZone = MaCollCorr(Qst)
                unzone.Comm = NouvDir
                SiModif = True
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Function ExtrVal(ByVal Ch As String) As Integer
        Dim L As String = Ch.Length - 1
        Dim Valeur As Integer = 0
        Dim K As Integer = 1
        Do While IsNumeric(Ch.Chars(L))
            Valeur += K * Val(Ch.Chars(L))
            K = K * 10
            L = L - 1
        Loop
    End Function

    Private Function SiOui(ByVal Direc As String, ByVal LeCode As String) As String
        Dim LesComm() As String
        If Direc = "" Then Return PasOK
        LesComm = Direc.Split("/")
        Dim L As Integer = LesComm.Length
        For K As Integer = 1 To L - 2
            Dim St As String = LesComm(K)
            If St.StartsWith("A") Then
                St = St.Remove(0, 1)
                If St.Contains(LeCode) Then
                    Return OK
                End If
            End If
        Next
        Return PasOK
    End Function

    Private Sub dgQuest_CellValueChanged(sender As Object, _
                                         e As DataGridViewCellEventArgs) _
                                     Handles dgQuest.CellValueChanged

        Dim Col As Integer = e.ColumnIndex
        Dim Lig As Integer = e.RowIndex
        If Lig < 0 Then Exit Sub
        If Col < 0 Then Exit Sub
        Select Case Col
            Case 1
                Dim Tot As Integer = 0
                For L As Integer = 0 To dgQuest.Rows.Count - 1
                    If IsNumeric(dgQuest(1, L).Value) Then Tot += dgQuest(1, L).Value
                Next
                Label3.Text = "Total : " & CStr(Tot)
            Case 2, 3, 4
                If dgQuest.Rows(Lig).Cells(Col).Style.BackColor = Color.Aqua Then
                    dgQuest.Rows(Lig).Cells(Col).Value = "Zéro"
                End If
        End Select
    End Sub

    Private Sub TextBox_TextChanged(sender As System.Object, e As System.EventArgs) _
                Handles TextBox4.TextChanged, TextBox3.TextChanged, _
                TextBox2.TextChanged, TextBox1.TextChanged
        SiModif = True
        Q00Ecr()
    End Sub
End Class