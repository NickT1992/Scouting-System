<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFixture
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
        Me.btnAddNewPlayerReport = New System.Windows.Forms.Button()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtWeather = New System.Windows.Forms.TextBox()
        Me.lblWeather = New System.Windows.Forms.Label()
        Me.txtVenue = New System.Windows.Forms.TextBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.btnAddExistingPlayerReport = New System.Windows.Forms.Button()
        Me.cmbHomeTeam = New System.Windows.Forms.ComboBox()
        Me.cmbAwayTeam = New System.Windows.Forms.ComboBox()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchSurname = New System.Windows.Forms.Label()
        Me.txtSearchSurname = New System.Windows.Forms.TextBox()
        Me.lbPlayers = New System.Windows.Forms.ListBox()
        Me.TTFixture = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddNewPlayerReport
        '
        Me.btnAddNewPlayerReport.Location = New System.Drawing.Point(315, 395)
        Me.btnAddNewPlayerReport.Name = "btnAddNewPlayerReport"
        Me.btnAddNewPlayerReport.Size = New System.Drawing.Size(155, 23)
        Me.btnAddNewPlayerReport.TabIndex = 0
        Me.btnAddNewPlayerReport.Text = "Add New Player Report"
        Me.TTFixture.SetToolTip(Me.btnAddNewPlayerReport, "Click to add a player report for a previously unscouted player.")
        Me.btnAddNewPlayerReport.UseVisualStyleBackColor = True
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(12, 19)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(68, 13)
        Me.lblHomeTeam.TabIndex = 1
        Me.lblHomeTeam.Text = "Home Team:"
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(254, 19)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(66, 13)
        Me.lblAwayTeam.TabIndex = 3
        Me.lblAwayTeam.Text = "Away Team:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 62)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(86, 62)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(84, 20)
        Me.txtResult.TabIndex = 8
        Me.txtResult.Text = "-"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeather
        '
        Me.txtWeather.Location = New System.Drawing.Point(16, 169)
        Me.txtWeather.Multiline = True
        Me.txtWeather.Name = "txtWeather"
        Me.txtWeather.Size = New System.Drawing.Size(454, 60)
        Me.txtWeather.TabIndex = 10
        '
        'lblWeather
        '
        Me.lblWeather.AutoSize = True
        Me.lblWeather.Location = New System.Drawing.Point(13, 150)
        Me.lblWeather.Name = "lblWeather"
        Me.lblWeather.Size = New System.Drawing.Size(103, 13)
        Me.lblWeather.TabIndex = 9
        Me.lblWeather.Text = "Weather Conditions:"
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(86, 103)
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(384, 20)
        Me.txtVenue.TabIndex = 12
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(13, 106)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(41, 13)
        Me.lblVenue.TabIndex = 11
        Me.lblVenue.Text = "Venue:"
        '
        'btnAddExistingPlayerReport
        '
        Me.btnAddExistingPlayerReport.Location = New System.Drawing.Point(6, 160)
        Me.btnAddExistingPlayerReport.Name = "btnAddExistingPlayerReport"
        Me.btnAddExistingPlayerReport.Size = New System.Drawing.Size(155, 23)
        Me.btnAddExistingPlayerReport.TabIndex = 13
        Me.btnAddExistingPlayerReport.Text = "Add Existing Player Report"
        Me.TTFixture.SetToolTip(Me.btnAddExistingPlayerReport, "Click to add a player report for the selected existing player.")
        Me.btnAddExistingPlayerReport.UseVisualStyleBackColor = True
        '
        'cmbHomeTeam
        '
        Me.cmbHomeTeam.FormattingEnabled = True
        Me.cmbHomeTeam.Location = New System.Drawing.Point(86, 16)
        Me.cmbHomeTeam.Name = "cmbHomeTeam"
        Me.cmbHomeTeam.Size = New System.Drawing.Size(151, 21)
        Me.cmbHomeTeam.TabIndex = 14
        '
        'cmbAwayTeam
        '
        Me.cmbAwayTeam.FormattingEnabled = True
        Me.cmbAwayTeam.Location = New System.Drawing.Point(326, 16)
        Me.cmbAwayTeam.Name = "cmbAwayTeam"
        Me.cmbAwayTeam.Size = New System.Drawing.Size(151, 21)
        Me.cmbAwayTeam.TabIndex = 15
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Controls.Add(Me.lblSearchSurname)
        Me.gbSearch.Controls.Add(Me.txtSearchSurname)
        Me.gbSearch.Controls.Add(Me.lbPlayers)
        Me.gbSearch.Controls.Add(Me.btnAddExistingPlayerReport)
        Me.gbSearch.Location = New System.Drawing.Point(16, 235)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(293, 189)
        Me.gbSearch.TabIndex = 16
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search Existing Players"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(227, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(57, 23)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.TTFixture.SetToolTip(Me.btnSearch, "Click to search for the player surname specified.")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearchSurname
        '
        Me.lblSearchSurname.AutoSize = True
        Me.lblSearchSurname.Location = New System.Drawing.Point(6, 29)
        Me.lblSearchSurname.Name = "lblSearchSurname"
        Me.lblSearchSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSearchSurname.TabIndex = 17
        Me.lblSearchSurname.Text = "Surname:"
        '
        'txtSearchSurname
        '
        Me.txtSearchSurname.Location = New System.Drawing.Point(70, 26)
        Me.txtSearchSurname.Name = "txtSearchSurname"
        Me.txtSearchSurname.Size = New System.Drawing.Size(151, 20)
        Me.txtSearchSurname.TabIndex = 15
        '
        'lbPlayers
        '
        Me.lbPlayers.FormattingEnabled = True
        Me.lbPlayers.Location = New System.Drawing.Point(6, 59)
        Me.lbPlayers.Name = "lbPlayers"
        Me.lbPlayers.Size = New System.Drawing.Size(278, 95)
        Me.lbPlayers.TabIndex = 14
        '
        'frmAddFixture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(483, 436)
        Me.Controls.Add(Me.cmbAwayTeam)
        Me.Controls.Add(Me.cmbHomeTeam)
        Me.Controls.Add(Me.txtVenue)
        Me.Controls.Add(Me.lblVenue)
        Me.Controls.Add(Me.txtWeather)
        Me.Controls.Add(Me.lblWeather)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblAwayTeam)
        Me.Controls.Add(Me.lblHomeTeam)
        Me.Controls.Add(Me.btnAddNewPlayerReport)
        Me.Controls.Add(Me.gbSearch)
        Me.Name = "frmAddFixture"
        Me.Text = "Add Fixture"
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddNewPlayerReport As System.Windows.Forms.Button
    Friend WithEvents lblHomeTeam As System.Windows.Forms.Label
    Friend WithEvents lblAwayTeam As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtWeather As System.Windows.Forms.TextBox
    Friend WithEvents lblWeather As System.Windows.Forms.Label
    Friend WithEvents txtVenue As System.Windows.Forms.TextBox
    Friend WithEvents lblVenue As System.Windows.Forms.Label
    Friend WithEvents btnAddExistingPlayerReport As System.Windows.Forms.Button
    Friend WithEvents cmbHomeTeam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAwayTeam As System.Windows.Forms.ComboBox
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearchSurname As System.Windows.Forms.Label
    Friend WithEvents txtSearchSurname As System.Windows.Forms.TextBox
    Friend WithEvents lbPlayers As System.Windows.Forms.ListBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TTFixture As System.Windows.Forms.ToolTip
End Class
