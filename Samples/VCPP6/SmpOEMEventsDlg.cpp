// SmpOEMEventsDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpOEMEventsDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpOEMEventsDlg dialog


CSmpOEMEventsDlg::CSmpOEMEventsDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpOEMEventsDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpOEMEventsDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpOEMEventsDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpOEMEventsDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpOEMEventsDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpOEMEventsDlg)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_CUSTOM_ACCOUNTS_MENU, OnButtonInvokeCustomAccountsMenu)
	ON_BN_CLICKED(IDC_BUTTON_INVOKE_CUSTOM_FILE_MENU, OnButtonInvokeCustomFileMenu)
	ON_BN_CLICKED(IDC_BUTTON_ACCEPT_PAYMENT_SET, OnButtonAcceptPaymentSet)
	ON_BN_CLICKED(IDC_BUTTON_ADD_CUSTOMER_SET, OnButtonAddCustomerSet)
	ON_BN_CLICKED(IDC_BUTTON_REFUND_TO_CUSTOMER_SET, OnButtonRefundToCustomerSet)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_CUSTOMER_SET, OnButtonEditCustomerSet)
	ON_BN_CLICKED(IDC_BUTTON_DELETE_CUSTOMER_SET, OnButtonDeleteCustomerSet)
	ON_BN_CLICKED(IDC_BUTTON_FIND_CUSTOMER_SET, OnButtonFindCustomerSet)
	ON_BN_CLICKED(IDC_BUTTON_BACKUP_DATA_SET, OnButtonBackupDataSet)
	ON_BN_CLICKED(IDC_BUTTON_REGISTER_HELP_SET, OnButtonRegisterHelpSet)
	ON_BN_CLICKED(IDC_BUTTON_HELP_TOPICS_SET, OnButtonHelpTopicsSet)
	ON_BN_CLICKED(IDC_BUTTON_MENU_SHORTCUT_KEYS_SET, OnButtonMenuShortcutKeysSet)
	ON_BN_CLICKED(IDC_BUTTON_DAILY_REPORT_SET, OnButtonDailyReportSet)
	ON_BN_CLICKED(IDC_BUTTON_MONTHLY_REPORT_SET, OnButtonMonthlyReportSet)
	ON_BN_CLICKED(IDC_BUTTON_ANNUAL_REPORT_SET, OnButtonAnnualReportSet)
	ON_BN_CLICKED(IDC_BUTTON_ADD_NEW_STOCK_ITEM_SET, OnButtonAddNewStockItemSet)
	ON_BN_CLICKED(IDC_BUTTON_MODIFY_STOCK_ITEM_SET, OnButtonModifyStockItemSet)
	ON_BN_CLICKED(IDC_BUTTON_MODIFY_STOCK_ITEM_PRICE_SET, OnButtonModifyStockItemPriceSet)
	ON_BN_CLICKED(IDC_BUTTON_CURRENCY_SETTINGS_SET, OnButtonCurrencySettingsSet)
	ON_BN_CLICKED(IDC_BUTTON_METHOD_OF_PAYMENT_SET, OnButtonMethodOfPaymentSet)
	ON_BN_CLICKED(IDC_BUTTON_SERVICE_MASTER_SET, OnButtonServiceMasterSet)
	ON_BN_CLICKED(IDC_BUTTON_ADD_TRANSACTION_SET, OnButtonAddTransactionSet)
	ON_BN_CLICKED(IDC_BUTTON_EDIT_TRANSACTION_SET, OnButtonEditTransactionSet)
	ON_BN_CLICKED(IDC_BUTTON_CANCEL_TRANSACTION_SET, OnButtonCancelTransactionSet)
	ON_BN_CLICKED(IDC_BUTTON_TOOLBAR_SET, OnButtonToolbarSet)
	ON_BN_CLICKED(IDC_BUTTON_FULL_SCREEN_SET, OnButtonFullScreenSet)
	ON_BN_CLICKED(IDC_BUTTON_CLEAR_ALL_SET, OnButtonClearAllSet)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpOEMEventsDlg message handlers

BOOL CSmpOEMEventsDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	SmpOEM.CoCreateInstance(CLSID_SmpOEM);

	SetDefaultValues();
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpOEMEventsDlg::OnButtonInvokeCustomAccountsMenu() 
{
	

}

void CSmpOEMEventsDlg::OnButtonInvokeCustomFileMenu() 
{
	//SmpOEMEvent->InvokeCustomFileMenuDlg(ID_FILE_BACKUPDATABASE);
	
//ID_FILE_BACKUPDATABASE	
}

void CSmpOEMEventsDlg::OnButtonAcceptPaymentSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_ACCEPT_PAYMENT_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomAccountsDlg(ID_ACCOUNTS_ACCEPTPAYMENT,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomAccountsDlg(ID_ACCOUNTS_ACCEPTPAYMENT,FALSE);
	}
	
}

