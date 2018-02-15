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
    public partial class IISmpGenericReportDlg : Form
    {
        ListViewItem item1;
        string Footer, Header;
        string strFRow, strFCol, strFMRow, strFMCol, strFAligment, strHRow, strHCol, strHMRow, strHMCol, strHAligment;
        ColumnHeader ColContntName, ColContnt, ColRow, ColColumn, ColMRow, ColMColumn, ColAligment;

        public IISmpGenericReportDlg()
        {
            
            InitializeComponent();
        }

        private void IISmpGenericReportDlg_Load(object sender, EventArgs e)
        {
            initialisecombo();
            initialiselist();
        }

        private void GetAttributeValues()
        {
            
            Footer = FootrTxt.Text;
            Header = HeaderTxt.Text;
            strFRow = FRowCombo.Text;
            strFCol = FColumnCombo.Text;
            strFMRow = FMRowCombo.Text;
            strFMCol = FColumnCombo.Text;
            strFAligment = FAlignmentCombo.Text;
            strHRow = HRowCombo.Text;
            strHCol = HColumnCombo.Text;
            strHMRow = HMRowCombo.Text;
            strHMCol = HMColumnCombo.Text;
            strHAligment = HAlignmentCombo.Text;
        }
        private void initialiselist()
        {
            RsltList.View = View.Details;
            ColContntName = RsltList.Columns.Add("Content Name", 100, HorizontalAlignment.Left);
            ColContnt = RsltList.Columns.Add("Content", 100, HorizontalAlignment.Left);
            ColRow = RsltList.Columns.Add("Row", 100, HorizontalAlignment.Left);
            ColColumn = RsltList.Columns.Add("Column", 100, HorizontalAlignment.Left);
            ColMRow = RsltList.Columns.Add("Maximum Row", 100, HorizontalAlignment.Left);
            ColMColumn = RsltList.Columns.Add("Maximum Column", 100, HorizontalAlignment.Left);
            ColAligment = RsltList.Columns.Add("Alignment", 100, HorizontalAlignment.Left);
        }
        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initialisecombo()
        {
            for (int i = 1; i <= 100; i++)
            {
                HRowCombo.Items.Add(i);
                HColumnCombo.Items.Add(i);
                HMRowCombo.Items.Add(i);
                HMColumnCombo.Items.Add(i);
                FRowCombo.Items.Add(i);
                FColumnCombo.Items.Add(i);
                FMRowCombo.Items.Add(i);
                FMColumnCombo.Items.Add(i);
                CRowCombo.Items.Add(i);
                CColumnCombo.Items.Add(i);
                CMRowsCombo.Items.Add(i);
                CMColumnCombo.Items.Add(i);
            }
            HAlignmentCombo.Items.Add("Left");
            HAlignmentCombo.Items.Add("Right");
            HAlignmentCombo.Items.Add("Center");
            FAlignmentCombo.Items.Add("Left");
            FAlignmentCombo.Items.Add("Right");
            FAlignmentCombo.Items.Add("Center");
            CAlignmentCombo.Items.Add("Left");
            CAlignmentCombo.Items.Add("Right");
            CAlignmentCombo.Items.Add("Center");
        }

        private void Adbtn_Click(object sender, EventArgs e)
        {
            item1 = new ListViewItem(CntnNmeTxt.Text);
            item1.SubItems.Add(CntntTxt.Text);
            item1.SubItems.Add(CRowCombo.Text);
            item1.SubItems.Add(CColumnCombo.Text);
            item1.SubItems.Add(CMRowsCombo.Text);
            item1.SubItems.Add(CMColumnCombo.Text);
            item1.SubItems.Add(CAlignmentCombo.Text);
            RsltList.Items.AddRange(new ListViewItem[] { item1});
            
        }

        private void ShwBtn_Click(object sender, EventArgs e)
        {
            IISmpGenericReport m_ISmpGenericReport;
            m_ISmpGenericReport = new ISmpGenericReportClass();
            string strBContent="", strBContentName="",strCRow="",strCCol="",strCMRow="",strCMCol="",strCAligment="";
            GetAttributeValues();
            try
            {
                m_ISmpGenericReport.AddReportHeading(Convert.ToInt32(strHRow), Convert.ToInt32(strHCol), Convert.ToInt32(strHMRow), Convert.ToInt32(strHMCol), Header, Convert.ToInt32(StringAlignment.Center), 0);
                for (int i = 0; i < RsltList.Items.Count; i++)
                {
                    RsltList.Items[i].Selected = true;
                    if (RsltList.Items[i].Selected == true)
                    {
                        strBContentName = RsltList.Items[i].SubItems[0].Text;
                        strBContent = RsltList.Items[i].SubItems[1].Text;
                        strCRow = RsltList.Items[i].SubItems[2].Text;
                        strCCol = RsltList.Items[i].SubItems[3].Text;
                        strCMRow = RsltList.Items[i].SubItems[4].Text;
                        strCMCol = RsltList.Items[i].SubItems[5].Text;
                        strCAligment = RsltList.Items[i].SubItems[6].Text;
                    }

                    m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol), strBContentName, Right, 1);
                    m_ISmpGenericReport.AddBodyContentsEx(Convert.ToInt32(strCRow), Convert.ToInt32(strCCol) + 1, strBContent, Right, 1);
                }
                m_ISmpGenericReport.AddFooterContents(Convert.ToInt32(strFRow), Convert.ToInt32(strFCol), Convert.ToInt32(strFMRow), Convert.ToInt32(strFMCol), Footer, Convert.ToInt32(StringAlignment.Center), 0);
                m_ISmpGenericReport.FillReport();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < RsltList.Items.Count; i++)
            {
                if (RsltList.Items[i].Selected)
                {
                    RsltList.Items[i].Remove();
                    i--;
                }
            }
           
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            CntnNmeTxt.Text = "";
            CntntTxt.Text = "";
            CRowCombo.Text = "";
            CColumnCombo.Text = "";
            CMRowsCombo.Text = "";
            CMColumnCombo.Text = "";
            CAlignmentCombo.Text = "";
        }


    }
}