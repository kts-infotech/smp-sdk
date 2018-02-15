// SMPUserEventDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPUserEventDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPUserEventDlg property page

IMPLEMENT_DYNCREATE(CSMPUserEventDlg, CPropertyPage)

CSMPUserEventDlg::CSMPUserEventDlg() : CPropertyPage(CSMPUserEventDlg::IDD)
{
	//{{AFX_DATA_INIT(CSMPUserEventDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

CSMPUserEventDlg::~CSMPUserEventDlg()
{
}

void CSMPUserEventDlg::DoDataExchange(CDataExchange* pDX)
{
	CPropertyPage::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPUserEventDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPUserEventDlg, CPropertyPage)
	//{{AFX_MSG_MAP(CSMPUserEventDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPUserEventDlg message handlers

void CSMPUserEventDlg::OnOK() 
{
    AfxMessageBox(_T("Successfully loggedin"));	
	//CPropertyPage::OnOK();
}

void CSMPUserEventDlg::OnCancel() 
{
	AfxMessageBox(_T("CSMPUserEventDlg::OnCancel()"));	
	//CPropertyPage::OnCancel();
}
