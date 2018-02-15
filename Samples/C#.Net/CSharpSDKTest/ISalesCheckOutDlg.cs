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
    public partial class ISalesCheckOutDlg : Form
    {
        public ISalesCheckOutDlg()
        {
            InitializeComponent();
        }

        private void SalesCheckoutbtn_Click(object sender, EventArgs e)
        {
            ISalesCheckout m_SalesCheckout;

            m_SalesCheckout = new SalesCheckoutClass();

            m_SalesCheckout.InvokeSalesCheckoutDlg();
        }

    }
}