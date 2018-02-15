Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpFileMenuOperationsDlg
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.BackupDatabtn = New System.Windows.Forms.Button()
			Me.ChangePasswordbtn = New System.Windows.Forms.Button()
			Me.ExportReportbtn = New System.Windows.Forms.Button()
			Me.Loginbtn = New System.Windows.Forms.Button()
			Me.Logoutbtn = New System.Windows.Forms.Button()
			Me.Printbtn = New System.Windows.Forms.Button()
			Me.PrintOldReceiptbtn = New System.Windows.Forms.Button()
			Me.PrintPreviewbtn = New System.Windows.Forms.Button()
			Me.PrintSetupbtn = New System.Windows.Forms.Button()
			Me.RestoreDatabtn = New System.Windows.Forms.Button()
			Me.Exitbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' BackupDatabtn
			' 
			Me.BackupDatabtn.Location = New System.Drawing.Point(35, 39)
			Me.BackupDatabtn.Name = "BackupDatabtn"
			Me.BackupDatabtn.Size = New System.Drawing.Size(113, 33)
			Me.BackupDatabtn.TabIndex = 0
			Me.BackupDatabtn.Text = "Backup Data"
			Me.BackupDatabtn.UseVisualStyleBackColor = True
'			Me.BackupDatabtn.Click += New System.EventHandler(Me.BackupDatabtn_Click);
			' 
			' ChangePasswordbtn
			' 
			Me.ChangePasswordbtn.Location = New System.Drawing.Point(35, 86)
			Me.ChangePasswordbtn.Name = "ChangePasswordbtn"
			Me.ChangePasswordbtn.Size = New System.Drawing.Size(113, 33)
			Me.ChangePasswordbtn.TabIndex = 1
			Me.ChangePasswordbtn.Text = "Change Password"
			Me.ChangePasswordbtn.UseVisualStyleBackColor = True
'			Me.ChangePasswordbtn.Click += New System.EventHandler(Me.ChangePasswordbtn_Click);
			' 
			' ExportReportbtn
			' 
			Me.ExportReportbtn.Location = New System.Drawing.Point(35, 139)
			Me.ExportReportbtn.Name = "ExportReportbtn"
			Me.ExportReportbtn.Size = New System.Drawing.Size(113, 33)
			Me.ExportReportbtn.TabIndex = 2
			Me.ExportReportbtn.Text = "Export Report"
			Me.ExportReportbtn.UseVisualStyleBackColor = True
'			Me.ExportReportbtn.Click += New System.EventHandler(Me.ExportReportbtn_Click);
			' 
			' Loginbtn
			' 
			Me.Loginbtn.Location = New System.Drawing.Point(35, 187)
			Me.Loginbtn.Name = "Loginbtn"
			Me.Loginbtn.Size = New System.Drawing.Size(113, 33)
			Me.Loginbtn.TabIndex = 3
			Me.Loginbtn.Text = "Log In"
			Me.Loginbtn.UseVisualStyleBackColor = True
'			Me.Loginbtn.Click += New System.EventHandler(Me.Loginbtn_Click);
			' 
			' Logoutbtn
			' 
			Me.Logoutbtn.Location = New System.Drawing.Point(35, 234)
			Me.Logoutbtn.Name = "Logoutbtn"
			Me.Logoutbtn.Size = New System.Drawing.Size(113, 33)
			Me.Logoutbtn.TabIndex = 4
			Me.Logoutbtn.Text = "Log Out"
			Me.Logoutbtn.UseVisualStyleBackColor = True
'			Me.Logoutbtn.Click += New System.EventHandler(Me.Logoutbtn_Click);
			' 
			' Printbtn
			' 
			Me.Printbtn.Location = New System.Drawing.Point(307, 34)
			Me.Printbtn.Name = "Printbtn"
			Me.Printbtn.Size = New System.Drawing.Size(113, 33)
			Me.Printbtn.TabIndex = 5
			Me.Printbtn.Text = "Print"
			Me.Printbtn.UseVisualStyleBackColor = True
'			Me.Printbtn.Click += New System.EventHandler(Me.Printbtn_Click);
			' 
			' PrintOldReceiptbtn
			' 
			Me.PrintOldReceiptbtn.Location = New System.Drawing.Point(307, 86)
			Me.PrintOldReceiptbtn.Name = "PrintOldReceiptbtn"
			Me.PrintOldReceiptbtn.Size = New System.Drawing.Size(113, 33)
			Me.PrintOldReceiptbtn.TabIndex = 6
			Me.PrintOldReceiptbtn.Text = "Print Old Receipt"
			Me.PrintOldReceiptbtn.UseVisualStyleBackColor = True
