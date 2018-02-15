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
    public partial class ISmpSetUpDlg : Form
    {
        public ISmpSetUpDlg()
        {
            InitializeComponent();
        }

        private void MiscItemMasterbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeMiscItemMasterDlg();
        }

        private void StockMasterbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeStockMasterDlg();
        }

        private void SMPSetUp_Load(object sender, EventArgs e)
        {

        }

        private void CategoryMasterbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeCategoryMasterDlg();
        }

        private void CurrencySettingsbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeCurrencySettingsDlg();
        }

        private void DefaultSettingsbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeDefaultSettingsDlg();
        }

        private void DefaultSettingsExtbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeDefaultSettingsExtDlg();
        }

        private void DeleteOldDatabtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeDeleteOldDataDlg();
        }

        private void ManageUsersbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeManageUsersDlg();
        }

        private void MethodOfPaymentbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeMethodOfPaymentDlg();
        }

        private void ServiceMasterbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeServiceMasterDlg();
        }

        private void SetupWizardbtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeSetupWizard();
        }

        private void ShopInfobtn_Click(object sender, EventArgs e)
        {
            ISmpSetup m_SmpSetup;

            m_SmpSetup = new SmpSetupClass();

            m_SmpSetup.InvokeShopInfoDlg();
        }
    }
}