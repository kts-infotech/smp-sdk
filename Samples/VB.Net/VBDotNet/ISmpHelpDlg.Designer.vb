Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpHelpDlg
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
			Me.AboutBoxbtn = New System.Windows.Forms.Button()
			Me.HelTopicsbtn = New System.Windows.Forms.Button()
			Me.MenuShortcutKeybtn = New System.Windows.Forms.Button()
			Me.InvokeRegisterbtn = New System.Windows.Forms.Button()
			Me.TipOfTheDayDlgbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AboutBoxbtn
			' 
			Me.AboutBoxbtn.Location = New System.Drawing.Point(19, 34)
			Me.AboutBoxbtn.Name = "AboutBoxbtn"
			Me.AboutBoxbtn.Size = New System.Drawing.Size(128, 36)
			Me.AboutBoxbtn.TabIndex = 0
			Me.AboutBoxbtn.Text = "About Box"
			Me.AboutBoxbtn.UseVisualStyleBackColor = True
'			Me.AboutBoxbtn.Click += New System.EventHandler(Me.AboutBoxbtn_Click);
			' 
			' HelTopicsbtn
			' 
			Me.HelTopicsbtn.Location = New System.Drawing.Point(122, 96)
			Me.HelTopicsbtn.Name = "HelTopicsbtn"
			Me.HelTopicsbtn.Size = New System.Drawing.Size(128, 36)
			Me.HelTopicsbtn.TabIndex = 1
			Me.HelTopicsbtn.Text = "HelpTopics"
			Me.HelTopicsbtn.UseVisualStyleBackColor = True
'			Me.HelTopicsbtn.Click += New System.EventHandler(Me.HelTopicsbtn_Click);
			' 
			' MenuShortcutKeybtn
			' 
			Me.MenuShortcutKeybtn.Location = New System.Drawing.Point(19, 159)
			Me.MenuShortcutKeybtn.Name = "MenuShortcutKeybtn"
			Me.MenuShortcutKeybtn.Size = New System.Drawing.Size(128, 36)
			Me.MenuShortcutKeybtn.TabIndex = 2
			Me.MenuShortcutKeybtn.Text = "Menu ShortcutKey"
			Me.MenuShortcutKeybtn.UseVisualStyleBackColor = True
'			Me.MenuShortcutKeybtn.Click += New System.EventHandler(Me.MenuShortcutKeybtn_Click);
			' 
			' InvokeRegisterbtn
			' 
			Me.InvokeRegisterbtn.Location = New System.Drawing.Point(230, 34)
			Me.InvokeRegisterbtn.Name = "InvokeRegisterbtn"
			Me.InvokeRegisterbtn.Size = New System.Drawing.Size(128, 36)
			Me.InvokeRegisterbtn.TabIndex = 3
			Me.InvokeRegisterbtn.Text = " Register"
			Me.InvokeRegisterbtn.UseVisualStyleBackColor = True
'			Me.InvokeRegisterbtn.Click += New System.EventHandler(Me.InvokeRegisterbtn_Click);
			' 
			' TipOfTheDayDlgbtn
			' 
			Me.TipOfTheDayDlgbtn.Location = New System.Drawing.Point(230, 159)
			Me.TipOfTheDayDlgbtn.Name = "TipOfTheDayDlgbtn"
			Me.TipOfTheDayDlgbtn.Size = New System.Drawing.Size(128, 36)
			Me.TipOfTheDayDlgbtn.TabIndex = 4
			Me.TipOfTheDayDlgbtn.Text = "Tip Of The Day"
			Me.TipOfTheDayDlgbtn.UseVisualStyleBackColor = True
'			Me.TipOfTheDayDlgbtn.Click += New System.EventHandler(Me.TipOfTheDayDlgbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.TipOfTheDayDlgbtn)
			Me.groupBox1.Controls.Add(Me.InvokeRegisterbtn)
			Me.groupBox1.Controls.Add(Me.MenuShortcutKeybtn)
			Me.groupBox1.Controls.Add(Me.HelTopicsbtn)
			Me.groupBox1.Controls.Add(Me.AboutBoxbtn)
			Me.groupBox1.Location = New System.Drawing.Point(12, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(381, 226)
			Me.groupBox1.TabIndex = 5
			Me.groupBox1.TabStop = False
			' 
			' HelpDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(404, 266)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "HelpDlg"
			Me.Text = "HelpDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AboutBoxbtn As System.Windows.Forms.Button
		Private WithEvents HelTopicsbtn As System.Windows.Forms.Button
		Private WithEvents MenuShortcutKeybtn As System.Windows.Forms.Button
		Private WithEvents InvokeRegisterbtn As System.Windows.Forms.Button
		Private WithEvents TipOfTheDayDlgbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace