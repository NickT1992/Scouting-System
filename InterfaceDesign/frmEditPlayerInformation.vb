Public Class frmEditPlayerInformation

    Dim imgLoc As String = ""

    Private Sub frmEditPlayerInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbClub.DataSource = frmAddFixture.getClubs()
        cmbClub.DisplayMember = "ClubName"
        cmbClub.ValueMember = "ClubID"

        lbPlayers.DataSource = getAllPlayers()
        lbPlayers.DisplayMember = "PlayerFullName"
        lbPlayers.ValueMember = "PlayerID"

    End Sub

    Private Sub btnDeletePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePlayer.Click

        Select Case MsgBox("Are you sure you want to delete this player?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Deletion")
            Case MsgBoxResult.Yes
                deletePlayer() 'Doesn't work- need to delete PlayerID from report first
                MsgBox(lbPlayers.SelectedItem.PlayerFullName & " has been deleted")
                Me.Close()
        End Select

    End Sub

    Private Function getAllPlayers()

        Dim allPlayers As New List(Of Player)

        Dim Str As String = _
       <String> SELECT 
                    *
                FROM 
                    Player 
                INNER JOIN Club ON Club.ClubID = Player.ClubID                            
                Order By   
                    PlayerFirstName
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()
                        While drResult.Read

                            allPlayers.Add(New Player(drResult("PlayerID")) With {
                                         .PlayerFirstName = drResult("PlayerFirstName"),
                                         .PlayerLastName = drResult("PlayerLastName"),
                                         .DOB = drResult("DOB"),
                                         .Age = drResult("Age"),
                                         .PlaceOfBirth = drResult("PlaceOfBirth"),
                                         .ClubID = drResult("ClubID"),
                                         .ClubName = drResult("ClubName"),
                                         .PlayerImage = drResult("PlayerImage")})
                        End While
                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("All Players Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return allPlayers

    End Function

    Private Sub fillPlayerInfo()

        For Each plr As Player In getAllPlayers()

            If lbPlayers.SelectedItem.PlayerID = plr.PlayerID Then

                txtFirstName.Text = plr.PlayerFirstName
                txtSurname.Text = plr.PlayerLastName
                txtPlaceOfBirth.Text = plr.PlaceOfBirth
                cmbClub.SelectedValue = plr.ClubID
                dtpDOB.Value = plr.DOB

                Dim ms As New IO.MemoryStream(CType(plr.PlayerImage, Byte()))
                Dim returnImage As Image = Image.FromStream(ms)

                pcbEditPlayer.Image = returnImage

            End If
        Next

    End Sub

    Private Sub deletePlayer()

        Dim Str As String = _
       <String> 
                DELETE FROM Player
                WHERE PlayerID = @PlayerID
       </String>

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    MsgBox(_fixtureID)
                    cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = lbPlayers.SelectedItem.PlayerID
                    cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                End Using
            End Using

            'lbPlayers.Items.Remove(lbPlayers.SelectedItem) 'Throws error- refill from DT?
            MsgBox("Player Deleted")

        Catch ex As Exception
            MsgBox("Delete Player Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub updatePlayerInfo()

        Dim Str As String = _
       <String> 
               UPDATE Player
                SET PlayerFirstName = @PlayerFirstName, 
                    PlayerLastName = @PlayerLastName, 
                    PlaceOfBirth = @PlaceOfBirth,
                    DOB = @DOB,
                    Age = @Age,
                    ClubID = @ClubID,
                    PlayerImage = @PlayerImage
                WHERE PlayerID = @PlayerID
       </String>
        'Need to re-calculate age*****
        'Updating club changes club for all reports, not just general player info*****
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    'Create an Image object.'
                    Using picture As Image = Image.FromFile(imgLoc)
                        'Create an empty stream in memory.'
                        Using stream As New IO.MemoryStream
                            'Fill the stream with the binary data from the Image.
                            picture.Save(stream, Imaging.ImageFormat.Jpeg)
                            cmdQuery.Parameters.Add("@PlayerID", SqlDbType.Int).Value = lbPlayers.SelectedItem.PlayerID
                            cmdQuery.Parameters.Add("@PlayerFirstName", SqlDbType.VarChar).Value = txtFirstName.Text
                            cmdQuery.Parameters.Add("@PlayerLastName", SqlDbType.VarChar).Value = txtSurname.Text
                            cmdQuery.Parameters.Add("@PlaceOfBirth", SqlDbType.VarChar).Value = txtPlaceOfBirth.Text
                            cmdQuery.Parameters.Add("@DOB", SqlDbType.Date).Value = dtpDOB.Value
                            cmdQuery.Parameters.Add("@Age", SqlDbType.Int).Value = calculateAge(dtpDOB.Value)
                            cmdQuery.Parameters.Add("@ClubID", SqlDbType.Int).Value = cmbClub.SelectedItem.ClubID
                            cmdQuery.Parameters.Add("@PlayerImage", SqlDbType.VarBinary).Value = stream.GetBuffer()
                            cmdQuery.ExecuteNonQuery() 'NonQuery since the database is being deleted from, not queried
                        End Using
                    End Using
                End Using
            End Using
            MsgBox(txtFirstName.Text & " " & txtSurname.Text & "'s profile has been updated.")

        Catch ex As Exception
            MsgBox("Edit Player Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

    Private Sub lbPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPlayers.SelectedIndexChanged
        fillPlayerInfo()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Select Case MsgBox("Are you sure you want to edit this player?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Changes")
            Case MsgBoxResult.Yes
                checkPictureBox()
                updatePlayerInfo()
                Me.Close()
        End Select
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim dlg As New OpenFileDialog
        dlg.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*"
        dlg.Title = "Select Player Picture"

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            imgLoc = dlg.FileName.ToString
            pcbEditPlayer.ImageLocation = imgLoc
        End If
    End Sub

    Private Sub checkPictureBox()

        If imgLoc = "" Then
            imgLoc = pcbEditPlayer.ImageLocation 'Equals nothing, imgLocation is in the DB???
        End If

    End Sub

End Class