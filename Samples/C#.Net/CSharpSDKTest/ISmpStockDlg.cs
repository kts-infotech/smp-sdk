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
    public partial class ISmpStockDlg : Form
    {
        public ISmpStockDlg()
        {
            InitializeComponent();
        }

        private void AddNewStockbtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            m_SmpStock.InvokeAddNewStockDlg();
        }

        private void CancelSalesbtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            int iSalesId = 0;

            m_SmpStock.InvokeCancelSalesDlg(ref (iSalesId));
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            m_SmpStock.InvokeCheckoutDlg();
        }

        private void EditStockbtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            m_SmpStock.InvokeEditStockDlg();
        }

        private void ModifyStockItemPricebtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            m_SmpStock.InvokeModifyStockItemPriceDlg();
        }

        private void StockRateSettingsbtn_Click(object sender, EventArgs e)
        {
            ISmpStock m_SmpStock;

            m_SmpStock = new SmpStockClass();

            m_SmpStock.InvokeStockRateSettingsDlg();
        }
    }
}