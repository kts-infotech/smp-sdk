Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IReportsDlg
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
			Me.NormalBtn = New System.Windows.Forms.RadioButton()
			Me.Aditinalinfobtn = New System.Windows.Forms.RadioButton()
			Me.Withcaptionbtn = New System.Windows.Forms.RadioButton()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.Tablecombo = New System.Windows.Forms.ComboBox()
			Me.AdTableBtn = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.AddHeadingTxt = New System.Windows.Forms.TextBox()
			Me.HeadingTxt = New System.Windows.Forms.TextBox()
			Me.CaptionTxt = New System.Windows.Forms.TextBox()
			Me.Reportbtn = New System.Windows.Forms.Button()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' NormalBtn
			' 
			Me.NormalBtn.AutoSize = True
			Me.NormalBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.NormalBtn.Location = New System.Drawing.Point(23, 28)
			Me.NormalBtn.Name = "NormalBtn"
			Me.NormalBtn.Size = New System.Drawing.Size(58, 17)
			Me.NormalBtn.TabIndex = 0
			Me.NormalBtn.TabStop = True
			Me.NormalBtn.Text = "Normal"
			Me.NormalBtn.UseVisualStyleBackColor = True
'			Me.NormalBtn.CheckedChanged += New System.EventHandler(Me.NormalBtn_CheckedChanged);
			' 
			' Aditinalinfobtn
			' 
			Me.Aditinalinfobtn.AutoSize = True
			Me.Aditinalinfobtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Aditinalinfobtn.Location = New System.Drawing.Point(23, 54)
			Me.Aditinalinfobtn.Name = "Aditinalinfobtn"
			Me.Aditinalinfobtn.Size = New System.Drawing.Size(151, 17)
			Me.Aditinalinfobtn.TabIndex = 1
			Me.Aditinalinfobtn.TabStop = True
			Me.Aditinalinfobtn.Text = "With Additional Information"
			Me.Aditinalinfobtn.UseVisualStyleBackColor = True
'			Me.Aditinalinfobtn.CheckedChanged += New System.EventHandler(Me.Aditinalinfobtn_CheckedChanged);
			' 
			' Withcaptionbtn
			' 
			Me.Withcaptionbtn.AutoSize = True
			Me.Withcaptionbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Withcaptionbtn.Location = New System.Drawing.Point(23, 77)
			Me.Withcaptionbtn.Name = "Withcaptionbtn"
			Me.Withcaptionbtn.Size = New System.Drawing.Size(86, 17)
			Me.Withcaptionbtn.TabIndex = 2
			Me.Withcaptionbtn.TabStop = True
			Me.Withcaptionbtn.Text = "With Caption"
			Me.Withcaptionbtn.UseVisualStyleBackColor = True
'			Me.Withcaptionbtn.CheckedChanged += New System.EventHandler(Me.Withcaptionbtn_CheckedChanged);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Withcaptionbtn)
			Me.groupBox1.Controls.Add(Me.Aditinalinfobtn)
			Me.groupBox1.Controls.Add(Me.NormalBtn)
			Me.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox1.Location = New System.Drawing.Point(12, 19)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(179, 109)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Select report Options"
			' 
			' Tablecombo
			' 
			Me.Tablecombo.FormattingEnabled = True
			Me.Tablecombo.Location = New System.Drawing.Point(35, 158)
			Me.Tablecombo.Name = "Tablecombo"
			Me.Tablecombo.Size = New System.Drawing.Size(130, 21)
			Me.Tablecombo.TabIndex = 4
			' 
			' AdTableBtn
			' 
			Me.AdTableBtn.Location = New System.Drawing.Point(90, 202)
			Me.AdTableBtn.Name = "AdTableBtn"
			Me.AdTableBtn.Size = New System.Drawing.Size(75, 23)
			Me.AdTableBtn.TabIndex = 5
			Me.AdTableBtn.Text = "Add Table"
			Me.AdTableBtn.UseVisualStyleBackColor = True
'			Me.AdTableBtn.Click += New System.EventHandler(Me.AdTableBtn_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox2.Location = New System.Drawing.Point(12, 134)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(179, 109)
			Me.groupBox2.TabIndex = 6
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Select Table"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(229, 124)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(124, 13)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Enter Additional Heading"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(229, 86)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(75, 13)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Enter Heading"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(229, 50)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(71, 13)
			Me.label3.TabIndex = 9
			Me.label3.Text = "Enter Caption"
			' 
			' AddHeadingTxt
			' 
			Me.AddHeadingTxt.Enabled = False
			Me.AddHeadingTxt.Location = New System.Drawing.Point(359, 121)
			Me.AddHeadingTxt.Name = "AddHeadingTxt"
			Me.AddHeadingTxt.Size = New System.Drawing.Size(100, 20)
			Me.AddHeadingTxt.TabIndex = 10
			' 
			' HeadingTxt
			' 
			Me.HeadingTxt.Enabled = False
			Me.HeadingTxt.Location = New System.Drawing.Point(359, 83)
			Me.HeadingTxt.Name = "HeadingTxt"
			Me.HeadingTxt.Size = New System.Drawing.Size(100, 20)
			Me.HeadingTxt.TabIndex = 11
			' 
			' CaptionTxt
			' 
			Me.CaptionTxt.Enabled = False
			Me.CaptionTxt.Location = New System.Drawing.Point(359, 47)
			Me.CaptionTxt.Name = "CaptionTxt"
			Me.CaptionTxt.Size = New System.Drawing.Size(100, 20)
			Me.CaptionTxt.TabIndex = 12
			' 
			' Reportbtn
			' 
			Me.Reportbtn.Location = New System.Drawing.Point(359, 188)
			Me.Reportbtn.Name = "Reportbtn"
			Me.Reportbtn.Size = New System.Drawing.Size(100, 26)
			Me.Reportbtn.TabIndex = 13
			Me.Reportbtn.Text = "Generate Report"
			Me.Reportbtn.UseVisualStyleBackColor = True
'			Me.Reportbtn.Click += New System.EventHandler(Me.Reportbtn_Click);
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(414, 259)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 23)
			Me.Clsbtn.TabIndex = 14
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' groupBox3
			' 
			Me.groupBox3.Location = New System.Drawing.Point(215, 19)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(274, 224)
			Me.groupBox3.TabIndex = 15
			Me.groupBox3.TabStop = False
			' 
			' IReportsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(501, 294)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.Reportbtn)
			Me.Controls.Add(Me.CaptionTxt)
			Me.Controls.Add(Me.HeadingTxt)
			Me.Controls.Add(Me.AddHeadingTxt)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.AdTableBtn)
			Me.Controls.Add(Me.Tablecombo)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Name = "IReportsDlg"
			Me.Text = "IReportsDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents NormalBtn As System.Windows.Forms.RadioButton
		Private WithEvents Aditinalinfobtn As System.Windows.Forms.RadioButton
		Private WithEvents Withcaptionbtn As System.Windows.Forms.RadioButton
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private Tablecombo As System.Windows.Forms.ComboBox
		Private WithEvents AdTableBtn As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private AddHeadingTxt As System.Windows.Forms.TextBox
		Private HeadingTxt As System.Windows.Forms.TextBox
		Private CaptionTxt As System.Windows.Forms.TextBox
		Private WithEvents Reportbtn As System.Windows.Forms.Button
		Private WithEvents Clsbtn As System.Windows.Forms.Button
		Private groupBox3 As System.Windows.Forms.GroupBox
	End Class
End Namespace