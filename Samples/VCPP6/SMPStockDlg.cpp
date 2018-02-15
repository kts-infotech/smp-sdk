// SMPStockDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SMPStockDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPStockDlg dialog


CSMPStockDlg::CSMPStockDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPStockDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPStockDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSMPStockDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPStockDlg)
	//DDX_Control(pDX, IDC_EDIT_ITEMNAME, m_ItemName);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPStockDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPStockDlg)
	ON_BN_CLICKED(IDC_BUTTON_ADD_NEW_STOCK, OnButtonAddNewStock)
	ON_BN_CLICKED(IDC_BUTTON_CANCEL, OnButtonCancel)
	ON_BN_CLICKED(IDC_BUTTON_CHECKOUT, OnButtonCheckout)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_STOCK, OnButtonEditStock)
	ON_BN_CLICKED(IDC_BUTTON_MOD_ITM_PRICE, OnButtonModItmPrice)
	ON_BN_CLICKED(IDC_BUTTON_STOCK_RATE, OnButtonStockRate)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPStockDlg message handlers

void CSMPStockDlg::OnButtonAddNewStock() 
{
     if(SUCCEEDED(hr))
	{
        m_SmpStock->InvokeAddNewStockDlg();
	}	
}

BOOL CSMPStockDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	hr = m_SmpStock.CoCreateInstance(CLSID_SmpStock);
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSMPStockDlg::OnButtonCancel() 
{
	// TODO: Add your control notification handler code here
	if(SUCCEEDED(hr))
	{
		long SalesID;
        m_SmpStock->InvokeCancelSalesDlg(&SalesID);
	}
}

void CSMPStockDlg::OnButtonCheckout() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpStock->InvokeCheckoutDlg();		
	}	
}

void CSMPStockDlg::OnButtonEditStock() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpStock->InvokeEditStockDlg();
	}	
}

void CSMPStockDlg::OnButtonModItmPrice() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpStock->InvokeModifyStockItemPriceDlg();
	}	
}

void CSMPStockDlg::OnButtonStockRate() 
{
    if(SUCCEEDED(hr))
	{
        m_SmpStock->InvokeStockRateSettingsDlg();
	}	
}
