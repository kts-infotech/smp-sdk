// ISalesCheckoutDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "ISalesCheckoutDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CISalesCheckoutDlg dialog


CISalesCheckoutDlg::CISalesCheckoutDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CISalesCheckoutDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CISalesCheckoutDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CISalesCheckoutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CISalesCheckoutDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CISalesCheckoutDlg, CDialog)
	//{{AFX_MSG_MAP(CISalesCheckoutDlg)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_SALESCHECKOUTDLG, OnButtonInvokeSalescheckoutdlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CISalesCheckoutDlg message handlers

void CISalesCheckoutDlg::OnButtonInvokeSalescheckoutdlg() 
{
	HRESULT hr=m_ISalesCheckout->InvokeSalesCheckoutDlg();
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Invoke SalesCheckoutDlg failed"));
	}
}

BOOL CISalesCheckoutDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr;
	hr=m_ISalesCheckout.CoCreateInstance(CLSID_SalesCheckout);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("ISalesCheckout Interface initialisation failed"));
		return FALSE;
	}	
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
