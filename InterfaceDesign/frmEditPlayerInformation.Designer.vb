<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPlayerInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDeletePlayer = New System.Windows.Forms.Button()
        Me.lbPlayers = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.pcbEditPlayer = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.cmbClub = New System.Windows.Forms.ComboBox()
        Me.lblPlaceOfBirth = New System.Windows.Forms.Label()
        Me.txtPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        CType(Me.pcbEditPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeletePlayer
        '
        Me.btnDeletePlayer.Location = New System.Drawing.Point(348, 331)
        Me.btnDeletePlayer.Name = "btnDeletePlayer"
        Me.btnDeletePlayer.Size = New System.Drawing.Size(97, 23)
        Me.btnDeletePlayer.TabIndex = 0
        Me.btnDeletePlayer.Text = "Delete Player"
        Me.btnDeletePlayer.UseVisualStyleBackColor = True
        '
        'lbPlayers
        '
        Me.lbPlayers.FormattingEnabled = True
        Me.lbPlayers.Location = New System.Drawing.Point(31, 12)
        Me.lbPlayers.Name = "lbPlayers"
        Me.lbPlayers.Size = New System.Drawing.Size(290, 342)
        Me.lbPlayers.TabIndex = 1
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(551, 331)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(97, 23)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm Changes"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'pcbEditPlayer
        '
        Me.pcbEditPlayer.Location = New System.Drawing.Point(348, 12)
        Me.pcbEditPlayer.Name = "pcbEditPlayer"
        Me.pcbEditPlayer.Size = New System.Drawing.Size(129, 145)
        Me.pcbEditPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbEditPlayer.TabIndex = 3
        Me.pcbEditPlayer.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(380, 163)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(516, 226)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(31, 13)
        Me.lblClub.TabIndex = 43
        Me.lblClub.Text = "Club:"
        '
        'cmbClub
        '
        Me.cmbClub.FormattingEnabled = True
        Me.cmbClub.Location = New System.Drawing.Point(517, 242)
        Me.cmbClub.Name = "cmbClub"
        Me.cmbClub.Size = New System.Drawing.Size(131, 21)
        Me.cmbClub.TabIndex = 42
        '
        'lblPlaceOfBirth
        '
        Me.lblPlaceOfBirth.AutoSize = True
        Me.lblPlaceOfBirth.Location = New System.Drawing.Point(516, 121)
        Me.lblPlaceOfBirth.Name = "lblPlaceOfBirth"
        Me.lblPlaceOfBirth.Size = New System.Drawing.Size(73, 13)
        Me.lblPlaceOfBirth.TabIndex = 47
        Me.lblPlaceOfBirth.Text = "Place of Birth:"
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(519, 142)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(131, 20)
        Me.txtPlaceOfBirth.TabIndex = 46
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(516, 175)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(39, 13)
        Me.lblDOB.TabIndex = 45
        Me.lblDOB.Text = "D.O.B:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(517, 193)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(131, 20)
        Me.dtpDOB.TabIndex = 44
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(516, 12)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(92, 13)
        Me.lblFirstName.TabIndex = 38
        Me.lblFirstName.Text = "Player First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(519, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(131, 20)
        Me.txtFirstName.TabIndex = 39
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(516, 70)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(84, 13)
        Me.lblSurname.TabIndex = 40
        Me.lblSurname.Text = "Player Surname:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(519, 88)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(131, 20)
        Me.txtSurname.TabIndex = 41
        '
        'frmEditPlayerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 366)
        Me.Controls.Add(Me.lblClub)
        Me.Controls.Add(Me.cmbClub)
        Me.Controls.Add(Me.lblPlaceOfBirth)
        Me.Controls.Add(Me.txtPlaceOfBirth)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.pcbEditPlayer)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lbPlayers)
        Me.Controls.Add(Me.btnDeletePlayer)
        Me.Name = "frmEditPlayerInformation"
        Me.Text = "Edit Player Information"
        CType(Me.pcbEditPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeletePlayer As System.Windows.Forms.Button
    Friend WithEvents lbPlayers As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents pcbEditPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblClub As System.Windows.Forms.Label
    Friend WithEvents cmbClub As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlaceOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtPlaceOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
End Class
