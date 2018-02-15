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

	Partial Public Class ISmpAppDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub GetWindowbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Windowbtn.Click
			'ISmpApp m_ISmpApp;
			'm_ISmpApp = new SmpAppClass();
			'int iWindowHandle;
			'iWindowHandle = m_ISmpApp.WindowHandle;
			'IntPtr ipwindowhandle;
			'ipwindowhandle = (IntPtr)iWindowHandle;

			'Handle hTest;
			'hTest = (Handle)ipwindowhandle;
			'Control cwinhadl;
			'string test;
			'cwinhadl = FromHandle(ipwindowhandle);
			'test = cwinhadl.Text;
			'windowTxt.Text = test;
			'cwinhadl = Control.FromHandle(ipwindowhandle);

			'MessageBox.Show(cwinhadl.Text);


		End Sub


		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SendStatusbtn.Click
			Dim m_SmpApp As ISmpApp
			m_SmpApp = New SmpAppClass()
			Dim strSendStatus As String
			strSendStatus = SendStatusTxt.Text
			If strSendStatus = "" Then
				MessageBox.Show("Enter the status")
			Else

				m_SmpApp.SendStatus(strSendStatus)
			End If
		End Sub

		Private Sub setaddininfobtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setaddininfobtn.Click
			'ISmpApp m_SmpApp;
			'm_SmpApp = new SmpAppClass();
			'm_SmpApp.
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub

		Private Sub AddinSecurityinfotxt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddinSecurityinfotxt.Click
			'ISmpApp m_SmpApp;
			'm_SmpApp = new SmpAppClass();
			'int isessionId;
			'm_SmpApp.
		End Sub

	End Class
End Namespace