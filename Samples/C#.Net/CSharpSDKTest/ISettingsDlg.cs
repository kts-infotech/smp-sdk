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
    public partial class ISettingsDlg : Form
    {
      
        public ISettingsDlg()
        {
            InitializeComponent();
        }

        private void UseEnterKeybtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            long lEntrKey;
            lEntrKey = m_Settings.UseEnterKey;
            if (lEntrKey == 1)
            {
                RsltLbl.Text = "Enabled";
            }
            else if (lEntrKey == 0)
            {
                RsltLbl.Text = "Disabled";
            }
        }

        private void AutomaticBackupbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            long lAutoBackup;
            lAutoBackup = m_Settings.AutomaticBackup;
            if (lAutoBackup == 1)
            {
                RsltLbl.Text = "Enabled";
            }
            else if (lAutoBackup == 0)
            {
                RsltLbl.Text = "Disabled";
            }
        }

        private void AutomaticCompactbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            long lAutoCompact;
            lAutoCompact=m_Settings.AutomaticCompact;
            if (lAutoCompact == 1)
            {
                RsltLbl.Text = "Enabled";
            }
            else if (lAutoCompact == 0)
            {
                RsltLbl.Text = "Disabled";
            }
        }

        private void DateFormatbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            string strDate;
            strDate=m_Settings.DateFormat;
            RsltLbl.Text = strDate;
        }

        private void MembershipFeebtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            double dblfee;
            dblfee=m_Settings.DefaultMembershipFee;
            RsltLbl.Text = dblfee.ToString();
        }

        private void SecurityDepositbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            double dblsecuritydeposit;
            dblsecuritydeposit=m_Settings.DefaultSecurityDeposit;
            RsltLbl.Text = dblsecuritydeposit.ToString();
        }

        private void LaunchOnStartupbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            long llanchstrtup;
            llanchstrtup=m_Settings.LaunchOnStartup;
            if (llanchstrtup == 1)
            {
                RsltLbl.Text = "Enabled";
            }
            else if (llanchstrtup == 0)
            {
                RsltLbl.Text = "Disabled";
            }
        }

        private void NoOfDisplayRecordsbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            int iNofDsplRcrds;
            iNofDsplRcrds=m_Settings.NoOfDisplayRecords;
            RsltLbl.Text = iNofDsplRcrds.ToString();
        }

        private void OverrideExDataOnABbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            long lovrrdedataonAB;
            lovrrdedataonAB=m_Settings.OverrideExDataOnAB;
            if (lovrrdedataonAB == 1)
            {
                RsltLbl.Text = "Enabled";
            }
            else if (lovrrdedataonAB == 0)
            {
                RsltLbl.Text = "Disabled";
            }
        }

        private void PictureFolderbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            string strpctreFldr;
            strpctreFldr=m_Settings.PictureFolder;
            RsltLbl.Text = strpctreFldr;
        }

        private void PaymentMethodbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            RsltLbl.Text = m_Settings.PaymentMethod;
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterPaymntMthdbtn_Click(object sender, EventArgs e)
        {
            ISettings m_Settings;
            m_Settings = new SettingsClass();
            RsltLbl.Text = "";
            Paymntlbl.Text = "";
            string strPaymtMthd;
            if (paymntTxt.Text == "")
            {
                Paymntlbl.Text = "Enter the Payment Method";
            }
            else
            {
                strPaymtMthd=paymntTxt.Text;
                m_Settings.PaymentMethod=strPaymtMthd;
                Paymntlbl.Text = "Entered the Payment Method successful ";
                paymntTxt.Text = "";
            }
        }
    }
}