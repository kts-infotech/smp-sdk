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
	Partial Public Class ISmpViewDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PrintInDosModebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintInDosModebtn.Click
			Dim m_SmpView As ISmpView

			m_SmpView = New SmpViewClass()

			m_SmpView.PrintInDosMode()
		End Sub

		Private Sub PrintReportbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintReportbtn.Click
			Dim m_SmpView As ISmpView

			m_SmpView = New SmpViewClass()

			m_SmpView.PrintReport()
		End Sub
	End Class
End Namespace