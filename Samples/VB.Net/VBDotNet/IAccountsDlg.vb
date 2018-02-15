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
	Partial Public Class IAccountsDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RefundToCustomerbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefundToCustomerbtn.Click
			Dim m_Accounts As IAccounts

			m_Accounts = New AccountsClass()

			Dim VarCusId As Object = 0

			m_Accounts.InvokeRefundToCustomerDlg(VarCusId)
		End Sub

		Private Sub AcceptPaymentbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AcceptPaymentbtn.Click
			Dim m_Accounts As IAccounts

			m_Accounts = New AccountsClass()

			Dim VarCusId As Object = 0

			m_Accounts.InvokeAcceptPaymentDialog(VarCusId)
		End Sub

		Private Sub Adbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Adbtn.Click
			Dim m_Accounts As IAccounts

			m_Accounts = New AccountsClass()

			Adlbl.Visible = False

			Dim strShpBal As String

			Dim num As Double

			strShpBal = AdTxt.Text

			Dim isnum As Boolean=Double.TryParse(strShpBal,num)

			If (Not isnum) Then
				Adlbl.Visible=True

			ElseIf strShpBal = "" Then
				Adlbl.Visible = True
			Else
				m_Accounts.AddToShopBalance(Double.Parse(strShpBal))

				MessageBox.Show("Added to the shop balance")
			End If

		End Sub

		Private Sub Sbtractbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Sbtractbtn.Click
			Dim m_Accounts As IAccounts

			m_Accounts = New AccountsClass()

			Sublbl.Visible = False

			Dim strShpBal As String

			Dim num As Double

			strShpBal = SubtractTxt.Text

			Dim isnum As Boolean = Double.TryParse(strShpBal, num)

			If (Not isnum) Then
				Sublbl.Visible = True

			ElseIf strShpBal = "" Then
				Sublbl.Visible = True
			Else
				m_Accounts.SubstractFromShopBalance(Double.Parse(strShpBal))

				MessageBox.Show("Subtracted from the shop balance")
			End If

		End Sub

	End Class
End Namespace