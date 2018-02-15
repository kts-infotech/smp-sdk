Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpAppDlg
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
			Me.windowTxt = New System.Windows.Forms.TextBox()
			Me.Windowbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.setaddininfobtn = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.AddinSecurityinfotxt = New System.Windows.Forms.Button()
			Me.SendStatusbtn = New System.Windows.Forms.Button()
			Me.SendStatusTxt = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' windowTxt
			' 
			'this.windowTxt.Location = new System.Drawing.Point(38, 35);
			'this.windowTxt.Name = "windowTxt";
			'this.windowTxt.Size = new System.Drawing.Size(226, 20);
			'this.windowTxt.TabIndex = 0;
			'this.windowTxt.TextChanged += new System.EventHandler(this.GetwindowTxt_TextChanged);
			' 
			' Windowbtn
			' 
			Me.Windowbtn.Location = New System.Drawing.Point(128, 75)
			Me.Windowbtn.Name = "Windowbtn"
			Me.Windowbtn.Size = New System.Drawing.Size(136, 35)
			Me.Windowbtn.TabIndex = 1
			Me.Windowbtn.Text = "Get Window Handle"
			Me.Windowbtn.UseVisualStyleBackColor = True
'			Me.Windowbtn.Click += New System.EventHandler(Me.GetWindowbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Windowbtn)
			Me.groupBox1.Controls.Add(Me.windowTxt)
			Me.groupBox1.Location = New System.Drawing.Point(35, 37)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(305, 133)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			' 
			' setaddininfobtn
			' 
			Me.setaddininfobtn.Location = New System.Drawing.Point(163, 241)
			Me.setaddininfobtn.Name = "setaddininfobtn"
			Me.setaddininfobtn.Size = New System.Drawing.Size(136, 35)
			Me.setaddininfobtn.TabIndex = 3
			Me.setaddininfobtn.Text = "Set Addin Info"
			Me.setaddininfobtn.UseVisualStyleBackColor = True
'			Me.setaddininfobtn.Click += New System.EventHandler(Me.setaddininfobtn_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.Location = New System.Drawing.Point(35, 203)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(305, 100)
			Me.groupBox2.TabIndex = 4
			Me.groupBox2.TabStop = False
			' 
			' AddinSecurityinfotxt
			' 
			Me.AddinSecurityinfotxt.Location = New System.Drawing.Point(533, 241)
			Me.AddinSecurityinfotxt.Name = "AddinSecurityinfotxt"
			Me.AddinSecurityinfotxt.Size = New System.Drawing.Size(134, 35)
			Me.AddinSecurityinfotxt.TabIndex = 5
			Me.AddinSecurityinfotxt.Text = "Set Addin Security Info"
			Me.AddinSecurityinfotxt.UseVisualStyleBackColor = True
'			Me.AddinSecurityinfotxt.Click += New System.EventHandler(Me.AddinSecurityinfotxt_Click);
			' 
			' SendStatusbtn
			' 
			Me.SendStatusbtn.Location = New System.Drawing.Point(547, 118)
			Me.SendStatusbtn.Name = "SendStatusbtn"
			Me.SendStatusbtn.Size = New System.Drawing.Size(120, 29)
			Me.SendStatusbtn.TabIndex = 6
			Me.SendStatusbtn.Text = "Send Status"
			Me.SendStatusbtn.UseVisualStyleBackColor = True
'			Me.SendStatusbtn.Click += New System.EventHandler(Me.button2_Click);
			' 
			' SendStatusTxt
			' 
			Me.SendStatusTxt.Location = New System.Drawing.Point(473, 72)
			Me.SendStatusTxt.Name = "SendStatusTxt"
			Me.SendStatusTxt.Size = New System.Drawing.Size(194, 20)
			Me.SendStatusTxt.TabIndex = 7
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(411, 75)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(37, 13)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Status"
			' 
			' groupBox3
			' 
			Me.groupBox3.Location = New System.Drawing.Point(377, 37)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(322, 133)
			Me.groupBox3.TabIndex = 9
			Me.groupBox3.TabStop = False
			' 
			' groupBox4
			' 
			Me.groupBox4.Location = New System.Drawing.Point(377, 203)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(322, 100)
			Me.groupBox4.TabIndex = 10
			Me.groupBox4.TabStop = False
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(656, 328)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 35)
			Me.Clsbtn.TabIndex = 11
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' ISmpAppDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(765, 375)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.SendStatusTxt)
			Me.Controls.Add(Me.SendStatusbtn)
			Me.Controls.Add(Me.AddinSecurityinfotxt)
			Me.Controls.Add(Me.setaddininfobtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox4)
			Me.Name = "ISmpAppDlg"
			Me.Text = "ISmpAppDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private windowTxt As System.Windows.Forms.TextBox
		Private WithEvents Windowbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents setaddininfobtn As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents AddinSecurityinfotxt As System.Windows.Forms.Button
		Private WithEvents SendStatusbtn As System.Windows.Forms.Button
		Private SendStatusTxt As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private WithEvents Clsbtn As System.Windows.Forms.Button
	End Class
End Namespace