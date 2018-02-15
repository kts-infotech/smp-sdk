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
    public partial class IISmpCommandsDlg : Form
    {
        public IISmpCommandsDlg()
        {
            InitializeComponent();
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCommandIdbtn_Click(object sender, EventArgs e)
        {
            IISmpCommands m_ISmpCommands;
            m_ISmpCommands = new ISmpCommandsClass();
            string strSessionId;
            int isessionId;
            int icommandId;
            strSessionId = SesonIdTxt.Text;
            isessionId = Convert.ToInt32(strSessionId, 10);
            string Menustring=MenustringTxt.Text;
            if (Menustring == "")
            {
                MessageBox.Show("Please Enter the Valid menu String");
            }
            else
            {
                icommandId = m_ISmpCommands.get_MenuCommandID(isessionId, Menustring);
                if (icommandId >= 0)
                {
                    MessageBox.Show(icommandId.ToString());
                    CommandIdTxt.Text = icommandId.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to get commandId");
                }
            }
        }

        private void GetMenustringTxt_Click(object sender, EventArgs e)
        {
            IISmpCommands m_ISmpCommands;
            m_ISmpCommands = new ISmpCommandsClass();
            string strSessionId;
            string strCommandId;
            string strMenustring;
            int iSessionId;
            int iCommandId;
            strSessionId=SesonIdTxt.Text;
            strCommandId=CommandIdTxt.Text;
            iSessionId=Convert.ToInt32(strSessionId,10);
            
            if(strCommandId=="")
            {
                MessageBox.Show("First Enter the Menu String");
            }
            else
            {
                iCommandId = Convert.ToInt32(strCommandId, 10);
                strMenustring=m_ISmpCommands.get_MenuString(iSessionId, iCommandId);
                MessageBox.Show(strMenustring);
                MenustringTxt.Text = strMenustring;
            }
        }

        private void MenuCommandExbtn_Click(object sender, EventArgs e)
        {
            IISmpCommands m_ISmpCommands;
            m_ISmpCommands = new ISmpCommandsClass();
            string strSessionId;
            string strFunctionName;
            int iMenucommandEx;
            int iSessionId;
            strSessionId=SesonIdTxt.Text;
            iSessionId=Convert.ToInt32(strSessionId,10);
            strFunctionName=FunctionmeTxt.Text;
            if (strFunctionName == "")
            {
                MessageBox.Show("Enter The Function Name");
            }
            else
            {
                iMenucommandEx = m_ISmpCommands.get_MenuCommandEx(iSessionId, strFunctionName);
                if (iMenucommandEx >= 0)
                {
                    MessageBox.Show(iMenucommandEx.ToString());
                    CommandExTxt.Text = iMenucommandEx.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to get commandEx");
                }
            }
        }

        private void Noofcommandsbtn_Click(object sender, EventArgs e)
        {
            IISmpCommands m_ISmpCommands;
            m_ISmpCommands = new ISmpCommandsClass();
            string strFunctionName;
            string strSessionId;
            int iSessionId;
            int iNoOfcommannds;
            strFunctionName=FunctionmeTxt.Text;
            strSessionId=SesonIdTxt.Text;
            iSessionId=Convert.ToInt32(strSessionId,10);
            if(strFunctionName=="")
            {
                MessageBox.Show("Enter the function Name");
            }
            else
            {
                iNoOfcommannds=m_ISmpCommands.get_NoOfCommands(iSessionId, strFunctionName);
                MessageBox.Show(iNoOfcommannds.ToString());
                NoOfComandsTxt.Text = iNoOfcommannds.ToString();
            }
        }
    }
}