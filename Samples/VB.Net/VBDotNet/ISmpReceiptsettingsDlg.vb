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
	Partial Public Class ReceiptsettingsDlg
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ReceiptsettingsDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub BypassPrintDlgbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BypassPrintDlgbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim lBypassprnt As Long

			lBypassprnt = m_SmpReceiptSettings.BypassPrintDlg

			If lBypassprnt = 1 Then
				bypassprntlbl.Text = " Enabled "

			ElseIf lBypassprnt = 0 Then
				bypassprntlbl.Text = " Disabled "
			End If
		End Sub

		Private Sub MessageBox(ByVal p As String)
			Throw New Exception("The method or operation is not implemented.")
		End Sub

		Private Sub EnableDefaultReceiptPrinterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EnableDefaultReceiptPrinterbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim lenbledfltreceptprntr As Long

			lenbledfltreceptprntr = m_SmpReceiptSettings.EnableDefaultReceiptPrinter

			If lenbledfltreceptprntr = 1 Then
				enbldfltreceptprntrlbl.Text = " Enabled "

			ElseIf lenbledfltreceptprntr = 0 Then
				enbldfltreceptprntrlbl.Text = " Disabled "
			End If
		End Sub

		Private Sub FooterTextbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FooterTextbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim strFootrTxt As String

			strFootrTxt = m_SmpReceiptSettings.FooterText

			If strFootrTxt = "" Then
				footrtxtlbl.Text = " No Footer Text"

			Else
				footrtxtlbl.Text = strFootrTxt
			End If
		End Sub

		Private Sub PrintFooterTextbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintFooterTextbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim lPrntFootrTxt As Long

			lPrntFootrTxt = m_SmpReceiptSettings.PrintFooterText

			If lPrntFootrTxt = 1 Then
				prntfootrtextlbl.Text = " Enabled "

			ElseIf lPrntFootrTxt = 0 Then
				prntfootrtextlbl.Text = " Disabled "
			End If
		End Sub

		Private Sub ReceiptPrinterNamebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReceiptPrinterNamebtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim strReceptPrntrName As String

			strReceptPrntrName = m_SmpReceiptSettings.ReceiptPrinterName

			If strReceptPrntrName = "" Then
				receptpntrnmelbl.Text = "No Printer Name"

			Else

				receptpntrnmelbl.Text = strReceptPrntrName
			End If
		End Sub

		Private Sub ReceiptSpacingbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReceiptSpacingbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim iReceptSpacng As Integer = 0

			iReceptSpacng = m_SmpReceiptSettings.ReceiptSpacing

			If iReceptSpacng = 0 Then
				ReceptSpacnglbl.Text = " Not Defined "

			Else

				ReceptSpacnglbl.Text = iReceptSpacng.ToString()
			End If
		End Sub

		Private Sub PrintTimeAtFooterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintTimeAtFooterbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim lPrntTmeAtFootr As Long

			lPrntTmeAtFootr = m_SmpReceiptSettings.PrintTimeAtFooter

			If lPrntTmeAtFootr = 1 Then
				PrntTmeAtFootrlbl.Text = "Enabled"

			ElseIf lPrntTmeAtFootr = 0 Then
				PrntTmeAtFootrlbl.Text = "Disabled"
			End If
		End Sub

		Private Sub PrintShopNameAtHeaderbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintShopNameAtHeaderbtn.Click
			Dim m_SmpReceiptSettings As ISmpReceiptSettings

			m_SmpReceiptSettings = New SmpReceiptSettingsClass()

			Dim lPrntShpNmeAtHeder As Long

			lPrntShpNmeAtHeder = m_SmpReceiptSettings.PrintShopNameAtHeader

			If lPrntShpNmeAtHeder = 1 Then
				PrntshpNmeAtHederlbl.Text = "Enabled"

			ElseIf lPrntShpNmeAtHeder = 0 Then
				PrntshpNmeAtHederlbl.Text = "Disabled"
			End If
		End Sub


	End Class
End Namespace