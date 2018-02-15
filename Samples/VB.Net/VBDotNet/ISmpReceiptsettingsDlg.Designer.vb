Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ReceiptsettingsDlg
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
			Me.BypassPrintDlgbtn = New System.Windows.Forms.Button()
			Me.EnableDefaultReceiptPrinterbtn = New System.Windows.Forms.Button()
			Me.FooterTextbtn = New System.Windows.Forms.Button()
			Me.PrintFooterTextbtn = New System.Windows.Forms.Button()
			Me.PrintShopNameAtHeaderbtn = New System.Windows.Forms.Button()
			Me.PrintTimeAtFooterbtn = New System.Windows.Forms.Button()
			Me.ReceiptPrinterNamebtn = New System.Windows.Forms.Button()
			Me.ReceiptSpacingbtn = New System.Windows.Forms.Button()
			Me.enblelabel = New System.Windows.Forms.Label()
			Me.bypassprntlbl = New System.Windows.Forms.Label()
			Me.enbldfltreceptprntrlbl = New System.Windows.Forms.Label()
			Me.footrtxtlbl = New System.Windows.Forms.Label()
			Me.prntfootrtextlbl = New System.Windows.Forms.Label()
			Me.receptpntrnmelbl = New System.Windows.Forms.Label()
			Me.ReceptSpacnglbl = New System.Windows.Forms.Label()
			Me.PrntTmeAtFootrlbl = New System.Windows.Forms.Label()
			Me.PrntshpNmeAtHederlbl = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' BypassPrintDlgbtn
			' 
			Me.BypassPrintDlgbtn.Location = New System.Drawing.Point(19, 21)
			Me.BypassPrintDlgbtn.Name = "BypassPrintDlgbtn"
			Me.BypassPrintDlgbtn.Size = New System.Drawing.Size(160, 31)
			Me.BypassPrintDlgbtn.TabIndex = 0
			Me.BypassPrintDlgbtn.Text = "Bypass Print"
			Me.BypassPrintDlgbtn.UseVisualStyleBackColor = True
'			Me.BypassPrintDlgbtn.Click += New System.EventHandler(Me.BypassPrintDlgbtn_Click);
			' 
			' EnableDefaultReceiptPrinterbtn
			' 
			Me.EnableDefaultReceiptPrinterbtn.Location = New System.Drawing.Point(19, 72)
			Me.EnableDefaultReceiptPrinterbtn.Name = "EnableDefaultReceiptPrinterbtn"
			Me.EnableDefaultReceiptPrinterbtn.Size = New System.Drawing.Size(160, 31)
			Me.EnableDefaultReceiptPrinterbtn.TabIndex = 1
			Me.EnableDefaultReceiptPrinterbtn.Text = "Default Receipt Printer"
			Me.EnableDefaultReceiptPrinterbtn.UseVisualStyleBackColor = True
'			Me.EnableDefaultReceiptPrinterbtn.Click += New System.EventHandler(Me.EnableDefaultReceiptPrinterbtn_Click);
			' 
			' FooterTextbtn
			' 
			Me.FooterTextbtn.Location = New System.Drawing.Point(19, 118)
			Me.FooterTextbtn.Name = "FooterTextbtn"
			Me.FooterTextbtn.Size = New System.Drawing.Size(160, 31)
			Me.FooterTextbtn.TabIndex = 2
			Me.FooterTextbtn.Text = "Footer Text"
			Me.FooterTextbtn.UseVisualStyleBackColor = True
'			Me.FooterTextbtn.Click += New System.EventHandler(Me.FooterTextbtn_Click);
			' 
			' PrintFooterTextbtn
			' 
			Me.PrintFooterTextbtn.Location = New System.Drawing.Point(19, 170)
			Me.PrintFooterTextbtn.Name = "PrintFooterTextbtn"
			Me.PrintFooterTextbtn.Size = New System.Drawing.Size(160, 31)
			Me.PrintFooterTextbtn.TabIndex = 3
			Me.PrintFooterTextbtn.Text = "Print Footer Text"
			Me.PrintFooterTextbtn.UseVisualStyleBackColor = True
'			Me.PrintFooterTextbtn.Click += New System.EventHandler(Me.PrintFooterTextbtn_Click);
			' 
			' PrintShopNameAtHeaderbtn
			' 
			Me.PrintShopNameAtHeaderbtn.Location = New System.Drawing.Point(19, 392)
			Me.PrintShopNameAtHeaderbtn.Name = "PrintShopNameAtHeaderbtn"
			Me.PrintShopNameAtHeaderbtn.Size = New System.Drawing.Size(160, 31)
			Me.PrintShopNameAtHeaderbtn.TabIndex = 4
			Me.PrintShopNameAtHeaderbtn.Text = "Print Shop Name At Header"
			Me.PrintShopNameAtHeaderbtn.UseVisualStyleBackColor = True
