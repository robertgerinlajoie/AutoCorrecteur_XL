<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulaire
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
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(266, 442)
        Me.btnFermer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(100, 28)
        Me.btnFermer.TabIndex = 1
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colSub, Me.SiDiff, Me.ColSel, Me.colPts})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(677, 372)
        Me.DataGridView1.TabIndex = 2
        '
        'colType
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colType.DefaultCellStyle = DataGridViewCellStyle1
        Me.colType.HeaderText = "TypeModif"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        '
        'colSub
        '
        Me.colSub.HeaderText = "Sous_Type"
        Me.colSub.Name = "colSub"
        Me.colSub.ReadOnly = True
        Me.colSub.Width = 200
        '
        'SiDiff
        '
        Me.SiDiff.HeaderText = "Différent?"
        Me.SiDiff.Name = "SiDiff"
        Me.SiDiff.ReadOnly = True
        Me.SiDiff.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColSel
        '
        Me.ColSel.FillWeight = 30.0!
        Me.ColSel.HeaderText = "Évalué?"
        Me.ColSel.Name = "ColSel"
        Me.ColSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPts
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPts.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPts.HeaderText = "Nb Points"
        Me.colPts.Name = "colPts"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(653, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "La formule est : "
        '
        'frmFormulaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 483)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFermer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFormulaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiDiff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPts As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
