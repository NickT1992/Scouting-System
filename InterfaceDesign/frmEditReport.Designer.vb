<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSelectedPlayer = New System.Windows.Forms.Label()
        Me.cmbSelectedPlayer = New System.Windows.Forms.ComboBox()
        Me.lblReportDate = New System.Windows.Forms.Label()
        Me.lblScoutName = New System.Windows.Forms.Label()
        Me.cmbReportDate = New System.Windows.Forms.ComboBox()
        Me.cmbScoutName = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectedPlayer
        '
        Me.lblSelectedPlayer.AutoSize = True
        Me.lblSelectedPlayer.Location = New System.Drawing.Point(234, 46)
        Me.lblSelectedPlayer.Name = "lblSelectedPlayer"
        Me.lblSelectedPlayer.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedPlayer.TabIndex = 58
        Me.lblSelectedPlayer.Text = "Selected Player:"
        '
        'cmbSelectedPlayer
        '
        Me.cmbSelectedPlayer.FormattingEnabled = True
        Me.cmbSelectedPlayer.Location = New System.Drawing.Point(319, 43)
        Me.cmbSelectedPlayer.Name = "cmbSelectedPlayer"
        Me.cmbSelectedPlayer.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelectedPlayer.TabIndex = 57
        '
        'lblReportDate
        '
        Me.lblReportDate.AutoSize = True
        Me.lblReportDate.Location = New System.Drawing.Point(12, 46)
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Size = New System.Drawing.Size(68, 13)
        Me.lblReportDate.TabIndex = 56
        Me.lblReportDate.Text = "Report Date:"
        '
        'lblScoutName
        '
        Me.lblScoutName.AutoSize = True
        Me.lblScoutName.Location = New System.Drawing.Point(12, 9)
        Me.lblScoutName.Name = "lblScoutName"
        Me.lblScoutName.Size = New System.Drawing.Size(63, 13)
        Me.lblScoutName.TabIndex = 55
        Me.lblScoutName.Text = "Staff Name:"
        '
        'cmbReportDate
        '
        Me.cmbReportDate.FormattingEnabled = True
        Me.cmbReportDate.Location = New System.Drawing.Point(86, 43)
        Me.cmbReportDate.Name = "cmbReportDate"
        Me.cmbReportDate.Size = New System.Drawing.Size(121, 21)
        Me.cmbReportDate.TabIndex = 54
        '
        'cmbScoutName
        '
        Me.cmbScoutName.FormattingEnabled = True
        Me.cmbScoutName.Location = New System.Drawing.Point(86, 6)
        Me.cmbScoutName.Name = "cmbScoutName"
        Me.cmbScoutName.Size = New System.Drawing.Size(121, 21)
        Me.cmbScoutName.TabIndex = 53
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(283, 153)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Overall:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEditReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSelectedPlayer)
        Me.Controls.Add(Me.cmbSelectedPlayer)
        Me.Controls.Add(Me.lblReportDate)
        Me.Controls.Add(Me.lblScoutName)
        Me.Controls.Add(Me.cmbReportDate)
        Me.Controls.Add(Me.cmbScoutName)
        Me.Name = "frmEditReport"
        Me.Text = "Edit Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectedPlayer As System.Windows.Forms.Label
    Friend WithEvents cmbSelectedPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents lblReportDate As System.Windows.Forms.Label
    Friend WithEvents lblScoutName As System.Windows.Forms.Label
    Friend WithEvents cmbReportDate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbScoutName As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
