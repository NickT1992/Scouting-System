<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditScout
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
        Me.lbScouts = New System.Windows.Forms.ListBox()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.cmbClub = New System.Windows.Forms.ComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnDeleteScout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnAddNewScout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbScouts
        '
        Me.lbScouts.FormattingEnabled = True
        Me.lbScouts.Location = New System.Drawing.Point(12, 12)
        Me.lbScouts.Name = "lbScouts"
        Me.lbScouts.Size = New System.Drawing.Size(290, 303)
        Me.lbScouts.TabIndex = 2
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(319, 181)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(31, 13)
        Me.lblClub.TabIndex = 56
        Me.lblClub.Text = "Club:"
        '
        'cmbClub
        '
        Me.cmbClub.FormattingEnabled = True
        Me.cmbClub.Location = New System.Drawing.Point(320, 197)
        Me.cmbClub.Name = "cmbClub"
        Me.cmbClub.Size = New System.Drawing.Size(131, 21)
        Me.cmbClub.TabIndex = 55
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(319, 121)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(76, 13)
        Me.lblEmail.TabIndex = 58
        Me.lblEmail.Text = "Email Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(322, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(163, 20)
        Me.txtEmail.TabIndex = 57
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(319, 12)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(91, 13)
        Me.lblFirstName.TabIndex = 51
        Me.lblFirstName.Text = "Scout First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(322, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstName.TabIndex = 52
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(319, 70)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(83, 13)
        Me.lblSurname.TabIndex = 53
        Me.lblSurname.Text = "Scout Surname:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(322, 88)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(163, 20)
        Me.txtSurname.TabIndex = 54
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(563, 331)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(97, 23)
        Me.btnConfirm.TabIndex = 50
        Me.btnConfirm.Text = "Confirm Changes"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnDeleteScout
        '
        Me.btnDeleteScout.Location = New System.Drawing.Point(12, 331)
        Me.btnDeleteScout.Name = "btnDeleteScout"
        Me.btnDeleteScout.Size = New System.Drawing.Size(97, 23)
        Me.btnDeleteScout.TabIndex = 48
        Me.btnDeleteScout.Text = "Delete Scout"
        Me.btnDeleteScout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Scout Role:"
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(320, 255)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(163, 20)
        Me.txtRole.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(498, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(501, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(163, 20)
        Me.txtUsername.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(501, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(163, 20)
        Me.txtPassword.TabIndex = 63
        '
        'btnAddNewScout
        '
        Me.btnAddNewScout.Location = New System.Drawing.Point(205, 331)
        Me.btnAddNewScout.Name = "btnAddNewScout"
        Me.btnAddNewScout.Size = New System.Drawing.Size(97, 23)
        Me.btnAddNewScout.TabIndex = 67
        Me.btnAddNewScout.Text = "Add New Scout"
        Me.btnAddNewScout.UseVisualStyleBackColor = True
        '
        'frmEditScout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 366)
        Me.Controls.Add(Me.btnAddNewScout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.lblClub)
        Me.Controls.Add(Me.cmbClub)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnDeleteScout)
        Me.Controls.Add(Me.lbScouts)
        Me.Name = "frmEditScout"
        Me.Text = "Edit Scout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbScouts As System.Windows.Forms.ListBox
    Friend WithEvents lblClub As System.Windows.Forms.Label
    Friend WithEvents cmbClub As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnDeleteScout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRole As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNewScout As System.Windows.Forms.Button
End Class
