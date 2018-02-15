Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib

Public Class SmpOEMEventsDlg

    Dim objSMPOEM As ISmpOEM = New SmpOEM
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ButtonAcceptPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAcceptPayment.Click
        If CheckBoxAcceptPaymentTrue.Checked Then
            objSMPOEM.InvokeCustomAccountsDlg(32990) = 1

        Else
            objSMPOEM.InvokeCustomAccountsDlg(32990) = 0
        End If
            
    End Sub

    Private Sub ButtonRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegister.Click
        If CheckBoxRegisterTrue.Checked Then
            objSMPOEM.InvokeCustomHelpDlg(32931) = 1

        Else
            objSMPOEM.InvokeCustomHelpDlg(32931) = 0
        End If
    End Sub

    Private Sub ButtonRefundCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefundCustomer.Click

        If CheckBoxAcceptPaymentTrue.Checked Then
            objSMPOEM.InvokeCustomAccountsDlg(32994) = 1

        Else
            objSMPOEM.InvokeCustomAccountsDlg(32994) = 0
        End If
    End Sub

    Private Sub ButtonAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddCustomer.Click
        If CheckBoxAddCustomerTrue.Checked Then
            objSMPOEM.InvokeCustomCustomerDlg(32833) = 1

        Else
            objSMPOEM.InvokeCustomCustomerDlg(32833) = 0
        End If
    End Sub

    Private Sub ButtonEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditCustomer.Click
        If CheckBoxEditCustomerTrue.Checked Then
            objSMPOEM.InvokeCustomCustomerDlg(32837) = 1

        Else
            objSMPOEM.InvokeCustomCustomerDlg(32837) = 0
        End If
    End Sub

    Private Sub ButtonDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteCustomer.Click
        If CheckBoxDeleteCustomerTrue.Checked Then
            objSMPOEM.InvokeCustomCustomerDlg(32870) = 1

        Else
            objSMPOEM.InvokeCustomCustomerDlg(32870) = 0
        End If
    End Sub

    Private Sub ButtonFindCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFindCustomer.Click
        If CheckBoxFindCustomerTrue.Checked Then
            objSMPOEM.InvokeCustomCustomerDlg(32835) = 1

        Else
            objSMPOEM.InvokeCustomCustomerDlg(32835) = 0
        End If
    End Sub

    Private Sub ButtonBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackup.Click
        If CheckBoxBackupTrue.Checked Then
            objSMPOEM.InvokeCustomFileMenuDlg(32771) = 1

        Else
            objSMPOEM.InvokeCustomFileMenuDlg(32771) = 0
        End If
    End Sub

    Private Sub ButtonPrintSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintSetup.Click
        If CheckBoxPrintSetupTrue.Checked Then
            objSMPOEM.InvokeCustomFileMenuDlg(32994) = 1

        Else
            objSMPOEM.InvokeCustomFileMenuDlg(32994) = 0
        End If
    End Sub

    Private Sub ButtonHelpTopics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelpTopics.Click
        If CheckBoxHelpTopicsTrue.Checked Then
            objSMPOEM.InvokeCustomHelpDlg(32797) = 1

        Else
            objSMPOEM.InvokeCustomHelpDlg(32797) = 0
        End If
    End Sub

    Private Sub ButtonMenuShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMenuShortcut.Click
        If CheckBoxMenuShortcutTrue.Checked Then
            objSMPOEM.InvokeCustomHelpDlg(32988) = 1

        Else
            objSMPOEM.InvokeCustomHelpDlg(32988) = 0
        End If
    End Sub

    Private Sub ButtonDailyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDailyReport.Click
        If CheckBoxDailyReportTrue.Checked Then
            objSMPOEM.InvokeCustomreportsDlg(32825) = 1

        Else
            objSMPOEM.InvokeCustomreportsDlg(32825) = 0
        End If
    End Sub

    Private Sub ButtonMonthlyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMonthlyReport.Click
        If CheckBoxMonthlyReportTrue.Checked Then
            objSMPOEM.InvokeCustomreportsDlg(32826) = 1

        Else
            objSMPOEM.InvokeCustomreportsDlg(32826) = 0
        End If
    End Sub

    Private Sub ButtonAnnualReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAnnualReport.Click
        If CheckBoxAnnualReportTrue.Checked Then
            objSMPOEM.InvokeCustomreportsDlg(32867) = 1

        Else
            objSMPOEM.InvokeCustomreportsDlg(32867) = 0
        End If
    End Sub

    Private Sub ButtonAddNewStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddNewStock.Click
        If CheckBoxAddNewStockTrue.Checked Then
            objSMPOEM.InvokeCustomSalesDlg(32810) = 1

        Else
            objSMPOEM.InvokeCustomSalesDlg(32810) = 0
        End If
    End Sub

    Private Sub ButtonModifyStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyStock.Click
        If CheckBoxModifyStockTrue.Checked Then
            objSMPOEM.InvokeCustomSalesDlg(32811) = 1

        Else
            objSMPOEM.InvokeCustomSalesDlg(32811) = 0
        End If
    End Sub

    Private Sub ButtonModifyItemPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyItemPrice.Click
        If CheckBoxModifyItemPriceTrue.Checked Then
            objSMPOEM.InvokeCustomSalesDlg(32976) = 1

        Else
            objSMPOEM.InvokeCustomSalesDlg(32976) = 0
        End If
    End Sub

    Private Sub ButtonCurrencySettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCurrencySettings.Click
        If CheckBoxCurrencySettingsTrue.Checked Then
            objSMPOEM.InvokeCustomSetupDlg(32787) = 1

        Else
            objSMPOEM.InvokeCustomAccountsDlg(32787) = 0
        End If
    End Sub

    Private Sub ButtonMethodOfPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMethodOfPayment.Click
        If CheckBoxMethodOfPaymentTrue.Checked Then
            objSMPOEM.InvokeCustomSalesDlg(32818) = 1

        Else
            objSMPOEM.InvokeCustomSalesDlg(32818) = 0
        End If
    End Sub

    Private Sub ButtonServiceMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonServiceMaster.Click
        If CheckBoxServiceMasterTrue.Checked Then
            objSMPOEM.InvokeCustomSalesDlg(32831) = 1

        Else
            objSMPOEM.InvokeCustomSalesDlg(32831) = 0
        End If
    End Sub

    Private Sub ButtonAddTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddTransaction.Click
        If CheckBoxAddTransactionTrue.Checked Then
            objSMPOEM.InvokeCustomTransactionDlg(32801) = 1

        Else
            objSMPOEM.InvokeCustomTransactionDlg(32801) = 0
        End If
    End Sub

    Private Sub ButtonEditTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditTransaction.Click
        If CheckBoxEditTransactionTrue.Checked Then
            objSMPOEM.InvokeCustomTransactionDlg(32809) = 1

        Else
            objSMPOEM.InvokeCustomTransactionDlg(32809) = 0
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        If CheckBoxCancelTrue.Checked Then
            objSMPOEM.InvokeCustomTransactionDlg(32925) = 1

        Else
            objSMPOEM.InvokeCustomTransactionDlg(32925) = 0
        End If
    End Sub

    Private Sub ButtonToolBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonToolBar.Click
        If CheckBoxToolBarTrue.Checked Then
            objSMPOEM.InvokeCustomViewMenuDlg(32985) = 1

        Else
            objSMPOEM.InvokeCustomViewMenuDlg(32985) = 0
        End If
    End Sub

    Private Sub ButtonClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearAll.Click
        If CheckBoxClearAllTrue.Checked Then
            objSMPOEM.InvokeCustomViewMenuDlg(32868) = 1

        Else
            objSMPOEM.InvokeCustomViewMenuDlg(32868) = 0
        End If
    End Sub

    Private Sub ButtonFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFullScreen.Click
        If CheckBoxFullScreenTrue.Checked Then
            objSMPOEM.InvokeCustomViewMenuDlg(32999) = 1

        Else
            objSMPOEM.InvokeCustomViewMenuDlg(32999) = 0
        End If
    End Sub
End Class