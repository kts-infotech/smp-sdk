Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpReportItemAttributesDlg
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label27 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label28 = New System.Windows.Forms.Label()
			Me.HBoldCheckBox = New System.Windows.Forms.CheckBox()
			Me.HeaderTxt = New System.Windows.Forms.TextBox()
			Me.HRowCombo = New System.Windows.Forms.ComboBox()
			Me.HMRowCombo = New System.Windows.Forms.ComboBox()
			Me.HFontSizeCombo = New System.Windows.Forms.ComboBox()
			Me.HMColCombo = New System.Windows.Forms.ComboBox()
			Me.HColCombo = New System.Windows.Forms.ComboBox()
			Me.HAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.HFontColorCombo = New System.Windows.Forms.ComboBox()
			Me.HFontCombo = New System.Windows.Forms.ComboBox()
			Me.FFontCombo = New System.Windows.Forms.ComboBox()
			Me.FFontColorCombo = New System.Windows.Forms.ComboBox()
			Me.FAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.FColCombo = New System.Windows.Forms.ComboBox()
			Me.FMColCombo = New System.Windows.Forms.ComboBox()
			Me.FFontSizeCombo = New System.Windows.Forms.ComboBox()
			Me.FMRowCombo = New System.Windows.Forms.ComboBox()
			Me.FRowCombo = New System.Windows.Forms.ComboBox()
			Me.Footertxt = New System.Windows.Forms.TextBox()
			Me.FBoldCheckBox = New System.Windows.Forms.CheckBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.label20 = New System.Windows.Forms.Label()
			Me.label21 = New System.Windows.Forms.Label()
			Me.label22 = New System.Windows.Forms.Label()
			Me.label23 = New System.Windows.Forms.Label()
			Me.label24 = New System.Windows.Forms.Label()
			Me.ContentTxt = New System.Windows.Forms.TextBox()
			Me.ContentNmeTxt = New System.Windows.Forms.TextBox()
			Me.CRowCombo = New System.Windows.Forms.ComboBox()
			Me.CColCombo = New System.Windows.Forms.ComboBox()
			Me.CMRowCombo = New System.Windows.Forms.ComboBox()
			Me.CMColCombo = New System.Windows.Forms.ComboBox()
			Me.CAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.CFontSizeCombo = New System.Windows.Forms.ComboBox()
			Me.CShowheadingCheckBox = New System.Windows.Forms.CheckBox()
			Me.CItalicsCombo = New System.Windows.Forms.CheckBox()
			Me.CBoldCheckBox = New System.Windows.Forms.CheckBox()
			Me.RmvBtn = New System.Windows.Forms.Button()
			Me.AdBtn = New System.Windows.Forms.Button()
			Me.ClrBtn = New System.Windows.Forms.Button()
			Me.RsltList = New System.Windows.Forms.ListView()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.ShwBtn = New System.Windows.Forms.Button()
			Me.ClsBtn = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label1.Location = New System.Drawing.Point(27, 33)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(42, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Header"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(52, 71)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(34, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Rows"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(52, 97)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(52, 13)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Max rows"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(52, 123)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(28, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Font"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(52, 149)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(61, 13)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Font Colour"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(52, 175)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(53, 13)
			Me.label6.TabIndex = 5
			Me.label6.Text = "Alignment"
			' 
			' label27
			' 
			Me.label27.AutoSize = True
			Me.label27.Location = New System.Drawing.Point(201, 97)
			Me.label27.Name = "label27"
			Me.label27.Size = New System.Drawing.Size(70, 13)
			Me.label27.TabIndex = 6
			Me.label27.Text = "Max Columns"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(201, 71)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(47, 13)
			Me.label8.TabIndex = 7
			Me.label8.Text = "Columns"
			' 
			' label28
			' 
			Me.label28.AutoSize = True
			Me.label28.Location = New System.Drawing.Point(201, 123)
			Me.label28.Name = "label28"
			Me.label28.Size = New System.Drawing.Size(51, 13)
			Me.label28.TabIndex = 8
			Me.label28.Text = "Font Size"
			' 
			' HBoldCheckBox
			' 
			Me.HBoldCheckBox.AutoSize = True
			Me.HBoldCheckBox.Location = New System.Drawing.Point(204, 148)
			Me.HBoldCheckBox.Name = "HBoldCheckBox"
			Me.HBoldCheckBox.Size = New System.Drawing.Size(47, 17)
			Me.HBoldCheckBox.TabIndex = 9
			Me.HBoldCheckBox.Text = "Bold"
			Me.HBoldCheckBox.UseVisualStyleBackColor = True
			' 
			' HeaderTxt
			' 
			Me.HeaderTxt.Location = New System.Drawing.Point(108, 25)
			Me.HeaderTxt.Name = "HeaderTxt"
			Me.HeaderTxt.Size = New System.Drawing.Size(199, 20)
			Me.HeaderTxt.TabIndex = 10
			' 
			' HRowCombo
			' 
			Me.HRowCombo.FormattingEnabled = True
			Me.HRowCombo.Location = New System.Drawing.Point(108, 51)
			Me.HRowCombo.Name = "HRowCombo"
			Me.HRowCombo.Size = New System.Drawing.Size(57, 21)
			Me.HRowCombo.TabIndex = 11
			' 
			' HMRowCombo
			' 
			Me.HMRowCombo.FormattingEnabled = True
			Me.HMRowCombo.Location = New System.Drawing.Point(108, 77)
			Me.HMRowCombo.Name = "HMRowCombo"
			Me.HMRowCombo.Size = New System.Drawing.Size(57, 21)
			Me.HMRowCombo.TabIndex = 12
			' 
			' HFontSizeCombo
			' 
			Me.HFontSizeCombo.FormattingEnabled = True
			Me.HFontSizeCombo.Location = New System.Drawing.Point(266, 103)
			Me.HFontSizeCombo.Name = "HFontSizeCombo"
			Me.HFontSizeCombo.Size = New System.Drawing.Size(41, 21)
			Me.HFontSizeCombo.TabIndex = 13
			' 
			' HMColCombo
			' 
			Me.HMColCombo.FormattingEnabled = True
			Me.HMColCombo.Location = New System.Drawing.Point(266, 77)
			Me.HMColCombo.Name = "HMColCombo"
			Me.HMColCombo.Size = New System.Drawing.Size(41, 21)
			Me.HMColCombo.TabIndex = 14
			' 
			' HColCombo
			' 
			Me.HColCombo.FormattingEnabled = True
			Me.HColCombo.Location = New System.Drawing.Point(266, 51)
			Me.HColCombo.Name = "HColCombo"
			Me.HColCombo.Size = New System.Drawing.Size(41, 21)
			Me.HColCombo.TabIndex = 15
			' 
			' HAlignmentCombo
			' 
			Me.HAlignmentCombo.FormattingEnabled = True
			Me.HAlignmentCombo.Location = New System.Drawing.Point(108, 155)
			Me.HAlignmentCombo.Name = "HAlignmentCombo"
			Me.HAlignmentCombo.Size = New System.Drawing.Size(57, 21)
			Me.HAlignmentCombo.TabIndex = 16
			' 
			' HFontColorCombo
			' 
			Me.HFontColorCombo.FormattingEnabled = True
			Me.HFontColorCombo.Location = New System.Drawing.Point(108, 129)
			Me.HFontColorCombo.Name = "HFontColorCombo"
			Me.HFontColorCombo.Size = New System.Drawing.Size(57, 21)
			Me.HFontColorCombo.TabIndex = 17
			' 
			' HFontCombo
			' 
			Me.HFontCombo.FormattingEnabled = True
			Me.HFontCombo.Location = New System.Drawing.Point(108, 103)
			Me.HFontCombo.Name = "HFontCombo"
			Me.HFontCombo.Size = New System.Drawing.Size(57, 21)
			Me.HFontCombo.TabIndex = 18
			' 
			' FFontCombo
			' 
			Me.FFontCombo.FormattingEnabled = True
			Me.FFontCombo.Location = New System.Drawing.Point(454, 120)
			Me.FFontCombo.Name = "FFontCombo"
			Me.FFontCombo.Size = New System.Drawing.Size(57, 21)
			Me.FFontCombo.TabIndex = 37
			' 
			' FFontColorCombo
			' 
			Me.FFontColorCombo.FormattingEnabled = True
			Me.FFontColorCombo.Location = New System.Drawing.Point(454, 146)
			Me.FFontColorCombo.Name = "FFontColorCombo"
			Me.FFontColorCombo.Size = New System.Drawing.Size(57, 21)
			Me.FFontColorCombo.TabIndex = 36
			' 
			' FAlignmentCombo
			' 
			Me.FAlignmentCombo.FormattingEnabled = True
			Me.FAlignmentCombo.Location = New System.Drawing.Point(454, 172)
			Me.FAlignmentCombo.Name = "FAlignmentCombo"
			Me.FAlignmentCombo.Size = New System.Drawing.Size(57, 21)
			Me.FAlignmentCombo.TabIndex = 35
			' 
			' FColCombo
			' 
			Me.FColCombo.FormattingEnabled = True
			Me.FColCombo.Location = New System.Drawing.Point(612, 68)
			Me.FColCombo.Name = "FColCombo"
			Me.FColCombo.Size = New System.Drawing.Size(41, 21)
			Me.FColCombo.TabIndex = 34
			' 
			' FMColCombo
			' 
			Me.FMColCombo.FormattingEnabled = True
			Me.FMColCombo.Location = New System.Drawing.Point(612, 94)
			Me.FMColCombo.Name = "FMColCombo"
			Me.FMColCombo.Size = New System.Drawing.Size(41, 21)
			Me.FMColCombo.TabIndex = 33
			' 
			' FFontSizeCombo
			' 
			Me.FFontSizeCombo.FormattingEnabled = True
			Me.FFontSizeCombo.Location = New System.Drawing.Point(612, 120)
			Me.FFontSizeCombo.Name = "FFontSizeCombo"
			Me.FFontSizeCombo.Size = New System.Drawing.Size(41, 21)
			Me.FFontSizeCombo.TabIndex = 32
			' 
			' FMRowCombo
			' 
			Me.FMRowCombo.FormattingEnabled = True
			Me.FMRowCombo.Location = New System.Drawing.Point(454, 94)
			Me.FMRowCombo.Name = "FMRowCombo"
			Me.FMRowCombo.Size = New System.Drawing.Size(57, 21)
			Me.FMRowCombo.TabIndex = 31
			' 
			' FRowCombo
			' 
			Me.FRowCombo.FormattingEnabled = True
			Me.FRowCombo.Location = New System.Drawing.Point(454, 68)
			Me.FRowCombo.Name = "FRowCombo"
			Me.FRowCombo.Size = New System.Drawing.Size(57, 21)
			Me.FRowCombo.TabIndex = 30
			' 
			' Footertxt
			' 
			Me.Footertxt.Location = New System.Drawing.Point(454, 42)
			Me.Footertxt.Name = "Footertxt"
			Me.Footertxt.Size = New System.Drawing.Size(199, 20)
			Me.Footertxt.TabIndex = 29
			' 
			' FBoldCheckBox
			' 
			Me.FBoldCheckBox.AutoSize = True
			Me.FBoldCheckBox.Location = New System.Drawing.Point(535, 148)
			Me.FBoldCheckBox.Name = "FBoldCheckBox"
			Me.FBoldCheckBox.Size = New System.Drawing.Size(47, 17)
			Me.FBoldCheckBox.TabIndex = 28
			Me.FBoldCheckBox.Text = "Bold"
			Me.FBoldCheckBox.UseVisualStyleBackColor = True
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(532, 123)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(51, 13)
			Me.label7.TabIndex = 27
			Me.label7.Text = "Font Size"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(532, 71)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(47, 13)
			Me.label9.TabIndex = 26
			Me.label9.Text = "Columns"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(532, 97)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(70, 13)
			Me.label10.TabIndex = 25
			Me.label10.Text = "Max Columns"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(383, 175)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(53, 13)
			Me.label11.TabIndex = 24
			Me.label11.Text = "Alignment"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(383, 149)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(61, 13)
			Me.label12.TabIndex = 23
			Me.label12.Text = "Font Colour"
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(383, 123)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(28, 13)
			Me.label13.TabIndex = 22
			Me.label13.Text = "Font"
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(383, 97)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(52, 13)
			Me.label14.TabIndex = 21
			Me.label14.Text = "Max rows"
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Location = New System.Drawing.Point(383, 71)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(34, 13)
			Me.label15.TabIndex = 20
			Me.label15.Text = "Rows"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Location = New System.Drawing.Point(383, 45)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(37, 13)
			Me.label16.TabIndex = 19
			Me.label16.Text = "Footer"
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.HFontSizeCombo)
			Me.groupBox1.Controls.Add(Me.HeaderTxt)
			Me.groupBox1.Controls.Add(Me.HRowCombo)
			Me.groupBox1.Controls.Add(Me.HMRowCombo)
			Me.groupBox1.Controls.Add(Me.HMColCombo)
			Me.groupBox1.Controls.Add(Me.HColCombo)
			Me.groupBox1.Controls.Add(Me.HAlignmentCombo)
			Me.groupBox1.Controls.Add(Me.HFontColorCombo)
			Me.groupBox1.Controls.Add(Me.HFontCombo)
			Me.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox1.Location = New System.Drawing.Point(26, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(323, 204)
			Me.groupBox1.TabIndex = 38
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Header Properties"
			' 
			' groupBox2
			' 
			Me.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox2.Location = New System.Drawing.Point(364, 12)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(309, 204)
			Me.groupBox2.TabIndex = 39
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Footer Properties"
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Location = New System.Drawing.Point(52, 460)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(51, 13)
			Me.label17.TabIndex = 40
			Me.label17.Text = "Font Size"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Location = New System.Drawing.Point(52, 433)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(53, 13)
			Me.label18.TabIndex = 41
			Me.label18.Text = "Alignment"
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Location = New System.Drawing.Point(52, 406)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(70, 13)
			Me.label19.TabIndex = 42
			Me.label19.Text = "Max Columns"
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Location = New System.Drawing.Point(52, 379)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(57, 13)
			Me.label20.TabIndex = 43
			Me.label20.Text = "Max Rows"
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Location = New System.Drawing.Point(52, 352)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(42, 13)
			Me.label21.TabIndex = 44
			Me.label21.Text = "Column"
			' 
			' label22
			' 
			Me.label22.AutoSize = True
			Me.label22.Location = New System.Drawing.Point(52, 325)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(29, 13)
			Me.label22.TabIndex = 45
			Me.label22.Text = "Row"
			' 
			' label23
			' 
			Me.label23.AutoSize = True
			Me.label23.Location = New System.Drawing.Point(52, 298)
			Me.label23.Name = "label23"
			Me.label23.Size = New System.Drawing.Size(75, 13)
			Me.label23.TabIndex = 46
			Me.label23.Text = "Content Name"
			' 
			' label24
			' 
			Me.label24.AutoSize = True
			Me.label24.Location = New System.Drawing.Point(52, 271)
			Me.label24.Name = "label24"
			Me.label24.Size = New System.Drawing.Size(44, 13)
			Me.label24.TabIndex = 47
			Me.label24.Text = "Content"
			' 
			' ContentTxt
			' 
			Me.ContentTxt.Location = New System.Drawing.Point(134, 268)
			Me.ContentTxt.Name = "ContentTxt"
			Me.ContentTxt.Size = New System.Drawing.Size(199, 20)
			Me.ContentTxt.TabIndex = 48
			' 
			' ContentNmeTxt
			' 
			Me.ContentNmeTxt.Location = New System.Drawing.Point(134, 295)
			Me.ContentNmeTxt.Name = "ContentNmeTxt"
			Me.ContentNmeTxt.Size = New System.Drawing.Size(199, 20)
			Me.ContentNmeTxt.TabIndex = 49
			' 
			' CRowCombo
			' 
			Me.CRowCombo.FormattingEnabled = True
			Me.CRowCombo.Location = New System.Drawing.Point(134, 322)
			Me.CRowCombo.Name = "CRowCombo"
			Me.CRowCombo.Size = New System.Drawing.Size(92, 21)
			Me.CRowCombo.TabIndex = 50
			' 
			' CColCombo
			' 
			Me.CColCombo.FormattingEnabled = True
			Me.CColCombo.Location = New System.Drawing.Point(134, 349)
			Me.CColCombo.Name = "CColCombo"
			Me.CColCombo.Size = New System.Drawing.Size(92, 21)
			Me.CColCombo.TabIndex = 51
			' 
			' CMRowCombo
			' 
			Me.CMRowCombo.FormattingEnabled = True
			Me.CMRowCombo.Location = New System.Drawing.Point(134, 376)
			Me.CMRowCombo.Name = "CMRowCombo"
			Me.CMRowCombo.Size = New System.Drawing.Size(92, 21)
			Me.CMRowCombo.TabIndex = 52
			' 
			' CMColCombo
			' 
			Me.CMColCombo.FormattingEnabled = True
			Me.CMColCombo.Location = New System.Drawing.Point(134, 403)
			Me.CMColCombo.Name = "CMColCombo"
			Me.CMColCombo.Size = New System.Drawing.Size(92, 21)
			Me.CMColCombo.TabIndex = 53
			' 
			' CAlignmentCombo
			' 
			Me.CAlignmentCombo.FormattingEnabled = True
			Me.CAlignmentCombo.Location = New System.Drawing.Point(134, 430)
			Me.CAlignmentCombo.Name = "CAlignmentCombo"
			Me.CAlignmentCombo.Size = New System.Drawing.Size(92, 21)
			Me.CAlignmentCombo.TabIndex = 54
			' 
			' CFontSizeCombo
			' 
			Me.CFontSizeCombo.FormattingEnabled = True
			Me.CFontSizeCombo.Location = New System.Drawing.Point(134, 457)
			Me.CFontSizeCombo.Name = "CFontSizeCombo"
			Me.CFontSizeCombo.Size = New System.Drawing.Size(92, 21)
			Me.CFontSizeCombo.TabIndex = 55
			' 
			' CShowheadingCheckBox
			' 
			Me.CShowheadingCheckBox.AutoSize = True
			Me.CShowheadingCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
			Me.CShowheadingCheckBox.Location = New System.Drawing.Point(206, 142)
			Me.CShowheadingCheckBox.Name = "CShowheadingCheckBox"
			Me.CShowheadingCheckBox.Size = New System.Drawing.Size(94, 17)
			Me.CShowheadingCheckBox.TabIndex = 56
			Me.CShowheadingCheckBox.Text = "Show heading"
			Me.CShowheadingCheckBox.UseVisualStyleBackColor = True
			' 
			' CItalicsCombo
			' 
			Me.CItalicsCombo.AutoSize = True
			Me.CItalicsCombo.ForeColor = System.Drawing.SystemColors.ControlText
			Me.CItalicsCombo.Location = New System.Drawing.Point(206, 115)
			Me.CItalicsCombo.Name = "CItalicsCombo"
			Me.CItalicsCombo.Size = New System.Drawing.Size(53, 17)
			Me.CItalicsCombo.TabIndex = 57
			Me.CItalicsCombo.Text = "Italics"
			Me.CItalicsCombo.UseVisualStyleBackColor = True
			' 
			' CBoldCheckBox
			' 
			Me.CBoldCheckBox.AutoSize = True
			Me.CBoldCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
			Me.CBoldCheckBox.Location = New System.Drawing.Point(206, 88)
			Me.CBoldCheckBox.Name = "CBoldCheckBox"
			Me.CBoldCheckBox.Size = New System.Drawing.Size(47, 17)
			Me.CBoldCheckBox.TabIndex = 58
			Me.CBoldCheckBox.Text = "Bold"
			Me.CBoldCheckBox.UseVisualStyleBackColor = True
			' 
			' RmvBtn
			' 
			Me.RmvBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.RmvBtn.Location = New System.Drawing.Point(266, 195)
			Me.RmvBtn.Name = "RmvBtn"
			Me.RmvBtn.Size = New System.Drawing.Size(65, 23)
			Me.RmvBtn.TabIndex = 59
			Me.RmvBtn.Text = "Remove"
			Me.RmvBtn.UseVisualStyleBackColor = True
'			Me.RmvBtn.Click += New System.EventHandler(Me.RmvBtn_Click);
			' 
			' AdBtn
			' 
			Me.AdBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.AdBtn.Location = New System.Drawing.Point(203, 195)
			Me.AdBtn.Name = "AdBtn"
			Me.AdBtn.Size = New System.Drawing.Size(57, 23)
			Me.AdBtn.TabIndex = 60
			Me.AdBtn.Text = "Add"
			Me.AdBtn.UseVisualStyleBackColor = True
'			Me.AdBtn.Click += New System.EventHandler(Me.AdBtn_Click);
			' 
			' ClrBtn
			' 
			Me.ClrBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ClrBtn.Location = New System.Drawing.Point(203, 227)
			Me.ClrBtn.Name = "ClrBtn"
			Me.ClrBtn.Size = New System.Drawing.Size(120, 23)
			Me.ClrBtn.TabIndex = 61
			Me.ClrBtn.Text = "Clear all"
			Me.ClrBtn.UseVisualStyleBackColor = True
'			Me.ClrBtn.Click += New System.EventHandler(Me.ClrBtn_Click);
			' 
			' RsltList
			' 
			Me.RsltList.FullRowSelect = True
			Me.RsltList.GridLines = True
			Me.RsltList.Location = New System.Drawing.Point(364, 268)
			Me.RsltList.Name = "RsltList"
			Me.RsltList.Size = New System.Drawing.Size(289, 183)
			Me.RsltList.TabIndex = 62
			Me.RsltList.UseCompatibleStateImageBehavior = False
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.ShwBtn)
			Me.groupBox3.Controls.Add(Me.AdBtn)
			Me.groupBox3.Controls.Add(Me.CBoldCheckBox)
			Me.groupBox3.Controls.Add(Me.ClrBtn)
			Me.groupBox3.Controls.Add(Me.CItalicsCombo)
			Me.groupBox3.Controls.Add(Me.RmvBtn)
			Me.groupBox3.Controls.Add(Me.CShowheadingCheckBox)
			Me.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox3.Location = New System.Drawing.Point(26, 238)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(647, 264)
			Me.groupBox3.TabIndex = 63
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Body Contents"
			' 
			' ShwBtn
			' 
			Me.ShwBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ShwBtn.Location = New System.Drawing.Point(552, 222)
			Me.ShwBtn.Name = "ShwBtn"
			Me.ShwBtn.Size = New System.Drawing.Size(75, 29)
			Me.ShwBtn.TabIndex = 65
			Me.ShwBtn.Text = "Show"
			Me.ShwBtn.UseVisualStyleBackColor = True
'			Me.ShwBtn.Click += New System.EventHandler(Me.ShwBtn_Click);
			' 
			' ClsBtn
			' 
			Me.ClsBtn.Location = New System.Drawing.Point(555, 508)
			Me.ClsBtn.Name = "ClsBtn"
			Me.ClsBtn.Size = New System.Drawing.Size(75, 30)
			Me.ClsBtn.TabIndex = 64
			Me.ClsBtn.Text = "Close"
			Me.ClsBtn.UseVisualStyleBackColor = True
'			Me.ClsBtn.Click += New System.EventHandler(Me.ClsBtn_Click);
			' 
			' ISmpReportItemAttributesDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(702, 550)
			Me.Controls.Add(Me.ClsBtn)
			Me.Controls.Add(Me.RsltList)
			Me.Controls.Add(Me.CFontSizeCombo)
			Me.Controls.Add(Me.CAlignmentCombo)
			Me.Controls.Add(Me.CMColCombo)
			Me.Controls.Add(Me.CMRowCombo)
			Me.Controls.Add(Me.CColCombo)
			Me.Controls.Add(Me.CRowCombo)
			Me.Controls.Add(Me.ContentNmeTxt)
			Me.Controls.Add(Me.ContentTxt)
			Me.Controls.Add(Me.label24)
			Me.Controls.Add(Me.label23)
			Me.Controls.Add(Me.label22)
			Me.Controls.Add(Me.label21)
			Me.Controls.Add(Me.label20)
			Me.Controls.Add(Me.label19)
			Me.Controls.Add(Me.label18)
			Me.Controls.Add(Me.label17)
			Me.Controls.Add(Me.FFontCombo)
			Me.Controls.Add(Me.FFontColorCombo)
			Me.Controls.Add(Me.FAlignmentCombo)
			Me.Controls.Add(Me.FColCombo)
			Me.Controls.Add(Me.FMColCombo)
			Me.Controls.Add(Me.FFontSizeCombo)
			Me.Controls.Add(Me.FMRowCombo)
			Me.Controls.Add(Me.FRowCombo)
			Me.Controls.Add(Me.Footertxt)
			Me.Controls.Add(Me.FBoldCheckBox)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.label13)
			Me.Controls.Add(Me.label14)
			Me.Controls.Add(Me.label15)
			Me.Controls.Add(Me.label16)
			Me.Controls.Add(Me.HBoldCheckBox)
			Me.Controls.Add(Me.label28)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label27)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Name = "ISmpReportItemAttributesDlg"
			Me.Text = "ISmpReportItemAttributes"
