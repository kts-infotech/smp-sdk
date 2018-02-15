Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IGridDlg
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
			Me.ReadOnlyChckBox = New System.Windows.Forms.CheckBox()
			Me.FontChckBox = New System.Windows.Forms.CheckBox()
			Me.FontSizeChckBox = New System.Windows.Forms.CheckBox()
			Me.FontTypChkBox = New System.Windows.Forms.CheckBox()
			Me.CellColorChkBox = New System.Windows.Forms.CheckBox()
			Me.RowHieghtCombo = New System.Windows.Forms.ComboBox()
			Me.NoOfFColumnCombo = New System.Windows.Forms.ComboBox()
			Me.NoOfFRowCombo = New System.Windows.Forms.ComboBox()
			Me.NoOfColumnCombo = New System.Windows.Forms.ComboBox()
			Me.NoOfRowCombo = New System.Windows.Forms.ComboBox()
			Me.ColumnWidthCombo = New System.Windows.Forms.ComboBox()
			Me.ColumnCombo = New System.Windows.Forms.ComboBox()
			Me.RowCombo = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.FontCombo = New System.Windows.Forms.ComboBox()
			Me.FontSizeCombo = New System.Windows.Forms.ComboBox()
			Me.FontTypeCombo = New System.Windows.Forms.ComboBox()
			Me.CellColorCombo = New System.Windows.Forms.ComboBox()
			Me.CellTxtColorCombo = New System.Windows.Forms.ComboBox()
			Me.HGridCombo = New System.Windows.Forms.ComboBox()
			Me.VGridCombo = New System.Windows.Forms.ComboBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.CellTextTxt = New System.Windows.Forms.TextBox()
			Me.UpdateRowChckBox = New System.Windows.Forms.CheckBox()
			Me.UpdateColumnChkBox = New System.Windows.Forms.CheckBox()
			Me.UColumnCombo = New System.Windows.Forms.ComboBox()
			Me.URowCombo = New System.Windows.Forms.ComboBox()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.InserBtn = New System.Windows.Forms.Button()
			Me.DeleteBtn = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.OkBtn = New System.Windows.Forms.Button()
			Me.CancelBtn = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ReadOnlyChckBox
			' 
			Me.ReadOnlyChckBox.AutoSize = True
			Me.ReadOnlyChckBox.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ReadOnlyChckBox.Location = New System.Drawing.Point(346, 34)
			Me.ReadOnlyChckBox.Name = "ReadOnlyChckBox"
			Me.ReadOnlyChckBox.Size = New System.Drawing.Size(76, 17)
			Me.ReadOnlyChckBox.TabIndex = 0
			Me.ReadOnlyChckBox.Text = "Read Only"
			Me.ReadOnlyChckBox.UseVisualStyleBackColor = True
			' 
			' FontChckBox
			' 
			Me.FontChckBox.AutoSize = True
			Me.FontChckBox.Location = New System.Drawing.Point(50, 54)
			Me.FontChckBox.Name = "FontChckBox"
			Me.FontChckBox.Size = New System.Drawing.Size(47, 17)
			Me.FontChckBox.TabIndex = 1
			Me.FontChckBox.Text = "Font"
			Me.FontChckBox.UseVisualStyleBackColor = True
'			Me.FontChckBox.CheckedChanged += New System.EventHandler(Me.FontChckBox_CheckedChanged);
			' 
			' FontSizeChckBox
			' 
			Me.FontSizeChckBox.AutoSize = True
			Me.FontSizeChckBox.Location = New System.Drawing.Point(112, 54)
			Me.FontSizeChckBox.Name = "FontSizeChckBox"
			Me.FontSizeChckBox.Size = New System.Drawing.Size(70, 17)
			Me.FontSizeChckBox.TabIndex = 2
			Me.FontSizeChckBox.Text = "Font Size"
			Me.FontSizeChckBox.UseVisualStyleBackColor = True
'			Me.FontSizeChckBox.CheckedChanged += New System.EventHandler(Me.FontSizeChckBox_CheckedChanged);
			' 
			' FontTypChkBox
			' 
			Me.FontTypChkBox.AutoSize = True
			Me.FontTypChkBox.Location = New System.Drawing.Point(188, 54)
			Me.FontTypChkBox.Name = "FontTypChkBox"
			Me.FontTypChkBox.Size = New System.Drawing.Size(74, 17)
			Me.FontTypChkBox.TabIndex = 3
			Me.FontTypChkBox.Text = "Font Type"
			Me.FontTypChkBox.UseVisualStyleBackColor = True
'			Me.FontTypChkBox.CheckedChanged += New System.EventHandler(Me.FontTypChkBox_CheckedChanged);
			' 
			' CellColorChkBox
			' 
			Me.CellColorChkBox.AutoSize = True
			Me.CellColorChkBox.Location = New System.Drawing.Point(268, 54)
			Me.CellColorChkBox.Name = "CellColorChkBox"
			Me.CellColorChkBox.Size = New System.Drawing.Size(100, 17)
			Me.CellColorChkBox.TabIndex = 4
			Me.CellColorChkBox.Text = "Cell Text Colour"
			Me.CellColorChkBox.UseVisualStyleBackColor = True
'			Me.CellColorChkBox.CheckedChanged += New System.EventHandler(Me.CellColorChkBox_CheckedChanged);
			' 
			' RowHieghtCombo
			' 
			Me.RowHieghtCombo.FormattingEnabled = True
			Me.RowHieghtCombo.Location = New System.Drawing.Point(159, 285)
			Me.RowHieghtCombo.Name = "RowHieghtCombo"
			Me.RowHieghtCombo.Size = New System.Drawing.Size(72, 21)
			Me.RowHieghtCombo.TabIndex = 5
			' 
			' NoOfFColumnCombo
			' 
			Me.NoOfFColumnCombo.FormattingEnabled = True
			Me.NoOfFColumnCombo.Location = New System.Drawing.Point(159, 258)
			Me.NoOfFColumnCombo.Name = "NoOfFColumnCombo"
			Me.NoOfFColumnCombo.Size = New System.Drawing.Size(72, 21)
			Me.NoOfFColumnCombo.TabIndex = 6
			' 
			' NoOfFRowCombo
			' 
			Me.NoOfFRowCombo.FormattingEnabled = True
			Me.NoOfFRowCombo.Location = New System.Drawing.Point(159, 231)
			Me.NoOfFRowCombo.Name = "NoOfFRowCombo"
			Me.NoOfFRowCombo.Size = New System.Drawing.Size(72, 21)
			Me.NoOfFRowCombo.TabIndex = 7
			' 
			' NoOfColumnCombo
			' 
			Me.NoOfColumnCombo.FormattingEnabled = True
			Me.NoOfColumnCombo.Location = New System.Drawing.Point(159, 204)
			Me.NoOfColumnCombo.Name = "NoOfColumnCombo"
			Me.NoOfColumnCombo.Size = New System.Drawing.Size(72, 21)
			Me.NoOfColumnCombo.TabIndex = 8
			' 
			' NoOfRowCombo
			' 
			Me.NoOfRowCombo.FormattingEnabled = True
			Me.NoOfRowCombo.Location = New System.Drawing.Point(159, 177)
			Me.NoOfRowCombo.Name = "NoOfRowCombo"
			Me.NoOfRowCombo.Size = New System.Drawing.Size(72, 21)
			Me.NoOfRowCombo.TabIndex = 9
			' 
			' ColumnWidthCombo
			' 
			Me.ColumnWidthCombo.FormattingEnabled = True
			Me.ColumnWidthCombo.Location = New System.Drawing.Point(159, 150)
			Me.ColumnWidthCombo.Name = "ColumnWidthCombo"
			Me.ColumnWidthCombo.Size = New System.Drawing.Size(72, 21)
			Me.ColumnWidthCombo.TabIndex = 10
			' 
			' ColumnCombo
			' 
			Me.ColumnCombo.FormattingEnabled = True
			Me.ColumnCombo.Location = New System.Drawing.Point(159, 123)
			Me.ColumnCombo.Name = "ColumnCombo"
			Me.ColumnCombo.Size = New System.Drawing.Size(72, 21)
			Me.ColumnCombo.TabIndex = 11
			' 
			' RowCombo
			' 
			Me.RowCombo.FormattingEnabled = True
			Me.RowCombo.Location = New System.Drawing.Point(159, 96)
			Me.RowCombo.Name = "RowCombo"
			Me.RowCombo.Size = New System.Drawing.Size(72, 21)
			Me.RowCombo.TabIndex = 12
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(47, 96)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(29, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "Row"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(47, 123)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(42, 13)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Column"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(47, 150)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(73, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "Column Width"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(47, 177)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "No Of Rows"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(47, 204)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(78, 13)
			Me.label5.TabIndex = 17
			Me.label5.Text = "No Of Columns"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(47, 231)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(93, 13)
			Me.label6.TabIndex = 18
			Me.label6.Text = "No Of Fixed Rows"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(47, 258)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(106, 13)
			Me.label7.TabIndex = 19
			Me.label7.Text = "No Of Fixed Columns"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(47, 285)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(63, 13)
			Me.label8.TabIndex = 20
			Me.label8.Text = "Row Hieght"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(247, 291)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(87, 13)
			Me.label9.TabIndex = 36
			Me.label9.Text = "Vertical Grid Line"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(247, 264)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(99, 13)
			Me.label10.TabIndex = 35
			Me.label10.Text = "Horizontal Grid Line"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label11.Location = New System.Drawing.Point(219, 187)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(81, 13)
			Me.label11.TabIndex = 34
			Me.label11.Text = "Cell Text Colour"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label12.Location = New System.Drawing.Point(219, 215)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(48, 13)
			Me.label12.TabIndex = 33
			Me.label12.Text = "Cell Text"
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(247, 183)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(57, 13)
			Me.label13.TabIndex = 32
			Me.label13.Text = "Cell Colour"
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.Location = New System.Drawing.Point(247, 156)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(55, 13)
			Me.label14.TabIndex = 31
			Me.label14.Text = "Font Type"
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.Location = New System.Drawing.Point(247, 129)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(51, 13)
			Me.label15.TabIndex = 30
			Me.label15.Text = "Font Size"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.Location = New System.Drawing.Point(247, 102)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(28, 13)
			Me.label16.TabIndex = 29
			Me.label16.Text = "Font"
			' 
			' FontCombo
			' 
			Me.FontCombo.Enabled = False
			Me.FontCombo.FormattingEnabled = True
			Me.FontCombo.Location = New System.Drawing.Point(340, 79)
			Me.FontCombo.Name = "FontCombo"
			Me.FontCombo.Size = New System.Drawing.Size(72, 21)
			Me.FontCombo.TabIndex = 28
			' 
			' FontSizeCombo
			' 
			Me.FontSizeCombo.Enabled = False
			Me.FontSizeCombo.FormattingEnabled = True
			Me.FontSizeCombo.Location = New System.Drawing.Point(340, 106)
			Me.FontSizeCombo.Name = "FontSizeCombo"
			Me.FontSizeCombo.Size = New System.Drawing.Size(72, 21)
			Me.FontSizeCombo.TabIndex = 27
			' 
			' FontTypeCombo
			' 
			Me.FontTypeCombo.Enabled = False
			Me.FontTypeCombo.FormattingEnabled = True
			Me.FontTypeCombo.Location = New System.Drawing.Point(340, 133)
			Me.FontTypeCombo.Name = "FontTypeCombo"
			Me.FontTypeCombo.Size = New System.Drawing.Size(72, 21)
			Me.FontTypeCombo.TabIndex = 26
			' 
			' CellColorCombo
			' 
			Me.CellColorCombo.FormattingEnabled = True
			Me.CellColorCombo.Location = New System.Drawing.Point(340, 160)
			Me.CellColorCombo.Name = "CellColorCombo"
			Me.CellColorCombo.Size = New System.Drawing.Size(72, 21)
			Me.CellColorCombo.TabIndex = 25
			' 
			' CellTxtColorCombo
			' 
			Me.CellTxtColorCombo.Enabled = False
			Me.CellTxtColorCombo.FormattingEnabled = True
			Me.CellTxtColorCombo.Location = New System.Drawing.Point(340, 188)
			Me.CellTxtColorCombo.Name = "CellTxtColorCombo"
			Me.CellTxtColorCombo.Size = New System.Drawing.Size(72, 21)
			Me.CellTxtColorCombo.TabIndex = 23
			' 
			' HGridCombo
			' 
			Me.HGridCombo.FormattingEnabled = True
			Me.HGridCombo.Location = New System.Drawing.Point(340, 241)
			Me.HGridCombo.Name = "HGridCombo"
			Me.HGridCombo.Size = New System.Drawing.Size(72, 21)
			Me.HGridCombo.TabIndex = 22
			' 
			' VGridCombo
			' 
			Me.VGridCombo.FormattingEnabled = True
			Me.VGridCombo.Location = New System.Drawing.Point(340, 268)
			Me.VGridCombo.Name = "VGridCombo"
			Me.VGridCombo.Size = New System.Drawing.Size(72, 21)
			Me.VGridCombo.TabIndex = 21
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.CellTextTxt)
			Me.groupBox1.Controls.Add(Me.label12)
			Me.groupBox1.Controls.Add(Me.CellTxtColorCombo)
			Me.groupBox1.Controls.Add(Me.label11)
			Me.groupBox1.Controls.Add(Me.ReadOnlyChckBox)
			Me.groupBox1.Controls.Add(Me.FontCombo)
			Me.groupBox1.Controls.Add(Me.VGridCombo)
			Me.groupBox1.Controls.Add(Me.HGridCombo)
			Me.groupBox1.Controls.Add(Me.CellColorCombo)
			Me.groupBox1.Controls.Add(Me.FontTypeCombo)
			Me.groupBox1.Controls.Add(Me.FontSizeCombo)
			Me.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox1.Location = New System.Drawing.Point(28, 20)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(434, 315)
			Me.groupBox1.TabIndex = 37
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Cell Properties"
			' 
			' CellTextTxt
			' 
			Me.CellTextTxt.Location = New System.Drawing.Point(340, 215)
			Me.CellTextTxt.Name = "CellTextTxt"
			Me.CellTextTxt.Size = New System.Drawing.Size(82, 20)
			Me.CellTextTxt.TabIndex = 44
			' 
			' UpdateRowChckBox
			' 
			Me.UpdateRowChckBox.AutoSize = True
			Me.UpdateRowChckBox.Location = New System.Drawing.Point(50, 387)
			Me.UpdateRowChckBox.Name = "UpdateRowChckBox"
			Me.UpdateRowChckBox.Size = New System.Drawing.Size(86, 17)
			Me.UpdateRowChckBox.TabIndex = 38
			Me.UpdateRowChckBox.Text = "Update Row"
			Me.UpdateRowChckBox.UseVisualStyleBackColor = True
