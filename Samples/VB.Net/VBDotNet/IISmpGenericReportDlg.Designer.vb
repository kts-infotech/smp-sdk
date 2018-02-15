Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IISmpGenericReportDlg
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
			Me.HeaderTxt = New System.Windows.Forms.TextBox()
			Me.HAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.HMRowCombo = New System.Windows.Forms.ComboBox()
			Me.HRowCombo = New System.Windows.Forms.ComboBox()
			Me.HColumnCombo = New System.Windows.Forms.ComboBox()
			Me.HMColumnCombo = New System.Windows.Forms.ComboBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.FMColumnCombo = New System.Windows.Forms.ComboBox()
			Me.FColumnCombo = New System.Windows.Forms.ComboBox()
			Me.FRowCombo = New System.Windows.Forms.ComboBox()
			Me.FMRowCombo = New System.Windows.Forms.ComboBox()
			Me.FAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.FootrTxt = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.CMRowsCombo = New System.Windows.Forms.ComboBox()
			Me.CColumnCombo = New System.Windows.Forms.ComboBox()
			Me.CAlignmentCombo = New System.Windows.Forms.ComboBox()
			Me.CMColumnCombo = New System.Windows.Forms.ComboBox()
			Me.CRowCombo = New System.Windows.Forms.ComboBox()
			Me.CntntLbl = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.ClrBtn = New System.Windows.Forms.Button()
			Me.CntntTxt = New System.Windows.Forms.TextBox()
			Me.CntnNmeTxt = New System.Windows.Forms.TextBox()
			Me.RmvBtn = New System.Windows.Forms.Button()
			Me.Adbtn = New System.Windows.Forms.Button()
			Me.label15 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.ShwBtn = New System.Windows.Forms.Button()
			Me.ClsBtn = New System.Windows.Forms.Button()
			Me.RsltList = New System.Windows.Forms.ListView()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(48, 179)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(53, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Alignment"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(48, 155)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(94, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Maximum Columns"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(48, 59)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(42, 13)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Header"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(48, 83)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(29, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Row"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(48, 131)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(81, 13)
			Me.label5.TabIndex = 4
			Me.label5.Text = "Maximum Rows"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(48, 107)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(42, 13)
			Me.label6.TabIndex = 5
			Me.label6.Text = "Column"
			' 
			' HeaderTxt
			' 
			Me.HeaderTxt.Location = New System.Drawing.Point(145, 56)
			Me.HeaderTxt.Name = "HeaderTxt"
			Me.HeaderTxt.Size = New System.Drawing.Size(171, 20)
			Me.HeaderTxt.TabIndex = 6
			' 
			' HAlignmentCombo
			' 
			Me.HAlignmentCombo.FormattingEnabled = True
			Me.HAlignmentCombo.Location = New System.Drawing.Point(145, 176)
			Me.HAlignmentCombo.Name = "HAlignmentCombo"
			Me.HAlignmentCombo.Size = New System.Drawing.Size(65, 21)
			Me.HAlignmentCombo.TabIndex = 7
			' 
			' HMRowCombo
			' 
			Me.HMRowCombo.FormattingEnabled = True
			Me.HMRowCombo.Location = New System.Drawing.Point(145, 128)
			Me.HMRowCombo.Name = "HMRowCombo"
			Me.HMRowCombo.Size = New System.Drawing.Size(65, 21)
			Me.HMRowCombo.TabIndex = 8
			' 
			' HRowCombo
			' 
			Me.HRowCombo.FormattingEnabled = True
			Me.HRowCombo.Location = New System.Drawing.Point(145, 80)
			Me.HRowCombo.Name = "HRowCombo"
			Me.HRowCombo.Size = New System.Drawing.Size(65, 21)
			Me.HRowCombo.TabIndex = 9
			' 
			' HColumnCombo
			' 
			Me.HColumnCombo.FormattingEnabled = True
			Me.HColumnCombo.Location = New System.Drawing.Point(145, 104)
			Me.HColumnCombo.Name = "HColumnCombo"
			Me.HColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.HColumnCombo.TabIndex = 10
			' 
			' HMColumnCombo
			' 
			Me.HMColumnCombo.FormattingEnabled = True
			Me.HMColumnCombo.Location = New System.Drawing.Point(145, 152)
			Me.HMColumnCombo.Name = "HMColumnCombo"
			Me.HMColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.HMColumnCombo.TabIndex = 11
			' 
			' groupBox1
			' 
			Me.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox1.Location = New System.Drawing.Point(23, 20)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(311, 212)
			Me.groupBox1.TabIndex = 12
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Header Properties"
			' 
			' FMColumnCombo
			' 
			Me.FMColumnCombo.FormattingEnabled = True
			Me.FMColumnCombo.Location = New System.Drawing.Point(472, 152)
			Me.FMColumnCombo.Name = "FMColumnCombo"
			Me.FMColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.FMColumnCombo.TabIndex = 24
			' 
			' FColumnCombo
			' 
			Me.FColumnCombo.FormattingEnabled = True
			Me.FColumnCombo.Location = New System.Drawing.Point(472, 104)
			Me.FColumnCombo.Name = "FColumnCombo"
			Me.FColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.FColumnCombo.TabIndex = 23
			' 
			' FRowCombo
			' 
			Me.FRowCombo.FormattingEnabled = True
			Me.FRowCombo.Location = New System.Drawing.Point(472, 80)
			Me.FRowCombo.Name = "FRowCombo"
			Me.FRowCombo.Size = New System.Drawing.Size(65, 21)
			Me.FRowCombo.TabIndex = 22
			' 
			' FMRowCombo
			' 
			Me.FMRowCombo.FormattingEnabled = True
			Me.FMRowCombo.Location = New System.Drawing.Point(472, 128)
			Me.FMRowCombo.Name = "FMRowCombo"
			Me.FMRowCombo.Size = New System.Drawing.Size(65, 21)
			Me.FMRowCombo.TabIndex = 21
			' 
			' FAlignmentCombo
			' 
			Me.FAlignmentCombo.FormattingEnabled = True
			Me.FAlignmentCombo.Location = New System.Drawing.Point(472, 176)
			Me.FAlignmentCombo.Name = "FAlignmentCombo"
			Me.FAlignmentCombo.Size = New System.Drawing.Size(65, 21)
			Me.FAlignmentCombo.TabIndex = 20
			' 
			' FootrTxt
			' 
			Me.FootrTxt.Location = New System.Drawing.Point(472, 56)
			Me.FootrTxt.Name = "FootrTxt"
			Me.FootrTxt.Size = New System.Drawing.Size(171, 20)
			Me.FootrTxt.TabIndex = 19
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(375, 107)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(42, 13)
			Me.label7.TabIndex = 18
			Me.label7.Text = "Column"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(375, 131)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(81, 13)
			Me.label8.TabIndex = 17
			Me.label8.Text = "Maximum Rows"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(375, 83)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(29, 13)
			Me.label9.TabIndex = 16
			Me.label9.Text = "Row"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label10.Location = New System.Drawing.Point(375, 59)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(37, 13)
			Me.label10.TabIndex = 15
			Me.label10.Text = "Footer"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(375, 155)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(94, 13)
			Me.label11.TabIndex = 14
			Me.label11.Text = "Maximum Columns"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(375, 179)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(53, 13)
			Me.label12.TabIndex = 13
			Me.label12.Text = "Alignment"
			' 
			' groupBox2
			' 
			Me.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox2.Location = New System.Drawing.Point(350, 20)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(311, 212)
			Me.groupBox2.TabIndex = 25
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Footer Properties"
			' 
			' CMRowsCombo
			' 
			Me.CMRowsCombo.FormattingEnabled = True
			Me.CMRowsCombo.Location = New System.Drawing.Point(145, 379)
			Me.CMRowsCombo.Name = "CMRowsCombo"
			Me.CMRowsCombo.Size = New System.Drawing.Size(65, 21)
			Me.CMRowsCombo.TabIndex = 26
			' 
			' CColumnCombo
			' 
			Me.CColumnCombo.FormattingEnabled = True
			Me.CColumnCombo.Location = New System.Drawing.Point(145, 353)
			Me.CColumnCombo.Name = "CColumnCombo"
			Me.CColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.CColumnCombo.TabIndex = 27
			' 
			' CAlignmentCombo
			' 
			Me.CAlignmentCombo.FormattingEnabled = True
			Me.CAlignmentCombo.Location = New System.Drawing.Point(145, 431)
			Me.CAlignmentCombo.Name = "CAlignmentCombo"
			Me.CAlignmentCombo.Size = New System.Drawing.Size(65, 21)
			Me.CAlignmentCombo.TabIndex = 28
			' 
			' CMColumnCombo
			' 
			Me.CMColumnCombo.FormattingEnabled = True
			Me.CMColumnCombo.Location = New System.Drawing.Point(122, 167)
			Me.CMColumnCombo.Name = "CMColumnCombo"
			Me.CMColumnCombo.Size = New System.Drawing.Size(65, 21)
			Me.CMColumnCombo.TabIndex = 29
			' 
			' CRowCombo
			' 
			Me.CRowCombo.FormattingEnabled = True
			Me.CRowCombo.Location = New System.Drawing.Point(145, 327)
			Me.CRowCombo.Name = "CRowCombo"
			Me.CRowCombo.Size = New System.Drawing.Size(65, 21)
			Me.CRowCombo.TabIndex = 30
			' 
			' CntntLbl
			' 
			Me.CntntLbl.AutoSize = True
			Me.CntntLbl.Location = New System.Drawing.Point(48, 304)
			Me.CntntLbl.Name = "CntntLbl"
			Me.CntntLbl.Size = New System.Drawing.Size(44, 13)
			Me.CntntLbl.TabIndex = 31
			Me.CntntLbl.Text = "Content"
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(48, 278)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(75, 13)
			Me.label14.TabIndex = 32
			Me.label14.Text = "Content Name"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.ClrBtn)
			Me.groupBox3.Controls.Add(Me.CMColumnCombo)
			Me.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox3.Location = New System.Drawing.Point(23, 238)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(638, 248)
			Me.groupBox3.TabIndex = 33
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Body Contents"
			' 
			' ClrBtn
			' 
			Me.ClrBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ClrBtn.Location = New System.Drawing.Point(201, 219)
			Me.ClrBtn.Name = "ClrBtn"
			Me.ClrBtn.Size = New System.Drawing.Size(75, 23)
			Me.ClrBtn.TabIndex = 44
			Me.ClrBtn.Text = "Clear All"
			Me.ClrBtn.UseVisualStyleBackColor = True
