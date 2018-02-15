Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISecurityDlg
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
			Me.Accesscstmrbtn = New System.Windows.Forms.Button()
			Me.Acesssalesbtn = New System.Windows.Forms.Button()
			Me.AccessSetupbtn = New System.Windows.Forms.Button()
			Me.Accesstransctnbtn = New System.Windows.Forms.Button()
			Me.CrntusrLoginbtn = New System.Windows.Forms.Button()
			Me.Crntusrbtn = New System.Windows.Forms.Button()
			Me.DatabaseRytbtn = New System.Windows.Forms.Button()
			Me.PrntRptsbtn = New System.Windows.Forms.Button()
			Me.ShpbalBtn = New System.Windows.Forms.Button()
			Me.VwRptBtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.UsrRytBtn = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.LeafsecurityTxt = New System.Windows.Forms.TextBox()
			Me.ModuleTxt = New System.Windows.Forms.TextBox()
			Me.XMTTxt = New System.Windows.Forms.TextBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.UserBtn = New System.Windows.Forms.Button()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.UsrNmeTxt = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.Infolist = New System.Windows.Forms.ListBox()
			Me.InfoLbl = New System.Windows.Forms.Label()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.Securitylist = New System.Windows.Forms.ListBox()
			Me.groupBox4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' Accesscstmrbtn
			' 
			Me.Accesscstmrbtn.Location = New System.Drawing.Point(40, 47)
			Me.Accesscstmrbtn.Name = "Accesscstmrbtn"
			Me.Accesscstmrbtn.Size = New System.Drawing.Size(143, 32)
			Me.Accesscstmrbtn.TabIndex = 0
			Me.Accesscstmrbtn.Text = "Access Customer Menu"
			Me.Accesscstmrbtn.UseVisualStyleBackColor = True
'			Me.Accesscstmrbtn.Click += New System.EventHandler(Me.Accesscstmrbtn_Click);
			' 
			' Acesssalesbtn
			' 
			Me.Acesssalesbtn.Location = New System.Drawing.Point(40, 85)
			Me.Acesssalesbtn.Name = "Acesssalesbtn"
			Me.Acesssalesbtn.Size = New System.Drawing.Size(143, 32)
			Me.Acesssalesbtn.TabIndex = 1
			Me.Acesssalesbtn.Text = "Access Sales Menu"
			Me.Acesssalesbtn.UseVisualStyleBackColor = True
'			Me.Acesssalesbtn.Click += New System.EventHandler(Me.Acesssalesbtn_Click);
			' 
			' AccessSetupbtn
			' 
			Me.AccessSetupbtn.Location = New System.Drawing.Point(40, 124)
			Me.AccessSetupbtn.Name = "AccessSetupbtn"
			Me.AccessSetupbtn.Size = New System.Drawing.Size(143, 32)
			Me.AccessSetupbtn.TabIndex = 2
			Me.AccessSetupbtn.Text = "Access SetUp"
			Me.AccessSetupbtn.UseVisualStyleBackColor = True
'			Me.AccessSetupbtn.Click += New System.EventHandler(Me.AccessSetupbtn_Click);
			' 
			' Accesstransctnbtn
			' 
			Me.Accesstransctnbtn.Location = New System.Drawing.Point(40, 163)
			Me.Accesstransctnbtn.Name = "Accesstransctnbtn"
			Me.Accesstransctnbtn.Size = New System.Drawing.Size(143, 32)
			Me.Accesstransctnbtn.TabIndex = 3
			Me.Accesstransctnbtn.Text = "Access Transaction Menu"
			Me.Accesstransctnbtn.UseVisualStyleBackColor = True
'			Me.Accesstransctnbtn.Click += New System.EventHandler(Me.Accesstransctnbtn_Click);
			' 
			' CrntusrLoginbtn
			' 
			Me.CrntusrLoginbtn.Location = New System.Drawing.Point(40, 203)
			Me.CrntusrLoginbtn.Name = "CrntusrLoginbtn"
			Me.CrntusrLoginbtn.Size = New System.Drawing.Size(143, 32)
			Me.CrntusrLoginbtn.TabIndex = 4
			Me.CrntusrLoginbtn.Text = "Current User Login"
			Me.CrntusrLoginbtn.UseVisualStyleBackColor = True
'			Me.CrntusrLoginbtn.Click += New System.EventHandler(Me.CrntusrLoginbtn_Click);
			' 
			' Crntusrbtn
			' 
			Me.Crntusrbtn.Location = New System.Drawing.Point(204, 47)
			Me.Crntusrbtn.Name = "Crntusrbtn"
			Me.Crntusrbtn.Size = New System.Drawing.Size(143, 32)
			Me.Crntusrbtn.TabIndex = 5
			Me.Crntusrbtn.Text = "Current User Rights"
			Me.Crntusrbtn.UseVisualStyleBackColor = True
