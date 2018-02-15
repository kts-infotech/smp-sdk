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
    public partial class IAccountsDlg : Form
    {
        public IAccountsDlg()
        {
            InitializeComponent();
        }

        private void RefundToCustomerbtn_Click(object sender, EventArgs e)
        {
            IAccounts m_Accounts;

            m_Accounts = new AccountsClass();

            object VarCusId = 0;

            m_Accounts.InvokeRefundToCustomerDlg(VarCusId);
        }

        private void AcceptPaymentbtn_Click(object sender, EventArgs e)
        {
            IAccounts m_Accounts;

            m_Accounts = new AccountsClass();

            object VarCusId = 0;

            m_Accounts.InvokeAcceptPaymentDialog(VarCusId);
        }

        private void Adbtn_Click(object sender, EventArgs e)
        {
            IAccounts m_Accounts;

            m_Accounts = new AccountsClass();

            Adlbl.Visible = false;

            string strShpBal;

            double num;

            strShpBal = AdTxt.Text;

            bool isnum=double.TryParse(strShpBal,out num);

            if (!isnum)
            {
                Adlbl.Visible=true;
            }

            else if (strShpBal == "")
            {
                Adlbl.Visible = true;
            }
            else
            {
                m_Accounts.AddToShopBalance(double.Parse(strShpBal));

                MessageBox.Show("Added to the shop balance");
            }
                
         }

        private void Sbtractbtn_Click(object sender, EventArgs e)
        {
            IAccounts m_Accounts;

            m_Accounts = new AccountsClass();

            Sublbl.Visible = false;

            string strShpBal;

            double num;

            strShpBal = SubtractTxt.Text;

            bool isnum = double.TryParse(strShpBal, out num);

            if (!isnum)
            {
                Sublbl.Visible = true;
            }

            else if (strShpBal == "")
            {
                Sublbl.Visible = true;
            }
            else
            {
                m_Accounts.SubstractFromShopBalance(double.Parse(strShpBal));

                MessageBox.Show("Subtracted from the shop balance");
            }

        }

     }
}