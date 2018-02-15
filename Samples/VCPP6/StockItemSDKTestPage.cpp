// StockItemSDKTestPage.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "StockItemSDKTestPage.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CStockItemSDKTestPage property page

IMPLEMENT_DYNCREATE(CStockItemSDKTestPage, CPropertyPage)

CStockItemSDKTestPage::CStockItemSDKTestPage() : CPropertyPage(CStockItemSDKTestPage::IDD)
{
	//{{AFX_DATA_INIT(CStockItemSDKTestPage)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	m_strMessage=_T("Add Stock Item SDK Test Page");
}

CStockItemSDKTestPage::~CStockItemSDKTestPage()
{
}

void CStockItemSDKTestPage::DoDataExchange(CDataExchange* pDX)
{
	CPropertyPage::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CStockItemSDKTestPage)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CStockItemSDKTestPage, CPropertyPage)
	//{{AFX_MSG_MAP(CStockItemSDKTestPage)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CStockItemSDKTestPage message handlers

void CStockItemSDKTestPage::OnOK() 
{
	// TODO: Add extra validation here
	AfxMessageBox(m_strMessage);
	return;
	//CPropertyPage::OnOK();
}

void CStockItemSDKTestPage::OnCancel() 
{
	// TODO: Add extra cleanup here
	return;
	//CPropertyPage::OnCancel();
}

void CStockItemSDKTestPage::SetMessage(CString strMsg)
{
	m_strMessage=strMsg;
}

LRESULT CStockItemSDKTestPage::WindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	// TODO: Add your specialized code here and/or call the base class
	
	return CPropertyPage::WindowProc(message, wParam, lParam);
}

BOOL CStockItemSDKTestPage::OnInitDialog() 
{
	CPropertyPage::OnInitDialog();
	
	// TODO: Add extra initialization here
	GetDlgItem(IDC_STATIC_MESSAGE)->SetWindowText(m_strMessage);
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
