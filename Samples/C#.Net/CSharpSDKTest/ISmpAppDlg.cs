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

    public partial class ISmpAppDlg : Form
    {
        public ISmpAppDlg()
        {
            InitializeComponent();
        }

        private void GetWindowbtn_Click(object sender, EventArgs e)
        {
            //ISmpApp m_ISmpApp;
            //m_ISmpApp = new SmpAppClass();
            //int iWindowHandle;
            //iWindowHandle = m_ISmpApp.WindowHandle;
            //IntPtr ipwindowhandle;
            //ipwindowhandle = (IntPtr)iWindowHandle;

            //Handle hTest;
            //hTest = (Handle)ipwindowhandle;
            //Control cwinhadl;
            //string test;
            //cwinhadl = FromHandle(ipwindowhandle);
            //test = cwinhadl.Text;
            //windowTxt.Text = test;
            //cwinhadl = Control.FromHandle(ipwindowhandle);

            //MessageBox.Show(cwinhadl.Text);


        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            ISmpApp m_SmpApp;
            m_SmpApp = new SmpAppClass();
            string strSendStatus;
            strSendStatus = SendStatusTxt.Text;
            if (strSendStatus == "")
            {
                MessageBox.Show("Enter the status");
            }
            else

                m_SmpApp.SendStatus(strSendStatus);
        }

        private void setaddininfobtn_Click(object sender, EventArgs e)
        {
            //ISmpApp m_SmpApp;
            //m_SmpApp = new SmpAppClass();
            //m_SmpApp.
        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddinSecurityinfotxt_Click(object sender, EventArgs e)
        {
            //ISmpApp m_SmpApp;
            //m_SmpApp = new SmpAppClass();
            //int isessionId;
            //m_SmpApp.
        }

    }
}