// SecurityinterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SecurityinterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSecurityinterfaceDlg dialog


CSecurityinterfaceDlg::CSecurityinterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSecurityinterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSecurityinterfaceDlg)
	m_username = _T("");
	m_LeafSecurityNoadName = _T("");
	m_ModuleName = _T("");
	m_ModuleSection = _T("");
	//}}AFX_DATA_INIT
}


void CSecurityinterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSecurityinterfaceDlg)
	DDX_Control(pDX, IDC_EDIT_OUTPUT, m_output);
	DDX_Text(pDX, IDC_EDIT_USER_NAME, m_username);
	DDX_Text(pDX, IDC_EDIT_LEAF_SECURITY_NODE_NAME, m_LeafSecurityNoadName);
	DDX_Text(pDX, IDC_EDIT_MODULE_NAME, m_ModuleName);
	DDX_Text(pDX, IDC_EDIT_MODULE_SECTION, m_ModuleSection);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSecurityinterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(CSecurityinterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_ACCESS_CUSTOMER_MENU, OnButtonAccessCustomerMenu)
	ON_BN_CLICKED(IDC_BUTTON_ACCESS_SALES_MENU, OnButtonAccessSalesMenu)
	ON_BN_CLICKED(IDC_BUTTON_ACCESS_SETUP, OnButtonAccessSetup)
	ON_BN_CLICKED(IDC_BUTTON_ACCESS_TRANSACTION_MENU, OnButtonAccessTransactionMenu)
	ON_BN_CLICKED(IDC_BUTTON_CURRENTLOGIN_USER, OnButtonCurrentloginUser)
	ON_BN_CLICKED(IDC_BUTTON_CURRENT_USER_RIGHTS, OnButtonCurrentUserRights)
	ON_BN_CLICKED(IDC_BUTTON_DATABASE_RIGHTS, OnButtonDatabaseRights)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_REPORTS, OnButtonPrintReports)
	ON_BN_CLICKED(IDC_BUTTON_UPDATE_SHOPE_BALANCE, OnButtonUpdateShopeBalance)
	ON_BN_CLICKED(IDC_BUTTON_VIEW_REPORTS, OnButtonViewReports)
	ON_BN_CLICKED(IDC_BUTTON_USER_RIGHTS_INFO, OnButtonUserRightsInfo)
	ON_BN_CLICKED(IDC_BUTTON_USER_RIGHT_INFO, OnButtonUserRightInfo)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSecurityinterfaceDlg message handlers

void CSecurityinterfaceDlg::OnButtonAccessCustomerMenu() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_AccessCustomerMenu(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have rights to access Customer Menu"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have rights to access Customer Menu"));
		}	
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}

}

BOOL CSecurityinterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();	

	HRESULT hr = m_ISecurity.CoCreateInstance(CLSID_Security);

	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create com pointer"));
		return FALSE;
	}


	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSecurityinterfaceDlg::OnButtonAccessSalesMenu() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_AccessSalesMenu(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have rights to access Sales Menu"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have rights to access Sales Menu"));
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonAccessSetup() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_AccessSetup(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have rights to access Setup Menu"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have rights to access Setup Menu"));
		}	
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonAccessTransactionMenu() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_AccessTransactionMenu(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have rights to access Transaction Menu"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have rights to access Transaction Menu"));
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonCurrentloginUser() 
{
	CString str_user;
	BSTR bstr_user;	
	try
	{
		m_ISecurity->get_CurrentLoginUser(&bstr_user);
		str_user=(CString)bstr_user;
		m_output.SetWindowText(str_user);	
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonCurrentUserRights() 
{
    BSTR bstr_user;
	CString str_user;
	try
	{
		m_ISecurity->get_CurrentUserRights(&bstr_user);
		str_user=(CString)bstr_user;
		m_output.SetWindowText(str_user);	
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonDatabaseRights() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_DatabaseRight(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have Database Right"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have Database Right"));
		}	
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonPrintReports() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_PrintReports(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have Print Reports Right"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have Print Reports Right"));
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSecurityinterfaceDlg::OnButtonUpdateShopeBalance() 
{
	double d_double;
	try
	{
		m_ISecurity->get_UpdateShopBalance(&d_double);
		CString str_balance;
		str_balance.Format(_T("%f"),d_double);
		m_output.SetWindowText(str_balance);
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSecurityinterfaceDlg::OnButtonViewReports() 
{
	long bval;
	bval=-1;
	try
	{
		HRESULT hr=m_ISecurity->get_ViewReports(&bval);
		if(bval>0)
		{
			m_output.SetWindowText(_T("Have View Reports Right"));
		}
		else
		{
			m_output.SetWindowText(_T("Dont have View Reports Right"));
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSecurityinterfaceDlg::OnButtonUserRightsInfo() 
{
	BSTR bstr_username;
	BSTR bstr_securitydata;
	CString str_securitydata;

	try
	{
		UpdateData();
		m_username.TrimLeft();
		if(m_username.GetLength()>0)
		{
			bstr_username=m_username.AllocSysString();
			HRESULT hr=m_ISecurity->GetUserRightsInfo(bstr_username,&bstr_securitydata);
			str_securitydata=(CString)bstr_securitydata;
			//AfxMessageBox(str_securitydata);
			m_output.SetWindowText(str_securitydata);
		}
		else
		{
			AfxMessageBox(_T("Enter User name"));
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}

}

void CSecurityinterfaceDlg::OnButtonUserRightInfo() 
{
	BSTR bstr_XMLModuleName;
	BSTR bstr_ModuleSection;
	BSTR bstr_LeafSecurityNodeName;
	long bval;
	bval=-1;
	bool bflag=true;
	try
	{
	
		UpdateData();

		m_ModuleName.TrimLeft();
		m_ModuleSection.TrimLeft();
		m_LeafSecurityNoadName.TrimLeft();

		if(m_ModuleName.GetLength()==0)
		{
			bflag=false;
			AfxMessageBox(_T("Enter Module Name"));
		}
		if(m_ModuleSection.GetLength()==0)
		{
			bflag=false;
			AfxMessageBox(_T("Enter Module Section"));
		}
		if(m_LeafSecurityNoadName.GetLength()==0)
		{
			bflag=false;
			AfxMessageBox(_T("Enter Leaf Security Node Name"));
		}

		if(bflag)
		{
			bstr_XMLModuleName=m_ModuleName.AllocSysString();
			bstr_ModuleSection=m_ModuleSection.AllocSysString();
			bstr_LeafSecurityNodeName=m_LeafSecurityNoadName.AllocSysString();

			HRESULT hr=m_ISecurity->get_UserRightInfo(bstr_XMLModuleName,bstr_ModuleSection,bstr_LeafSecurityNodeName,&bval);

			if(bval>0)
			{
				//m_output.SetWindowText("Have User Right Info");
				AfxMessageBox(_T("Have User Right Info"));
			}
			else
			{
				//m_output.SetWindowText("Dont have User Right Info");
				AfxMessageBox(_T("Dont have User Right Info"));
			}
		}
	}
	catch(...)
	{
		m_output.SetWindowText(_T("Error while perofrming the action"));
	}
	

}
