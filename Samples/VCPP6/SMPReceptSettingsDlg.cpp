// SMPReceptSettingsDlg.cpp : implementation file
//

#include "stdafx.h"
#include"resource.h"
#include "SMPReceptSettingsDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSMPReceptSettingsDlg dialog


CSMPReceptSettingsDlg::CSMPReceptSettingsDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSMPReceptSettingsDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSMPReceptSettingsDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSMPReceptSettingsDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSMPReceptSettingsDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSMPReceptSettingsDlg, CDialog)
	//{{AFX_MSG_MAP(CSMPReceptSettingsDlg)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_SALES_RECEIPT, OnButtonPrintSalesReceipt)
	ON_BN_CLICKED(IDC_BUTTON_BYPASS_PRINT, OnButtonBypassPrint)
	ON_BN_CLICKED(IDC_BUTTON_EN_DFLT_RECEIPT_PRNTR, OnButtonEnDfltReceiptPrntr)
	ON_BN_CLICKED(IDC_BUTTON_RECEIPT_PRINTER_NAME, OnButtonReceiptPrinterName)
	ON_BN_CLICKED(IDC_BUTTON_PRINT_FOOTER_TXT, OnButtonPrintFooterTxt)
	ON_BN_CLICKED(IDC_BUTTON_FOOTER_TXT, OnButtonFooterTxt)
	ON_BN_CLICKED(IDC_BUTTON_RECEIPT_SPACING, OnButtonReceiptSpacing)
	ON_BN_CLICKED(IDC_BUTTON_ALWYS_PRNT_FOOTER_TIME, OnButtonAlwysPrntFooterTime)
	ON_BN_CLICKED(IDC_BUTTON_PRNT_RECEIPT_CNTSLY, OnButtonPrntReceiptCntsly)
	ON_BN_CLICKED(IDC_BUTTON_FOOTER_PH_NO, OnButtonFooterPhNo)
	ON_BN_CLICKED(IDC_BUTTON_HEADER_SHP_NME, OnButtonHeaderShpNme)
	ON_BN_CLICKED(IDC_BUTTON_SET_ESC_POS_MODE, OnButtonSetEscPosMode)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSMPReceptSettingsDlg message handlers

BOOL CSMPReceptSettingsDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	HRESULT hr=m_SmpReceiptSettings.CoCreateInstance(CLSID_SmpReceiptSettings);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("SMPReceipt Settings Failed"));
		return FALSE;
	}
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSMPReceptSettingsDlg::OnButtonPrintSalesReceipt() 
{
	
	long	lPrntReceipt=0;

	HRESULT hr=m_SmpReceiptSettings->get_AlwaysPrintSalesReceipt(&lPrntReceipt);

	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lPrntReceipt==TRUE)
	{
		AfxMessageBox(_T("AlwaysPrintSalesReceipt option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("AlwaysPrintSalesReceipt option is Disabled"));
	}
}

void CSMPReceptSettingsDlg::OnButtonBypassPrint() 
{
	long	lBypassPrnt=0;

	HRESULT hr=m_SmpReceiptSettings->get_BypassPrintDlg(&lBypassPrnt);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lBypassPrnt==TRUE)
	{
		AfxMessageBox(_T("BypassPrint option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("BypassPrint option is Disabled"));
	}
}

void CSMPReceptSettingsDlg::OnButtonEnDfltReceiptPrntr() 
{

	long	lReceiptPrntr=0;

	HRESULT hr=m_SmpReceiptSettings->get_EnableDefaultReceiptPrinter(&lReceiptPrntr);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lReceiptPrntr==TRUE)
	{
		AfxMessageBox(_T(" DefaultReceiptPrinter option is Enabled"));
	}
	else
	{
		AfxMessageBox(_T("DefaultReceiptPrinter option is Disabled"));
	}
	
}

void CSMPReceptSettingsDlg::OnButtonReceiptPrinterName() 
{
	BSTR	bstr;
	CString str;

	HRESULT hr=m_SmpReceiptSettings->get_ReceiptPrinterName(&bstr);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	str=bstr;
	
	if(str.IsEmpty())
	{
		AfxMessageBox(_T("Printer Name is not Entered"));
	}
	else
		
		AfxMessageBox(str);
}

void CSMPReceptSettingsDlg::OnButtonPrintFooterTxt() 
{
	long	lPrintFooterTxt;
	
	HRESULT hr=m_SmpReceiptSettings->get_PrintFooterText(&lPrintFooterTxt);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lPrintFooterTxt==TRUE)
	{
		AfxMessageBox(_T("Print Footer Text is enabled"));
	}
	else
		
		AfxMessageBox(_T("Print Footer Text is disabled"));
}

void CSMPReceptSettingsDlg::OnButtonFooterTxt() 
{
	BSTR	bstr;
	CString str;

	HRESULT hr=m_SmpReceiptSettings->get_FooterText(&bstr);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	str=bstr;
	
	if(str.IsEmpty())
	{
		AfxMessageBox(_T("Footer Text is not Entered"));
	}
	else
		
		AfxMessageBox(str);
}

void CSMPReceptSettingsDlg::OnButtonReceiptSpacing() 
{
	long lSpcing;
	CString str;

	HRESULT hr=m_SmpReceiptSettings->get_ReceiptSpacing(&lSpcing);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}
	
	str.Format(_T("Spacing is %ld"),lSpcing);
	AfxMessageBox(str);
}

void CSMPReceptSettingsDlg::OnButtonAlwysPrntFooterTime() 
{
	long	lPrntFooterTime;

	HRESULT hr=m_SmpReceiptSettings->get_PrintTimeAtFooter(&lPrntFooterTime);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lPrntFooterTime==TRUE)
	{
		AfxMessageBox(_T("Print Time At Footer option is enabled"));
	}
	else
		
		AfxMessageBox(_T("Print Time At Footer option is disabled"));
	
}

void CSMPReceptSettingsDlg::OnButtonPrntReceiptCntsly() 
{
	long	lPrntReceiptCntsly;
	
	HRESULT hr=m_SmpReceiptSettings->get_PrintReceiptsContinuously(&lPrntReceiptCntsly);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lPrntReceiptCntsly==TRUE)
	{
		AfxMessageBox(_T("Print Receipts Continuously option is enabled"));
	}
	else
		
		AfxMessageBox(_T("Print Receipts Continuously option is disabled"));
	
}

void CSMPReceptSettingsDlg::OnButtonFooterPhNo() 
{
	long	lFooterPhNo;
	
	HRESULT hr=m_SmpReceiptSettings->get_PhoneNumberAtFooter(&lFooterPhNo);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lFooterPhNo==TRUE)
	{
		AfxMessageBox(_T("Phone Number At Footer option is enabled"));
	}
	else
		
		AfxMessageBox(_T("Phone Number At Footer option is disabled"));
	
}

void CSMPReceptSettingsDlg::OnButtonHeaderShpNme() 
{
	long	lHeaderShpNme;
	
	HRESULT hr=m_SmpReceiptSettings->get_PrintShopNameAtHeader(&lHeaderShpNme);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}

	if(lHeaderShpNme==TRUE)
	{
		AfxMessageBox(_T("Print ShopName At Header option is enabled"));
	}
	else
		
		AfxMessageBox(_T("Print ShopName At Header option is disabled"));
	
}

void CSMPReceptSettingsDlg::OnButtonSetEscPosMode() 
{
  

	HRESULT hr=m_SmpReceiptSettings->SetEscPOSMode(TRUE);
	
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to load"));
	}
    	
	
}
