Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpReportSettingDlg
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
			Me.AllwaysPrintMembershipFormbtn = New System.Windows.Forms.Button()
			Me.BypassPrintDlgbtn = New System.Windows.Forms.Button()
			Me.PrintPhNoAtFooterbtn = New System.Windows.Forms.Button()
			Me.PrintShopLogobtn = New System.Windows.Forms.Button()
			Me.PrintShopNameAtHeaderbtn = New System.Windows.Forms.Button()
			Me.PrintTimeAtFooterbtn = New System.Windows.Forms.Button()
			Me.prntMbrShplbl = New System.Windows.Forms.Label()
			Me.BypassPrntlbl = New System.Windows.Forms.Label()
			Me.PrntPhnolbl = New System.Windows.Forms.Label()
			Me.PrntShpLogolbl = New System.Windows.Forms.Label()
			Me.PrntShpNmeAtHederlbl = New System.Windows.Forms.Label()
			Me.PrntTmeAtFootrlbl = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AllwaysPrintMembershipFormbtn
			' 
			Me.AllwaysPrintMembershipFormbtn.Location = New System.Drawing.Point(9, 17)
			Me.AllwaysPrintMembershipFormbtn.Name = "AllwaysPrintMembershipFormbtn"
			Me.AllwaysPrintMembershipFormbtn.Size = New System.Drawing.Size(166, 33)
			Me.AllwaysPrintMembershipFormbtn.TabIndex = 0
			Me.AllwaysPrintMembershipFormbtn.Text = "Print Membership Form"
			Me.AllwaysPrintMembershipFormbtn.UseVisualStyleBackColor = True
'			Me.AllwaysPrintMembershipFormbtn.Click += New System.EventHandler(Me.AllwaysPrintMembershipFormbtn_Click);
			' 
			' BypassPrintDlgbtn
			' 
			Me.BypassPrintDlgbtn.Location = New System.Drawing.Point(9, 65)
			Me.BypassPrintDlgbtn.Name = "BypassPrintDlgbtn"
			Me.BypassPrintDlgbtn.Size = New System.Drawing.Size(166, 33)
			Me.BypassPrintDlgbtn.TabIndex = 1
			Me.BypassPrintDlgbtn.Text = "Bypass Print"
			Me.BypassPrintDlgbtn.UseVisualStyleBackColor = True
'			Me.BypassPrintDlgbtn.Click += New System.EventHandler(Me.BypassPrintDlgbtn_Click);
			' 
			' PrintPhNoAtFooterbtn
			' 
			Me.PrintPhNoAtFooterbtn.Location = New System.Drawing.Point(9, 113)
			Me.PrintPhNoAtFooterbtn.Name = "PrintPhNoAtFooterbtn"
			Me.PrintPhNoAtFooterbtn.Size = New System.Drawing.Size(166, 33)
			Me.PrintPhNoAtFooterbtn.TabIndex = 2
			Me.PrintPhNoAtFooterbtn.Text = "Print Phone Number At Footer"
			Me.PrintPhNoAtFooterbtn.UseVisualStyleBackColor = True
'			Me.PrintPhNoAtFooterbtn.Click += New System.EventHandler(Me.PrintPhNoAtFooterbtn_Click);
			' 
			' PrintShopLogobtn
			' 
			Me.PrintShopLogobtn.Location = New System.Drawing.Point(9, 161)
			Me.PrintShopLogobtn.Name = "PrintShopLogobtn"
			Me.PrintShopLogobtn.Size = New System.Drawing.Size(166, 33)
			Me.PrintShopLogobtn.TabIndex = 3
			Me.PrintShopLogobtn.Text = "Print Shop Logo"
			Me.PrintShopLogobtn.UseVisualStyleBackColor = True
'			Me.PrintShopLogobtn.Click += New System.EventHandler(Me.PrintShopLogobtn_Click);
			' 
			' PrintShopNameAtHeaderbtn
			' 
			Me.PrintShopNameAtHeaderbtn.Location = New System.Drawing.Point(9, 209)
			Me.PrintShopNameAtHeaderbtn.Name = "PrintShopNameAtHeaderbtn"
			Me.PrintShopNameAtHeaderbtn.Size = New System.Drawing.Size(166, 33)
			Me.PrintShopNameAtHeaderbtn.TabIndex = 4
			Me.PrintShopNameAtHeaderbtn.Text = "Print Shop Name At Header"
			Me.PrintShopNameAtHeaderbtn.UseVisualStyleBackColor = True
'			Me.PrintShopNameAtHeaderbtn.Click += New System.EventHandler(Me.PrintShopNameAtHeaderbtn_Click);
			' 
			' PrintTimeAtFooterbtn
			' 
			Me.PrintTimeAtFooterbtn.Location = New System.Drawing.Point(9, 259)
			Me.PrintTimeAtFooterbtn.Name = "PrintTimeAtFooterbtn"
			Me.PrintTimeAtFooterbtn.Size = New System.Drawing.Size(166, 33)
			Me.PrintTimeAtFooterbtn.TabIndex = 5
			Me.PrintTimeAtFooterbtn.Text = "Print Time At Footer"
			Me.PrintTimeAtFooterbtn.UseVisualStyleBackColor = True