'			Me.Crntusrbtn.Click += New System.EventHandler(Me.Crntusrbtn_Click);
			' 
			' DatabaseRytbtn
			' 
			Me.DatabaseRytbtn.Location = New System.Drawing.Point(204, 85)
			Me.DatabaseRytbtn.Name = "DatabaseRytbtn"
			Me.DatabaseRytbtn.Size = New System.Drawing.Size(143, 32)
			Me.DatabaseRytbtn.TabIndex = 6
			Me.DatabaseRytbtn.Text = "Database Right"
			Me.DatabaseRytbtn.UseVisualStyleBackColor = True
'			Me.DatabaseRytbtn.Click += New System.EventHandler(Me.DatabaseRytbtn_Click);
			' 
			' PrntRptsbtn
			' 
			Me.PrntRptsbtn.Location = New System.Drawing.Point(204, 124)
			Me.PrntRptsbtn.Name = "PrntRptsbtn"
			Me.PrntRptsbtn.Size = New System.Drawing.Size(143, 32)
			Me.PrntRptsbtn.TabIndex = 7
			Me.PrntRptsbtn.Text = "Print Reports"
			Me.PrntRptsbtn.UseVisualStyleBackColor = True
'			Me.PrntRptsbtn.Click += New System.EventHandler(Me.PrntRptsbtn_Click);
			' 
			' ShpbalBtn
			' 
			Me.ShpbalBtn.Location = New System.Drawing.Point(204, 163)
			Me.ShpbalBtn.Name = "ShpbalBtn"
			Me.ShpbalBtn.Size = New System.Drawing.Size(143, 32)
			Me.ShpbalBtn.TabIndex = 8
			Me.ShpbalBtn.Text = "Update Shop Balance"
			Me.ShpbalBtn.UseVisualStyleBackColor = True
'			Me.ShpbalBtn.Click += New System.EventHandler(Me.ShpbalBtn_Click);
			' 
			' VwRptBtn
			' 
			Me.VwRptBtn.Location = New System.Drawing.Point(204, 203)
			Me.VwRptBtn.Name = "VwRptBtn"
			Me.VwRptBtn.Size = New System.Drawing.Size(143, 32)
			Me.VwRptBtn.TabIndex = 9
			Me.VwRptBtn.Text = "View Reports"
			Me.VwRptBtn.UseVisualStyleBackColor = True
'			Me.VwRptBtn.Click += New System.EventHandler(Me.VwRptBtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Location = New System.Drawing.Point(12, 18)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(361, 240)
			Me.groupBox1.TabIndex = 10
			Me.groupBox1.TabStop = False
			' 
			' UsrRytBtn
			' 
			Me.UsrRytBtn.Location = New System.Drawing.Point(244, 442)
			Me.UsrRytBtn.Name = "UsrRytBtn"
			Me.UsrRytBtn.Size = New System.Drawing.Size(103, 32)
			Me.UsrRytBtn.TabIndex = 11
			Me.UsrRytBtn.Text = "User Right info"
			Me.UsrRytBtn.UseVisualStyleBackColor = True
'			Me.UsrRytBtn.Click += New System.EventHandler(Me.UsrRytBtn_Click);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(37, 397)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(129, 13)
			Me.label1.TabIndex = 12
			Me.label1.Text = "Leaf Security Node Name"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(37, 359)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(81, 13)
			Me.label2.TabIndex = 13
			Me.label2.Text = "Module Section"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(37, 320)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(98, 13)
			Me.label3.TabIndex = 14
			Me.label3.Text = "XML Module Name"
			' 
			' LeafsecurityTxt
			' 
			Me.LeafsecurityTxt.Location = New System.Drawing.Point(204, 394)
			Me.LeafsecurityTxt.Name = "LeafsecurityTxt"
			Me.LeafsecurityTxt.Size = New System.Drawing.Size(143, 20)
			Me.LeafsecurityTxt.TabIndex = 15
			' 
			' ModuleTxt
			' 
			Me.ModuleTxt.Location = New System.Drawing.Point(204, 356)
			Me.ModuleTxt.Name = "ModuleTxt"
			Me.ModuleTxt.Size = New System.Drawing.Size(143, 20)
			Me.ModuleTxt.TabIndex = 16
			' 
			' XMTTxt
			' 
			Me.XMTTxt.Location = New System.Drawing.Point(204, 317)
			Me.XMTTxt.Name = "XMTTxt"
			Me.XMTTxt.Size = New System.Drawing.Size(143, 20)
			Me.XMTTxt.TabIndex = 17
			' 
			' groupBox2
			' 
			Me.groupBox2.Location = New System.Drawing.Point(12, 288)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(361, 202)
			Me.groupBox2.TabIndex = 18
			Me.groupBox2.TabStop = False
			' 
			' UserBtn
			' 
			Me.UserBtn.Location = New System.Drawing.Point(244, 552)
			Me.UserBtn.Name = "UserBtn"
			Me.UserBtn.Size = New System.Drawing.Size(103, 32)
			Me.UserBtn.TabIndex = 19
			Me.UserBtn.Text = "User Right Info"
			Me.UserBtn.UseVisualStyleBackColor = True
