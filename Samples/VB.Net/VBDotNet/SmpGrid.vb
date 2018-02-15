Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib
Public Class SmpGridDlg


    Private m_SmpGrid As SmpGrid
    Private m_SmpGridCtrl As SmpGridCtrl
    Private m_SmpPluginTab As SmpPluginTab
    Private m_IGrid As IGrid

    Public Sub New()

        InitializeComponent()
        m_SmpGrid = New SmpGridClass()
        m_IGrid = New GridClass()
        m_SmpPluginTab = New SmpPluginTab()
        m_SmpGridCtrl = New SmpGridCtrlClass()
    End Sub



    Private Sub ButtonAutoSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAutoSize.Click
        ' IGrid m_Grid;
        'm_Grid = New SmpGridCtrlClass()
        Try

        
            Dim icolumn As Integer = 2
            Dim irow As Integer = 4


            m_IGrid.NoOfColumns = 5
            m_IGrid.NoOfRows = 100

            m_SmpGrid.AutoSize()


            m_SmpPluginTab.SetCurrentView(0)
            
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ButtonSet_Auto_Size_Style_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSet_Auto_Size_Style.Click
        Dim icolumn As Integer = 2
        Dim irow As Integer = 4


        m_IGrid.NoOfColumns = 5
        m_IGrid.NoOfRows = 100


        m_SmpGridCtrl.SetCellText(3, 2, "test", 5)
        m_SmpGrid.SetAutoSizeStyle(48)

        m_SmpPluginTab.SetCurrentView(0)

    End Sub

    Private Sub ButtonSet_FocusCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSet_FocusCell.Click
        Dim icolumn As Integer = 2
        Dim irow As Integer = 4
        m_IGrid.NoOfColumns = 5
        m_IGrid.NoOfRows = 100
        m_SmpGrid.SetFocusCell(3, 3)
        m_SmpPluginTab.SetCurrentView(0)


    End Sub
End Class