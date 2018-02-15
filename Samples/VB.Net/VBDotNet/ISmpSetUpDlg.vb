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
	Partial Public Class ISmpSetUpDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MiscItemMasterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MiscItemMasterbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeMiscItemMasterDlg()
		End Sub

		Private Sub StockMasterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StockMasterbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeStockMasterDlg()
		End Sub

		Private Sub SMPSetUp_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub CategoryMasterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CategoryMasterbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeCategoryMasterDlg()
		End Sub

		Private Sub CurrencySettingsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CurrencySettingsbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeCurrencySettingsDlg()
		End Sub

		Private Sub DefaultSettingsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultSettingsbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeDefaultSettingsDlg()
		End Sub

		Private Sub DefaultSettingsExtbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultSettingsExtbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeDefaultSettingsExtDlg()
		End Sub

		Private Sub DeleteOldDatabtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteOldDatabtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeDeleteOldDataDlg()
		End Sub

		Private Sub ManageUsersbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManageUsersbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeManageUsersDlg()
		End Sub

		Private Sub MethodOfPaymentbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MethodOfPaymentbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeMethodOfPaymentDlg()
		End Sub

		Private Sub ServiceMasterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ServiceMasterbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeServiceMasterDlg()
		End Sub

		Private Sub SetupWizardbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetupWizardbtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeSetupWizard()
		End Sub

		Private Sub ShopInfobtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShopInfobtn.Click
			Dim m_SmpSetup As ISmpSetup

			m_SmpSetup = New SmpSetupClass()

			m_SmpSetup.InvokeShopInfoDlg()
		End Sub
	End Class
End Namespace