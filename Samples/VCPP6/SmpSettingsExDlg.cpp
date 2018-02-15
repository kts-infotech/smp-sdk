// SmpSettingsExDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpSettingsExDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpSettingsExDlg dialog


CSmpSettingsExDlg::CSmpSettingsExDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpSettingsExDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpSettingsExDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpSettingsExDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpSettingsExDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpSettingsExDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpSettingsExDlg)
	ON_BN_CLICKED(IDC_BUTTON_RELOAD_ALL_APPLICATIONSETTINGS, OnButtonReloadAllApplicationsettings)
	ON_BN_CLICKED(IDC_BUTTON_RELOAD_ALL_DEFAULTSETTINGS, OnButtonReloadAllDefaultsettings)
	ON_BN_CLICKED(IDC_BUTTON_RELOAD_ALL_LOCALSETTINGS, OnButtonReloadAllLocalsettings)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpSettingsExDlg message handlers

BOOL CSmpSettingsExDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr=m_objSmpSettingsExDlg.CoCreateInstance(CLSID_SmpSettingsEx);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("SmpSettingsExDlg Failed"));
		return FALSE;
	}
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpSettingsExDlg::OnButtonReloadAllApplicationsettings() 
{
	m_objSmpSettingsExDlg->ReloadAllApplicationSettings();
	AfxMessageBox(_T("Application Settings are Loaded Successfully."));	
}

void CSmpSettingsExDlg::OnButtonReloadAllDefaultsettings() 
{
	m_objSmpSettingsExDlg->ReloadAllDefaultSettings();
	AfxMessageBox(_T("Default Settings are Loaded Successfully."));	
}

void CSmpSettingsExDlg::OnButtonReloadAllLocalsettings() 
{
	m_objSmpSettingsExDlg->ReloadAllLocalSettings();
	AfxMessageBox(_T("All Local Settings are Loaded Successfully."));	
}
