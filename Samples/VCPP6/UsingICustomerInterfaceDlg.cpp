// UsingICustomerInterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "UsingICustomerInterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// UsingICustomerInterfaceDlg dialog


UsingICustomerInterfaceDlg::UsingICustomerInterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(UsingICustomerInterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(UsingICustomerInterfaceDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void UsingICustomerInterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(UsingICustomerInterfaceDlg)
	DDX_Control(pDX, IDC_EDIT_FIELDNAME, m_EditFieldName);
	DDX_Control(pDX, IDC_EDIT_CUSTOMER_ID, m_EditCustId);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(UsingICustomerInterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(UsingICustomerInterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_FIND, OnButtonFind)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_FINDCUSTOMER_DLG, OnButtonInvokeFindcustomerDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// UsingICustomerInterfaceDlg message handlers

void UsingICustomerInterfaceDlg::OnButtonFind() 
{
	try
	{
		CString strCustId,strFieldName;
		VARIANT Val;
		BSTR bstrCusId;
		//CString strCustDetails="";

		m_EditCustId.GetWindowText(strCustId);
		m_EditFieldName.GetWindowText(strFieldName);

		if(strCustId.GetLength()<=0||strFieldName.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter all the inputs"));
			return;
		}
		try
		{
			m_ICustomer->GetCustomerDetails(strCustId.AllocSysString(),strFieldName.AllocSysString(),&Val);
			bstrCusId=Val.bstrVal;
			CString strCustDetails(bstrCusId);
			strFieldName+=" Field Value";
			MessageBox(strCustDetails,strFieldName,MB_ICONINFORMATION|MB_OK);

		}
		catch(...)
		{
			AfxMessageBox(_T("Failed to get the customer details. Please check the values you have entered"));
			return;
		}
		
		
	}
	catch(CException ex)
	{
		AfxMessageBox(_T("Failed to get the customer details. Please check the values you have entered"));
	}
	catch(_com_error ex)
	{
		AfxMessageBox(_T("Failed to get the customer details. Please check the values you have entered"));
	}
	catch(...)
	{
		AfxMessageBox(_T("Failed to get the customer details. Please check the values you have entered"));
	}

}

BOOL UsingICustomerInterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr;
	hr=m_ICustomer.CoCreateInstance(CLSID_Customer);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("ICustomerInterface initialisation failed"));
		return FALSE;
	}	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void UsingICustomerInterfaceDlg::OnButtonInvokeFindcustomerDlg() 
{
	try
	{
		BSTR strVal;
		m_ICustomer->InvokeFindCustomerDlg(&strVal);
	}
	catch(...)
	{
		AfxMessageBox(_T("Failed to Invoke FindCustomerDlg"));
	}
}
