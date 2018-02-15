// UsingISMPCommands.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "UsingISMPCommands.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CUsingISMPCommands dialog


CUsingISMPCommands::CUsingISMPCommands(CWnd* pParent /*=NULL*/)
	: CDialog(CUsingISMPCommands::IDD, pParent)
{
	//{{AFX_DATA_INIT(CUsingISMPCommands)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CUsingISMPCommands::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CUsingISMPCommands)
	DDX_Control(pDX, IDC_BUTTON5, m_btnSetSessionId);
	DDX_Control(pDX, IDC_BUTTON_MENUSTRING, m_btnMenuString);
	DDX_Control(pDX, IDC_BUTTON_GET_NOOFCOMMANDS, m_btnNoOfCommands);
	DDX_Control(pDX, IDC_BUTTON_GET_MENUCOMMANDID, m_btnMenuCmdId);
	DDX_Control(pDX, IDC_BUTTON_GET_MENUCOMMANDEX, m_btnMenuCmdEx);
	DDX_Control(pDX, IDC_EDIT_SESSION_ID, m_EditSessionId);
	DDX_Control(pDX, IDC_EDIT_NO_OF_COMMANDS, m_EditNoOfCommands);
	DDX_Control(pDX, IDC_EDIT_MENU_STRING, m_EditMenuString);
	DDX_Control(pDX, IDC_EDIT_MENU_COMMANDEX, m_EditMenuCommandEx);
	DDX_Control(pDX, IDC_EDIT_FUNCTION_NAME, m_EditFunctionName);
	DDX_Control(pDX, IDC_EDIT_COMMANDID, m_EditCommandId);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CUsingISMPCommands, CDialog)
	//{{AFX_MSG_MAP(CUsingISMPCommands)
	ON_BN_CLICKED(IDC_BUTTON5, OnSetSessionId)
	ON_BN_CLICKED(IDC_BUTTON_GET_MENUCOMMANDID, OnButtonGetMenucommandid)
	ON_BN_CLICKED(IDC_BUTTON_GET_MENUCOMMANDEX, OnButtonGetMenucommandex)
	ON_BN_CLICKED(IDC_BUTTON_MENUSTRING, OnButtonMenustring)
	ON_BN_CLICKED(IDC_BUTTON_GET_NOOFCOMMANDS, OnButtonGetNoofcommands)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CUsingISMPCommands message handlers

BOOL CUsingISMPCommands::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr;
	CString strSessionId;
	hr=m_IISMPCommands.CoCreateInstance(CLSID_ISmpCommands);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("IISmpCommandsInterface initialisation failed"));
		return FALSE;
	}	
	strSessionId.Format(_T("%ld"),GetApp()->m_lSessionID);
	m_EditSessionId.SetWindowText(strSessionId);
	DisableInitialCtrls(TRUE);
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CUsingISMPCommands::OnSetSessionId() 
{
	try
	{
		CString strSessionId="";
		m_EditSessionId.GetWindowText(strSessionId);
		if(strSessionId.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter SessionId"));
			return;
		}
#ifdef UNICODE
				//m_lSessionID = wcstol((strSessionId), NULL);
#else
				//m_lSessionID=atol((LPCTSTR)strSessionId);
#endif
		AfxMessageBox(_T("Successfully set SessionId"));
		//DisableInitialCtrls(TRUE);
	}
	catch(...)
	{
		AfxMessageBox(_T("Error!!!Failed to set SessionId"));
	}

}

void CUsingISMPCommands::DisableInitialCtrls(BOOL bVal)
{
	BOOL bSet;
	bSet=bVal;
	/*m_EditCommandId.EnableWindow(bSet);
	m_EditFunctionName.EnableWindow(bSet);
	m_EditMenuCommandEx.EnableWindow(bSet);
	m_EditMenuString.EnableWindow(bSet);
	m_EditNoOfCommands.EnableWindow(bSet);
	m_btnMenuCmdEx.EnableWindow(bSet);
	m_btnMenuCmdId.EnableWindow(bSet);
	m_btnMenuString.EnableWindow(bSet);
	m_btnNoOfCommands.EnableWindow(bSet);*/

	m_EditCommandId.SetReadOnly(bSet);
	m_EditMenuCommandEx.SetReadOnly(bSet);
	m_EditNoOfCommands.SetReadOnly(bSet);
	m_EditSessionId.SetReadOnly(bSet);
	m_btnSetSessionId.EnableWindow(!bSet);
}

