// AccntsReportTestDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "AccntsReportTestDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAccntsReportTestDlg property page

IMPLEMENT_DYNCREATE(CAccntsReportTestDlg, CPropertyPage)

CAccntsReportTestDlg::CAccntsReportTestDlg() : CPropertyPage(CAccntsReportTestDlg::IDD)
{
	//{{AFX_DATA_INIT(CAccntsReportTestDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

CAccntsReportTestDlg::~CAccntsReportTestDlg()
{
}

void CAccntsReportTestDlg::DoDataExchange(CDataExchange* pDX)
{
	CPropertyPage::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAccntsReportTestDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CAccntsReportTestDlg, CPropertyPage)
	//{{AFX_MSG_MAP(CAccntsReportTestDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CAccntsReportTestDlg message handlers

void CAccntsReportTestDlg::OnOK() 
{
	// TODO: Add extra validation here
	AfxMessageBox(_T("CAccntsReportTestDlg OK"));
	//CPropertyPage::OnOK();
}
