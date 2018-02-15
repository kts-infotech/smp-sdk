Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IISmpCommandsDlg
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
			Me.SesonIdBtn = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SesonIdTxt = New System.Windows.Forms.TextBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.MenustringTxt = New System.Windows.Forms.TextBox()
			Me.GetMenustringTxt = New System.Windows.Forms.Button()
			Me.MenuCommandIdbtn = New System.Windows.Forms.Button()
			Me.CommandIdTxt = New System.Windows.Forms.TextBox()
			Me.NoOfComandsTxt = New System.Windows.Forms.TextBox()
			Me.CommandExTxt = New System.Windows.Forms.TextBox()
			Me.FunctionmeTxt = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.Noofcommandsbtn = New System.Windows.Forms.Button()
			Me.MenuCommandExbtn = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.SuspendLayout()
			' 
			' SesonIdBtn
			' 
			Me.SesonIdBtn.Enabled = False
			Me.SesonIdBtn.Location = New System.Drawing.Point(263, 46)
			Me.SesonIdBtn.Name = "SesonIdBtn"
			Me.SesonIdBtn.Size = New System.Drawing.Size(137, 35)
			Me.SesonIdBtn.TabIndex = 0
			Me.SesonIdBtn.Text = "Set Session Id"
			Me.SesonIdBtn.UseVisualStyleBackColor = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(39, 57)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(56, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Session Id"
			' 
			' SesonIdTxt
			' 
			Me.SesonIdTxt.Enabled = False
			Me.SesonIdTxt.Location = New System.Drawing.Point(142, 54)
			Me.SesonIdTxt.Name = "SesonIdTxt"
			Me.SesonIdTxt.Size = New System.Drawing.Size(100, 20)
			Me.SesonIdTxt.TabIndex = 2
			Me.SesonIdTxt.Text = "0"
			' 
			' groupBox1
			' 
			Me.groupBox1.Location = New System.Drawing.Point(12, 27)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(429, 75)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(39, 216)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(68, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Command ID"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(39, 156)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(64, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Menu String"
			' 
			' MenustringTxt
			' 
			Me.MenustringTxt.Location = New System.Drawing.Point(142, 153)
			Me.MenustringTxt.Name = "MenustringTxt"
			Me.MenustringTxt.Size = New System.Drawing.Size(100, 20)
			Me.MenustringTxt.TabIndex = 6
			' 
			' GetMenustringTxt
			' 
			Me.GetMenustringTxt.Location = New System.Drawing.Point(263, 205)
			Me.GetMenustringTxt.Name = "GetMenustringTxt"
			Me.GetMenustringTxt.Size = New System.Drawing.Size(137, 35)
			Me.GetMenustringTxt.TabIndex = 7
			Me.GetMenustringTxt.Text = "Get Menu String"
			Me.GetMenustringTxt.UseVisualStyleBackColor = True
'			Me.GetMenustringTxt.Click += New System.EventHandler(Me.GetMenustringTxt_Click);
			' 
			' MenuCommandIdbtn
			' 
			Me.MenuCommandIdbtn.Location = New System.Drawing.Point(263, 145)
			Me.MenuCommandIdbtn.Name = "MenuCommandIdbtn"
			Me.MenuCommandIdbtn.Size = New System.Drawing.Size(137, 35)
			Me.MenuCommandIdbtn.TabIndex = 8
			Me.MenuCommandIdbtn.Text = "Get Menu Command ID"
			Me.MenuCommandIdbtn.UseVisualStyleBackColor = True
'			Me.MenuCommandIdbtn.Click += New System.EventHandler(Me.MenuCommandIdbtn_Click);
			' 
			' CommandIdTxt
			' 
			Me.CommandIdTxt.Enabled = False
			Me.CommandIdTxt.Location = New System.Drawing.Point(142, 213)
			Me.CommandIdTxt.Name = "CommandIdTxt"
			Me.CommandIdTxt.Size = New System.Drawing.Size(100, 20)
			Me.CommandIdTxt.TabIndex = 9
			' 
			' NoOfComandsTxt
			' 
			Me.NoOfComandsTxt.Enabled = False
			Me.NoOfComandsTxt.Location = New System.Drawing.Point(142, 414)
			Me.NoOfComandsTxt.Name = "NoOfComandsTxt"
			Me.NoOfComandsTxt.Size = New System.Drawing.Size(100, 20)
			Me.NoOfComandsTxt.TabIndex = 10
			' 
			' CommandExTxt
			' 
			Me.CommandExTxt.Enabled = False
			Me.CommandExTxt.Location = New System.Drawing.Point(142, 363)
			Me.CommandExTxt.Name = "CommandExTxt"
			Me.CommandExTxt.Size = New System.Drawing.Size(100, 20)
			Me.CommandExTxt.TabIndex = 11
			' 
			' FunctionmeTxt
			' 
			Me.FunctionmeTxt.Location = New System.Drawing.Point(142, 313)
			Me.FunctionmeTxt.Name = "FunctionmeTxt"
			Me.FunctionmeTxt.Size = New System.Drawing.Size(100, 20)
			Me.FunctionmeTxt.TabIndex = 12
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(39, 417)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(90, 13)
			Me.label4.TabIndex = 13
			Me.label4.Text = "No Of Commands"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(39, 366)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(99, 13)
			Me.label5.TabIndex = 14
			Me.label5.Text = "Menu Command Ex"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(39, 316)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(79, 13)
			Me.label6.TabIndex = 15
			Me.label6.Text = "Function Name"
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(354, 502)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 23)
			Me.Clsbtn.TabIndex = 16
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' Noofcommandsbtn
			' 
			Me.Noofcommandsbtn.Location = New System.Drawing.Point(263, 406)
			Me.Noofcommandsbtn.Name = "Noofcommandsbtn"
			Me.Noofcommandsbtn.Size = New System.Drawing.Size(137, 35)
			Me.Noofcommandsbtn.TabIndex = 17
			Me.Noofcommandsbtn.Text = "Get No Of commands"
			Me.Noofcommandsbtn.UseVisualStyleBackColor = True
'			Me.Noofcommandsbtn.Click += New System.EventHandler(Me.Noofcommandsbtn_Click);
			' 
			' MenuCommandExbtn
			' 
			Me.MenuCommandExbtn.Location = New System.Drawing.Point(263, 305)
			Me.MenuCommandExbtn.Name = "MenuCommandExbtn"
			Me.MenuCommandExbtn.Size = New System.Drawing.Size(137, 35)
			Me.MenuCommandExbtn.TabIndex = 18
			Me.MenuCommandExbtn.Text = "Get Menu Command Ex"
			Me.MenuCommandExbtn.UseVisualStyleBackColor = True
'			Me.MenuCommandExbtn.Click += New System.EventHandler(Me.MenuCommandExbtn_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.Location = New System.Drawing.Point(30, 284)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(399, 171)
			Me.groupBox2.TabIndex = 19
			Me.groupBox2.TabStop = False
			' 
			' groupBox3
			' 
			Me.groupBox3.Location = New System.Drawing.Point(12, 120)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(429, 365)
			Me.groupBox3.TabIndex = 0
			Me.groupBox3.TabStop = False
			' 
			' IISmpCommandsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(453, 537)
			Me.Controls.Add(Me.MenuCommandExbtn)
			Me.Controls.Add(Me.Noofcommandsbtn)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.FunctionmeTxt)
			Me.Controls.Add(Me.CommandExTxt)
			Me.Controls.Add(Me.NoOfComandsTxt)
			Me.Controls.Add(Me.CommandIdTxt)
			Me.Controls.Add(Me.MenuCommandIdbtn)
			Me.Controls.Add(Me.GetMenustringTxt)
			Me.Controls.Add(Me.MenustringTxt)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.SesonIdTxt)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.SesonIdBtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Name = "IISmpCommandsDlg"
			Me.Text = "IISmpCommands"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private SesonIdBtn As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private SesonIdTxt As System.Windows.Forms.TextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private MenustringTxt As System.Windows.Forms.TextBox
		Private WithEvents GetMenustringTxt As System.Windows.Forms.Button
		Private WithEvents MenuCommandIdbtn As System.Windows.Forms.Button
		Private CommandIdTxt As System.Windows.Forms.TextBox
		Private NoOfComandsTxt As System.Windows.Forms.TextBox
		Private CommandExTxt As System.Windows.Forms.TextBox
		Private FunctionmeTxt As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents Clsbtn As System.Windows.Forms.Button
		Private WithEvents Noofcommandsbtn As System.Windows.Forms.Button
		Private WithEvents MenuCommandExbtn As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
	End Class
End Namespace