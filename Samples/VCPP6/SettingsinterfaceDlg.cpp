// SettingsinterfaceDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SettingsinterfaceDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSettingsinterfaceDlg dialog


CSettingsinterfaceDlg::CSettingsinterfaceDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSettingsinterfaceDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSettingsinterfaceDlg)
	m_Paymentmethod = _T("");
	//}}AFX_DATA_INIT
}


void CSettingsinterfaceDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSettingsinterfaceDlg)
	DDX_Control(pDX, IDC_EDIT_SETTING_OUTPUT, m_settings_out);
	DDX_Text(pDX, IDC_EDIT_PAYMENT_METHOD, m_Paymentmethod);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSettingsinterfaceDlg, CDialog)
	//{{AFX_MSG_MAP(CSettingsinterfaceDlg)
	ON_BN_CLICKED(IDC_BUTTON_COMPACT_DATABASE, OnButtonCompactDatabase)
	ON_BN_CLICKED(IDC_BUTTON_AUTOMATICBACKUP, OnButtonAutomaticbackup)
	ON_BN_CLICKED(IDC_BUTTONAUTOMATIC_COMPACT, OnButtonautomaticCompact)
	ON_BN_CLICKED(IDC_BUTTON_DATE_FORMAT, OnButtonDateFormat)
	ON_BN_CLICKED(IDC_BUTTON_DEFAULT_MEMBERSHIPFEE, OnButtonDefaultMembershipfee)
	ON_BN_CLICKED(IDC_BUTTON_DEFAULT_SECURITY_DEPOSIT, OnButtonDefaultSecurityDeposit)
	ON_BN_CLICKED(IDC_BUTTON_PAYMENT_METHOD, OnButtonPaymentMethod)
	ON_BN_CLICKED(IDC_BUTTON_PICTURE_FOLDER, OnButtonPictureFolder)
	ON_BN_CLICKED(IDC_BUTTON_LAUNCH_ON_STARTUP, OnButtonLaunchOnStartup)
	ON_BN_CLICKED(IDC_BUTTON_NO_OF_DISPLAY_RECORDS, OnButtonNoOfDisplayRecords)
	ON_BN_CLICKED(IDC_BUTTON_OVERRIDE_EX_DATA_ON, OnButtonOverrideExDataOn)
	ON_BN_CLICKED(IDC_BUTTON_USE_ENTER_KEY, OnButtonUseEnterKey)
	ON_BN_CLICKED(IDC_BUTTON_SET_PAYMENT_METHOD, OnButtonSetPaymentMethod)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSettingsinterfaceDlg message handlers

