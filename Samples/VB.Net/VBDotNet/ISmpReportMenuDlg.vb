Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib

Namespace CSharpSDKTest
	Partial Public Class ISmpReportMenuDlg
		Inherits Form

		Public Sub New()

			InitializeComponent()
		End Sub

		Private Sub AnualAccountbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AnualAccountbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu
				m_SmpReportMenu = New SmpReportMenuClass()
				m_SmpReportMenu.InvokeAnualAccountDlg()
				Return
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try

		End Sub

		Private Sub AnualStatisticsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AnualStatisticsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeAnualStatisticsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CanceledSalesbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CanceledSalesbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCanceledSalesDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CanceledTransactionsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CanceledTransactionsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCanceledTransactionsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerBalanceAmountbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerBalanceAmountbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerBalanceAmountDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerInactivebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerInactivebtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerInactiveDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try

		End Sub

		Private Sub CustomerListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerMostActivebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerMostActivebtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerMostActiveDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerPaymentDetailsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerPaymentDetailsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerPaymentDetailsdlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerRefundDetailsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerRefundDetailsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerRefundDetailsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerSalesDetailsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerSalesDetailsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerSalesDetailsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub CustomerTransactionDetailsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomerTransactionDetailsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeCustomerTransactionDetailsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub DailyAccountbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DailyAccountbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeDailyAccountDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub DailySummarybtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DailySummarybtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeDailySummaryDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub DiscountSalesbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DiscountSalesbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeDiscountSalesDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub MiscTransactionListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MiscTransactionListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeMiscTransactionListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub MonthlyAccountbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MonthlyAccountbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeMonthlyAccountDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub MonthlyStatisticsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MonthlyStatisticsbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeMonthlyStatisticsDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub ReorderListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReorderListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeReorderListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub Rollbackbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Rollbackbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeRollbackDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub SalesListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SalesListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeSalesListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub ServiceDeliveredbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ServiceDeliveredbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeServiceDeliveredDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub ServiceListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ServiceListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeServiceListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub SpecifiedPeriodAccountbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SpecifiedPeriodAccountbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeSpecifiedPeriodAccountDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub StokeListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StokeListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeStokeListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub

		Private Sub TransactionListbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TransactionListbtn.Click
			Try
				Dim m_SmpReportMenu As ISmpReportMenu

				m_SmpReportMenu = New SmpReportMenuClass()

				m_SmpReportMenu.InvokeTransactionListDlg()
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try
		End Sub
	End Class
End Namespace