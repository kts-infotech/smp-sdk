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
	Partial Public Class ICustomerDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Cstmrdtlsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cstmrdtlsbtn.Click
			Dim m_Customer As ICustomer

			m_Customer = New CustomerClass()

			CustIdlbl.Visible = False

			FldNmelbl.Visible = False

			Dim strCusId, strFldNme As String

			strCusId = custIdTxt.Text

			strFldNme = FldNmeTxt.Text

			If (strCusId = "") AndAlso (strFldNme = "") Then
				CustIdlbl.Visible = True
				FldNmelbl.Visible = True

			ElseIf strCusId = "" Then
				CustIdlbl.Visible = True

			ElseIf strFldNme = "" Then
				FldNmelbl.Visible = True

			Else
				Dim VarVal As Object = 0

				m_Customer.GetCustomerDetails(strCusId, strFldNme, VarVal)

				Dim strMsg As String = VarVal.ToString()

				MessageBox.Show(strMsg)
			End If
		End Sub

		Private Sub FindCustomerbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FindCustomerbtn.Click
			Dim m_Customer As ICustomer

			m_Customer = New CustomerClass()

			Dim strCusId As String=""

			m_Customer.InvokeFindCustomerDlg(strCusId)
		End Sub

		Private Sub clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clsbtn.Click
			Me.Close()
		End Sub
	End Class
End Namespace