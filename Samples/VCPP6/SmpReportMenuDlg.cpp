// SmpReportMenuDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpReportMenuDlg.h"
#include "resource.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpReportMenuDlg dialog


CSmpReportMenuDlg::CSmpReportMenuDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpReportMenuDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpReportMenuDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpReportMenuDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpReportMenuDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpReportMenuDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpReportMenuDlg)
	ON_BN_CLICKED(IDC_BUTTON_ANNUALACCOUNT, OnButtonAnnualaccount)
	ON_BN_CLICKED(IDC_BUTTON_ANNUALSATISTICS, OnButtonAnnualsatistics)
	ON_BN_CLICKED(IDC_BUTTON_CANCELEDSALES, OnButtonCanceledsales)
	ON_BN_CLICKED(IDC_BUTTON_CANCELEDTRANSACTIONS, OnButtonCanceledtransactions)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERBALANCEAMT, OnButtonCustomerbalanceamt)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERINACT, OnButtonCustomerinact)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERLIST, OnButtonCustomerlist)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERMOSTACT, OnButtonCustomermostact)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERPAYMENT, OnButtonCustomerpayment)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERREFUND, OnButtonCustomerrefund)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERTRANSACTIONS, OnButtonCustomertransactions)
	ON_BN_CLICKED(IDC_BUTTON_CUSTOMERSALES, OnButtonCustomersales)
	ON_BN_CLICKED(IDC_BUTTON_DAILYSUMMARY, OnButtonDailysummary)
	ON_BN_CLICKED(IDC_BUTTON_DAILYACCOUNT, OnButtonDailyaccount)
	ON_BN_CLICKED(IDC_BUTTON_DISCOUNTSALES, OnButtonDiscountsales)
	ON_BN_CLICKED(IDC_BUTTON_MONTHLYACCOUNT, OnButtonMonthlyaccount)
	ON_BN_CLICKED(IDC_BUTTON_MONTHLYSTATISTICS, OnButtonMonthlystatistics)
	ON_BN_CLICKED(IDC_BUTTON_REORDERLIST, OnButtonReorderlist)
	ON_BN_CLICKED(IDC_BUTTON_ROLLBACK, OnButtonRollback)
	ON_BN_CLICKED(IDC_BUTTON_SALESLIST, OnButtonSaleslist)
	ON_BN_CLICKED(IDC_BUTTON_SERVICEDELIVRD, OnButtonServicedelivrd)
	ON_BN_CLICKED(IDC_BUTTON_SERVICELIST, OnButtonServicelist)
	ON_BN_CLICKED(IDC_BUTTON_SPECFDPERIODACCNT, OnButtonSpecfdperiodaccnt)
	ON_BN_CLICKED(IDC_BUTTON_STOCKLIST, OnButtonStocklist)
	ON_BN_CLICKED(IDC_BUTTON_TRANSACTIONLIST, OnButtonTransactionlist)
	ON_BN_CLICKED(IDC_BUTTON_MISCTRANSLIST, OnButtonMisctranslist)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpReportMenuDlg message handlers

void CSmpReportMenuDlg::OnButtonAnnualaccount() 
{
	// TODO: Add your control notification handler code here
    m_SmpReportMenu->InvokeAnualAccountDlg();
	
}

void CSmpReportMenuDlg::OnButtonAnnualsatistics() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeAnualStatisticsDlg();
}

void CSmpReportMenuDlg::OnButtonCanceledsales() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCanceledSalesDlg();
	
}

void CSmpReportMenuDlg::OnButtonCanceledtransactions() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCanceledTransactionsDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomerbalanceamt() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerBalanceAmountDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomerinact() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerInactiveDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomerlist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerListDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomermostact() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerMostActiveDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomerpayment() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerPaymentDetailsdlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomerrefund() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerRefundDetailsDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomertransactions() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerTransactionDetailsDlg();
	
}

void CSmpReportMenuDlg::OnButtonCustomersales() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeCustomerSalesDetailsDlg();
	
}

void CSmpReportMenuDlg::OnButtonDailysummary() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeDailySummaryDlg();
	
}

void CSmpReportMenuDlg::OnButtonDailyaccount() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeDailyAccountDlg();
	
}

void CSmpReportMenuDlg::OnButtonDiscountsales() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeDiscountSalesDlg();
	
}

void CSmpReportMenuDlg::OnButtonMonthlyaccount() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeMonthlyAccountDlg();
	
}

void CSmpReportMenuDlg::OnButtonMonthlystatistics() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeMonthlyStatisticsDlg();
	
}

void CSmpReportMenuDlg::OnButtonReorderlist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeReorderListDlg();
	
}

void CSmpReportMenuDlg::OnButtonRollback() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeRollbackDlg();
	
}

void CSmpReportMenuDlg::OnButtonSaleslist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeSalesListDlg();
	
}

void CSmpReportMenuDlg::OnButtonServicedelivrd() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeServiceDeliveredDlg();
	
}

void CSmpReportMenuDlg::OnButtonServicelist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeServiceListDlg();
	
}

void CSmpReportMenuDlg::OnButtonSpecfdperiodaccnt() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeSpecifiedPeriodAccountDlg();
	
}

void CSmpReportMenuDlg::OnButtonStocklist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeStokeListDlg();
	
}

void CSmpReportMenuDlg::OnButtonTransactionlist() 
{
	// TODO: Add your control notification handler code here
    m_SmpReportMenu->InvokeTransactionListDlg();
	
}

void CSmpReportMenuDlg::OnButtonMisctranslist() 
{
	// TODO: Add your control notification handler code here
	m_SmpReportMenu->InvokeMiscTransactionListDlg();
	
}

BOOL CSmpReportMenuDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	// TODO: Add extra initialization here
	HRESULT hr=m_SmpReportMenu.CoCreateInstance(CLSID_SmpReportMenu);

	if(FAILED(hr))
	{
		AfxMessageBox(_T("SMPReportMenu Failed"));
		return FALSE;
	}
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
