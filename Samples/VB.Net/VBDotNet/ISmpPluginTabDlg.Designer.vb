<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISmpPluginTabDlg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreateView = New System.Windows.Forms.Button
        Me.btnCreateFormView = New System.Windows.Forms.Button
        Me.btnCreateHtmlView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSetCurrentViewTo = New System.Windows.Forms.TextBox
        Me.btnSetCurrentView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateView
        '
        Me.btnCreateView.Location = New System.Drawing.Point(22, 24)
        Me.btnCreateView.Name = "btnCreateView"
        Me.btnCreateView.Size = New System.Drawing.Size(101, 23)
        Me.btnCreateView.TabIndex = 0
        Me.btnCreateView.Text = "Create View"
        Me.btnCreateView.UseVisualStyleBackColor = True
        '
        'btnCreateFormView
        '
        Me.btnCreateFormView.Location = New System.Drawing.Point(143, 24)
        Me.btnCreateFormView.Name = "btnCreateFormView"
        Me.btnCreateFormView.Size = New System.Drawing.Size(103, 23)
        Me.btnCreateFormView.TabIndex = 1
        Me.btnCreateFormView.Text = "Create Form View"
        Me.btnCreateFormView.UseVisualStyleBackColor = True
        '
        'btnCreateHtmlView
        '
        Me.btnCreateHtmlView.Location = New System.Drawing.Point(45, 64)
        Me.btnCreateHtmlView.Name = "btnCreateHtmlView"
        Me.btnCreateHtmlView.Size = New System.Drawing.Size(173, 23)
        Me.btnCreateHtmlView.TabIndex = 2
        Me.btnCreateHtmlView.Text = "Create HTML View"
        Me.btnCreateHtmlView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Set Current View to :"
        '
        'txtSetCurrentViewTo
        '
        Me.txtSetCurrentViewTo.Location = New System.Drawing.Point(117, 14)
        Me.txtSetCurrentViewTo.Name = "txtSetCurrentViewTo"
        Me.txtSetCurrentViewTo.Size = New System.Drawing.Size(100, 20)
        Me.txtSetCurrentViewTo.TabIndex = 4
        '
        'btnSetCurrentView
        '
        Me.btnSetCurrentView.Location = New System.Drawing.Point(142, 47)
        Me.btnSetCurrentView.Name = "btnSetCurrentView"
        Me.btnSetCurrentView.Size = New System.Drawing.Size(75, 23)
        Me.btnSetCurrentView.TabIndex = 5
        Me.btnSetCurrentView.Text = "Set"
        Me.btnSetCurrentView.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSetCurrentView)
        Me.GroupBox1.Controls.Add(Me.txtSetCurrentViewTo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 89)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ISmpPluginTabDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 190)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCreateHtmlView)
        Me.Controls.Add(Me.btnCreateFormView)
        Me.Controls.Add(Me.btnCreateView)
        Me.Name = "ISmpPluginTabDlg"
        Me.Text = "ISmpPluginTabDlg"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateView As System.Windows.Forms.Button
    Friend WithEvents btnCreateFormView As System.Windows.Forms.Button
    Friend WithEvents btnCreateHtmlView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSetCurrentViewTo As System.Windows.Forms.TextBox
    Friend WithEvents btnSetCurrentView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
