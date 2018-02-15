// ISmpUserEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnUserLogin(BSTR strUserLoginName)
{
	CString	strName;
	
	strName=strUserLoginName;
	CString strMsg(strName);
	strMsg+=_T("  Logged in");
	AfxMessageBox(strMsg);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnUserLogout(BSTR strUserLoginName)
{
	CString	strName;
	
	strName=strUserLoginName;
	CString strMsg(strName);
	strMsg+=_T("  Logged out");
	AfxMessageBox(strMsg);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::AddLoginUserPages(VARIANT pSheet)
{
	//AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CPropertySheet* pAddLoginUserPages=(CPropertySheet*)pSheet.byref;
		
	CComPtr<ISmpPluginTab> SmpPluginTab;
	
	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	VARIANT Var;
	Var.vt=VT_BYREF;
    
	Var.byref=m_SMPUserEventDlg;
	//m_SMPUserEventDlg->m_pPropertySheet=pAddLoginUserPages;
	SmpPluginTab->AddSmpPage(Var);
	return S_OK;
}