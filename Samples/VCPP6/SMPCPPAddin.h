// SMPCPPAddin.h : Declaration of the CSMPCPPAddin

#ifndef __SMPCPPADDIN_H_
#define __SMPCPPADDIN_H_

#include "resource.h"       // main symbols
#include "SDKTestApp.h"
#include "StockItemSDKTestPage.h"
#include "SMPUserEventDlg.h"
#include "AccntsReportTestDlg.h"
#include  "SmpGridControlDlg.h"

#import ".\SMPTLBFile\SalesMatePlus.tlb" raw_interfaces_only, raw_native_types, no_namespace, named_guids 

static const GUID CATID_SMP_ADDINS =
{ 0x66dbc8c6, 0xb4d0, 0x48c4, { 0x98, 0x8d, 0x47, 0xd7, 0xb3, 0x5e,0x12, 0x7b } };

#define ID_SALES_CHECKOUT               32815
#define ID_ACCOUNTS_ACCEPTPAYMENT       32990
#define ID_CUSTMER_ADD_CUSTOMER         32833
#define ID_ACCOUNTS_AMOUNTRETURN        32994
#define ID_CUSTOMER_EDITDELETECUSTOMER  32837
#define ID_CUSTOMER_DELETE              32870
#define ID_CUSTMER_FIND                 32835
#define ID_FILE_BACKUPDATABASE          32771
#define ID_HELP_REGISTER                32931
#define ID_HELP_HELPTOPICS              32797
#define ID_HELP_MENUSHORTCUTS           32988
#define ID_REPORTS_DAILYREPORTS         32825
#define ID_REPORTS_MONTHLYREPORTS       32826
#define ID_ACCOUNTS_YEARLY_REPORTS      32867
#define ID_SALES_ADD_NEW_STOCK_ITEM     32810
#define ID_SALES_MODIFY_ITEM            32811
#define ID_SALES_MODIFYSTOCKITEMPRICE   32976
#define ID_SETUP_CURRENCYSETTINGS       32787
#define ID_SETUP_ADDMETHODOFPAYMENT     32818
#define ID_SETUP_SERVICEMASTER          32831
#define ID_TRANSACTION_TRANSACTIONDETAILS 32801
#define ID_TRANSACTION_EDITTRANSACTIONDETAILS 32809
#define ID_TRANSACTION_CANCEL_TRANSACTION 32925
#define ID_VIEW_TOOLBAR_MAINTOOLBAR     32985
#define ID_VIEW_FULLSCREEN              32999
#define ID_VIEW_CLEAR_ALL               32868
/////////////////////////////////////////////////////////////////////////////
// CSMPCPPAddin
class ATL_NO_VTABLE CSMPCPPAddin : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CSMPCPPAddin, &CLSID_SMPCPPAddin>,
	public IDispatchImpl<ISMPCPPAddin, &IID_ISMPCPPAddin, &LIBID_SDKTESTLib>,
	public IDispatchImpl<ISmpAddin, &IID_ISmpAddin, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpDialogEvents, &IID_ISmpDialogEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpDialogExt, &IID_ISmpDialogExt, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<IAccountsEvents, &IID_IAccountsEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ICustomerEvents, &IID_ICustomerEvents, &LIBID_SalesMatePlusLib>,
	public ISalesCheckoutEvents,
	public IDispatchImpl<ISmpPluginTabEvents, &IID_ISmpPluginTabEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpSetupEvents, &IID_ISmpSetupEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpStockEvents, &IID_ISmpStockEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpUserEvents, &IID_ISmpUserEvents, &LIBID_SalesMatePlusLib>,
	public ITansactionEvents,
	public IDispatchImpl<IISmpReportMenuEvents, &IID_IISmpReportMenuEvents, &LIBID_SalesMatePlusLib>,
	public IDispatchImpl<ISmpOEMEvents, &IID_ISmpOEMEvents, &LIBID_SalesMatePlusLib>
{

		CStockItemSDKTestPage* m_StockItemSDKTestPage;
		CAccntsReportTestDlg *m_pAccntsReportTestDlg;
		CButton* m_SDKButton;
		CButton* m_SDKCheckBox;
public:
	CSMPCPPAddin()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_SMPCPPADDIN)