'			Me.ClrBtn.Click += New System.EventHandler(Me.ClrBtn_Click);
			' 
			' CntntTxt
			' 
			Me.CntntTxt.Location = New System.Drawing.Point(145, 301)
			Me.CntntTxt.Name = "CntntTxt"
			Me.CntntTxt.Size = New System.Drawing.Size(171, 20)
			Me.CntntTxt.TabIndex = 0
			' 
			' CntnNmeTxt
			' 
			Me.CntnNmeTxt.Location = New System.Drawing.Point(145, 275)
			Me.CntnNmeTxt.Name = "CntnNmeTxt"
			Me.CntnNmeTxt.Size = New System.Drawing.Size(171, 20)
			Me.CntnNmeTxt.TabIndex = 1
			' 
			' RmvBtn
			' 
			Me.RmvBtn.Location = New System.Drawing.Point(224, 429)
			Me.RmvBtn.Name = "RmvBtn"
			Me.RmvBtn.Size = New System.Drawing.Size(75, 23)
			Me.RmvBtn.TabIndex = 2
			Me.RmvBtn.Text = "Remove"
			Me.RmvBtn.UseVisualStyleBackColor = True
'			Me.RmvBtn.Click += New System.EventHandler(Me.RmvBtn_Click);
			' 
			' Adbtn
			' 
			Me.Adbtn.Location = New System.Drawing.Point(224, 403)
			Me.Adbtn.Name = "Adbtn"
			Me.Adbtn.Size = New System.Drawing.Size(75, 23)
			Me.Adbtn.TabIndex = 3
			Me.Adbtn.Text = "Add"
			Me.Adbtn.UseVisualStyleBackColor = True
