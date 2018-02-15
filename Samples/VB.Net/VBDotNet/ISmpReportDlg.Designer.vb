Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpReportDlg
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
			Me.selectitemcombo = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.FontLbl = New System.Windows.Forms.Label()
			Me.SizeLbl = New System.Windows.Forms.Label()
			Me.ColourLbl = New System.Windows.Forms.Label()
			Me.ColourTxt = New System.Windows.Forms.TextBox()
			Me.SizeTxt = New System.Windows.Forms.TextBox()
			Me.FontTxt = New System.Windows.Forms.TextBox()
			Me.Subheading2Lbl = New System.Windows.Forms.Label()
			Me.ImagePathLbl = New System.Windows.Forms.Label()
			Me.ImagePathTxt = New System.Windows.Forms.TextBox()
			Me.Subheading2Txt = New System.Windows.Forms.TextBox()
			Me.Savebtn = New System.Windows.Forms.Button()
			Me.ResetallBtn = New System.Windows.Forms.Button()
			Me.Cancelbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.Selecttablecombo = New System.Windows.Forms.ComboBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.adtabltbtn = New System.Windows.Forms.Button()
			Me.prntrptbtn = New System.Windows.Forms.Button()
			Me.Generaterptbtn = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' selectitemcombo
			' 
			Me.selectitemcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.selectitemcombo.Items.AddRange(New Object() { "", "Body Format", "Footer Format", "Footer Info", "Header Format", "Header Info"})
			Me.selectitemcombo.Location = New System.Drawing.Point(122, 33)
			Me.selectitemcombo.Name = "selectitemcombo"
			Me.selectitemcombo.Size = New System.Drawing.Size(164, 21)
			Me.selectitemcombo.TabIndex = 0
'			Me.selectitemcombo.SelectedIndexChanged += New System.EventHandler(Me.selectitemcombo_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(25, 36)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(91, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Select item to edit"
			' 
			' FontLbl
			' 
			Me.FontLbl.AutoSize = True
			Me.FontLbl.Location = New System.Drawing.Point(25, 73)
			Me.FontLbl.Name = "FontLbl"
			Me.FontLbl.Size = New System.Drawing.Size(28, 13)
			Me.FontLbl.TabIndex = 2
			Me.FontLbl.Text = "Font"
			Me.FontLbl.Visible = False
			' 
			' SizeLbl
			' 
			Me.SizeLbl.AutoSize = True
			Me.SizeLbl.Location = New System.Drawing.Point(25, 114)
			Me.SizeLbl.Name = "SizeLbl"
			Me.SizeLbl.Size = New System.Drawing.Size(27, 13)
			Me.SizeLbl.TabIndex = 3
			Me.SizeLbl.Text = "Size"
			Me.SizeLbl.Visible = False
			' 
			' ColourLbl
			' 
			Me.ColourLbl.AutoSize = True
			Me.ColourLbl.Location = New System.Drawing.Point(25, 151)
			Me.ColourLbl.Name = "ColourLbl"
			Me.ColourLbl.Size = New System.Drawing.Size(37, 13)
			Me.ColourLbl.TabIndex = 4
			Me.ColourLbl.Text = "Colour"
			Me.ColourLbl.Visible = False
			' 
			' ColourTxt
			' 
			Me.ColourTxt.Location = New System.Drawing.Point(122, 148)
			Me.ColourTxt.Name = "ColourTxt"
			Me.ColourTxt.Size = New System.Drawing.Size(164, 20)
			Me.ColourTxt.TabIndex = 5
			Me.ColourTxt.Visible = False
			' 
			' SizeTxt
			' 
			Me.SizeTxt.Location = New System.Drawing.Point(122, 111)
			Me.SizeTxt.Name = "SizeTxt"
			Me.SizeTxt.Size = New System.Drawing.Size(164, 20)
			Me.SizeTxt.TabIndex = 6
			Me.SizeTxt.Visible = False
			' 
			' FontTxt
			' 
			Me.FontTxt.Location = New System.Drawing.Point(122, 70)
			Me.FontTxt.Name = "FontTxt"
			Me.FontTxt.Size = New System.Drawing.Size(164, 20)
			Me.FontTxt.TabIndex = 7
			Me.FontTxt.Visible = False
			' 
			' Subheading2Lbl
			' 
			Me.Subheading2Lbl.AutoSize = True
			Me.Subheading2Lbl.Location = New System.Drawing.Point(25, 190)
			Me.Subheading2Lbl.Name = "Subheading2Lbl"
			Me.Subheading2Lbl.Size = New System.Drawing.Size(75, 13)
			Me.Subheading2Lbl.TabIndex = 8
			Me.Subheading2Lbl.Text = "Sub Heading2"
			Me.Subheading2Lbl.Visible = False
			' 
			' ImagePathLbl
			' 
			Me.ImagePathLbl.AutoSize = True
			Me.ImagePathLbl.Location = New System.Drawing.Point(25, 232)
			Me.ImagePathLbl.Name = "ImagePathLbl"
			Me.ImagePathLbl.Size = New System.Drawing.Size(61, 13)
			Me.ImagePathLbl.TabIndex = 9
			Me.ImagePathLbl.Text = "Image Path"
			Me.ImagePathLbl.Visible = False
			' 
			' ImagePathTxt
			' 
			Me.ImagePathTxt.Location = New System.Drawing.Point(122, 229)
			Me.ImagePathTxt.Name = "ImagePathTxt"
			Me.ImagePathTxt.Size = New System.Drawing.Size(164, 20)
			Me.ImagePathTxt.TabIndex = 10
			Me.ImagePathTxt.Visible = False
			' 
			' Subheading2Txt
			' 
			Me.Subheading2Txt.Location = New System.Drawing.Point(122, 187)
			Me.Subheading2Txt.Name = "Subheading2Txt"
			Me.Subheading2Txt.Size = New System.Drawing.Size(164, 20)
			Me.Subheading2Txt.TabIndex = 11
			Me.Subheading2Txt.Visible = False
			' 
			' Savebtn
			' 
			Me.Savebtn.Location = New System.Drawing.Point(28, 279)
			Me.Savebtn.Name = "Savebtn"
			Me.Savebtn.Size = New System.Drawing.Size(75, 23)
			Me.Savebtn.TabIndex = 12
			Me.Savebtn.Text = "Save"
			Me.Savebtn.UseVisualStyleBackColor = True