'			Me.UserBtn.Click += New System.EventHandler(Me.UserBtn_Click);
			' 
			' groupBox3
			' 
			Me.groupBox3.Location = New System.Drawing.Point(12, 501)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(361, 100)
			Me.groupBox3.TabIndex = 20
			Me.groupBox3.TabStop = False
			' 
			' UsrNmeTxt
			' 
			Me.UsrNmeTxt.Location = New System.Drawing.Point(204, 526)
			Me.UsrNmeTxt.Name = "UsrNmeTxt"
			Me.UsrNmeTxt.Size = New System.Drawing.Size(143, 20)
			Me.UsrNmeTxt.TabIndex = 0
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(37, 529)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(60, 13)
			Me.label4.TabIndex = 1
			Me.label4.Text = "User Name"
			' 
			' Infolist
			' 
			Me.Infolist.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Infolist.ForeColor = System.Drawing.Color.Red
			Me.Infolist.FormattingEnabled = True
			Me.Infolist.HorizontalScrollbar = True
			Me.Infolist.ItemHeight = 15
			Me.Infolist.Location = New System.Drawing.Point(416, 49)
			Me.Infolist.MultiColumn = True
			Me.Infolist.Name = "Infolist"
			Me.Infolist.Size = New System.Drawing.Size(186, 184)
			Me.Infolist.TabIndex = 15
			' 
			' InfoLbl
			' 
			Me.InfoLbl.AutoSize = True
			Me.InfoLbl.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.InfoLbl.ForeColor = System.Drawing.Color.Red
			Me.InfoLbl.Location = New System.Drawing.Point(413, 376)
			Me.InfoLbl.Name = "InfoLbl"
			Me.InfoLbl.Size = New System.Drawing.Size(0, 15)
			Me.InfoLbl.TabIndex = 22
			' 
			' groupBox4
			' 
			Me.groupBox4.Controls.Add(Me.Securitylist)
			Me.groupBox4.Location = New System.Drawing.Point(379, 18)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(257, 583)
			Me.groupBox4.TabIndex = 24
			Me.groupBox4.TabStop = False
			' 
			' Securitylist
			' 
			Me.Securitylist.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Securitylist.ForeColor = System.Drawing.Color.Red
			Me.Securitylist.FormattingEnabled = True
			Me.Securitylist.HorizontalScrollbar = True
			Me.Securitylist.ItemHeight = 15
			Me.Securitylist.Location = New System.Drawing.Point(37, 495)
			Me.Securitylist.MultiColumn = True
			Me.Securitylist.Name = "Securitylist"
			Me.Securitylist.Size = New System.Drawing.Size(186, 79)
			Me.Securitylist.TabIndex = 15
			' 
			' ISecurityDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(648, 621)
			Me.Controls.Add(Me.InfoLbl)
			Me.Controls.Add(Me.Infolist)
			Me.Controls.Add(Me.UsrNmeTxt)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.UserBtn)
			Me.Controls.Add(Me.XMTTxt)
			Me.Controls.Add(Me.ModuleTxt)
			Me.Controls.Add(Me.LeafsecurityTxt)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.UsrRytBtn)
			Me.Controls.Add(Me.VwRptBtn)
			Me.Controls.Add(Me.ShpbalBtn)
			Me.Controls.Add(Me.PrntRptsbtn)
			Me.Controls.Add(Me.DatabaseRytbtn)
			Me.Controls.Add(Me.Crntusrbtn)
			Me.Controls.Add(Me.CrntusrLoginbtn)
			Me.Controls.Add(Me.Accesstransctnbtn)
			Me.Controls.Add(Me.AccessSetupbtn)
			Me.Controls.Add(Me.Acesssalesbtn)
			Me.Controls.Add(Me.Accesscstmrbtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox4)
			Me.Name = "ISecurityDlg"
			Me.Text = "ISecurityDlg"
			Me.groupBox4.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents Accesscstmrbtn As System.Windows.Forms.Button
		Private WithEvents Acesssalesbtn As System.Windows.Forms.Button
		Private WithEvents AccessSetupbtn As System.Windows.Forms.Button
		Private WithEvents Accesstransctnbtn As System.Windows.Forms.Button
		Private WithEvents CrntusrLoginbtn As System.Windows.Forms.Button
		Private WithEvents Crntusrbtn As System.Windows.Forms.Button
		Private WithEvents DatabaseRytbtn As System.Windows.Forms.Button
		Private WithEvents PrntRptsbtn As System.Windows.Forms.Button
		Private WithEvents ShpbalBtn As System.Windows.Forms.Button
		Private WithEvents VwRptBtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents UsrRytBtn As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private LeafsecurityTxt As System.Windows.Forms.TextBox
		Private ModuleTxt As System.Windows.Forms.TextBox
		Private XMTTxt As System.Windows.Forms.TextBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents UserBtn As System.Windows.Forms.Button
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private UsrNmeTxt As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private Infolist As System.Windows.Forms.ListBox
		Private InfoLbl As System.Windows.Forms.Label
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private Securitylist As System.Windows.Forms.ListBox
	End Class
End Namespace