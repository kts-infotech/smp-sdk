using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesMatePlusLib;
using System.IO;
using System.Reflection;

namespace CSharpSDKTest
{
    public partial class ISmpPluginTabDlg : Form
    {
        int iView;
        int iFormView;
        ISmpPluginTab m_SmpPluginTab = new SmpPluginTab();


        public ISmpPluginTabDlg()
        {
            InitializeComponent();
            iView = 0;
            iFormView = 0;
        }

        private void buttonCreateView_Click(object sender, EventArgs e)
        {
            object vTabView = new object();
            vTabView = null;
            int m_lIndex=-1;
            iView = iView + 1;
            int iCount;
            iCount = iView;
            string strLabel = "View";
            strLabel = strLabel + iCount;
            string strToolTip ="View ToolTip";
            strToolTip = strToolTip + iCount;
            m_SmpPluginTab.CreateView(strLabel, strToolTip, ref vTabView, ref m_lIndex);
        }

        private void buttonCreateFormView_Click(object sender, EventArgs e)
        {
            object vTabView = new object();
            vTabView = null;
            int m_lIndex=-1;
            iFormView = iFormView+1;
            int iCount;
            iCount = iFormView;
            String strLabel = "FormView";
            strLabel = strLabel + iCount;
            String strToolTip = "FormView ToolTip";
            strToolTip = strToolTip + iCount;
            m_SmpPluginTab.CreateFormView(strLabel, strToolTip, ref vTabView, ref m_lIndex);
	
        }

        private void buttonCreateHTMLView_Click(object sender, EventArgs e)
        {
            
            int lIndex = 0;
            object pBrowserObj = new object();
            m_SmpPluginTab.CreateHtmlView("SalesMate + Site", "Tooltip", ref pBrowserObj, ref lIndex);

            SHDocVw.IWebBrowser2 pBrowser2 = (SHDocVw.IWebBrowser2)pBrowserObj;
            object Param1 = new object();
            object Param2= new object();
            object Param3= new object();
            object Param4 = new object();
            pBrowser2.Navigate("http://www.salesmateplus.com", ref Param1, ref Param2, ref Param3,ref Param4);
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxCurrentView.Text == "")
                {
                    m_SmpPluginTab.SetCurrentView(0);
                }
                else
                {
                    int lIndex = Convert.ToInt32(textBoxCurrentView.Text);
                    m_SmpPluginTab.SetCurrentView(lIndex);

                }

            }
            catch {
                m_SmpPluginTab.SetCurrentView(0);
            }
        }
    }
}