'			Me.UpdateRowChckBox.CheckedChanged += New System.EventHandler(Me.UpdateRowChckBox_CheckedChanged);
			' 
			' UpdateColumnChkBox
			' 
			Me.UpdateColumnChkBox.AutoSize = True
			Me.UpdateColumnChkBox.Location = New System.Drawing.Point(136, 387)
			Me.UpdateColumnChkBox.Name = "UpdateColumnChkBox"
			Me.UpdateColumnChkBox.Size = New System.Drawing.Size(99, 17)
			Me.UpdateColumnChkBox.TabIndex = 39
			Me.UpdateColumnChkBox.Text = "Update Column"
			Me.UpdateColumnChkBox.UseVisualStyleBackColor = True
'			Me.UpdateColumnChkBox.CheckedChanged += New System.EventHandler(Me.UpdateColumnChkBox_CheckedChanged);
			' 
			' UColumnCombo
			' 
			Me.UColumnCombo.Enabled = False
			Me.UColumnCombo.FormattingEnabled = True
			Me.UColumnCombo.Location = New System.Drawing.Point(220, 427)
			Me.UColumnCombo.Name = "UColumnCombo"
			Me.UColumnCombo.Size = New System.Drawing.Size(71, 21)
			Me.UColumnCombo.TabIndex = 40
			' 
			' URowCombo
			' 
			Me.URowCombo.Enabled = False
			Me.URowCombo.FormattingEnabled = True
			Me.URowCombo.Location = New System.Drawing.Point(82, 427)
			Me.URowCombo.Name = "URowCombo"
			Me.URowCombo.Size = New System.Drawing.Size(72, 21)
			Me.URowCombo.TabIndex = 41
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Location = New System.Drawing.Point(172, 430)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(42, 13)
			Me.label17.TabIndex = 42
			Me.label17.Text = "Column"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Location = New System.Drawing.Point(47, 430)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(29, 13)
			Me.label18.TabIndex = 43
			Me.label18.Text = "Row"
			' 
			' InserBtn
			' 
			Me.InserBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.InserBtn.Location = New System.Drawing.Point(318, 34)
			Me.InserBtn.Name = "InserBtn"
			Me.InserBtn.Size = New System.Drawing.Size(75, 23)
			Me.InserBtn.TabIndex = 44
			Me.InserBtn.Text = "Insert"
			Me.InserBtn.UseVisualStyleBackColor = True
