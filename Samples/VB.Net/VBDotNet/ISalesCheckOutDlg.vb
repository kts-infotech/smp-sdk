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
	Partial Public Class ISalesCheckOutDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SalesCheckoutbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SalesCheckoutbtn.Click
			Dim m_SalesCheckout As ISalesCheckout

			m_SalesCheckout = New SalesCheckoutClass()

			m_SalesCheckout.InvokeSalesCheckoutDlg()
		End Sub

	End Class
End Namespace