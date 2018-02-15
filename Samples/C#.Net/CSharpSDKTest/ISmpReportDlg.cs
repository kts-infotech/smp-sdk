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
    public partial class ISmpReportDlg : Form
    {
        ISmpReport m_SmpReport;
        string strFont;
        string strFooterHeading1;
        string strFooterHeading2;
        string strFooterHeading3;
        string strMainHeading1;
        string strSubHeading1;
        string strMainHeading2;
        string strSubHeading2;
        string strImagePath;
        int isize;
        int icolor;
        
        public ISmpReportDlg()
        {
            m_SmpReport = new SmpReportClass();
            InitializeComponent();
        }
        ~ISmpReportDlg()
        {
            m_SmpReport = null;
            Dispose(true);
        }

        private void selectitemcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (selectitemcombo.Text == "")
            {
                FontLbl.Visible = false;
                FontTxt.Visible = false;
                SizeTxt.Visible = false;
                SizeLbl.Visible = false;
                ColourLbl.Visible = false;
                ColourTxt.Visible = false;
                Subheading2Lbl.Visible = false;
                Subheading2Txt.Visible = false;
                ImagePathLbl.Visible = false;
                ImagePathTxt.Visible = false;
            }
            else if (selectitemcombo.Text == "Body Format")
            {

                FontLbl.Visible = true;
                FontTxt.Visible = true;
                SizeTxt.Visible = true;
                SizeLbl.Visible = true;
                ColourLbl.Visible = true;
                ColourTxt.Visible = true;
                FontLbl.Text = "Font";
                SizeLbl.Text = "Size";
                ColourLbl.Text = "Colour";
                FontTxt.Text = "Arial";
                SizeTxt.Text = "12";
                ColourTxt.Text = "0";
                
            }
            else if (selectitemcombo.Text == "Footer Format")
            {
                FontLbl.Visible = true;
                FontTxt.Visible = true;
                SizeTxt.Visible = true;
                SizeLbl.Visible = true;
                ColourLbl.Visible = true;
                ColourTxt.Visible = true;
                FontLbl.Text = "Font";
                SizeLbl.Text = "Size";
                ColourLbl.Text = "Colour";
                FontTxt.Text = "Arial";
                SizeTxt.Text = "12";
                ColourTxt.Text = "0";
                
            }
            else if (selectitemcombo.Text == "Footer Info")
            {
                FontLbl.Visible = true;
                FontTxt.Visible = true;
                SizeTxt.Visible = true;
                SizeLbl.Visible = true;
                ColourLbl.Visible = true;
                ColourTxt.Visible = true;
                FontTxt.Text = "";
                SizeTxt.Text = "";
                ColourTxt.Text = "";
                FontLbl.Text = "Footer1";
                SizeLbl.Text = "Footer2";
                ColourLbl.Text = "Footer3";
                
            }
            else if (selectitemcombo.Text == "Header Format")
            {
                FontLbl.Visible = true;
                FontTxt.Visible = true;
                SizeTxt.Visible = true;
                SizeLbl.Visible = true;
                ColourLbl.Visible = true;
                ColourTxt.Visible = true;
                FontLbl.Text = "Font";
                SizeLbl.Text = "Size";
                ColourLbl.Text = "Colour";
                FontTxt.Text = "Arial";
                SizeTxt.Text = "12";
                ColourTxt.Text = "0";
                
            }
            else if (selectitemcombo.Text == "Header Info")
            {
                FontLbl.Visible = true;
                FontTxt.Visible = true;
                SizeTxt.Visible = true;
                SizeLbl.Visible = true;
                ColourLbl.Visible = true;
                ColourTxt.Visible = true;
                Subheading2Lbl.Visible = true;
                Subheading2Txt.Visible = true;
                ImagePathLbl.Visible = true;
                ImagePathTxt.Visible = true;
                FontTxt.Text = "";
                SizeTxt.Text = "";
                ColourTxt.Text = "";
                FontLbl.Text = "Main Heading1";
                SizeLbl.Text = "sub Heading1";
                ColourLbl.Text = "Main Heading2";
                
            }
        }

        private void ResetallBtn_Click(object sender, EventArgs e)
        {
            FontTxt.Text = "";
            SizeTxt.Text = "";
            ColourTxt.Text = "";
            Subheading2Txt.Text = "";
            ImagePathTxt.Text = "";
            MessageBox.Show("All data cleared");
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            selectitemcombo.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            if (selectitemcombo.Text == "")
            {
                MessageBox.Show("Select an item");
            }
            else if (selectitemcombo.Text == "Body Format")
            {
                strFont = FontTxt.Text;
                isize = Convert.ToInt32(SizeTxt.Text,10); 
                icolor = Convert.ToInt32(ColourTxt.Text,10);
                m_SmpReport.SetBodyFormat(strFont,isize,icolor);
                MessageBox.Show("Added Successfully");
            }
            else if (selectitemcombo.Text == "Footer Format")
            {
                strFont = FontTxt.Text;
                isize = Convert.ToInt32(SizeTxt.Text,10);
                icolor = Convert.ToInt32(ColourTxt.Text,10);
                m_SmpReport.SetFooterFormat(strFont,isize,icolor);
                MessageBox.Show("Added Successfully");
            }
            else if (selectitemcombo.Text == "Footer Info")
            {
                strFooterHeading1=FontTxt.Text;
                strFooterHeading2=SizeTxt.Text;
                strFooterHeading3=ColourTxt.Text;
                m_SmpReport.SetFooterInfo(strFooterHeading1, strFooterHeading2, strFooterHeading3);
                MessageBox.Show("Added Successfully");
            }
            else if (selectitemcombo.Text == "Header Format")
            {
                strFont = FontTxt.Text;
                isize = Convert.ToInt32(SizeTxt.Text,10);
                icolor = Convert.ToInt32(ColourTxt.Text,10);
                m_SmpReport.SetHeaderFormat(strFont,isize,icolor);
                MessageBox.Show("Added Successfully");
            }
            else if (selectitemcombo.Text == "Header Info")
            {
                strMainHeading1=FontTxt.Text;
                strSubHeading1=SizeTxt.Text;
                strMainHeading2=ColourTxt.Text;
                strSubHeading2=Subheading2Txt.Text;
                strImagePath=ImagePathTxt.Text;
                FontTxt.Text = "";
                SizeTxt.Text ="";
                ColourTxt.Text = "";
                m_SmpReport.SetHeaderInfo(strMainHeading1,strSubHeading1,strMainHeading2,strSubHeading2,strImagePath);
                MessageBox.Show("Added Successfully");
            }
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adtabltbtn_Click(object sender, EventArgs e)
        {
            string strTable;
            strTable = Selecttablecombo.Text;
            if (Selecttablecombo.Text == "")
            {
                MessageBox.Show("Enter the table name");
            }
            else
            {

                Selecttablecombo.Items.Add(strTable);
            }
          }
        

        private void Generaterptbtn_Click(object sender, EventArgs e)
        {
             string strQuery=Selecttablecombo.Text;
            if (Selecttablecombo.Text == "")
            {
                MessageBox.Show("Select an table");
            }
            else
            {
                if (selectitemcombo.Text == "Body Format")
                {
                    
                    m_SmpReport.GetBodyFormat(ref strFont, ref isize, ref icolor);
                }
                else if (selectitemcombo.Text == "Footer Format")
                {
                    
                    m_SmpReport.GetFooterFormat(ref strFont, ref isize, ref icolor);
                }
                else if (selectitemcombo.Text == "Footer Info")
                {
                    
                    m_SmpReport.GetFooterInfo(ref strFooterHeading1, ref strFooterHeading2, ref strFooterHeading3);
                }
                else if (selectitemcombo.Text == "Header Format")
                {
                    
                    m_SmpReport.GetHeaderFormat(ref strFont, ref isize, ref icolor);
                }
                else if (selectitemcombo.Text == "Header Info")
                {
                    
                    m_SmpReport.GetHeaderInfo(ref strMainHeading1, ref strSubHeading1, ref strMainHeading2, ref strSubHeading2, ref strImagePath);
                }
                m_SmpReport.FillReport(strQuery);
            }
        }

        private void prntrptbtn_Click(object sender, EventArgs e)
        {

            m_SmpReport.PrintReport();
        }

        private void ISmpReportDlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_SmpReport = null;
            this.Dispose();
        }
    }
}