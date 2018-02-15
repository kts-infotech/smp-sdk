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
    public partial class ISmpReportMenuDlg : Form
    {
        
        public ISmpReportMenuDlg()
        {

            InitializeComponent();
        }

        private void AnualAccountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;
                m_SmpReportMenu = new SmpReportMenuClass();
                m_SmpReportMenu.InvokeAnualAccountDlg();
                return;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
           
        }

        private void AnualStatisticsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeAnualStatisticsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CanceledSalesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCanceledSalesDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CanceledTransactionsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCanceledTransactionsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerBalanceAmountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerBalanceAmountDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerInactivebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerInactiveDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }

        }

        private void CustomerListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerMostActivebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerMostActiveDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerPaymentDetailsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerPaymentDetailsdlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerRefundDetailsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerRefundDetailsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerSalesDetailsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerSalesDetailsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CustomerTransactionDetailsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeCustomerTransactionDetailsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void DailyAccountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeDailyAccountDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void DailySummarybtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeDailySummaryDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void DiscountSalesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeDiscountSalesDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void MiscTransactionListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeMiscTransactionListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void MonthlyAccountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeMonthlyAccountDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void MonthlyStatisticsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeMonthlyStatisticsDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ReorderListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeReorderListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void Rollbackbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeRollbackDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SalesListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeSalesListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ServiceDeliveredbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeServiceDeliveredDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ServiceListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeServiceListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SpecifiedPeriodAccountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeSpecifiedPeriodAccountDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void StokeListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeStokeListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void TransactionListbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISmpReportMenu m_SmpReportMenu;

                m_SmpReportMenu = new SmpReportMenuClass();

                m_SmpReportMenu.InvokeTransactionListDlg();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}