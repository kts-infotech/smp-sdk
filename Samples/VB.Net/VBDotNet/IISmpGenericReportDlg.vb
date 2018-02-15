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
	Partial Public Class IISmpGenericReportDlg
		Inherits Form
		Private item1 As ListViewItem
		Private Footer, Header As String
		Private strFRow, strFCol, strFMRow, strFMCol, strFAligment, strHRow, strHCol, strHMRow, strHMCol, strHAligment As String
		Private ColContntName, ColContnt, ColRow, ColColumn, ColMRow, ColMColumn, ColAligment As ColumnHeader

		Public Sub New()

			InitializeComponent()
		End Sub

		Private Sub IISmpGenericReportDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			initialisecombo()
			initialiselist()
		End Sub

		Private Sub GetAttributeValues()

			Footer = FootrTxt.Text
			Header = HeaderTxt.Text
			strFRow = FRowCombo.Text
			strFCol = FColumnCombo.Text
			strFMRow = FMRowCombo.Text
			strFMCol = FColumnCombo.Text
			strFAligment = FAlignmentCombo.Text
			strHRow = HRowCombo.Text
			strHCol = HColumnCombo.Text
			strHMRow = HMRowCombo.Text
			strHMCol = HMColumnCombo.Text
			strHAligment = HAlignmentCombo.Text
		End Sub
		Private Sub initialiselist()
			RsltList.View = View.Details
			ColContntName = RsltList.Columns.Add("Content Name", 100, HorizontalAlignment.Left)
			ColContnt = RsltList.Columns.Add("Content", 100, HorizontalAlignment.Left)
			ColRow = RsltList.Columns.Add("Row", 100, HorizontalAlignment.Left)
			ColColumn = RsltList.Columns.Add("Column", 100, HorizontalAlignment.Left)
			ColMRow = RsltList.Columns.Add("Maximum Row", 100, HorizontalAlignment.Left)
			ColMColumn = RsltList.Columns.Add("Maximum Column", 100, HorizontalAlignment.Left)
			ColAligment = RsltList.Columns.Add("Alignment", 100, HorizontalAlignment.Left)
		End Sub
		Private Sub ClsBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClsBtn.Click
			Me.Close()
		End Sub

		Private Sub initialisecombo()
			For i As Integer = 1 To 100
				HRowCombo.Items.Add(i)
				HColumnCombo.Items.Add(i)
				HMRowCombo.Items.Add(i)
				HMColumnCombo.Items.Add(i)
				FRowCombo.Items.Add(i)
				FColumnCombo.Items.Add(i)
				FMRowCombo.Items.Add(i)
				FMColumnCombo.Items.Add(i)
				CRowCombo.Items.Add(i)
				CColumnCombo.Items.Add(i)
				CMRowsCombo.Items.Add(i)
				CMColumnCombo.Items.Add(i)
			Next i
			HAlignmentCombo.Items.Add("Left")
			HAlignmentCombo.Items.Add("Right")
			HAlignmentCombo.Items.Add("Center")
			FAlignmentCombo.Items.Add("Left")
			FAlignmentCombo.Items.Add("Right")
			FAlignmentCombo.Items.Add("Center")
			CAlignmentCombo.Items.Add("Left")
			CAlignmentCombo.Items.Add("Right")
			CAlignmentCombo.Items.Add("Center")
		End Sub

		Private Sub Adbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Adbtn.Click
			item1 = New ListViewItem(CntnNmeTxt.Text)
			item1.SubItems.Add(CntntTxt.Text)
			item1.SubItems.Add(CRowCombo.Text)
			item1.SubItems.Add(CColumnCombo.Text)
			item1.SubItems.Add(CMRowsCombo.Text)
			item1.SubItems.Add(CMColumnCombo.Text)
			item1.SubItems.Add(CAlignmentCombo.Text)
			RsltList.Items.AddRange(New ListViewItem() { item1})

		End Sub

		Private Sub ShwBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShwBtn.Click
			Dim m_ISmpGenericReport As IISmpGenericReport
			m_ISmpGenericReport = New ISmpGenericReportClass()
			Dim strBContent As String="", strBContentName As String="", strCRow As String="", strCCol As String="", strCMRow As String="", strCMCol As String="", strCAligment As String=""
			GetAttributeValues()
			Try
				m_ISmpGenericReport.AddReportHeading(Convert.ToInt32(strHRow), Convert.ToInt32(strHCol), Convert.ToInt32(strHMRow), Convert.ToInt32(strHMCol), Header, Convert.ToInt32(StringAlignment.Center), 0)
				For i As Integer = 0 To RsltList.Items.Count - 1
					RsltList.Items(i).Selected = True
					If RsltList.Items(i).Selected = True Then
						strBContentName = RsltList.Items(i).SubItems(0).Text
						strBContent = RsltList.Items(i).SubItems(1).Text
						strCRow = RsltList.Items(i).SubItems(2).Text
						strCCol = RsltList.Items(i).SubItems(3).Text
						strCMRow = RsltList.Items(i).SubItems(4).Text
						strCMCol = RsltList.Items(i).SubItems(5).Text
						strCAligment = RsltList.Items(i).SubItems(6).Text
					End If

					m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol), strBContentName, Right, 1)
					m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol) + 1, strBContent, Right, 1)
				Next i
				m_ISmpGenericReport.AddFooterContents(Convert.ToInt32(strFRow), Convert.ToInt32(strFCol), Convert.ToInt32(strFMRow), Convert.ToInt32(strFMCol), Footer, Convert.ToInt32(StringAlignment.Center), 0)
				m_ISmpGenericReport.FillReport()
			Catch EX As Exception
				MessageBox.Show(EX.ToString())
			End Try
		End Sub

		Private Sub RmvBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RmvBtn.Click

			For i As Integer = 0 To RsltList.Items.Count - 1
				If RsltList.Items(i).Selected Then
					RsltList.Items(i).Remove()
					i -= 1
				End If
			Next i

		End Sub

		Private Sub ClrBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClrBtn.Click
			CntnNmeTxt.Text = ""
			CntntTxt.Text = ""
			CRowCombo.Text = ""
			CColumnCombo.Text = ""
			CMRowsCombo.Text = ""
			CMColumnCombo.Text = ""
			CAlignmentCombo.Text = ""
		End Sub


	End Class
End Namespace