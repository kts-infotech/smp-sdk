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
	Partial Public Class IGridDlg
		Inherits Form
		Private m_Grid As IGrid
		Private strRow, strRowHieght, strNoOfRow, strNoOfFRow, strCol, strColWidth, strNoOfCol, strNoOfFCol As String
		Private strFontSize, strFont, strFontType, strCellColor, strTxtColor, strHGrid, strVGrid, strCellTxt As String
		Private iReadOnly As Integer

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CancelBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelBtn.Click
			Me.Close()
		End Sub

		Private Sub SetComboValues()
			For i As Integer = 0 To 49
				RowCombo.Items.Add(i)
				URowCombo.Items.Add(i)
				NoOfRowCombo.Items.Add(i)
				NoOfFRowCombo.Items.Add(i)
				RowHieghtCombo.Items.Add(i)
				ColumnCombo.Items.Add(i)
				ColumnWidthCombo.Items.Add(i)
				UColumnCombo.Items.Add(i)
				NoOfColumnCombo.Items.Add(i)
				NoOfFColumnCombo.Items.Add(i)
				FontSizeCombo.Items.Add(i)
			Next i

			FontCombo.Items.Add("Times New Roman")
			FontCombo.Items.Add("Comic Sans MS")
			FontCombo.Items.Add("Verdana")
			FontCombo.Items.Add("Book Antiqua")
			FontCombo.Items.Add("Impact")

			CellColorCombo.Items.Add("RED")
			CellColorCombo.Items.Add("BLUE")
			CellColorCombo.Items.Add("GREEN")

			CellTxtColorCombo.Items.Add("RED")
			CellTxtColorCombo.Items.Add("BLUE")
			CellTxtColorCombo.Items.Add("GREEN")

			FontTypeCombo.Items.Add("Capital")
			FontTypeCombo.Items.Add("Small")

			HGridCombo.Items.Add("TRUE")
			HGridCombo.Items.Add("FALSE")

			VGridCombo.Items.Add("TRUE")
			VGridCombo.Items.Add("FALSE")
		End Sub

		Private Sub IGridDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SetComboValues()
		End Sub

		Private Sub FontChckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles FontChckBox.CheckedChanged
			If FontChckBox.Checked = True Then
				FontCombo.Enabled = True
			Else
				FontCombo.Enabled = False
			End If
		End Sub

		Private Sub FontSizeChckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles FontSizeChckBox.CheckedChanged
			If FontSizeChckBox.Checked = True Then
				FontSizeCombo.Enabled = True
			Else
				FontSizeCombo.Enabled = False
			End If
		End Sub

		Private Sub FontTypChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles FontTypChkBox.CheckedChanged
			If FontTypChkBox.Checked = True Then
				FontTypeCombo.Enabled = True
			Else
				FontTypeCombo.Enabled = False
			End If
		End Sub

		Private Sub CellColorChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CellColorChkBox.CheckedChanged
			If CellColorChkBox.Checked = True Then
				CellTxtColorCombo.Enabled = True
			Else
				CellTxtColorCombo.Enabled = False
			End If
		End Sub

		Private Sub UpdateRowChckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UpdateRowChckBox.CheckedChanged
			If UpdateRowChckBox.Checked = True Then
				URowCombo.Enabled = True
			Else
				URowCombo.Enabled = False
			End If
		End Sub

		Private Sub UpdateColumnChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UpdateColumnChkBox.CheckedChanged
			If UpdateColumnChkBox.Checked = True Then
				UColumnCombo.Enabled = True
			Else
				UColumnCombo.Enabled = False
			End If
		End Sub

		Private Sub InserBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InserBtn.Click

		   ' IGrid m_Grid;
			m_Grid = New GridClass()

			Try
				Dim icolumn As Integer = Convert.ToInt32(UColumnCombo.Text)
				Dim irow As Integer = Convert.ToInt32(URowCombo.Text)

				m_Grid.InsertColumn(icolumn)
				m_Grid.InsertRow(irow)
			Catch EX As Exception
				MessageBox.Show(EX.ToString())
			End Try
		End Sub

		Private Sub DeleteBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteBtn.Click

			m_Grid = New GridClass()

			Try
				Dim irow As Integer = Convert.ToInt32(URowCombo.Text)
				Dim icolumn As Integer = Convert.ToInt32(UColumnCombo.Text)

				m_Grid.DeleteColumn(icolumn)
				m_Grid.DeleteRow(irow)
			Catch EX As Exception
				MessageBox.Show(EX.ToString())
			End Try
		End Sub

		Private Sub GetValues()
			strRow = RowCombo.Text
			strRowHieght = RowHieghtCombo.Text
			strNoOfRow = NoOfRowCombo.Text
			strNoOfFRow = NoOfFRowCombo.Text
			strCol = ColumnCombo.Text
			strColWidth = ColumnWidthCombo.Text
			strNoOfCol = NoOfColumnCombo.Text
			strNoOfFCol = NoOfFColumnCombo.Text
			strFont = FontCombo.Text
			strFontSize = FontSizeCombo.Text
			strFontType = FontTypeCombo.Text
			strCellColor = CellColorCombo.Text
			strCellTxt = CellTextTxt.Text
			strTxtColor = CellTxtColorCombo.Text
			strHGrid = HGridCombo.Text
			strVGrid = VGridCombo.Text
			If ReadOnlyChckBox.Checked = True Then
				iReadOnly = 1
			ElseIf ReadOnlyChckBox.Checked = False Then
				iReadOnly = 0
			End If

		End Sub

		Private Sub OkBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkBtn.Click
			'IGrid m_Grid;
			m_Grid = New GridClass()

			Dim m_Reports As IReports
			m_Reports = New ReportsClass()

			Try
				GetValues()
				m_Grid.ResetGrid()

				m_Grid.ReadOnly = iReadOnly
				m_Grid.NoOfRows = Convert.ToInt32(strNoOfRow)
				m_Grid.NoOfColumns = Convert.ToInt32(strNoOfCol)
				m_Grid.NoOfFixedRows = Convert.ToInt32(strNoOfFRow)
				m_Grid.NoOfFixedColumns = Convert.ToInt32(strNoOfFCol)
				m_Grid.RowHeight(Convert.ToInt32(strRow)) = Convert.ToInt32(strRowHieght)
				m_Grid.ColumnWidth(Convert.ToInt32(strCol)) = Convert.ToInt32(strColWidth)
				If strCellColor = "RED" Then
					m_Grid.CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol)) = Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(255, 0, 0)))
				ElseIf strCellColor = "BLUE" Then
					m_Grid.CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol)) = Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(0, 0, 255)))
				Else
					m_Grid.CellColour(Convert.ToInt32(strRow), Convert.ToInt32(strCol)) = Convert.ToInt32(ColorTranslator.ToOle(Color.FromArgb(0, 255, 0)))
				End If
				m_Grid.UnmergeCells(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(strRow) + 1, Convert.ToInt32(strCol) + 1)
				m_Grid.MergeCells(Convert.ToInt32(strRow), Convert.ToInt32(strCol), Convert.ToInt32(strRow) + 1, Convert.ToInt32(strCol) + 1)

			Catch EX As Exception
				MessageBox.Show(EX.ToString())
			End Try
		End Sub

		Private Sub IGridDlg_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
			m_Grid = Nothing
			Me.Close()
		End Sub



	End Class
End Namespace