void CSettingsinterfaceDlg::OnButtonCompactDatabase() 
{
	try
	{
		UpdateData();
		HRESULT hr_compactDb =m_ISettings->CompactDatabase();
		if(FAILED(hr_compactDb))
		{
			m_settings_out.SetWindowText(_T("Failed to Compact Database"));			
		}
		else
		{
			m_settings_out.SetWindowText(_T(" Compact Database Successfull"));
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while Compact Database"));

	}
}

BOOL CSettingsinterfaceDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	hr = m_ISettings.CoCreateInstance(CLSID_Settings);
	UpdateData();

	if(FAILED(hr))
	{
		
		AfxMessageBox(_T("Failed to create com pointer"));
		return FALSE;
	}	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSettingsinterfaceDlg::OnButtonAutomaticbackup() 
{
	long bval;
	bval=-1;	
	try
	{
		m_ISettings->get_AutomaticBackup(&bval);
		UpdateData();
		
		if(bval>0)
		{
			m_settings_out.SetWindowText(_T("Automatic backup Successful"));
		}
		else
		{
			m_settings_out.SetWindowText(_T("Automatic backup Failed"));
		}
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSettingsinterfaceDlg::OnButtonautomaticCompact() 
{
	long bval;
	bval=-1;	
	try
	{
		m_ISettings->get_AutomaticCompact(&bval);
		UpdateData();
		if(bval>0)
		{
			m_settings_out.SetWindowText(_T("Automatic Compact Successful"));
		}
		else
		{
			m_settings_out.SetWindowText(_T("Automatic Compact Failed"));
		}	
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSettingsinterfaceDlg::OnButtonDateFormat() 
{
	CString str_DateFormat;
	BSTR bstr_DateFormat;
	try
	{
		UpdateData();
		m_ISettings->get_DateFormat(&bstr_DateFormat);
		str_DateFormat=(CString)bstr_DateFormat;
		m_settings_out.SetWindowText(str_DateFormat);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonDefaultMembershipfee() 
{
	double d_double;
	try
	{
		m_ISettings->get_DefaultMembershipFee(&d_double);
		CString str_MembershipFee;
		str_MembershipFee.Format(_T("%f"),d_double);
		m_settings_out.SetWindowText(str_MembershipFee);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonDefaultSecurityDeposit() 
{
	double d_double;
	try
	{
		m_ISettings->get_DefaultSecurityDeposit(&d_double);
		CString str_SecurityDeposit;
		str_SecurityDeposit.Format(_T("%f"),d_double);
		m_settings_out.SetWindowText(str_SecurityDeposit);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonPaymentMethod() 
{
	CString str_PaymentMethod;
	BSTR bstr_PaymentMethod;
	try
	{
		UpdateData();
		m_ISettings->get_PaymentMethod(&bstr_PaymentMethod);
		str_PaymentMethod=(CString)bstr_PaymentMethod;
		m_settings_out.SetWindowText(str_PaymentMethod);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonPictureFolder() 
{
	CString str_PictureFolder;
	BSTR bstr_PictureFolder;
	try
	{
		UpdateData();
		m_ISettings->get_PictureFolder(&bstr_PictureFolder);
		str_PictureFolder=(CString)bstr_PictureFolder;
		m_settings_out.SetWindowText(str_PictureFolder);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonLaunchOnStartup() 
{
	long bval;
	bval=-1;	
	try
	{
		m_ISettings->get_LaunchOnStartup(&bval);
		UpdateData();
		
		if(bval>0)
		{
			m_settings_out.SetWindowText(_T("Launch On Startup Successful"));
		}
		else
		{
			m_settings_out.SetWindowText(_T("Launch On Startup Failed"));
		}	
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
}

void CSettingsinterfaceDlg::OnButtonNoOfDisplayRecords() 
{
	long bval;
	bval=0;	
	try
	{
		m_ISettings->get_NoOfDisplayRecords(&bval);
		
		CString str_NoOfDisplayRecords;
		str_NoOfDisplayRecords.Format(_T("%ld"),bval);
		
		m_settings_out.SetWindowText(str_NoOfDisplayRecords);
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
		
	
}

void CSettingsinterfaceDlg::OnButtonOverrideExDataOn() 
{
	long bval;
	bval=-1;	
	try
	{
		m_ISettings->get_OverrideExDataOnAB(&bval);	
		
		if(bval>0)
		{
			m_settings_out.SetWindowText(_T("Override ExData On Successful"));
		}
		else
		{
			m_settings_out.SetWindowText(_T("Override ExData On Failed"));
		}	
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonUseEnterKey() 
{
	long bval;
	bval=-1;
	try
	{
		m_ISettings->get_UseEnterKey(&bval);	
		
		if(bval>0)
		{
			m_settings_out.SetWindowText(_T("Use Enter Key"));
		}
		else
		{
			m_settings_out.SetWindowText(_T("Dont Use Enter Key"));
		}	
	}
	catch(...)
	{
		m_settings_out.SetWindowText(_T("Error while perofrming the action"));
	}
	
}

void CSettingsinterfaceDlg::OnButtonSetPaymentMethod() 
{	
	BSTR bstr_payment_method;
	CString str_payment_method;

	try
	{
		UpdateData();

		m_Paymentmethod.TrimLeft();

		if(m_Paymentmethod.GetLength()>0)
		{

			bstr_payment_method=m_Paymentmethod.AllocSysString();

			HRESULT HR_payment_method= m_ISettings->put_PaymentMethod(bstr_payment_method);

			if(FAILED(HR_payment_method))
			{
				AfxMessageBox(_T("Set new Payment Method Failed"));
			}
			else
			{
				AfxMessageBox(_T("Payment Method Set Successfully"));
			}
		}
		else
		{
			MessageBox(_T("Enter a payment method"));
		}
	}
	catch(...)
	{
		AfxMessageBox(_T("Error while perofrming the action"));
	}


	
}
