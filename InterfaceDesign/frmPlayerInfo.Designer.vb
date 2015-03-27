<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayerInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.lblQuickSearch = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPlayerClub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbPlayerTeam = New System.Windows.Forms.ComboBox()
        Me.lblRefinedSearch = New System.Windows.Forms.Label()
        Me.btnAttributesSearch = New System.Windows.Forms.Button()
        Me.btnQuickSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbPlayers = New System.Windows.Forms.ListBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblScoutName = New System.Windows.Forms.Label()
        Me.lblScoutRole = New System.Windows.Forms.Label()
        Me.TTSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkSearchPlayer = New System.Windows.Forms.CheckBox()
        Me.UC_Menu_Scout1 = New InterfaceDesign.UC_Menu_Scout()
        Me.SuspendLayout()
        '
        'lblQuickSearch
        '
        Me.lblQuickSearch.AutoSize = True
        Me.lblQuickSearch.Location = New System.Drawing.Point(884, 57)
        Me.lblQuickSearch.Name = "lblQuickSearch"
        Me.lblQuickSearch.Size = New System.Drawing.Size(72, 13)
        Me.lblQuickSearch.TabIndex = 1
        Me.lblQuickSearch.Text = "Quick Search"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(884, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Surname:"
        '
        'lblPlayerClub
        '
        Me.lblPlayerClub.AutoSize = True
        Me.lblPlayerClub.Location = New System.Drawing.Point(884, 182)
        Me.lblPlayerClub.Name = "lblPlayerClub"
        Me.lblPlayerClub.Size = New System.Drawing.Size(31, 13)
        Me.lblPlayerClub.TabIndex = 4
        Me.lblPlayerClub.Text = "Club:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(936, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 20)
        Me.txtName.TabIndex = 6
        '
        'cmbPlayerTeam
        '
        Me.cmbPlayerTeam.FormattingEnabled = True
        Me.cmbPlayerTeam.Location = New System.Drawing.Point(936, 179)
        Me.cmbPlayerTeam.Name = "cmbPlayerTeam"
        Me.cmbPlayerTeam.Size = New System.Drawing.Size(120, 21)
        Me.cmbPlayerTeam.TabIndex = 8
        Me.TTSearch.SetToolTip(Me.cmbPlayerTeam, "View all scouted players within the selected club.")
        '
        'lblRefinedSearch
        '
        Me.lblRefinedSearch.AutoSize = True
        Me.lblRefinedSearch.Location = New System.Drawing.Point(884, 154)
        Me.lblRefinedSearch.Name = "lblRefinedSearch"
        Me.lblRefinedSearch.Size = New System.Drawing.Size(81, 13)
        Me.lblRefinedSearch.TabIndex = 10
        Me.lblRefinedSearch.Text = "Refined Search"
        '
        'btnAttributesSearch
        '
        Me.btnAttributesSearch.Location = New System.Drawing.Point(898, 545)
        Me.btnAttributesSearch.Name = "btnAttributesSearch"
        Me.btnAttributesSearch.Size = New System.Drawing.Size(161, 23)
        Me.btnAttributesSearch.TabIndex = 22
        Me.btnAttributesSearch.Text = "Search By Attributes"
        Me.TTSearch.SetToolTip(Me.btnAttributesSearch, "Click to build a customisable query.")
        Me.btnAttributesSearch.UseVisualStyleBackColor = True
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.Location = New System.Drawing.Point(992, 111)
        Me.btnQuickSearch.Name = "btnQuickSearch"
        Me.btnQuickSearch.Size = New System.Drawing.Size(64, 23)
        Me.btnQuickSearch.TabIndex = 24
        Me.btnQuickSearch.Text = "Search"
        Me.TTSearch.SetToolTip(Me.btnQuickSearch, "Click to search for the specified player surname.")
        Me.btnQuickSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(895, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 2)
        Me.Label1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(895, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 2)
        Me.Label2.TabIndex = 26
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbPlayers
        '
        Me.lbPlayers.FormattingEnabled = True
        Me.lbPlayers.Location = New System.Drawing.Point(898, 238)
        Me.lbPlayers.Name = "lbPlayers"
        Me.lbPlayers.Size = New System.Drawing.Size(160, 290)
        Me.lbPlayers.TabIndex = 30
        Me.TTSearch.SetToolTip(Me.lbPlayers, "Select the desired player to view their reports. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Scouts will be limited to the" & _
        "ir own reports.")
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.AliceBlue
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(321, 6)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(104, 13)
        Me.lblEmail.TabIndex = 31
        Me.lblEmail.Text = "Scout Email Address"
        '
        'lblScoutName
        '
        Me.lblScoutName.AutoSize = True
        Me.lblScoutName.BackColor = System.Drawing.Color.AliceBlue
        Me.lblScoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoutName.ForeColor = System.Drawing.Color.Black
        Me.lblScoutName.Location = New System.Drawing.Point(165, 6)
        Me.lblScoutName.Name = "lblScoutName"
        Me.lblScoutName.Size = New System.Drawing.Size(66, 13)
        Me.lblScoutName.TabIndex = 32
        Me.lblScoutName.Text = "Scout Name"
        '
        'lblScoutRole
        '
        Me.lblScoutRole.AutoSize = True
        Me.lblScoutRole.BackColor = System.Drawing.Color.AliceBlue
        Me.lblScoutRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoutRole.ForeColor = System.Drawing.Color.Black
        Me.lblScoutRole.Location = New System.Drawing.Point(12, 6)
        Me.lblScoutRole.Name = "lblScoutRole"
        Me.lblScoutRole.Size = New System.Drawing.Size(60, 13)
        Me.lblScoutRole.TabIndex = 33
        Me.lblScoutRole.Text = "Scout Role"
        '
        'chkSearchPlayer
        '
        Me.chkSearchPlayer.AutoSize = True
        Me.chkSearchPlayer.Enabled = False
        Me.chkSearchPlayer.Location = New System.Drawing.Point(462, 34)
        Me.chkSearchPlayer.Name = "chkSearchPlayer"
        Me.chkSearchPlayer.Size = New System.Drawing.Size(107, 17)
        Me.chkSearchPlayer.TabIndex = 34
        Me.chkSearchPlayer.Text = "Search By Player"
        Me.TTSearch.SetToolTip(Me.chkSearchPlayer, "Check the box to view reports based on a player, rather than a fixture.")
        Me.chkSearchPlayer.UseVisualStyleBackColor = True
        '
        'UC_Menu_Scout1
        '
        Me.UC_Menu_Scout1.Location = New System.Drawing.Point(0, 34)
        Me.UC_Menu_Scout1.Name = "UC_Menu_Scout1"
        Me.UC_Menu_Scout1.Size = New System.Drawing.Size(879, 547)
        Me.UC_Menu_Scout1.TabIndex = 29
        '
        'frmPlayerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1074, 580)
        Me.Controls.Add(Me.chkSearchPlayer)
        Me.Controls.Add(Me.lblScoutRole)
        Me.Controls.Add(Me.lblScoutName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lbPlayers)
        Me.Controls.Add(Me.UC_Menu_Scout1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuickSearch)
        Me.Controls.Add(Me.btnAttributesSearch)
        Me.Controls.Add(Me.lblRefinedSearch)
        Me.Controls.Add(Me.cmbPlayerTeam)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPlayerClub)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblQuickSearch)
        Me.Name = "frmPlayerInfo"
        Me.Text = "Player Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuickSearch As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPlayerClub As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbPlayerTeam As System.Windows.Forms.ComboBox
    Friend WithEvents lblRefinedSearch As System.Windows.Forms.Label
    Friend WithEvents btnAttributesSearch As System.Windows.Forms.Button
    Friend WithEvents btnQuickSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents UC_Menu_Scout1 As InterfaceDesign.UC_Menu_Scout
    Friend WithEvents lbPlayers As System.Windows.Forms.ListBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblScoutName As System.Windows.Forms.Label
    Friend WithEvents lblScoutRole As System.Windows.Forms.Label
    Friend WithEvents TTSearch As System.Windows.Forms.ToolTip
    Friend WithEvents chkSearchPlayer As System.Windows.Forms.CheckBox

End Class
