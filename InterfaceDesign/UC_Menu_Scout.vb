Public Class UC_Menu_Scout

    Private Sub btnEditPlayerInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPlayerInfo.Click
        Dim frmEditPlayerInformation As New frmEditPlayerInformation
        frmEditPlayerInformation.ShowDialog()
    End Sub

    Private Sub btnAddReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReport.Click
        Dim frmAddFixture As New frmAddFixture
        frmAddFixture.ShowDialog()
    End Sub

    Private Sub btnEditReport_Click(sender As System.Object, e As System.EventArgs) Handles btnEditReport.Click
        Dim frmEditReport As New frmEditReport
        frmEditReport.ShowDialog()
    End Sub

    Private Sub btnEditFixtureInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditFixtureInfo.Click
        Dim frmEditFixture As New frmEditFixture
        frmEditFixture.ShowDialog()
    End Sub

    Private Sub btnEditScoutInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditScoutInfo.Click
        Dim frmEditScout As New frmEditScout
        frmEditScout.ShowDialog()
    End Sub

    Private Sub cmbScoutName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbScoutName.SelectedIndexChanged
        cmbReportDate.DataSource = frmPlayerInfo.filterFixtureReports()
        cmbReportDate.DisplayMember = "ReportDate"
        cmbReportDate.ValueMember = "ReportID"
    End Sub

    Private Sub cmbReportDate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportDate.SelectedIndexChanged

        frmPlayerInfo.setFixtureInfo()

        For Each p As Player In frmPlayerInfo.retrievePlayerList()
            frmPlayerInfo.playerList.Add(p)
        Next

        'if not the same fixtureID
        cmbSelectedPlayer.DataSource = Nothing
        cmbSelectedPlayer.DataSource = frmPlayerInfo.playerList
        cmbSelectedPlayer.DisplayMember = "PlayerFullName"
        cmbSelectedPlayer.ValueMember = "PlayerID"

        If cmbSelectedPlayer.Items.Count > 0 Then
            cmbSelectedPlayer.SelectedIndex = 0
        End If

        lblNumberOfReports.Text = "Report: 1" & "/" & cmbSelectedPlayer.Items.Count

        frmPlayerInfo.playerList.Clear()

    End Sub

    Private Sub cmbSelectedPlayer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSelectedPlayer.SelectedIndexChanged
        frmPlayerInfo.setFixtureReport()
        'If cmbSelectedPlayer.SelectedIndex = 0 Then 'Doesn't change setPlayerInfo() when cmbSelectedPlayer changes 
        If cmbSelectedPlayer.SelectedIndex >= 0 Then
            'Dim x As Integer = cmbSelectedPlayer.SelectedIndex
            frmPlayerInfo.setPlayerInfo() 'This event is called 3 times on cmbReportDate_IndexChange- error never thrown for load (only called once)
            'cmbSelectedPlayer.SelectedIndex = x
        End If

    End Sub

    Private Sub btnNextPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnNextPlayer.Click
        'Moves to next item in playerList
        Dim x As Integer = cmbSelectedPlayer.SelectedIndex
        If x = cmbSelectedPlayer.Items.Count - 1 Then
            x = 0
        Else
            x += 1
        End If

        cmbSelectedPlayer.SelectedIndex = x

        lblNumberOfReports.Text = "Report: " & x + 1 & "/" & cmbSelectedPlayer.Items.Count

    End Sub

    Private Sub btnPreviousPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnPreviousPlayer.Click
        'Moves to previous item in playerList
        Dim x As Integer = cmbSelectedPlayer.SelectedIndex
        If x <= 0 Then
            x = cmbSelectedPlayer.Items.Count - 1
        Else
            x -= 1
        End If

        cmbSelectedPlayer.SelectedIndex = x

        lblNumberOfReports.Text = "Report: " & x + 1 & "/" & cmbSelectedPlayer.Items.Count
    End Sub

    Private Sub btnSubmitGrade_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmitGrade.Click
        frmPlayerInfo.updateGrade()
    End Sub

End Class