'			Me.InserBtn.Click += New System.EventHandler(Me.InserBtn_Click);
			' 
			' DeleteBtn
			' 
			Me.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.DeleteBtn.Location = New System.Drawing.Point(318, 77)
			Me.DeleteBtn.Name = "DeleteBtn"
			Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
			Me.DeleteBtn.TabIndex = 45
			Me.DeleteBtn.Text = "Delete"
			Me.DeleteBtn.UseVisualStyleBackColor = True
'			Me.DeleteBtn.Click += New System.EventHandler(Me.DeleteBtn_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.DeleteBtn)
			Me.groupBox2.Controls.Add(Me.InserBtn)
			Me.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue
			Me.groupBox2.Location = New System.Drawing.Point(28, 353)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(434, 127)
			Me.groupBox2.TabIndex = 46
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Cell Properties"
			' 
			' OkBtn
			' 
			Me.OkBtn.Location = New System.Drawing.Point(287, 496)
			Me.OkBtn.Name = "OkBtn"
			Me.OkBtn.Size = New System.Drawing.Size(75, 23)
			Me.OkBtn.TabIndex = 46
			Me.OkBtn.Text = "OK"
			Me.OkBtn.UseVisualStyleBackColor = True
'			Me.OkBtn.Click += New System.EventHandler(Me.OkBtn_Click);
			' 
			' CancelBtn
			' 
			Me.CancelBtn.Location = New System.Drawing.Point(368, 496)
			Me.CancelBtn.Name = "CancelBtn"
			Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
			Me.CancelBtn.TabIndex = 47
			Me.CancelBtn.Text = "Cancel"
			Me.CancelBtn.UseVisualStyleBackColor = True