'			Me.PrintTimeAtFooterbtn.Click += New System.EventHandler(Me.PrintTimeAtFooterbtn_Click);
			' 
			' prntMbrShplbl
			' 
			Me.prntMbrShplbl.AutoSize = True
			Me.prntMbrShplbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.prntMbrShplbl.ForeColor = System.Drawing.Color.Red
			Me.prntMbrShplbl.Location = New System.Drawing.Point(214, 27)
			Me.prntMbrShplbl.Name = "prntMbrShplbl"
			Me.prntMbrShplbl.Size = New System.Drawing.Size(0, 19)
			Me.prntMbrShplbl.TabIndex = 6
			' 
			' BypassPrntlbl
			' 
			Me.BypassPrntlbl.AutoSize = True
			Me.BypassPrntlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.BypassPrntlbl.ForeColor = System.Drawing.Color.Red
			Me.BypassPrntlbl.Location = New System.Drawing.Point(214, 75)
			Me.BypassPrntlbl.Name = "BypassPrntlbl"
			Me.BypassPrntlbl.Size = New System.Drawing.Size(0, 19)
			Me.BypassPrntlbl.TabIndex = 7
			' 
			' PrntPhnolbl
			' 
			Me.PrntPhnolbl.AutoSize = True
			Me.PrntPhnolbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntPhnolbl.ForeColor = System.Drawing.Color.Red
			Me.PrntPhnolbl.Location = New System.Drawing.Point(214, 123)
			Me.PrntPhnolbl.Name = "PrntPhnolbl"
			Me.PrntPhnolbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntPhnolbl.TabIndex = 8
			' 
			' PrntShpLogolbl
			' 
			Me.PrntShpLogolbl.AutoSize = True
			Me.PrntShpLogolbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntShpLogolbl.ForeColor = System.Drawing.Color.Red
			Me.PrntShpLogolbl.Location = New System.Drawing.Point(214, 171)
			Me.PrntShpLogolbl.Name = "PrntShpLogolbl"
			Me.PrntShpLogolbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntShpLogolbl.TabIndex = 9
			' 
			' PrntShpNmeAtHederlbl
			' 
			Me.PrntShpNmeAtHederlbl.AutoSize = True
			Me.PrntShpNmeAtHederlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntShpNmeAtHederlbl.ForeColor = System.Drawing.Color.Red
			Me.PrntShpNmeAtHederlbl.Location = New System.Drawing.Point(214, 219)
			Me.PrntShpNmeAtHederlbl.Name = "PrntShpNmeAtHederlbl"
			Me.PrntShpNmeAtHederlbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntShpNmeAtHederlbl.TabIndex = 10
			' 
			' PrntTmeAtFootrlbl
			' 
			Me.PrntTmeAtFootrlbl.AutoSize = True
			Me.PrntTmeAtFootrlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntTmeAtFootrlbl.ForeColor = System.Drawing.Color.Red
			Me.PrntTmeAtFootrlbl.Location = New System.Drawing.Point(214, 269)
			Me.PrntTmeAtFootrlbl.Name = "PrntTmeAtFootrlbl"
			Me.PrntTmeAtFootrlbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntTmeAtFootrlbl.TabIndex = 11
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.PrntTmeAtFootrlbl)
			Me.groupBox1.Controls.Add(Me.PrntShpNmeAtHederlbl)
			Me.groupBox1.Controls.Add(Me.PrntShpLogolbl)
			Me.groupBox1.Controls.Add(Me.PrntPhnolbl)
			Me.groupBox1.Controls.Add(Me.BypassPrntlbl)
			Me.groupBox1.Controls.Add(Me.prntMbrShplbl)
			Me.groupBox1.Controls.Add(Me.PrintTimeAtFooterbtn)
			Me.groupBox1.Controls.Add(Me.PrintShopNameAtHeaderbtn)
			Me.groupBox1.Controls.Add(Me.PrintShopLogobtn)
			Me.groupBox1.Controls.Add(Me.PrintPhNoAtFooterbtn)
			Me.groupBox1.Controls.Add(Me.BypassPrintDlgbtn)
			Me.groupBox1.Controls.Add(Me.AllwaysPrintMembershipFormbtn)
			Me.groupBox1.Location = New System.Drawing.Point(16, 16)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(320, 309)
			Me.groupBox1.TabIndex = 12
			Me.groupBox1.TabStop = False
			' 
			' ReportSettingDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(353, 342)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "ReportSettingDlg"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.ReportSettingDlg_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AllwaysPrintMembershipFormbtn As System.Windows.Forms.Button
		Private WithEvents BypassPrintDlgbtn As System.Windows.Forms.Button
		Private WithEvents PrintPhNoAtFooterbtn As System.Windows.Forms.Button
		Private WithEvents PrintShopLogobtn As System.Windows.Forms.Button
		Private WithEvents PrintShopNameAtHeaderbtn As System.Windows.Forms.Button
		Private WithEvents PrintTimeAtFooterbtn As System.Windows.Forms.Button
		Private prntMbrShplbl As System.Windows.Forms.Label
		Private BypassPrntlbl As System.Windows.Forms.Label
		Private PrntPhnolbl As System.Windows.Forms.Label
		Private PrntShpLogolbl As System.Windows.Forms.Label
		Private PrntShpNmeAtHederlbl As System.Windows.Forms.Label
		Private PrntTmeAtFootrlbl As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace