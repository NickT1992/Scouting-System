Public Class frmPlayerInfo

    Public myDataTable As DataTable = Nothing
    Public playerList As New List(Of Player)
    Public loaded As Boolean = False
    Private wantAllScouts As Boolean = True
    Private wantFixture As Boolean = True '************************for report
    Private wantPlayer As Boolean = False '************************for report
    Public reportList As New List(Of Report)
    Private selectedReportID As Integer = 0
    Private ind As Integer = 0

    Private Sub frmPlayerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If _scoutRole = "Scout" Then
            UC_Menu_Scout1.TabControl1.TabPages.RemoveByKey("tabPlayerInfo")
            UC_Menu_Scout1.TabControl1.TabPages.RemoveByKey("tabPlayerReports")
            UC_Menu_Scout1.TabControl1.TabPages.RemoveByKey("tabEdit")
            UC_Menu_Scout1.TabControl1.TabPages.RemoveByKey("tabGrid")
            wantAllScouts = False
        End If

        fillGrade()

        UC_Menu_Scout1.cmbScoutName.DataSource = retrieveScouts()
        UC_Menu_Scout1.cmbScoutName.DisplayMember = "ScoutName"
        UC_Menu_Scout1.cmbScoutName.ValueMember = "ScoutID"

        setScout()

        UC_Menu_Scout1.cmbReportDate.DataSource = filterFixtureReports()
        UC_Menu_Scout1.cmbReportDate.DisplayMember = "ReportDate"
        UC_Menu_Scout1.cmbReportDate.ValueMember = "ReportID"

        'UC_Menu_Scout1.cmbSelectedPlayer.DataSource = Nothing
        UC_Menu_Scout1.cmbSelectedPlayer.DataSource = playerList
        UC_Menu_Scout1.cmbSelectedPlayer.DisplayMember = "PlayerFullName"
        UC_Menu_Scout1.cmbSelectedPlayer.ValueMember = "PlayerID"

        cmbPlayerTeam.DataSource = frmAddFixture.getClubs()
        cmbPlayerTeam.DisplayMember = "ClubName"
        cmbPlayerTeam.ValueMember = "ClubID"

        setFixtureReport()

        loaded = True
    End Sub

    Private Sub frmPlayerInfo_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'Me.Visible = False
        'Dim frmLogin As New frmLogin
        'frmLogin.Show()
    End Sub

    Private Sub btnAttributesSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttributesSearch.Click
        Dim frmAttributesSearch As New frmAttributesSearch
        frmAttributesSearch.ShowDialog()
    End Sub

    Private Sub tsbScout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setTSBCheck(sender)
        UC_Menu_Scout1.Visible = True
    End Sub

    Private Sub tsbCoach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setTSBCheck(sender)
        UC_Menu_Scout1.Visible = False
    End Sub

    Private Sub setTSBCheck(ByVal s As System.Object)

        For Each button In Me.ToolStrip1.Items.OfType(Of ToolStripButton)()
            If button IsNot s Then
                button.Checked = False
            Else
                button.Checked = True
            End If
        Next
    End Sub

    'Filters reports based on the selected scout
    Public Function filterFixtureReports() As List(Of Report)

        Dim typeList As New List(Of Report)
        Dim Str As String = _
       <String> SELECT
                    * 
                FROM 
                    Report 
                WHERE
                    ScoutID = (<%= UC_Menu_Scout1.cmbScoutName.SelectedItem.ScoutID %>)
                ORDER BY      
                    ReportDate
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Report(drResult("ReportID"), drResult("ScoutID"), drResult("FixtureID"), drResult("PlayerID"), drResult("ReportDate")))
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList
    End Function
    '*********************************************************************************************
    '*********************************************************************************************
    '*********************************************************************************************
    'Public Function filterFixtures() As List(Of Fixture)

    '    Dim typeList As New List(Of Fixture)
    '    Dim Str As String = _
    '   <String> /*SELECT
    '                * 
    '            FROM 
    '                Fixture
    '            INNER JOIN Report ON Report.FixtureID = Fixture.FixtureID
    '            WHERE
    '                Report.ScoutID = (<%= UC_Menu_Scout1.cmbScoutName.SelectedItem.ScoutID %>)
    '            ORDER BY 
    '                Fixture.FixtureID*/  

    '            SELECT
    '                DISTINCT Report.FixtureID, HomeTeamID, AwayTeamID, ReportID, ReportDate 
    '            FROM 
    '                Fixture
    '            INNER JOIN Report ON Report.FixtureID = Fixture.FixtureID
    '            WHERE
    '                Report.ScoutID = (<%= UC_Menu_Scout1.cmbScoutName.SelectedItem.ScoutID %>)    
    '            Order BY ReportDate     
    '   </String>
    '    Try
    '        Using conn As New SqlClient.SqlConnection(DBConnection)
    '            conn.Open()
    '            Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
    '                Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
    '                    While drResult.Read
    '                        typeList.Add(New Fixture(drResult("FixtureID")) With {
    '                                     .HomeTeamID = drResult("HomeTeamID"),
    '                                     .AwayTeamID = drResult("AwayTeamID"),
    '                                     .ReportID = drResult("ReportID"),
    '                                     .ReportDate = drResult("ReportDate")})
    '                    End While
    '                End Using 'Automatically closes connection
    '            End Using
    '        End Using

    '    Catch ex As Exception
    '        MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
    '    End Try

    '    Return typeList
    'End Function
    '*********************************************************************************************
    '*********************************************************************************************
    '*********************************************************************************************

    Private Sub setScout()

        Dim getScout = (From sct As Scout In retrieveScouts()
                                   Where sct.ScoutID = _scoutID).FirstOrDefault()

        lblScoutName.Text = getScout.ScoutName
        lblEmail.Text = "Contact: " & getScout.EmailAddress

        lblScoutRole.Text = _scoutRole & ":"

    End Sub

    'Public Function retrieveFixtureReport() As List(Of Report)
    '    'Try changing where statement- <%wantPlayerReport%> or <%wantFixtureReport%>
    '    '<%= wantFixtureReport() %>
    '    '<%= wantPlayerReport() %> 
    '    Dim typeList As New List(Of Report)
    '    Dim Str As String = _
    '   <String>                
    '            SELECT 
    '                *
    '            FROM 
    '                Report
    '            WHERE
    '                FixtureID = @FixtureID
    '            ORDER BY 
    '                ReportDate                        
    '   </String>
    '    Try
    '        Using conn As New SqlClient.SqlConnection(DBConnection)
    '            conn.Open()
    '            Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
    '                cmdQuery.Parameters.Add("@FixtureID", SqlDbType.Int).Value = UC_Menu_Scout1.cmbReportDate.SelectedItem.FixtureID
    '                'cmdQuery.Parameters.Add("@SelectedPlayerID", SqlDbType.Int).Value = lbPlayers.SelectedItem.PlayerID
    '                Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
    '                    While drResult.Read
    '                        typeList.Add(New Report(drResult("ReportID"), drResult("ScoutID"), drResult("FixtureID"), drResult("PlayerID"), drResult("ReportDate")) With {
    '                                     .PositionPlayed = drResult("PositionPlayed"),
    '                                     .PreferredFoot = drResult("PreferredFoot"),
    '                                     .Comments = drResult("Comments"),
    '                                     .MonitorStatus = drResult("MonitorStatus"),
    '                                     .Crossing = drResult("Crossing"),
    '                                     .Dribbling = drResult("Dribbling"),
    '                                     .Finishing = drResult("Finishing"),
    '                                     .BallControl = drResult("BallControl"),
    '                                     .Passing = drResult("Passing"),
    '                                     .HeadingAccuracy = drResult("HeadingAccuracy"),
    '                                     .Marking = drResult("Marking"),
    '                                     .Tackling = drResult("Tackling"),
    '                                     .Aggression = drResult("Aggression"),
    '                                     .Positioning = drResult("Positioning"),
    '                                     .Anticipation = drResult("Anticipation"),
    '                                     .Composure = drResult("Composure"),
    '                                     .Vision = drResult("Vision"),
    '                                     .Teamwork = drResult("Teamwork"),
    '                                     .WorkRate = drResult("WorkRate"),
    '                                     .Pace = drResult("Pace"),
    '                                     .Balance = drResult("Balance"),
    '                                     .Jumping = drResult("Jumping"),
    '                                     .Strength = drResult("Strength"),
    '                                     .Stamina = drResult("Stamina"),
    '                                     .Overall = calculateScore(drResult("Crossing"), drResult("Dribbling"), drResult("Finishing"), drResult("BallControl"), _
    '                                       drResult("Passing"), drResult("HeadingAccuracy"), drResult("Marking"), drResult("Tackling"), _
    '                                       drResult("Aggression"), drResult("Positioning"), drResult("Anticipation"), drResult("Composure"), _
    '                                       drResult("Vision"), drResult("Teamwork"), drResult("WorkRate"), drResult("Pace"), _
    '                                       drResult("Balance"), drResult("Jumping"), drResult("Strength"), drResult("Stamina"))})
    '                    End While
    '                End Using 'Automatically closes connection
    '            End Using
    '        End Using

    '    Catch ex As Exception
    '        MsgBox("Fixture Report Exception: " & ex.Message & vbNewLine & Str)
    '    End Try

    '    Return typeList

    'End Function

    '*********************************************************************for report
    Public Function retrieveReport() As List(Of Report)

        Dim typeList As New List(Of Report)
        Dim Str As String = _
        <String>
            <%= wantFixtureReport() %>
            <%= wantPlayerReport() %>
        </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read

                            selectedReportID = drResult("ReportID")
                            typeList.Add(New Report(drResult("ReportID"), drResult("ScoutID"), drResult("FixtureID"), drResult("PlayerID"), drResult("ReportDate")) With {
                                         .PositionPlayed = drResult("PositionPlayed"),
                                         .PreferredFoot = drResult("PreferredFoot"),
                                         .Comments = drResult("Comments"),
                                         .MonitorStatus = drResult("MonitorStatus"),
                                         .Crossing = drResult("Crossing"),
                                         .Dribbling = drResult("Dribbling"),
                                         .Finishing = drResult("Finishing"),
                                         .BallControl = drResult("BallControl"),
                                         .Passing = drResult("Passing"),
                                         .HeadingAccuracy = drResult("HeadingAccuracy"),
                                         .Marking = drResult("Marking"),
                                         .Tackling = drResult("Tackling"),
                                         .Aggression = drResult("Aggression"),
                                         .Positioning = drResult("Positioning"),
                                         .Anticipation = drResult("Anticipation"),
                                         .Composure = drResult("Composure"),
                                         .Vision = drResult("Vision"),
                                         .Teamwork = drResult("Teamwork"),
                                         .WorkRate = drResult("WorkRate"),
                                         .Pace = drResult("Pace"),
                                         .Balance = drResult("Balance"),
                                         .Jumping = drResult("Jumping"),
                                         .Strength = drResult("Strength"),
                                         .Stamina = drResult("Stamina"),
                                         .Overall = calculateScore(drResult("Crossing"), drResult("Dribbling"), drResult("Finishing"), drResult("BallControl"), _
                                           drResult("Passing"), drResult("HeadingAccuracy"), drResult("Marking"), drResult("Tackling"), _
                                           drResult("Aggression"), drResult("Positioning"), drResult("Anticipation"), drResult("Composure"), _
                                           drResult("Vision"), drResult("Teamwork"), drResult("WorkRate"), drResult("Pace"), _
                                           drResult("Balance"), drResult("Jumping"), drResult("Strength"), drResult("Stamina"))})
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList

    End Function

    '*********************************************************************for report
    Private Function wantFixtureReport() As String

        If wantFixture = True Then

            Return <String>
                SELECT 
                    *
                FROM 
                    Report
                WHERE
                    FixtureID = <%= UC_Menu_Scout1.cmbReportDate.SelectedItem.FixtureID %>
                ORDER BY
                    ReportDate
                   </String>
        Else
            Return ""

        End If

    End Function

    Private Function wantPlayerReport() As String

        If wantPlayer = True Then

            Return <String>
                SELECT 
                    *,
                    isNull(Player.PlayerFirstName + ' ' + Player.PlayerLastName, ' ') AS 'PlayerName' 
                FROM 
                    Report 
                INNER JOIN Player ON Player.PlayerID = Report.PlayerID
                INNER JOIN Fixture ON Fixture.FixtureID = Report.FixtureID
                WHERE
                    Player.PlayerID = <%= lbPlayers.SelectedItem.PlayerID %>
                ORDER BY
                    ReportDate
                  </String>
        Else
            Return ""

        End If

    End Function
    '*********************************************************************for report

    Public Function retrievePlayerList()

        Dim typeList As New List(Of Player)
        Dim Str As String = _
       <String> SELECT
                   *
                FROM 
                    Player 
                INNER JOIN Report ON Report.PlayerID = Player.PlayerID
                /*INNER JOIN Club ON Club.ClubID = Player.ClubID*/
                WHERE
                    Report.FixtureID = @FixtureID
                ORDER BY 
                    Player.PlayerLastName      
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@FixtureID", SqlDbType.Int).Value = UC_Menu_Scout1.cmbReportDate.SelectedItem.FixtureID
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Player(drResult("PlayerID")) With {
                                         .PlayerFirstName = drResult("PlayerFirstName"),
                                         .PlayerLastName = drResult("PlayerLastName")})
                            'Add ClubID/Name - look at outher Inner Joins
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList
    End Function

    Public Sub setFixtureReport()

        If UC_Menu_Scout1.cmbSelectedPlayer.SelectedIndex < 0 Then
            UC_Menu_Scout1.cmbSelectedPlayer.SelectedIndex = 0
        End If
        ind = UC_Menu_Scout1.cmbSelectedPlayer.SelectedIndex 'if want fixture

        'Dim player = Nothing

        'If wantFixture = True Then
        'Player = TryCast(UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem, Player) 'Combobox is bound to a List(Of Report), selectedItem cast to it's type:
        'Else
        'Player = TryCast(lbPlayers.SelectedItem, Player)

        reportList.Clear()
        reportList = retrieveReport()

        'reportList(0).PositionPlayed

        'reportList.Clear()
        'For Each r As Report In retrieveReport() 'Add to list- like playerlist
        'reportList.Add(r)
        'r.P()
        'Next

        'End If

        'If Not player Is Nothing Then
        '    Dim getPlayerReport = (From rpt As Report In retrieveReport()
        '                                                   Where rpt.PlayerID = player.PlayerID).FirstOrDefault()

        '    If Not getPlayerReport Is Nothing Then

        '*****General Information
        UC_Menu_Scout1.lblRptPosition.Text = reportList(ind).PositionPlayed

        UC_Menu_Scout1.lblFoot.Text = reportList(ind).PreferredFoot
        UC_Menu_Scout1.txtComments.Text = reportList(ind).Comments
        UC_Menu_Scout1.lblStatus.Text = reportList(ind).MonitorStatus

        UC_Menu_Scout1.lblReportNumber.Text = countReports() & " Report(s) From "
        UC_Menu_Scout1.lblScoutNumber.Text = countScouts() & " Scout(s)"
        UC_Menu_Scout1.lblMainPosition.Text = getMainPosition()
        UC_Menu_Scout1.lblFoot.Text = getMainFoot()
        '*****Technical
        UC_Menu_Scout1.UcAttributes1.lblXCrossing.Text = reportList(ind).Crossing
        UC_Menu_Scout1.UcAttributes1.lblXDribbling.Text = reportList(ind).Dribbling
        UC_Menu_Scout1.UcAttributes1.lblXFinishing.Text = reportList(ind).Finishing
        UC_Menu_Scout1.UcAttributes1.lblXBallControl.Text = reportList(ind).BallControl
        UC_Menu_Scout1.UcAttributes1.lblXPassing.Text = reportList(ind).Passing
        UC_Menu_Scout1.UcAttributes1.lblXHeadingAccuracy.Text = reportList(ind).HeadingAccuracy
        UC_Menu_Scout1.UcAttributes1.lblXMarking.Text = reportList(ind).Marking
        UC_Menu_Scout1.UcAttributes1.lblXTackling.Text = reportList(ind).Tackling
        '*****Mental
        UC_Menu_Scout1.UcAttributes1.lblXAggression.Text = reportList(ind).Aggression
        UC_Menu_Scout1.UcAttributes1.lblXPositioning.Text = reportList(ind).Positioning
        UC_Menu_Scout1.UcAttributes1.lblXAnticipation.Text = reportList(ind).Anticipation
        UC_Menu_Scout1.UcAttributes1.lblXComposure.Text = reportList(ind).Composure
        UC_Menu_Scout1.UcAttributes1.lblXVision.Text = reportList(ind).Vision
        UC_Menu_Scout1.UcAttributes1.lblXTeamwork.Text = reportList(ind).Teamwork
        UC_Menu_Scout1.UcAttributes1.lblXWorkRate.Text = reportList(ind).WorkRate
        '*****Physical
        UC_Menu_Scout1.UcAttributes1.lblXPace.Text = reportList(ind).Pace
        UC_Menu_Scout1.UcAttributes1.lblXBalance.Text = reportList(ind).Balance
        UC_Menu_Scout1.UcAttributes1.lblXJumping.Text = reportList(ind).Jumping
        UC_Menu_Scout1.UcAttributes1.lblXStrength.Text = reportList(ind).Strength
        UC_Menu_Scout1.UcAttributes1.lblXStamina.Text = reportList(ind).Stamina

        UC_Menu_Scout1.UcAttributes1.lblXOverall.Text = reportList(ind).Overall

        setColours(UC_Menu_Scout1.UcAttributes1.lblXCrossing, UC_Menu_Scout1.UcAttributes1.lblXCrossing.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXDribbling, UC_Menu_Scout1.UcAttributes1.lblXDribbling.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXFinishing, UC_Menu_Scout1.UcAttributes1.lblXFinishing.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXBallControl, UC_Menu_Scout1.UcAttributes1.lblXBallControl.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXPassing, UC_Menu_Scout1.UcAttributes1.lblXPassing.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXHeadingAccuracy, UC_Menu_Scout1.UcAttributes1.lblXHeadingAccuracy.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXMarking, UC_Menu_Scout1.UcAttributes1.lblXMarking.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXTackling, UC_Menu_Scout1.UcAttributes1.lblXTackling.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXAggression, UC_Menu_Scout1.UcAttributes1.lblXAggression.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXPositioning, UC_Menu_Scout1.UcAttributes1.lblXPositioning.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXAnticipation, UC_Menu_Scout1.UcAttributes1.lblXAnticipation.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXComposure, UC_Menu_Scout1.UcAttributes1.lblXComposure.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXVision, UC_Menu_Scout1.UcAttributes1.lblXVision.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXTeamwork, UC_Menu_Scout1.UcAttributes1.lblXTeamwork.Text, _
           UC_Menu_Scout1.UcAttributes1.lblXWorkRate, UC_Menu_Scout1.UcAttributes1.lblXWorkRate.Text, _
            UC_Menu_Scout1.UcAttributes1.lblXPace, UC_Menu_Scout1.UcAttributes1.lblXPace.Text, _
            UC_Menu_Scout1.UcAttributes1.lblXBalance, UC_Menu_Scout1.UcAttributes1.lblXBalance.Text, _
            UC_Menu_Scout1.UcAttributes1.lblXJumping, UC_Menu_Scout1.UcAttributes1.lblXJumping.Text, _
            UC_Menu_Scout1.UcAttributes1.lblXStrength, UC_Menu_Scout1.UcAttributes1.lblXStrength.Text, _
            UC_Menu_Scout1.UcAttributes1.lblXStamina, UC_Menu_Scout1.UcAttributes1.lblXStamina.Text)

        setAllAverages()
        'End If
        'End If
    End Sub

    Public Function retrieveScouts() As List(Of Scout)

        Dim typeList As New List(Of Scout)
        Dim errorStr As String = ""

        Dim Str As String = _
        <String>
            SELECT	
                *,  				            
                isNull(FirstName + ' ' + LastName, ' ') AS 'ScoutName'                        	           
            FROM 
                Scout
            <%= showAllScouts() %>                         	                                
            ORDER BY 
                ScoutName
        </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Scout(drResult("ScoutID"), drResult("ScoutName")) With {
                                         .EmailAddress = drResult("EmailAddress")})
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Scout Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList

    End Function

    Private Function showAllScouts() As String

        If wantAllScouts Then
            Return ""
        Else
            Return "WHERE ScoutID = " & _scoutID.ToString
        End If

    End Function

    Private Sub fillGrade()
        UC_Menu_Scout1.cmbGrade.Items.Add("Ungraded")
        UC_Menu_Scout1.cmbGrade.Items.Add("A")
        UC_Menu_Scout1.cmbGrade.Items.Add("B")
        UC_Menu_Scout1.cmbGrade.Items.Add("C")
        UC_Menu_Scout1.cmbGrade.Items.Add("D")       
    End Sub

    Public Sub setPlayerInfo()

        Dim currentPlayerID As Integer = 0

        If wantFixture = True Then
            currentPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            currentPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim Str As String = _
       <String> SELECT
                   *,
                   isNull(Player.PlayerFirstName + ' ' + Player.PlayerLastName, ' ') AS 'PlayerName' 
                FROM 
                    Player 
                INNER JOIN Report ON Report.PlayerID = Player.PlayerID
                INNER JOIN Fixture ON Fixture.FixtureID = Report.FixtureID
                INNER JOIN Club ON Club.ClubID = Player.ClubID
                WHERE
                    Report.PlayerID = @PlayerID
                ORDER BY 
                    Player.PlayerLastName      
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = currentPlayerID 'Sometimes nothing selected- never errors on load
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            UC_Menu_Scout1.lblRptPlayerName.Text = drResult("PlayerName") 'Breakpoint here- called multiple times
                            UC_Menu_Scout1.lblRptAge.Text = drResult("Age")
                            UC_Menu_Scout1.lblRptClub.Text = drResult("ClubName")

                            UC_Menu_Scout1.lblDisplayName.Text = drResult("PlayerName")
                            UC_Menu_Scout1.lblAge.Text = drResult("Age")
                            UC_Menu_Scout1.lblClub.Text = drResult("ClubName")
                            UC_Menu_Scout1.lblPlaceOfBirth.Text = drResult("PlaceOfBirth")
                            UC_Menu_Scout1.lblDOB.Text = drResult("DOB")
                            If Not IsDBNull(drResult("Grade")) Then
                                UC_Menu_Scout1.cmbGrade.SelectedItem = drResult("Grade")
                            Else
                                UC_Menu_Scout1.cmbGrade.SelectedIndex = 0
                            End If

                            Dim pictureData As Byte() = DirectCast(drResult("PlayerImage"), Byte())

                            Dim picture As Image = Nothing

                            'Create a stream in memory containing the bytes that comprise the image.
                            Using stream As New IO.MemoryStream(pictureData)
                                'Read the stream and create an Image object from the data.'
                                picture = Image.FromStream(stream)
                            End Using

                            UC_Menu_Scout1.PictureBox1.Image = picture

                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("SetPlayerInfo Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Public Sub setFixtureInfo() 'Only called once, why is setPlayerInfo called 3 times?
        'How to get ClubName in Club table from Home/AwayTeamID in Fixture table

        Dim currentFixtureID As Integer = 0

        If wantFixture = True Then
            currentFixtureID = UC_Menu_Scout1.cmbReportDate.SelectedItem.FixtureID
        Else
            currentFixtureID = getFixtureID()
        End If

        Dim Str As String = _
       <String> SELECT
                   */*,
                    Club.ClubID,    
                    Club.ClubName
                   isNull(Fixture.HomeTeamID + ' ' + Fixture.AwayTeamID, ' ') AS 'FullFixture'*/ 
                FROM 
                    Fixture
                /*INNER JOIN Club ON Club.ClubID = Fixture.HomeTeamID
                INNER JOIN Club ON Club.ClubID = Fixture.AwayTeamID*/
                WHERE
                    Fixture.FixtureID = @FixtureID    
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@FixtureID", SqlDbType.Int).Value = currentFixtureID 'Sometimes nothing selected- never errors on load
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            UC_Menu_Scout1.lblFixture.Text = drResult("HomeTeamID") & " Vs " & drResult("AwayTeamID") 'Need to convert ID's from fixture table to ClubID's in Club table- add in class
                            UC_Menu_Scout1.lblVenue.Text = drResult("Venue")
                            UC_Menu_Scout1.lblResult.Text = drResult("Result")
                            UC_Menu_Scout1.lblConditions.Text = drResult("WeatherConditions")
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("SetFixtureInfo Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Function getFixtureID()

        Dim fixtureID As Integer
        Dim Str As String = _
       <String> SELECT
                   FixtureID 
                FROM 
                    Report
                WHERE
                    ReportID = @ReportID    
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ReportID", SqlDbType.Int).Value = selectedReportID
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            fixtureID = drResult("FixtureID")
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("SetFixtureInfo Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return fixtureID

    End Function

    Private Sub colourSort(ByVal lbl As Label, ByVal value As Integer)

        Select Case value
            Case 0 To 5
                lbl.ForeColor = Color.DarkSlateGray
            Case 6 To 10
                lbl.ForeColor = Color.Black
            Case 11 To 15
                lbl.ForeColor = Color.SteelBlue
            Case 16 To 20
                lbl.ForeColor = Color.Blue
            Case Else
                lbl.ForeColor = Color.Red
        End Select

    End Sub

    Private Sub setColours(ByVal cro As Label, ByVal cro2 As String, ByVal dri As Label, ByVal dri2 As String, _
     ByVal fin As Label, ByVal fin2 As String, ByVal bct As Label, ByVal bct2 As String, ByVal pas As Label, ByVal pas2 As String, _
     ByVal hea As Label, ByVal hea2 As String, ByVal mar As Label, ByVal mar2 As String, ByVal tac As Label, ByVal tac2 As String, _
     ByVal agg As Label, ByVal agg2 As String, ByVal pos As Label, ByVal pos2 As String, ByVal ant As Label, ByVal ant2 As String, _
     ByVal com As Label, ByVal com2 As String, ByVal vis As Label, ByVal vis2 As String, ByVal twk As Label, ByVal twk2 As String, _
     ByVal wkr As Label, ByVal wkr2 As String, ByVal pac As Label, ByVal pac2 As String, ByVal bal As Label, ByVal bal2 As String, _
     ByVal jmp As Label, ByVal jmp2 As String, ByVal str As Label, ByVal str2 As String, ByVal sta As Label, ByVal sta2 As String)

        '*****Technical
        colourSort(cro, Integer.Parse(cro2))
        colourSort(dri, Integer.Parse(dri2))
        colourSort(fin, Integer.Parse(fin2))
        colourSort(bct, Integer.Parse(bct2))
        colourSort(pas, Integer.Parse(pas2))
        colourSort(hea, Integer.Parse(hea2))
        colourSort(mar, Integer.Parse(mar2))
        colourSort(tac, Integer.Parse(tac2))
        '*****Mental
        colourSort(agg, Integer.Parse(agg2))
        colourSort(pos, Integer.Parse(pos2))
        colourSort(ant, Integer.Parse(ant2))
        colourSort(com, Integer.Parse(com2))
        colourSort(vis, Integer.Parse(vis2))
        colourSort(twk, Integer.Parse(twk2))
        colourSort(wkr, Integer.Parse(wkr2))
        '*****Physical
        colourSort(pac, Integer.Parse(pac2))
        colourSort(bal, Integer.Parse(bal2))
        colourSort(jmp, Integer.Parse(jmp2))
        colourSort(str, Integer.Parse(str2))
        colourSort(sta, Integer.Parse(sta2))

    End Sub

    Public Function calculateScore(ByVal crossing As Integer, ByVal dribbling As Integer, ByVal finishing As Integer, _
                                    ByVal ballControl As Integer, ByVal passing As Integer, ByVal headingAccuracy As Integer, _
                                    ByVal marking As Integer, ByVal tackling As Integer, ByVal aggression As Integer, _
                                    ByVal positioning As Integer, ByVal anticipation As Integer, ByVal composure As Integer, _
                                    ByVal vision As Integer, ByVal teamwork As Integer, ByVal workRate As Integer, ByVal pace As Integer, _
                                    ByVal balance As Integer, ByVal jumping As Integer, ByVal strength As Integer, ByVal stamina As Integer)

        Dim score As Integer = 0

        score = ((crossing + dribbling + finishing + ballControl + passing + _
                headingAccuracy + marking + tackling + aggression + positioning + _
                anticipation + composure + vision + teamwork + workRate + pace + _
                balance + jumping + strength + stamina) / 400) * 100

        Return score

    End Function

    Public Function retrieveDT() As DataTable 'Retrieves for one player- change on index change. Could fill DT for each report from scout, or just selected report then all fields are accessible
        'Try select distinct for report dates, then cycle through players scouted on the same date/report
        'Could run this separately to retrievePlayerInfo, and just fill player/fixture info, not report info
        Dim Str As String = _
       <String> SELECT                 
                    *
                FROM 
                    Report
                WHERE 
                    PlayerID = @PlayerID
                ORDER BY 
                    ReportID    
       </String>

        Dim dt As New DataTable
        Using conn As New SqlClient.SqlConnection(DBConnection)
            conn.Open()
            Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = 52
                cmdQuery.CommandTimeout = 600

                Try
                    Using daResults As New SqlClient.SqlDataAdapter(cmdQuery)
                        daResults.Fill(dt)
                    End Using
                Catch ex As Exception
                    MsgBox("An Exception has happened: " & ex.Message & vbNewLine)
                End Try

            End Using 'Automatically closes connection
        End Using

        Return dt

    End Function

    Private Function calculateAverage(ByVal colName As String) As Integer

        Dim selectedPlayerID As Integer = 0

        If wantFixture = True Then
            selectedPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            selectedPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim average As Integer = 0
        Dim Str As String = _
       <String> SELECT ROUND(AVG(<%= colName %>),0)
                FROM 
                    Report 
                WHERE
                    PlayerID = (<%= selectedPlayerID %>)    
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    average = Convert.ToInt16(cmdQuery.ExecuteScalar())
                End Using 'Automatically closes connection
            End Using

        Catch ex As Exception
            MsgBox("Average Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return average
        MsgBox(average)

    End Function

    Private Sub setAllAverages()

        UC_Menu_Scout1.UcAttributes2.lblXCrossing.Text = calculateAverage("Crossing")
        UC_Menu_Scout1.UcAttributes2.lblXDribbling.Text = calculateAverage("Dribbling")
        UC_Menu_Scout1.UcAttributes2.lblXFinishing.Text = calculateAverage("Finishing")
        UC_Menu_Scout1.UcAttributes2.lblXBallControl.Text = calculateAverage("BallControl")
        UC_Menu_Scout1.UcAttributes2.lblXPassing.Text = calculateAverage("Passing")
        UC_Menu_Scout1.UcAttributes2.lblXHeadingAccuracy.Text = calculateAverage("HeadingAccuracy")
        UC_Menu_Scout1.UcAttributes2.lblXMarking.Text = calculateAverage("Marking")
        UC_Menu_Scout1.UcAttributes2.lblXTackling.Text = calculateAverage("Tackling")
        UC_Menu_Scout1.UcAttributes2.lblXAggression.Text = calculateAverage("Aggression")
        UC_Menu_Scout1.UcAttributes2.lblXPositioning.Text = calculateAverage("Positioning")
        UC_Menu_Scout1.UcAttributes2.lblXAnticipation.Text = calculateAverage("Anticipation")
        UC_Menu_Scout1.UcAttributes2.lblXComposure.Text = calculateAverage("Composure")
        UC_Menu_Scout1.UcAttributes2.lblXVision.Text = calculateAverage("Vision")
        UC_Menu_Scout1.UcAttributes2.lblXTeamwork.Text = calculateAverage("Teamwork")
        UC_Menu_Scout1.UcAttributes2.lblXWorkRate.Text = calculateAverage("WorkRate")
        UC_Menu_Scout1.UcAttributes2.lblXPace.Text = calculateAverage("Pace")
        UC_Menu_Scout1.UcAttributes2.lblXBalance.Text = calculateAverage("Balance")
        UC_Menu_Scout1.UcAttributes2.lblXJumping.Text = calculateAverage("Jumping")
        UC_Menu_Scout1.UcAttributes2.lblXStrength.Text = calculateAverage("Strength")
        UC_Menu_Scout1.UcAttributes2.lblXStamina.Text = calculateAverage("Stamina")
        UC_Menu_Scout1.UcAttributes2.lblXOverall.Text = calculateAverage("Overall") 'Should be in retrieve report?

        setColours(UC_Menu_Scout1.UcAttributes2.lblXCrossing, UC_Menu_Scout1.UcAttributes2.lblXCrossing.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXDribbling, UC_Menu_Scout1.UcAttributes2.lblXDribbling.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXFinishing, UC_Menu_Scout1.UcAttributes2.lblXFinishing.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXBallControl, UC_Menu_Scout1.UcAttributes2.lblXBallControl.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXPassing, UC_Menu_Scout1.UcAttributes2.lblXPassing.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXHeadingAccuracy, UC_Menu_Scout1.UcAttributes2.lblXHeadingAccuracy.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXMarking, UC_Menu_Scout1.UcAttributes2.lblXMarking.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXTackling, UC_Menu_Scout1.UcAttributes2.lblXTackling.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXAggression, UC_Menu_Scout1.UcAttributes2.lblXAggression.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXPositioning, UC_Menu_Scout1.UcAttributes2.lblXPositioning.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXAnticipation, UC_Menu_Scout1.UcAttributes2.lblXAnticipation.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXComposure, UC_Menu_Scout1.UcAttributes2.lblXComposure.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXVision, UC_Menu_Scout1.UcAttributes2.lblXVision.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXTeamwork, UC_Menu_Scout1.UcAttributes2.lblXTeamwork.Text, _
                   UC_Menu_Scout1.UcAttributes2.lblXWorkRate, UC_Menu_Scout1.UcAttributes2.lblXWorkRate.Text, _
                    UC_Menu_Scout1.UcAttributes2.lblXPace, UC_Menu_Scout1.UcAttributes2.lblXPace.Text, _
                    UC_Menu_Scout1.UcAttributes2.lblXBalance, UC_Menu_Scout1.UcAttributes2.lblXBalance.Text, _
                    UC_Menu_Scout1.UcAttributes2.lblXJumping, UC_Menu_Scout1.UcAttributes2.lblXJumping.Text, _
                    UC_Menu_Scout1.UcAttributes2.lblXStrength, UC_Menu_Scout1.UcAttributes2.lblXStrength.Text, _
                    UC_Menu_Scout1.UcAttributes2.lblXStamina, UC_Menu_Scout1.UcAttributes2.lblXStamina.Text)

    End Sub

    Public Function countScouts() As Integer

        Dim selectedPlayerID As Integer = 0

        If wantFixture = True Then
            selectedPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            selectedPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim scoutNumbers As Integer
        Dim Str As String = _
       <String> SELECT COUNT(DISTINCT ScoutID)
                FROM 
                    Report 
                WHERE
                    PlayerID = (<%= selectedPlayerID %>)      
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    scoutNumbers = Convert.ToInt16(cmdQuery.ExecuteScalar())
                End Using 'Automatically closes connection
            End Using

        Catch ex As Exception
            MsgBox("Scout Count Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return scoutNumbers

    End Function

    Public Function countReports() As Integer

        Dim selectedPlayerID As Integer = 0

        If wantFixture = True Then
            'If UC_Menu_Scout1.cmbSelectedPlayer.Items.Count > 0 Then
            selectedPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
            'End If
        Else
        selectedPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim reportNumbers As Integer
        Dim Str As String = _
       <String> SELECT COUNT(ReportID)
                FROM 
                    Report 
                WHERE
                    PlayerID = (<%= selectedPlayerID %>)     
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    reportNumbers = Convert.ToInt16(cmdQuery.ExecuteScalar())
                End Using 'Automatically closes connection
            End Using

        Catch ex As Exception
            MsgBox("Report Count Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return reportNumbers

    End Function

    Public Function getMainPosition() As String

        Dim selectedPlayerID As Integer = 0

        If wantFixture = True Then
            selectedPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            selectedPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim position As String = ""
        Dim Str As String = _
       <String> SELECT       
                    Report.PositionPlayed,
                COUNT(Report.PositionPlayed) AS value_occurrence
                FROM Report
                WHERE 
                    Report.PlayerID = (<%= selectedPlayerID %>) 
                GROUP BY Report.PositionPlayed
                ORDER BY value_occurrence DESC

       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    position = cmdQuery.ExecuteScalar()
                End Using 'Automatically closes connection
            End Using

        Catch ex As Exception
            MsgBox("Main Position Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return position

    End Function

    Public Function getMainFoot() As String

        Dim selectedPlayerID As Integer = 0

        If wantFixture = True Then
            selectedPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            selectedPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim foot As String = ""
        Dim Str As String = _
       <String> SELECT       
                    Report.PreferredFoot,
                COUNT(Report.PreferredFoot) AS value_occurrence
                FROM Report
                WHERE 
                    Report.PlayerID = (<%= selectedPlayerID %>) 
                GROUP BY Report.PreferredFoot
                ORDER BY value_occurrence DESC

       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    foot = cmdQuery.ExecuteScalar()
                End Using 'Automatically closes connection
            End Using

        Catch ex As Exception
            MsgBox("Main Foot Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return foot

    End Function

    Private Sub btnQuickSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnQuickSearch.Click

        If txtName.Text = "" Then
            MsgBox("Please search for an existing player's surname")
            Exit Sub
        End If

        lbPlayers.DataSource = frmAddFixture.searchSurname(txtName.Text)
        lbPlayers.DisplayMember = "PlayerFullName"
        lbPlayers.ValueMember = "PlayerID"

        UC_Menu_Scout1.TabControl1.SelectedIndex = 2

    End Sub

    Private Sub lbPlayers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbPlayers.SelectedIndexChanged

        If lbPlayers.Items.Count > 0 Then
            If wantPlayer = True Then

                '************************for report
                'wantFixture = False
                'wantPlayer = True
                setPlayerInfo()
                setFixtureInfo()
                setFixtureReport()
                '************************
            End If

        End If

    End Sub

    Private Sub cmbPlayerTeam_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPlayerTeam.SelectedIndexChanged

        If cmbPlayerTeam.SelectedItem IsNot Nothing Then
            lbPlayers.DataSource = getPlayersByClub()
            lbPlayers.DisplayMember = "PlayerFullName"
            lbPlayers.ValueMember = "PlayerID"
        End If

    End Sub

    Public Function getPlayersByClub() As List(Of Player)

        Dim typeList As New List(Of Player)
        Dim Str As String = _
       <String> SELECT
                    PlayerID,
                    PlayerFirstName,
                    PlayerLastName 
                FROM 
                    Player 
                WHERE
                    Player.ClubID = (<%= cmbPlayerTeam.SelectedItem.ClubID %>)
                ORDER BY 
                    PlayerLastName      
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Player(drResult("PlayerID")) With {
                                         .PlayerFirstName = drResult("PlayerFirstName"),
                                         .PlayerLastName = drResult("PlayerLastName")})
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList
    End Function

    Public Function filterPlayerReports() As List(Of Report)

        Dim typeList As New List(Of Report) 'ScoutID passed from Login*****
        Dim Str As String = _
       <String> SELECT
                    * 
                FROM 
                    Report 
                WHERE
                    ScoutID = 2 /*(<%= UC_Menu_Scout1.cmbScoutName.SelectedItem.ScoutID %>)*/ 
                AND PlayerID = @PlayerID
                ORDER BY 
                    ReportDate      
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = lbPlayers.SelectedItem.PlayerID
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Report(drResult("ReportID"), drResult("ScoutID"), drResult("FixtureID"), drResult("PlayerID"), drResult("ReportDate")))
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Report Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList
    End Function

    Private Sub frmPlayerInfo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Dispose()
    End Sub

    Private Sub chkSearchPlayer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSearchPlayer.CheckedChanged

        If chkSearchPlayer.Checked = True Then
            wantPlayer = True
            wantFixture = False
        Else
            wantPlayer = False
            wantFixture = True
        End If

    End Sub

    Public Sub updateGrade()

        Dim currentPlayerID As Integer = 0

        If wantFixture = True Then
            currentPlayerID = UC_Menu_Scout1.cmbSelectedPlayer.SelectedItem.PlayerID
        Else
            currentPlayerID = lbPlayers.SelectedItem.PlayerID
        End If

        Dim Str As String = _
       <String> 
               UPDATE Player
                SET Grade = @Grade                    
                WHERE PlayerID = @PlayerID
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = currentPlayerID
                    cmdQuery.Parameters.Add("@Grade", SqlDbType.VarChar).Value = UC_Menu_Scout1.cmbGrade.SelectedItem.ToString
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                End Using
            End Using

            MsgBox(UC_Menu_Scout1.lblDisplayName.Text & "'s grade has been set to " & UC_Menu_Scout1.cmbGrade.SelectedItem.ToString)

        Catch ex As Exception
            MsgBox("Update Grade Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

End Class