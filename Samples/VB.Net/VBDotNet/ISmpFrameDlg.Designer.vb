Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpFrameDlg
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
			Me.LeftToolbarbtn = New System.Windows.Forms.Button()
			Me.MainFramebtn = New System.Windows.Forms.Button()
			Me.MainToolbarbtn = New System.Windows.Forms.Button()
			Me.Menubtn = New System.Windows.Forms.Button()
			Me.PluginToolbarCountbtn = New System.Windows.Forms.Button()
			Me.RightToolbarbtn = New System.Windows.Forms.Button()
			Me.Statusbarbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.Rsltlbl = New System.Windows.Forms.Label()
			Me.pluginhandlbtn = New System.Windows.Forms.Button()
			Me.pluginhandlTxt = New System.Windows.Forms.TextBox()
			Me.pluginhandllbl = New System.Windows.Forms.Label()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.comboBox3 = New System.Windows.Forms.ComboBox()
			Me.comboBox4 = New System.Windows.Forms.ComboBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' LeftToolbarbtn
			' 
			Me.LeftToolbarbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.LeftToolbarbtn.Location = New System.Drawing.Point(23, 143)
			Me.LeftToolbarbtn.Name = "LeftToolbarbtn"
			Me.LeftToolbarbtn.Size = New System.Drawing.Size(124, 35)
			Me.LeftToolbarbtn.TabIndex = 0
			Me.LeftToolbarbtn.Text = "Left Toolbar"
			Me.LeftToolbarbtn.UseVisualStyleBackColor = True
			' 
			' MainFramebtn
			' 
			Me.MainFramebtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.MainFramebtn.Location = New System.Drawing.Point(201, 90)
			Me.MainFramebtn.Name = "MainFramebtn"
			Me.MainFramebtn.Size = New System.Drawing.Size(124, 35)
			Me.MainFramebtn.TabIndex = 1
			Me.MainFramebtn.Text = "Main Frame bar"
			Me.MainFramebtn.UseVisualStyleBackColor = True
			' 
			' MainToolbarbtn
			' 
			Me.MainToolbarbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.MainToolbarbtn.Location = New System.Drawing.Point(23, 38)
			Me.MainToolbarbtn.Name = "MainToolbarbtn"
			Me.MainToolbarbtn.Size = New System.Drawing.Size(124, 35)
			Me.MainToolbarbtn.TabIndex = 2
			Me.MainToolbarbtn.Text = "Main Toolbar"
			Me.MainToolbarbtn.UseVisualStyleBackColor = True
