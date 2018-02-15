// SmpappinterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpappinterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpappinterfaceDlg dialog


CSmpappinterfaceDlg::CSmpappinterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpappinterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpappinterfaceDlg)
	m_sendstatus = _T("");
	//}}AFX_DATA_INIT
}


void CSmpappinterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpappinterfaceDlg)
	DDX_Control(pDX, IDC_EDIT_WINDOW_HANDLE, m_windowhandle);
	DDX_Text(pDX, IDC_EDIT_SEND_STATUS, m_sendstatus);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpappinterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpappinterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_GET_WINDOW_HANDLE, OnButtonGetWindowHandle)
	ON_BN_CLICKED(IDC_BUTTON_SEND_STATUS, OnButtonSendStatus)
	ON_BN_CLICKED(IDC_BUTTON_SET_ADDIN_INFO, OnButtonSetAddinInfo)
	ON_BN_CLICKED(IDC_BUTTON_SET_ADDIN_SECURITY_INFO, OnButtonSetAddinSecurityInfo)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpappinterfaceDlg message handlers

void CSmpappinterfaceDlg::OnButtonGetWindowHandle() 
{
	VARIANT var_val;
	try
	{
		m_ISmpApp->get_WindowHandle(&var_val);

		CWnd* frmWnd=CWnd::FromHandle((HWND)var_val.byref);
		CString strWndTxt;
		frmWnd->GetWindowText(strWndTxt);

		m_windowhandle.SetWindowText(strWndTxt);	
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
	
}

BOOL CSmpappinterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr = m_ISmpApp.CoCreateInstance(CLSID_SmpApp);	

	if(FAILED(hr))
	{
		
		AfxMessageBox(_T("Failed to create com pointer"));
		return FALSE;
	}	

	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpappinterfaceDlg::OnButtonSendStatus() 
{
	BSTR bstr_status;
	try
	{
		UpdateData();
		m_sendstatus.TrimLeft();

		if(m_sendstatus.GetLength()>0)
		{
			bstr_status=m_sendstatus.AllocSysString();

			HRESULT HR=m_ISmpApp->SendStatus(bstr_status);
			if(FAILED(HR))
			{
				AfxMessageBox(_T("Failed to send status"));
			}
		}
		else
		{
			AfxMessageBox(_T("Enter a status"));
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
	
}

void CSmpappinterfaceDlg::OnButtonSetAddinInfo() 
{
	try
	{
		CComPtr<ISmpApp>objSmpApp=(ISmpApp*)GetApp()->m_SmpApp;
		
		if(objSmpApp==NULL)
		{
			AfxMessageBox(_T("Failed to initialise ISmpApp object"));
		}
		else
		{
			VARIANT wndHndle;
			::VariantInit(&wndHndle);
			objSmpApp->get_WindowHandle(&wndHndle);
			CWnd* wnd=CWnd::FromHandle((HWND)wndHndle.byref);
			CString strTxt;
			wnd->GetWindowText(strTxt);

			if(LoadLongResource(strSecurityXML,IDR_SDK_TEST_ADDIN_MENU))
			{
			   strSecurityXML.Replace(_T("\n"),_T("")); //Replace all new line characters
			   strSecurityXML.Replace(_T("\t"),_T("")); //Replace all tab characters
			}

			HINSTANCE lAppHandle=AfxGetInstanceHandle();
			HRESULT HR=m_ISmpApp->SetAddInInfo(GetApp()->m_lSessionID,(long)lAppHandle,strSecurityXML.AllocSysString(),0,0);
			if(FAILED(HR))
			{
				AfxMessageBox(_T("Failed to set Addin Info"));
			}
			else
			{
				AfxMessageBox(_T("Addin Info set successfully"));
			}
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while Setting Addin Info"));

	}
	
}

BOOL CSmpappinterfaceDlg::LoadLongResource(CString &str, UINT nID)
{

	try
	{
		HRSRC               hRes;
		BOOL                bResult            = FALSE;

		//if you want standard HTML type
		hRes = FindResource(AfxGetInstanceHandle(), MAKEINTRESOURCE(nID), RT_HTML);
		if (hRes == NULL)
		{
			//trace error
			str = _T("Error: Resource could not be found\r\n");
		}
		else
		{
			DWORD dwSize = SizeofResource(AfxGetInstanceHandle(), hRes);
			if (dwSize == 0)
			{
			str.Empty();
			bResult = TRUE;
			}
			else
			{
			HGLOBAL hGlob = LoadResource(AfxGetInstanceHandle(), hRes);
			if (hGlob != NULL)
			{
				LPVOID lpData = LockResource(hGlob);
			if (lpData != NULL)
			{
				str            = (LPCSTR)lpData;
				bResult        = TRUE;
			}
			FreeResource(hGlob);
			}
			}
			if (!bResult)
			str = _T("Error: Resource could not be load\r\n");
		}
		return bResult;
	}
  catch(CResourceException* ex)
  {
   ex->Delete();
   return FALSE;
  }
  catch(...)
  {
   return FALSE;
  }

}

void CSmpappinterfaceDlg::OnButtonSetAddinSecurityInfo() 
{
	try
	{
		CComPtr<ISmpApp>objSmpApp=(ISmpApp*)GetApp()->m_SmpApp;
		
		if(objSmpApp==NULL)
		{
			AfxMessageBox(_T("Failed to initialise ISmpApp object"));
		}
		else
		{
			VARIANT wndHndle;
			::VariantInit(&wndHndle);
			objSmpApp->get_WindowHandle(&wndHndle);
			CWnd* wnd=CWnd::FromHandle((HWND)wndHndle.byref);
			CString strTxt;
			wnd->GetWindowText(strTxt);

			if(LoadLongResource(strSecurityXML,IDR_SDK_TEST_ADDIN_SECURITY_INFO))
			{
			   strSecurityXML.Replace(_T("\n"),_T("")); //Replace all new line characters
			   strSecurityXML.Replace(_T("\t"),_T("")); //Replace all tab characters
			}

			HINSTANCE lAppHandle=AfxGetInstanceHandle();
			HRESULT HR=m_ISmpApp->SetAddinSecurityInfo(GetApp()->m_lSessionID,strSecurityXML.AllocSysString());
			if(FAILED(HR))
			{
				AfxMessageBox(_T("Failed to set Addin Security Info"));
			}
			else
			{
				AfxMessageBox(_T("Addin Security Info set successfully"));
			}
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while Setting Addin Security Info"));

	}
	
}
