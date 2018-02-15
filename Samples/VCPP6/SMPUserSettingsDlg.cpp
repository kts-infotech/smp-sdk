// SMPUserSettingsDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPUserSettingsDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPUserSettingsDlg dialog


CSMPUserSettingsDlg::CSMPUserSettingsDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPUserSettingsDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPUserSettingsDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSMPUserSettingsDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPUserSettingsDlg)
	DDX_Control(pDX, IDC_BUTTON_LOGIN, m_Login);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPUserSettingsDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPUserSettingsDlg)
	ON_BN_CLICKED(IDC_BUTTON_LOGIN, OnButtonLogin)
	ON_BN_CLICKED(IDC_BUTTON_CHNGE_PASS, OnButtonChngePass)
	ON_WM_TIMER()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPUserSettingsDlg message handlers

void CSMPUserSettingsDlg::OnButtonLogin() 
{
	if(SUCCEEDED(hr))
	{
        m_SmpUser->InvokeLoginUserDlg();
	}
}

void CSMPUserSettingsDlg::OnButtonChngePass() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpUser->InvokeChangePasswordDlg();
	}	
}

BOOL CSMPUserSettingsDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	hr = m_SmpUser.CoCreateInstance(CLSID_SmpUser); 
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSMPUserSettingsDlg::OnTimer(UINT nIDEvent) 
{
}
