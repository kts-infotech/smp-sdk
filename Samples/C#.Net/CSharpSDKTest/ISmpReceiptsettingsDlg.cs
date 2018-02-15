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
    public partial class ReceiptsettingsDlg : Form
    {
        
        public ReceiptsettingsDlg()
        {
            InitializeComponent();
        }

        private void ReceiptsettingsDlg_Load(object sender, EventArgs e)
        {

        }

        private void BypassPrintDlgbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings m_SmpReceiptSettings;
            
            m_SmpReceiptSettings = new SmpReceiptSettingsClass();
            
            long lBypassprnt;
            
            lBypassprnt = m_SmpReceiptSettings.BypassPrintDlg;

            if (lBypassprnt == 1)
            {
                bypassprntlbl.Text = " Enabled ";
            }
            
            else if (lBypassprnt == 0)
            {
                bypassprntlbl.Text = " Disabled ";
            }
         }

        private void MessageBox(string p)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void EnableDefaultReceiptPrinterbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings m_SmpReceiptSettings;
            
            m_SmpReceiptSettings = new SmpReceiptSettingsClass();
            
            long lenbledfltreceptprntr;

            lenbledfltreceptprntr = m_SmpReceiptSettings.EnableDefaultReceiptPrinter;

            if (lenbledfltreceptprntr == 1)
            {
                enbldfltreceptprntrlbl.Text = " Enabled ";
            }

            else if (lenbledfltreceptprntr == 0)
            {
                enbldfltreceptprntrlbl.Text = " Disabled ";
            }
        }

        private void FooterTextbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings m_SmpReceiptSettings;

            m_SmpReceiptSettings = new SmpReceiptSettingsClass();

            string strFootrTxt;

            strFootrTxt = m_SmpReceiptSettings.FooterText;

            if (strFootrTxt == "")
            {
                footrtxtlbl.Text = " No Footer Text";
            }

            else
            {
                footrtxtlbl.Text = strFootrTxt;
            }
        }

        private void PrintFooterTextbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings m_SmpReceiptSettings;

            m_SmpReceiptSettings = new SmpReceiptSettingsClass();

            long lPrntFootrTxt;

            lPrntFootrTxt = m_SmpReceiptSettings.PrintFooterText;

            if (lPrntFootrTxt == 1)
            {
                prntfootrtextlbl.Text = " Enabled ";
            }

            else if (lPrntFootrTxt == 0)
            {
                prntfootrtextlbl.Text = " Disabled ";
            }
        }

        private void ReceiptPrinterNamebtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings     m_SmpReceiptSettings;

            m_SmpReceiptSettings =  new SmpReceiptSettingsClass();

            string strReceptPrntrName;

            strReceptPrntrName = m_SmpReceiptSettings.ReceiptPrinterName;

            if (strReceptPrntrName == "")
            {
                receptpntrnmelbl.Text = "No Printer Name";
            }

            else

                receptpntrnmelbl.Text = strReceptPrntrName;
        }

        private void ReceiptSpacingbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings     m_SmpReceiptSettings;

            m_SmpReceiptSettings =  new SmpReceiptSettingsClass();

            int iReceptSpacng = 0;

            iReceptSpacng = m_SmpReceiptSettings.ReceiptSpacing;

            if (iReceptSpacng == 0)
            {
                ReceptSpacnglbl.Text = " Not Defined ";
            }

            else

                ReceptSpacnglbl.Text = iReceptSpacng.ToString();
        }

        private void PrintTimeAtFooterbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings     m_SmpReceiptSettings;

            m_SmpReceiptSettings =  new SmpReceiptSettingsClass();

            long lPrntTmeAtFootr;

            lPrntTmeAtFootr = m_SmpReceiptSettings.PrintTimeAtFooter;

            if (lPrntTmeAtFootr == 1)
            {
                PrntTmeAtFootrlbl.Text = "Enabled";
            }

            else if (lPrntTmeAtFootr == 0)
            {
                PrntTmeAtFootrlbl.Text = "Disabled";
            }
        }

        private void PrintShopNameAtHeaderbtn_Click(object sender, EventArgs e)
        {
            ISmpReceiptSettings     m_SmpReceiptSettings;

            m_SmpReceiptSettings =  new SmpReceiptSettingsClass();

            long lPrntShpNmeAtHeder;

            lPrntShpNmeAtHeder = m_SmpReceiptSettings.PrintShopNameAtHeader;

            if (lPrntShpNmeAtHeder == 1)
            {
                PrntshpNmeAtHederlbl.Text = "Enabled";
            }

            else if (lPrntShpNmeAtHeder == 0)
            {
                PrntshpNmeAtHederlbl.Text = "Disabled";
            }
        }


    }
}