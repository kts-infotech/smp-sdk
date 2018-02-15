Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpStockDlg
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
			Me.AddNewStockbtn = New System.Windows.Forms.Button()
			Me.CancelSalesbtn = New System.Windows.Forms.Button()
			Me.Checkoutbtn = New System.Windows.Forms.Button()
			Me.EditStockbtn = New System.Windows.Forms.Button()
			Me.ModifyStockItemPricebtn = New System.Windows.Forms.Button()
			Me.StockRateSettingsbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AddNewStockbtn
			' 
			Me.AddNewStockbtn.Location = New System.Drawing.Point(14, 21)
			Me.AddNewStockbtn.Name = "AddNewStockbtn"
			Me.AddNewStockbtn.Size = New System.Drawing.Size(135, 45)
			Me.AddNewStockbtn.TabIndex = 0
			Me.AddNewStockbtn.Text = "Add New Stock"
			Me.AddNewStockbtn.UseVisualStyleBackColor = True
'			Me.AddNewStockbtn.Click += New System.EventHandler(Me.AddNewStockbtn_Click);
			' 
			' CancelSalesbtn
			' 
			Me.CancelSalesbtn.Location = New System.Drawing.Point(14, 93)
			Me.CancelSalesbtn.Name = "CancelSalesbtn"
			Me.CancelSalesbtn.Size = New System.Drawing.Size(135, 45)
			Me.CancelSalesbtn.TabIndex = 1
			Me.CancelSalesbtn.Text = "Cancel Sales"
			Me.CancelSalesbtn.UseVisualStyleBackColor = True
'			Me.CancelSalesbtn.Click += New System.EventHandler(Me.CancelSalesbtn_Click);
			' 
			' Checkoutbtn
			' 
			Me.Checkoutbtn.Location = New System.Drawing.Point(14, 165)
			Me.Checkoutbtn.Name = "Checkoutbtn"
			Me.Checkoutbtn.Size = New System.Drawing.Size(135, 45)
			Me.Checkoutbtn.TabIndex = 2
			Me.Checkoutbtn.Text = "Check out"
			Me.Checkoutbtn.UseVisualStyleBackColor = True
'			Me.Checkoutbtn.Click += New System.EventHandler(Me.Checkoutbtn_Click);
			' 
			' EditStockbtn
			' 
			Me.EditStockbtn.Location = New System.Drawing.Point(175, 21)
			Me.EditStockbtn.Name = "EditStockbtn"
			Me.EditStockbtn.Size = New System.Drawing.Size(135, 45)
			Me.EditStockbtn.TabIndex = 3
			Me.EditStockbtn.Text = "Edit Stock"
			Me.EditStockbtn.UseVisualStyleBackColor = True
'			Me.EditStockbtn.Click += New System.EventHandler(Me.EditStockbtn_Click);
			' 
			' ModifyStockItemPricebtn
			' 
			Me.ModifyStockItemPricebtn.Location = New System.Drawing.Point(175, 93)
			Me.ModifyStockItemPricebtn.Name = "ModifyStockItemPricebtn"
			Me.ModifyStockItemPricebtn.Size = New System.Drawing.Size(135, 45)
			Me.ModifyStockItemPricebtn.TabIndex = 4
			Me.ModifyStockItemPricebtn.Text = "Modify Stock Item Price"
			Me.ModifyStockItemPricebtn.UseVisualStyleBackColor = True
'			Me.ModifyStockItemPricebtn.Click += New System.EventHandler(Me.ModifyStockItemPricebtn_Click);
			' 
			' StockRateSettingsbtn
			' 
			Me.StockRateSettingsbtn.Location = New System.Drawing.Point(175, 165)
			Me.StockRateSettingsbtn.Name = "StockRateSettingsbtn"
			Me.StockRateSettingsbtn.Size = New System.Drawing.Size(135, 45)
			Me.StockRateSettingsbtn.TabIndex = 5
			Me.StockRateSettingsbtn.Text = "Stock Rate Settings"
			Me.StockRateSettingsbtn.UseVisualStyleBackColor = True
'			Me.StockRateSettingsbtn.Click += New System.EventHandler(Me.StockRateSettingsbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.StockRateSettingsbtn)
			Me.groupBox1.Controls.Add(Me.ModifyStockItemPricebtn)
			Me.groupBox1.Controls.Add(Me.EditStockbtn)
			Me.groupBox1.Controls.Add(Me.Checkoutbtn)
			Me.groupBox1.Controls.Add(Me.CancelSalesbtn)
			Me.groupBox1.Controls.Add(Me.AddNewStockbtn)
			Me.groupBox1.Location = New System.Drawing.Point(17, 27)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(324, 230)
			Me.groupBox1.TabIndex = 6
			Me.groupBox1.TabStop = False
			' 
			' SmpStockDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(352, 280)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SmpStockDlg"
			Me.Text = "SmpStockDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AddNewStockbtn As System.Windows.Forms.Button
		Private WithEvents CancelSalesbtn As System.Windows.Forms.Button
		Private WithEvents Checkoutbtn As System.Windows.Forms.Button
		Private WithEvents EditStockbtn As System.Windows.Forms.Button
		Private WithEvents ModifyStockItemPricebtn As System.Windows.Forms.Button
		Private WithEvents StockRateSettingsbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace