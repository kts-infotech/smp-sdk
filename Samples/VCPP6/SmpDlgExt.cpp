// ISmpDialogExt Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::AddCustomerPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;
	m_StockItemSDKTestPage->SetMessage(_T("Add Customer SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddSetupPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;
	m_StockItemSDKTestPage->SetMessage(_T("Add Setup SDK Test Pages"));

	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddDeleteOldDataPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	m_StockItemSDKTestPage->SetMessage(_T("Add Delete Old Data SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddShopPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	m_StockItemSDKTestPage->SetMessage(_T("Add Shop SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddManageUserPages(VARIANT pSheet)
{

	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNOCANCEL);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
    else if(iRes==IDCANCEL)
	{
		return E_NOTIMPL;
	}
	//Check for the Operation of POSDefaultSettings Dialog
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	m_StockItemSDKTestPage->SetMessage(_T("Manage User SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);

	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddTransactionPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}
	//Check for the Operation of POSDefaultSettings Dialog
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	m_StockItemSDKTestPage->SetMessage(_T("Transaction SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::AddAboutBoxPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	int iRes=AfxMessageBox(_T("This SDK Test routine will remove the first page in Manage User and Add Plugin Page. Do you want to remove the page?"),MB_YESNO);
	if(iRes==IDYES)
	{
		pStockSheet->RemovePage(0);
	}

	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	m_StockItemSDKTestPage->SetMessage(_T("Add About Box SDK Test Pages"));
	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
