// UsingIAccountsInterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "UsingIAccountsInterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CUsingIAccountsInterfaceDlg dialog


CUsingIAccountsInterfaceDlg::CUsingIAccountsInterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CUsingIAccountsInterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CUsingIAccountsInterfaceDlg)
	//}}AFX_DATA_INIT
}


void CUsingIAccountsInterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CUsingIAccountsInterfaceDlg)
	DDX_Control(pDX, IDC_EDIT_SUBTRACT_FRM_SHOP_BALANCE, m_EditSubVal);
	DDX_Control(pDX, IDC_EDIT_ADD_TO_SHOP_BALANCE, m_EditAddVal);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CUsingIAccountsInterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(CUsingIAccountsInterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_ACCEPT_PAYMENT_DLG, OnButtonInvokeAcceptPaymentDlg)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_REFUND_TO_CUSTOMER, OnButtonInvokeRefundToCustomer)
	ON_BN_CLICKED(IDC_BUTTON_ADD_TO_SHOP_BALANCE, OnButtonAddToShopBalance)
	ON_BN_CLICKED(IDC_BUTTON_SUB_FROM_SHOP_BALANCE, OnButtonSubFromShopBalance)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CUsingIAccountsInterfaceDlg message handlers

void CUsingIAccountsInterfaceDlg::OnButtonInvokeAcceptPaymentDlg() 
{
	try
	{
		VARIANT varCusId;
		varCusId.iVal=1;
		m_IAccountsInterface->InvokeAcceptPaymentDialog(varCusId);
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while invoking AcceptPaymentDialog"));
	}
}

BOOL CUsingIAccountsInterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr;
	hr=m_IAccountsInterface.CoCreateInstance(CLSID_Accounts);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("IAccountsInterface initialisation failed"));
		return FALSE;
	}
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CUsingIAccountsInterfaceDlg::OnButtonInvokeRefundToCustomer() 
{
	try
	{
		VARIANT varCusId;
		varCusId.iVal=1;
		m_IAccountsInterface->InvokeRefundToCustomerDlg(varCusId);
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while invoking RefundToCustomerDlg"));
	}
}

void CUsingIAccountsInterfaceDlg::OnButtonAddToShopBalance() 
{
	try
	{
		double dVal;
		CString strAddVal;
		m_EditAddVal.GetWindowText(strAddVal);
		if(strAddVal!="")
		{
			try
			{
#ifdef UNICODE
				dVal = wcstod((strAddVal), NULL);
#else
				dVal=atof((LPCTSTR)strAddVal);
#endif
				if(dVal<=0)
				{
					AfxMessageBox(_T("Please check the value you have entered"));
					return;
				}
			}
			catch(...)
			{
				AfxMessageBox(_T("Please enter a valid value"));
				return;
			}
			BOOL bet=m_IAccountsInterface->AddToShopBalance(dVal);
			if(bet)
			{
				AfxMessageBox(_T("Value successfully added to the shop balance"));
			}
			else
			{
				AfxMessageBox(_T("Failed too add value to the shop balance"));
			}
		}
		else
		{
			AfxMessageBox(_T("Please enter value for adding to the shop balance"));
			return;
		}
		
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while adding value to the shop balance"));
	}
}

void CUsingIAccountsInterfaceDlg::OnButtonSubFromShopBalance() 
{
	try
	{
		double dVal;
		CString strSubVal;
		m_EditSubVal.GetWindowText(strSubVal);
		if(strSubVal!="")
		{
			try
			{
#ifdef UNICODE
				dVal = wcstod((strSubVal), NULL);
#else
				dVal=atof((LPCTSTR)strSubVal);
#endif

				if(dVal<=0)
				{
					AfxMessageBox(_T("Please check the value you have entered"));
					return;
				}
			}
			catch(...)
			{
				AfxMessageBox(_T("Please enter a valid value"));
				return;
			}

			long lVal=m_IAccountsInterface->SubstractFromShopBalance(dVal);

			if(lVal>0)
			{
				AfxMessageBox(_T("Value successfully substracted from the shop balance"));
			}
			else
			{
				AfxMessageBox(_T("Failed to substract value from the shop balance"));
			}
		}
		else
		{
			AfxMessageBox(_T("Please enter value for substracting from the shop balance"));
			return;
		}
		
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while substracting value from the shop balance"));
	}		
}