DECLARE_PROTECT_FINAL_CONSTRUCT()

BEGIN_COM_MAP(CSMPCPPAddin)
	COM_INTERFACE_ENTRY(ISMPCPPAddin)
//DEL 	COM_INTERFACE_ENTRY(IDispatch)
	COM_INTERFACE_ENTRY2(IDispatch, ISMPCPPAddin)
	COM_INTERFACE_ENTRY(ISmpAddin)
	COM_INTERFACE_ENTRY(ISmpDialogEvents)
	COM_INTERFACE_ENTRY(ISmpDialogExt)
	COM_INTERFACE_ENTRY(IAccountsEvents)
	COM_INTERFACE_ENTRY(ICustomerEvents)
	COM_INTERFACE_ENTRY(ISalesCheckoutEvents)
	COM_INTERFACE_ENTRY(ISmpPluginTabEvents)
	COM_INTERFACE_ENTRY(ISmpSetupEvents)
	COM_INTERFACE_ENTRY(ISmpStockEvents)
	COM_INTERFACE_ENTRY(ISmpUserEvents)
	COM_INTERFACE_ENTRY(ITansactionEvents)
	COM_INTERFACE_ENTRY(IISmpReportMenuEvents)
	COM_INTERFACE_ENTRY(ISmpOEMEvents)
END_COM_MAP()

BEGIN_CATEGORY_MAP(CSMPTestAddin)
   IMPLEMENTED_CATEGORY(CATID_SMP_ADDINS)
END_CATEGORY_MAP()

// ISMPCPPAddin
public:
	STDMETHOD(UsingISmpSettingsExInterface)();
	STDMETHOD(UsingSmpGridInterface)();
	STDMETHOD(UsingSmpGridControlMethod)();
	STDMETHOD(UsingISmpOEMEventsInterface)();
	STDMETHOD(UsingISmpOEMInterface)();
	CSMPUserEventDlg* m_SMPUserEventDlg;
	STDMETHOD(UsingITransactionsInterface)();
	STDMETHOD(UsingISmpViewInterface)();
	STDMETHOD(UsingISmpUserInterface)();
	STDMETHOD(UsingISmpStockInterface)();
	STDMETHOD(UsingISmpSetupInterface)();
	STDMETHOD(UsingISmpReportSettingsInterface)();
	STDMETHOD(UsingISmpReportMenuInterface)();
	STDMETHOD(UsingISmpReportInterface)();
	STDMETHOD(UsingISmpReceiptSettingsInterface)();
	STDMETHOD(UsingISmpPluginTabInterface)();
	STDMETHOD(UsingISmpHelpInterface)();
	STDMETHOD(UsingISmpFrameInterface)();
	STDMETHOD(UsingISmpFileMenuOperationsInterface)();
	STDMETHOD(UsingISmpAppInterface)();
	STDMETHOD(UsingISettingsInterface)();
	STDMETHOD(UsingISecurityInterface)();
	STDMETHOD(UsingISalesCheckoutInterface)();
	STDMETHOD(UsingIReportsInterface)();
	STDMETHOD(UsingIItemInterface)();
	STDMETHOD(UsingIISmpCommandsInterface)();
	STDMETHOD(UsingIGridInterface)();
	STDMETHOD(UsingIDatabaseMethods)();
	STDMETHOD(UsingICustomerInterface)();
	STDMETHOD(UsingIAccountsInterface)();
	BOOL LoadLongResource(CString &str, UINT nID);
	STDMETHOD(GenericReportUsingAttribute)();
	STDMETHOD(GenericReportUsingMethod)();
// ISmpAddin
	STDMETHOD(Initialize)(LONG lSessionID, ISmpApp * pApp, VARIANT bFirstTime)
	{
		AFX_MANAGE_STATE(AfxGetStaticModuleState())

		CString strXML,strSecurityXML;

		//Add the session id to global variable
		GetApp()->m_lSessionID=lSessionID;
		GetApp()->m_SmpApp=pApp;

//Store the session ID for later use;


		if(LoadLongResource(strXML,IDR_SDK_TEST_ADDIN_MENU))
		{
			strXML.Replace(_T("\n"),_T("")); //Replace all new line characters
			strXML.Replace(_T("\t"),_T("")); //Replace all tab characters

			HINSTANCE lAppHandle=AfxGetInstanceHandle();
			pApp->SetAddInInfo(lSessionID,(long)lAppHandle,strXML.AllocSysString(),IDR_CPP_ADINTOOLBAR,IDR_CPP_ADINTOOLBAR);
			
		}
		m_StockItemSDKTestPage = new CStockItemSDKTestPage();
		m_SMPUserEventDlg	   = new CSMPUserEventDlg();
		m_pAccntsReportTestDlg=new CAccntsReportTestDlg();

		m_SDKButton=new CButton();
		m_SDKCheckBox=new CButton();

		return S_OK;	
	}
	STDMETHOD(Uninitialize)(LONG lSessionID)
	{
		return E_NOTIMPL;
	}
	STDMETHOD(InitializeDatabase)(LONG lSessionID, LONG * plStatus)
	{
		return E_NOTIMPL;
	}
	STDMETHOD(UpdateAddinCmdUI)(LONG lCommandID, LONG * pbEnable)
	{
		return E_NOTIMPL;
	}
	STDMETHOD(DeleteOldData)(BSTR strSpecifiedDate)
	{
		return E_NOTIMPL;
	}
	STDMETHOD(ApplicationLaunched)()
	{
		CComPtr<ISmpOEM> SmpOEM;
		SmpOEM.CoCreateInstance(CLSID_SmpOEM);
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_CHECKOUT,TRUE);

		return S_OK;
	}
	STDMETHOD(InvokeAboutBox)()
	{
		return E_NOTIMPL;
	}
	STDMETHOD(CheckCredentials)(BSTR * pStrOrganizationName, BSTR * pStrKey)
	{
		/*********************************************************************************/
		//Please comment or remove these lines of code after getting your own company name
		/*********************************************************************************/
		*pStrOrganizationName=CString(_T("KTS InfoTech")).AllocSysString();
		*pStrKey=CString(_T("4484862")).AllocSysString();
		/*********************************************************************************/

		return S_OK;
		//return E_NOTIMPL;
	}
// ISmpDialogEvents
	STDMETHOD(OnDialogWndProc)(VARIANT hWndHandle, LONG lDialogID, LONG message, VARIANT wParam, VARIANT lParam, LONG lDialogeType);
// ISmpDialogExt
	STDMETHOD(AddCustomerPages)(VARIANT pSheet);
	STDMETHOD(AddSetupPages)(VARIANT pSheet);
	STDMETHOD(AddDeleteOldDataPages)(VARIANT pSheet);
	STDMETHOD(AddShopPages)(VARIANT pSheet);
	STDMETHOD(AddManageUserPages)(VARIANT pSheet);
	STDMETHOD(AddTransactionPages)(VARIANT pSheet);
	STDMETHOD(AddAboutBoxPages)(VARIANT pSheet);

// IAccountsEvents
	STDMETHOD(OnTransactionAccountDetails)(LONG lType, VARIANT varValue1, VARIANT varValue2, VARIANT varValue3, VARIANT varValue4);
	STDMETHOD(OnAccountReport)(LONG lReportType, BSTR strValue1, BSTR strValue2, VARIANT varGenericReport);
	STDMETHOD(AddAdvancedReportPage)(LONG lReportType, VARIANT pSheet);

