// Transaction.cpp : implementation file
//

#include "stdafx.h"
#include"resource.h"
#include "Transaction.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CTransaction dialog


CTransaction::CTransaction(CWnd* pParent /*=NULL*/)
	: CDialog(CTransaction::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTransaction)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CTransaction::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTransaction)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CTransaction, CDialog)
	//{{AFX_MSG_MAP(CTransaction)
	ON_BN_CLICKED(IDC_BUTTON_AD_MISC_XPNSE, OnButtonAdMiscXpnse)
	ON_BN_CLICKED(IDC_BUTTON_AD_MSC_INCME, OnButtonAdMscIncme)
	ON_BN_CLICKED(IDC_BUTTON_AD_TRNSTION, OnButtonAdTrnstion)
	ON_BN_CLICKED(IDC_BUTTON_CNCL_TRANSTION, OnButtonCnclTranstion)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_MISC_XPENSE, OnButtonEditMiscXpense)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_MISC_INCME, OnButtonEditMiscIncme)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_TRANSTION, OnButtonEditTranstion)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTransaction message handlers

BOOL CTransaction::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr=m_Transaction.CoCreateInstance(CLSID_Transactions);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Transaction Settings Failed"));
		return FALSE;
	}
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CTransaction::OnButtonAdMiscXpnse() 
{
	if(E_FAIL==m_Transaction->InvokeAddMiscExpenseDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}

}

void CTransaction::OnButtonAdMscIncme() 
{
	if(E_FAIL==m_Transaction->InvokeAddMiscIncomeDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}

void CTransaction::OnButtonAdTrnstion() 
{
	if(E_FAIL==m_Transaction->InvokeAddTransactionDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}

void CTransaction::OnButtonCnclTranstion() 
{
	if(E_FAIL==m_Transaction->InvokeCancelTransactionDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}

void CTransaction::OnButtonEditMiscXpense() 
{
	if(E_FAIL==m_Transaction->InvokeEditMiscExpenseDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}

void CTransaction::OnButtonEditMiscIncme() 
{
	if(E_FAIL==m_Transaction->InvokeEditMiscIncomeDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}

void CTransaction::OnButtonEditTranstion() 
{
	if(E_FAIL==m_Transaction->InvokeEditTransactionDlg())
	{
		AfxMessageBox(_T("Access denied"));
	}
	
}
