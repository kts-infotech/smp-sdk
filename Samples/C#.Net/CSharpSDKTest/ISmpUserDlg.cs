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
    public partial class ISmpUserDlg : Form
    {
        public ISmpUserDlg()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            ISmpUser m_SmpUser;

            m_SmpUser = new SmpUserClass();

            m_SmpUser.InvokeLoginUserDlg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISmpUser m_SmpUser;

            m_SmpUser = new SmpUserClass();

            m_SmpUser.InvokeChangePasswordDlg();
        }
    }
}