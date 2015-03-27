Public Class frmLogin

    Private Sub btnLogIn_Click(sender As System.Object, e As System.EventArgs) Handles btnLogIn.Click

        Dim Str As String = _
        <String> SELECT 
                    * 
                 FROM 
                    ScoutRole 
                 WHERE 
                    Username = @Username
                 AND 
                    Password = @Password
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    cmdQuery.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text
                    cmdQuery.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text
                    Using drResult As SqlClient.SqlDataReader = cmdQuery.ExecuteReader()

                        If drResult.Read = True Then 'If the record can be queried, pass verification and open another form  
                            MessageBox.Show("Successfull Login!")

                            _scoutID = drResult("ScoutID")
                            _scoutRole = drResult("Role")

                            'Dim frmPlayerInfo As New frmPlayerInfo
                            'frmPlayerInfo.Show()
                            Me.Hide()

                            frmPlayerInfo.Visible = True
                        Else
                            MessageBox.Show("Invalid username or password!")
                        End If

                    End Using 'Automatically closes connection
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Scout Role Exception: " & ex.Message & vbNewLine & Str)
        End Try

    End Sub

End Class