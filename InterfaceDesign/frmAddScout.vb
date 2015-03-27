Public Class frmAddScout

    Dim _ScoutID As Integer = 0

    Private Sub frmAddScout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbClub.DataSource = frmAddFixture.getClubs()
        cmbClub.DisplayMember = "ClubName"
        cmbClub.ValueMember = "ClubID"
    End Sub

    Private Sub btnAddNewScout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewScout.Click

        Select Case MsgBox("Are you sure you want to add this scout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm scout addition")
            Case MsgBoxResult.Yes
                addNewScout()
                addScoutRole()

                'frmEditScout.lbScouts.DataSource = frmEditScout.getAllScouts() 'Re-do when a new scout is added- not working atm
                'frmEditScout.lbScouts.DisplayMember = "ScoutName"
                'frmEditScout.lbScouts.ValueMember = "ScoutID"
                Me.Close()
        End Select

    End Sub

    Private Sub addNewScout()

        _ScoutID = getMaxID("ScoutID", "Scout")

        Dim Str As String = _
       <String> 
                INSERT INTO
                    Scout(
                        ScoutID, 
                        FirstName,
                        LastName,
                        EmailAddress,
                        ClubID) 
                VALUES(
                        @ScoutID,
                        @FirstName,
                        @LastName,
                        @EmailAddress,
                        @ClubID)              
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = _ScoutID
                    cmdQuery.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFirstName.Text
                    cmdQuery.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtSurname.Text
                    cmdQuery.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = txtEmail.Text
                    cmdQuery.Parameters.Add("@ClubID", SqlDbType.Int).Value = cmbClub.SelectedItem.ClubID
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being added to, not queried
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Add Scout Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub addScoutRole()

        Dim Str As String = _
       <String> 
            INSERT INTO
                    ScoutRole(
                        ScoutID,
                        Role,
                        Username,
                        Password)
                VALUES(
                        @ScoutID,
                        @ScoutRole, 
                        @Username,
                        @Password)
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = _ScoutID
                    cmdQuery.Parameters.Add("@ScoutRole", SqlDbType.VarChar).Value = txtRole.Text
                    cmdQuery.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text
                    cmdQuery.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being added to, not queried
                End Using
            End Using
            MsgBox("Scout Added")

        Catch ex As Exception
            MsgBox("Add ScoutRole Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

End Class