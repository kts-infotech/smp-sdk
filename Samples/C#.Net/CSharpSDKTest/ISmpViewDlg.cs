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
    public partial class ISmpViewDlg : Form
    {
        public ISmpViewDlg()
        {
            InitializeComponent();
        }

        private void PrintInDosModebtn_Click(object sender, EventArgs e)
        {
            ISmpView m_SmpView;

            m_SmpView = new SmpViewClass();

            m_SmpView.PrintInDosMode();
        }

        private void PrintReportbtn_Click(object sender, EventArgs e)
        {
            ISmpView m_SmpView;

            m_SmpView = new SmpViewClass();

            m_SmpView.PrintReport();
        }
    }
}