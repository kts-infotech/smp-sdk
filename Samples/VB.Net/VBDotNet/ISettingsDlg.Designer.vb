Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISettingsDlg
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
			Me.AutomaticBackupbtn = New System.Windows.Forms.Button()
			Me.AutomaticCompactbtn = New System.Windows.Forms.Button()
			Me.DateFormatbtn = New System.Windows.Forms.Button()
			Me.MembershipFeebtn = New System.Windows.Forms.Button()
			Me.SecurityDepositbtn = New System.Windows.Forms.Button()
			Me.LaunchOnStartupbtn = New System.Windows.Forms.Button()
			Me.NoOfDisplayRecordsbtn = New System.Windows.Forms.Button()
			Me.OverrideExDataOnABbtn = New System.Windows.Forms.Button()
			Me.PaymentMethodbtn = New System.Windows.Forms.Button()
			Me.PictureFolderbtn = New System.Windows.Forms.Button()
			Me.UseEnterKeybtn = New System.Windows.Forms.Button()
			Me.RsltLbl = New System.Windows.Forms.Label()
			Me.paymntTxt = New System.Windows.Forms.TextBox()
			Me.EnterPaymntMthdbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.Paymntlbl = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AutomaticBackupbtn
			' 
			Me.AutomaticBackupbtn.Location = New System.Drawing.Point(46, 46)
			Me.AutomaticBackupbtn.Name = "AutomaticBackupbtn"
			Me.AutomaticBackupbtn.Size = New System.Drawing.Size(142, 43)
			Me.AutomaticBackupbtn.TabIndex = 0
			Me.AutomaticBackupbtn.Text = "Automatic Backup"
			Me.AutomaticBackupbtn.UseVisualStyleBackColor = True
'			Me.AutomaticBackupbtn.Click += New System.EventHandler(Me.AutomaticBackupbtn_Click);
			' 
			' AutomaticCompactbtn
			' 
			Me.AutomaticCompactbtn.Location = New System.Drawing.Point(46, 95)
			Me.AutomaticCompactbtn.Name = "AutomaticCompactbtn"
			Me.AutomaticCompactbtn.Size = New System.Drawing.Size(142, 43)
			Me.AutomaticCompactbtn.TabIndex = 1
			Me.AutomaticCompactbtn.Text = "Automatic Compact"
			Me.AutomaticCompactbtn.UseVisualStyleBackColor = True
'			Me.AutomaticCompactbtn.Click += New System.EventHandler(Me.AutomaticCompactbtn_Click);
			' 
			' DateFormatbtn
			' 
			Me.DateFormatbtn.Location = New System.Drawing.Point(46, 144)
			Me.DateFormatbtn.Name = "DateFormatbtn"
			Me.DateFormatbtn.Size = New System.Drawing.Size(142, 43)
			Me.DateFormatbtn.TabIndex = 2
			Me.DateFormatbtn.Text = "Date Format"
			Me.DateFormatbtn.UseVisualStyleBackColor = True
'			Me.DateFormatbtn.Click += New System.EventHandler(Me.DateFormatbtn_Click);
			' 
			' MembershipFeebtn
			' 
			Me.MembershipFeebtn.Location = New System.Drawing.Point(194, 46)
			Me.MembershipFeebtn.Name = "MembershipFeebtn"
			Me.MembershipFeebtn.Size = New System.Drawing.Size(142, 43)
			Me.MembershipFeebtn.TabIndex = 3
			Me.MembershipFeebtn.Text = "Membership Fee "
			Me.MembershipFeebtn.UseVisualStyleBackColor = True
'			Me.MembershipFeebtn.Click += New System.EventHandler(Me.MembershipFeebtn_Click);
			' 
			' SecurityDepositbtn
			' 
			Me.SecurityDepositbtn.Location = New System.Drawing.Point(194, 95)
			Me.SecurityDepositbtn.Name = "SecurityDepositbtn"
			Me.SecurityDepositbtn.Size = New System.Drawing.Size(142, 43)
			Me.SecurityDepositbtn.TabIndex = 4
			Me.SecurityDepositbtn.Text = "Security Deposit"
			Me.SecurityDepositbtn.UseVisualStyleBackColor = True
