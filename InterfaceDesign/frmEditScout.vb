Public Class frmEditScout

    Private Sub frmEditScout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cmbClub.DataSource = frmAddFixture.getClubs()
        cmbClub.DisplayMember = "ClubName"
        cmbClub.ValueMember = "ClubID"

        lbScouts.DataSource = getAllScouts() 'Re-do when a new scout is added
        lbScouts.DisplayMember = "ScoutName"
        lbScouts.ValueMember = "ScoutID"
    End Sub

    Private Sub lbScouts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbScouts.SelectedIndexChanged
        fillScoutInfo()
    End Sub

    Private Sub btnAddNewScout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewScout.Click
        Dim frmAddScout As New frmAddScout
        frmAddScout.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        Select Case MsgBox("Are you sure you want to edit this scout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Changes")
            Case MsgBoxResult.Yes
                updateScoutInfo()
                Me.Close()
        End Select

    End Sub

    Private Sub btnDeleteScout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteScout.Click
        'Problem with deleting scouts with reports? Justify that we want to keep the scout because his reports are still useful
        Select Case MsgBox("Are you sure you want to delete this scout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Deletion")
            Case MsgBoxResult.Yes
                deleteScoutRole() 'ScoutRole ahs to be deleted first, because of the dependancies in between tables
                deleteScout()
                Me.Close()
        End Select

    End Sub

    Public Function getAllScouts()

        Dim allScouts As New List(Of Scout)

        Dim Str As String = _
       <String> SELECT 
                    *,
                    isNull(FirstName + ' ' + LastName, ' ') AS 'ScoutName' 
                FROM 
                    Scout   
                INNER JOIN ScoutRole ON ScoutRole.ScoutID = Scout.ScoutID
                INNER JOIN Club ON Club.ClubID = Scout.ClubID                           
                Order By   
                    ScoutName
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read
                            allScouts.Add(New Scout(drResult("ScoutID"), (drResult("ScoutName"))) With {
                                         .ScoutFirstName = drResult("FirstName"),
                                         .ScoutLastName = drResult("LastName"),
                                         .EmailAddress = drResult("EmailAddress"),
                                         .ScoutRole = drResult("Role"),
                                         .Username = drResult("Username"),
                                         .Password = drResult("Password"),
                                         .ClubID = drResult("ClubID"),
                                         .ClubName = drResult("ClubName")})
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("All Scouts Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return allScouts

    End Function

    Private Sub fillScoutInfo()

        For Each sct As Scout In getAllScouts()

            If lbScouts.SelectedItem.ScoutID = sct.ScoutID Then

                txtFirstName.Text = sct.ScoutFirstName
                txtSurname.Text = sct.ScoutLastName
                txtEmail.Text = sct.EmailAddress
                txtRole.Text = sct.ScoutRole
                txtUsername.Text = sct.Username
                txtPassword.Text = sct.Password
                cmbClub.SelectedValue = sct.ClubID
            End If
        Next

    End Sub

    Private Sub updateScoutInfo()

        Dim Str As String = _
       <String> 
           BEGIN TRANSACTION

                UPDATE Scout
                SET FirstName = @ScoutFirstName, 
                    LastName = @ScoutLastName, 
                    EmailAddress = @EmailAddress,
                    ClubID = @ClubID
                WHERE ScoutID = @ScoutID

                UPDATE ScoutRole
                SET Role = @ScoutRole,
                    Username = @Username,
                    Password = @Password
                WHERE ScoutID = @ScoutID

            COMMIT
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = lbScouts.SelectedItem.ScoutID
                    cmdQuery.Parameters.Add("@ScoutFirstName", SqlDbType.VarChar).Value = txtFirstName.Text
                    cmdQuery.Parameters.Add("@ScoutLastName", SqlDbType.VarChar).Value = txtSurname.Text
                    cmdQuery.Parameters.Add("@ScoutRole", SqlDbType.VarChar).Value = txtRole.Text
                    cmdQuery.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = txtEmail.Text
                    cmdQuery.Parameters.Add("@ClubID", SqlDbType.VarChar).Value = cmbClub.SelectedItem.ClubID
                    cmdQuery.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text
                    cmdQuery.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                End Using
            End Using
            MsgBox(txtFirstName.Text & " " & txtSurname.Text & "'s profile has been updated.")

        Catch ex As Exception
            MsgBox("Edit Scout Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub deleteScout()

        Dim Str As String = _
       <String> 
                DELETE FROM Scout
                WHERE ScoutID = @ScoutID
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = lbScouts.SelectedItem.ScoutID
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                End Using
            End Using

            'lbPlayers.Items.Remove(lbPlayers.SelectedItem) 'Throws error- refill from DT?

        Catch ex As Exception
            MsgBox("Delete Scout Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub deleteScoutRole()

        Dim Str As String = _
       <String> 
                DELETE FROM ScoutRole
                WHERE ScoutID = @ScoutID
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@ScoutID", SqlDbType.Int).Value = lbScouts.SelectedItem.ScoutID
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                End Using
            End Using

            'lbPlayers.Items.Remove(lbPlayers.SelectedItem) 'Throws error- refill from DT?
            MsgBox("Scout Deleted")

        Catch ex As Exception
            MsgBox("Delete ScoutRole Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

End Class



