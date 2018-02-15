// ISalesCheckoutEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnCheckout(BSTR strSalesTransID)
{
	CString strComment=_T("Sales TansactionID : ");
	 CString strTransID(strSalesTransID);
	 strComment+=strTransID;

	AfxMessageBox(strComment);
	return E_NOTIMPL;
}