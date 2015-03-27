<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Menu_Scout
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPlayerInfo = New System.Windows.Forms.TabPage()
        Me.btnSubmitGrade = New System.Windows.Forms.Button()
        Me.cmbGrade = New System.Windows.Forms.ComboBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblScoutNumber = New System.Windows.Forms.Label()
        Me.lblReportNumber = New System.Windows.Forms.Label()
        Me.UcAttributes2 = New InterfaceDesign.UCAttributes()
        Me.lblFoot = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMainPosition = New System.Windows.Forms.Label()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.lblPlaceOfBirth = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabFixtureReports = New System.Windows.Forms.TabPage()
        Me.lblSelectedPlayer = New System.Windows.Forms.Label()
        Me.cmbSelectedPlayer = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblRptClub = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreviousPlayer = New System.Windows.Forms.Button()
        Me.btnNextPlayer = New System.Windows.Forms.Button()
        Me.lblNumberOfReports = New System.Windows.Forms.Label()
        Me.btnAddReport = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblRptAge = New System.Windows.Forms.Label()
        Me.lblRptPosition = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblRptPlayerName = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblReportDate = New System.Windows.Forms.Label()
        Me.lblScoutName = New System.Windows.Forms.Label()
        Me.cmbReportDate = New System.Windows.Forms.ComboBox()
        Me.lblConditions = New System.Windows.Forms.Label()
        Me.cmbScoutName = New System.Windows.Forms.ComboBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblFixture = New System.Windows.Forms.Label()
        Me.UcAttributes1 = New InterfaceDesign.UCAttributes()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnEditScoutInfo = New System.Windows.Forms.Button()
        Me.btnEditFixtureInfo = New System.Windows.Forms.Button()
        Me.btnEditReport = New System.Windows.Forms.Button()
        Me.btnEditPlayerInfo = New System.Windows.Forms.Button()
        Me.TTReports = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabPlayerInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFixtureReports.SuspendLayout()
        Me.tabEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPlayerInfo)
        Me.TabControl1.Controls.Add(Me.tabFixtureReports)
        Me.TabControl1.Controls.Add(Me.tabEdit)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(881, 549)
        Me.TabControl1.TabIndex = 1
        '
        'tabPlayerInfo
        '
        Me.tabPlayerInfo.BackColor = System.Drawing.Color.White
        Me.tabPlayerInfo.Controls.Add(Me.btnSubmitGrade)
        Me.tabPlayerInfo.Controls.Add(Me.cmbGrade)
        Me.tabPlayerInfo.Controls.Add(Me.lblGrade)
        Me.tabPlayerInfo.Controls.Add(Me.Label35)
        Me.tabPlayerInfo.Controls.Add(Me.Label34)
        Me.tabPlayerInfo.Controls.Add(Me.Label33)
        Me.tabPlayerInfo.Controls.Add(Me.Label32)
        Me.tabPlayerInfo.Controls.Add(Me.Label31)
        Me.tabPlayerInfo.Controls.Add(Me.Label30)
        Me.tabPlayerInfo.Controls.Add(Me.Label29)
        Me.tabPlayerInfo.Controls.Add(Me.Panel13)
        Me.tabPlayerInfo.Controls.Add(Me.lblScoutNumber)
        Me.tabPlayerInfo.Controls.Add(Me.lblReportNumber)
        Me.tabPlayerInfo.Controls.Add(Me.UcAttributes2)
        Me.tabPlayerInfo.Controls.Add(Me.lblFoot)
        Me.tabPlayerInfo.Controls.Add(Me.Panel4)
        Me.tabPlayerInfo.Controls.Add(Me.Panel3)
        Me.tabPlayerInfo.Controls.Add(Me.Panel2)
        Me.tabPlayerInfo.Controls.Add(Me.Panel1)
        Me.tabPlayerInfo.Controls.Add(Me.lblMainPosition)
        Me.tabPlayerInfo.Controls.Add(Me.lblClub)
        Me.tabPlayerInfo.Controls.Add(Me.lblPlaceOfBirth)
        Me.tabPlayerInfo.Controls.Add(Me.lblAge)
        Me.tabPlayerInfo.Controls.Add(Me.lblDOB)
        Me.tabPlayerInfo.Controls.Add(Me.lblDisplayName)
        Me.tabPlayerInfo.Controls.Add(Me.PictureBox1)
        Me.tabPlayerInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabPlayerInfo.Name = "tabPlayerInfo"
        Me.tabPlayerInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlayerInfo.Size = New System.Drawing.Size(873, 523)
        Me.tabPlayerInfo.TabIndex = 0
        Me.tabPlayerInfo.Text = "Player Information"
        '
        'btnSubmitGrade
        '
        Me.btnSubmitGrade.Location = New System.Drawing.Point(669, 441)
        Me.btnSubmitGrade.Name = "btnSubmitGrade"
        Me.btnSubmitGrade.Size = New System.Drawing.Size(82, 23)
        Me.btnSubmitGrade.TabIndex = 40
        Me.btnSubmitGrade.Text = "Submit Grade"
        Me.TTReports.SetToolTip(Me.btnSubmitGrade, "Click to submit the selected grade.")
        Me.btnSubmitGrade.UseVisualStyleBackColor = True
        '
        'cmbGrade
        '
        Me.cmbGrade.FormattingEnabled = True
        Me.cmbGrade.Location = New System.Drawing.Point(530, 441)
        Me.cmbGrade.Name = "cmbGrade"
        Me.cmbGrade.Size = New System.Drawing.Size(121, 21)
        Me.cmbGrade.TabIndex = 39
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(476, 444)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade.TabIndex = 38
        Me.lblGrade.Text = "Grade:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 366)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 13)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "Preferred Foot:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 324)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 13)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "Main Position:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 275)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 35
        Me.Label33.Text = "Club:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 238)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 13)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Place of Birth:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(149, 207)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(29, 13)
        Me.Label31.TabIndex = 33
        Me.Label31.Text = "Age:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 207)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Date of Birth:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 177)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 13)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Name:"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Black
        Me.Panel13.Location = New System.Drawing.Point(8, 402)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(261, 2)
        Me.Panel13.TabIndex = 21
        '
        'lblScoutNumber
        '
        Me.lblScoutNumber.AutoSize = True
        Me.lblScoutNumber.Location = New System.Drawing.Point(85, 420)
        Me.lblScoutNumber.Name = "lblScoutNumber"
        Me.lblScoutNumber.Size = New System.Drawing.Size(68, 13)
        Me.lblScoutNumber.TabIndex = 30
        Me.lblScoutNumber.Text = "CountScouts"
        '
        'lblReportNumber
        '
        Me.lblReportNumber.AutoSize = True
        Me.lblReportNumber.Location = New System.Drawing.Point(5, 420)
        Me.lblReportNumber.Name = "lblReportNumber"
        Me.lblReportNumber.Size = New System.Drawing.Size(72, 13)
        Me.lblReportNumber.TabIndex = 29
        Me.lblReportNumber.Text = "CountReports"
        '
        'UcAttributes2
        '
        Me.UcAttributes2.BackColor = System.Drawing.Color.AliceBlue
        Me.UcAttributes2.Location = New System.Drawing.Point(449, 6)
        Me.UcAttributes2.Name = "UcAttributes2"
        Me.UcAttributes2.Size = New System.Drawing.Size(418, 471)
        Me.UcAttributes2.TabIndex = 23
        '
        'lblFoot
        '
        Me.lblFoot.AutoSize = True
        Me.lblFoot.Location = New System.Drawing.Point(149, 366)
        Me.lblFoot.Name = "lblFoot"
        Me.lblFoot.Size = New System.Drawing.Size(74, 13)
        Me.lblFoot.TabIndex = 22
        Me.lblFoot.Text = "Preferred Foot"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(8, 172)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(261, 2)
        Me.Panel4.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(8, 475)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 2)
        Me.Panel3.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(8, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 2)
        Me.Panel2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(8, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 2)
        Me.Panel1.TabIndex = 19
        '
        'lblMainPosition
        '
        Me.lblMainPosition.AutoSize = True
        Me.lblMainPosition.Location = New System.Drawing.Point(149, 324)
        Me.lblMainPosition.Name = "lblMainPosition"
        Me.lblMainPosition.Size = New System.Drawing.Size(70, 13)
        Me.lblMainPosition.TabIndex = 18
        Me.lblMainPosition.Text = "Main Position"
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(149, 275)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(28, 13)
        Me.lblClub.TabIndex = 16
        Me.lblClub.Text = "Club"
        '
        'lblPlaceOfBirth
        '
        Me.lblPlaceOfBirth.AutoSize = True
        Me.lblPlaceOfBirth.Location = New System.Drawing.Point(149, 238)
        Me.lblPlaceOfBirth.Name = "lblPlaceOfBirth"
        Me.lblPlaceOfBirth.Size = New System.Drawing.Size(70, 13)
        Me.lblPlaceOfBirth.TabIndex = 15
        Me.lblPlaceOfBirth.Text = "Place of Birth"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(184, 207)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 13)
        Me.lblAge.TabIndex = 14
        Me.lblAge.Text = "(Age)"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(80, 207)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(30, 13)
        Me.lblDOB.TabIndex = 13
        Me.lblDOB.Text = "DOB"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Location = New System.Drawing.Point(149, 177)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(35, 13)
        Me.lblDisplayName.TabIndex = 12
        Me.lblDisplayName.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(8, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'tabFixtureReports
        '
        Me.tabFixtureReports.BackColor = System.Drawing.Color.White
        Me.tabFixtureReports.Controls.Add(Me.lblSelectedPlayer)
        Me.tabFixtureReports.Controls.Add(Me.cmbSelectedPlayer)
        Me.tabFixtureReports.Controls.Add(Me.Label28)
        Me.tabFixtureReports.Controls.Add(Me.lblRptClub)
        Me.tabFixtureReports.Controls.Add(Me.Label8)
        Me.tabFixtureReports.Controls.Add(Me.Label7)
        Me.tabFixtureReports.Controls.Add(Me.Label6)
        Me.tabFixtureReports.Controls.Add(Me.Label5)
        Me.tabFixtureReports.Controls.Add(Me.Label4)
        Me.tabFixtureReports.Controls.Add(Me.Label3)
        Me.tabFixtureReports.Controls.Add(Me.Label2)
        Me.tabFixtureReports.Controls.Add(Me.Label1)
        Me.tabFixtureReports.Controls.Add(Me.btnPreviousPlayer)
        Me.tabFixtureReports.Controls.Add(Me.btnNextPlayer)
        Me.tabFixtureReports.Controls.Add(Me.lblNumberOfReports)
        Me.tabFixtureReports.Controls.Add(Me.btnAddReport)
        Me.tabFixtureReports.Controls.Add(Me.Panel6)
        Me.tabFixtureReports.Controls.Add(Me.Panel7)
        Me.tabFixtureReports.Controls.Add(Me.txtComments)
        Me.tabFixtureReports.Controls.Add(Me.Panel8)
        Me.tabFixtureReports.Controls.Add(Me.lblRptAge)
        Me.tabFixtureReports.Controls.Add(Me.lblRptPosition)
        Me.tabFixtureReports.Controls.Add(Me.lblStatus)
        Me.tabFixtureReports.Controls.Add(Me.lblRptPlayerName)
        Me.tabFixtureReports.Controls.Add(Me.lblResult)
        Me.tabFixtureReports.Controls.Add(Me.Panel5)
        Me.tabFixtureReports.Controls.Add(Me.lblReportDate)
        Me.tabFixtureReports.Controls.Add(Me.lblScoutName)
        Me.tabFixtureReports.Controls.Add(Me.cmbReportDate)
        Me.tabFixtureReports.Controls.Add(Me.lblConditions)
        Me.tabFixtureReports.Controls.Add(Me.cmbScoutName)
        Me.tabFixtureReports.Controls.Add(Me.lblVenue)
        Me.tabFixtureReports.Controls.Add(Me.lblFixture)
        Me.tabFixtureReports.Controls.Add(Me.UcAttributes1)
        Me.tabFixtureReports.Location = New System.Drawing.Point(4, 22)
        Me.tabFixtureReports.Name = "tabFixtureReports"
        Me.tabFixtureReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFixtureReports.Size = New System.Drawing.Size(873, 523)
        Me.tabFixtureReports.TabIndex = 1
        Me.tabFixtureReports.Text = "Fixture Reports"
        '
        'lblSelectedPlayer
        '
        Me.lblSelectedPlayer.AutoSize = True
        Me.lblSelectedPlayer.Location = New System.Drawing.Point(206, 46)
        Me.lblSelectedPlayer.Name = "lblSelectedPlayer"
        Me.lblSelectedPlayer.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedPlayer.TabIndex = 52
        Me.lblSelectedPlayer.Text = "Selected Player:"
        '
        'cmbSelectedPlayer
        '
        Me.cmbSelectedPlayer.FormattingEnabled = True
        Me.cmbSelectedPlayer.Location = New System.Drawing.Point(291, 43)
        Me.cmbSelectedPlayer.Name = "cmbSelectedPlayer"
        Me.cmbSelectedPlayer.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelectedPlayer.TabIndex = 51
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(166, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "Club:"
        '
        'lblRptClub
        '
        Me.lblRptClub.AutoSize = True
        Me.lblRptClub.Location = New System.Drawing.Point(219, 143)
        Me.lblRptClub.Name = "lblRptClub"
        Me.lblRptClub.Size = New System.Drawing.Size(28, 13)
        Me.lblRptClub.TabIndex = 49
        Me.lblRptClub.Text = "Club"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Conditions:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Venue:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Result:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fixture:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name:"
        '
        'btnPreviousPlayer
        '
        Me.btnPreviousPlayer.Location = New System.Drawing.Point(449, 488)
        Me.btnPreviousPlayer.Name = "btnPreviousPlayer"
        Me.btnPreviousPlayer.Size = New System.Drawing.Size(89, 23)
        Me.btnPreviousPlayer.TabIndex = 40
        Me.btnPreviousPlayer.Text = "Previous Player"
        Me.TTReports.SetToolTip(Me.btnPreviousPlayer, "Click to view previous player report.")
        Me.btnPreviousPlayer.UseVisualStyleBackColor = True
        '
        'btnNextPlayer
        '
        Me.btnNextPlayer.Location = New System.Drawing.Point(778, 488)
        Me.btnNextPlayer.Name = "btnNextPlayer"
        Me.btnNextPlayer.Size = New System.Drawing.Size(89, 23)
        Me.btnNextPlayer.TabIndex = 39
        Me.btnNextPlayer.Text = "Next Player"
        Me.TTReports.SetToolTip(Me.btnNextPlayer, "Click to view next player report.")
        Me.btnNextPlayer.UseVisualStyleBackColor = True
        '
        'lblNumberOfReports
        '
        Me.lblNumberOfReports.AutoSize = True
        Me.lblNumberOfReports.Location = New System.Drawing.Point(638, 493)
        Me.lblNumberOfReports.Name = "lblNumberOfReports"
        Me.lblNumberOfReports.Size = New System.Drawing.Size(59, 13)
        Me.lblNumberOfReports.TabIndex = 38
        Me.lblNumberOfReports.Text = "Report ?/?"
        '
        'btnAddReport
        '
        Me.btnAddReport.Location = New System.Drawing.Point(10, 488)
        Me.btnAddReport.Name = "btnAddReport"
        Me.btnAddReport.Size = New System.Drawing.Size(86, 23)
        Me.btnAddReport.TabIndex = 37
        Me.btnAddReport.Text = "Add Report"
        Me.TTReports.SetToolTip(Me.btnAddReport, "Click to create a new series of reports.")
        Me.btnAddReport.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(8, 167)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(400, 2)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(8, 271)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(400, 2)
        Me.Panel7.TabIndex = 24
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(8, 280)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(404, 197)
        Me.txtComments.TabIndex = 36
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(8, 129)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(400, 2)
        Me.Panel8.TabIndex = 25
        '
        'lblRptAge
        '
        Me.lblRptAge.AutoSize = True
        Me.lblRptAge.Location = New System.Drawing.Point(367, 108)
        Me.lblRptAge.Name = "lblRptAge"
        Me.lblRptAge.Size = New System.Drawing.Size(26, 13)
        Me.lblRptAge.TabIndex = 32
        Me.lblRptAge.Text = "Age"
        '
        'lblRptPosition
        '
        Me.lblRptPosition.AutoSize = True
        Me.lblRptPosition.Location = New System.Drawing.Point(219, 108)
        Me.lblRptPosition.Name = "lblRptPosition"
        Me.lblRptPosition.Size = New System.Drawing.Size(55, 13)
        Me.lblRptPosition.TabIndex = 31
        Me.lblRptPosition.Text = "Position(s)"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(51, 143)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 33
        Me.lblStatus.Text = "Status"
        '
        'lblRptPlayerName
        '
        Me.lblRptPlayerName.AutoSize = True
        Me.lblRptPlayerName.Location = New System.Drawing.Point(51, 108)
        Me.lblRptPlayerName.Name = "lblRptPlayerName"
        Me.lblRptPlayerName.Size = New System.Drawing.Size(64, 13)
        Me.lblRptPlayerName.TabIndex = 30
        Me.lblRptPlayerName.Text = "PlayerName"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(367, 182)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 29
        Me.lblResult.Text = "Result"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(8, 95)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 2)
        Me.Panel5.TabIndex = 22
        '
        'lblReportDate
        '
        Me.lblReportDate.AutoSize = True
        Me.lblReportDate.Location = New System.Drawing.Point(5, 46)
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Size = New System.Drawing.Size(68, 13)
        Me.lblReportDate.TabIndex = 16
        Me.lblReportDate.Text = "Report Date:"
        '
        'lblScoutName
        '
        Me.lblScoutName.AutoSize = True
        Me.lblScoutName.Location = New System.Drawing.Point(5, 9)
        Me.lblScoutName.Name = "lblScoutName"
        Me.lblScoutName.Size = New System.Drawing.Size(63, 13)
        Me.lblScoutName.TabIndex = 15
        Me.lblScoutName.Text = "Staff Name:"
        '
        'cmbReportDate
        '
        Me.cmbReportDate.FormattingEnabled = True
        Me.cmbReportDate.Location = New System.Drawing.Point(79, 43)
        Me.cmbReportDate.Name = "cmbReportDate"
        Me.cmbReportDate.Size = New System.Drawing.Size(121, 21)
        Me.cmbReportDate.TabIndex = 14
        '
        'lblConditions
        '
        Me.lblConditions.AutoSize = True
        Me.lblConditions.Location = New System.Drawing.Point(72, 246)
        Me.lblConditions.Name = "lblConditions"
        Me.lblConditions.Size = New System.Drawing.Size(56, 13)
        Me.lblConditions.TabIndex = 27
        Me.lblConditions.Text = "Conditions"
        '
        'cmbScoutName
        '
        Me.cmbScoutName.FormattingEnabled = True
        Me.cmbScoutName.Location = New System.Drawing.Point(79, 6)
        Me.cmbScoutName.Name = "cmbScoutName"
        Me.cmbScoutName.Size = New System.Drawing.Size(121, 21)
        Me.cmbScoutName.TabIndex = 13
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Location = New System.Drawing.Point(51, 215)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(38, 13)
        Me.lblVenue.TabIndex = 26
        Me.lblVenue.Text = "Venue"
        '
        'lblFixture
        '
        Me.lblFixture.AutoSize = True
        Me.lblFixture.Location = New System.Drawing.Point(51, 182)
        Me.lblFixture.Name = "lblFixture"
        Me.lblFixture.Size = New System.Drawing.Size(38, 13)
        Me.lblFixture.TabIndex = 24
        Me.lblFixture.Text = "Fixture"
        '
        'UcAttributes1
        '
        Me.UcAttributes1.BackColor = System.Drawing.Color.AliceBlue
        Me.UcAttributes1.Location = New System.Drawing.Point(449, 6)
        Me.UcAttributes1.Name = "UcAttributes1"
        Me.UcAttributes1.Size = New System.Drawing.Size(418, 471)
        Me.UcAttributes1.TabIndex = 0
        '
        'tabEdit
        '
        Me.tabEdit.Controls.Add(Me.RichTextBox4)
        Me.tabEdit.Controls.Add(Me.RichTextBox3)
        Me.tabEdit.Controls.Add(Me.RichTextBox2)
        Me.tabEdit.Controls.Add(Me.RichTextBox1)
        Me.tabEdit.Controls.Add(Me.btnEditScoutInfo)
        Me.tabEdit.Controls.Add(Me.btnEditFixtureInfo)
        Me.tabEdit.Controls.Add(Me.btnEditReport)
        Me.tabEdit.Controls.Add(Me.btnEditPlayerInfo)
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEdit.Size = New System.Drawing.Size(873, 523)
        Me.tabEdit.TabIndex = 5
        Me.tabEdit.Text = "Edit"
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.White
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Location = New System.Drawing.Point(601, 40)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(248, 151)
        Me.RichTextBox4.TabIndex = 37
        Me.RichTextBox4.Text = "Edit all report information such as: Player Attributes, Comments, and Report Date" & _
    "."
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.White
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Location = New System.Drawing.Point(601, 280)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(248, 151)
        Me.RichTextBox3.TabIndex = 36
        Me.RichTextBox3.Text = "Edit scout information such as: Name, Scout Role, Username and Password."
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(178, 280)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(248, 151)
        Me.RichTextBox2.TabIndex = 35
        Me.RichTextBox2.Text = "Edit fixture information such as: Edit Fixture Information such as: Teams, Venue," & _
    " Weather Conditions and Result."
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(178, 40)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(248, 151)
        Me.RichTextBox1.TabIndex = 34
        Me.RichTextBox1.Text = "Edit key player information such as: Name, Date of Birth, and Place of Birth."
        '
        'btnEditScoutInfo
        '
        Me.btnEditScoutInfo.Location = New System.Drawing.Point(441, 277)
        Me.btnEditScoutInfo.Name = "btnEditScoutInfo"
        Me.btnEditScoutInfo.Size = New System.Drawing.Size(154, 154)
        Me.btnEditScoutInfo.TabIndex = 32
        Me.btnEditScoutInfo.Text = "Edit Scout Information"
        Me.btnEditScoutInfo.UseVisualStyleBackColor = True
        '
        'btnEditFixtureInfo
        '
        Me.btnEditFixtureInfo.Enabled = False
        Me.btnEditFixtureInfo.Location = New System.Drawing.Point(18, 279)
        Me.btnEditFixtureInfo.Name = "btnEditFixtureInfo"
        Me.btnEditFixtureInfo.Size = New System.Drawing.Size(154, 151)
        Me.btnEditFixtureInfo.TabIndex = 31
        Me.btnEditFixtureInfo.Text = "Edit Fixture Information"
        Me.btnEditFixtureInfo.UseVisualStyleBackColor = True
        '
        'btnEditReport
        '
        Me.btnEditReport.Enabled = False
        Me.btnEditReport.Location = New System.Drawing.Point(441, 40)
        Me.btnEditReport.Name = "btnEditReport"
        Me.btnEditReport.Size = New System.Drawing.Size(154, 151)
        Me.btnEditReport.TabIndex = 30
        Me.btnEditReport.Text = "Edit Report Information"
        Me.btnEditReport.UseVisualStyleBackColor = True
        '
        'btnEditPlayerInfo
        '
        Me.btnEditPlayerInfo.Location = New System.Drawing.Point(18, 40)
        Me.btnEditPlayerInfo.Name = "btnEditPlayerInfo"
        Me.btnEditPlayerInfo.Size = New System.Drawing.Size(154, 151)
        Me.btnEditPlayerInfo.TabIndex = 29
        Me.btnEditPlayerInfo.Text = "Edit Player Information"
        Me.btnEditPlayerInfo.UseVisualStyleBackColor = True
        '
        'UC_Menu_Scout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UC_Menu_Scout"
        Me.Size = New System.Drawing.Size(879, 547)
        Me.TabControl1.ResumeLayout(False)
        Me.tabPlayerInfo.ResumeLayout(False)
        Me.tabPlayerInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFixtureReports.ResumeLayout(False)
        Me.tabFixtureReports.PerformLayout()
        Me.tabEdit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPlayerInfo As System.Windows.Forms.TabPage
    Friend WithEvents UcAttributes2 As InterfaceDesign.UCAttributes
    Friend WithEvents lblFoot As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMainPosition As System.Windows.Forms.Label
    Friend WithEvents lblClub As System.Windows.Forms.Label
    Friend WithEvents lblPlaceOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblDisplayName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tabFixtureReports As System.Windows.Forms.TabPage
    Friend WithEvents btnAddReport As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblRptAge As System.Windows.Forms.Label
    Friend WithEvents lblRptPosition As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRptPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblReportDate As System.Windows.Forms.Label
    Friend WithEvents lblScoutName As System.Windows.Forms.Label
    Friend WithEvents cmbReportDate As System.Windows.Forms.ComboBox
    Friend WithEvents lblConditions As System.Windows.Forms.Label
    Friend WithEvents cmbScoutName As System.Windows.Forms.ComboBox
    Friend WithEvents lblVenue As System.Windows.Forms.Label
    Friend WithEvents lblFixture As System.Windows.Forms.Label
    Friend WithEvents UcAttributes1 As InterfaceDesign.UCAttributes
    Friend WithEvents btnNextPlayer As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfReports As System.Windows.Forms.Label
    Friend WithEvents btnPreviousPlayer As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents lblScoutNumber As System.Windows.Forms.Label
    Friend WithEvents lblReportNumber As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblRptClub As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblSelectedPlayer As System.Windows.Forms.Label
    Friend WithEvents cmbSelectedPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEditScoutInfo As System.Windows.Forms.Button
    Friend WithEvents btnEditFixtureInfo As System.Windows.Forms.Button
    Friend WithEvents btnEditReport As System.Windows.Forms.Button
    Friend WithEvents btnEditPlayerInfo As System.Windows.Forms.Button
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TTReports As System.Windows.Forms.ToolTip
    Friend WithEvents cmbGrade As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnSubmitGrade As System.Windows.Forms.Button

End Class
