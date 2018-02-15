// Smpfilemenuoperationinterface.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "Smpfilemenuoperationinterface.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpfilemenuoperationinterface dialog


CSmpfilemenuoperationinterface::CSmpfilemenuoperationinterface(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpfilemenuoperationinterface::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpfilemenuoperationinterface)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpfilemenuoperationinterface::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpfilemenuoperationinterface)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpfilemenuoperationinterface, CDialog)
	//{{AFX_MSG_MAP(CSmpfilemenuoperationinterface)
	ON_BN_CLICKED(IDC_BUTTON_BACKUPDATA, OnButtonBackupdata)
	ON_BN_CLICKED(IDC_BUTTON_CHANGE_PASSWORD, OnButtonChangePassword)
	ON_BN_CLICKED(IDC_BUTTON_EXIT, OnButtonExit)
	ON_BN_CLICKED(IDC_BUTTON_EXPORT_REPORT, OnButtonExportReport)
	ON_BN_CLICKED(IDC_BUTTON_LOGIN, OnButtonLogin)
	ON_BN_CLICKED(IDC_BUTTON_LOGOUT, OnButtonLogout)
	ON_BN_CLICKED(IDC_BUTTON_PRINT, OnButtonPrint)
	ON_BN_CLICKED(IDC_BUTTON_PRINTOLDRECEIPT, OnButtonPrintoldreceipt)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_PREVIEW, OnButtonPrintPreview)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_SETUP, OnButtonPrintSetup)
	ON_BN_CLICKED(IDC_BUTTON_RESTORE_DATA, OnButtonRestoreData)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpfilemenuoperationinterface message handlers

void CSmpfilemenuoperationinterface::OnButtonBackupdata() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeBackupDataDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

BOOL CSmpfilemenuoperationinterface::OnInitDialog() 
{
	CDialog::OnInitDialog();
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	
	hr = m_ISmpFileMenuOperations.CoCreateInstance(CLSID_SmpFileMenuOperations);
	

	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create com pointer"));
		return FALSE;
	}	

	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpfilemenuoperationinterface::OnButtonChangePassword() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeChangePasswordDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
	
}

void CSmpfilemenuoperationinterface::OnButtonExit() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			EndDialog(0);
			m_ISmpFileMenuOperations->InvokeExit();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonExportReport() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeExportReportDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonLogin() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeLoginDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonLogout() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeLogout();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonPrint() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokePrintDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonPrintoldreceipt() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokePrintOldReceiptDlg();
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonPrintPreview() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokePrintPreviewDlg();
		}	
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonPrintSetup() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokePrintSetupDlg();
		}	
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}

void CSmpfilemenuoperationinterface::OnButtonRestoreData() 
{
	try
	{
		if(SUCCEEDED(hr))
		{
			m_ISmpFileMenuOperations->InvokeRestoreDataDlg();
		}	
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while performing the action"));
	}
}