// ICustomerEvents
	STDMETHOD(OnCustomerDelete)(BSTR strCustomerID);
	STDMETHOD(OnShowCustomerDetails)(BSTR strCustID, VARIANT varGenericReport);
	STDMETHOD(OnCustomerAdd)(BSTR strCustomerID);
	STDMETHOD(OnCustomerEdit)(BSTR strCustomerID);

// ISalesCheckoutEvents
	STDMETHOD(OnCheckout)(BSTR strSalesTransID);

// ISmpPluginTabEvents
	STDMETHOD(OnSetCurView)(LONG lCurViewIndex);

// ISmpSetupEvents
	STDMETHOD(OnSaveDefaultSettings)();
	STDMETHOD(OnPluginInvokeSetupWizard)();
// ISmpStockEvents
	STDMETHOD(OnAddStockItem)(BSTR strItemID);
	STDMETHOD(OnDeleteStockItem)(BSTR strItemID);
	STDMETHOD(OnEditStockItem)(BSTR strItemID);
	STDMETHOD(AddStockItemPages)(VARIANT pSheet);

// ISmpUserEvents
	STDMETHOD(OnUserLogin)(BSTR strUserLoginName);
	STDMETHOD(OnUserLogout)(BSTR strUserLoginName);
	STDMETHOD(AddLoginUserPages)(VARIANT pSheet);

// ITansactionEvents
	STDMETHOD(OnAddTransaction)(BSTR strTransactionID);
	STDMETHOD(OnEditTransaction)(BSTR strTransactionID);
	STDMETHOD(OnDeleteTransaction)(BSTR strTansactionID);
// IISmpReportMenuEvents
	STDMETHOD(OnMonthlyStatisticsReport)(BSTR strMonth, BSTR strYear, VARIANT varGenericReport);
	STDMETHOD(OnAnualStatisticsReport)(BSTR strYear, VARIANT varGenericReport);
