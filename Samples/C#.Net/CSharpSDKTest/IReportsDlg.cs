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
    public partial class IReportsDlg : Form
    {
        public IReportsDlg()
        {
            InitializeComponent();
        }

        private void Aditinalinfobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Aditinalinfobtn.Checked == true)
            {
                HeadingTxt.Enabled = true;
                AddHeadingTxt.Enabled = true;
                CaptionTxt.Enabled = false;
            }
        }

        private void Withcaptionbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Withcaptionbtn.Checked == true)
            {
                HeadingTxt.Enabled = false;
                AddHeadingTxt.Enabled = false;
                CaptionTxt.Enabled = true;
            }
        }

        private void NormalBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalBtn.Checked == true) 
            {
                HeadingTxt.Enabled = false;
                AddHeadingTxt.Enabled = false;
                CaptionTxt.Enabled = false;
            }
        }

        private void AdTableBtn_Click(object sender, EventArgs e)
        {
            string strAdTable;
            strAdTable=Tablecombo.Text;
            if (strAdTable == "")
            {
                MessageBox.Show("Enter The table name");
            }
            else
            {
                Tablecombo.Items.Add(strAdTable);
                MessageBox.Show("Added Sucessfully");
                strAdTable = "";
            }
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            IReports m_Reports;
            m_Reports = new ReportsClass();
            string strQuery;
            strQuery=Tablecombo.Text;
            if(strQuery=="")
            {
                MessageBox.Show("Enter the table name");
            }
            else if (NormalBtn.Checked == true)
            {
                m_Reports.FillReport(strQuery);
            }
            else if (Withcaptionbtn.Checked == true)
            {
                string strCaption;
                strCaption = CaptionTxt.Text;
                if (strCaption == "")
                {
                    MessageBox.Show("Please enter the caption");
                }
                else
                {
                    m_Reports.FillReportWithCaption(strQuery, strCaption);
                }
            }
            else if (Aditinalinfobtn.Checked == true)
            {
                string strHeading;
                string strAdheading;
                int bshowheader=1;
                int bshowfooter=1;
                strHeading=HeadingTxt.Text;
                strAdheading=AddHeadingTxt.Text;
                if (strHeading == "")
                {
                    MessageBox.Show("Enter the Heading");
                }
                else if (strAdheading == "")
                {
                    MessageBox.Show("Enter the additional Heading");
                }
                else if ((strAdheading == "") && (strHeading == ""))
                {
                    MessageBox.Show("Enter the Heading and Additional Heading");
                }
                else
                {
                    m_Reports.FillReportEx(strQuery, strHeading, strAdheading, bshowheader, bshowfooter);
                }
            }
        }

    }
}