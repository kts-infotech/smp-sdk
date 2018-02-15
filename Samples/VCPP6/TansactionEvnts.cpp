// ITansactionEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnAddTransaction(BSTR strTransactionID)
{
	CString strComment=_T("TansactionID : ");
	CString strTransID(strTransactionID);
	strComment+=strTransID;
	MessageBox(NULL,strComment,_T("OnAddTransaction Event"),MB_ICONINFORMATION|MB_OK);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnEditTransaction(BSTR strTransactionID)
{
	CString strComment=_T("TansactionID : ");
	CString strTransID(strTransactionID);
	strComment+=strTransID;
	MessageBox(NULL,strComment,_T("OnEditTransaction Event"),MB_ICONINFORMATION|MB_OK);
	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnDeleteTransaction(BSTR strTansactionID)
{
	CString strComment=_T("TansactionID : ");
	CString strTransID(strTansactionID);
	strComment+=strTransID;
	MessageBox(NULL,strComment,_T("OnDeleteTransaction Event"),MB_ICONINFORMATION|MB_OK);
	return S_OK;
}