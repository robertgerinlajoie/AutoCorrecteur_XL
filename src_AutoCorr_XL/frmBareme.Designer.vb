<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBareme
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBareme))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgQuest = New System.Windows.Forms.DataGridView()
        Me.colQST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNbPoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDirect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVisual = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barème"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgQuest
        '
        Me.dgQuest.AllowUserToAddRows = False
        Me.dgQuest.AllowUserToDeleteRows = False
        Me.dgQuest.AllowUserToOrderColumns = True
        Me.dgQuest.AllowUserToResizeRows = False
        Me.dgQuest.CausesValidation = False
        Me.dgQuest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQuest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colQST, Me.colNbPoints, Me.colVal, Me.colFormule, Me.colFormat, Me.colDirect, Me.colVisual})
        Me.dgQuest.Location = New System.Drawing.Point(23, 348)
        Me.dgQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgQuest.Name = "dgQuest"
        Me.dgQuest.RowTemplate.Height = 24
        Me.dgQuest.Size = New System.Drawing.Size(873, 386)
        Me.dgQuest.TabIndex = 1
        '
        'colQST
        '
        Me.colQST.HeaderText = "Question"
        Me.colQST.MaxInputLength = 4
        Me.colQST.MinimumWidth = 40
        Me.colQST.Name = "colQST"
        Me.colQST.ToolTipText = "Nom de la plage-question"
        Me.colQST.Width = 80
        '
        'colNbPoints
        '
        Me.colNbPoints.HeaderText = "Pts_Qst"
        Me.colNbPoints.MaxInputLength = 3
        Me.colNbPoints.MinimumWidth = 40
        Me.colNbPoints.Name = "colNbPoints"
        Me.colNbPoints.ToolTipText = "Nombre de point pour la question"
        Me.colNbPoints.Width = 70
        '
        'colVal
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colVal.DefaultCellStyle = DataGridViewCellStyle1
        Me.colVal.HeaderText = "PtsVal"
        Me.colVal.MaxInputLength = 3
        Me.colVal.MinimumWidth = 40
        Me.colVal.Name = "colVal"
        Me.colVal.ToolTipText = "Nb de points enlevés"
        Me.colVal.Width = 70
        '
        'colFormule
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFormule.DefaultCellStyle = DataGridViewCellStyle2
        Me.colFormule.HeaderText = "PtsFormule"
        Me.colFormule.MaxInputLength = 3
        Me.colFormule.MinimumWidth = 40
        Me.colFormule.Name = "colFormule"
        Me.colFormule.ToolTipText = "Nb de points enlevés"
        Me.colFormule.Width = 70
        '
        'colFormat
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFormat.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFormat.HeaderText = "PtsFormat"
        Me.colFormat.MaxInputLength = 3
        Me.colFormat.MinimumWidth = 40
        Me.colFormat.Name = "colFormat"
        Me.colFormat.ToolTipText = "Nb de points enlevés"
        Me.colFormat.Width = 70
        '
        'colDirect
        '
        Me.colDirect.HeaderText = "Directive"
        Me.colDirect.MaxInputLength = 32
        Me.colDirect.Name = "colDirect"
        Me.colDirect.ReadOnly = True
        Me.colDirect.ToolTipText = "Commentaire de la plage"
        Me.colDirect.Width = 200
        '
        'colVisual
        '
        Me.colVisual.HeaderText = "Visualiser"
        Me.colVisual.Name = "colVisual"
        Me.colVisual.Text = "Détails"
        Me.colVisual.UseColumnTextForButtonValue = True
        Me.colVisual.Width = 80
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(604, 109)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 745)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total : 0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFermer
        '
        Me.btnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermer.Location = New System.Drawing.Point(741, 762)
        Me.btnFermer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(155, 46)
        Me.btnFermer.TabIndex = 4
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(445, 182)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 24)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(445, 224)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 24)
        Me.TextBox2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SUPPRIMÉES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "AJOUTÉES"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(232, 224)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(186, 24)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(232, 182)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 24)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "NUMÉROS de LIGNES :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NUMÉROS de COLONNES :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(875, 57)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Les zones de couleur indiquent qu'il n'y a pas de changement et donc la valeur es" & _
    "t «0». Les autres valeurs seront des points «perdus» jusqu'à concurrence du nomb" & _
    "re de points pour la question."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox0
        '
        Me.TextBox0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox0.Location = New System.Drawing.Point(232, 256)
        Me.TextBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(399, 24)
        Me.TextBox0.TabIndex = 14
        Me.TextBox0.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Code enregistré :"
        '
        'frmBareme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 832)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgQuest)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmBareme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détermination du bareme"
        CType(Me.dgQuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgQuest As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents colQST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNbPoints As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDirect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVisual As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