'			Me.MainToolbarbtn.Click += New System.EventHandler(Me.MainToolbarbtn_Click);
			' 
			' Menubtn
			' 
			Me.Menubtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Menubtn.Location = New System.Drawing.Point(201, 38)
			Me.Menubtn.Name = "Menubtn"
			Me.Menubtn.Size = New System.Drawing.Size(124, 35)
			Me.Menubtn.TabIndex = 3
			Me.Menubtn.Text = "Menu bar"
			Me.Menubtn.UseVisualStyleBackColor = True
			' 
			' PluginToolbarCountbtn
			' 
			Me.PluginToolbarCountbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.PluginToolbarCountbtn.Location = New System.Drawing.Point(111, 208)
			Me.PluginToolbarCountbtn.Name = "PluginToolbarCountbtn"
			Me.PluginToolbarCountbtn.Size = New System.Drawing.Size(124, 35)
			Me.PluginToolbarCountbtn.TabIndex = 4
			Me.PluginToolbarCountbtn.Text = "Plugin Toolbar Count"
			Me.PluginToolbarCountbtn.UseVisualStyleBackColor = True
			' 
			' RightToolbarbtn
			' 
			Me.RightToolbarbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.RightToolbarbtn.Location = New System.Drawing.Point(23, 90)
			Me.RightToolbarbtn.Name = "RightToolbarbtn"
			Me.RightToolbarbtn.Size = New System.Drawing.Size(124, 35)
			Me.RightToolbarbtn.TabIndex = 5
			Me.RightToolbarbtn.Text = "Right Toolbar"
			Me.RightToolbarbtn.UseVisualStyleBackColor = True
			' 
			' Statusbarbtn
			' 
			Me.Statusbarbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Statusbarbtn.Location = New System.Drawing.Point(201, 143)
			Me.Statusbarbtn.Name = "Statusbarbtn"
			Me.Statusbarbtn.Size = New System.Drawing.Size(124, 35)
			Me.Statusbarbtn.TabIndex = 6
			Me.Statusbarbtn.Text = "Status bar"
			Me.Statusbarbtn.UseVisualStyleBackColor = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Rsltlbl)
			Me.groupBox1.Controls.Add(Me.Statusbarbtn)
			Me.groupBox1.Controls.Add(Me.PluginToolbarCountbtn)
			Me.groupBox1.Controls.Add(Me.RightToolbarbtn)
			Me.groupBox1.Controls.Add(Me.LeftToolbarbtn)
			Me.groupBox1.Controls.Add(Me.MainFramebtn)
			Me.groupBox1.Controls.Add(Me.Menubtn)
			Me.groupBox1.Controls.Add(Me.MainToolbarbtn)
			Me.groupBox1.ForeColor = System.Drawing.Color.Red
			Me.groupBox1.Location = New System.Drawing.Point(28, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(350, 324)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Frame Handle"
			' 
			' Rsltlbl
			' 
			Me.Rsltlbl.AutoSize = True
			Me.Rsltlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Rsltlbl.ForeColor = System.Drawing.Color.DeepSkyBlue
			Me.Rsltlbl.Location = New System.Drawing.Point(139, 274)
			Me.Rsltlbl.Name = "Rsltlbl"
			Me.Rsltlbl.Size = New System.Drawing.Size(0, 16)
			Me.Rsltlbl.TabIndex = 7
			' 
			' pluginhandlbtn
			' 
			Me.pluginhandlbtn.Location = New System.Drawing.Point(229, 383)
			Me.pluginhandlbtn.Name = "pluginhandlbtn"
			Me.pluginhandlbtn.Size = New System.Drawing.Size(124, 40)
			Me.pluginhandlbtn.TabIndex = 8
			Me.pluginhandlbtn.Text = "Plug in ToolBar Handle"
			Me.pluginhandlbtn.UseVisualStyleBackColor = True
			' 
			' pluginhandlTxt
			' 
			Me.pluginhandlTxt.Location = New System.Drawing.Point(51, 394)
			Me.pluginhandlTxt.Name = "pluginhandlTxt"
			Me.pluginhandlTxt.Size = New System.Drawing.Size(154, 20)
			Me.pluginhandlTxt.TabIndex = 9
			' 
			' pluginhandllbl
			' 
			Me.pluginhandllbl.AutoSize = True
			Me.pluginhandllbl.ForeColor = System.Drawing.Color.Red
			Me.pluginhandllbl.Location = New System.Drawing.Point(237, 426)
			Me.pluginhandllbl.Name = "pluginhandllbl"
			Me.pluginhandllbl.Size = New System.Drawing.Size(0, 13)
			Me.pluginhandllbl.TabIndex = 10
			' 
			' groupBox2
			' 
			Me.groupBox2.ForeColor = System.Drawing.Color.Red
			Me.groupBox2.Location = New System.Drawing.Point(28, 359)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(350, 100)
			Me.groupBox2.TabIndex = 11
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Plug in Toolbar Handle"
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(106, 543)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(247, 21)
			Me.comboBox1.TabIndex = 12
			' 
			' comboBox2
			' 
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Location = New System.Drawing.Point(212, 585)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(35, 21)
			Me.comboBox2.TabIndex = 13
			' 
			' comboBox3
			' 
			Me.comboBox3.FormattingEnabled = True
			Me.comboBox3.Location = New System.Drawing.Point(318, 585)
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(35, 21)
			Me.comboBox3.TabIndex = 14
			' 
			' comboBox4
			' 
			Me.comboBox4.FormattingEnabled = True
			Me.comboBox4.Location = New System.Drawing.Point(106, 585)
			Me.comboBox4.Name = "comboBox4"
			Me.comboBox4.Size = New System.Drawing.Size(35, 21)
			Me.comboBox4.TabIndex = 15
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(106, 505)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(247, 20)
			Me.textBox1.TabIndex = 16
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(274, 588)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(28, 13)
			Me.label1.TabIndex = 17
			Me.label1.Text = "Blue"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(167, 588)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(27, 13)
			Me.label2.TabIndex = 18
			Me.label2.Text = "Red"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(48, 508)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(32, 13)
			Me.label3.TabIndex = 19
			Me.label3.Text = "Pane"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(48, 588)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(36, 13)
			Me.label4.TabIndex = 20
			Me.label4.Text = "Green"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(48, 546)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(37, 13)
			Me.label5.TabIndex = 21
			Me.label5.Text = "Status"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(139, 634)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(124, 35)
			Me.button1.TabIndex = 22
			Me.button1.Text = "Set Status Pane"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' groupBox3
			' 
			Me.groupBox3.ForeColor = System.Drawing.Color.Red
			Me.groupBox3.Location = New System.Drawing.Point(28, 479)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(350, 202)
			Me.groupBox3.TabIndex = 23
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Status Pane"
			' 
			' FrameDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(411, 706)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.comboBox4)
			Me.Controls.Add(Me.comboBox3)
			Me.Controls.Add(Me.comboBox2)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.pluginhandllbl)
			Me.Controls.Add(Me.pluginhandlTxt)
			Me.Controls.Add(Me.pluginhandlbtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Name = "FrameDlg"
			Me.Text = "FrameDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private LeftToolbarbtn As System.Windows.Forms.Button
		Private MainFramebtn As System.Windows.Forms.Button
		Private WithEvents MainToolbarbtn As System.Windows.Forms.Button
		Private Menubtn As System.Windows.Forms.Button
		Private PluginToolbarCountbtn As System.Windows.Forms.Button
		Private RightToolbarbtn As System.Windows.Forms.Button
		Private Statusbarbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private Rsltlbl As System.Windows.Forms.Label
		Private pluginhandlbtn As System.Windows.Forms.Button
		Private pluginhandlTxt As System.Windows.Forms.TextBox
		Private pluginhandllbl As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private comboBox3 As System.Windows.Forms.ComboBox
		Private comboBox4 As System.Windows.Forms.ComboBox
		Private textBox1 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private button1 As System.Windows.Forms.Button
		Private groupBox3 As System.Windows.Forms.GroupBox
	End Class
End Namespace