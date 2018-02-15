// ISmpPluginTabEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"
#include "UsingIDatabaseMethodsDlg.h"
STDMETHODIMP CSMPCPPAddin::OnSetCurView(LONG lCurViewIndex)
{
	CString strMsg;
	strMsg.Format(_T("Tab Index %ld"),lCurViewIndex);
	::MessageBox(NULL,strMsg,_T("SDK Test"),MB_OK);

	return S_OK;
}