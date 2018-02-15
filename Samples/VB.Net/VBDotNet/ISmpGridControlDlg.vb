Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports SalesMatePlusLib

Public Class ISmpGridControlDlg
    Private m_Grid As IGrid
    Private m_PluginTab As SmpPluginTab
    Private m_SmpGridCtrl As ISmpGridCtrl

    Dim strImagePath As String = ""
    Public DT_CENTER As Integer = 1
    Public DT_RIGHT As Integer = 2
    Public DT_WORDBREAK As Integer = 10
    Public DT_LEFT As Integer = 0
    Public DT_NOCLIP As Integer = 100
    Public DT_TOP As Integer = 0


    Private Sub ISmpGridControlDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox_BUSINESS_LOGO_ROW.SelectedIndex = 0
        ComboBox_BUSINESS_LOGO_COLUMN.SelectedIndex = 0
        ComboBox_CELL_TEXT_WRAP_ROW.SelectedIndex = 0
        ComboBox_CELL_TEXT_WRAP_COLUMN.SelectedIndex = 0
        ComboBox_CELL_TEXT_ALIGNMENT_ROW.SelectedIndex = 0
        ComboBox_CELL_TEXT_ALIGNMENT_COLUMN.SelectedIndex = 0
        ComboBox_IMAGE_FROM_FILE_SELECT_ROW.SelectedIndex = 0
        ComboBox_IMAGE_FROM_FILE_SELECT_COLUMN.SelectedIndex = 0
        ComboBox_SET_CELL_IMAGE_FROM_RESOURCE_ROW.SelectedIndex = 0
        ComboBox_SET_CELL_IMAGE_FROM_RESOURCE_COLUMN.SelectedIndex = 0
        ComboBox_SET_CELL_TEXT_ROW.SelectedIndex = 0
        ComboBox_SET_CELL_TEXT_COLUMN.SelectedIndex = 0

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
      

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button_BUSINESS_LOGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_BUSINESS_LOGO.Click
        Try
            m_Grid = New GridClass()
            m_PluginTab = New SmpPluginTab()
            m_SmpGridCtrl = New SmpGridCtrlClass()
            m_SmpGridCtrl.DeleteAllItems()

            m_Grid.NoOfColumns = 15
            m_Grid.NoOfRows = 10

            Dim row As Integer
            Dim col As Integer

            row = Convert.ToInt32(ComboBox_BUSINESS_LOGO_ROW.SelectedItem)
            col = Convert.ToInt32(ComboBox_BUSINESS_LOGO_COLUMN.SelectedItem)
            m_SmpGridCtrl.SetBusinessLogo(row, col, 150, 45)
            m_Grid.RowHeight(row) = 60
            m_Grid.ColumnWidth(col) = 160
            m_PluginTab.SetCurrentView(0)

        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub Button_SET_CELL_TEXT_WRAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_CELL_TEXT_WRAP.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        Dim row As Integer
        Dim col As Integer

        row = Convert.ToInt32(ComboBox_BUSINESS_LOGO_ROW.SelectedItem)
        col = Convert.ToInt32(ComboBox_BUSINESS_LOGO_COLUMN.SelectedItem)
        m_SmpGridCtrl.SetCellText(row, col, "KTS Infotech", 1)
        m_SmpGridCtrl.SetCellTextWrap(row, col, 2)
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_SET_DEFAULT_COLUMN_WIDTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_DEFAULT_COLUMN_WIDTH.Click
        Try
            m_Grid = New GridClass()
            m_SmpGridCtrl = New SmpGridCtrlClass()
            m_PluginTab = New SmpPluginTab()
            Dim iColumnWidth As Integer

            m_SmpGridCtrl.DeleteAllItems()
            m_Grid.NoOfColumns = 15
            m_Grid.NoOfRows = 10
            iColumnWidth = Convert.ToInt32(TextBox_COLUMN_WIDTH.Text)
            m_SmpGridCtrl.SetDefaultColumnWidth(iColumnWidth)
            m_PluginTab.SetCurrentView(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try
        


    End Sub

    Private Sub Button_SET_ALIGNMENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_ALIGNMENT.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        Dim row As Integer
        Dim col As Integer

        row = Convert.ToInt32(ComboBox_CELL_TEXT_ALIGNMENT_ROW.SelectedItem)
        col = Convert.ToInt32(ComboBox_CELL_TEXT_ALIGNMENT_COLUMN.SelectedItem)
        m_SmpGridCtrl.SetCellText(row, col, "KTS Infotech", 1)
        m_SmpGridCtrl.SetCellTextAlignment(row, col, 1)
        m_PluginTab.SetCurrentView(0)
    End Sub

    Private Sub Button_IMAGE_FROM_FILE_BROWSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_IMAGE_FROM_FILE_BROWSE.Click
        strImagePath = String.Empty

        'open file dialog   
        Dim open As New OpenFileDialog
        'image filters  
        open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then

            If File.Exists(open.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                strImagePath = open.FileName
            End If
        End If

    End Sub

    Private Sub Button_SET_CELL_IMAGE_FROM_FILE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_CELL_IMAGE_FROM_FILE.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()
        Dim row As Integer
        Dim col As Integer

        m_SmpGridCtrl.DeleteAllItems()

        If strImagePath = String.Empty Then
            MessageBox.Show("Please select an image")
            Return
        End If

        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        row = Convert.ToInt32(ComboBox_IMAGE_FROM_FILE_SELECT_ROW.SelectedItem)
        col = Convert.ToInt32(ComboBox_IMAGE_FROM_FILE_SELECT_COLUMN.SelectedItem)
        m_SmpGridCtrl.SetCellImage(row, col, strImagePath, 50, 30)
        m_Grid.RowHeight(row) = 70
        m_Grid.ColumnWidth(col) = 100
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_CELL_IMAGE_FROM_RESOURCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CELL_IMAGE_FROM_RESOURCE.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        Dim row As Integer
        Dim col As Integer

        row = Convert.ToInt32(ComboBox_SET_CELL_IMAGE_FROM_RESOURCE_ROW.SelectedItem)
        col = Convert.ToInt32(ComboBox_SET_CELL_IMAGE_FROM_RESOURCE_COLUMN.SelectedItem)
        'm_SmpGridCtrl.SetCellImageEx(row, col,)
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_SET_CELL_TEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_CELL_TEXT.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()
        Dim strEditText As String
        Dim row As Integer
        Dim col As Integer

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10
        
        strEditText = TextBox_EDIT_CELL_TEXT.Text.ToString()
        row = Convert.ToInt32(ComboBox_SET_CELL_TEXT_ROW.SelectedItem)
        col = Convert.ToInt32(ComboBox_SET_CELL_TEXT_COLUMN.SelectedItem)
        m_SmpGridCtrl.SetCellText(row, col, strEditText, 1)
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_SET_ROW_HEIGHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_ROW_HEIGHT.Click
        Try
            m_Grid = New GridClass()
            m_SmpGridCtrl = New SmpGridCtrlClass()
            m_PluginTab = New SmpPluginTab()
            Dim iRowHeight As Integer

            m_SmpGridCtrl.DeleteAllItems()
            m_Grid.NoOfColumns = 15
            m_Grid.NoOfRows = 10
            iRowHeight = Convert.ToInt32(TextBox_EDIT_ROW_HEIGHT.Text)
            m_SmpGridCtrl.SetDefaultRowHeight(iRowHeight)
            m_PluginTab.SetCurrentView(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        

    End Sub

    Private Sub ButtonSetWordWrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetWordWrap.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        m_SmpGridCtrl.SetWordWrapMode(10)
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_SET_GRID_DISPLAY_READ_ONLY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SET_GRID_DISPLAY_READ_ONLY.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        m_SmpGridCtrl.SetGridDisplayReadOnly(1)
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_AUTO_SIZE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AUTO_SIZE.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        m_SmpGridCtrl.SetCellText(2, 2, "KTS Infotech", 1)
        m_SmpGridCtrl.AutoSize()
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_DELETE_ALL_IMAGES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DELETE_ALL_IMAGES.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass()
        m_PluginTab = New SmpPluginTab()

        m_SmpGridCtrl.DeleteAllItems()
        m_Grid.NoOfColumns = 15
        m_Grid.NoOfRows = 10

        'm_SmpGridCtrl.DeleteAllImages()
        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_DELETE_ALL_ITEMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DELETE_ALL_ITEMS.Click
        
        m_SmpGridCtrl.DeleteAllItems()
        m_PluginTab.SetCurrentView(0)
    End Sub

    Private Sub Button_REFRESH_CONTROL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_REFRESH_CONTROL.Click
        m_SmpGridCtrl.RefreshCtrl()

    End Sub

    Private Sub Button_CREATE_BASIC_REPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CREATE_BASIC_REPORT.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass
        m_SmpGridCtrl.DeleteAllItems()

        m_Grid.HorizondalGridLine = 3
        Dim strShopName, strShopAddress, strShopCity, strShopPhone, strShopGSTIN, strCustomerId As String
        Dim strSupplyStateName As String

        Dim strCustomer As String = ""
        Dim strConsumerState As String = ""
        Dim bHSNCodeAvailable As Boolean = False

        Dim strTaxInfoCheck As String = "False"

        strShopName = "KTS INFOTECH"
        strShopAddress = "Pala"
        strShopCity = "Kottayam"
        strShopPhone = "123456789"
        strShopGSTIN = "32GST1233HF"
        strCustomerId = "Gopu"

        Dim HeaderRows As Integer = 12
        Dim ContentRows As Integer = 0
        Dim FooterRows As Integer = 12

        Dim TotalRows As Integer = HeaderRows + ContentRows + FooterRows
        Dim MaxNoOfCoumns As Integer = 10

        Dim iHeaderRowIndex, strSupplyStateID As Integer

        m_Grid.NoOfRows = HeaderRows + ContentRows + FooterRows
        m_Grid.NoOfColumns = MaxNoOfCoumns
        'Put the column width
           
        For i As Integer = 0 To MaxNoOfCoumns - 1
            m_Grid.ColumnWidth(i) = 25
        Next
        m_Grid.ReadOnly = 0

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 2

        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 25


        m_Grid.RowHeight(iHeaderRowIndex) = 35


        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, strShopName, DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 0
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 15
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, "PRINT TYPE", DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 0
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 30

        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, (strShopAddress + strShopCity + ", Phone: " + strShopPhone), DT_CENTER Or DT_WORDBREAK)

        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 15
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, ("GSTIN: " + strShopGSTIN), DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 25
        m_Grid.RowHeight(iHeaderRowIndex) = 27
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, "Tax Invoice", DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        'Gap
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 1
        iHeaderRowIndex = iHeaderRowIndex + 1
        'End Gap

        'Header Text first row
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4)
        m_Grid.CellText(iHeaderRowIndex, 0) = "Invoice No: 10"
        m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9)
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 4, "Date: 05/10/2017", DT_RIGHT Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1
        strSupplyStateID = 32
        strSupplyStateName = "Kerala"

        'Header Text second row
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4)
        m_Grid.CellText(iHeaderRowIndex, 0) = "Billed To: Rajeev"

        m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9)
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 4, ("State: " + strSupplyStateName), DT_RIGHT Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        'Header Text third row
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 4)
        m_Grid.CellText(iHeaderRowIndex, 0) = "GSTIN: 07AIFPR5898G2ZL"

        m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex, 9)
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 4, "State Code: 32", DT_RIGHT Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        'GAP
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 1
        iHeaderRowIndex = iHeaderRowIndex + 1
        'End GAP
        'Now set the Item Headers
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex + 1, 2)
        m_Grid.ColumnWidth(0) = 80
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, "Item Name", DT_CENTER Or DT_WORDBREAK)

        m_Grid.MergeCells(iHeaderRowIndex, 3, iHeaderRowIndex + 1, 3)
        m_Grid.ColumnWidth(3) = 30
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 3, "Qty", DT_CENTER Or DT_WORDBREAK)

        m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex + 1, 5)
        m_Grid.ColumnWidth(4) = 40
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 4, "Rate", DT_CENTER Or DT_WORDBREAK)


        m_Grid.MergeCells(iHeaderRowIndex, 6, iHeaderRowIndex + 1, 6)
        m_Grid.ColumnWidth(6) = 30
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 6, "Tax %", DT_CENTER Or DT_WORDBREAK)

        m_Grid.MergeCells(iHeaderRowIndex, 7, iHeaderRowIndex + 1, 9)
        m_Grid.ColumnWidth(7) = 30
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 7, "Taxable Amount", DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1
        Dim fTotal, fSubTotal, fSGSTTotalTaxAmt, fCGSTTotalTaxAmt As Double

        Dim iContentRowIndex As Integer = iHeaderRowIndex + 1

        m_Grid.NoOfRows = (HeaderRows + 5 + FooterRows)
        m_Grid.NoOfColumns = MaxNoOfCoumns

        Dim iIndex As Integer = 0

        Dim iRowHeight As Integer = 45
        m_Grid.RowHeight(iContentRowIndex) = iRowHeight

        m_Grid.MergeCells(iContentRowIndex, 0, iContentRowIndex, 2)
        m_SmpGridCtrl.SetCellText(iContentRowIndex, 0, "Salesmate +", DT_LEFT Or DT_WORDBREAK)

        m_Grid.RowHeight(iContentRowIndex) = iRowHeight
        m_SmpGridCtrl.SetCellText(iContentRowIndex, 3, "1", DT_LEFT Or DT_WORDBREAK)

        m_Grid.MergeCells(iContentRowIndex, 4, iContentRowIndex, 5)
        m_Grid.RowHeight(iContentRowIndex) = iRowHeight
        m_SmpGridCtrl.SetCellText(iContentRowIndex, 4, "105", DT_RIGHT Or DT_WORDBREAK)


        m_Grid.RowHeight(iContentRowIndex) = iRowHeight
        m_SmpGridCtrl.SetCellText(iContentRowIndex, 6, "28", DT_RIGHT Or DT_WORDBREAK)

        m_Grid.MergeCells(iContentRowIndex, 7, iContentRowIndex, 9)
        m_Grid.RowHeight(iContentRowIndex) = iRowHeight
        m_SmpGridCtrl.SetCellText(iContentRowIndex, 7, "105", DT_RIGHT Or DT_WORDBREAK)

        Dim fTotalItemDiscount, fIGSTTotalTaxAmt As Double
        'GET TAX DETAILS

        fTotalItemDiscount = 1000000000
        fSGSTTotalTaxAmt = 405
        fCGSTTotalTaxAmt = 405
        fIGSTTotalTaxAmt = 0

        fSubTotal = 10620
        iContentRowIndex = iContentRowIndex + 1
        iIndex = iIndex + 1
        Dim iFooterIndex As Integer = 0
        Dim fDiscount As Integer = 0
        Dim fTotalCessAmount As Integer = 0
        Dim fHandlingCharges As Integer = 0

        If fDiscount = 0 Then

            iFooterIndex = iFooterIndex + 1
        End If

        If fHandlingCharges = 0 Then

            iFooterIndex = iFooterIndex + 1
        End If

        If (True) Then

            iFooterIndex = iFooterIndex + 1
            If (fTotalCessAmount <= 0) Then

                iFooterIndex = iFooterIndex + 1
            End If

            m_Grid.NoOfRows = (iContentRowIndex + FooterRows - iFooterIndex)
            fTotal = fSubTotal + fSGSTTotalTaxAmt + fCGSTTotalTaxAmt + fTotalCessAmount + fHandlingCharges - (fDiscount)


        Else

            iFooterIndex = iFooterIndex + 2
            If (fTotalCessAmount <= 0) Then

                iFooterIndex = iFooterIndex + 1
            End If

            m_Grid.NoOfRows = (iContentRowIndex + FooterRows - iFooterIndex)


        End If
        m_Grid.NoOfColumns = (MaxNoOfCoumns)
        iIndex = 0
        Dim iFooterStartIndex As Integer = iContentRowIndex
        'Now the Amount Section
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
        m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "Sub Total"

        m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "105.00", DT_RIGHT Or DT_WORDBREAK)
        iIndex = iIndex + 1

        'CGST
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
        m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "CGST"
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)

        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "14.70", DT_RIGHT Or DT_WORDBREAK)
        iIndex = iIndex + 1

        'SGST
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
        m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "SGST"
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "14.70", DT_RIGHT Or DT_WORDBREAK)
        iIndex = iIndex + 1

        'CESS
        If (fTotalCessAmount > 0) Then

            m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
            m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "Cess"
            m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)



            m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "300", DT_RIGHT Or DT_WORDBREAK)
            iIndex = iIndex + 1
        End If

        'Handling Charges

        m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
        m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "Handling Charges"
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "0.00", DT_RIGHT Or DT_WORDBREAK)
        iIndex = iIndex + 1

        'Discount
        'Total Tax Amount after Tax
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 3, iFooterStartIndex + iIndex, 6)
        m_Grid.CellText(iFooterStartIndex + iIndex, 3) = "Total Invoice"
        m_Grid.MergeCells(iFooterStartIndex + iIndex, 7, iFooterStartIndex + iIndex, 9)
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 7, "134.40", DT_RIGHT Or DT_WORDBREAK)
        iIndex = iIndex + 1

        m_Grid.MergeCells(16, 0, 20, 2)

        m_Grid.MergeCells(iFooterStartIndex + iIndex, 0, iFooterStartIndex + iIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iFooterStartIndex + iIndex, 0) = 20
        m_Grid.RowHeight(iFooterStartIndex + iIndex) = 27
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 0, "BILL AMOUNT: 134.40/-", DT_CENTER Or DT_WORDBREAK)
        iIndex = iIndex + 1


        m_Grid.MergeCells(iFooterStartIndex + iIndex, 0, iFooterStartIndex + iIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iFooterStartIndex + iIndex, 0) = 13
        m_Grid.RowHeight(iFooterStartIndex + iIndex) = 20
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 0, "Cashier Name: KTS InfoTech", DT_CENTER Or DT_WORDBREAK)
        iIndex = iIndex + 1


        m_Grid.RowHeight(iFooterStartIndex + iIndex) = 35

        m_Grid.MergeCells(iFooterStartIndex + iIndex, 0, iFooterStartIndex + iIndex, MaxNoOfCoumns - 1)
        m_SmpGridCtrl.SetCellText(iFooterStartIndex + iIndex, 0, "Thank You Visit Again", DT_CENTER Or DT_WORDBREAK)
        iIndex = iIndex + 1

        m_PluginTab.SetCurrentView(0)

    End Sub

    Private Sub Button_CREATE_DETAIL_REPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CREATE_DETAIL_REPORT.Click
        m_Grid = New GridClass()
        m_SmpGridCtrl = New SmpGridCtrlClass
        m_SmpGridCtrl.DeleteAllItems()

        m_Grid.HorizondalGridLine = 3

        Dim HeaderRows As Integer = 17
        Dim ContentRows As Integer = 10
        Dim FooterRows As Integer = 20


        Dim iHeaderRowIndex As Integer = 0

        Dim TotalRows As Integer = HeaderRows + ContentRows + FooterRows

        Dim MaxNoOfCoumns As Integer = 15

        Dim fHandlingCharges, fSalesDiscAmount, fGrantTotal As Double



        Dim strShopName, strShopAddress, strShopCity, strShopPhone, strShopGSTIN, strCustomerId, strCustomerName, strCustomerAddress As String
        Dim strCustomerGSTIN As String = ""
        Dim strShopBankAccountNo, strShopBankIFSC As String

        Dim bUseLogo As Boolean = True

        m_Grid.NoOfRows = (HeaderRows + ContentRows + FooterRows)

        m_Grid.NoOfColumns = (MaxNoOfCoumns)

        'Put the Column width
        For i As Integer = 0 To MaxNoOfCoumns - 1
            m_Grid.ColumnWidth(i) = 60
        Next

        strShopName = "KTS INFOTECH"
        strShopAddress = "Pala"
        strShopCity = "Kottayam"
        strShopPhone = "123456789"
        strShopGSTIN = "32GST1233HF"
        strShopBankAccountNo = "570123456789"
        strShopBankIFSC = "SBIN000000"

        Dim strPayType, strSalesDate, strConsumerState As String
        Dim fGrUnitprice As Double = 0
        Dim fGrQuantity As Double = 0
        Dim fGrGrossValue As Double = 0
        Dim fGrCashDisc As Double = 0
        Dim fGrTaxAmount As Double = 0
        Dim fGrTotal As Double = 0
        Dim fNetAmtWithoutTax As Double = 0
        Dim fTotalSGST As Double = 0
        Dim fTotalCGST As Double = 0
        Dim fTotalIGST As Double = 0
        Dim fTotalGST As Double = 0
        Dim fTotalCess As Double = 0
        Dim strShopStateName, strShopStateID, strShopStateTin As String


        strSalesDate = "10/05/2017"

        strCustomerId = "Gopu"

        fHandlingCharges = 10
        'strHandlingCharges.Format(_T("%0.2f"),fHandlingCharges)

        fSalesDiscAmount = 10

        strPayType = "Cash"

        fGrantTotal = 1000



        strConsumerState = "Kerala"

        strShopStateTin = "123456"
        strShopStateID = "32"
        strShopStateName = "Kerala"

        'Get shipping datails
        Dim strReverseCharge As String = "No"
        Dim strTransMode As String = ""
        Dim strVehicleNo As String = ""
        Dim strSupplyStateTin, strSupplyStateID, strSupplyStateName As String

        strSupplyStateTin = "12345"
        strSupplyStateID = "32"
        strSupplyStateName = "Kerala"
        Dim strFirstName, strLastName As String
        strFirstName = "KTS"
        strLastName = "Infotech"
        strCustomerAddress = "Pala"
        strCustomerName = strFirstName + " " + strLastName

        'Get Customer GSTIN


        'Put all report data Read Only
        m_SmpGridCtrl.SetGridDisplayReadOnly(0)

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 40
        m_Grid.RowHeight(iHeaderRowIndex) = 44
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, strShopName, DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 0
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 25
        m_Grid.RowHeight(iHeaderRowIndex) = 27
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, (strShopAddress + ", " + strShopCity + ", Mobile: " + strShopPhone), DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 21

        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, "Header Text", DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 0
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 25
        m_Grid.RowHeight(iHeaderRowIndex) = 27
        m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 0, "GSTIN : 32fghb2544", DT_CENTER Or DT_WORDBREAK)
        iHeaderRowIndex = iHeaderRowIndex + 1

        Try
            m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex + 1, 1)
            m_Grid.MergeCells(iHeaderRowIndex, 2, iHeaderRowIndex + 1, 11)
            m_Grid.MergeCells(iHeaderRowIndex, 12, iHeaderRowIndex + 1, MaxNoOfCoumns - 1)

            'Put The logo
            m_SmpGridCtrl.SetBusinessLogo(iHeaderRowIndex, 0, 150, 45)
            m_Grid.RowHeight(iHeaderRowIndex) = 27
            'Set the Invoice Text
            m_Grid.CellFontSize(iHeaderRowIndex, 2) = 38
            '//m_Grid.set_CellTextColour(iHeaderRowIndex,2,RGB(0,0,255))
            m_SmpGridCtrl.SetCellText(iHeaderRowIndex, 2, "", DT_CENTER Or DT_WORDBREAK)
            m_Grid.CellText(iHeaderRowIndex, 13) = "Duplicate"
            m_Grid.CellFontSize(iHeaderRowIndex, 12) = 25
            m_Grid.CellText(iHeaderRowIndex, 12) = ""

        Catch ex As Exception

        End Try



        iHeaderRowIndex += 2
        'Gap
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 1
        iHeaderRowIndex = iHeaderRowIndex + 1

        'End Gap
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 1)
        m_Grid.CellText(iHeaderRowIndex, 0) = ("Reverse Charge : " + strReverseCharge)
        m_Grid.MergeCells(iHeaderRowIndex, 2, iHeaderRowIndex, 5)
        m_Grid.CellText(iHeaderRowIndex, 2) = "Invoice No : 10 "

        m_Grid.MergeCells(iHeaderRowIndex, 6, iHeaderRowIndex, 8)
        m_Grid.CellText(iHeaderRowIndex, 6) = ("Invoice Date : " + strSalesDate)


        m_Grid.MergeCells(iHeaderRowIndex, 9, iHeaderRowIndex, 11)
        m_Grid.CellText(iHeaderRowIndex, 9) = ("State : " + strShopStateName)

        m_Grid.MergeCells(iHeaderRowIndex, 12, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellText(iHeaderRowIndex, 12) = ("State Code : " + strShopStateID)
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 1)
        m_Grid.CellText(iHeaderRowIndex, 0) = "Transporation Mode : cash"
        m_Grid.MergeCells(iHeaderRowIndex, 2, iHeaderRowIndex, 5)
        m_Grid.CellText(iHeaderRowIndex, 2) = ("Vehicle No : " + strVehicleNo)
        m_Grid.MergeCells(iHeaderRowIndex, 6, iHeaderRowIndex, 8)
        m_Grid.CellText(iHeaderRowIndex, 6) = ("Date Of Supply : " + strSalesDate)

        m_Grid.MergeCells(iHeaderRowIndex, 9, iHeaderRowIndex, 11)
        m_Grid.CellText(iHeaderRowIndex, 9) = ("Place Of supply : " + strSupplyStateName)

        m_Grid.MergeCells(iHeaderRowIndex, 12, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellText(iHeaderRowIndex, 12) = ("State Code : " + strSupplyStateID)
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 1
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 7)
        m_Grid.CellFontSize(iHeaderRowIndex, 0) = 25
        m_Grid.RowHeight(iHeaderRowIndex) = 25
        m_Grid.CellText(iHeaderRowIndex, 0) = "Details Of The Receiver | Billed To"

        m_Grid.MergeCells(iHeaderRowIndex, 8, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellFontSize(iHeaderRowIndex, 8) = 25
        m_Grid.CellText(iHeaderRowIndex, 8) = "Details Of The Consignee | Shipped To"
        iHeaderRowIndex = iHeaderRowIndex + 1


        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 7)
        m_Grid.CellText(iHeaderRowIndex, 0) = ("Name        : " + strCustomerName)

        m_Grid.MergeCells(iHeaderRowIndex, 8, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellText(iHeaderRowIndex, 8) = ("Name        : " + strCustomerName)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 7)
        m_Grid.CellText(iHeaderRowIndex, 0) = ("Address    : " + strCustomerAddress)

        m_Grid.MergeCells(iHeaderRowIndex, 8, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellText(iHeaderRowIndex, 8) = ("Address    : " + strCustomerAddress)
        iHeaderRowIndex = iHeaderRowIndex + 1

        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, 2)
        m_Grid.CellText(iHeaderRowIndex, 0) = ("GSTIN : " + strCustomerGSTIN)

        m_Grid.MergeCells(iHeaderRowIndex, 3, iHeaderRowIndex, 4)
        m_Grid.CellText(iHeaderRowIndex, 3) = ("State : " + strSupplyStateName)
        m_Grid.MergeCells(iHeaderRowIndex, 5, iHeaderRowIndex, 7)
        m_Grid.CellText(iHeaderRowIndex, 5) = ("State Code : " + strSupplyStateID)

        m_Grid.MergeCells(iHeaderRowIndex, 8, iHeaderRowIndex, 10)
        m_Grid.CellText(iHeaderRowIndex, 8) = ("GSTIN : " + strCustomerGSTIN)

        m_Grid.MergeCells(iHeaderRowIndex, 11, iHeaderRowIndex, 12)
        m_Grid.CellText(iHeaderRowIndex, 11) = ("State : " + strSupplyStateName)
        m_Grid.MergeCells(iHeaderRowIndex, 13, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.CellText(iHeaderRowIndex, 13) = ("State Code : " + strSupplyStateID)
        iHeaderRowIndex = iHeaderRowIndex + 1

        Dim strIncludeHSN As String = "False"
        Dim bHSNCodeAvailable As Boolean = False

        bHSNCodeAvailable = True

        'Now demarcate the next area
        'GAP
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 10
        '///m_Grid.set_CellColour (iHeaderRowIndex,0,(long)RGB(0,0,0));
        iHeaderRowIndex = iHeaderRowIndex + 1
        'End GAP
        'Now set the Item Headers
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex + 1, 0)
        m_Grid.ColumnWidth(0) = 45
        m_Grid.CellText(iHeaderRowIndex, 0) = "Sr.No."

        m_Grid.MergeCells(iHeaderRowIndex, 1, iHeaderRowIndex + 1, 1)
        m_Grid.ColumnWidth(1) = 150
        m_Grid.CellText(iHeaderRowIndex, 1) = "Name of Product / Service"

        If (bHSNCodeAvailable) Then

            m_Grid.MergeCells(iHeaderRowIndex, 2, iHeaderRowIndex + 1, 2)
            m_Grid.CellText(iHeaderRowIndex, 2) = "HSN"

        Else

            m_Grid.MergeCells(iHeaderRowIndex, 2, iHeaderRowIndex + 1, 2)
            m_Grid.CellText(iHeaderRowIndex, 2) = "Item ID"
        End If



        m_Grid.MergeCells(iHeaderRowIndex, 3, iHeaderRowIndex + 1, 3)
        m_Grid.ColumnWidth(3) = 40
        m_Grid.CellText(iHeaderRowIndex, 3) = "Qty"

        m_Grid.MergeCells(iHeaderRowIndex, 4, iHeaderRowIndex + 1, 4)
        m_Grid.ColumnWidth(4) = 70
        m_Grid.CellText(iHeaderRowIndex, 4) = "Rate"

        m_Grid.MergeCells(iHeaderRowIndex, 5, iHeaderRowIndex + 1, 5)
        m_Grid.ColumnWidth(5) = 75
        m_Grid.CellText(iHeaderRowIndex, 5) = "Amount"

        m_Grid.MergeCells(iHeaderRowIndex, 6, iHeaderRowIndex + 1, 6)
        m_Grid.CellText(iHeaderRowIndex, 6) = "Discount"

        m_Grid.MergeCells(iHeaderRowIndex, 7, iHeaderRowIndex + 1, 7)
        m_Grid.ColumnWidth(7) = 80
        m_Grid.CellText(iHeaderRowIndex, 7) = "Taxable Value"
        'CGST
        m_Grid.MergeCells(iHeaderRowIndex, 8, iHeaderRowIndex, 9)
        m_SmpGridCtrl.SetCellTextAlignment(14, 8, DT_CENTER)
        m_Grid.CellText(iHeaderRowIndex, 8) = "SGST"
        m_Grid.CellText(iHeaderRowIndex + 1, 8) = "Rate"
        m_Grid.CellText(iHeaderRowIndex + 1, 9) = "Amount"

        'SGST
        m_Grid.MergeCells(iHeaderRowIndex, 10, iHeaderRowIndex, 11)
        m_SmpGridCtrl.SetCellTextAlignment(iHeaderRowIndex, 10, DT_CENTER)
        m_Grid.CellText(iHeaderRowIndex, 10) = "CGST"
        m_Grid.CellText(iHeaderRowIndex + 1, 10) = "Rate"
        m_Grid.CellText(iHeaderRowIndex + 1, 11) = "Amount"

        'IGST
        m_Grid.MergeCells(iHeaderRowIndex, 12, iHeaderRowIndex, 13)
        m_SmpGridCtrl.SetCellTextAlignment(iHeaderRowIndex, 12, DT_CENTER)
        m_Grid.CellText(iHeaderRowIndex, 12) = "IGST"
        m_Grid.CellText(iHeaderRowIndex + 1, 12) = "Rate"
        m_Grid.CellText(iHeaderRowIndex + 1, 13) = "Amount"

        'Total
        m_Grid.MergeCells(iHeaderRowIndex, 14, iHeaderRowIndex + 1, 14)
        m_Grid.ColumnWidth(14) = 85
        m_Grid.CellText(iHeaderRowIndex, 14) = "Total"
        iHeaderRowIndex += 2
        'Gap
        m_Grid.MergeCells(iHeaderRowIndex, 0, iHeaderRowIndex, MaxNoOfCoumns - 1)
        m_Grid.RowHeight(iHeaderRowIndex) = 1


        Try


            Dim strLargestItemName As String = ""
            Dim strLargestItemID As String = ""
            Dim iTempRow, iTempCol, iTranCount As Integer



            Dim iFooterStartIndex As Integer = 0
            iTempRow = HeaderRows + 1
            iTranCount = 0
            iTempCol = 0




            m_SmpGridCtrl.SetCellText(20, 0, "1", DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 1, "Salemate +", DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 2, "1234", DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 3, "2", DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)

            m_SmpGridCtrl.SetCellText(20, 4, "2500", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 5, "5000", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            m_SmpGridCtrl.SetCellText(20, 6, "500", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 7, "4500", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 8, "9", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 9, "405", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 10, "9", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 11, "405", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(20, 14, "5310", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(1, 7, "23", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(2, 3, "2", DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(2, 4, "25", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(2, 5, "25", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(2, 6, "2", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            m_SmpGridCtrl.SetCellText(2, 7, "23", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            'Calculate SGST,CGST,IGST rate and amount
           

            iFooterStartIndex = 25
            m_Grid.MergeCells(iFooterStartIndex, 0, iFooterStartIndex, MaxNoOfCoumns - 1)
            m_Grid.RowHeight(iFooterStartIndex) = 1

            iFooterStartIndex = iFooterStartIndex + 1
            m_Grid.MergeCells(iFooterStartIndex, 0, iFooterStartIndex, 8)
            m_Grid.CellText(iFooterStartIndex, 0) = "Total Invoice Amount in Words:"


            m_Grid.MergeCells(iFooterStartIndex + 1, 0, iFooterStartIndex + 6, 8)
            m_Grid.CellFontSize(iFooterStartIndex + 1, 0) = 30
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 1, 0, "Ten thousand six hundred and twenty six only", DT_WORDBREAK)

            'Now the Amount Section
            m_Grid.MergeCells(iFooterStartIndex, 9, iFooterStartIndex, 12)
            m_Grid.CellText(iFooterStartIndex, 9) = "Total Amount Before Tax"
            m_Grid.MergeCells(iFooterStartIndex, 13, iFooterStartIndex, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex, 13, "4500", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'CGST
            m_Grid.MergeCells(iFooterStartIndex + 1, 9, iFooterStartIndex + 1, 12)
            m_Grid.CellText(iFooterStartIndex + 1, 9) = "Add : CGST"
            m_Grid.MergeCells(iFooterStartIndex + 1, 13, iFooterStartIndex + 1, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 1, 13, "405", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            'SGST
            m_Grid.MergeCells(iFooterStartIndex + 2, 9, iFooterStartIndex + 2, 12)
            m_Grid.CellText(iFooterStartIndex + 2, 9) = "Add : SGST"
            m_Grid.MergeCells(iFooterStartIndex + 2, 13, iFooterStartIndex + 2, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 2, 13, "405", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
            'IGST
            m_Grid.MergeCells(iFooterStartIndex + 3, 9, iFooterStartIndex + 3, 12)
            m_Grid.CellText(iFooterStartIndex + 3, 9) = "Add : IGST"
            m_Grid.MergeCells(iFooterStartIndex + 3, 13, iFooterStartIndex + 3, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 3, 13, "0", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'CESS amount GST
            m_Grid.MergeCells(iFooterStartIndex + 4, 9, iFooterStartIndex + 4, 12)
            m_Grid.CellText(iFooterStartIndex + 4, 9) = "CESS (+)"
            m_Grid.MergeCells(iFooterStartIndex + 4, 13, iFooterStartIndex + 4, 14)

            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 4, 13, "0", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'Discount amount 
            m_Grid.MergeCells(iFooterStartIndex + 5, 9, iFooterStartIndex + 5, 12)
            m_Grid.CellText(iFooterStartIndex + 5, 9) = "Handling/Transportation  Charges (+) "
            m_Grid.MergeCells(iFooterStartIndex + 5, 13, iFooterStartIndex + 5, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 5, 13, "0", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'Handling/Transportation  Charges:

            m_Grid.MergeCells(iFooterStartIndex + 6, 9, iFooterStartIndex + 6, 12)
            m_Grid.CellText(iFooterStartIndex + 6, 9) = "Total Discount (-) "
            m_Grid.MergeCells(iFooterStartIndex + 6, 13, iFooterStartIndex + 6, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 6, 13, "1000", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'Total Tax Amount after Tax
            m_Grid.MergeCells(iFooterStartIndex + 7, 9, iFooterStartIndex + 7, 12)
            m_Grid.CellFontSize(iFooterStartIndex + 7, 9) = 25
            m_Grid.CellFontSize(iFooterStartIndex + 7, 13) = 25
            m_Grid.RowHeight(iFooterStartIndex + 7) = 30
            m_Grid.CellText(iFooterStartIndex + 7, 9) = "Grant Total"
            m_Grid.MergeCells(iFooterStartIndex + 7, 13, iFooterStartIndex + 7, 14)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 7, 13, "10620", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            'Last Footer Area



            'Payment Type
            m_Grid.MergeCells(iFooterStartIndex + 7, 0, iFooterStartIndex + 7, 2)
            m_Grid.CellText(iFooterStartIndex + 7, 0) = "Payment Type"
            m_Grid.MergeCells(iFooterStartIndex + 7, 3, iFooterStartIndex + 7, 6)
            m_Grid.CellText(iFooterStartIndex + 7, 3) = "Payment Type"


            'Add Bank details
            m_Grid.MergeCells(iFooterStartIndex + 8, 0, iFooterStartIndex + 8, 6)
            m_Grid.CellText(iFooterStartIndex + 8, 0) = "Bank details"
            'Bank Account Number
            m_Grid.MergeCells(iFooterStartIndex + 9, 0, iFooterStartIndex + 9, 2)
            m_Grid.CellText(iFooterStartIndex + 9, 0) = "Bank Account Number"
            m_Grid.MergeCells(iFooterStartIndex + 9, 3, iFooterStartIndex + 9, 6)
            m_Grid.CellText(iFooterStartIndex + 9, 3) = "67012548223"
            'Bank Branch IfSC
            m_Grid.MergeCells(iFooterStartIndex + 10, 0, iFooterStartIndex + 10, 2)
            m_Grid.CellText(iFooterStartIndex + 10, 0) = "Bank Branch IFSC"
            m_Grid.MergeCells(iFooterStartIndex + 10, 3, iFooterStartIndex + 10, 6)
            m_Grid.CellText(iFooterStartIndex + 10, 3) = "SBIN0700001"
            'Terms and Conditions

            m_Grid.MergeCells(iFooterStartIndex + 11, 0, iFooterStartIndex + 14, 6)
            m_SmpGridCtrl.SetCellText(iFooterStartIndex + 11, 0, "Terms and Conditions:\n     ", DT_TOP Or DT_LEFT Or DT_NOCLIP Or DT_WORDBREAK)

            m_Grid.MergeCells(iFooterStartIndex + 7, 7, iFooterStartIndex + 14, 8)
            m_Grid.CellText(iFooterStartIndex + 7, 7) = "Office Seal"

            m_Grid.MergeCells(iFooterStartIndex + 8, 9, iFooterStartIndex + 8, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 8, 9) = "GST Payable On Reverse Charge "
            m_Grid.MergeCells(iFooterStartIndex + 8, 13, iFooterStartIndex + 8, MaxNoOfCoumns - 1)
            If (strReverseCharge = "Yes") Then

                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 1, 0, " strDigiWords", DT_WORDBREAK)

                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 7, 13, "9000", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 8, 13, "1620", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            Else

                m_Grid.CellText(iFooterStartIndex + 8, 13) = "N/A"
            End If

            'Certified
            m_Grid.MergeCells(iFooterStartIndex + 9, 9, iFooterStartIndex + 9, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 9, 9) = "Certified that the particulars given above are true and correct."

            m_Grid.MergeCells(iFooterStartIndex + 10, 9, iFooterStartIndex + 10, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 10, 9) = ("For, " + strShopName)

            m_Grid.MergeCells(iFooterStartIndex + 11, 9, iFooterStartIndex + 13, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 11, 9) = "Authorized Signatory :"

            'Display Operator Name

            m_Grid.MergeCells(iFooterStartIndex + 14, 9, iFooterStartIndex + 14, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 14, 9) = "Operator Name "
            m_Grid.MergeCells(iFooterStartIndex + 14, 13, iFooterStartIndex + 14, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 14, 13) = "KTS InfoTech"


            m_Grid.MergeCells(iFooterStartIndex + 8, 9, iFooterStartIndex + 8, MaxNoOfCoumns - 1)


            m_Grid.MergeCells(iFooterStartIndex + 9, 9, iFooterStartIndex + 9, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 9, 9) = "GST Payable On Reverse Charge "
            m_Grid.MergeCells(iFooterStartIndex + 9, 13, iFooterStartIndex + 9, MaxNoOfCoumns - 1)
            If (strReverseCharge = "Yes") Then


                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 1, 0, "Five THousand", DT_WORDBREAK)

                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 7, 13, "9000", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)
                m_SmpGridCtrl.SetCellText(iFooterStartIndex + 9, 13, "1620", DT_RIGHT Or DT_NOCLIP Or DT_WORDBREAK)

            Else

                m_Grid.CellText(iFooterStartIndex + 9, 13) = "N/A"
            End If


            m_Grid.MergeCells(iFooterStartIndex + 10, 9, iFooterStartIndex + 10, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 10, 9) = "Certified that the particulars given above are true and correct."

            m_Grid.MergeCells(iFooterStartIndex + 11, 9, iFooterStartIndex + 11, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 11, 9) = (("For, ") + strShopName)

            m_Grid.MergeCells(iFooterStartIndex + 12, 9, iFooterStartIndex + 14, MaxNoOfCoumns - 1)
            m_Grid.CellText(iFooterStartIndex + 12, 9) = "Authorized Signatory :"

            m_Grid.MergeCells(iFooterStartIndex + 15, 0, iFooterStartIndex + 15, 6)

            m_Grid.MergeCells(iFooterStartIndex + 15, 7, iFooterStartIndex + 15, MaxNoOfCoumns - 1)

            m_Grid.MergeCells(TotalRows - 5, 0, TotalRows - 2, MaxNoOfCoumns - 1)
            m_SmpGridCtrl.SetCellText(TotalRows - 5, 0, "Thank You Visit Again", DT_CENTER Or DT_NOCLIP Or DT_WORDBREAK)

            m_PluginTab.SetCurrentView(0)




        Catch ex As Exception



        End Try




    End Sub
End Class