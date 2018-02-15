// SMPHelpDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPHelpDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPHelpDlg dialog


CSMPHelpDlg::CSMPHelpDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPHelpDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPHelpDlg)
	//}}AFX_DATA_INIT
}


void CSMPHelpDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPHelpDlg)
	//DDX_Control(pDX, IDC_EDIT_FILE_LOC, m_HelpFilepath);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPHelpDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPHelpDlg)
	ON_BN_CLICKED(IDC_BUTTON_ABOUT, OnButtonAbout)
	ON_BN_CLICKED(IDC_BUTTON_TIP, OnButtonTip)
	ON_BN_CLICKED(IDC_BUTTON_SHORTKEY, OnButtonShortkey)
	ON_BN_CLICKED(IDC_BUTTON_HELP, OnButtonHelp)
	ON_BN_CLICKED(IDC_BUTTON_REGISTER, OnButtonRegister)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPHelpDlg message handlers

void CSMPHelpDlg::OnButtonAbout() 
{
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{
        m_SMPHelp->InvokeAboutBoxDlg();
	}

}

BOOL CSMPHelpDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{        
		m_SMPHelp->get_HelpFilePath(&strfile);
	}    
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSMPHelpDlg::OnButtonTip() 
{
	// TODO: Add your control notification handler code here
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{
        m_SMPHelp->InvokeTipOfTheDayDlg();
	}
}

void CSMPHelpDlg::OnButtonShortkey() 
{
	// TODO: Add your control notification handler code here
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{
        m_SMPHelp->InvokeMenuShortcutKeyDlg();
	}
}

void CSMPHelpDlg::OnButtonHelp() 
{
	// TODO: Add your control notification handler code here
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{
        m_SMPHelp->InvokeHelpTopics(strfile);
	}
}

void CSMPHelpDlg::OnButtonRegister() 
{
	// TODO: Add your control notification handler code here
	CComPtr<ISmpHelp>m_SMPHelp; 
	HRESULT hr = m_SMPHelp.CoCreateInstance(CLSID_SmpHelp);
	if(SUCCEEDED(hr))
	{
        m_SMPHelp->InvokeRegisterDlg();
	}
}