'			Me.Adbtn.Click += New System.EventHandler(Me.Adbtn_Click);
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Location = New System.Drawing.Point(48, 330)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(29, 13)
			Me.label15.TabIndex = 34
			Me.label15.Text = "Row"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Location = New System.Drawing.Point(48, 356)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(42, 13)
			Me.label16.TabIndex = 35
			Me.label16.Text = "Column"
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Location = New System.Drawing.Point(48, 382)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(81, 13)
			Me.label17.TabIndex = 36
			Me.label17.Text = "Maximum Rows"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Location = New System.Drawing.Point(48, 408)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(94, 13)
			Me.label18.TabIndex = 37
			Me.label18.Text = "Maximum Columns"
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Location = New System.Drawing.Point(48, 434)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(53, 13)
			Me.label19.TabIndex = 38
			Me.label19.Text = "Alignment"
			' 
			' ShwBtn
			' 
			Me.ShwBtn.Location = New System.Drawing.Point(491, 505)
			Me.ShwBtn.Name = "ShwBtn"
			Me.ShwBtn.Size = New System.Drawing.Size(75, 23)
			Me.ShwBtn.TabIndex = 41
			Me.ShwBtn.Text = "Show"
			Me.ShwBtn.UseVisualStyleBackColor = True
'			Me.ShwBtn.Click += New System.EventHandler(Me.ShwBtn_Click);
			' 
			' ClsBtn
			' 
			Me.ClsBtn.Location = New System.Drawing.Point(586, 505)
			Me.ClsBtn.Name = "ClsBtn"
			Me.ClsBtn.Size = New System.Drawing.Size(75, 23)
			Me.ClsBtn.TabIndex = 42
			Me.ClsBtn.Text = "Close"
			Me.ClsBtn.UseVisualStyleBackColor = True
