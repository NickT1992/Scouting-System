Public Class frmEditReport

    Private Sub cmbScoutName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbScoutName.SelectedIndexChanged
        cmbReportDate.DataSource = frmPlayerInfo.filterFixtureReports()
        cmbReportDate.DisplayMember = "ReportDate"
        cmbReportDate.ValueMember = "ReportID"
    End Sub

End Class