// ISmpDialogEvents
// ISmpOEMEvents
	STDMETHOD(InvokeCustomFileMenuDlg)(LONG iMenuType)
	{
		switch(iMenuType)
		{
		case ID_FILE_BACKUPDATABASE:
			AfxMessageBox(_T("Successfully bypass Backup Data Dlg"));
			return S_OK;
	
		}
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomSetupMenuDlg)(LONG iDialogType)	     
	{
			switch(iDialogType)
		{
		case ID_SETUP_CURRENCYSETTINGS:
			AfxMessageBox(_T("Successfully bypass Currency settings Dlg"));
			return S_OK;
		case ID_SETUP_ADDMETHODOFPAYMENT:
			AfxMessageBox(_T("Successfully bypass Add Method of Payment Dlg"));
			return S_OK;
		case ID_SETUP_SERVICEMASTER:
			AfxMessageBox(_T("Successfully bypass Service Master Dlg"));
			return S_OK;
          
		}
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomViewMenu)(LONG iMenuType)     
	{
			switch(iMenuType)
		{
		case ID_VIEW_TOOLBAR_MAINTOOLBAR:
			AfxMessageBox(_T("Successfully bypass Main Toolbar Dlg"));
			return S_OK;
		case ID_VIEW_FULLSCREEN:
			AfxMessageBox(_T("Successfully bypass Full Screen Dlg"));
			return S_OK;
		case ID_VIEW_CLEAR_ALL:
			AfxMessageBox(_T("Successfully bypass Clear Dlg"));
			return S_OK;
		}
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomCustomerMenuDlg)(LONG iMenuType)
	{
		switch(iMenuType)
		{
		case ID_CUSTMER_ADD_CUSTOMER:
			AfxMessageBox(_T("Successfully bypass Add Customer Dlg"));
			return S_OK;
    	case ID_CUSTOMER_EDITDELETECUSTOMER:
			AfxMessageBox(_T("Successfully bypass Edit Customer Dlg"));
			return S_OK;
		case ID_CUSTOMER_DELETE:
			AfxMessageBox(_T("Successfully bypass Delete Customer Dlg"));
			return S_OK;
		case ID_CUSTMER_FIND:
			AfxMessageBox(_T("Successfully bypass Find Customer Dlg"));
			return S_OK;           
		}
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomTransactionMenuDlg)(LONG iDialogType)
	{

       switch(iDialogType)
		{
		case ID_TRANSACTION_TRANSACTIONDETAILS:
			AfxMessageBox(_T("Successfully bypass Transaction Dlg"));
			return S_OK;
		case ID_TRANSACTION_EDITTRANSACTIONDETAILS:
			AfxMessageBox(_T("Successfully bypass Edit Transaction Dlg"));
			return S_OK;
		case ID_TRANSACTION_CANCEL_TRANSACTION:
			AfxMessageBox(_T("Successfully bypass Cancel Transaction Dlg"));
			return S_OK;
		} 
  
 
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomSalesMenuDlg)(LONG iDialogType)
	{
		switch(iDialogType)
		{
		case ID_SALES_CHECKOUT:
			AfxMessageBox(_T("Custom Dialog Here"));
			//SmpPOSMainScreenPage();
			return S_OK;
           case  ID_SALES_ADD_NEW_STOCK_ITEM:
			AfxMessageBox(_T("Successfully bypass Add New Stock Item Dlg"));
			return S_OK;
			case  ID_SALES_MODIFY_ITEM:
			AfxMessageBox(_T("Successfully bypass Modify Iteam Dlg"));
			return S_OK;
         	case  ID_SALES_MODIFYSTOCKITEMPRICE:
			AfxMessageBox(_T("Successfully bypass Modify Stock Iteam Price Dlg"));
			return S_OK;
    	
		}
		return E_NOTIMPL;
	
	}
	STDMETHOD(InvokeCustomAccountsMenuDlg)(LONG iMenuType)
	{
		switch(iMenuType)
		{
		case ID_ACCOUNTS_ACCEPTPAYMENT:
			AfxMessageBox(_T("Successfully bypass Accept Payment Dlg"));
			return S_OK;
		case ID_ACCOUNTS_AMOUNTRETURN:
		    AfxMessageBox(_T("Successfully bypass Refund to customer Dlg"));
			return S_OK;
		}
		return E_NOTIMPL;
	}
	STDMETHOD(InvokeCustomReportMenuDlg)(LONG iDlgType)
	{
		switch(iDlgType)
		{
		case ID_REPORTS_DAILYREPORTS:
			AfxMessageBox(_T("Successfully bypass Daily Report Dlg"));
			return S_OK;
		case ID_REPORTS_MONTHLYREPORTS:
			AfxMessageBox(_T("Successfully bypass Monthly Report Dlg"));
			return S_OK;
		case ID_ACCOUNTS_YEARLY_REPORTS:
			AfxMessageBox(_T("Successfully bypass Yearly Dlg"));
			return S_OK;
		}
		return E_NOTIMPL;
	        
	}
	STDMETHOD(InvokeCustomHelpMenuDlg)(LONG iHelpMenuType)

	{
			switch(iHelpMenuType)
		{
		case ID_HELP_REGISTER:
			AfxMessageBox(_T("Successfully bypass Register Dlg"));
			return S_OK;
		case ID_HELP_HELPTOPICS:
			AfxMessageBox(_T("Successfully bypass help Topics Dlg"));
			return S_OK;
		case ID_HELP_MENUSHORTCUTS:
			AfxMessageBox(_T("Successfully bypass Menu ShortCut Dlg"));
			return S_OK;
       
		}
		return E_NOTIMPL;
	}
// ISmpOEMEvents
};

#endif //__SMPCPPADDIN_H_
