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
	Partial Public Class ISmpReportDlg
		Inherits Form
		Private m_SmpReport As ISmpReport
		Private strFont As String
		Private strFooterHeading1 As String
		Private strFooterHeading2 As String
		Private strFooterHeading3 As String
		Private strMainHeading1 As String
		Private strSubHeading1 As String
		Private strMainHeading2 As String
		Private strSubHeading2 As String
		Private strImagePath As String
		Private isize As Integer
		Private icolor As Integer

		Public Sub New()
			m_SmpReport = New SmpReportClass()
			InitializeComponent()
		End Sub
		Protected Overrides Sub Finalize()
			m_SmpReport = Nothing
			Dispose(True)
		End Sub

		Private Sub selectitemcombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles selectitemcombo.SelectedIndexChanged

			If selectitemcombo.Text = "" Then
				FontLbl.Visible = False
				FontTxt.Visible = False
				SizeTxt.Visible = False
				SizeLbl.Visible = False
				ColourLbl.Visible = False
				ColourTxt.Visible = False
				Subheading2Lbl.Visible = False
				Subheading2Txt.Visible = False
				ImagePathLbl.Visible = False
				ImagePathTxt.Visible = False
			ElseIf selectitemcombo.Text = "Body Format" Then

				FontLbl.Visible = True
				FontTxt.Visible = True
				SizeTxt.Visible = True
				SizeLbl.Visible = True
				ColourLbl.Visible = True
				ColourTxt.Visible = True
				FontLbl.Text = "Font"
				SizeLbl.Text = "Size"
				ColourLbl.Text = "Colour"
				FontTxt.Text = "Arial"
				SizeTxt.Text = "12"
				ColourTxt.Text = "0"

			ElseIf selectitemcombo.Text = "Footer Format" Then
				FontLbl.Visible = True
				FontTxt.Visible = True
				SizeTxt.Visible = True
				SizeLbl.Visible = True
				ColourLbl.Visible = True
				ColourTxt.Visible = True
				FontLbl.Text = "Font"
				SizeLbl.Text = "Size"
				ColourLbl.Text = "Colour"
				FontTxt.Text = "Arial"
				SizeTxt.Text = "12"
				ColourTxt.Text = "0"

			ElseIf selectitemcombo.Text = "Footer Info" Then
				FontLbl.Visible = True
				FontTxt.Visible = True
				SizeTxt.Visible = True
				SizeLbl.Visible = True
				ColourLbl.Visible = True
				ColourTxt.Visible = True
				FontTxt.Text = ""
				SizeTxt.Text = ""
				ColourTxt.Text = ""
				FontLbl.Text = "Footer1"
				SizeLbl.Text = "Footer2"
				ColourLbl.Text = "Footer3"

			ElseIf selectitemcombo.Text = "Header Format" Then
				FontLbl.Visible = True
				FontTxt.Visible = True
				SizeTxt.Visible = True
				SizeLbl.Visible = True
				ColourLbl.Visible = True
				ColourTxt.Visible = True
				FontLbl.Text = "Font"
				SizeLbl.Text = "Size"
				ColourLbl.Text = "Colour"
				FontTxt.Text = "Arial"
				SizeTxt.Text = "12"
				ColourTxt.Text = "0"

			ElseIf selectitemcombo.Text = "Header Info" Then
				FontLbl.Visible = True
				FontTxt.Visible = True
				SizeTxt.Visible = True
				SizeLbl.Visible = True
				ColourLbl.Visible = True
				ColourTxt.Visible = True
				Subheading2Lbl.Visible = True
				Subheading2Txt.Visible = True
				ImagePathLbl.Visible = True
				ImagePathTxt.Visible = True
				FontTxt.Text = ""
				SizeTxt.Text = ""
				ColourTxt.Text = ""
				FontLbl.Text = "Main Heading1"
				SizeLbl.Text = "sub Heading1"
				ColourLbl.Text = "Main Heading2"

			End If
		End Sub

		Private Sub ResetallBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetallBtn.Click
			FontTxt.Text = ""
			SizeTxt.Text = ""
			ColourTxt.Text = ""
			Subheading2Txt.Text = ""
			ImagePathTxt.Text = ""
			MessageBox.Show("All data cleared")
		End Sub

		Private Sub Cancelbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancelbtn.Click
			selectitemcombo.Text = ""
		End Sub

		Private Sub Savebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Savebtn.Click

			If selectitemcombo.Text = "" Then
				MessageBox.Show("Select an item")
			ElseIf selectitemcombo.Text = "Body Format" Then
				strFont = FontTxt.Text
				isize = Convert.ToInt32(SizeTxt.Text,10)
				icolor = Convert.ToInt32(ColourTxt.Text,10)
				m_SmpReport.SetBodyFormat(strFont,isize,icolor)
				MessageBox.Show("Added Successfully")
			ElseIf selectitemcombo.Text = "Footer Format" Then
				strFont = FontTxt.Text
				isize = Convert.ToInt32(SizeTxt.Text,10)
				icolor = Convert.ToInt32(ColourTxt.Text,10)
				m_SmpReport.SetFooterFormat(strFont,isize,icolor)
				MessageBox.Show("Added Successfully")
			ElseIf selectitemcombo.Text = "Footer Info" Then
				strFooterHeading1=FontTxt.Text
				strFooterHeading2=SizeTxt.Text
				strFooterHeading3=ColourTxt.Text
				m_SmpReport.SetFooterInfo(strFooterHeading1, strFooterHeading2, strFooterHeading3)
				MessageBox.Show("Added Successfully")
			ElseIf selectitemcombo.Text = "Header Format" Then
				strFont = FontTxt.Text
				isize = Convert.ToInt32(SizeTxt.Text,10)
				icolor = Convert.ToInt32(ColourTxt.Text,10)
				m_SmpReport.SetHeaderFormat(strFont,isize,icolor)
				MessageBox.Show("Added Successfully")
			ElseIf selectitemcombo.Text = "Header Info" Then
				strMainHeading1=FontTxt.Text
				strSubHeading1=SizeTxt.Text
				strMainHeading2=ColourTxt.Text
				strSubHeading2=Subheading2Txt.Text
				strImagePath=ImagePathTxt.Text
				FontTxt.Text = ""
				SizeTxt.Text =""
				ColourTxt.Text = ""
				m_SmpReport.SetHeaderInfo(strMainHeading1,strSubHeading1,strMainHeading2,strSubHeading2,strImagePath)
				MessageBox.Show("Added Successfully")
			End If
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub

		Private Sub adtabltbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles adtabltbtn.Click
			Dim strTable As String
			strTable = Selecttablecombo.Text
			If Selecttablecombo.Text = "" Then
				MessageBox.Show("Enter the table name")
			Else

				Selecttablecombo.Items.Add(strTable)
			End If
		End Sub


		Private Sub Generaterptbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Generaterptbtn.Click
			 Dim strQuery As String=Selecttablecombo.Text
			If Selecttablecombo.Text = "" Then
				MessageBox.Show("Select an table")
			Else
				If selectitemcombo.Text = "Body Format" Then

					m_SmpReport.GetBodyFormat(strFont, isize, icolor)
				ElseIf selectitemcombo.Text = "Footer Format" Then

					m_SmpReport.GetFooterFormat(strFont, isize, icolor)
				ElseIf selectitemcombo.Text = "Footer Info" Then

					m_SmpReport.GetFooterInfo(strFooterHeading1, strFooterHeading2, strFooterHeading3)
				ElseIf selectitemcombo.Text = "Header Format" Then

					m_SmpReport.GetHeaderFormat(strFont, isize, icolor)
				ElseIf selectitemcombo.Text = "Header Info" Then

					m_SmpReport.GetHeaderInfo(strMainHeading1, strSubHeading1, strMainHeading2, strSubHeading2, strImagePath)
				End If
				m_SmpReport.FillReport(strQuery)
			End If
		End Sub

		Private Sub prntrptbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles prntrptbtn.Click

			m_SmpReport.PrintReport()
		End Sub

		Private Sub ISmpReportDlg_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
			m_SmpReport = Nothing
			Me.Dispose()
		End Sub
	End Class
End Namespace