'			Me.PrintOldReceiptbtn.Click += New System.EventHandler(Me.PrintOldReceiptbtn_Click);
			' 
			' PrintPreviewbtn
			' 
			Me.PrintPreviewbtn.Location = New System.Drawing.Point(307, 139)
			Me.PrintPreviewbtn.Name = "PrintPreviewbtn"
			Me.PrintPreviewbtn.Size = New System.Drawing.Size(113, 33)
			Me.PrintPreviewbtn.TabIndex = 7
			Me.PrintPreviewbtn.Text = "Print Preview"
			Me.PrintPreviewbtn.UseVisualStyleBackColor = True
'			Me.PrintPreviewbtn.Click += New System.EventHandler(Me.PrintPreviewbtn_Click);
			' 
			' PrintSetupbtn
			' 
			Me.PrintSetupbtn.Location = New System.Drawing.Point(307, 187)
			Me.PrintSetupbtn.Name = "PrintSetupbtn"
			Me.PrintSetupbtn.Size = New System.Drawing.Size(113, 33)
			Me.PrintSetupbtn.TabIndex = 8
			Me.PrintSetupbtn.Text = "Print Setup"
			Me.PrintSetupbtn.UseVisualStyleBackColor = True
'			Me.PrintSetupbtn.Click += New System.EventHandler(Me.PrintSetupbtn_Click);
			' 
			' RestoreDatabtn
			' 
			Me.RestoreDatabtn.Location = New System.Drawing.Point(307, 234)
			Me.RestoreDatabtn.Name = "RestoreDatabtn"
			Me.RestoreDatabtn.Size = New System.Drawing.Size(113, 33)
			Me.RestoreDatabtn.TabIndex = 9
			Me.RestoreDatabtn.Text = "Restore Data"
			Me.RestoreDatabtn.UseVisualStyleBackColor = True
'			Me.RestoreDatabtn.Click += New System.EventHandler(Me.RestoreDatabtn_Click);
			' 
			' Exitbtn
			' 
			Me.Exitbtn.Location = New System.Drawing.Point(170, 139)
			Me.Exitbtn.Name = "Exitbtn"
			Me.Exitbtn.Size = New System.Drawing.Size(113, 33)
			Me.Exitbtn.TabIndex = 10
			Me.Exitbtn.Text = "Exit"
			Me.Exitbtn.UseVisualStyleBackColor = True
'			Me.Exitbtn.Click += New System.EventHandler(Me.Exitbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Exitbtn)
			Me.groupBox1.Controls.Add(Me.RestoreDatabtn)
			Me.groupBox1.Controls.Add(Me.PrintSetupbtn)
			Me.groupBox1.Controls.Add(Me.PrintPreviewbtn)
			Me.groupBox1.Controls.Add(Me.PrintOldReceiptbtn)
			Me.groupBox1.Controls.Add(Me.Printbtn)
			Me.groupBox1.Controls.Add(Me.Logoutbtn)
			Me.groupBox1.Controls.Add(Me.Loginbtn)
			Me.groupBox1.Controls.Add(Me.ExportReportbtn)
			Me.groupBox1.Controls.Add(Me.ChangePasswordbtn)
			Me.groupBox1.Controls.Add(Me.BackupDatabtn)
			Me.groupBox1.Location = New System.Drawing.Point(12, 24)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(446, 297)
			Me.groupBox1.TabIndex = 11
			Me.groupBox1.TabStop = False
			' 
			' SmpFileMenuOperationsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(470, 342)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SmpFileMenuOperationsDlg"
			Me.Text = "SmpFileMenuOperationsDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents BackupDatabtn As System.Windows.Forms.Button
		Private WithEvents ChangePasswordbtn As System.Windows.Forms.Button
		Private WithEvents ExportReportbtn As System.Windows.Forms.Button
		Private WithEvents Loginbtn As System.Windows.Forms.Button
		Private WithEvents Logoutbtn As System.Windows.Forms.Button
		Private WithEvents Printbtn As System.Windows.Forms.Button
		Private WithEvents PrintOldReceiptbtn As System.Windows.Forms.Button
		Private WithEvents PrintPreviewbtn As System.Windows.Forms.Button
		Private WithEvents PrintSetupbtn As System.Windows.Forms.Button
		Private WithEvents RestoreDatabtn As System.Windows.Forms.Button
		Private WithEvents Exitbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace