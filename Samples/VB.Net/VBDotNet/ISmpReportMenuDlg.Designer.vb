Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpReportMenuDlg
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
			Me.AnualAccountbtn = New System.Windows.Forms.Button()
			Me.AnualStatisticsbtn = New System.Windows.Forms.Button()
			Me.CanceledSalesbtn = New System.Windows.Forms.Button()
			Me.CanceledTransactionsbtn = New System.Windows.Forms.Button()
			Me.CustomerBalanceAmountbtn = New System.Windows.Forms.Button()
			Me.CustomerInactivebtn = New System.Windows.Forms.Button()
			Me.CustomerMostActivebtn = New System.Windows.Forms.Button()
			Me.CustomerPaymentDetailsbtn = New System.Windows.Forms.Button()
			Me.CustomerRefundDetailsbtn = New System.Windows.Forms.Button()
			Me.CustomerSalesDetailsbtn = New System.Windows.Forms.Button()
			Me.CustomerTransactionDetailsbtn = New System.Windows.Forms.Button()
			Me.DailyAccountbtn = New System.Windows.Forms.Button()
			Me.DiscountSalesbtn = New System.Windows.Forms.Button()
			Me.MiscTransactionListbtn = New System.Windows.Forms.Button()
			Me.MonthlyAccountbtn = New System.Windows.Forms.Button()
			Me.MonthlyStatisticsbtn = New System.Windows.Forms.Button()
			Me.ReorderListbtn = New System.Windows.Forms.Button()
			Me.Rollbackbtn = New System.Windows.Forms.Button()
			Me.SalesListbtn = New System.Windows.Forms.Button()
			Me.ServiceDeliveredbtn = New System.Windows.Forms.Button()
			Me.ServiceListbtn = New System.Windows.Forms.Button()
			Me.SpecifiedPeriodAccountbtn = New System.Windows.Forms.Button()
			Me.StokeListbtn = New System.Windows.Forms.Button()
			Me.TransactionListbtn = New System.Windows.Forms.Button()
			Me.CustomerListbtn = New System.Windows.Forms.Button()
			Me.DailySummarybtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AnualAccountbtn
			' 
			Me.AnualAccountbtn.Location = New System.Drawing.Point(17, 21)
			Me.AnualAccountbtn.Name = "AnualAccountbtn"
			Me.AnualAccountbtn.Size = New System.Drawing.Size(177, 58)
			Me.AnualAccountbtn.TabIndex = 0
			Me.AnualAccountbtn.Text = "Annual Account"
			Me.AnualAccountbtn.UseVisualStyleBackColor = True
'			Me.AnualAccountbtn.Click += New System.EventHandler(Me.AnualAccountbtn_Click);
			' 
			' AnualStatisticsbtn
			' 
			Me.AnualStatisticsbtn.Location = New System.Drawing.Point(17, 85)
			Me.AnualStatisticsbtn.Name = "AnualStatisticsbtn"
			Me.AnualStatisticsbtn.Size = New System.Drawing.Size(177, 58)
			Me.AnualStatisticsbtn.TabIndex = 1
			Me.AnualStatisticsbtn.Text = "Annual Statistics"
			Me.AnualStatisticsbtn.UseVisualStyleBackColor = True
'			Me.AnualStatisticsbtn.Click += New System.EventHandler(Me.AnualStatisticsbtn_Click);
			' 
			' CanceledSalesbtn
			' 
			Me.CanceledSalesbtn.Location = New System.Drawing.Point(17, 149)
			Me.CanceledSalesbtn.Name = "CanceledSalesbtn"
			Me.CanceledSalesbtn.Size = New System.Drawing.Size(177, 58)
			Me.CanceledSalesbtn.TabIndex = 2
			Me.CanceledSalesbtn.Text = "Canceled Sales"
			Me.CanceledSalesbtn.UseVisualStyleBackColor = True
'			Me.CanceledSalesbtn.Click += New System.EventHandler(Me.CanceledSalesbtn_Click);
			' 
			' CanceledTransactionsbtn
			' 
			Me.CanceledTransactionsbtn.Location = New System.Drawing.Point(17, 213)
			Me.CanceledTransactionsbtn.Name = "CanceledTransactionsbtn"
			Me.CanceledTransactionsbtn.Size = New System.Drawing.Size(177, 58)
			Me.CanceledTransactionsbtn.TabIndex = 3
			Me.CanceledTransactionsbtn.Text = "Canceled Transactions"
			Me.CanceledTransactionsbtn.UseVisualStyleBackColor = True
'			Me.CanceledTransactionsbtn.Click += New System.EventHandler(Me.CanceledTransactionsbtn_Click);
			' 
			' CustomerBalanceAmountbtn
			' 
			Me.CustomerBalanceAmountbtn.Location = New System.Drawing.Point(17, 277)
			Me.CustomerBalanceAmountbtn.Name = "CustomerBalanceAmountbtn"
			Me.CustomerBalanceAmountbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerBalanceAmountbtn.TabIndex = 4
			Me.CustomerBalanceAmountbtn.Text = "Customer Balance Amount"
			Me.CustomerBalanceAmountbtn.UseVisualStyleBackColor = True
'			Me.CustomerBalanceAmountbtn.Click += New System.EventHandler(Me.CustomerBalanceAmountbtn_Click);
			' 
			' CustomerInactivebtn
			' 
			Me.CustomerInactivebtn.Location = New System.Drawing.Point(17, 341)
			Me.CustomerInactivebtn.Name = "CustomerInactivebtn"
			Me.CustomerInactivebtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerInactivebtn.TabIndex = 5
			Me.CustomerInactivebtn.Text = "Customer Inactive"
			Me.CustomerInactivebtn.UseVisualStyleBackColor = True
'			Me.CustomerInactivebtn.Click += New System.EventHandler(Me.CustomerInactivebtn_Click);
			' 
			' CustomerMostActivebtn
			' 
			Me.CustomerMostActivebtn.Location = New System.Drawing.Point(213, 21)
			Me.CustomerMostActivebtn.Name = "CustomerMostActivebtn"
			Me.CustomerMostActivebtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerMostActivebtn.TabIndex = 6
			Me.CustomerMostActivebtn.Text = "Customer Most Active"
			Me.CustomerMostActivebtn.UseVisualStyleBackColor = True
'			Me.CustomerMostActivebtn.Click += New System.EventHandler(Me.CustomerMostActivebtn_Click);
			' 
			' CustomerPaymentDetailsbtn
			' 
			Me.CustomerPaymentDetailsbtn.Location = New System.Drawing.Point(213, 85)
			Me.CustomerPaymentDetailsbtn.Name = "CustomerPaymentDetailsbtn"
			Me.CustomerPaymentDetailsbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerPaymentDetailsbtn.TabIndex = 7
			Me.CustomerPaymentDetailsbtn.Text = "Customer Payment Details"
			Me.CustomerPaymentDetailsbtn.UseVisualStyleBackColor = True
'			Me.CustomerPaymentDetailsbtn.Click += New System.EventHandler(Me.CustomerPaymentDetailsbtn_Click);
			' 
			' CustomerRefundDetailsbtn
			' 
			Me.CustomerRefundDetailsbtn.Location = New System.Drawing.Point(213, 149)
			Me.CustomerRefundDetailsbtn.Name = "CustomerRefundDetailsbtn"
			Me.CustomerRefundDetailsbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerRefundDetailsbtn.TabIndex = 8
			Me.CustomerRefundDetailsbtn.Text = "Customer Refund Details"
			Me.CustomerRefundDetailsbtn.UseVisualStyleBackColor = True
'			Me.CustomerRefundDetailsbtn.Click += New System.EventHandler(Me.CustomerRefundDetailsbtn_Click);
			' 
			' CustomerSalesDetailsbtn
			' 
			Me.CustomerSalesDetailsbtn.Location = New System.Drawing.Point(213, 213)
			Me.CustomerSalesDetailsbtn.Name = "CustomerSalesDetailsbtn"
			Me.CustomerSalesDetailsbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerSalesDetailsbtn.TabIndex = 9
			Me.CustomerSalesDetailsbtn.Text = "Customer Sales Details"
			Me.CustomerSalesDetailsbtn.UseVisualStyleBackColor = True
'			Me.CustomerSalesDetailsbtn.Click += New System.EventHandler(Me.CustomerSalesDetailsbtn_Click);
			' 
			' CustomerTransactionDetailsbtn
			' 
			Me.CustomerTransactionDetailsbtn.Location = New System.Drawing.Point(213, 277)
			Me.CustomerTransactionDetailsbtn.Name = "CustomerTransactionDetailsbtn"
			Me.CustomerTransactionDetailsbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerTransactionDetailsbtn.TabIndex = 10
			Me.CustomerTransactionDetailsbtn.Text = "Customer Transaction Details"
			Me.CustomerTransactionDetailsbtn.UseVisualStyleBackColor = True
'			Me.CustomerTransactionDetailsbtn.Click += New System.EventHandler(Me.CustomerTransactionDetailsbtn_Click);
			' 
			' DailyAccountbtn
			' 
			Me.DailyAccountbtn.Location = New System.Drawing.Point(213, 341)
			Me.DailyAccountbtn.Name = "DailyAccountbtn"
			Me.DailyAccountbtn.Size = New System.Drawing.Size(177, 58)
			Me.DailyAccountbtn.TabIndex = 11
			Me.DailyAccountbtn.Text = "Daily Account"
			Me.DailyAccountbtn.UseVisualStyleBackColor = True
'			Me.DailyAccountbtn.Click += New System.EventHandler(Me.DailyAccountbtn_Click);
			' 
			' DiscountSalesbtn
			' 
			Me.DiscountSalesbtn.Location = New System.Drawing.Point(406, 21)
			Me.DiscountSalesbtn.Name = "DiscountSalesbtn"
			Me.DiscountSalesbtn.Size = New System.Drawing.Size(177, 58)
			Me.DiscountSalesbtn.TabIndex = 12
			Me.DiscountSalesbtn.Text = "Discount Sales"
			Me.DiscountSalesbtn.UseVisualStyleBackColor = True
'			Me.DiscountSalesbtn.Click += New System.EventHandler(Me.DiscountSalesbtn_Click);
			' 
			' MiscTransactionListbtn
			' 
			Me.MiscTransactionListbtn.Location = New System.Drawing.Point(406, 85)
			Me.MiscTransactionListbtn.Name = "MiscTransactionListbtn"
			Me.MiscTransactionListbtn.Size = New System.Drawing.Size(177, 58)
			Me.MiscTransactionListbtn.TabIndex = 13
			Me.MiscTransactionListbtn.Text = "Miscellaneous Transaction List"
			Me.MiscTransactionListbtn.UseVisualStyleBackColor = True
'			Me.MiscTransactionListbtn.Click += New System.EventHandler(Me.MiscTransactionListbtn_Click);
			' 
			' MonthlyAccountbtn
			' 
			Me.MonthlyAccountbtn.Location = New System.Drawing.Point(406, 149)
			Me.MonthlyAccountbtn.Name = "MonthlyAccountbtn"
			Me.MonthlyAccountbtn.Size = New System.Drawing.Size(177, 58)
			Me.MonthlyAccountbtn.TabIndex = 14
			Me.MonthlyAccountbtn.Text = "Monthly Account"
			Me.MonthlyAccountbtn.UseVisualStyleBackColor = True
'			Me.MonthlyAccountbtn.Click += New System.EventHandler(Me.MonthlyAccountbtn_Click);
			' 
			' MonthlyStatisticsbtn
			' 
			Me.MonthlyStatisticsbtn.Location = New System.Drawing.Point(406, 213)
			Me.MonthlyStatisticsbtn.Name = "MonthlyStatisticsbtn"
			Me.MonthlyStatisticsbtn.Size = New System.Drawing.Size(177, 58)
			Me.MonthlyStatisticsbtn.TabIndex = 15
			Me.MonthlyStatisticsbtn.Text = "Monthly Statistics"
			Me.MonthlyStatisticsbtn.UseVisualStyleBackColor = True
'			Me.MonthlyStatisticsbtn.Click += New System.EventHandler(Me.MonthlyStatisticsbtn_Click);
			' 
			' ReorderListbtn
			' 
			Me.ReorderListbtn.Location = New System.Drawing.Point(406, 277)
			Me.ReorderListbtn.Name = "ReorderListbtn"
			Me.ReorderListbtn.Size = New System.Drawing.Size(177, 58)
			Me.ReorderListbtn.TabIndex = 16
			Me.ReorderListbtn.Text = "Reorder List"
			Me.ReorderListbtn.UseVisualStyleBackColor = True
'			Me.ReorderListbtn.Click += New System.EventHandler(Me.ReorderListbtn_Click);
			' 
			' Rollbackbtn
			' 
			Me.Rollbackbtn.Location = New System.Drawing.Point(406, 341)
			Me.Rollbackbtn.Name = "Rollbackbtn"
			Me.Rollbackbtn.Size = New System.Drawing.Size(177, 58)
			Me.Rollbackbtn.TabIndex = 17
			Me.Rollbackbtn.Text = "Roll back"
			Me.Rollbackbtn.UseVisualStyleBackColor = True
'			Me.Rollbackbtn.Click += New System.EventHandler(Me.Rollbackbtn_Click);
			' 
			' SalesListbtn
			' 
			Me.SalesListbtn.Location = New System.Drawing.Point(598, 21)
			Me.SalesListbtn.Name = "SalesListbtn"
			Me.SalesListbtn.Size = New System.Drawing.Size(177, 58)
			Me.SalesListbtn.TabIndex = 18
			Me.SalesListbtn.Text = "Sales List"
			Me.SalesListbtn.UseVisualStyleBackColor = True