'			Me.Load += New System.EventHandler(Me.ISmpReportItemAttributesDlg_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label27 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label28 As System.Windows.Forms.Label
		Private HBoldCheckBox As System.Windows.Forms.CheckBox
		Private HeaderTxt As System.Windows.Forms.TextBox
		Private HRowCombo As System.Windows.Forms.ComboBox
		Private HMRowCombo As System.Windows.Forms.ComboBox
		Private HFontSizeCombo As System.Windows.Forms.ComboBox
		Private HMColCombo As System.Windows.Forms.ComboBox
		Private HColCombo As System.Windows.Forms.ComboBox
		Private HAlignmentCombo As System.Windows.Forms.ComboBox
		Private HFontColorCombo As System.Windows.Forms.ComboBox
		Private HFontCombo As System.Windows.Forms.ComboBox
		Private FFontCombo As System.Windows.Forms.ComboBox
		Private FFontColorCombo As System.Windows.Forms.ComboBox
		Private FAlignmentCombo As System.Windows.Forms.ComboBox
		Private FColCombo As System.Windows.Forms.ComboBox
		Private FMColCombo As System.Windows.Forms.ComboBox
		Private FFontSizeCombo As System.Windows.Forms.ComboBox
		Private FMRowCombo As System.Windows.Forms.ComboBox
		Private FRowCombo As System.Windows.Forms.ComboBox
		Private Footertxt As System.Windows.Forms.TextBox
		Private FBoldCheckBox As System.Windows.Forms.CheckBox
		Private label7 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private label21 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label23 As System.Windows.Forms.Label
		Private label24 As System.Windows.Forms.Label
		Private ContentTxt As System.Windows.Forms.TextBox
		Private ContentNmeTxt As System.Windows.Forms.TextBox
		Private CRowCombo As System.Windows.Forms.ComboBox
		Private CColCombo As System.Windows.Forms.ComboBox
		Private CMRowCombo As System.Windows.Forms.ComboBox
		Private CMColCombo As System.Windows.Forms.ComboBox
		Private CAlignmentCombo As System.Windows.Forms.ComboBox
		Private CFontSizeCombo As System.Windows.Forms.ComboBox
		Private CShowheadingCheckBox As System.Windows.Forms.CheckBox
		Private CItalicsCombo As System.Windows.Forms.CheckBox
		Private CBoldCheckBox As System.Windows.Forms.CheckBox
		Private WithEvents RmvBtn As System.Windows.Forms.Button
		Private WithEvents AdBtn As System.Windows.Forms.Button
		Private WithEvents ClrBtn As System.Windows.Forms.Button
		Private RsltList As System.Windows.Forms.ListView
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private WithEvents ShwBtn As System.Windows.Forms.Button
		Private WithEvents ClsBtn As System.Windows.Forms.Button
	End Class
End Namespace