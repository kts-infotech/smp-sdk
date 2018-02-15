// SMPSetupDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPSetupDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPSetupDlg dialog


CSMPSetupDlg::CSMPSetupDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPSetupDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPSetupDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSMPSetupDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPSetupDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPSetupDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPSetupDlg)
	ON_BN_CLICKED(IDC_BUTTON_CATAGORY_MASTER, OnButtonCatagoryMaster)
	ON_BN_CLICKED(IDC_BUTTON_CURRENCY_SETTINGS, OnButtonCurrencySettings)
	ON_BN_CLICKED(IDC_BUTTON_DELETE_OLDDATA, OnButtonDeleteOlddata)
	ON_BN_CLICKED(IDC_BUTTON_MANAGE_USER, OnButtonManageUser)
	ON_BN_CLICKED(IDC_BUTTON_METHOD_OF_PAYMENT, OnButtonMethodOfPayment)
	ON_BN_CLICKED(IDC_BUTTON_MISC_ITEM_MASTER, OnButtonMiscItemMaster)
	ON_BN_CLICKED(IDC_BUTTON_SERVICE_MASTER, OnButtonServiceMaster)
	ON_BN_CLICKED(IDC_BUTTON_SETUP_WIZARD, OnButtonSetupWizard)
	ON_BN_CLICKED(IDC_BUTTON_SHOP_INFO, OnButtonShopInfo)
	ON_BN_CLICKED(IDC_BUTTON_STOCK_MASTER, OnButtonStockMaster)
	ON_BN_CLICKED(IDC_BUTTON_DEFAULT_SETNGS, OnButtonDefaultSetngs)
	ON_BN_CLICKED(IDC_BUTTON_DEFAULT_SETNGS_EXT, OnButtonDefaultSetngsExt)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPSetupDlg message handlers

void CSMPSetupDlg::OnButtonCatagoryMaster() 
{
	if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeCategoryMasterDlg();
	}
	
}

void CSMPSetupDlg::OnButtonCurrencySettings() 
{
   	if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeCurrencySettingsDlg();
	}	
}

BOOL CSMPSetupDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
    hr= m_SmpSetup.CoCreateInstance(CLSID_SmpSetup); 	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSMPSetupDlg::OnButtonDeleteOlddata() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeDeleteOldDataDlg();
	}	
}

void CSMPSetupDlg::OnButtonManageUser() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeManageUsersDlg();
	}
	
}

void CSMPSetupDlg::OnButtonMethodOfPayment() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeMethodOfPaymentDlg();
	}	
}

void CSMPSetupDlg::OnButtonMiscItemMaster() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeMiscItemMasterDlg();
	}	
}

void CSMPSetupDlg::OnButtonServiceMaster() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeServiceMasterDlg();
	}	
}

void CSMPSetupDlg::OnButtonSetupWizard() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeSetupWizard();
	}
}

void CSMPSetupDlg::OnButtonShopInfo() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeShopInfoDlg();
	}	
}

void CSMPSetupDlg::OnButtonStockMaster() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeStockMasterDlg();
	}	
}

void CSMPSetupDlg::OnButtonDefaultSetngs() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeDefaultSettingsDlg();
	}	
}

void CSMPSetupDlg::OnButtonDefaultSetngsExt() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpSetup->InvokeDefaultSettingsExtDlg();
	}	
}
