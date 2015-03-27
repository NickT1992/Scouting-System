Public Class UCAddAttribute

    Private Sub UCAddAttribute_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        fillCategory()
        fillAttribute()
        fillEqualityFactor()
        fillCmbValue()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        fillAttribute()
        cmbAttribute.SelectedIndex = 0
    End Sub

    Private Sub cmbAttribute_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAttribute.SelectedIndexChanged
        fillCmbValue()
        If cmbAttribute.SelectedItem = "PreferredFoot" OrElse cmbAttribute.SelectedItem = "PositionPlayed" OrElse cmbAttribute.SelectedItem = "MonitorStatus" OrElse cmbAttribute.SelectedItem = "Grade" Then
            txtValue.Visible = False
            cmbValue.Visible = True
            cmbEqualityFactor.Items.Clear()
            cmbEqualityFactor.Items.Add("=")
            cmbEqualityFactor.SelectedIndex = 0
        Else
            txtValue.Visible = True
            cmbValue.Visible = False
            fillEqualityFactor()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Me.Dispose()
    End Sub

    Private Sub fillCategory()
        cmbCategory.Items.Add("Attributes")
        cmbCategory.Items.Add("General Information")
        'cmbCategory.Items.Add("Report Information")
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub fillAttribute()

        cmbAttribute.Items.Clear()

        If cmbCategory.SelectedItem = "Attributes" Then
            cmbAttribute.Items.Add("Crossing")
            cmbAttribute.Items.Add("Dribbling")
            cmbAttribute.Items.Add("Finishing")
            cmbAttribute.Items.Add("Ball Control")
            cmbAttribute.Items.Add("Passing")
            cmbAttribute.Items.Add("Heading Accuracy")
            cmbAttribute.Items.Add("Marking")
            cmbAttribute.Items.Add("Tackling")
            cmbAttribute.Items.Add("Aggression")
            cmbAttribute.Items.Add("Positioning")
            cmbAttribute.Items.Add("Anticipation")
            cmbAttribute.Items.Add("Composure")
            cmbAttribute.Items.Add("Vision")
            cmbAttribute.Items.Add("Teamwork")
            cmbAttribute.Items.Add("Work Rate")
            cmbAttribute.Items.Add("Pace")
            cmbAttribute.Items.Add("Balance")
            cmbAttribute.Items.Add("Jumping")
            cmbAttribute.Items.Add("Strength")
            cmbAttribute.Items.Add("Stamina")
            cmbAttribute.Items.Add("Overall")
        End If

        If cmbCategory.SelectedItem = "General Information" Then
            cmbAttribute.Items.Add("Age")
            cmbAttribute.Items.Add("PreferredFoot")
            cmbAttribute.Items.Add("PositionPlayed")
            cmbAttribute.Items.Add("MonitorStatus")
            cmbAttribute.Items.Add("Grade")
        End If

        'If cmbCategory.SelectedItem = "Report Information" Then
        '    cmbAttribute.Items.Add("Scout Name")
        '    cmbAttribute.Items.Add("Report Date") 'Think I can use dtp >= etc
        'End If
        cmbAttribute.SelectedIndex = 0
    End Sub

    Private Sub fillEqualityFactor()
        cmbEqualityFactor.Items.Add(">=")
        cmbEqualityFactor.Items.Add("=")
        cmbEqualityFactor.Items.Add("<=")
        cmbEqualityFactor.SelectedIndex = 0
    End Sub

    'Private Function filterPlayers() As String
    '    Return cmbAttribute.SelectedItem & " " & cmbEqualityFactor.SelectedItem & " " '& Integer.Parse(txtNumber.Text)
    'End Function

    Private Sub fillCmbValue()

        cmbValue.Items.Clear()

        If cmbAttribute.SelectedItem = "PreferredFoot" Then
            cmbValue.Items.Add("Right")
            cmbValue.Items.Add("Left")
            cmbValue.Items.Add("Either")
            cmbValue.SelectedIndex = 0
        End If

        If cmbAttribute.SelectedItem = "PositionPlayed" Then
            cmbValue.Items.Add("GK")
            cmbValue.Items.Add("LWB")
            cmbValue.Items.Add("LB")
            cmbValue.Items.Add("RWB")
            cmbValue.Items.Add("RB")
            cmbValue.Items.Add("CB")
            cmbValue.Items.Add("CDM")
            cmbValue.Items.Add("CM")
            cmbValue.Items.Add("CAM")
            cmbValue.Items.Add("LW")
            cmbValue.Items.Add("RW")
            cmbValue.Items.Add("CF")
            cmbValue.Items.Add("ST")
            cmbValue.SelectedIndex = 12
        End If

        If cmbAttribute.SelectedItem = "MonitorStatus" Then
            cmbValue.Items.Add("Monitor")
            cmbValue.Items.Add("Follow-Up")
            cmbValue.SelectedIndex = 0
        End If

        If cmbAttribute.SelectedItem = "Grade" Then
            cmbValue.Items.Add("Ungraded")
            cmbValue.Items.Add("A")
            cmbValue.Items.Add("B")
            cmbValue.Items.Add("C")
            cmbValue.Items.Add("D")
            cmbValue.SelectedIndex = 0
        End If

    End Sub


End Class
