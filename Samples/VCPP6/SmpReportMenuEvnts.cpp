//SmpReportMenuEvnts
// IISmpReportMenuEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnMonthlyStatisticsReport(BSTR strMonth, BSTR strYear, VARIANT varGenericReport)
{
	/*
    CComPtr<IISmpGenericReport>m_IISmpGenericReport;
	CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes;
	m_SMPReportItemAttributes.CoCreateInstance(CLSID_SmpReportItemAttributes);
    CComPtr<IItem> item;
	HRESULT hr1=item.CoCreateInstance(CLSID_Item);

	m_IISmpGenericReport=(IISmpGenericReport*)varGenericReport.pdispVal;
	m_IISmpGenericReport->get_BodyProperties(&m_SMPReportItemAttributes.p);
	long lVal;
	m_SMPReportItemAttributes->get_ItemCount(&lVal);
	for(int i=0;i<lVal;i++)
	{
		m_IISmpGenericReport->get_BodyItem(i,&item.p);		
		BSTR name;
		item->get_Content(&name);
		CString strNmae(name);
		AfxMessageBox(strNmae);
	}
	*/
	AfxMessageBox(_T("Monthly statistics report event for the month : "+(CString)strMonth)+"/"+(CString)strYear);

	return S_OK;
}
STDMETHODIMP CSMPCPPAddin::OnAnualStatisticsReport(BSTR strYear, VARIANT varGenericReport)
{
	AfxMessageBox(_T("Annual statistics report event for the year : "+(CString)strYear));
	return S_OK;
}