'			Me.Savebtn.Click += New System.EventHandler(Me.Savebtn_Click);
			' 
			' ResetallBtn
			' 
			Me.ResetallBtn.Location = New System.Drawing.Point(122, 279)
			Me.ResetallBtn.Name = "ResetallBtn"
			Me.ResetallBtn.Size = New System.Drawing.Size(75, 23)
			Me.ResetallBtn.TabIndex = 13
			Me.ResetallBtn.Text = "Reset All"
			Me.ResetallBtn.UseVisualStyleBackColor = True
'			Me.ResetallBtn.Click += New System.EventHandler(Me.ResetallBtn_Click);
			' 
			' Cancelbtn
			' 
			Me.Cancelbtn.Location = New System.Drawing.Point(211, 279)
			Me.Cancelbtn.Name = "Cancelbtn"
			Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
			Me.Cancelbtn.TabIndex = 14
			Me.Cancelbtn.Text = "Cancel"
			Me.Cancelbtn.UseVisualStyleBackColor = True
'			Me.Cancelbtn.Click += New System.EventHandler(Me.Cancelbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Cancelbtn)
			Me.groupBox1.Controls.Add(Me.ResetallBtn)
			Me.groupBox1.Controls.Add(Me.selectitemcombo)
			Me.groupBox1.Controls.Add(Me.Savebtn)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.Subheading2Txt)
			Me.groupBox1.Controls.Add(Me.FontLbl)
			Me.groupBox1.Controls.Add(Me.ImagePathTxt)
			Me.groupBox1.Controls.Add(Me.SizeLbl)
			Me.groupBox1.Controls.Add(Me.ImagePathLbl)
			Me.groupBox1.Controls.Add(Me.ColourLbl)
			Me.groupBox1.Controls.Add(Me.Subheading2Lbl)
			Me.groupBox1.Controls.Add(Me.ColourTxt)
			Me.groupBox1.Controls.Add(Me.FontTxt)
			Me.groupBox1.Controls.Add(Me.SizeTxt)
			Me.groupBox1.Location = New System.Drawing.Point(18, 39)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(306, 333)
			Me.groupBox1.TabIndex = 15
			Me.groupBox1.TabStop = False
			' 
			' Selecttablecombo
			' 
			Me.Selecttablecombo.FormattingEnabled = True
			Me.Selecttablecombo.Items.AddRange(New Object() { "", "SM_SALES_TB", "SM_SALES_TRANSACTION_TB", "SM_SERVICE_TB", "SM_STOCK_TB", "SM_STOCK_TRANSACTION_TB", "SM_STOCK_TYPE_TB", "SM_CUSTOMER_TB"})
			Me.Selecttablecombo.Location = New System.Drawing.Point(441, 106)
			Me.Selecttablecombo.Name = "Selecttablecombo"
			Me.Selecttablecombo.Size = New System.Drawing.Size(135, 21)
			Me.Selecttablecombo.TabIndex = 16
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(372, 109)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(63, 13)
			Me.label2.TabIndex = 17
			Me.label2.Text = "Select table"
			' 
			' adtabltbtn
			' 
			Me.adtabltbtn.Location = New System.Drawing.Point(501, 153)
			Me.adtabltbtn.Name = "adtabltbtn"
			Me.adtabltbtn.Size = New System.Drawing.Size(75, 23)
			Me.adtabltbtn.TabIndex = 18
			Me.adtabltbtn.Text = "Add table"
			Me.adtabltbtn.UseVisualStyleBackColor = True
