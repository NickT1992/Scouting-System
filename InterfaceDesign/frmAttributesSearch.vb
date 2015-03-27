Public Class frmAttributesSearch

    Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewCondition.Click
        FlowLayoutPanel1.Controls.Add(New UCAddAttribute)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'dgPlayers.DataSource = Nothing
        dgPlayers.DataSource = search(buildFilterString)
        setDGColumns()
    End Sub

    Public Function buildFilterString()
        Dim value As String = ""
        Dim myString As String = ""

        For Each strip As UCAddAttribute In FlowLayoutPanel1.Controls

            If strip.cmbAttribute.SelectedItem = "PreferredFoot" OrElse strip.cmbAttribute.SelectedItem = "PositionPlayed" OrElse strip.cmbAttribute.SelectedItem = "MonitorStatus" OrElse strip.cmbAttribute.SelectedItem = "Grade" Then

                strip.txtValue.Visible = False 'only works on search click- needs to be dones in UCAddAttribute
                myString = myString + strip.cmbAttribute.SelectedItem & " " & strip.cmbEqualityFactor.SelectedItem & " " & "'" & strip.cmbValue.SelectedItem & "'" & " AND "
                '^^^ need to convert strip.cmbValue.SelectedItem to string- add '' around word?
            Else

                strip.cmbValue.Visible = False
                myString = myString + strip.cmbAttribute.SelectedItem & " " & strip.cmbEqualityFactor.SelectedItem & " " & Integer.Parse(strip.txtValue.Text) & " AND "
            End If
        Next

                myString = myString + "1 = 1"

                Return myString

    End Function

    Private Sub btnViewPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnViewPlayer.Click
        'Not needed at the moment- double-click grid instead
    End Sub

    Private Sub dgPlayers_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgPlayers.CellMouseDoubleClick
        'Must be a better way of doing this
        'If selected index >=0
        Dim tempList As New List(Of Player)
        Dim selectedPlayer As New Player(dgPlayers.Rows(e.RowIndex).Cells("PlayerID").Value.ToString()) With {
                                         .PlayerFirstName = dgPlayers.Rows(e.RowIndex).Cells("PlayerFirstName").Value.ToString(),
                                         .PlayerLastName = dgPlayers.Rows(e.RowIndex).Cells("PlayerLastName").Value.ToString()}
        tempList.Add(selectedPlayer)
        frmPlayerInfo.lbPlayers.DataSource = tempList
        frmPlayerInfo.lbPlayers.DisplayMember = "PlayerFullName"
        frmPlayerInfo.lbPlayers.ValueMember = "PlayerID"

        frmPlayerInfo.UC_Menu_Scout1.TabControl1.SelectedIndex = 2

        Me.Close()
    End Sub

    Private Sub setDGColumns()
        dgPlayers.Columns("PlayerImage").Visible = False
        dgPlayers.Columns("FixtureID").Visible = False
        dgPlayers.Columns("ReportID").Visible = False
        dgPlayers.Columns("ScoutID").Visible = False
        dgPlayers.Columns("PlayerID").Visible = False
        dgPlayers.Columns("PlayerID1").Visible = False
        dgPlayers.Columns("Age").Visible = False
        dgPlayers.Columns("DOB").Visible = False
        dgPlayers.Columns("PlaceOfBirth").Visible = False
        dgPlayers.Columns("ClubID").Visible = False
        dgPlayers.Columns("PreferredFoot").DisplayIndex = 14
    End Sub

End Class