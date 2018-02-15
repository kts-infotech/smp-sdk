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
	Partial Public Class IReportsDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Aditinalinfobtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Aditinalinfobtn.CheckedChanged
			If Aditinalinfobtn.Checked = True Then
				HeadingTxt.Enabled = True
				AddHeadingTxt.Enabled = True
				CaptionTxt.Enabled = False
			End If
		End Sub

		Private Sub Withcaptionbtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Withcaptionbtn.CheckedChanged
			If Withcaptionbtn.Checked = True Then
				HeadingTxt.Enabled = False
				AddHeadingTxt.Enabled = False
				CaptionTxt.Enabled = True
			End If
		End Sub

		Private Sub NormalBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NormalBtn.CheckedChanged
			If NormalBtn.Checked = True Then
				HeadingTxt.Enabled = False
				AddHeadingTxt.Enabled = False
				CaptionTxt.Enabled = False
			End If
		End Sub

		Private Sub AdTableBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdTableBtn.Click
			Dim strAdTable As String
			strAdTable=Tablecombo.Text
			If strAdTable = "" Then
				MessageBox.Show("Enter The table name")
			Else
				Tablecombo.Items.Add(strAdTable)
				MessageBox.Show("Added Sucessfully")
				strAdTable = ""
			End If
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub

		Private Sub Reportbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Reportbtn.Click
			Dim m_Reports As IReports
			m_Reports = New ReportsClass()
			Dim strQuery As String
			strQuery=Tablecombo.Text
			If strQuery="" Then
				MessageBox.Show("Enter the table name")
			ElseIf NormalBtn.Checked = True Then
				m_Reports.FillReport(strQuery)
			ElseIf Withcaptionbtn.Checked = True Then
				Dim strCaption As String
				strCaption = CaptionTxt.Text
				If strCaption = "" Then
					MessageBox.Show("Please enter the caption")
				Else
					m_Reports.FillReportWithCaption(strQuery, strCaption)
				End If
			ElseIf Aditinalinfobtn.Checked = True Then
				Dim strHeading As String
				Dim strAdheading As String
				Dim bshowheader As Integer=1
				Dim bshowfooter As Integer=1
				strHeading=HeadingTxt.Text
				strAdheading=AddHeadingTxt.Text
				If strHeading = "" Then
					MessageBox.Show("Enter the Heading")
				ElseIf strAdheading = "" Then
					MessageBox.Show("Enter the additional Heading")
				ElseIf (strAdheading = "") AndAlso (strHeading = "") Then
					MessageBox.Show("Enter the Heading and Additional Heading")
				Else
					m_Reports.FillReportEx(strQuery, strHeading, strAdheading, bshowheader, bshowfooter)
				End If
			End If
		End Sub

	End Class
End Namespace