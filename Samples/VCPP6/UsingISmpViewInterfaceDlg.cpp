// UsingISmpViewInterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "UsingISmpViewInterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CUsingISmpViewInterfaceDlg dialog


CUsingISmpViewInterfaceDlg::CUsingISmpViewInterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CUsingISmpViewInterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CUsingISmpViewInterfaceDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CUsingISmpViewInterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CUsingISmpViewInterfaceDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CUsingISmpViewInterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(CUsingISmpViewInterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_REPORT, OnButtonPrintReport)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_IN_DOS_MODE, OnButtonPrintInDosMode)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CUsingISmpViewInterfaceDlg message handlers

void CUsingISmpViewInterfaceDlg::OnButtonPrintReport() 
{
	// TODO: Add your control notification handler code here
	HRESULT hr=m_ISmpView->PrintReport();
	if(S_OK!=hr)
	{
		AfxMessageBox(_T("Failed to call ISmpView::PrintReport"));
	}
}

void CUsingISmpViewInterfaceDlg::OnButtonPrintInDosMode() 
{
	// TODO: Add your control notification handler code here
	
}

void CUsingISmpViewInterfaceDlg::OnOK() 
{
	// TODO: Add extra validation here
	
	CDialog::OnOK();
}

BOOL CUsingISmpViewInterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr=m_ISmpView.CoCreateInstance(CLSID_SmpView);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create ISmpView object"));
	}
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
