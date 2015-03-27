<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttributesSearch
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddNewCondition = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewPlayer = New System.Windows.Forms.Button()
        Me.dgPlayers = New System.Windows.Forms.DataGridView()
        Me.TTFilter = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 40)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(895, 191)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnAddNewCondition
        '
        Me.btnAddNewCondition.Location = New System.Drawing.Point(9, 11)
        Me.btnAddNewCondition.Name = "btnAddNewCondition"
        Me.btnAddNewCondition.Size = New System.Drawing.Size(154, 23)
        Me.btnAddNewCondition.TabIndex = 0
        Me.btnAddNewCondition.Text = "Add New Condition"
        Me.TTFilter.SetToolTip(Me.btnAddNewCondition, "Multiple conditions can be added to filter though player reports.")
        Me.btnAddNewCondition.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(750, 237)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(154, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.TTFilter.SetToolTip(Me.btnSearch, "Click to run your query. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double-click the desired player report in the grid to " & _
        "view in full.")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnViewPlayer
        '
        Me.btnViewPlayer.Location = New System.Drawing.Point(750, 533)
        Me.btnViewPlayer.Name = "btnViewPlayer"
        Me.btnViewPlayer.Size = New System.Drawing.Size(154, 23)
        Me.btnViewPlayer.TabIndex = 3
        Me.btnViewPlayer.Text = "View Selected Player"
        Me.btnViewPlayer.UseVisualStyleBackColor = True
        '
        'dgPlayers
        '
        Me.dgPlayers.AllowUserToAddRows = False
        Me.dgPlayers.AllowUserToDeleteRows = False
        Me.dgPlayers.AllowUserToResizeColumns = False
        Me.dgPlayers.AllowUserToResizeRows = False
        Me.dgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlayers.Location = New System.Drawing.Point(9, 276)
        Me.dgPlayers.MultiSelect = False
        Me.dgPlayers.Name = "dgPlayers"
        Me.dgPlayers.ReadOnly = True
        Me.dgPlayers.RowHeadersVisible = False
        Me.dgPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPlayers.Size = New System.Drawing.Size(895, 251)
        Me.dgPlayers.TabIndex = 4
        '
        'frmAttributesSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(914, 568)
        Me.Controls.Add(Me.dgPlayers)
        Me.Controls.Add(Me.btnViewPlayer)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAddNewCondition)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmAttributesSearch"
        Me.Text = "Attributes Search"
        CType(Me.dgPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAddNewCondition As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnViewPlayer As System.Windows.Forms.Button
    Friend WithEvents dgPlayers As System.Windows.Forms.DataGridView
    Friend WithEvents TTFilter As System.Windows.Forms.ToolTip
End Class