'			Me.ClsBtn.Click += New System.EventHandler(Me.ClsBtn_Click);
			' 
			' RsltList
			' 
			Me.RsltList.FullRowSelect = True
			Me.RsltList.GridLines = True
			Me.RsltList.Location = New System.Drawing.Point(350, 283)
			Me.RsltList.Margin = New System.Windows.Forms.Padding(0)
			Me.RsltList.Name = "RsltList"
			Me.RsltList.Size = New System.Drawing.Size(293, 179)
			Me.RsltList.TabIndex = 43
			Me.RsltList.UseCompatibleStateImageBehavior = False
			' 
			' IISmpGenericReportDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(684, 540)
			Me.Controls.Add(Me.RsltList)
			Me.Controls.Add(Me.ClsBtn)
			Me.Controls.Add(Me.ShwBtn)
			Me.Controls.Add(Me.RmvBtn)
			Me.Controls.Add(Me.label19)
			Me.Controls.Add(Me.label18)
			Me.Controls.Add(Me.label17)
			Me.Controls.Add(Me.label16)
			Me.Controls.Add(Me.label15)
			Me.Controls.Add(Me.CAlignmentCombo)
			Me.Controls.Add(Me.CntnNmeTxt)
			Me.Controls.Add(Me.CntntTxt)
			Me.Controls.Add(Me.Adbtn)
			Me.Controls.Add(Me.label14)
			Me.Controls.Add(Me.CntntLbl)
			Me.Controls.Add(Me.CRowCombo)
			Me.Controls.Add(Me.CColumnCombo)
			Me.Controls.Add(Me.CMRowsCombo)
			Me.Controls.Add(Me.FMColumnCombo)
			Me.Controls.Add(Me.FColumnCombo)
			Me.Controls.Add(Me.FRowCombo)
			Me.Controls.Add(Me.FMRowCombo)
			Me.Controls.Add(Me.FAlignmentCombo)
			Me.Controls.Add(Me.FootrTxt)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.HMColumnCombo)
			Me.Controls.Add(Me.HColumnCombo)
			Me.Controls.Add(Me.HRowCombo)
			Me.Controls.Add(Me.HMRowCombo)
			Me.Controls.Add(Me.HAlignmentCombo)
			Me.Controls.Add(Me.HeaderTxt)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox3)
			Me.Name = "IISmpGenericReportDlg"
			Me.Text = "IISmpGenericReportDlg"
'			Me.Load += New System.EventHandler(Me.IISmpGenericReportDlg_Load);
			Me.groupBox3.ResumeLayout(False)
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
		Private HeaderTxt As System.Windows.Forms.TextBox
		Private HAlignmentCombo As System.Windows.Forms.ComboBox
		Private HMRowCombo As System.Windows.Forms.ComboBox
		Private HRowCombo As System.Windows.Forms.ComboBox
		Private HColumnCombo As System.Windows.Forms.ComboBox
		Private HMColumnCombo As System.Windows.Forms.ComboBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private FMColumnCombo As System.Windows.Forms.ComboBox
		Private FColumnCombo As System.Windows.Forms.ComboBox
		Private FRowCombo As System.Windows.Forms.ComboBox
		Private FMRowCombo As System.Windows.Forms.ComboBox
		Private FAlignmentCombo As System.Windows.Forms.ComboBox
		Private FootrTxt As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private CMRowsCombo As System.Windows.Forms.ComboBox
		Private CColumnCombo As System.Windows.Forms.ComboBox
		Private CAlignmentCombo As System.Windows.Forms.ComboBox
		Private CMColumnCombo As System.Windows.Forms.ComboBox
		Private CRowCombo As System.Windows.Forms.ComboBox
		Private CntntLbl As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private WithEvents RmvBtn As System.Windows.Forms.Button
		Private CntntTxt As System.Windows.Forms.TextBox
		Private CntnNmeTxt As System.Windows.Forms.TextBox
		Private WithEvents Adbtn As System.Windows.Forms.Button
		Private label15 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private WithEvents ShwBtn As System.Windows.Forms.Button
		Private WithEvents ClsBtn As System.Windows.Forms.Button
		Private RsltList As System.Windows.Forms.ListView
		Private WithEvents ClrBtn As System.Windows.Forms.Button
	End Class
End Namespace