<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCorr = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnQuit1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorrFich = New System.Windows.Forms.TextBox()
        Me.txtCorrDossier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblDossEtud = New System.Windows.Forms.Label()
        Me.lblDossFit = New System.Windows.Forms.Label()
        Me.lblDossTrans = New System.Windows.Forms.Label()
        Me.lblDossRecup = New System.Windows.Forms.Label()
        Me.btnCorrFichier = New System.Windows.Forms.Button()
        Me.btnCorrDossier = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPrelim = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabAidePrep = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPrep = New System.Windows.Forms.TabPage()
        Me.btnPrep_Exec = New System.Windows.Forms.Button()
        Me.btnQuit2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrepModel = New System.Windows.Forms.TextBox()
        Me.btnPrepModel = New System.Windows.Forms.Button()
        Me.btnPrepTrav = New System.Windows.Forms.Button()
        Me.txtPrepTrav = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.Label()
        Me.TabAideCorr = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabCorr = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPrelim.SuspendLayout()
        Me.TabAidePrep.SuspendLayout()
        Me.TabPrep.SuspendLayout()
        Me.TabAideCorr.SuspendLayout()
        Me.TabCorr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correction de classeurs Excel"
        '
        'btnCorr
        '
        Me.btnCorr.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorr.Location = New System.Drawing.Point(360, 618)
        Me.btnCorr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCorr.Name = "btnCorr"
        Me.btnCorr.Size = New System.Drawing.Size(279, 55)
        Me.btnCorr.TabIndex = 1
        Me.btnCorr.Text = "Exécuter"
        Me.btnCorr.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnQuit1
        '
        Me.btnQuit1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnQuit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit1.Location = New System.Drawing.Point(828, 618)
        Me.btnQuit1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit1.Name = "btnQuit1"
        Me.btnQuit1.Size = New System.Drawing.Size(182, 51)
        Me.btnQuit1.TabIndex = 3
        Me.btnQuit1.Text = "Quitter"
        Me.btnQuit1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fichier de correction"
        '
        'txtCorrFich
        '
        Me.txtCorrFich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrFich.Location = New System.Drawing.Point(245, 211)
        Me.txtCorrFich.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorrFich.Name = "txtCorrFich"
        Me.txtCorrFich.Size = New System.Drawing.Size(606, 30)
        Me.txtCorrFich.TabIndex = 6
        '
        'txtCorrDossier
        '
        Me.txtCorrDossier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrDossier.Location = New System.Drawing.Point(245, 121)
        Me.txtCorrDossier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorrDossier.Name = "txtCorrDossier"
        Me.txtCorrDossier.Size = New System.Drawing.Size(606, 30)
        Me.txtCorrDossier.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dossier des fichiers"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'lblDossEtud
        '
        Me.lblDossEtud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDossEtud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDossEtud.Location = New System.Drawing.Point(277, 364)
        Me.lblDossEtud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDossEtud.Name = "lblDossEtud"
        Me.lblDossEtud.Size = New System.Drawing.Size(501, 43)
        Me.lblDossEtud.TabIndex = 9
        Me.lblDossEtud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDossFit
        '
        Me.lblDossFit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDossFit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDossFit.Location = New System.Drawing.Point(277, 450)
        Me.lblDossFit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDossFit.Name = "lblDossFit"
        Me.lblDossFit.Size = New System.Drawing.Size(501, 43)
        Me.lblDossFit.TabIndex = 10
        Me.lblDossFit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDossTrans
        '
        Me.lblDossTrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDossTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDossTrans.Location = New System.Drawing.Point(277, 407)
        Me.lblDossTrans.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDossTrans.Name = "lblDossTrans"
        Me.lblDossTrans.Size = New System.Drawing.Size(501, 43)
        Me.lblDossTrans.TabIndex = 11
        Me.lblDossTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDossRecup
        '
        Me.lblDossRecup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDossRecup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDossRecup.Location = New System.Drawing.Point(276, 493)
        Me.lblDossRecup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDossRecup.Name = "lblDossRecup"
        Me.lblDossRecup.Size = New System.Drawing.Size(501, 43)
        Me.lblDossRecup.TabIndex = 12
        Me.lblDossRecup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCorrFichier
        '
        Me.btnCorrFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrFichier.Location = New System.Drawing.Point(878, 205)
        Me.btnCorrFichier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCorrFichier.Name = "btnCorrFichier"
        Me.btnCorrFichier.Size = New System.Drawing.Size(139, 43)
        Me.btnCorrFichier.TabIndex = 13
        Me.btnCorrFichier.Text = "Parcourir"
        Me.btnCorrFichier.UseVisualStyleBackColor = True
        '
        'btnCorrDossier
        '
        Me.btnCorrDossier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrDossier.Location = New System.Drawing.Point(878, 116)
        Me.btnCorrDossier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCorrDossier.Name = "btnCorrDossier"
        Me.btnCorrDossier.Size = New System.Drawing.Size(139, 43)
        Me.btnCorrDossier.TabIndex = 14
        Me.btnCorrDossier.Text = "Parcourir"
        Me.btnCorrDossier.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPrelim)
        Me.TabControl1.Controls.Add(Me.TabAidePrep)
        Me.TabControl1.Controls.Add(Me.TabPrep)
        Me.TabControl1.Controls.Add(Me.TabAideCorr)
        Me.TabControl1.Controls.Add(Me.TabCorr)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1045, 740)
        Me.TabControl1.TabIndex = 15
        '
        'TabPrelim
        '
        Me.TabPrelim.Controls.Add(Me.Label4)
        Me.TabPrelim.Location = New System.Drawing.Point(4, 34)
        Me.TabPrelim.Name = "TabPrelim"
        Me.TabPrelim.Size = New System.Drawing.Size(1037, 702)
        Me.TabPrelim.TabIndex = 3
        Me.TabPrelim.Text = "Préliminaires"
        Me.TabPrelim.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(805, 284)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'TabAidePrep
        '
        Me.TabAidePrep.Controls.Add(Me.Label7)
        Me.TabAidePrep.Location = New System.Drawing.Point(4, 34)
        Me.TabAidePrep.Name = "TabAidePrep"
        Me.TabAidePrep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAidePrep.Size = New System.Drawing.Size(1037, 702)
        Me.TabAidePrep.TabIndex = 2
        Me.TabAidePrep.Text = "Aide Prép"
        Me.TabAidePrep.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(805, 406)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'TabPrep
        '
        Me.TabPrep.Controls.Add(Me.btnPrep_Exec)
        Me.TabPrep.Controls.Add(Me.btnQuit2)
        Me.TabPrep.Controls.Add(Me.Label6)
        Me.TabPrep.Controls.Add(Me.Label5)
        Me.TabPrep.Controls.Add(Me.txtPrepModel)
        Me.TabPrep.Controls.Add(Me.btnPrepModel)
        Me.TabPrep.Controls.Add(Me.btnPrepTrav)
        Me.TabPrep.Controls.Add(Me.txtPrepTrav)
        Me.TabPrep.Controls.Add(Me.txtModel)
        Me.TabPrep.Location = New System.Drawing.Point(4, 34)
        Me.TabPrep.Name = "TabPrep"
        Me.TabPrep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrep.Size = New System.Drawing.Size(1037, 702)
        Me.TabPrep.TabIndex = 1
        Me.TabPrep.Text = "Préparation"
        Me.TabPrep.UseVisualStyleBackColor = True
        '
        'btnPrep_Exec
        '
        Me.btnPrep_Exec.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPrep_Exec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrep_Exec.Location = New System.Drawing.Point(410, 587)
        Me.btnPrep_Exec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrep_Exec.Name = "btnPrep_Exec"
        Me.btnPrep_Exec.Size = New System.Drawing.Size(279, 55)
        Me.btnPrep_Exec.TabIndex = 21
        Me.btnPrep_Exec.Text = "Exécuter"
        Me.btnPrep_Exec.UseVisualStyleBackColor = False
        '
        'btnQuit2
        '
        Me.btnQuit2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnQuit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit2.Location = New System.Drawing.Point(795, 587)
        Me.btnQuit2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit2.Name = "btnQuit2"
        Me.btnQuit2.Size = New System.Drawing.Size(182, 51)
        Me.btnQuit2.TabIndex = 20
        Me.btnQuit2.Text = "Quitter"
        Me.btnQuit2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(375, 39)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Préparation du corrigé"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fichier de travail :"
        '
        'txtPrepModel
        '
        Me.txtPrepModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrepModel.Location = New System.Drawing.Point(235, 291)
        Me.txtPrepModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrepModel.Name = "txtPrepModel"
        Me.txtPrepModel.Size = New System.Drawing.Size(606, 30)
        Me.txtPrepModel.TabIndex = 17
        '
        'btnPrepModel
        '
        Me.btnPrepModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepModel.Location = New System.Drawing.Point(863, 285)
        Me.btnPrepModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrepModel.Name = "btnPrepModel"
        Me.btnPrepModel.Size = New System.Drawing.Size(139, 43)
        Me.btnPrepModel.TabIndex = 16
        Me.btnPrepModel.Text = "Parcourir"
        Me.btnPrepModel.UseVisualStyleBackColor = True
        '
        'btnPrepTrav
        '
        Me.btnPrepTrav.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepTrav.Location = New System.Drawing.Point(863, 151)
        Me.btnPrepTrav.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrepTrav.Name = "btnPrepTrav"
        Me.btnPrepTrav.Size = New System.Drawing.Size(139, 43)
        Me.btnPrepTrav.TabIndex = 15
        Me.btnPrepTrav.Text = "Parcourir"
        Me.btnPrepTrav.UseVisualStyleBackColor = True
        '
        'txtPrepTrav
        '
        Me.txtPrepTrav.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrepTrav.Location = New System.Drawing.Point(235, 157)
        Me.txtPrepTrav.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrepTrav.Name = "txtPrepTrav"
        Me.txtPrepTrav.Size = New System.Drawing.Size(606, 30)
        Me.txtPrepTrav.TabIndex = 9
        '
        'txtModel
        '
        Me.txtModel.AutoSize = True
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(61, 296)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(166, 25)
        Me.txtModel.TabIndex = 6
        Me.txtModel.Text = "Fichier modèle :"
        '
        'TabAideCorr
        '
        Me.TabAideCorr.Controls.Add(Me.Label8)
        Me.TabAideCorr.Location = New System.Drawing.Point(4, 34)
        Me.TabAideCorr.Name = "TabAideCorr"
        Me.TabAideCorr.Size = New System.Drawing.Size(1037, 702)
        Me.TabAideCorr.TabIndex = 4
        Me.TabAideCorr.Text = "Aide Corr"
        Me.TabAideCorr.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(805, 406)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'TabCorr
        '
        Me.TabCorr.Controls.Add(Me.Label9)
        Me.TabCorr.Controls.Add(Me.RadioButton2)
        Me.TabCorr.Controls.Add(Me.RadioButton1)
        Me.TabCorr.Controls.Add(Me.txtCorrDossier)
        Me.TabCorr.Controls.Add(Me.btnCorrDossier)
        Me.TabCorr.Controls.Add(Me.Label1)
        Me.TabCorr.Controls.Add(Me.btnCorrFichier)
        Me.TabCorr.Controls.Add(Me.btnCorr)
        Me.TabCorr.Controls.Add(Me.lblDossRecup)
        Me.TabCorr.Controls.Add(Me.btnQuit1)
        Me.TabCorr.Controls.Add(Me.lblDossTrans)
        Me.TabCorr.Controls.Add(Me.Label2)
        Me.TabCorr.Controls.Add(Me.lblDossFit)
        Me.TabCorr.Controls.Add(Me.txtCorrFich)
        Me.TabCorr.Controls.Add(Me.lblDossEtud)
        Me.TabCorr.Controls.Add(Me.Label3)
        Me.TabCorr.Location = New System.Drawing.Point(4, 34)
        Me.TabCorr.Name = "TabCorr"
        Me.TabCorr.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCorr.Size = New System.Drawing.Size(1037, 702)
        Me.TabCorr.TabIndex = 0
        Me.TabCorr.Text = "Correction"
        Me.TabCorr.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 584)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Avec / sans évaluation  :"
        Me.Label9.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(524, 581)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 29)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Avec"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(661, 581)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 29)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sans"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 737)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPrelim.ResumeLayout(False)
        Me.TabAidePrep.ResumeLayout(False)
        Me.TabPrep.ResumeLayout(False)
        Me.TabPrep.PerformLayout()
        Me.TabAideCorr.ResumeLayout(False)
        Me.TabCorr.ResumeLayout(False)
        Me.TabCorr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCorr As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnQuit1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorrFich As System.Windows.Forms.TextBox
    Friend WithEvents txtCorrDossier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblDossEtud As System.Windows.Forms.Label
    Friend WithEvents lblDossFit As System.Windows.Forms.Label
    Friend WithEvents lblDossTrans As System.Windows.Forms.Label
    Friend WithEvents lblDossRecup As System.Windows.Forms.Label
    Friend WithEvents btnCorrFichier As System.Windows.Forms.Button
    Friend WithEvents btnCorrDossier As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabCorr As System.Windows.Forms.TabPage
    Friend WithEvents TabPrep As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrepModel As System.Windows.Forms.TextBox
    Friend WithEvents btnPrepModel As System.Windows.Forms.Button
    Friend WithEvents btnPrepTrav As System.Windows.Forms.Button
    Friend WithEvents txtPrepTrav As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.Label
    Friend WithEvents TabAidePrep As System.Windows.Forms.TabPage
    Friend WithEvents btnPrep_Exec As System.Windows.Forms.Button
    Friend WithEvents btnQuit2 As System.Windows.Forms.Button
    Friend WithEvents TabPrelim As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabAideCorr As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