'			Me.CancelBtn.Click += New System.EventHandler(Me.CancelBtn_Click);
			' 
			' IGridDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(484, 531)
			Me.Controls.Add(Me.OkBtn)
			Me.Controls.Add(Me.CancelBtn)
			Me.Controls.Add(Me.label18)
			Me.Controls.Add(Me.label17)
			Me.Controls.Add(Me.URowCombo)
			Me.Controls.Add(Me.UColumnCombo)
			Me.Controls.Add(Me.UpdateColumnChkBox)
			Me.Controls.Add(Me.UpdateRowChckBox)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label13)
			Me.Controls.Add(Me.label14)
			Me.Controls.Add(Me.label15)
			Me.Controls.Add(Me.label16)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.RowCombo)
			Me.Controls.Add(Me.ColumnCombo)
			Me.Controls.Add(Me.ColumnWidthCombo)
			Me.Controls.Add(Me.NoOfRowCombo)
			Me.Controls.Add(Me.NoOfColumnCombo)
			Me.Controls.Add(Me.NoOfFRowCombo)
			Me.Controls.Add(Me.NoOfFColumnCombo)
			Me.Controls.Add(Me.RowHieghtCombo)
			Me.Controls.Add(Me.CellColorChkBox)
			Me.Controls.Add(Me.FontTypChkBox)
			Me.Controls.Add(Me.FontSizeChckBox)
			Me.Controls.Add(Me.FontChckBox)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Name = "IGridDlg"
			Me.Text = "IGridDlg"
'			Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.IGridDlg_FormClosed);
'			Me.Load += New System.EventHandler(Me.IGridDlg_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ReadOnlyChckBox As System.Windows.Forms.CheckBox
		Private WithEvents FontChckBox As System.Windows.Forms.CheckBox
		Private WithEvents FontSizeChckBox As System.Windows.Forms.CheckBox
		Private WithEvents FontTypChkBox As System.Windows.Forms.CheckBox
		Private WithEvents CellColorChkBox As System.Windows.Forms.CheckBox
		Private RowHieghtCombo As System.Windows.Forms.ComboBox
		Private NoOfFColumnCombo As System.Windows.Forms.ComboBox
		Private NoOfFRowCombo As System.Windows.Forms.ComboBox
		Private NoOfColumnCombo As System.Windows.Forms.ComboBox
		Private NoOfRowCombo As System.Windows.Forms.ComboBox
		Private ColumnWidthCombo As System.Windows.Forms.ComboBox
		Private ColumnCombo As System.Windows.Forms.ComboBox
		Private RowCombo As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private FontCombo As System.Windows.Forms.ComboBox
		Private FontSizeCombo As System.Windows.Forms.ComboBox
		Private FontTypeCombo As System.Windows.Forms.ComboBox
		Private CellColorCombo As System.Windows.Forms.ComboBox
		Private CellTxtColorCombo As System.Windows.Forms.ComboBox
		Private HGridCombo As System.Windows.Forms.ComboBox
		Private VGridCombo As System.Windows.Forms.ComboBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents UpdateRowChckBox As System.Windows.Forms.CheckBox
		Private WithEvents UpdateColumnChkBox As System.Windows.Forms.CheckBox
		Private UColumnCombo As System.Windows.Forms.ComboBox
		Private URowCombo As System.Windows.Forms.ComboBox
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private CellTextTxt As System.Windows.Forms.TextBox
		Private WithEvents InserBtn As System.Windows.Forms.Button
		Private WithEvents DeleteBtn As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents OkBtn As System.Windows.Forms.Button
		Private WithEvents CancelBtn As System.Windows.Forms.Button
	End Class
End Namespace