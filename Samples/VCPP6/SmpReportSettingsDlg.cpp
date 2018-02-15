// SmpReportSettingsDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpReportSettingsDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpReportSettingsDlg dialog


CSmpReportSettingsDlg::CSmpReportSettingsDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpReportSettingsDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpReportSettingsDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpReportSettingsDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpReportSettingsDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpReportSettingsDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpReportSettingsDlg)
	ON_BN_CLICKED(IDC_BUTTON_BYPASSPRINT, OnButtonBypassprint)
	ON_BN_CLICKED(IDC_BUTTON_PRINTSHOPNAMEATHEADER, OnButtonPrintshopnameatheader)
	ON_BN_CLICKED(IDC_BUTTON_PRINTMEMBERSHIPFORM, OnButtonPrintmembershipform)
	ON_BN_CLICKED(IDC_BUTTON_PRINTTIMEATFOOTER, OnButtonPrinttimeatfooter)
	ON_BN_CLICKED(IDC_BUTTON_PRINTSHOPLOGO, OnButtonPrintshoplogo)
	ON_BN_CLICKED(IDC_BUTTON_PRINTPHNOATFOOTER, OnButtonPrintphnoatfooter)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpReportSettingsDlg message handlers

void CSmpReportSettingsDlg::OnButtonBypassprint() 
{
	// TODO: Add your control notification handler code here
	
    m_objCSmpReportSettingsDlg->get_BypassPrintDlg(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Bypass Print option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Bypass Print option is Disabled"));
	}
}

void CSmpReportSettingsDlg::OnButtonPrintshopnameatheader() 
{
	// TODO: Add your control notification handler code here
	m_objCSmpReportSettingsDlg->get_PrintShopNameAtHeader(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Print shop name at header option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Print shop name at header option is Disabled"));
	}
	
	
}

void CSmpReportSettingsDlg::OnButtonPrintmembershipform() 
{
	// TODO: Add your control notification handler code here
	 m_objCSmpReportSettingsDlg->get_AllwaysPrintMembershipForm(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Print membership form option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Print membership form option is Disabled"));
	}
	
}

void CSmpReportSettingsDlg::OnButtonPrinttimeatfooter() 
{
	// TODO: Add your control notification handler code here
	m_objCSmpReportSettingsDlg->get_PrintTimeAtFooter(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Print time at footer option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Print time at footer option is Disabled"));
	}
	
}

void CSmpReportSettingsDlg::OnButtonPrintshoplogo() 
{
	// TODO: Add your control notification handler code here
	m_objCSmpReportSettingsDlg->get_PrintShopLogo(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Print shoplogo option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Print shoplogo option is Disabled"));
	}
	
}

void CSmpReportSettingsDlg::OnButtonPrintphnoatfooter() 
{
	// TODO: Add your control notification handler code here
	m_objCSmpReportSettingsDlg->get_PrintPhNoAtFooter(&m_lValue);
	
	if(m_lValue==TRUE)
	{
		AfxMessageBox(_T("Print phone number at footer option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("Print phone number at footer option is Disabled"));
	}
	
	
}

BOOL CSmpReportSettingsDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr=m_objCSmpReportSettingsDlg.CoCreateInstance(CLSID_SmpReportSettings);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("SMPReportSettings Failed"));
		return FALSE;
	}
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