'			Me.adtabltbtn.Click += New System.EventHandler(Me.adtabltbtn_Click);
			' 
			' prntrptbtn
			' 
			Me.prntrptbtn.Location = New System.Drawing.Point(421, 281)
			Me.prntrptbtn.Name = "prntrptbtn"
			Me.prntrptbtn.Size = New System.Drawing.Size(129, 23)
			Me.prntrptbtn.TabIndex = 19
			Me.prntrptbtn.Text = "Print Report "
			Me.prntrptbtn.UseVisualStyleBackColor = True
'			Me.prntrptbtn.Click += New System.EventHandler(Me.prntrptbtn_Click);
			' 
			' Generaterptbtn
			' 
			Me.Generaterptbtn.Location = New System.Drawing.Point(421, 229)
			Me.Generaterptbtn.Name = "Generaterptbtn"
			Me.Generaterptbtn.Size = New System.Drawing.Size(129, 23)
			Me.Generaterptbtn.TabIndex = 20
			Me.Generaterptbtn.Text = "Generate Report"
			Me.Generaterptbtn.UseVisualStyleBackColor = True
'			Me.Generaterptbtn.Click += New System.EventHandler(Me.Generaterptbtn_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.Location = New System.Drawing.Point(344, 39)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(264, 333)
			Me.groupBox2.TabIndex = 21
			Me.groupBox2.TabStop = False
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(533, 399)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 23)
			Me.Clsbtn.TabIndex = 22
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' ISmpReportDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(628, 434)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.Generaterptbtn)
			Me.Controls.Add(Me.prntrptbtn)
			Me.Controls.Add(Me.adtabltbtn)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.Selecttablecombo)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Name = "ISmpReportDlg"
			Me.Text = "ISmpReprotDlg"
'			Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.ISmpReportDlg_FormClosed);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents selectitemcombo As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private FontLbl As System.Windows.Forms.Label
		Private SizeLbl As System.Windows.Forms.Label
		Private ColourLbl As System.Windows.Forms.Label
		Private ColourTxt As System.Windows.Forms.TextBox
		Private SizeTxt As System.Windows.Forms.TextBox
		Private FontTxt As System.Windows.Forms.TextBox
		Private Subheading2Lbl As System.Windows.Forms.Label
		Private ImagePathLbl As System.Windows.Forms.Label
		Private ImagePathTxt As System.Windows.Forms.TextBox
		Private Subheading2Txt As System.Windows.Forms.TextBox
		Private WithEvents Savebtn As System.Windows.Forms.Button
		Private WithEvents ResetallBtn As System.Windows.Forms.Button
		Private WithEvents Cancelbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private Selecttablecombo As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents adtabltbtn As System.Windows.Forms.Button
		Private WithEvents prntrptbtn As System.Windows.Forms.Button
		Private WithEvents Generaterptbtn As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents Clsbtn As System.Windows.Forms.Button
	End Class
End Namespace