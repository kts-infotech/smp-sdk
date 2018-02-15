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
    public partial class ISmpHelpDlg : Form
    {
        public ISmpHelpDlg()
        {
            InitializeComponent();
        }

        private void TipOfTheDayDlgbtn_Click(object sender, EventArgs e)
        {
            ISmpHelp m_SmpHelp;

            m_SmpHelp = new SmpHelpClass();

            m_SmpHelp.InvokeTipOfTheDayDlg();
        }


        private void InvokeRegisterbtn_Click(object sender, EventArgs e)
        {
            ISmpHelp m_SmpHelp;

            m_SmpHelp = new SmpHelpClass();

            m_SmpHelp.InvokeRegisterDlg();
        }

        private void AboutBoxbtn_Click(object sender, EventArgs e)
        {
            ISmpHelp m_SmpHelp;

            m_SmpHelp = new SmpHelpClass();

            m_SmpHelp.InvokeAboutBoxDlg();
        }

        private void HelTopicsbtn_Click(object sender, EventArgs e)
        {
            ISmpHelp m_SmpHelp;

            m_SmpHelp = new SmpHelpClass();

            string strHlpFliPath;

            strHlpFliPath = m_SmpHelp.HelpFilePath;

            m_SmpHelp.InvokeHelpTopics(strHlpFliPath);
        }

        private void MenuShortcutKeybtn_Click(object sender, EventArgs e)
        {
            ISmpHelp m_SmpHelp;

            m_SmpHelp = new SmpHelpClass();

            m_SmpHelp.InvokeMenuShortcutKeyDlg();
        }
    }
}