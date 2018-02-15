// ISmpStockEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::AddStockItemPages(VARIANT pSheet)
{
	CPropertySheet* pStockSheet=(CPropertySheet*)pSheet.byref;	
    
	//Check for the Operation of POSDefaultSettings Dialog
	
	CComPtr<ISmpPluginTab> SmpPluginTab;	

	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;

	Var.byref = m_StockItemSDKTestPage;	

	m_StockItemSDKTestPage->m_pPropertySheet = pStockSheet;	

	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnAddStockItem(BSTR strItemID)
{
	MessageBox(NULL,CString(strItemID),_T("SDK Test"),MB_OK);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnDeleteStockItem(BSTR strItemID)
{
	CString strMsg;
	strMsg.Format(_T("Item %s will be deleted. Do you want to return E_FAIL from plugin.\nIt will stop deleting the item."),CString(strItemID));
	if(IDYES==MessageBox(NULL,strMsg,_T("SDK Test"),MB_YESNO))
	{
		return E_FAIL;
	}
	else
	{
		return S_OK;
	}
}
STDMETHODIMP CSMPCPPAddin::OnEditStockItem(BSTR strItemID)
{
	CString strMsg;
	strMsg.Format(_T("Item %s will be updated. Do you want to return E_FAIL from plugin.\nIt will stop updating the item."),CString(strItemID));
	if(IDYES==MessageBox(NULL,strMsg,_T("SDK Test"),MB_YESNO))
	{
		return E_FAIL;
	}
	else
	{
		return S_OK;
	}
}