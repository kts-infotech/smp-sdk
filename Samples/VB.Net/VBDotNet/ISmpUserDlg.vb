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
	Partial Public Class ISmpUserDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub loginbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loginbtn.Click
			Dim m_SmpUser As ISmpUser

			m_SmpUser = New SmpUserClass()

			m_SmpUser.InvokeLoginUserDlg()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim m_SmpUser As ISmpUser

			m_SmpUser = New SmpUserClass()

			m_SmpUser.InvokeChangePasswordDlg()
		End Sub
	End Class
End Namespace