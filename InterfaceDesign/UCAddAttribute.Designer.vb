<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAddAttribute
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblAttribute = New System.Windows.Forms.Label()
        Me.cmbAttribute = New System.Windows.Forms.ComboBox()
        Me.cmbEqualityFactor = New System.Windows.Forms.ComboBox()
        Me.lblEqualityFactor = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.TTfilterStrip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbValue = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(61, 7)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 0
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(3, 10)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(52, 13)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Category:"
        '
        'lblAttribute
        '
        Me.lblAttribute.AutoSize = True
        Me.lblAttribute.Location = New System.Drawing.Point(204, 10)
        Me.lblAttribute.Name = "lblAttribute"
        Me.lblAttribute.Size = New System.Drawing.Size(49, 13)
        Me.lblAttribute.TabIndex = 2
        Me.lblAttribute.Text = "Attribute:"
        '
        'cmbAttribute
        '
        Me.cmbAttribute.FormattingEnabled = True
        Me.cmbAttribute.Location = New System.Drawing.Point(258, 7)
        Me.cmbAttribute.Name = "cmbAttribute"
        Me.cmbAttribute.Size = New System.Drawing.Size(121, 21)
        Me.cmbAttribute.TabIndex = 3
        '
        'cmbEqualityFactor
        '
        Me.cmbEqualityFactor.FormattingEnabled = True
        Me.cmbEqualityFactor.Location = New System.Drawing.Point(486, 7)
        Me.cmbEqualityFactor.Name = "cmbEqualityFactor"
        Me.cmbEqualityFactor.Size = New System.Drawing.Size(121, 21)
        Me.cmbEqualityFactor.TabIndex = 4
        '
        'lblEqualityFactor
        '
        Me.lblEqualityFactor.AutoSize = True
        Me.lblEqualityFactor.Location = New System.Drawing.Point(402, 10)
        Me.lblEqualityFactor.Name = "lblEqualityFactor"
        Me.lblEqualityFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblEqualityFactor.TabIndex = 5
        Me.lblEqualityFactor.Text = "Equality Factor:"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(685, 7)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(48, 20)
        Me.txtValue.TabIndex = 6
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(631, 10)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(37, 13)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Value:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(782, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.TTfilterStrip.SetToolTip(Me.btnRemove, "Click to remove this condition.")
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cmbValue
        '
        Me.cmbValue.FormattingEnabled = True
        Me.cmbValue.Location = New System.Drawing.Point(685, 7)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Size = New System.Drawing.Size(74, 21)
        Me.cmbValue.TabIndex = 9
        '
        'UCAddAttribute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblEqualityFactor)
        Me.Controls.Add(Me.cmbEqualityFactor)
        Me.Controls.Add(Me.cmbAttribute)
        Me.Controls.Add(Me.lblAttribute)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.cmbValue)
        Me.Name = "UCAddAttribute"
        Me.Size = New System.Drawing.Size(860, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblAttribute As System.Windows.Forms.Label
    Friend WithEvents cmbAttribute As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEqualityFactor As System.Windows.Forms.ComboBox
    Friend WithEvents lblEqualityFactor As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents TTfilterStrip As System.Windows.Forms.ToolTip
    Friend WithEvents cmbValue As System.Windows.Forms.ComboBox

End Class
