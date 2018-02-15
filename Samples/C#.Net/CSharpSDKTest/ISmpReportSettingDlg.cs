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
    public partial class ISmpReportSettingDlg : Form
    {
        public ISmpReportSettingDlg()
        {
            InitializeComponent();
        }

        private void PrintShopNameAtHeaderbtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lPrntShpNme;

            lPrntShpNme = m_SmpReportSettings.PrintShopNameAtHeader;

            if (lPrntShpNme == 1)
            {
                PrntShpNmeAtHederlbl.Text = "Enabled";
            }
            else if (lPrntShpNme == 0)
            {
                PrntShpNmeAtHederlbl.Text = "Disabled";
            }
        }

        private void PrintShopLogobtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lPrntShpLogo;

            lPrntShpLogo = m_SmpReportSettings.PrintShopLogo;

            if (lPrntShpLogo == 1)
            {
                PrntShpLogolbl.Text = "Enabled";
            }

            else if (lPrntShpLogo == 0)
            {
                PrntShpLogolbl.Text = "Disabled";
            }
        }

        private void PrintPhNoAtFooterbtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lPrntPhno;

            lPrntPhno = m_SmpReportSettings.PrintPhNoAtFooter;

            if (lPrntPhno == 1)
            {
                PrntPhnolbl.Text = "Enabled";
            }

            else if (lPrntPhno == 0)
            {
                PrntPhnolbl.Text = "Disabled";
            }

        }

        private void PrintTimeAtFooterbtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lprntTme;

            lprntTme = m_SmpReportSettings.PrintTimeAtFooter;

            if (lprntTme == 1)
            {
                PrntTmeAtFootrlbl.Text = "Enabled";
            }

            else if (lprntTme == 0)
            {
                PrntTmeAtFootrlbl.Text = "Disabled";
            }

        }

        private void BypassPrintDlgbtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lBypassprnt;

            lBypassprnt = m_SmpReportSettings.BypassPrintDlg;

            if (lBypassprnt == 1)
            {
                BypassPrntlbl.Text = "Enabled";
            }

            else if (lBypassprnt == 0)
            {
                BypassPrntlbl.Text = "Disabled";
            }
        }

        private void AllwaysPrintMembershipFormbtn_Click(object sender, EventArgs e)
        {
            ISmpReportSettings m_SmpReportSettings;

            m_SmpReportSettings = new SmpReportSettingsClass();

            long lPrntMbershpFrm;

            lPrntMbershpFrm = m_SmpReportSettings.AllwaysPrintMembershipForm;

            if (lPrntMbershpFrm == 1)
            {
                prntMbrShplbl.Text = "Enabled";
            }

            else if (lPrntMbershpFrm == 0)
            {
                prntMbrShplbl.Text = "Disabled";
            }
        }

        private void ReportSettingDlg_Load(object sender, EventArgs e)
        {

        }
    }
}