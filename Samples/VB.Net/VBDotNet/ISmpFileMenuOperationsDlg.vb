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
	Partial Public Class ISmpFileMenuOperationsDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BackupDatabtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackupDatabtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeBackupDataDlg()
		End Sub

		Private Sub ChangePasswordbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChangePasswordbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeChangePasswordDlg()
		End Sub

		Private Sub ExportReportbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportReportbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeExportReportDlg()
		End Sub

		Private Sub Loginbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Loginbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeLoginDlg()
		End Sub

		Private Sub Logoutbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Logoutbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeLogout()
		End Sub

		Private Sub Exitbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Exitbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeExit()

			Application.Exit()
		End Sub


		Private Sub Printbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Printbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokePrintDlg()
		End Sub

		Private Sub PrintOldReceiptbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintOldReceiptbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokePrintOldReceiptDlg()
		End Sub

		Private Sub PrintPreviewbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintPreviewbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokePrintPreviewDlg()
		End Sub

		Private Sub PrintSetupbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintSetupbtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokePrintSetupDlg()
		End Sub

		Private Sub RestoreDatabtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RestoreDatabtn.Click
			Dim m_SmpFileMenuOperations As ISmpFileMenuOperations

			m_SmpFileMenuOperations = New SmpFileMenuOperationsClass()

			m_SmpFileMenuOperations.InvokeRestoreDataDlg()
		End Sub
	End Class
End Namespace