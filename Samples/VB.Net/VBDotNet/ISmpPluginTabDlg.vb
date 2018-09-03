Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib

Public Class ISmpPluginTabDlg

    Dim iView As Integer
    Dim iFormView As Integer
    Dim m_SmpPluginTab As SmpPluginTab = New SmpPluginTab()

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        iView = 0
        iFormView = 0
    End Sub

    Private Sub btnCreateView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateView.Click
        Dim vTabView As New Object()
        vTabView = Nothing
        Dim m_lIndex As Integer = -1
        iView = iView + 1
        Dim strCount As String
        Dim strView As String
        strView = (Convert.ToInt32(iView)).ToString()
        strCount = strView
        Dim strLabel As String = "View"
        strLabel = strLabel + strCount
        Dim strToolTip As String = "View ToolTip"
        strToolTip = strToolTip + strCount
        m_SmpPluginTab.CreateView(strLabel, strToolTip, vTabView, m_lIndex)
    End Sub

    Private Sub btnCreateFormView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFormView.Click
        Dim vTabView As New Object()
        vTabView = Nothing
        Dim m_lIndex As Integer = -1
        iFormView = iFormView + 1
        Dim iCount As Integer
        Dim strCount As String
        strCount = (Convert.ToInt32(iCount)).ToString()
        iCount = iFormView
        Dim strLabel As [String] = "FormView"
        strLabel = strLabel + strCount
        Dim strToolTip As [String] = "FormView ToolTip"
        strToolTip = strToolTip + strCount
        m_SmpPluginTab.CreateFormView(strLabel, strToolTip, vTabView, m_lIndex)
    End Sub

    Private Sub btnCreateHtmlView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateHtmlView.Click

        Dim lIndex As Integer = 0
        Dim pBrowserObj As New Object()
        m_SmpPluginTab.CreateHtmlView("SalesMate + Site", "Tooltip", pBrowserObj, lIndex)

        Dim pBrowser2 As SHDocVw.IWebBrowser2 = DirectCast(pBrowserObj, SHDocVw.IWebBrowser2)
        Dim Param1 As New Object()
        Dim Param2 As New Object()
        Dim Param3 As New Object()
        Dim Param4 As New Object()
        pBrowser2.Navigate("http://www.salesmateplus.com", Param1, Param2, Param3, Param4)

    End Sub

    Private Sub btnSetCurrentView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetCurrentView.Click
        Try
            If txtSetCurrentViewTo.Text = "" Then
                m_SmpPluginTab.SetCurrentView(0)
            Else
                Dim lIndex As Integer = Convert.ToInt32(txtSetCurrentViewTo.Text)
                m_SmpPluginTab.SetCurrentView(lIndex)
            End If
        Catch ex As Exception
            m_SmpPluginTab.SetCurrentView(0)
        End Try
    End Sub
End Class