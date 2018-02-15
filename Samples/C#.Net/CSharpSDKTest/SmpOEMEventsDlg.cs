using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesMatePlusLib;

namespace CSharpSDKTest
{
    public partial class SmpOEMEventsDlg : Form
    {
        ISmpOEM objSmpOEM = new SmpOEMClass();
        public SmpOEMEventsDlg()
        {
            InitializeComponent();
        }

        private void SmpOEMEventsDlg_Load(object sender, EventArgs e)
        {
            
        }
        //Custom Account Menu
        private void btnAcceptPaymentSet_Click(object sender, EventArgs e)
        {
           
            if (rbtnAcceptPaymentTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomAccountsDlg(32990, 1);
            }
            else 
            {
                objSmpOEM.set_InvokeCustomAccountsDlg(32990, 0);
            }
        }

        private void btnRefundToCustomerSet_Click(object sender, EventArgs e)
        {
            if (rbtnRefundToCustomerTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomAccountsDlg(32994, 1);
            }
            else 
            {
                objSmpOEM.set_InvokeCustomAccountsDlg(32994, 0);
            }
        }

        //Custom Help Menu
        private void btnRegisterSet_Click(object sender, EventArgs e)
        {
            if (rbtnRegisterTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32931, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32931, 0);
            }
        }

        private void btnHelpTopicsSet_Click(object sender, EventArgs e)
        {
            if (rbtnHelpTopicsTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32797, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32797, 0);
            }
        }

        private void btnMenuShortcutKeysSet_Click(object sender, EventArgs e)
        {
            if (rbtnMenuShortcutKeysTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32988, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomHelpDlg(32988, 0);
            }
        }

        //Custom Setup Menu
        private void btnCurrencySettingsSet_Click(object sender, EventArgs e)
        {
            if (rbtnCurrencySettingsTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32787, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32787, 0);
            }
        }

        private void btnMethodOfPaymentSet_Click(object sender, EventArgs e)
        {
            if (rbtnMethodOfPaymentTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32818, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32818, 0);
            }
        }

        private void btnServiceMasterSet_Click(object sender, EventArgs e)
        {
            if (rbtnServiceMasterTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32831, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSetupDlg(32831, 0);
            }
        }

        //Custom Customer menu
        private void btnAddCustomerSet_Click(object sender, EventArgs e)
        {
            if (rbtnAddCustomerTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32833, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32833, 0);
            }
        }

        private void btnEditCustomerSet_Click(object sender, EventArgs e)
        {
            if (rbtnEditCustomerTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32837, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32837, 0);
            }
        }

        private void btnDeleteCustomerSet_Click(object sender, EventArgs e)
        {
            if (rbtnDeleteCustomerTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32870, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32870, 0);
            }
        }

        private void btnFindCustomerSet_Click(object sender, EventArgs e)
        {
            if (rbtnFindCustomerTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32835, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomCustomerDlg(32835, 0);
            }
        }

        //Custom Report Menu
        private void btnDailyReportSet_Click(object sender, EventArgs e)
        {
            if (rbtnDailyReportTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32825, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32825, 0);
            }
        }

        private void btnMonthlyReportSet_Click(object sender, EventArgs e)
        {
            if (rbtnMonthlyReportTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32826, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32826, 0);
            }
        }

        private void btnAnnualReportSet_Click(object sender, EventArgs e)
        {
            if (rbtnAnnualReportTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32867, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomreportsDlg(32867, 0);
            }
        }

        //Custom Transaction Menu
        private void btnAddTransactionSet_Click(object sender, EventArgs e)
        {
            if (rbtnAddTransactionTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32801, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32801, 0);
            }
        }

        private void btnEditTransactionSet_Click(object sender, EventArgs e)
        {
            if (rbtnEditTransactionTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32809, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32809, 0);
            }
        }

        private void btnCancelTransactionSet_Click(object sender, EventArgs e)
        {
            if (rbtnCancelTransactionTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32925, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomTransactionDlg(32925, 0);
            }
        }

        //Custom File Menu
        private void btnBackupDataSet_Click(object sender, EventArgs e)
        {
            if (rbtnBackupDataTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomFileMenuDlg(32771, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomFileMenuDlg(32771, 0);
            }
        }

        private void btnPrintSetupSet_Click(object sender, EventArgs e)
        {

        }

        //Custom Sales Menu
        private void btnAddNewStockItemSet_Click(object sender, EventArgs e)
        {
            if (rbtnAddNewStockItemTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32810, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32810, 0);
            }
        }

        private void btnModifyStockItemSet_Click(object sender, EventArgs e)
        {
            if (rbtnModifyStockItemTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32811, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32811, 0);
            }
        }

        private void btnModifyStockItemPriceSet_Click(object sender, EventArgs e)
        {
            if (rbtnModifyStockItemPriceTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32976, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomSalesDlg(32976, 0);
            }
        }

        //Custom View Menu
        private void btnToolBarSet_Click(object sender, EventArgs e)
        {
            if (rbtnToolBarTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32985, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32985, 0);
            }
        }

        private void btnClearAllSet_Click(object sender, EventArgs e)
        {
            if (rbtnClearAllTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32868, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32868, 0);
            }
        }

        private void btnFullScreenSet_Click(object sender, EventArgs e)
        {
            if (rbtnFullScreenTrue.Checked)
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32999, 1);
            }
            else
            {
                objSmpOEM.set_InvokeCustomViewMenuDlg(32999, 0);
            }
        }
    }
}