'			Me.PrintShopNameAtHeaderbtn.Click += New System.EventHandler(Me.PrintShopNameAtHeaderbtn_Click);
			' 
			' PrintTimeAtFooterbtn
			' 
			Me.PrintTimeAtFooterbtn.Location = New System.Drawing.Point(19, 338)
			Me.PrintTimeAtFooterbtn.Name = "PrintTimeAtFooterbtn"
			Me.PrintTimeAtFooterbtn.Size = New System.Drawing.Size(160, 31)
			Me.PrintTimeAtFooterbtn.TabIndex = 5
			Me.PrintTimeAtFooterbtn.Text = "Print Time At Footer "
			Me.PrintTimeAtFooterbtn.UseVisualStyleBackColor = True
'			Me.PrintTimeAtFooterbtn.Click += New System.EventHandler(Me.PrintTimeAtFooterbtn_Click);
			' 
			' ReceiptPrinterNamebtn
			' 
			Me.ReceiptPrinterNamebtn.Location = New System.Drawing.Point(19, 227)
			Me.ReceiptPrinterNamebtn.Name = "ReceiptPrinterNamebtn"
			Me.ReceiptPrinterNamebtn.Size = New System.Drawing.Size(160, 31)
			Me.ReceiptPrinterNamebtn.TabIndex = 6
			Me.ReceiptPrinterNamebtn.Text = "Receipt Printer Name"
			Me.ReceiptPrinterNamebtn.UseVisualStyleBackColor = True
'			Me.ReceiptPrinterNamebtn.Click += New System.EventHandler(Me.ReceiptPrinterNamebtn_Click);
			' 
			' ReceiptSpacingbtn
			' 
			Me.ReceiptSpacingbtn.Location = New System.Drawing.Point(19, 279)
			Me.ReceiptSpacingbtn.Name = "ReceiptSpacingbtn"
			Me.ReceiptSpacingbtn.Size = New System.Drawing.Size(160, 31)
			Me.ReceiptSpacingbtn.TabIndex = 7
			Me.ReceiptSpacingbtn.Text = "Receipt Spacing"
			Me.ReceiptSpacingbtn.UseVisualStyleBackColor = True
'			Me.ReceiptSpacingbtn.Click += New System.EventHandler(Me.ReceiptSpacingbtn_Click);
			' 
			' enblelabel
			' 
			Me.enblelabel.AutoSize = True
			Me.enblelabel.Location = New System.Drawing.Point(426, 56)
			Me.enblelabel.Name = "enblelabel"
			Me.enblelabel.Size = New System.Drawing.Size(0, 13)
			Me.enblelabel.TabIndex = 8
			' 
			' bypassprntlbl
			' 
			Me.bypassprntlbl.AutoSize = True
			Me.bypassprntlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bypassprntlbl.ForeColor = System.Drawing.Color.Red
			Me.bypassprntlbl.Location = New System.Drawing.Point(207, 35)
			Me.bypassprntlbl.Name = "bypassprntlbl"
			Me.bypassprntlbl.Size = New System.Drawing.Size(0, 19)
			Me.bypassprntlbl.TabIndex = 11
			' 
			' enbldfltreceptprntrlbl
			' 
			Me.enbldfltreceptprntrlbl.AutoSize = True
			Me.enbldfltreceptprntrlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.enbldfltreceptprntrlbl.ForeColor = System.Drawing.Color.Red
			Me.enbldfltreceptprntrlbl.Location = New System.Drawing.Point(207, 81)
			Me.enbldfltreceptprntrlbl.Name = "enbldfltreceptprntrlbl"
			Me.enbldfltreceptprntrlbl.Size = New System.Drawing.Size(0, 19)
			Me.enbldfltreceptprntrlbl.TabIndex = 12
			' 
			' footrtxtlbl
			' 
			Me.footrtxtlbl.AutoSize = True
			Me.footrtxtlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.footrtxtlbl.ForeColor = System.Drawing.Color.Red
			Me.footrtxtlbl.Location = New System.Drawing.Point(208, 127)
			Me.footrtxtlbl.Name = "footrtxtlbl"
			Me.footrtxtlbl.Size = New System.Drawing.Size(0, 19)
			Me.footrtxtlbl.TabIndex = 13
			' 
			' prntfootrtextlbl
			' 
			Me.prntfootrtextlbl.AutoSize = True
			Me.prntfootrtextlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.prntfootrtextlbl.ForeColor = System.Drawing.Color.Red
			Me.prntfootrtextlbl.Location = New System.Drawing.Point(209, 179)
			Me.prntfootrtextlbl.Name = "prntfootrtextlbl"
			Me.prntfootrtextlbl.Size = New System.Drawing.Size(0, 19)
			Me.prntfootrtextlbl.TabIndex = 14
			' 
			' receptpntrnmelbl
			' 
			Me.receptpntrnmelbl.AutoSize = True
			Me.receptpntrnmelbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.receptpntrnmelbl.ForeColor = System.Drawing.Color.Red
			Me.receptpntrnmelbl.Location = New System.Drawing.Point(208, 236)
			Me.receptpntrnmelbl.Name = "receptpntrnmelbl"
			Me.receptpntrnmelbl.Size = New System.Drawing.Size(0, 19)
			Me.receptpntrnmelbl.TabIndex = 15
			' 
			' ReceptSpacnglbl
			' 
			Me.ReceptSpacnglbl.AutoSize = True
			Me.ReceptSpacnglbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ReceptSpacnglbl.ForeColor = System.Drawing.Color.Red
			Me.ReceptSpacnglbl.Location = New System.Drawing.Point(210, 288)
			Me.ReceptSpacnglbl.Name = "ReceptSpacnglbl"
			Me.ReceptSpacnglbl.Size = New System.Drawing.Size(0, 19)
			Me.ReceptSpacnglbl.TabIndex = 16
			' 
			' PrntTmeAtFootrlbl
			' 
			Me.PrntTmeAtFootrlbl.AutoSize = True
			Me.PrntTmeAtFootrlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntTmeAtFootrlbl.ForeColor = System.Drawing.Color.Red
			Me.PrntTmeAtFootrlbl.Location = New System.Drawing.Point(207, 347)
			Me.PrntTmeAtFootrlbl.Name = "PrntTmeAtFootrlbl"
			Me.PrntTmeAtFootrlbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntTmeAtFootrlbl.TabIndex = 17
			Me.PrntTmeAtFootrlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' PrntshpNmeAtHederlbl
			' 
			Me.PrntshpNmeAtHederlbl.AutoSize = True
			Me.PrntshpNmeAtHederlbl.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PrntshpNmeAtHederlbl.ForeColor = System.Drawing.Color.Red
			Me.PrntshpNmeAtHederlbl.Location = New System.Drawing.Point(208, 401)
			Me.PrntshpNmeAtHederlbl.Name = "PrntshpNmeAtHederlbl"
			Me.PrntshpNmeAtHederlbl.Size = New System.Drawing.Size(0, 19)
			Me.PrntshpNmeAtHederlbl.TabIndex = 18
			Me.PrntshpNmeAtHederlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.PrntshpNmeAtHederlbl)
			Me.groupBox1.Controls.Add(Me.PrntTmeAtFootrlbl)
			Me.groupBox1.Controls.Add(Me.ReceptSpacnglbl)
			Me.groupBox1.Controls.Add(Me.receptpntrnmelbl)
			Me.groupBox1.Controls.Add(Me.prntfootrtextlbl)
			Me.groupBox1.Controls.Add(Me.footrtxtlbl)
			Me.groupBox1.Controls.Add(Me.enbldfltreceptprntrlbl)
			Me.groupBox1.Controls.Add(Me.bypassprntlbl)
			Me.groupBox1.Controls.Add(Me.ReceiptSpacingbtn)
			Me.groupBox1.Controls.Add(Me.ReceiptPrinterNamebtn)
			Me.groupBox1.Controls.Add(Me.PrintTimeAtFooterbtn)
			Me.groupBox1.Controls.Add(Me.PrintShopNameAtHeaderbtn)
			Me.groupBox1.Controls.Add(Me.PrintFooterTextbtn)
			Me.groupBox1.Controls.Add(Me.FooterTextbtn)
			Me.groupBox1.Controls.Add(Me.EnableDefaultReceiptPrinterbtn)
			Me.groupBox1.Controls.Add(Me.BypassPrintDlgbtn)
			Me.groupBox1.Location = New System.Drawing.Point(11, 9)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(335, 443)
			Me.groupBox1.TabIndex = 19
			Me.groupBox1.TabStop = False
			' 
			' ReceiptsettingsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(355, 470)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.enblelabel)
			Me.Name = "ReceiptsettingsDlg"
			Me.Text = "ReceiptsettingsDlg"
'			Me.Load += New System.EventHandler(Me.ReceiptsettingsDlg_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents BypassPrintDlgbtn As System.Windows.Forms.Button
		Private WithEvents EnableDefaultReceiptPrinterbtn As System.Windows.Forms.Button
		Private WithEvents FooterTextbtn As System.Windows.Forms.Button
		Private WithEvents PrintFooterTextbtn As System.Windows.Forms.Button
		Private WithEvents PrintShopNameAtHeaderbtn As System.Windows.Forms.Button
		Private WithEvents PrintTimeAtFooterbtn As System.Windows.Forms.Button
		Private WithEvents ReceiptPrinterNamebtn As System.Windows.Forms.Button
		Private WithEvents ReceiptSpacingbtn As System.Windows.Forms.Button
		Private enblelabel As System.Windows.Forms.Label
		Private bypassprntlbl As System.Windows.Forms.Label
		Private enbldfltreceptprntrlbl As System.Windows.Forms.Label
		Private footrtxtlbl As System.Windows.Forms.Label
		Private prntfootrtextlbl As System.Windows.Forms.Label
		Private receptpntrnmelbl As System.Windows.Forms.Label
		Private ReceptSpacnglbl As System.Windows.Forms.Label
		Private PrntTmeAtFootrlbl As System.Windows.Forms.Label
		Private PrntshpNmeAtHederlbl As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace