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
	Partial Public Class ISmpReportSettingDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PrintShopNameAtHeaderbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintShopNameAtHeaderbtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lPrntShpNme As Long

			lPrntShpNme = m_SmpReportSettings.PrintShopNameAtHeader

			If lPrntShpNme = 1 Then
				PrntShpNmeAtHederlbl.Text = "Enabled"
			ElseIf lPrntShpNme = 0 Then
				PrntShpNmeAtHederlbl.Text = "Disabled"
			End If
		End Sub

		Private Sub PrintShopLogobtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintShopLogobtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lPrntShpLogo As Long

			lPrntShpLogo = m_SmpReportSettings.PrintShopLogo

			If lPrntShpLogo = 1 Then
				PrntShpLogolbl.Text = "Enabled"

			ElseIf lPrntShpLogo = 0 Then
				PrntShpLogolbl.Text = "Disabled"
			End If
		End Sub

		Private Sub PrintPhNoAtFooterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintPhNoAtFooterbtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lPrntPhno As Long

			lPrntPhno = m_SmpReportSettings.PrintPhNoAtFooter

			If lPrntPhno = 1 Then
				PrntPhnolbl.Text = "Enabled"

			ElseIf lPrntPhno = 0 Then
				PrntPhnolbl.Text = "Disabled"
			End If

		End Sub

		Private Sub PrintTimeAtFooterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintTimeAtFooterbtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lprntTme As Long

			lprntTme = m_SmpReportSettings.PrintTimeAtFooter

			If lprntTme = 1 Then
				PrntTmeAtFootrlbl.Text = "Enabled"

			ElseIf lprntTme = 0 Then
				PrntTmeAtFootrlbl.Text = "Disabled"
			End If

		End Sub

		Private Sub BypassPrintDlgbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BypassPrintDlgbtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lBypassprnt As Long

			lBypassprnt = m_SmpReportSettings.BypassPrintDlg

			If lBypassprnt = 1 Then
				BypassPrntlbl.Text = "Enabled"

			ElseIf lBypassprnt = 0 Then
				BypassPrntlbl.Text = "Disabled"
			End If
		End Sub

		Private Sub AllwaysPrintMembershipFormbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllwaysPrintMembershipFormbtn.Click
			Dim m_SmpReportSettings As ISmpReportSettings

			m_SmpReportSettings = New SmpReportSettingsClass()

			Dim lPrntMbershpFrm As Long

			lPrntMbershpFrm = m_SmpReportSettings.AllwaysPrintMembershipForm

			If lPrntMbershpFrm = 1 Then
				prntMbrShplbl.Text = "Enabled"

			ElseIf lPrntMbershpFrm = 0 Then
				prntMbrShplbl.Text = "Disabled"
			End If
		End Sub

		Private Sub ReportSettingDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace