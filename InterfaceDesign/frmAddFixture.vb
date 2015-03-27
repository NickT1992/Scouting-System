Public Class frmAddFixture

    Private Sub frmAddFixture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setClubs()
    End Sub

    Private Sub btnAddNewPlayerReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewPlayerReport.Click

        isNewPlayer = True

        If validFixture() = False Then
            Exit Sub
        End If

        If isNewFixture = True Then
            addFixture()
        End If

        'Me.Hide()
        Dim frmAddReport As New frmAddReport(cmbHomeTeam.SelectedItem, cmbAwayTeam.SelectedItem)
        frmAddReport.ShowDialog()

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        If txtSearchSurname.Text = "" Then
            MsgBox("Please search for an existing player's surname")
            Exit Sub
        End If

        lbPlayers.DataSource = searchSurname(txtSearchSurname.Text)
        lbPlayers.DisplayMember = "PlayerFullName" 'Can't concatenate display member- need to combine datacolumns. Try datatable? FirstName, Surname and Age
        lbPlayers.ValueMember = "PlayerID"

    End Sub

    Private Sub btnAddExistingPlayerReport_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExistingPlayerReport.Click

        isNewPlayer = False

        If validFixture() = False Then
            Exit Sub
        End If

        If lbPlayers.SelectedItem IsNot Nothing Then
            _playerID = lbPlayers.SelectedItem.PlayerID
        Else
            MsgBox("Please search for an existing player's surname")
            Exit Sub
        End If

        If isNewFixture = True Then
            addFixture()
        End If

        Dim frmAddReport As New frmAddReport(cmbHomeTeam.SelectedItem, cmbAwayTeam.SelectedItem)
        frmAddReport.ShowDialog()

    End Sub

    Private Sub addFixture()

            _fixtureID = getMaxID("FixtureID", "Fixture") 'Stored in variable for use in report

            Dim Str As String = _
           <String> INSERT INTO
                    Fixture(
                        FixtureID, 
                        HomeTeamID, 
                        AwayTeamID, 
                        Result, 
                        Venue,
                        WeatherConditions) 
                VALUES(
                        @FixtureID,
                        @HomeTeamID,
                        @AwayTeamID,
                        @Result,
                        @Venue,
                        @WeatherConditions) 
       </String>

            Try
                Using conn As New SqlClient.SqlConnection(DBConnection)
                    conn.Open()
                    Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                        cmdQuery.Parameters.Add("@FixtureID", SqlDbType.Int).Value = _fixtureID 'Stored in variable for use in report
                        cmdQuery.Parameters.Add("@HomeTeamID", SqlDbType.Int).Value = cmbHomeTeam.SelectedItem.ClubID
                        cmdQuery.Parameters.Add("@AwayTeamID", SqlDbType.Int).Value = cmbAwayTeam.SelectedItem.ClubID
                        cmdQuery.Parameters.Add("@Result", SqlDbType.VarChar).Value = txtResult.Text
                        cmdQuery.Parameters.Add("@Venue", SqlDbType.VarChar).Value = txtVenue.Text
                        cmdQuery.Parameters.Add("@WeatherConditions", SqlDbType.VarChar).Value = txtWeather.Text
                        cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being added to, not queried
                    End Using
                End Using

                MsgBox("Fixture Added")

            Catch ex As Exception
                MsgBox("Fixture Exception: " & ex.Message & vbNewLine & Str)
            End Try

    End Sub

    Public Function getClubs()

        Dim typeList As New List(Of Club)
        Dim errorStr As String = ""

        Dim Str As String = _
        <String>
            SELECT	
                *                          	           
            FROM 
                Club                         	                                
            ORDER BY 
                ClubName
        </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            typeList.Add(New Club(drResult("ClubID"), drResult("ClubName")))
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Club Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList

    End Function

    Private Sub setClubs()

        cmbHomeTeam.DataSource = getClubs()
        cmbHomeTeam.DisplayMember = "ClubName"
        cmbHomeTeam.ValueMember = "ClubID"

        cmbAwayTeam.DataSource = getClubs()
        cmbAwayTeam.DisplayMember = "ClubName"
        cmbAwayTeam.ValueMember = "ClubID"

    End Sub

    Public Function searchSurname(ByVal inputSurname As String)

        Dim typeList As New List(Of Player)
        Dim errorStr As String = ""

        Dim Str As String = _
        <String>
            SELECT	
                *                          	           
            FROM 
                Player
            WHERE 
                PlayerLastName LIKE @Surname                                          	                                
        </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@Surname", SqlDbType.VarChar).Value = inputSurname
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
            MsgBox("Surname Search Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return typeList

    End Function

    Private Function validFixture() As Boolean

        If cmbHomeTeam.SelectedItem.ClubID = cmbAwayTeam.SelectedItem.ClubID Then
            MsgBox("Please select two different teams")
            Return False
            Exit Function
        End If

        If txtResult.Text.Length < 3 Then
            MsgBox("Please enter a valid result")
            Return False
            Exit Function
        End If

        Return True

    End Function


End Class