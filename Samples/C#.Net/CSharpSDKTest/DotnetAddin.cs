using System;
using System.Runtime.InteropServices;
using SalesMatePlusLib;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;

//using System.Windows.Forms;

namespace CSharpSDKTest
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    /// 

    [ClassInterface(ClassInterfaceType.AutoDispatch)]

    //Change this GUID for your own plugin...

    [Guid("CA20D230-8AB6-4fe7-B77C-06C3F4D8CE28")]


    public class CAddinDotNet : SalesMatePlusLib.ISmpAddin, SalesMatePlusLib.ISmpPluginTabEvents, SalesMatePlusLib.ISmpDialogEvents, SalesMatePlusLib.SmpOEMEvents
    {
        //private Thread AddinFormThread;
        private ApplicationContext appContext = new ApplicationContext();
        private int lPluginTab;
        private const int OMP_TAB_VIEW_ID = -100;
        private const int SMP_WM_SIZE = 5;
        //private System.UInt32 lWindowHandle;
        public List <CMenuInfo> m_MenuInfoArray=new List<CMenuInfo>();       
        long m_lSessionID;
        //CReceiptsettings objReceiptsettings;
        public CAddinDotNet()
        {
            //
            // TODO: Add constructor logic here
            //
            //objReceiptsettings = new CReceiptsettings();
            lPluginTab = -1;
            m_lSessionID = -1;

        }



        #region Component Category Registration

        [ComRegisterFunction]

        [ComVisible(false)]

        public static void RegisterFunction(Type t)
        {

            string sKey = @"\CLSID\{" + t.GUID.ToString() + @"}\Implemented Categories";

            Microsoft.Win32.RegistryKey regKey
                = Microsoft.Win32.Registry.ClassesRoot
                .OpenSubKey(sKey, true);

            if (regKey != null)
            {

                regKey.CreateSubKey("{66DBC8C6-B4D0-48C4-988D-47D7B35E127B}");

            }

        }



        [ComUnregisterFunction]

        [ComVisible(false)]

        public static void UnregisterFunction(Type t)
        {

            string sKey = @"\CLSID\{" + t.GUID.ToString() + @"}\Implemented Categories";

            Microsoft.Win32.RegistryKey regKey
                = Microsoft.Win32.Registry.ClassesRoot
                .OpenSubKey(sKey, true);

            if (regKey != null)
            {

                regKey.DeleteSubKey("{66DBC8C6-B4D0-48C4-988D-47D7B35E127B}");

            }

        }

        #endregion


        #region ISmpAddin Members

        public void CheckCredentials(ref string pStrOrganizationName, ref string pStrKey)
        {
            // TODO:  Add CAddinDotNet.CheckCredentials implementation
            pStrOrganizationName = "SalesMate + C# Sample";
            pStrKey = "12206286";
        }

        public void InvokeAboutBox()
        {
            // TODO:  Add CAddinDotNet.InvokeAboutBox implementation
        }

        public void ApplicationLaunched()
        {
            // TODO:  Add CAddinDotNet.ApplicationLaunched implementation
            AddMenuInfo();
        }
        private void StartMessageLoop()
        {
            Application.Run(appContext);
        }
        private void ApplicationContext(object MainForm)
        {

        }

        public void InitializeDatabase(int lSessionID, ref int plStatus)
        {
            // TODO:  Add CAddinDotNet.InitializeDatabase implementation
        }

        public void DeleteOldData(string strSpecifiedDate)
        {
            // TODO:  Add CAddinDotNet.DeleteOldData implementation
        }

        void SalesMatePlusLib.ISmpAddin.Initialize(int lSessionID, SmpApp pApp, object bFirstTime)
        {
            m_lSessionID = lSessionID;

            // TODO:  Add CAddinDotNet.SalesMatePlusLib.ISmpAddin.Initialize implementation
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            //Read the embedded XML menu resource
            Stream rgbxml = thisAssembly.GetManifestResourceStream("CSharpSDKTest.AddinXML.xml");

            Stream rgbBmp = thisAssembly.GetManifestResourceStream("CSharpSDKTest.Bitmap1.bmp");

            Bitmap bmp = new Bitmap(rgbBmp);

            XmlDocument doc = new XmlDocument();
            doc.Load(rgbxml);
            string strMenuXML = doc.InnerXml;


            Stream Hidexml = thisAssembly.GetManifestResourceStream("CSharpSDKTest.ADDIN_SECURITY_INFO.xml");
            XmlDocument hide = new XmlDocument();
            hide.Load(Hidexml);
            string strMenuHide = hide.InnerXml;

            
            //MessageBox.Show(strMenuXML);
            IntPtr bitMapHandle = bmp.GetHbitmap();
            pApp.SetAddInInfo(lSessionID, 0, strMenuXML, (int)bitMapHandle, (int)bitMapHandle);
            pApp.SetAddinSecurityInfo(lSessionID, strMenuHide);

        }

        public void UpdateAddinCmdUI(int lCommandID, ref int pbEnable)
        {
             //TODO:  Add CAddinDotNet.UpdateAddinCmdUI implementation
            try
            {
                pbEnable=1;

                string strFunctionName=string.Empty;

                for(int lIndex=0; lIndex<m_MenuInfoArray.Count; lIndex++)
                {
                    for (int lCommandIndex = 0; lCommandIndex < m_MenuInfoArray[lIndex].m_CommandIDArray.Count; lCommandIndex++)
                    {
                        if(lCommandID == m_MenuInfoArray[lIndex].m_CommandIDArray[lCommandIndex])
                        {
                            strFunctionName=m_MenuInfoArray[lIndex].m_strFunctionName;

                            break;
                        }

                    }
                }

                ISecurity mSMPSecurity = new SecurityClass();
                int lValue=-1;

                if (("UsingISettingsInterface") == strFunctionName)
                    {
                        string strCSharpModuleName = "CSharp SecurityTest Module";
                        string strCSharpModuleSection = "Security Test Setup";
                        string strLeafNodeName = "Show Settings";
                        try
                        {
                            lValue = mSMPSecurity.get_UserRightInfo(strCSharpModuleName, strCSharpModuleSection, strLeafNodeName);
                        }
                        catch (Exception)
                        {
                        }
                        pbEnable=lValue;
                    }
                    
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
           
        }

        public void Uninitialize(int lSessionID)
        {
            // TODO:  Add CAddinDotNet.Uninitialize implementation
            GC.Collect();
        }

        #endregion

        public void Function1()
        {
            MessageBox.Show("Test");
        }

        public void UsingISmpReceiptSettingsInterface()
        {
            ReceiptsettingsDlg objReceiptsettingsDlg = new ReceiptsettingsDlg();

            objReceiptsettingsDlg.ShowDialog();
        }

        public void UsingISmpReportSettingsInterface()
        {
            ISmpReportSettingDlg objReportSettingDlg = new ISmpReportSettingDlg();

            objReportSettingDlg.ShowDialog();
        }

        public void UsingITransactionsInterface()
        {
            ITransactionDlg objTransactionDlg = new ITransactionDlg();

            objTransactionDlg.ShowDialog();
        }

        public void UsingISmpHelpInterface()
        {
            ISmpHelpDlg objHelpDlg = new ISmpHelpDlg();

            objHelpDlg.ShowDialog();
        }

        public void UsingISalesCheckoutInterface()
        {
            ISalesCheckOutDlg objSalesCheckOutDlg = new ISalesCheckOutDlg();

            objSalesCheckOutDlg.ShowDialog();
        }

        public void UsingISmpFileMenuOperationsInterface()
        {
            ISmpFileMenuOperationsDlg objSmpFileMenuOperations = new ISmpFileMenuOperationsDlg();

            objSmpFileMenuOperations.ShowDialog();
        }

        public void UsingISmpSetupInterface()
        {
            ISmpSetUpDlg objSmpSetupDlg = new ISmpSetUpDlg();

            objSmpSetupDlg.ShowDialog();
        }

        public void UsingISmpStockInterface()
        {
            ISmpStockDlg objSmpStockDlg = new ISmpStockDlg();

            objSmpStockDlg.ShowDialog();
        }

        public void UsingISmpUserInterface()
        {
            ISmpUserDlg objSmpUserDlg = new ISmpUserDlg();

            objSmpUserDlg.ShowDialog();
        }

        public void UsingISmpViewInterface()
        {
            ISmpViewDlg objSmpViewDlg = new ISmpViewDlg();

            objSmpViewDlg.ShowDialog();
        }

        public void UsingISmpReportMenuInterface()
        {
            ISmpReportMenuDlg objReportMenuDlg = new ISmpReportMenuDlg();

            objReportMenuDlg.ShowDialog();
        }

        public void UsingIAccountsInterface()
        {
            IAccountsDlg objIAccountsDlg = new IAccountsDlg();

            objIAccountsDlg.ShowDialog();

        }

        public void UsingICustomerInterface()
        {
            ICustomerDlg objCustomerDlg = new ICustomerDlg();

            objCustomerDlg.ShowDialog();
        }

        public void UsingIDatabaseMethods()
        {
            IDatabaseDlg objDatabaseDlg = new IDatabaseDlg();

            objDatabaseDlg.ShowDialog();
        }

        public void UsingISettingsInterface()
        {
            ISettingsDlg objSettingsDlg = new ISettingsDlg();

            objSettingsDlg.ShowDialog();
        }

        public void UsingISmpFrameInterface()
        {
            ISmpFrameDlg objFrameDlg = new ISmpFrameDlg();

            objFrameDlg.ShowDialog();
        }

        public void UsingIISmpCommandsInterface()
        {
            IISmpCommandsDlg objIISmpCommandsDlg = new IISmpCommandsDlg();

            objIISmpCommandsDlg.ShowDialog();
        }

        public void UsingISmpAppInterface()
        {
            ISmpAppDlg objSmpAppDlg = new ISmpAppDlg();

            objSmpAppDlg.ShowDialog();

        }

        public void UsingIReportsInterface()
        {
            IReportsDlg objReportsDlg = new IReportsDlg();
            objReportsDlg.ShowDialog();
        }

        public void UsingISmpReportInterface()
        {
            ISmpReportDlg objISmpReportDlg = new ISmpReportDlg();
            objISmpReportDlg.ShowDialog();
        }

        public void UsingISecurityInterface()
        {
            ISecurityDlg objISecurityDlg = new ISecurityDlg();
            objISecurityDlg.ShowDialog();
        }
        public void UsingISmpPluginTabInterface()
        {
            ISmpPluginTabDlg objISmpPluginTab = new ISmpPluginTabDlg();
            objISmpPluginTab.ShowDialog();
        }

        public void GenericReportUsingMethod()
        {
            IISmpGenericReportDlg objIISmpGenericReportDlg = new IISmpGenericReportDlg();
            objIISmpGenericReportDlg.ShowDialog();
        }

        public void GenericReportUsingAttribute()
        {
            ISmpReportItemAttributesDlg objISmpReportItemAttributesDlg = new ISmpReportItemAttributesDlg();
            objISmpReportItemAttributesDlg.ShowDialog();
        }
        public void UsingISmpGridInterface()
        {
            SmpGridDlg objSmpGridDlg = new SmpGridDlg();
            objSmpGridDlg.ShowDialog();



        }
        public void UsingIGridInterface()
        {
            IGridDlg objIGridDlg = new IGridDlg();
            objIGridDlg.ShowDialog();
        }
        public void UsingSmpGridCtrlInterface()
        {
            SmpGridCtrlDlg objSmpGridCtrlDlg = new SmpGridCtrlDlg();
            objSmpGridCtrlDlg.ShowDialog();
        }

        public void UsingSmpOEMEventsInterface()
        {
            SmpOEMEventsDlg objSmpOEMEventsDlg = new SmpOEMEventsDlg();
            objSmpOEMEventsDlg.ShowDialog();
        }

        #region ISmpPluginTabEvents Members

        public void OnSetCurView(int lCurViewIndex)
        {
            if (lPluginTab == lCurViewIndex)
            {

            }
            else
            {

            }
        }

        #endregion

        #region ISmpDialogEvents Members

        public void OnDialogWndProc(object hWndHandle, int lDialogID, int message, object wParam, object lParam, int lDialogeType)
        {
            switch (lDialogID)
            {
                case OMP_TAB_VIEW_ID:
                    {
                        switch (message)
                        {
                            case SMP_WM_SIZE:
                                {

                                    //MessageBox.Show(lDialogeType.ToString());
                                    if (lDialogeType == lPluginTab)
                                    {
                                        ISmpPluginTab PluginTab = new SmpPluginTab();
                                        int X = 0, Y = 0, Width = 0, Height = 0;
                                        PluginTab.GetWindowRect(lPluginTab, ref X, ref Y, ref Width, ref Height);

                                    }

                                    break;

                                }
                        }
                        break;
                    }

            }
        }

        #endregion

        #region ISmpOEMEvents Members

        public void InvokeCustomAccountsMenuDlg(int iMenuType)
        {
            switch (iMenuType)
            {
                case 32990:
                    MessageBox.Show("Successfully bypass Accept Payment Dlg");
                    break;
                case 32994:
                    MessageBox.Show("Successfully bypass Refund to customer Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomCustomerMenuDlg(int iMenuType)
        {
            switch (iMenuType)
            {
                case 32833:
                    MessageBox.Show("Successfully bypass Add Customer Dlg");
                    break;
                case 32837:
                    MessageBox.Show("Successfully bypass Edit Customer Dlg");
                    break;
                case 32870:
                    MessageBox.Show("Successfully bypass Delete Customer Dlg");
                    break;
                case 32835:
                    MessageBox.Show("Successfully bypass Find Customer Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomFileMenuDlg(int iMenuType)
        {
            switch (iMenuType)
            {
                case 32771:
                    MessageBox.Show("Successfully bypass Accept Payment Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomHelpMenuDlg(int iHelpMenuType)
        {
            switch (iHelpMenuType)
            {
                case 32931:
                    MessageBox.Show("Successfully bypass Register Dlg");
                    break;
                case 32797:
                    MessageBox.Show("Successfully bypass help Topics Dlg");
                    break;
                case 32988:
                    MessageBox.Show("Successfully bypass Menu ShortCut Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomReportMenuDlg(int iDlgType)
        {
            switch (iDlgType)
            {
                case 32825:
                    MessageBox.Show("Successfully bypass Daily Report Dlg");
                    break;
                case 32826:
                    MessageBox.Show("Successfully bypass Monthly Report Dlg");
                    break;
                case 32867:
                    MessageBox.Show("Successfully bypass Yearly Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomSalesMenuDlg(int iDialogType)
        {
            switch (iDialogType)
            {
                case 32810:
                    MessageBox.Show("Custom Dialog Here");
                    break;
                case 32811:
                    MessageBox.Show("Successfully bypass Add New Stock Item Dlg");
                    break;
                case 32976:
                    MessageBox.Show("Successfully bypass Modify Iteam Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomSetupMenuDlg(int iDialogType)
        {
            switch (iDialogType)
            {
                case 32787:
                    MessageBox.Show("Successfully bypass Currency settings Dlg");
                    break;
                case 32818:
                    MessageBox.Show("Successfully bypass Add Method of Payment Dlg");
                    break;
                case 32831:
                    MessageBox.Show("Successfully bypass Service Master Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomTransactionMenuDlg(int iDialogType)
        {
            switch (iDialogType)
            {
                case 32825:
                    MessageBox.Show("Successfully bypass Transaction Dlg");
                    break;
                case 32826:
                    MessageBox.Show("Successfully bypass Edit Transaction Dlg");
                    break;
                case 32867:
                    MessageBox.Show("Successfully bypass Cancel Transaction Dlg");
                    break;
            }
            return;
        }

        public void InvokeCustomViewMenu(int iMenuType)
        {
            switch (iMenuType)
            {
                case 32985:
                    MessageBox.Show("Successfully bypass Main Toolbar Dlg");
                    break;
                case 32868:
                    MessageBox.Show("Successfully bypass Full Screen Dlg");
                    break;
                case 32999:
                    MessageBox.Show("Successfully bypass Clear Dlg");
                    break;
            }
            return;
        }

        #endregion

        void LoadFunctionName(ref List<string> strFunctionNamesArray)
        {
            try
            {
                //strFunctionNamesArray.Add("UsingIAccountsInterface");

                strFunctionNamesArray.Add("UsingISettingsInterface");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return;

        }

        public void AddMenuInfo()
        {
            IISmpCommands SmpCommandsInfo = new ISmpCommandsClass();

            try
            {

                    List<string> strFunctionNamesArray = new List<string>();

                    LoadFunctionName(ref strFunctionNamesArray);

                    for(int iIndex=0;iIndex<strFunctionNamesArray.Count;iIndex++)
                    {
                        int lNoOfCommands=0;

                        string strFunctionName=strFunctionNamesArray[iIndex];

                        lNoOfCommands = SmpCommandsInfo.get_NoOfCommands(Convert.ToInt32(m_lSessionID), strFunctionName);

                        int plCommands = 0;

                        plCommands = SmpCommandsInfo.get_MenuCommandEx(Convert.ToInt32(m_lSessionID), strFunctionName);

                        CMenuInfo MenuInfo=new CMenuInfo();

                        MenuInfo.m_strFunctionName=strFunctionName;

                        for(int i=0;i<lNoOfCommands;i++)
                        {
                         
                            MenuInfo.m_CommandIDArray.Add(plCommands);
                        }
                        m_MenuInfoArray.Add(MenuInfo);
                       
                    }
              
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }


            }
        }
        public class CMenuInfo
        {

            public string m_strFunctionName;
            public List<int> m_CommandIDArray=new List<int>();

            public CMenuInfo()
            {
            }

            public CMenuInfo(CMenuInfo MenuInfo)
            {
                m_strFunctionName = MenuInfo.m_strFunctionName;

                m_CommandIDArray.AddRange(MenuInfo.m_CommandIDArray);
            }

        }
    }

