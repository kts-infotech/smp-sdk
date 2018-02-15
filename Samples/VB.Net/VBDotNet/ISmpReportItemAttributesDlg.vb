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
	Partial Public Class ISmpReportItemAttributesDlg
		Inherits Form
		Private item1 As ListViewItem
		Private ColContentName, ColContent, ColRow, ColMRow, ColColumn, ColMColumn, ColAlignment, ColFontSize As ColumnHeader
		Private strHeader, strHRow, strHMRow, strHCol, strHMCol, strHAlignment, strHFont, strHFontColor, strHFontSize As String
		Private strFooter, strFRow, strFMRow, strFCol, strFMCol, strFAlignment, strFFont, strFFontColor, strFFontSize As String

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ClsBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClsBtn.Click
			Me.Close()

		End Sub

		Private Sub GetAttributes()
			strHeader = HeaderTxt.Text
			strHRow = HRowCombo.Text
			strHMRow = HMRowCombo.Text
			strHCol = HColCombo.Text
			strHMCol = HMColCombo.Text
			strHAlignment = HAlignmentCombo.Text
			strHFont = HFontCombo.Text
			strHFontColor = HFontColorCombo.Text
			strHFontSize = HFontSizeCombo.Text
			strFooter = Footertxt.Text
			strFRow = FRowCombo.Text
			strFCol = FColCombo.Text
			strFMRow = FMRowCombo.Text
			strFMCol = FMColCombo.Text
			strFAlignment = FAlignmentCombo.Text
			strFFont = FFontCombo.Text
			strFFontColor = FFontColorCombo.Text
			strFFontSize = FFontSizeCombo.Text
		End Sub

		Private Sub InitialiseCombo()
			For count As Integer = 0 To 49
				HRowCombo.Items.Add(count)
				HColCombo.Items.Add(count)
				HMRowCombo.Items.Add(count)
				HMColCombo.Items.Add(count)
				HFontSizeCombo.Items.Add(count)
				FRowCombo.Items.Add(count)
				FColCombo.Items.Add(count)
				FMColCombo.Items.Add(count)
				FMRowCombo.Items.Add(count)
				FFontSizeCombo.Items.Add(count)
				CRowCombo.Items.Add(count)
				CColCombo.Items.Add(count)
				CMRowCombo.Items.Add(count)
				CMColCombo.Items.Add(count)
				CFontSizeCombo.Items.Add(count)
			Next count
			HFontCombo.Items.Add("Times New Roman")
			HFontCombo.Items.Add("Comic Sans MS")
			HFontCombo.Items.Add("Verdana")
			HFontCombo.Items.Add("Book Antiqua")
			HFontCombo.Items.Add("Impact")

			FFontCombo.Items.Add("Times New Roman")
			FFontCombo.Items.Add("Comic Sans MS")
			FFontCombo.Items.Add("Verdana")
			FFontCombo.Items.Add("Book Antiqua")
			FFontCombo.Items.Add("Impact")

			HFontColorCombo.Items.Add("RED")
			HFontColorCombo.Items.Add("BLUE")
			HFontColorCombo.Items.Add("GREEN")

			FFontColorCombo.Items.Add("RED")
			FFontColorCombo.Items.Add("BLUE")
			FFontColorCombo.Items.Add("GREEN")

			HAlignmentCombo.Items.Add("RIGHT")
			HAlignmentCombo.Items.Add("LEFT")
			HAlignmentCombo.Items.Add("CENTER")

			FAlignmentCombo.Items.Add("RIGHT")
			FAlignmentCombo.Items.Add("LEFT")
			FAlignmentCombo.Items.Add("CENTER")

			CAlignmentCombo.Items.Add("RIGHT")
			CAlignmentCombo.Items.Add("LEFT")
			CAlignmentCombo.Items.Add("CENTER")
		End Sub

		Private Sub InitialiseList()
			RsltList.View = View.Details
			ColContentName = RsltList.Columns.Add("Content Name", 100, HorizontalAlignment.Left)
			ColContent = RsltList.Columns.Add("Content", 100, HorizontalAlignment.Left)
			ColRow = RsltList.Columns.Add("Row", 100, HorizontalAlignment.Left)
			ColColumn = RsltList.Columns.Add("Column", 100, HorizontalAlignment.Left)
			ColMRow = RsltList.Columns.Add("Maximum Row", 100, HorizontalAlignment.Left)
			ColMColumn = RsltList.Columns.Add("Maximum Column", 100, HorizontalAlignment.Left)
			ColAlignment = RsltList.Columns.Add("Alignment", 100, HorizontalAlignment.Left)
			ColFontSize = RsltList.Columns.Add("Font Size", 100, HorizontalAlignment.Left)
		End Sub

		Private Sub ISmpReportItemAttributesDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitialiseCombo()
			InitialiseList()
		End Sub

		Private Sub AdBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdBtn.Click
			item1 = New ListViewItem(ContentNmeTxt.Text)
			item1.SubItems.Add(ContentTxt.Text)
			item1.SubItems.Add(CRowCombo.Text)
			item1.SubItems.Add(CColCombo.Text)
			item1.SubItems.Add(CMRowCombo.Text)
			item1.SubItems.Add(CMColCombo.Text)
			item1.SubItems.Add(CAlignmentCombo.Text)
			item1.SubItems.Add(CFontSizeCombo.Text)
			RsltList.Items.AddRange(New ListViewItem() {item1})
		End Sub

		Private Sub ClrBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClrBtn.Click
			ContentNmeTxt.Text = ""
			ContentTxt.Text = ""
			CRowCombo.Text = ""
			CColCombo.Text = ""
			CMRowCombo.Text = ""
			CMColCombo.Text = ""
			CAlignmentCombo.Text = ""
			CFontSizeCombo.Text = ""
		End Sub

		Private Sub RmvBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RmvBtn.Click
			For i As Integer = 0 To RsltList.Items.Count - 1
				If RsltList.Items(i).Selected Then
					RsltList.Items(i).Remove()
					i -= 1
				End If
			Next i
		End Sub



		Private Sub ShwBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShwBtn.Click
			GetAttributes()

			Dim strHeaderFont As String = "Monotype Corsiva"
			Dim strFooterFont As String = "Verdana"
			Dim strContentName, strContent, strCRow, strCMRow, strCCol, strCMCol, strCAligment As String

			Dim m_ISmpGenericReport As IISmpGenericReport
			m_ISmpGenericReport = New ISmpGenericReportClass()

			Dim m_SmpReportItemAttributes_Body As ISmpReportItemAttributes
			m_SmpReportItemAttributes_Body = New SmpReportItemAttributesClass()

			Dim m_SmpReportItemAttributes_Header As ISmpReportItemAttributes
			m_SmpReportItemAttributes_Header = New SmpReportItemAttributesClass()

			Dim m_SmpReportItemAttributes_Footer As ISmpReportItemAttributes
			m_SmpReportItemAttributes_Footer = New SmpReportItemAttributesClass()

			Dim m_Item_Header As IItem
			m_Item_Header = New ItemClass()

			Dim m_ItemHeader As Item
			m_ItemHeader = New Item()

			Dim m_ItemFooter As Item
			m_ItemFooter = New Item()

			Dim m_Item_Footer As IItem
			m_Item_Footer = New ItemClass()

			Try
				m_Item_Header.Content = strHeader
				m_Item_Header.ContentType = 0
				m_Item_Header.Col = Convert.ToInt32(strHCol)
				m_Item_Header.HAlign = Convert.ToInt32(StringAlignment.Center)
				m_Item_Header.MaxCol = Convert.ToInt32(strHMCol)
				m_Item_Header.MaxRow = Convert.ToInt32(strHMRow)
				m_Item_Header.Row = Convert.ToInt32(strHRow)

				m_Item_Footer.Col = Convert.ToInt32(strFCol)
				m_Item_Footer.Content = strFooter
				m_Item_Footer.ContentType = 0
				m_Item_Footer.HAlign = Convert.ToInt32(StringAlignment.Center)
				m_Item_Footer.MaxCol = Convert.ToInt32(strFMCol)
				m_Item_Footer.MaxRow = Convert.ToInt32(strFMRow)
				m_Item_Footer.Row = Convert.ToInt32(strFRow)

				'Header Properties

				If strHFontColor = "RED" Then
					m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0)))

				ElseIf strHFontColor = "BLUE" Then
					m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)))
				Else
					m_SmpReportItemAttributes_Header.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0)))
				End If
				If HBoldCheckBox.Checked = True Then
					m_SmpReportItemAttributes_Header.HeadingBold = 1
				End If
				m_SmpReportItemAttributes_Header.HeadingFont = strHeaderFont
				m_SmpReportItemAttributes_Header.HeadingFontSize = Convert.ToInt32(strHFontSize)
				m_SmpReportItemAttributes_Header.ItemCount = 5
				m_SmpReportItemAttributes_Header.set_Item(0, m_ItemHeader)

				'Body Properties
				If CBoldCheckBox.Checked = True Then
					m_SmpReportItemAttributes_Body.NormalBold = 1
				End If
				m_SmpReportItemAttributes_Body.NormalFontSize = 20
				If CItalicsCombo.Checked = True Then
					m_SmpReportItemAttributes_Body.NormalItalic = 1
				End If
				If CShowheadingCheckBox.Checked = True Then
					m_SmpReportItemAttributes_Body.ShowHeading = 1
				End If

				'Footer Properties
				If strFFontColor = "RED" Then
					m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0)))
				ElseIf strFFontColor = "BLUE" Then
					m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)))
				Else
					m_SmpReportItemAttributes_Footer.ForgroundColor = Convert.ToUInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0)))
				End If
				If FBoldCheckBox.Checked = True Then
					m_SmpReportItemAttributes_Footer.FooterBold = 1
				End If
				m_SmpReportItemAttributes_Footer.FooterFont = strFooterFont
				m_SmpReportItemAttributes_Footer.FooterFontSize = Convert.ToInt32(strFFontSize)
				m_SmpReportItemAttributes_Footer.ItemCount = 5
				m_SmpReportItemAttributes_Footer.set_Item(0, m_ItemFooter)

				m_ISmpGenericReport.HeaderProperties = CType(m_SmpReportItemAttributes_Header, SmpReportItemAttributes)
				m_ISmpGenericReport.BodyProperties = CType(m_SmpReportItemAttributes_Body, SmpReportItemAttributes)
				m_ISmpGenericReport.FooterProperties = CType(m_SmpReportItemAttributes_Footer, SmpReportItemAttributes)

				m_ISmpGenericReport.AddReportHeading(m_Item_Header.Row, m_Item_Header.Col, m_Item_Header.MaxRow, m_Item_Header.MaxCol, m_Item_Header.Content, m_Item_Header.HAlign, m_Item_Header.ContentType)

				For icount As Integer = 0 To RsltList.Items.Count - 1
					RsltList.Items(icount).Selected = True
					If RsltList.Items(icount).Selected = True Then
						strContentName = RsltList.Items(icount).SubItems(0).Text
						strContent = RsltList.Items(icount).SubItems(1).Text
						strCRow = RsltList.Items(icount).SubItems(2).Text
						strCCol = RsltList.Items(icount).SubItems(3).Text
						strCMRow = RsltList.Items(icount).SubItems(4).Text
						strCMCol = RsltList.Items(icount).SubItems(5).Text
						strCAligment = RsltList.Items(icount).SubItems(6).Text

						m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol), strContentName, Right, 1)
						m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol) + 1, strContent, Right, 1)
					End If
				Next icount

				m_ISmpGenericReport.AddFooterContents(m_Item_Footer.Row, m_Item_Footer.Col, m_Item_Footer.MaxRow, m_Item_Footer.MaxCol, m_Item_Footer.Content, m_Item_Footer.HAlign, m_Item_Footer.ContentType)

				m_ISmpGenericReport.FillReport()
			Catch EX As Exception
				MessageBox.Show(EX.ToString())
			End Try

		End Sub
	End Class
End Namespace