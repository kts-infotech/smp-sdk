Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpUserDlg
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
			Me.loginbtn = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' loginbtn
			' 
			Me.loginbtn.Location = New System.Drawing.Point(27, 32)
			Me.loginbtn.Name = "loginbtn"
			Me.loginbtn.Size = New System.Drawing.Size(116, 40)
			Me.loginbtn.TabIndex = 0
			Me.loginbtn.Text = "Log In/Log Out"
			Me.loginbtn.UseVisualStyleBackColor = True
'			Me.loginbtn.Click += New System.EventHandler(Me.loginbtn_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(149, 32)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(116, 40)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Change Password"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.loginbtn)
			Me.groupBox1.Location = New System.Drawing.Point(12, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(288, 104)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			' 
			' SmpUserDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(311, 136)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SmpUserDlg"
			Me.Text = "SmpUserdlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents loginbtn As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox

	End Class
End Namespace