'			Me.SecurityDepositbtn.Click += New System.EventHandler(Me.SecurityDepositbtn_Click);
			' 
			' LaunchOnStartupbtn
			' 
			Me.LaunchOnStartupbtn.Location = New System.Drawing.Point(194, 144)
			Me.LaunchOnStartupbtn.Name = "LaunchOnStartupbtn"
			Me.LaunchOnStartupbtn.Size = New System.Drawing.Size(290, 43)
			Me.LaunchOnStartupbtn.TabIndex = 5
			Me.LaunchOnStartupbtn.Text = "Launch On Startup"
			Me.LaunchOnStartupbtn.UseVisualStyleBackColor = True
'			Me.LaunchOnStartupbtn.Click += New System.EventHandler(Me.LaunchOnStartupbtn_Click);
			' 
			' NoOfDisplayRecordsbtn
			' 
			Me.NoOfDisplayRecordsbtn.Location = New System.Drawing.Point(342, 46)
			Me.NoOfDisplayRecordsbtn.Name = "NoOfDisplayRecordsbtn"
			Me.NoOfDisplayRecordsbtn.Size = New System.Drawing.Size(142, 43)
			Me.NoOfDisplayRecordsbtn.TabIndex = 6
			Me.NoOfDisplayRecordsbtn.Text = "Number Of Display Records"
			Me.NoOfDisplayRecordsbtn.UseVisualStyleBackColor = True
'			Me.NoOfDisplayRecordsbtn.Click += New System.EventHandler(Me.NoOfDisplayRecordsbtn_Click);
			' 
			' OverrideExDataOnABbtn
			' 
			Me.OverrideExDataOnABbtn.Location = New System.Drawing.Point(342, 95)
			Me.OverrideExDataOnABbtn.Name = "OverrideExDataOnABbtn"
			Me.OverrideExDataOnABbtn.Size = New System.Drawing.Size(142, 43)
			Me.OverrideExDataOnABbtn.TabIndex = 7
			Me.OverrideExDataOnABbtn.Text = "Override Ex Data On AB"
			Me.OverrideExDataOnABbtn.UseVisualStyleBackColor = True
'			Me.OverrideExDataOnABbtn.Click += New System.EventHandler(Me.OverrideExDataOnABbtn_Click);
			' 
			' PaymentMethodbtn
			' 
			Me.PaymentMethodbtn.Location = New System.Drawing.Point(490, 144)
			Me.PaymentMethodbtn.Name = "PaymentMethodbtn"
			Me.PaymentMethodbtn.Size = New System.Drawing.Size(142, 43)
			Me.PaymentMethodbtn.TabIndex = 8
			Me.PaymentMethodbtn.Text = "Payment Method"
			Me.PaymentMethodbtn.UseVisualStyleBackColor = True
'			Me.PaymentMethodbtn.Click += New System.EventHandler(Me.PaymentMethodbtn_Click);
			' 
			' PictureFolderbtn
			' 
			Me.PictureFolderbtn.Location = New System.Drawing.Point(490, 46)
			Me.PictureFolderbtn.Name = "PictureFolderbtn"
			Me.PictureFolderbtn.Size = New System.Drawing.Size(142, 43)
			Me.PictureFolderbtn.TabIndex = 9
			Me.PictureFolderbtn.Text = "Picture Folder"
			Me.PictureFolderbtn.UseVisualStyleBackColor = True
'			Me.PictureFolderbtn.Click += New System.EventHandler(Me.PictureFolderbtn_Click);
			' 
			' UseEnterKeybtn
			' 
			Me.UseEnterKeybtn.Location = New System.Drawing.Point(490, 95)
			Me.UseEnterKeybtn.Name = "UseEnterKeybtn"
			Me.UseEnterKeybtn.Size = New System.Drawing.Size(142, 43)
			Me.UseEnterKeybtn.TabIndex = 10
			Me.UseEnterKeybtn.Text = "Use EnterKey"
			Me.UseEnterKeybtn.UseVisualStyleBackColor = True
'			Me.UseEnterKeybtn.Click += New System.EventHandler(Me.UseEnterKeybtn_Click);
			' 
			' RsltLbl
			' 
			Me.RsltLbl.AutoSize = True
			Me.RsltLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.RsltLbl.ForeColor = System.Drawing.Color.Red
			Me.RsltLbl.Location = New System.Drawing.Point(253, 180)
			Me.RsltLbl.Name = "RsltLbl"
			Me.RsltLbl.Size = New System.Drawing.Size(0, 16)
			Me.RsltLbl.TabIndex = 11
			' 
			' paymntTxt
			' 
			Me.paymntTxt.Location = New System.Drawing.Point(77, 33)
			Me.paymntTxt.Name = "paymntTxt"
			Me.paymntTxt.Size = New System.Drawing.Size(160, 20)
			Me.paymntTxt.TabIndex = 12
			' 
			' EnterPaymntMthdbtn
			' 
			Me.EnterPaymntMthdbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.EnterPaymntMthdbtn.Location = New System.Drawing.Point(286, 26)
			Me.EnterPaymntMthdbtn.Name = "EnterPaymntMthdbtn"
			Me.EnterPaymntMthdbtn.Size = New System.Drawing.Size(132, 33)
			Me.EnterPaymntMthdbtn.TabIndex = 13
			Me.EnterPaymntMthdbtn.Text = "Set Payment Method"
			Me.EnterPaymntMthdbtn.UseVisualStyleBackColor = True
'			Me.EnterPaymntMthdbtn.Click += New System.EventHandler(Me.EnterPaymntMthdbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.RsltLbl)
			Me.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
			Me.groupBox1.Location = New System.Drawing.Point(12, 26)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(649, 227)
			Me.groupBox1.TabIndex = 14
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "ISettings"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.Paymntlbl)
			Me.groupBox2.Controls.Add(Me.EnterPaymntMthdbtn)
			Me.groupBox2.Controls.Add(Me.paymntTxt)
			Me.groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
			Me.groupBox2.Location = New System.Drawing.Point(12, 266)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(649, 86)
			Me.groupBox2.TabIndex = 15
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Payment Method"
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(586, 370)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 28)
			Me.Clsbtn.TabIndex = 16
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' Paymntlbl
			' 
			Me.Paymntlbl.AutoSize = True
			Me.Paymntlbl.ForeColor = System.Drawing.Color.Red
			Me.Paymntlbl.Location = New System.Drawing.Point(439, 36)
			Me.Paymntlbl.Name = "Paymntlbl"
			Me.Paymntlbl.Size = New System.Drawing.Size(0, 13)
			Me.Paymntlbl.TabIndex = 17
			' 
			' ISettingsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(673, 410)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.UseEnterKeybtn)
			Me.Controls.Add(Me.PictureFolderbtn)
			Me.Controls.Add(Me.PaymentMethodbtn)
			Me.Controls.Add(Me.OverrideExDataOnABbtn)
			Me.Controls.Add(Me.NoOfDisplayRecordsbtn)
			Me.Controls.Add(Me.LaunchOnStartupbtn)
			Me.Controls.Add(Me.SecurityDepositbtn)
			Me.Controls.Add(Me.MembershipFeebtn)
			Me.Controls.Add(Me.DateFormatbtn)
			Me.Controls.Add(Me.AutomaticCompactbtn)
			Me.Controls.Add(Me.AutomaticBackupbtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Name = "ISettingsDlg"
			Me.Text = "ISettingsDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AutomaticBackupbtn As System.Windows.Forms.Button
		Private WithEvents AutomaticCompactbtn As System.Windows.Forms.Button
		Private WithEvents DateFormatbtn As System.Windows.Forms.Button
		Private WithEvents MembershipFeebtn As System.Windows.Forms.Button
		Private WithEvents SecurityDepositbtn As System.Windows.Forms.Button
		Private WithEvents LaunchOnStartupbtn As System.Windows.Forms.Button
		Private WithEvents NoOfDisplayRecordsbtn As System.Windows.Forms.Button
		Private WithEvents OverrideExDataOnABbtn As System.Windows.Forms.Button
		Private WithEvents PaymentMethodbtn As System.Windows.Forms.Button
		Private WithEvents PictureFolderbtn As System.Windows.Forms.Button
		Private WithEvents UseEnterKeybtn As System.Windows.Forms.Button
		Private RsltLbl As System.Windows.Forms.Label
		Private paymntTxt As System.Windows.Forms.TextBox
		Private WithEvents EnterPaymntMthdbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents Clsbtn As System.Windows.Forms.Button
		Private Paymntlbl As System.Windows.Forms.Label
	End Class
End Namespace