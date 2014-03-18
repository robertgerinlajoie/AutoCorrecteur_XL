Public Class frmFormulaire

    Public Sub Popul()
        'Dim Nb As Integer

        With DataGridView1
            Try

                .Rows.Add(New Object() {"Valeur", "Stricte", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Proche +/- ", PasOK, PasOK, 0})

                .Rows.Add(New Object() {"Formule", "Libre", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Absolue", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Contenu=", PasOK, PasOK, 0})

                .Rows.Add(New Object() {"Format", "Largeur +/- ", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Hauteur +/- ", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Police", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Trame", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Format numérique", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Bordure", PasOK, PasOK, 0})
                .Rows.Add(New Object() {"", "Alignement H/V", PasOK, PasOK, 0})

            Catch ex As Exception
                MsgBox("Bof")
            End Try
        End With
    End Sub

    Private Sub btnFermer_Click(sender As System.Object, e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, _
                e As System.Windows.Forms.DataGridViewCellEventArgs) _
                Handles DataGridView1.CellValueChanged
        Dim Ligne As Integer = e.RowIndex
        If Ligne < 0 Then Exit Sub
        Dim Col As Integer = e.ColumnIndex

        If Col <> 4 Then Exit Sub

        DataGridView1.Rows(Ligne).Cells(4).Value = 0

    End Sub

    Private Function GetMarge(ByVal UnMess As String, _
                           ByVal SiPct As Boolean) As String
        Dim Rep As String = "X"
        While Not IsNumeric(Rep)
            Rep = InputBox(UnMess)
            If Rep = "" Then Return ""
            Dim Pos As Integer = Rep.IndexOf("%")
            If Pos > -1 Then Rep = Rep.Remove(Pos)
        End While
        If SiPct Then Rep = Rep & ("%")
        Return Rep

    End Function

    Private Sub DataGridView1_CellClick(sender As Object, _
                                    e As DataGridViewCellEventArgs) _
                                    Handles DataGridView1.CellClick
        Dim Ligne As Integer = e.RowIndex
        If Ligne < 0 Then
            ' MsgBox("Zut alors")
            Exit Sub
        End If
        Dim Col As Integer = e.ColumnIndex
        If Col < 1 Or Col > 3 Then Exit Sub
        Dim Rep As String
        Select Case Col
            Case 1
                If DataGridView1.Rows(Ligne).Cells(3).Value = PasOK Then Exit Sub
                Select Case Ligne
                    Case 1 ' Valeur proche

                        DataGridView1.Rows(1).Cells(1).Value = "Proche=" & _
                            GetMarge("Entrez la marge d'erreur (pct)", True)

                    Case 4 ' Formule contient...
                        Rep = InputBox("Entrez le nom requis (plage ou fonction)")
                        If Rep <> "" Then
                            If Label1.Text.ToLower.Contains(Rep.ToLower) Then
                                DataGridView1.Rows(4).Cells(1).Value = "Contient=" & Rep.ToLower
                            Else
                                MsgBox("Attention : ce nom n'est pas dans la formule")
                            End If
                        Else
                            DataGridView1.Rows(4).Cells(1).Value = "Contient="
                        End If

                    Case 5 ' Marge sur Largeur
                        DataGridView1.Rows(5).Cells(1).Value = "Largeur +/- " & _
                              GetMarge("Entrez la marge d'erreur (pct)", True)

                    Case 6 ' Marge sur Hauteur
                        DataGridView1.Rows(6).Cells(1).Value = "Hauteur +/- " & _
                              GetMarge("Entrez la marge d'erreur (pct)", True)

                End Select

            Case 3
                If DataGridView1.Rows(Ligne).Cells(2).Value = PasOK Then
                    DataGridView1.Rows(Ligne).Cells(3).Value = PasOK
                    Exit Sub
                End If
                DataGridView1.Rows(Ligne).Cells(3).Value = Inv(DataGridView1.Rows(Ligne).Cells(3).Value)
                Select Case Ligne
                    Case 0, 1  ' Valeur stricte ou sproche
                        If DataGridView1.Rows(Ligne).Cells(3).Value <> PasOK Then _
                            DataGridView1.Rows(1 - Ligne).Cells(3).Value = PasOK
                    Case 2, 3, 4 ' Formule libre, absolue ou à contenu 
                        If DataGridView1.Rows(Ligne).Cells(3).Value = OK Then
                            DataGridView1.Rows(Suiv(Ligne)).Cells(3).Value = PasOK
                            DataGridView1.Rows(Suiv(Suiv(Ligne))).Cells(3).Value = PasOK
                        End If

                End Select
        End Select

    End Sub

    Private Function Suiv(ByVal N As Integer) As Integer
        N += 1
        If N = 5 Then N = 2
        Suiv = N
    End Function
  
End Class