// IAccountsEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnTransactionAccountDetails(LONG lType, VARIANT varValue1, VARIANT varValue2, VARIANT varValue3, VARIANT varValue4)
{    
	CString strVar=(CString)varValue1.bstrVal;
	if(lType==0)
	{
	  double dAmountRec=(double)varValue3.dblVal;
	  CString strAmountRec;
	  strAmountRec.Format(_T("%f"),dAmountRec);
	  AfxMessageBox(_T("Amount "+ strAmountRec +" is accepted from Customer : "+ strVar));
	}
	else
	{
	  double dAmountRet=(double)varValue4.dblVal;
	  CString strAmountRet;
	  strAmountRet.Format(_T("%f"),dAmountRet);
      AfxMessageBox(_T("Amount "+ strAmountRet+"is returned to Customer: "+strVar));
	}
	return E_NOTIMPL;
}
STDMETHODIMP CSMPCPPAddin::OnAccountReport(LONG lReportType, BSTR strValue1, BSTR strValue2, VARIANT varGenericReport)
{
	CComPtr<IISmpGenericReport> SmpGenericReport;
	IDispatch* pDispGR=varGenericReport.pdispVal;
	HRESULT hr=pDispGR->QueryInterface(IID_IISmpGenericReport,(void**)&SmpGenericReport);
	 
	if(SUCCEEDED(hr))
	{
	  
	}
	CString strVal1=(CString)strValue1;
	CString strVal2=(CString)strValue2;
	if(strVal2.GetLength()>0)
	{
       AfxMessageBox(_T("Account Report : "+ strVal1+" - "+strVal2));
	}
	else
	{
	    AfxMessageBox(_T("Account Report : "+ strVal1));
	}

	return E_NOTIMPL;
}
STDMETHODIMP CSMPCPPAddin::AddAdvancedReportPage(LONG lReportType, VARIANT pSheet)
{
    AfxMessageBox(_T("Showing AddAdvancedReportPage")); 
    CPropertySheet* pAdvancedReportSheet=(CPropertySheet*)pSheet.byref;
	CComPtr<ISmpPluginTab> SmpPluginTab;	
	SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
    VARIANT Var;
	Var.vt=VT_BYREF;
	Var.byref = m_pAccntsReportTestDlg;
	m_pAccntsReportTestDlg->pSheet=pAdvancedReportSheet;
	SmpPluginTab->AddSmpPage(Var);
	return E_NOTIMPL;
}