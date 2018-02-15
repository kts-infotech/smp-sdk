// SmpframeDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpframeDlg.h"
#include "afxcmn.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpframeDlg dialog


CSmpframeDlg::CSmpframeDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpframeDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpframeDlg)
	m_index = _T("");
	m_Panestatus = _T("");
	//}}AFX_DATA_INIT
}


void CSmpframeDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpframeDlg)
	DDX_Control(pDX, IDC_COMBO_RED, m_red);
	DDX_Control(pDX, IDC_COMBO_GREEN, m_green);
	DDX_Control(pDX, IDC_COMBO_BLUE, m_blue);
	DDX_Control(pDX, IDC_COMBO_PANE, m_pane);
	DDX_Control(pDX, IDC_EDIT_FRAME_OUTPUT, m_Frameoutput);
	DDX_Text(pDX, IDC_EDIT_INDEX, m_index);
	DDX_Text(pDX, IDC_EDIT_PANE_STATUS, m_Panestatus);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpframeDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpframeDlg)
	ON_BN_CLICKED(IDC_BUTTON_LEFT_TOOLBAR_HANDLE, OnButtonLeftToolbarHandle)
	ON_BN_CLICKED(IDC_BUTTON_MAIN_FRAME_HANDLE, OnButtonMainFrameHandle)
	ON_BN_CLICKED(IDC_BUTTON_MAIN_TOOLBAR_HANDLE, OnButtonMainToolbarHandle)
	ON_BN_CLICKED(IDC_BUTTON_MENU_HANDLE, OnButtonMenuHandle)
	ON_BN_CLICKED(IDC_BUTTON_PLUGIN_TOOLBAR_COUNT, OnButtonPluginToolbarCount)
	ON_BN_CLICKED(IDC_BUTTON_RIGHT_TOOLBAR_HANDLE, OnButtonRightToolbarHandle)
	ON_BN_CLICKED(IDC_BUTTON_STATUS_BAR_HANDLE, OnButtonStatusBarHandle)
	ON_BN_CLICKED(IDC_BUTTON_PLUGIN_TOOLBAR_HANDLE, OnButtonPluginToolbarHandle)
	ON_BN_CLICKED(IDC_BUTTON_SET_PANE_STATUS, OnButtonSetPaneStatus)
	ON_CBN_EDITCHANGE(IDC_COMBO_PANE, OnEditchangeComboPane)
	ON_BN_CLICKED(IDC_BUTTON_DELETE_MENU, OnButtonDeleteMenu)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpframeDlg message handlers

void CSmpframeDlg::OnButtonLeftToolbarHandle() 
{
	VARIANT var_val;
	m_ISmpFrame->get_LeftToolbarHandle(&var_val);

	CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);

	m_Frameoutput.SetWindowText(strWndTxt);


}

BOOL CSmpframeDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();

	for(int i=0;i<256;i++)
	{
		CString strindex;
		strindex.Format(_T("%d"),i);
		m_red.AddString(strindex);
		m_blue.AddString(strindex);
		m_green.AddString(strindex);
		
	}
	
	HRESULT hr = m_ISmpFrame.CoCreateInstance(CLSID_SmpFrame);

	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create com pointer"));
		return FALSE;
	}

		
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpframeDlg::OnButtonMainFrameHandle() 
{
	VARIANT var_val;
	::VariantInit(&var_val);
	m_ISmpFrame->get_MainFrameHandle(&var_val);
	CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);
	m_Frameoutput.SetWindowText(strWndTxt);
}

void CSmpframeDlg::OnButtonMainToolbarHandle() 
{
VARIANT var_val;
	::VariantInit(&var_val);
	m_ISmpFrame->get_MainToolbarHandle(&var_val);
	CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);
	m_Frameoutput.SetWindowText(strWndTxt);	
}

void CSmpframeDlg::OnButtonMenuHandle() 
{
	VARIANT var_val;
	::VariantInit(&var_val);
	m_ISmpFrame->get_MenuHandle(&var_val);
	CMenu* frmWndmen=CMenu::FromHandle((HMENU)var_val.byref);
	int nCnt=frmWndmen->GetMenuItemCount();
	//m_Frameoutput.SetWindowText(_T("The menu contain:%d items",nCnt));
	CString strout;
	strout.Format(_T("The menu contain: %d items"),nCnt);
	m_Frameoutput.SetWindowText(strout);
}

void CSmpframeDlg::OnButtonPluginToolbarCount() 
{
	/*VARIANT var_val;
	::VariantInit(&var_val);
	m_ISmpFrame->get_PluginToolbarCount(&var_val);
	CToolBar* frmWnd=CWnd::FromHandle((CToolBar)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);
	m_Frameoutput.SetWindowText(_T(strWndTxt));*/

	long lval;
	lval=0;

	m_ISmpFrame->get_PluginToolbarCount(&lval);

	CString str_PluginToolbarCount;
	str_PluginToolbarCount.Format(_T("%ld"),lval);

	m_Frameoutput.SetWindowText(str_PluginToolbarCount);
	
}

void CSmpframeDlg::OnButtonRightToolbarHandle() 
{
	VARIANT var_val;
	m_ISmpFrame->get_RightToolbarHandle(&var_val);

	CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);

	m_Frameoutput.SetWindowText(strWndTxt);
	
}

void CSmpframeDlg::OnButtonStatusBarHandle() 
{
	VARIANT var_val;
	m_ISmpFrame->get_StatusbarHandle(&var_val);

	CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
	CString strWndTxt;
	frmWnd->GetWindowText(strWndTxt);

	m_Frameoutput.SetWindowText(strWndTxt);
	
}

void CSmpframeDlg::OnButtonPluginToolbarHandle() 
{

	long lvalcnt;
	lvalcnt=0;
	long lval;
	lval=0;
	VARIANT var_val;

	m_ISmpFrame->get_PluginToolbarCount(&lvalcnt);

	//CString str_PluginToolbarCount;
	//str_PluginToolbarCount.Format(_T("%ld"),lval);
	//m_Frameoutput.SetWindowText(_T(str_PluginToolbarCount));

	if(lvalcnt>0)
	{
		UpdateData();
		m_index.TrimLeft();
		if(m_index.GetLength()>0)
		{
			m_index.Format(_T("%ld"),lval);

			m_ISmpFrame->get_PluginToolbarHandle(lval,&var_val);

			CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
			CString strWndTxt;
			frmWnd->GetWindowText(strWndTxt);

			AfxMessageBox(strWndTxt);
		}
		else
		{
			AfxMessageBox(_T("Enter an index first"));
		}
	}
	else
	{
		AfxMessageBox(_T("No Plugin Toolbar found"));

	}
	
}

void CSmpframeDlg::OnButtonSetPaneStatus() 
{
	long lval;
	BSTR bstr_statustext;
	lval=-1;
	lval=m_pane.GetCurSel();	

	if(lval<0)
	{
		AfxMessageBox(_T("Select an Index"));
	}

	else
	{
		UpdateData();
		m_Panestatus.TrimLeft();
		if(m_Panestatus.GetLength()>0)
		{
			bstr_statustext=m_Panestatus.AllocSysString();
			int ired,igreen,iblue;
			CString str_red,str_blue,str_green;

			m_red.GetWindowText(str_red);
			m_green.GetWindowText(str_green);
			m_blue.GetWindowText(str_blue);

			#ifdef UNICODE
							unsigned short  *stopstring;
							ired = wcstol((str_red),&stopstring,10);
							igreen = wcstol((str_green),&stopstring,10);
							iblue = wcstol((str_blue),&stopstring,10);
			#else
							ired=atoi(str_red);
							igreen=atoi(str_green);
							iblue=atoi(str_blue);
			#endif

			m_ISmpFrame->SetPaneStatusText(lval,bstr_statustext,(COLORREF)RGB(ired,igreen,iblue));
		}
		else
		{
			AfxMessageBox(_T("Enter a pane status"));
		}

	}
	
}

void CSmpframeDlg::OnEditchangeComboPane() 
{
	// TODO: Add your control notification handler code here
	
}

void CSmpframeDlg::OnButtonDeleteMenu() 
{
		VARIANT var_val;
	::VariantInit(&var_val);
	m_ISmpFrame->get_MenuHandle(&var_val);
	CMenu* frmWndmen=CMenu::FromHandle((HMENU)var_val.byref);
	if(frmWndmen->RemoveMenu(4,MF_BYPOSITION))
	{
		CDialog::OnOK();
	}
}