'			Me.SalesListbtn.Click += New System.EventHandler(Me.SalesListbtn_Click);
			' 
			' ServiceDeliveredbtn
			' 
			Me.ServiceDeliveredbtn.Location = New System.Drawing.Point(598, 85)
			Me.ServiceDeliveredbtn.Name = "ServiceDeliveredbtn"
			Me.ServiceDeliveredbtn.Size = New System.Drawing.Size(177, 58)
			Me.ServiceDeliveredbtn.TabIndex = 19
			Me.ServiceDeliveredbtn.Text = "Service Delivered"
			Me.ServiceDeliveredbtn.UseVisualStyleBackColor = True
'			Me.ServiceDeliveredbtn.Click += New System.EventHandler(Me.ServiceDeliveredbtn_Click);
			' 
			' ServiceListbtn
			' 
			Me.ServiceListbtn.Location = New System.Drawing.Point(599, 149)
			Me.ServiceListbtn.Name = "ServiceListbtn"
			Me.ServiceListbtn.Size = New System.Drawing.Size(177, 58)
			Me.ServiceListbtn.TabIndex = 20
			Me.ServiceListbtn.Text = "Service List"
			Me.ServiceListbtn.UseVisualStyleBackColor = True
'			Me.ServiceListbtn.Click += New System.EventHandler(Me.ServiceListbtn_Click);
			' 
			' SpecifiedPeriodAccountbtn
			' 
			Me.SpecifiedPeriodAccountbtn.Location = New System.Drawing.Point(599, 213)
			Me.SpecifiedPeriodAccountbtn.Name = "SpecifiedPeriodAccountbtn"
			Me.SpecifiedPeriodAccountbtn.Size = New System.Drawing.Size(177, 58)
			Me.SpecifiedPeriodAccountbtn.TabIndex = 21
			Me.SpecifiedPeriodAccountbtn.Text = "Specified Period Account"
			Me.SpecifiedPeriodAccountbtn.UseVisualStyleBackColor = True
'			Me.SpecifiedPeriodAccountbtn.Click += New System.EventHandler(Me.SpecifiedPeriodAccountbtn_Click);
			' 
			' StokeListbtn
			' 
			Me.StokeListbtn.Location = New System.Drawing.Point(598, 277)
			Me.StokeListbtn.Name = "StokeListbtn"
			Me.StokeListbtn.Size = New System.Drawing.Size(177, 58)
			Me.StokeListbtn.TabIndex = 22
			Me.StokeListbtn.Text = "Stock List"
			Me.StokeListbtn.UseVisualStyleBackColor = True
'			Me.StokeListbtn.Click += New System.EventHandler(Me.StokeListbtn_Click);
			' 
			' TransactionListbtn
			' 
			Me.TransactionListbtn.Location = New System.Drawing.Point(599, 341)
			Me.TransactionListbtn.Name = "TransactionListbtn"
			Me.TransactionListbtn.Size = New System.Drawing.Size(177, 58)
			Me.TransactionListbtn.TabIndex = 23
			Me.TransactionListbtn.Text = "Transaction List"
			Me.TransactionListbtn.UseVisualStyleBackColor = True
'			Me.TransactionListbtn.Click += New System.EventHandler(Me.TransactionListbtn_Click);
			' 
			' CustomerListbtn
			' 
			Me.CustomerListbtn.Location = New System.Drawing.Point(17, 405)
			Me.CustomerListbtn.Name = "CustomerListbtn"
			Me.CustomerListbtn.Size = New System.Drawing.Size(177, 58)
			Me.CustomerListbtn.TabIndex = 24
			Me.CustomerListbtn.Text = "Customer List"
			Me.CustomerListbtn.UseVisualStyleBackColor = True
'			Me.CustomerListbtn.Click += New System.EventHandler(Me.CustomerListbtn_Click);
			' 
			' DailySummarybtn
			' 
			Me.DailySummarybtn.Location = New System.Drawing.Point(213, 405)
			Me.DailySummarybtn.Name = "DailySummarybtn"
			Me.DailySummarybtn.Size = New System.Drawing.Size(177, 58)
			Me.DailySummarybtn.TabIndex = 25
			Me.DailySummarybtn.Text = "Daily Summary"
			Me.DailySummarybtn.UseVisualStyleBackColor = True
