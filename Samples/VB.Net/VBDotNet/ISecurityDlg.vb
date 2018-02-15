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
	Partial Public Class ISecurityDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Accesscstmrbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Accesscstmrbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lAcesscstmer As Long
			lAcesscstmer=m_Security.AccessCustomerMenu
			If lAcesscstmer = 1 Then
				Infolist.Items.Add("Have rights to access customer menu")
			ElseIf lAcesscstmer = 0 Then
				Infolist.Items.Add("Access to customer menu is denied")
			End If
		End Sub

		Private Sub Acesssalesbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Acesssalesbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lAcessSals As Long
			lAcessSals = m_Security.AccessSalesMenu
			If lAcessSals = 1 Then
				Infolist.Items.Add("Have rights to access sales menu")
			ElseIf lAcessSals = 0 Then
				Infolist.Items.Add("Access to sales menu is denied")
			End If

		End Sub

		Private Sub AccessSetupbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AccessSetupbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lAcessSetup As Long
			lAcessSetup = m_Security.AccessSetup
			If lAcessSetup = 1 Then
				Infolist.Items.Add("Have rights to access setup")
			ElseIf lAcessSetup = 0 Then
				Infolist.Items.Add("Access to setup is denied")
			End If
		End Sub

		Private Sub Accesstransctnbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Accesstransctnbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lAcessTransaction As Long
			lAcessTransaction = m_Security.AccessTransactionMenu
			If lAcessTransaction = 1 Then
				Infolist.Items.Add("Have rights to access transaction menu")
			ElseIf lAcessTransaction = 0 Then
				Infolist.Items.Add("Access to transaction menu is denied")
			End If
		End Sub

		Private Sub CrntusrLoginbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CrntusrLoginbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim strCurentUsrLogin As String
			strCurentUsrLogin = m_Security.CurrentLoginUser
			If strCurentUsrLogin = "" Then
				Infolist.Items.Add("No current user")
			Else
				Infolist.Items.Add(strCurentUsrLogin)
			End If
		End Sub

		Private Sub Crntusrbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Crntusrbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim strCrntUsrRights As String
			strCrntUsrRights = m_Security.CurrentUserRights
			If strCrntUsrRights = "" Then
				Infolist.Items.Add("No current user rights")
			Else
				Infolist.Items.Add(strCrntUsrRights)
			End If
		End Sub

		Private Sub DatabaseRytbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DatabaseRytbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lDatabseRite As Long
			lDatabseRite = m_Security.DatabaseRight
			If lDatabseRite = 1 Then
				Infolist.Items.Add("Have database right")
			ElseIf lDatabseRite = 0 Then
				Infolist.Items.Add("Database right is denied")
			End If
		End Sub

		Private Sub PrntRptsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrntRptsbtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lPrntrpts As Long
			lPrntrpts = m_Security.PrintReports
			If lPrntrpts = 1 Then
				Infolist.Items.Add("Have print rights")
			ElseIf lPrntrpts = 0 Then
				Infolist.Items.Add("Doesn't have print rights")
			End If
		End Sub

		Private Sub ShpbalBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShpbalBtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim dShpBal As Double
			dShpBal = m_Security.UpdateShopBalance
			Infolist.Items.Add(dShpBal)
		End Sub

		Private Sub VwRptBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VwRptBtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			Infolist.Items.Clear()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Dim lviewRpts As Long
			lviewRpts = m_Security.ViewReports
			If lviewRpts = 1 Then
				Infolist.Items.Add("Have rights to view reports")
			ElseIf lviewRpts = 0 Then
				Infolist.Items.Add("No rights view reports")
			End If
		End Sub

		Private Sub UsrRytBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UsrRytBtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			InfoLbl.Text = ""
			Infolist.Items.Clear()
			Securitylist.Items.Clear()
			Dim strXML As String
			Dim strModule As String
			Dim strLeaf As String
			Dim lUserRyt As Long
			strXML=XMTTxt.Text
			strModule=ModuleTxt.Text
			strLeaf=LeafsecurityTxt.Text
			If (strXML = "") AndAlso (strModule = "") AndAlso (strLeaf = "") Then
				MessageBox.Show("Please the XML Module name,module section and leaf security node name")
			ElseIf strXML = "" Then
				MessageBox.Show("Please enter the XML module name")
			ElseIf strModule = "" Then
				MessageBox.Show("Please enter the module section")
			ElseIf strLeaf = "" Then
				MessageBox.Show("Please enter the leaf security node name")
			Else
				lUserRyt= m_Security.UserRightInfo(strXML, strModule, strLeaf)
				If lUserRyt = 1 Then
					InfoLbl.Text = "Have User Right Info"
				ElseIf lUserRyt = 0 Then
					InfoLbl.Text = "Don't have user right Info"
				End If
			End If

		End Sub

		Private Sub UserBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UserBtn.Click
			Dim m_Security As ISecurity
			m_Security = New SecurityClass()
			InfoLbl.Text = ""
			Securitylist.Items.Clear()
			Infolist.Items.Clear()
			Dim strUserName As String
			Dim strUserSecurity As String=""
			strUserName = UsrNmeTxt.Text
			If strUserName = "" Then
				MessageBox.Show("Please enter the user name")
			Else
				m_Security.GetUserRightsInfo(strUserName, strUserSecurity)
				Securitylist.Items.Add(strUserSecurity)
			End If
		End Sub


	End Class
End Namespace