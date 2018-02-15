// SMPPluginTabDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPPluginTabDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPPluginTabDlg dialog


CSMPPluginTabDlg::CSMPPluginTabDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPPluginTabDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPPluginTabDlg)
	m_ViewIndex = _T("");
	//}}AFX_DATA_INIT
}


void CSMPPluginTabDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPPluginTabDlg)
	DDX_Text(pDX, IDC_EDIT1, m_ViewIndex);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPPluginTabDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPPluginTabDlg)
	ON_BN_CLICKED(IDC_BUTTON_CREATE_VIEW, OnButtonCreateView)
	ON_BN_CLICKED(IDC_BUTTON_CRTE_FORM_VIEW, OnButtonCrteFormView)
	ON_BN_CLICKED(IDC_BUTTON3, OnButton3)
	ON_BN_CLICKED(IDC_BUTTON_CREATE_HTML_VIEW, OnButtonCreateHtmlView)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPPluginTabDlg message handlers

BOOL CSMPPluginTabDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	iView=0;
	iFormView=0;
	HRESULT hr = m_SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("FAILED"));
		return FALSE;
	}
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}


void CSMPPluginTabDlg::OnButtonCreateView() 
{
	VARIANT vTabView;
	long m_lIndex;
	iView=iView++;
	CString strCount;
	strCount.Format(_T("%d"),iView);
	CString strLabel=_T("View");
	strLabel=strLabel+strCount;
	CString strToolTip=_T("View ToolTip");
	strToolTip=strToolTip+strCount;
	m_SmpPluginTab->CreateView(strLabel.AllocSysString(),strToolTip.AllocSysString(),&vTabView,&m_lIndex);	
}

void CSMPPluginTabDlg::OnButtonCrteFormView() 
{
	VARIANT vTabView;
	long m_lIndex;
	iFormView++;
	CString strCount;
	strCount.Format(_T("%d"),iFormView);
	CString strLabel=_T("FormView");
	strLabel=strLabel+strCount;
	CString strToolTip=_T("FormView ToolTip");
	strToolTip=strToolTip+strCount;
	m_SmpPluginTab->CreateFormView(strLabel.AllocSysString(),strToolTip.AllocSysString(),&vTabView,&m_lIndex);
	
	
}

void CSMPPluginTabDlg::OnButton3() 
{
	CString m_ViewCount;
	UpdateData(TRUE);
	m_ViewCount=m_ViewIndex;
	long lIndex;

	#ifdef UNICODE
    unsigned short  *stopstring;
    lIndex = wcstol((m_ViewCount),&stopstring,10);
    #else
    lIndex=atol((LPCTSTR)m_ViewCount);
    #endif
	m_SmpPluginTab->SetCurrentView(lIndex);
}

void CSMPPluginTabDlg::OnButtonCreateHtmlView() 
{
	// TODO: Add your control notification handler code here
	CComPtr<IDispatch> pBrowser;
	long lIndex;
	m_SmpPluginTab->CreateHtmlView(CComBSTR("SalesMate + Site"),CComBSTR("Tooltip"),&pBrowser,&lIndex);
	
	CComPtr<IWebBrowser2>    pBrowser2;
	
	pBrowser->QueryInterface(IID_IWebBrowser2,(void**)&pBrowser2);
	pBrowser2->Navigate(CComBSTR("http://www.salesmateplus.com"),NULL,NULL,NULL,NULL);

}