'			Me.DailySummarybtn.Click += New System.EventHandler(Me.DailySummarybtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.DailySummarybtn)
			Me.groupBox1.Controls.Add(Me.CustomerListbtn)
			Me.groupBox1.Controls.Add(Me.TransactionListbtn)
			Me.groupBox1.Controls.Add(Me.StokeListbtn)
			Me.groupBox1.Controls.Add(Me.SpecifiedPeriodAccountbtn)
			Me.groupBox1.Controls.Add(Me.ServiceListbtn)
			Me.groupBox1.Controls.Add(Me.ServiceDeliveredbtn)
			Me.groupBox1.Controls.Add(Me.SalesListbtn)
			Me.groupBox1.Controls.Add(Me.Rollbackbtn)
			Me.groupBox1.Controls.Add(Me.ReorderListbtn)
			Me.groupBox1.Controls.Add(Me.MonthlyStatisticsbtn)
			Me.groupBox1.Controls.Add(Me.MonthlyAccountbtn)
			Me.groupBox1.Controls.Add(Me.MiscTransactionListbtn)
			Me.groupBox1.Controls.Add(Me.DiscountSalesbtn)
			Me.groupBox1.Controls.Add(Me.DailyAccountbtn)
			Me.groupBox1.Controls.Add(Me.CustomerTransactionDetailsbtn)
			Me.groupBox1.Controls.Add(Me.CustomerSalesDetailsbtn)
			Me.groupBox1.Controls.Add(Me.CustomerRefundDetailsbtn)
			Me.groupBox1.Controls.Add(Me.CustomerPaymentDetailsbtn)
			Me.groupBox1.Controls.Add(Me.CustomerMostActivebtn)
			Me.groupBox1.Controls.Add(Me.CustomerInactivebtn)
			Me.groupBox1.Controls.Add(Me.CustomerBalanceAmountbtn)
			Me.groupBox1.Controls.Add(Me.CanceledTransactionsbtn)
			Me.groupBox1.Controls.Add(Me.CanceledSalesbtn)
			Me.groupBox1.Controls.Add(Me.AnualStatisticsbtn)
			Me.groupBox1.Controls.Add(Me.AnualAccountbtn)
			Me.groupBox1.Location = New System.Drawing.Point(47, 19)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(797, 487)
			Me.groupBox1.TabIndex = 26
			Me.groupBox1.TabStop = False
			' 
			' ReportMenuDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(873, 521)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "ReportMenuDlg"
			Me.Text = "ReportMenuDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AnualAccountbtn As System.Windows.Forms.Button
		Private WithEvents AnualStatisticsbtn As System.Windows.Forms.Button
		Private WithEvents CanceledSalesbtn As System.Windows.Forms.Button
		Private WithEvents CanceledTransactionsbtn As System.Windows.Forms.Button
		Private WithEvents CustomerBalanceAmountbtn As System.Windows.Forms.Button
		Private WithEvents CustomerInactivebtn As System.Windows.Forms.Button
		Private WithEvents CustomerMostActivebtn As System.Windows.Forms.Button
		Private WithEvents CustomerPaymentDetailsbtn As System.Windows.Forms.Button
		Private WithEvents CustomerRefundDetailsbtn As System.Windows.Forms.Button
		Private WithEvents CustomerSalesDetailsbtn As System.Windows.Forms.Button
		Private WithEvents CustomerTransactionDetailsbtn As System.Windows.Forms.Button
		Private WithEvents DailyAccountbtn As System.Windows.Forms.Button
		Private WithEvents DiscountSalesbtn As System.Windows.Forms.Button
		Private WithEvents MiscTransactionListbtn As System.Windows.Forms.Button
		Private WithEvents MonthlyAccountbtn As System.Windows.Forms.Button
		Private WithEvents MonthlyStatisticsbtn As System.Windows.Forms.Button
		Private WithEvents ReorderListbtn As System.Windows.Forms.Button
		Private WithEvents Rollbackbtn As System.Windows.Forms.Button
		Private WithEvents SalesListbtn As System.Windows.Forms.Button
		Private WithEvents ServiceDeliveredbtn As System.Windows.Forms.Button
		Private WithEvents ServiceListbtn As System.Windows.Forms.Button
		Private WithEvents SpecifiedPeriodAccountbtn As System.Windows.Forms.Button
		Private WithEvents StokeListbtn As System.Windows.Forms.Button
		Private WithEvents TransactionListbtn As System.Windows.Forms.Button
		Private WithEvents CustomerListbtn As System.Windows.Forms.Button
		Private WithEvents DailySummarybtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace