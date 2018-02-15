<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmpGridDlg
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
        Me.ButtonAutoSize = New System.Windows.Forms.Button
        Me.ButtonSet_Auto_Size_Style = New System.Windows.Forms.Button
        Me.ButtonSet_FocusCell = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ButtonAutoSize
        '
        Me.ButtonAutoSize.Location = New System.Drawing.Point(12, 38)
        Me.ButtonAutoSize.Name = "ButtonAutoSize"
        Me.ButtonAutoSize.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAutoSize.TabIndex = 0
        Me.ButtonAutoSize.Text = "AutoSize"
        Me.ButtonAutoSize.UseVisualStyleBackColor = True
        '
        'ButtonSet_Auto_Size_Style
        '
        Me.ButtonSet_Auto_Size_Style.Location = New System.Drawing.Point(93, 38)
        Me.ButtonSet_Auto_Size_Style.Name = "ButtonSet_Auto_Size_Style"
        Me.ButtonSet_Auto_Size_Style.Size = New System.Drawing.Size(110, 23)
        Me.ButtonSet_Auto_Size_Style.TabIndex = 1
        Me.ButtonSet_Auto_Size_Style.Text = "Set Auto Size Style"
        Me.ButtonSet_Auto_Size_Style.UseVisualStyleBackColor = True
        '
        'ButtonSet_FocusCell
        '
        Me.ButtonSet_FocusCell.Location = New System.Drawing.Point(210, 37)
        Me.ButtonSet_FocusCell.Name = "ButtonSet_FocusCell"
        Me.ButtonSet_FocusCell.Size = New System.Drawing.Size(104, 23)
        Me.ButtonSet_FocusCell.TabIndex = 2
        Me.ButtonSet_FocusCell.Text = "Set Focus Cell"
        Me.ButtonSet_FocusCell.UseVisualStyleBackColor = True
        '
        'SmpGridDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 102)
        Me.Controls.Add(Me.ButtonSet_FocusCell)
        Me.Controls.Add(Me.ButtonSet_Auto_Size_Style)
        Me.Controls.Add(Me.ButtonAutoSize)
        Me.Name = "SmpGridDlg"
        Me.Text = "SmpGrid"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonAutoSize As System.Windows.Forms.Button
    Friend WithEvents ButtonSet_Auto_Size_Style As System.Windows.Forms.Button
    Friend WithEvents ButtonSet_FocusCell As System.Windows.Forms.Button
End Class
