Public Class frmAddReport

    Dim imgLoc As String = ""
    Private homeTeam As New Club(0, "")
    Private awayTeam As New Club(0, "")
    Dim reportScore As Integer = 0

    Public Sub New(ByVal home As Club, ByVal away As Club)
        InitializeComponent()
        homeTeam = home
        awayTeam = away
    End Sub

    Private Sub frmAddReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        setClubs() 'Fills cmbClubs from the two teams involved in the fixture
        fillMonitorStatus() 'Fills cmbMonitorStatus
        fillPreferredFoot() 'Fills cmbPreferredFoot
        fillPositionPlayed() 'Fills cmbPositionPlayed

        If isNewPlayer = False Then
            fillPlayerInfo()
        End If

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        checkPictureBox()

        If txtFirstName.Text = "" OrElse txtSurname.Text = "" Then
            MsgBox("Please ensure a first name and surname have been entered for the player")
            Exit Sub
        End If

        If checkTechnicalNumbers() = False Then
            MsgBox("Please ensure all attribute numbers are between 1 and 20")
            Exit Sub
        End If
        If checkTacticalNumbers() = False Then
            MsgBox("Please ensure all attribute numbers are between 1 and 20")
            Exit Sub
        End If
        If checkPhysicalNumbers() = False Then
            MsgBox("Please ensure all attribute numbers are between 1 and 20")
            Exit Sub
        End If

        Select Case MsgBox("Are you sure you want to add this report?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Report")
            Case MsgBoxResult.Yes
                If isNewPlayer = True Then
                    addNewPlayer()
                End If

                addReport()
                showMsg()
                Me.Close()
        End Select

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub addNewPlayer()

                _playerID = getMaxID("PlayerID", "Player") 'Stored in variable for use in report

        Dim Str As String = _
       <String> INSERT INTO
                    Player(
                        PlayerID, 
                        PlayerFirstName,
                        PlayerLastName,
                        PlayerImage,
                        DOB,
                        Age,
                        PlaceOfBirth,
                        ClubID) 
                VALUES(
                        @PlayerID,
                        @PlayerFirstName,
                        @PlayerLastName,
                        @PlayerImage,
                        @DOB,
                        @Age,
                        @PlaceOfBirth,
                        @ClubID) 
       </String>

                Try
                    Using conn As New SqlClient.SqlConnection(DBConnection)
                        conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    'Create an Image object.
                    Using picture As Image = Image.FromFile(imgLoc)
                        'Create an empty stream in memory.
                        Using stream As New IO.MemoryStream
                            'Fill the stream with the binary data from the Image.
                            picture.Save(stream, Imaging.ImageFormat.Jpeg)
                            cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = _playerID
                            cmdQuery.Parameters.Add("@PlayerFirstName", SqlDbType.VarChar).Value = txtFirstName.Text
                            cmdQuery.Parameters.Add("@PlayerLastName", SqlDbType.VarChar).Value = txtSurname.Text
                            cmdQuery.Parameters.Add("@PlayerImage", SqlDbType.VarBinary).Value = stream.GetBuffer()
                            cmdQuery.Parameters.Add("@DOB", SqlDbType.Date).Value = dtpDOB.Value
                            cmdQuery.Parameters.Add("@Age", SqlDbType.Int).Value = calculateAge(dtpDOB.Value)
                            cmdQuery.Parameters.Add("@PlaceOfBirth", SqlDbType.VarChar).Value = txtPlaceOfBirth.Text
                            cmdQuery.Parameters.Add("@ClubID", SqlDbType.Int).Value = cmbClub.SelectedItem.ClubID
                            cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being added to, not queried
                        End Using
                    End Using
                End Using
            End Using

            MsgBox("Player Added")

        Catch ex As Exception
            MsgBox("Add Player Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub addReport()

        Dim Str As String = _
       <String> INSERT INTO
                    Report(
                        ReportID, 
                        ScoutID, 
                        FixtureID, 
                        PlayerID, 
                        PositionPlayed,
                        PreferredFoot,
                        Comments,
                        MonitorStatus,                       
                        ReportDate,
                        Crossing,
                        Dribbling,
                        Finishing,
                        BallControl,
                        Passing,
                        HeadingAccuracy,
                        Marking,
                        Tackling,
                        Aggression,
                        Positioning,
                        Anticipation,
                        Composure,
                        Vision,
                        Teamwork,
                        WorkRate,
                        Pace,
                        Balance,
                        Jumping,
                        Strength,
                        Stamina,
                        Overall) 
                VALUES(
                        @ReportID,
                        @ScoutID,
                        @FixtureID,
                        @PlayerID,
                        @PositionPlayed,
                        @PreferredFoot,
                        @Comments,
                        @MonitorStatus,                       
                        @ReportDate,
                        @Crossing,
                        @Dribbling,
                        @Finishing,
                        @BallControl,
                        @Passing,
                        @HeadingAccuracy,
                        @Marking,
                        @Tackling,
                        @Aggression,
                        @Positioning,
                        @Anticipation,
                        @Composure,
                        @Vision,
                        @Teamwork,
                        @WorkRate,
                        @Pace,
                        @Balance,
                        @Jumping,
                        @Strength,
                        @Stamina,
                        @Overall)                     
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    MsgBox(_fixtureID)
                    cmdQuery.Parameters.Add("@ReportID", SqlDbType.Int).Value = getMaxID("ReportID", "Report")
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = _scoutID
                    cmdQuery.Parameters.Add("@FixtureID", SqlDbType.Int).Value = _fixtureID 'Generated on confirmation of fixture information
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = _playerID 'Generated on confirmation of submit report
                    cmdQuery.Parameters.Add("@PositionPlayed", SqlDbType.VarChar).Value = cmbPosition.SelectedItem
                    cmdQuery.Parameters.Add("@PreferredFoot", SqlDbType.VarChar).Value = cmbPreferredFoot.SelectedItem
                    cmdQuery.Parameters.Add("@Comments", SqlDbType.VarChar).Value = txtComments.Text
                    cmdQuery.Parameters.Add("@MonitorStatus", SqlDbType.VarChar).Value = cmbMonitorStatus.SelectedItem
                    cmdQuery.Parameters.Add("@ReportDate", SqlDbType.Date).Value = System.DateTime.Today
                    cmdQuery.Parameters.Add("@Crossing", SqlDbType.Int).Value = txtCrossing.Text
                    cmdQuery.Parameters.Add("@Dribbling", SqlDbType.Int).Value = txtDribbling.Text
                    cmdQuery.Parameters.Add("@Finishing", SqlDbType.Int).Value = txtFinishing.Text
                    cmdQuery.Parameters.Add("@BallControl", SqlDbType.Int).Value = txtBallControl.Text
                    cmdQuery.Parameters.Add("@Passing", SqlDbType.Int).Value = txtPassing.Text
                    cmdQuery.Parameters.Add("@HeadingAccuracy", SqlDbType.Int).Value = txtHeadingAccuracy.Text
                    cmdQuery.Parameters.Add("@Marking", SqlDbType.Int).Value = txtMarking.Text
                    cmdQuery.Parameters.Add("@Tackling", SqlDbType.Int).Value = txtTackling.Text
                    cmdQuery.Parameters.Add("@Aggression", SqlDbType.Int).Value = txtAggression.Text
                    cmdQuery.Parameters.Add("@Positioning", SqlDbType.Int).Value = txtPositioning.Text
                    cmdQuery.Parameters.Add("@Anticipation", SqlDbType.Int).Value = txtAnticipation.Text
                    cmdQuery.Parameters.Add("@Composure", SqlDbType.Int).Value = txtComposure.Text
                    cmdQuery.Parameters.Add("@Vision", SqlDbType.Int).Value = txtVision.Text
                    cmdQuery.Parameters.Add("@Teamwork", SqlDbType.Int).Value = txtTeamwork.Text
                    cmdQuery.Parameters.Add("@WorkRate", SqlDbType.Int).Value = txtWorkRate.Text
                    cmdQuery.Parameters.Add("@Pace", SqlDbType.Int).Value = txtPace.Text
                    cmdQuery.Parameters.Add("@Balance", SqlDbType.Int).Value = txtBalance.Text
                    cmdQuery.Parameters.Add("@Jumping", SqlDbType.Int).Value = txtJumping.Text
                    cmdQuery.Parameters.Add("@Strength", SqlDbType.Int).Value = txtStrength.Text
                    cmdQuery.Parameters.Add("@Stamina", SqlDbType.Int).Value = txtStamina.Text
                    cmdQuery.Parameters.Add("@Overall", SqlDbType.Int).Value = reportScore
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being added to, not queried
                End Using
            End Using

            MsgBox("Report Added")

        Catch ex As Exception
            MsgBox("Add Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub fillMonitorStatus()
        cmbMonitorStatus.Items.Add("Monitor")
        cmbMonitorStatus.Items.Add("Follow-Up")
        cmbMonitorStatus.SelectedIndex = 0
    End Sub

    Private Sub fillPreferredFoot()
        cmbPreferredFoot.Items.Add("Right")
        cmbPreferredFoot.Items.Add("Left")
        cmbPreferredFoot.Items.Add("Either")
        cmbPreferredFoot.SelectedIndex = 0
    End Sub

    Private Sub fillPositionPlayed()
        cmbPosition.Items.Add("GK")
        cmbPosition.Items.Add("LWB")
        cmbPosition.Items.Add("LB")
        cmbPosition.Items.Add("RWB")
        cmbPosition.Items.Add("RB")
        cmbPosition.Items.Add("CB")
        cmbPosition.Items.Add("CDM")
        cmbPosition.Items.Add("CM")
        cmbPosition.Items.Add("CAM")
        cmbPosition.Items.Add("LW")
        cmbPosition.Items.Add("RW")
        cmbPosition.Items.Add("CF")
        cmbPosition.Items.Add("ST")
        cmbPosition.SelectedIndex = 12
    End Sub

    Private Sub showMsg()

        Select Case MsgBox("Do you want to add another player report for this fixture?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Add further reports")
            Case MsgBoxResult.Yes
                isNewFixture = False
                For Each txt As TextBox In Me.Controls.OfType(Of TextBox)()
                    txt.Clear()
                Next
                For Each txt As TextBox In Me.gbTechnical.Controls.OfType(Of TextBox)()
                    txt.Clear()
                Next
                For Each txt As TextBox In Me.gbTactical.Controls.OfType(Of TextBox)()
                    txt.Clear()
                Next
                For Each txt As TextBox In Me.gbPhysical.Controls.OfType(Of TextBox)()
                    txt.Clear()
                Next

                cmbMonitorStatus.SelectedIndex = 0
                cmbPreferredFoot.SelectedIndex = 0
                cmbPosition.SelectedIndex = 12

                'Close frmAddReport (make sure all fields are blank/default)
                Me.Close()
                'Go back to frmAddFixture, with the fixture info unable to change- then allow to add existing player, or new player
                frmAddFixture.txtResult.ReadOnly = True
                frmAddFixture.txtVenue.ReadOnly = True
                frmAddFixture.txtWeather.ReadOnly = True

            Case MsgBoxResult.No
                isNewFixture = True
                Me.Close()
                'Close frmAddFixture
                frmAddFixture.Dispose()
        End Select

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click

        Dim dlg As New OpenFileDialog
        dlg.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*"
        dlg.Title = "Select Player Picture"

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            imgLoc = dlg.FileName.ToString
            pcb1.ImageLocation = imgLoc

        End If

    End Sub

    Private Function retrievePlayerInfo()

        Dim typeList As New List(Of Player)
        Dim Str As String = _
       <String> SELECT 
                    *
                FROM 
                    Player
                INNER JOIN Club ON Club.ClubID = Player.ClubID                
                WHERE
                    PlayerID = @PlayerID    
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = _playerID
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Player(drResult("PlayerID")) With {
                                         .PlayerFirstName = drResult("PlayerFirstName"),
                                         .PlayerLastName = drResult("PlayerLastName"),
                                         .DOB = drResult("DOB"),
                                         .Age = drResult("Age"),
                                         .PlaceOfBirth = drResult("PlaceOfBirth"),
                                         .PlayerImage = drResult("PlayerImage"),
                                         .ClubID = drResult("ClubID")})                          
                            'ClubName might be retrieved here- as it's joined to the club table
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Player Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList

    End Function

    Private Sub setReportScore()

        reportScore = frmPlayerInfo.calculateScore(txtCrossing.Text, txtDribbling.Text, txtFinishing.Text, _
                     txtBallControl.Text, txtPassing.Text, txtHeadingAccuracy.Text, txtMarking.Text, txtTackling.Text, _
                    txtAggression.Text, txtPositioning.Text, txtAnticipation.Text, txtComposure.Text, txtVision.Text, txtTeamwork.Text, _
                    txtWorkRate.Text, txtPace.Text, txtBalance.Text, txtJumping.Text, txtStrength.Text, txtStamina.Text)

        lblXOverall.Text = reportScore

    End Sub

    Private Sub txtAttributes_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
    Handles txtCrossing.TextChanged, txtDribbling.TextChanged, txtFinishing.TextChanged, txtBallControl.TextChanged, txtPassing.TextChanged, _
    txtHeadingAccuracy.TextChanged, txtMarking.TextChanged, txtTackling.TextChanged, txtAggression.TextChanged, txtPositioning.TextChanged, _
    txtAnticipation.TextChanged, txtComposure.TextChanged, txtVision.TextChanged, txtTeamwork.TextChanged, txtWorkRate.TextChanged, _
        txtPace.TextChanged, txtBalance.TextChanged, txtJumping.TextChanged, txtStrength.TextChanged, txtStamina.TextChanged

        If checkTechnicalNumbers() = False Then
            lblXOverall.Text = "-"
            Exit Sub
        End If
        If checkTacticalNumbers() = False Then
            lblXOverall.Text = "-"
            Exit Sub
        End If
        If checkPhysicalNumbers() = False Then
            lblXOverall.Text = "-"
            Exit Sub
        End If

        setReportScore()

    End Sub

    Private Sub fillPlayerInfo()

        For Each plr As Player In retrievePlayerInfo()

            txtFirstName.Text = plr.PlayerFirstName
            txtSurname.Text = plr.PlayerLastName
            txtPlaceOfBirth.Text = plr.PlaceOfBirth
            txtClub.Text = plr.ClubID
            dtpDOB.Value = plr.DOB

            Dim ms As New IO.MemoryStream(CType(plr.PlayerImage, Byte()))
            Dim returnImage As Image = Image.FromStream(ms)

            pcb1.Image = returnImage

        Next

    End Sub

    Private Sub checkPictureBox()

        If imgLoc = "" Then
            imgLoc = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") & "defaultPlayerImage.jpeg"
        End If

    End Sub

    Private Function checkTechnicalNumbers()

        Dim number As Int32
        Dim invalidTextBoxes =
            From txt In gbTechnical.Controls.OfType(Of TextBox)()
            Where Not Integer.TryParse(txt.Text, number) OrElse number < 1 OrElse number > 20
        Dim correctValidation As Boolean = Not invalidTextBoxes.Any()

        Return correctValidation

    End Function

    Private Function checkTacticalNumbers()

        Dim number As Int32
        Dim invalidTextBoxes =
            From txt In gbTactical.Controls.OfType(Of TextBox)()
            Where Not Integer.TryParse(txt.Text, number) OrElse number < 1 OrElse number > 20
        Dim correctValidation As Boolean = Not invalidTextBoxes.Any()

        Return correctValidation

    End Function

    Private Function checkPhysicalNumbers()

        Dim number As Int32
        Dim invalidTextBoxes =
            From txt In gbPhysical.Controls.OfType(Of TextBox)()
            Where Not Integer.TryParse(txt.Text, number) OrElse number < 1 OrElse number > 20
        Dim correctValidation As Boolean = Not invalidTextBoxes.Any()

        Return correctValidation

    End Function

    Private Function fillClubs()

        'dropdown should contain option between two clubs selected in addFixture
        'if it's a new player use combobox to selected between two clubs
        'if it's an existing player fill textbox and hide combobox

        'txtClub.Text = cmbClub.SelectedItem.ID

        Dim clublist As New List(Of Club)
        clublist.Add(New Club(homeTeam.ClubID, homeTeam.ClubName))
        clublist.Add(New Club(awayTeam.ClubID, awayTeam.ClubName))

        Return clublist

    End Function

    Private Sub setClubs()
        cmbClub.DataSource = fillClubs()
        cmbClub.DisplayMember = "ClubName"
        cmbClub.ValueMember = "ClubID"
    End Sub

End Class