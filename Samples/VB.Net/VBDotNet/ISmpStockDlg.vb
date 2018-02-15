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
	Partial Public Class ISmpStockDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AddNewStockbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddNewStockbtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			m_SmpStock.InvokeAddNewStockDlg()
		End Sub

		Private Sub CancelSalesbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelSalesbtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			Dim iSalesId As Integer = 0

			m_SmpStock.InvokeCancelSalesDlg((iSalesId))
		End Sub

		Private Sub Checkoutbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Checkoutbtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			m_SmpStock.InvokeCheckoutDlg()
		End Sub

		Private Sub EditStockbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditStockbtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			m_SmpStock.InvokeEditStockDlg()
		End Sub

		Private Sub ModifyStockItemPricebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ModifyStockItemPricebtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			m_SmpStock.InvokeModifyStockItemPriceDlg()
		End Sub

		Private Sub StockRateSettingsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StockRateSettingsbtn.Click
			Dim m_SmpStock As ISmpStock

			m_SmpStock = New SmpStockClass()

			m_SmpStock.InvokeStockRateSettingsDlg()
		End Sub
	End Class
End Namespace