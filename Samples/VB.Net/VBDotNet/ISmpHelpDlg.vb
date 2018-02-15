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
	Partial Public Class ISmpHelpDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub TipOfTheDayDlgbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TipOfTheDayDlgbtn.Click
			Dim m_SmpHelp As ISmpHelp

			m_SmpHelp = New SmpHelpClass()

			m_SmpHelp.InvokeTipOfTheDayDlg()
		End Sub


		Private Sub InvokeRegisterbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InvokeRegisterbtn.Click
			Dim m_SmpHelp As ISmpHelp

			m_SmpHelp = New SmpHelpClass()

			m_SmpHelp.InvokeRegisterDlg()
		End Sub

		Private Sub AboutBoxbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutBoxbtn.Click
			Dim m_SmpHelp As ISmpHelp

			m_SmpHelp = New SmpHelpClass()

			m_SmpHelp.InvokeAboutBoxDlg()
		End Sub

		Private Sub HelTopicsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HelTopicsbtn.Click
			Dim m_SmpHelp As ISmpHelp

			m_SmpHelp = New SmpHelpClass()

			Dim strHlpFliPath As String

			strHlpFliPath = m_SmpHelp.HelpFilePath

			m_SmpHelp.InvokeHelpTopics(strHlpFliPath)
		End Sub

		Private Sub MenuShortcutKeybtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuShortcutKeybtn.Click
			Dim m_SmpHelp As ISmpHelp

			m_SmpHelp = New SmpHelpClass()

			m_SmpHelp.InvokeMenuShortcutKeyDlg()
		End Sub
	End Class
End Namespace