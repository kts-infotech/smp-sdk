// ISmpSetupEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnSaveDefaultSettings()
{
	AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::OnSaveDefaultSettings()"));
	return E_NOTIMPL;
}

STDMETHODIMP CSMPCPPAddin::OnPluginInvokeSetupWizard()
{
	AfxMessageBox(_T("Test Sample Plugin Wizard"));
	return E_NOTIMPL;
}
