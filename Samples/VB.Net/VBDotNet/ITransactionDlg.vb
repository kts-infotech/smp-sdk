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
	Partial Public Class ITransactionDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AddMiscExpenseBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddMiscExpenseBtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeAddMiscExpenseDlg()
		End Sub

		Private Sub AddMiscIncomebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddMiscIncomebtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeAddMiscIncomeDlg()
		End Sub

		Private Sub EditMiscExpensebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditMiscExpensebtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeEditMiscExpenseDlg()
		End Sub

		Private Sub EditMiscIncomebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditMiscIncomebtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeEditMiscIncomeDlg()
		End Sub

		Private Sub EditTransactionbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditTransactionbtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeEditTransactionDlg()
		End Sub

		Private Sub CancelTransactionbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelTransactionbtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeCancelTransactionDlg()
		End Sub

		Private Sub AddTransactionbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddTransactionbtn.Click
			Dim m_Transactions As ITransactions

			m_Transactions = New TransactionsClass()

			m_Transactions.InvokeAddTransactionDlg()
		End Sub
	End Class
End Namespace