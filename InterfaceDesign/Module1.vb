Module Module1

    Public DBConnection As String = "Data Source = bo9o4mxahz.database.windows.net; Initial Catalog = ScoutDB; uid=Nick1992; password = Scout1992"
    Public _fixtureID As Integer 'Stored in variable for use in report
    Public _playerID As Integer 'Stored in variable for use in report
    Public isNewPlayer As Boolean = True
    Public isNewFixture As Boolean = True
    Public _scoutID As Integer
    Public _scoutRole As String 'Stored in variable to limit scout's available functionality

    Public Function getMaxID(ByVal fieldName As String, ByVal tableName As String) As Integer 'Refactor and explain in conclusion

        Dim newID As Integer
        Dim Str = "SELECT MAX(" & fieldName & ") FROM " & tableName & ""
        Dim x As Integer
        Dim nullCheck As Boolean

        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)

                    x = cmdQuery.ExecuteScalar()
                    nullCheck = IsDBNull(x)

                    If nullCheck = True Then
                        newID = 1
                    Else
                        newID = x + 1
                    End If

                End Using
            End Using

        Catch ex As Exception
            MsgBox("Generate Max ID Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return newID

    End Function

    Public Function nullCheck(ByVal obj As Object) As Object

        If obj.Equals(DBNull.Value) Then
            Return ""
        Else
            Return obj
        End If

    End Function

    Public Function search(ByVal searchString As String) As DataTable
        'Currently searches by report, not overall overall
        Dim dt As New DataTable
        Dim Str As String = _
       <String> SELECT 
                    *
                FROM 
                    Player
                INNER JOIN Report ON Report.PlayerID = Player.PlayerID
                WHERE                 
                <%= searchString %>                    
                ORDER BY 
                    PlayerLastName
       </String>
        Try
            Using conn As New SqlClient.SqlConnection(DBConnection)
                conn.Open()
                Using cmdQuery As New SqlClient.SqlCommand(Str, conn)
                    Using daResults As New SqlClient.SqlDataAdapter(cmdQuery)
                        daResults.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Filter Search Exception: " & ex.Message & vbNewLine & Str)
        End Try

        Return dt

    End Function

    Public Function calculateAge(ByVal dob As Date) As Integer

        Dim age As Integer = 0
        age = Today.Year - dob.Year 'Or report date for age on date report was created
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age

    End Function

End Module
