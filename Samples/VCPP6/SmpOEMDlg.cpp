// SmpOEMDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpOEMDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpOEMDlg dialog


CSmpOEMDlg::CSmpOEMDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpOEMDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpOEMDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpOEMDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpOEMDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpOEMDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpOEMDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpOEMDlg message handlers

BOOL CSmpOEMDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