void CSmpOEMEventsDlg::SetDefaultValues()
{
	long value;

	SmpOEM->get_InvokeCustomAccountsDlg(ID_ACCOUNTS_ACCEPTPAYMENT,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_ACCEPT_PAYMENT_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_ACCEPT_PAYMENT_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomAccountsDlg(ID_ACCOUNTS_AMOUNTRETURN,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_REFUND_TO_CUSTOMER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_REFUND_TO_CUSTOMER_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomCustomerDlg(ID_CUSTMER_ADD_CUSTOMER,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_ADD_CUSTOMER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_ADD_CUSTOMER_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomCustomerDlg(ID_CUSTOMER_EDITDELETECUSTOMER,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_EDIT_CUSTOMER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_EDIT_CUSTOMER_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomCustomerDlg(ID_CUSTOMER_DELETE ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_DELETE_CUSTOMER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_DELETE_CUSTOMER_FALSE))->SetCheck(1);
	SmpOEM->get_InvokeCustomCustomerDlg(ID_CUSTOMER_DELETE ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_FIND_CUSTOMER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_FIND_CUSTOMER_FALSE))->SetCheck(1);
	SmpOEM->get_InvokeCustomFileMenuDlg(ID_FILE_BACKUPDATABASE ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_BACKUP_DATA_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_BACKUP_DATA_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomHelpDlg(ID_HELP_REGISTER ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_REGISTER_HELP_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_REGISTER_HELP_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomHelpDlg(ID_HELP_HELPTOPICS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_HELP_TOPICS_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_HELP_TOPICS_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomHelpDlg(ID_HELP_MENUSHORTCUTS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_MENU_SHORTCUT_KEYS_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_MENU_SHORTCUT_KEYS_FALSE))->SetCheck(1);

     SmpOEM->get_InvokeCustomreportsDlg(ID_REPORTS_DAILYREPORTS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_DAILY_REPORT_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_DAILY_REPORT_FALSE))->SetCheck(1);

	 SmpOEM->get_InvokeCustomreportsDlg(ID_REPORTS_MONTHLYREPORTS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_MONTHLY_REPORT_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_MONTHLY_REPORT_FALSE))->SetCheck(1);


	SmpOEM->get_InvokeCustomreportsDlg(ID_ACCOUNTS_YEARLY_REPORTS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_ANNUAL_REPORT_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_ANNUAL_REPORT_FALSE))->SetCheck(1);
	
	SmpOEM->get_InvokeCustomSalesDlg(ID_SALES_ADD_NEW_STOCK_ITEM ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_ADD_NEW_STOCK_ITEM_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_ADD_NEW_STOCK_ITEM_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomSalesDlg(ID_SALES_MODIFY_ITEM ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomSalesDlg(ID_SALES_MODIFYSTOCKITEMPRICE ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_PRICE_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_PRICE_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomSetupDlg(ID_SETUP_CURRENCYSETTINGS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_CURRENCY_SETTINGS_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_CURRENCY_SETTINGS_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomSetupDlg(ID_SETUP_ADDMETHODOFPAYMENT ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_METHOD_OF_PAYMENT_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_METHOD_OF_PAYMENT_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomSetupDlg(ID_SETUP_SERVICEMASTER ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_SERVICE_MASTER_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_SERVICE_MASTER_FALSE))->SetCheck(1);


	SmpOEM->get_InvokeCustomTransactionDlg(ID_TRANSACTION_TRANSACTIONDETAILS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_ADD_TRANSACTION_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_ADD_TRANSACTION_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomTransactionDlg(ID_TRANSACTION_EDITTRANSACTIONDETAILS ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_EDIT_TRANSACTION_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_EDIT_TRANSACTION_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomTransactionDlg(ID_TRANSACTION_CANCEL_TRANSACTION ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_CANCEL_TRANSACTION_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_CANCEL_TRANSACTION_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomViewMenuDlg(ID_VIEW_TOOLBAR_MAINTOOLBAR ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_TOOLBAR_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_TOOLBAR_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomViewMenuDlg(ID_VIEW_FULLSCREEN ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_FULL_SCREEN_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_FULL_SCREEN_FALSE))->SetCheck(1);

	SmpOEM->get_InvokeCustomViewMenuDlg(ID_VIEW_CLEAR_ALL ,&value);
	if(value == 1)
		((CButton*)GetDlgItem(IDC_RADIO_CLEAR_ALL_TRUE))->SetCheck(1);
	else
		((CButton*)GetDlgItem(IDC_RADIO_CLEAR_ALL_FALSE))->SetCheck(1);

}

void CSmpOEMEventsDlg::OnButtonAddCustomerSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_ADD_CUSTOMER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTMER_ADD_CUSTOMER,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTMER_ADD_CUSTOMER,FALSE);
	}
}

void CSmpOEMEventsDlg::OnButtonRefundToCustomerSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_REFUND_TO_CUSTOMER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomAccountsDlg(ID_ACCOUNTS_AMOUNTRETURN,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomAccountsDlg(ID_ACCOUNTS_AMOUNTRETURN,FALSE);
	}
	
}

void CSmpOEMEventsDlg::OnButtonEditCustomerSet() 
{
 	if(((CButton*)GetDlgItem(IDC_RADIO_EDIT_CUSTOMER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTOMER_EDITDELETECUSTOMER,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTOMER_EDITDELETECUSTOMER,FALSE);
	}
	
}

void CSmpOEMEventsDlg::OnButtonDeleteCustomerSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_DELETE_CUSTOMER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTOMER_DELETE ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTOMER_DELETE ,FALSE);
	}
	
}

void CSmpOEMEventsDlg::OnButtonFindCustomerSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_FIND_CUSTOMER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTMER_FIND ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomCustomerDlg(ID_CUSTMER_FIND ,FALSE);
	}	
}

