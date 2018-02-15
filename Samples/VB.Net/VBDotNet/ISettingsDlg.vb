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
	Partial Public Class ISettingsDlg
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UseEnterKeybtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UseEnterKeybtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim lEntrKey As Long
			lEntrKey = m_Settings.UseEnterKey
			If lEntrKey = 1 Then
				RsltLbl.Text = "Enabled"
			ElseIf lEntrKey = 0 Then
				RsltLbl.Text = "Disabled"
			End If
		End Sub

		Private Sub AutomaticBackupbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AutomaticBackupbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim lAutoBackup As Long
			lAutoBackup = m_Settings.AutomaticBackup
			If lAutoBackup = 1 Then
				RsltLbl.Text = "Enabled"
			ElseIf lAutoBackup = 0 Then
				RsltLbl.Text = "Disabled"
			End If
		End Sub

		Private Sub AutomaticCompactbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AutomaticCompactbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim lAutoCompact As Long
			lAutoCompact=m_Settings.AutomaticCompact
			If lAutoCompact = 1 Then
				RsltLbl.Text = "Enabled"
			ElseIf lAutoCompact = 0 Then
				RsltLbl.Text = "Disabled"
			End If
		End Sub

		Private Sub DateFormatbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DateFormatbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim strDate As String
			strDate=m_Settings.DateFormat
			RsltLbl.Text = strDate
		End Sub

		Private Sub MembershipFeebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MembershipFeebtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim dblfee As Double
			dblfee=m_Settings.DefaultMembershipFee
			RsltLbl.Text = dblfee.ToString()
		End Sub

		Private Sub SecurityDepositbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SecurityDepositbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim dblsecuritydeposit As Double
			dblsecuritydeposit=m_Settings.DefaultSecurityDeposit
			RsltLbl.Text = dblsecuritydeposit.ToString()
		End Sub

		Private Sub LaunchOnStartupbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LaunchOnStartupbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim llanchstrtup As Long
			llanchstrtup=m_Settings.LaunchOnStartup
			If llanchstrtup = 1 Then
				RsltLbl.Text = "Enabled"
			ElseIf llanchstrtup = 0 Then
				RsltLbl.Text = "Disabled"
			End If
		End Sub

		Private Sub NoOfDisplayRecordsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NoOfDisplayRecordsbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim iNofDsplRcrds As Integer
			iNofDsplRcrds=m_Settings.NoOfDisplayRecords
			RsltLbl.Text = iNofDsplRcrds.ToString()
		End Sub

		Private Sub OverrideExDataOnABbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OverrideExDataOnABbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim lovrrdedataonAB As Long
			lovrrdedataonAB=m_Settings.OverrideExDataOnAB
			If lovrrdedataonAB = 1 Then
				RsltLbl.Text = "Enabled"
			ElseIf lovrrdedataonAB = 0 Then
				RsltLbl.Text = "Disabled"
			End If
		End Sub

		Private Sub PictureFolderbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureFolderbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim strpctreFldr As String
			strpctreFldr=m_Settings.PictureFolder
			RsltLbl.Text = strpctreFldr
		End Sub

		Private Sub PaymentMethodbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PaymentMethodbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			RsltLbl.Text = m_Settings.PaymentMethod
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub

		Private Sub EnterPaymntMthdbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EnterPaymntMthdbtn.Click
			Dim m_Settings As ISettings
			m_Settings = New SettingsClass()
			RsltLbl.Text = ""
			Paymntlbl.Text = ""
			Dim strPaymtMthd As String
			If paymntTxt.Text = "" Then
				Paymntlbl.Text = "Enter the Payment Method"
			Else
				strPaymtMthd=paymntTxt.Text
				m_Settings.PaymentMethod=strPaymtMthd
				Paymntlbl.Text = "Entered the Payment Method successful "
				paymntTxt.Text = ""
			End If
		End Sub
	End Class
End Namespace