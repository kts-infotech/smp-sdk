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
    public partial class ISecurityDlg : Form
    {
        public ISecurityDlg()
        {
            InitializeComponent();
        }

        private void Accesscstmrbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lAcesscstmer;
            lAcesscstmer=m_Security.AccessCustomerMenu;
            if (lAcesscstmer == 1)
            {
                Infolist.Items.Add("Have rights to access customer menu");
            }
            else if (lAcesscstmer == 0)
            {
                Infolist.Items.Add("Access to customer menu is denied");
            }
        }

        private void Acesssalesbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lAcessSals;
            lAcessSals = m_Security.AccessSalesMenu;
            if (lAcessSals == 1)
            {
                Infolist.Items.Add("Have rights to access sales menu");
            }
            else if (lAcessSals == 0)
            {
                Infolist.Items.Add("Access to sales menu is denied");
            }

        }

        private void AccessSetupbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lAcessSetup;
            lAcessSetup = m_Security.AccessSetup;
            if (lAcessSetup == 1)
            {
                Infolist.Items.Add("Have rights to access setup");
            }
            else if (lAcessSetup == 0)
            {
                Infolist.Items.Add("Access to setup is denied");
            }
        }

        private void Accesstransctnbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lAcessTransaction;
            lAcessTransaction = m_Security.AccessTransactionMenu;
            if (lAcessTransaction == 1)
            {
                Infolist.Items.Add("Have rights to access transaction menu");
            }
            else if (lAcessTransaction == 0)
            {
                Infolist.Items.Add("Access to transaction menu is denied");
            }
        }

        private void CrntusrLoginbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            string strCurentUsrLogin;
            strCurentUsrLogin = m_Security.CurrentLoginUser;
            if (strCurentUsrLogin == "")
            {
                Infolist.Items.Add("No current user");
            }
            else
                Infolist.Items.Add(strCurentUsrLogin);
        }

        private void Crntusrbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            string strCrntUsrRights;
            strCrntUsrRights = m_Security.CurrentUserRights;
            if (strCrntUsrRights == "")
            {
                Infolist.Items.Add("No current user rights");
            }
            else
                Infolist.Items.Add(strCrntUsrRights);
        }

        private void DatabaseRytbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lDatabseRite;
            lDatabseRite = m_Security.DatabaseRight;
            if (lDatabseRite == 1)
            {
                Infolist.Items.Add("Have database right");
            }
            else if (lDatabseRite == 0)
            {
                Infolist.Items.Add("Database right is denied");
            }
        }

        private void PrntRptsbtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lPrntrpts;
            lPrntrpts = m_Security.PrintReports;
            if (lPrntrpts == 1)
            {
                Infolist.Items.Add("Have print rights");
            }
            else if (lPrntrpts == 0)
            {
                Infolist.Items.Add("Doesn't have print rights");
            }
        }

        private void ShpbalBtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            double dShpBal;
            dShpBal = m_Security.UpdateShopBalance;
            Infolist.Items.Add(dShpBal);
        }

        private void VwRptBtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            Infolist.Items.Clear();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            long lviewRpts;
            lviewRpts = m_Security.ViewReports;
            if (lviewRpts == 1)
            {
                Infolist.Items.Add("Have rights to view reports");
            }
            else if (lviewRpts == 0)
            {
                Infolist.Items.Add("No rights view reports");
            }
        }

        private void UsrRytBtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            InfoLbl.Text = "";
            Infolist.Items.Clear();
            Securitylist.Items.Clear();
            string strXML;
            string strModule;
            string strLeaf;
            long lUserRyt;
            strXML=XMTTxt.Text;
            strModule=ModuleTxt.Text;
            strLeaf=LeafsecurityTxt.Text;
            if ((strXML == "") && (strModule == "") && (strLeaf == ""))
            {
                MessageBox.Show("Please the XML Module name,module section and leaf security node name");
            }
            else if (strXML == "")
            {
                MessageBox.Show("Please enter the XML module name");
            }
            else if (strModule == "")
            {
                MessageBox.Show("Please enter the module section");
            }
            else if (strLeaf == "")
            {
                MessageBox.Show("Please enter the leaf security node name");
            }
            else
            {
                lUserRyt= m_Security.get_UserRightInfo(strXML, strModule, strLeaf);
                if (lUserRyt == 1)
                {
                    InfoLbl.Text = "Have User Right Info";
                }
                else if (lUserRyt == 0)
                {
                    InfoLbl.Text = "Don't have user right Info";
                }
            }
            
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            ISecurity m_Security;
            m_Security = new SecurityClass();
            InfoLbl.Text = "";
            Securitylist.Items.Clear();
            Infolist.Items.Clear();
            string strUserName;
            string strUserSecurity="";
            strUserName = UsrNmeTxt.Text;
            if (strUserName == "")
            {
                MessageBox.Show("Please enter the user name");
            }
            else
            {
                m_Security.GetUserRightsInfo(strUserName, ref strUserSecurity);
                Securitylist.Items.Add(strUserSecurity);
            }
        }


    }
}