void CSmpOEMEventsDlg::OnButtonBackupDataSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_BACKUP_DATA_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomFileMenuDlg(ID_FILE_BACKUPDATABASE ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomFileMenuDlg(ID_FILE_BACKUPDATABASE ,FALSE);
	}	
	
}
         

void CSmpOEMEventsDlg::OnButtonRegisterHelpSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_REGISTER_HELP_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_REGISTER ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_REGISTER ,FALSE);
	}	
	
}
               

void CSmpOEMEventsDlg::OnButtonHelpTopicsSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_HELP_TOPICS_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_HELPTOPICS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_HELPTOPICS ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonMenuShortcutKeysSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_MENU_SHORTCUT_KEYS_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_MENUSHORTCUTS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomHelpDlg(ID_HELP_MENUSHORTCUTS ,FALSE);
	}	
	
}


void CSmpOEMEventsDlg::OnButtonDailyReportSet() 
{
	
		if(((CButton*)GetDlgItem(IDC_RADIO_DAILY_REPORT_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_REPORTS_DAILYREPORTS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_REPORTS_DAILYREPORTS ,FALSE);
	}	
	
}


void CSmpOEMEventsDlg::OnButtonMonthlyReportSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_MONTHLY_REPORT_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_REPORTS_MONTHLYREPORTS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_REPORTS_MONTHLYREPORTS ,FALSE);
	}	
	
}
       

void CSmpOEMEventsDlg::OnButtonAnnualReportSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_ANNUAL_REPORT_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_ACCOUNTS_YEARLY_REPORTS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomreportsDlg(ID_ACCOUNTS_YEARLY_REPORTS ,FALSE);
	}	
	
}



void CSmpOEMEventsDlg::OnButtonAddNewStockItemSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_ADD_NEW_STOCK_ITEM_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_ADD_NEW_STOCK_ITEM ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_ADD_NEW_STOCK_ITEM ,FALSE);
	}	

}

void CSmpOEMEventsDlg::OnButtonModifyStockItemSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_MODIFY_ITEM ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_MODIFY_ITEM ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonModifyStockItemPriceSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_MODIFY_STOCK_ITEM_PRICE_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_MODIFYSTOCKITEMPRICE ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSalesDlg(ID_SALES_MODIFYSTOCKITEMPRICE ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonCurrencySettingsSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_CURRENCY_SETTINGS_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_CURRENCYSETTINGS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_CURRENCYSETTINGS ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonMethodOfPaymentSet() 
{
	
		if(((CButton*)GetDlgItem(IDC_RADIO_METHOD_OF_PAYMENT_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_ADDMETHODOFPAYMENT ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_ADDMETHODOFPAYMENT ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonServiceMasterSet() 
{

		if(((CButton*)GetDlgItem(IDC_RADIO_SERVICE_MASTER_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_SERVICEMASTER ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomSetupDlg(ID_SETUP_SERVICEMASTER ,FALSE);
	}	
	
	
}

void CSmpOEMEventsDlg::OnButtonAddTransactionSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_ADD_TRANSACTION_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_TRANSACTIONDETAILS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_TRANSACTIONDETAILS ,FALSE);
	}	
	
}

void CSmpOEMEventsDlg::OnButtonEditTransactionSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_EDIT_TRANSACTION_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_EDITTRANSACTIONDETAILS ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_EDITTRANSACTIONDETAILS ,FALSE);
	}	
	

}

void CSmpOEMEventsDlg::OnButtonCancelTransactionSet() 
{
		if(((CButton*)GetDlgItem(IDC_RADIO_CANCEL_TRANSACTION_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_CANCEL_TRANSACTION ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomTransactionDlg(ID_TRANSACTION_CANCEL_TRANSACTION ,FALSE);
	}	
}

void CSmpOEMEventsDlg::OnButtonToolbarSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_TOOLBAR_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_TOOLBAR_MAINTOOLBAR ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_TOOLBAR_MAINTOOLBAR ,FALSE);
	}	
	
}


void CSmpOEMEventsDlg::OnButtonFullScreenSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_FULL_SCREEN_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_FULLSCREEN ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_FULLSCREEN ,FALSE);
	}	
	
}
       

void CSmpOEMEventsDlg::OnButtonClearAllSet() 
{
	if(((CButton*)GetDlgItem(IDC_RADIO_CLEAR_ALL_TRUE))->GetCheck())
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_CLEAR_ALL ,TRUE);
	}
	else
	{
		SmpOEM->put_InvokeCustomViewMenuDlg(ID_VIEW_CLEAR_ALL ,FALSE);
	}	
	
}
