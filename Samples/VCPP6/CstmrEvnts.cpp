// ICustomerEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"

STDMETHODIMP CSMPCPPAddin::OnCustomerDelete(BSTR strCustomerID)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	
	CString strCustID=strCustomerID;
	CString strCustomer=_T("Deleting Customer " + strCustID +  ".....What do you want to return TRUE or FALSE?");
	
	if(IDYES==MessageBox(NULL,strCustomer,_T("Customer Delete Event"),MB_YESNO|MB_ICONQUESTION))
	{
		return S_OK;
	}
	else
	{
		return E_FAIL;
	}
}

STDMETHODIMP CSMPCPPAddin::OnShowCustomerDetails(BSTR strCustID, VARIANT varGenericReport)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	try
	{
		CString strCustmrID(strCustID);
		CString strCustomer;
		strCustomer.Format(_T("Showing Customer Details of %s.....What do you want to return TRUE or FALSE?"), strCustmrID);

		if(IDYES==MessageBox(NULL,strCustomer,_T("Add Customer Event"),MB_YESNO|MB_ICONQUESTION))
		{
			return S_OK;
		}
		else
		{
			return E_FAIL;
		}
	}
	catch(_com_error &err)
	{
		BSTR bstrerr=err.Description();
		CString strErr(bstrerr);
		AfxMessageBox(strErr);
	}
	catch(...)
	{
		AfxMessageBox(_T("Unknown Error"));
	}
	return E_FAIL;
}
STDMETHODIMP CSMPCPPAddin::OnCustomerAdd(BSTR strCustomerID)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CString strCustID=strCustomerID;
	CString strCustomer=_T("Adding Customer " + strCustID +  ".....What do you want to return TRUE or FALSE?");
	
	if(IDYES==MessageBox(NULL,strCustomer,_T("Add Customer Event"),MB_YESNO|MB_ICONQUESTION))
	{
		return S_OK;
	}
	else
	{
		return E_FAIL;
	}

}
STDMETHODIMP CSMPCPPAddin::OnCustomerEdit(BSTR strCustomerID)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CString strCustID=strCustomerID;
	CString strCustomer=_T("Updating Customer " + strCustID +  ".....What do you want to return TRUE or FALSE?");
	
	if(IDYES==MessageBox(NULL,strCustomer,_T("Edit Customer Event"),MB_YESNO|MB_ICONQUESTION))
	{
		return S_OK;
	}
	else
	{
		return E_FAIL;
	}

}