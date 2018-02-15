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
	Partial Public Class IISmpCommandsDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub

		Private Sub MenuCommandIdbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuCommandIdbtn.Click
			Dim m_ISmpCommands As IISmpCommands
			m_ISmpCommands = New ISmpCommandsClass()
			Dim strSessionId As String
			Dim isessionId As Integer
			Dim icommandId As Integer
			strSessionId = SesonIdTxt.Text
			isessionId = Convert.ToInt32(strSessionId, 10)
			Dim Menustring As String=MenustringTxt.Text
			If Menustring = "" Then
				MessageBox.Show("Please Enter the Valid menu String")
			Else
				icommandId = m_ISmpCommands.MenuCommandID(isessionId, Menustring)
				If icommandId >= 0 Then
					MessageBox.Show(icommandId.ToString())
					CommandIdTxt.Text = icommandId.ToString()
				Else
					MessageBox.Show("Failed to get commandId")
				End If
			End If
		End Sub

		Private Sub GetMenustringTxt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GetMenustringTxt.Click
			Dim m_ISmpCommands As IISmpCommands
			m_ISmpCommands = New ISmpCommandsClass()
			Dim strSessionId As String
			Dim strCommandId As String
			Dim strMenustring As String
			Dim iSessionId As Integer
			Dim iCommandId As Integer
			strSessionId=SesonIdTxt.Text
			strCommandId=CommandIdTxt.Text
			iSessionId=Convert.ToInt32(strSessionId,10)

			If strCommandId="" Then
				MessageBox.Show("First Enter the Menu String")
			Else
				iCommandId = Convert.ToInt32(strCommandId, 10)
				strMenustring=m_ISmpCommands.MenuString(iSessionId, iCommandId)
				MessageBox.Show(strMenustring)
				MenustringTxt.Text = strMenustring
			End If
		End Sub

		Private Sub MenuCommandExbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuCommandExbtn.Click
			Dim m_ISmpCommands As IISmpCommands
			m_ISmpCommands = New ISmpCommandsClass()
			Dim strSessionId As String
			Dim strFunctionName As String
			Dim iMenucommandEx As Integer
			Dim iSessionId As Integer
			strSessionId=SesonIdTxt.Text
			iSessionId=Convert.ToInt32(strSessionId,10)
			strFunctionName=FunctionmeTxt.Text
			If strFunctionName = "" Then
				MessageBox.Show("Enter The Function Name")
			Else
				iMenucommandEx = m_ISmpCommands.MenuCommandEx(iSessionId, strFunctionName)
				If iMenucommandEx >= 0 Then
					MessageBox.Show(iMenucommandEx.ToString())
					CommandExTxt.Text = iMenucommandEx.ToString()
				Else
					MessageBox.Show("Failed to get commandEx")
				End If
			End If
		End Sub

		Private Sub Noofcommandsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Noofcommandsbtn.Click
			Dim m_ISmpCommands As IISmpCommands
			m_ISmpCommands = New ISmpCommandsClass()
			Dim strFunctionName As String
			Dim strSessionId As String
			Dim iSessionId As Integer
			Dim iNoOfcommannds As Integer
			strFunctionName=FunctionmeTxt.Text
			strSessionId=SesonIdTxt.Text
			iSessionId=Convert.ToInt32(strSessionId,10)
			If strFunctionName="" Then
				MessageBox.Show("Enter the function Name")
			Else
				iNoOfcommannds=m_ISmpCommands.NoOfCommands(iSessionId, strFunctionName)
				MessageBox.Show(iNoOfcommannds.ToString())
				NoOfComandsTxt.Text = iNoOfcommannds.ToString()
			End If
		End Sub
	End Class
End Namespace