void CUsingISMPCommands::OnButtonGetMenucommandid() 
{
	try
	{
		long lComdId;
		CString strCommandId;
		CString strMenuString;	
		m_EditMenuString.GetWindowText(strMenuString);
		if(strMenuString.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter MenuString and continue"));
			return;
		}
		m_IISMPCommands->get_MenuCommandID(GetApp()->m_lSessionID,strMenuString.AllocSysString(),&lComdId);
		if(lComdId>=0)
		{
			strCommandId.Format(_T("%ld"),lComdId);

			MessageBox(strCommandId,_T("CommandId"),MB_ICONINFORMATION|MB_OK);

			m_EditCommandId.SetWindowText(strCommandId);
		}
		else
		{
			AfxMessageBox(_T("Failed to Get MenuCommandID"));
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error!!!Failed to Get MenuCommandID"));
	}

}

void CUsingISMPCommands::OnButtonGetMenucommandex() 
{
	try
	{
		long lComdEx;
		CString strCommandEx;
		CString strFunName;	
		m_EditFunctionName.GetWindowText(strFunName);
		if(strFunName.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter Function Name and continue"));
			return;
		}
		m_IISMPCommands->get_MenuCommandEx(GetApp()->m_lSessionID,strFunName.AllocSysString(),&lComdEx);
		if(lComdEx>=0)
		{
			strCommandEx.Format(_T("%ld"),lComdEx);

			MessageBox(strCommandEx,_T("CommandEx"),MB_ICONINFORMATION|MB_OK);

			m_EditMenuCommandEx.SetWindowText(strCommandEx);
		}
		else
		{
			AfxMessageBox(_T("Failed to Get MenuCommandEx"));
		}
		
	}
	catch(...)
	{
		AfxMessageBox(_T("Error!!!Failed to Get CommandEx"));
	}

}

void CUsingISMPCommands::OnButtonMenustring() 
{
	try
	{
		BSTR  bstrMenuString;
		CString strCommandId;
		long lCmdID;

		m_EditCommandId.GetWindowText(strCommandId);

		if(strCommandId.GetLength()<=0)
		{
			AfxMessageBox(_T("Please get Command Id and continue"));
			return;
		}

	#ifdef UNICODE
					unsigned short  *stopstring;
					lCmdID = wcstol((strCommandId),&stopstring,10);
	#else
					lCmdID=atol((LPCTSTR)strCommandId);
	#endif
					
		m_IISMPCommands->get_MenuString(GetApp()->m_lSessionID,lCmdID,&bstrMenuString);

		CString strMenuString(bstrMenuString);

		MessageBox(strMenuString,_T("Menu String"),MB_ICONINFORMATION|MB_OK);

		m_EditMenuString.SetWindowText(strMenuString);
	}
	catch(...)
	{
		AfxMessageBox(_T("Error!!!Failed to Get MenuString"));
	}
}

void CUsingISMPCommands::OnButtonGetNoofcommands() 
{
	try
	{
		long lNoOfCmds;
		CString strNoOfCmds;
		CString strFunName;	

		m_EditFunctionName.GetWindowText(strFunName);

		if(strFunName.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter Function Name and continue"));
			return;
		}
		m_IISMPCommands->get_NoOfCommands(GetApp()->m_lSessionID,strFunName.AllocSysString(),&lNoOfCmds);

		strNoOfCmds.Format(_T("%ld"),lNoOfCmds);

		MessageBox(strNoOfCmds,_T("No. Of Commands"),MB_ICONINFORMATION|MB_OK);

		m_EditNoOfCommands.SetWindowText(strNoOfCmds);
	}
	catch(...)
	{
		AfxMessageBox(_T("Error!!!Failed to Get No of commands"));
	}
}
