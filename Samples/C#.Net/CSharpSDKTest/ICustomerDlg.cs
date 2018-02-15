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
    public partial class ICustomerDlg : Form
    {
        public ICustomerDlg()
        {
            InitializeComponent();
        }

        private void Cstmrdtlsbtn_Click(object sender, EventArgs e)
        {
            ICustomer m_Customer;

            m_Customer = new CustomerClass();

            CustIdlbl.Visible = false;

            FldNmelbl.Visible = false;

            string strCusId, strFldNme;

            strCusId = custIdTxt.Text;

            strFldNme = FldNmeTxt.Text;

            if ((strCusId == "") && (strFldNme == ""))
            {
                CustIdlbl.Visible = true;
                FldNmelbl.Visible = true;
            }

            else if (strCusId == "") 
            {
                CustIdlbl.Visible = true;
            }

            else if (strFldNme == "")
            {
                FldNmelbl.Visible = true;
            }

            else
            {
                object VarVal = 0;

                m_Customer.GetCustomerDetails(strCusId, strFldNme, ref VarVal);

                string strMsg = VarVal.ToString();

                MessageBox.Show(strMsg);
            }
        }

        private void FindCustomerbtn_Click(object sender, EventArgs e)
        {
            ICustomer m_Customer;

            m_Customer = new CustomerClass();

            string strCusId="";

            m_Customer.InvokeFindCustomerDlg(ref strCusId);
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}