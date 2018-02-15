#if !defined(AFX_SMPOEMEVENTSDLG_H__E8A8508C_138F_4CF3_9E25_1A53E1D9A3A2__INCLUDED_)
#define AFX_SMPOEMEVENTSDLG_H__E8A8508C_138F_4CF3_9E25_1A53E1D9A3A2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpOEMEventsDlg.h : header file
//
#define ID_FILE_BACKUPDATABASE          32771
#define ID_ACCOUNTS_ACCEPTPAYMENT       32990
#define ID_CUSTMER_ADD_CUSTOMER         32833
#define ID_ACCOUNTS_AMOUNTRETURN        32994
#define ID_CUSTOMER_EDITDELETECUSTOMER  32837
#define ID_CUSTOMER_DELETE              32870
#define ID_CUSTMER_FIND                 32835
#define ID_FILE_BACKUPDATABASE          32771
#define ID_HELP_REGISTER                32931
#define ID_HELP_HELPTOPICS              32797
#define ID_HELP_MENUSHORTCUTS           32988
#define ID_REPORTS_DAILYREPORTS         32825
#define ID_REPORTS_MONTHLYREPORTS       32826
#define ID_ACCOUNTS_YEARLY_REPORTS      32867
#define ID_SALES_ADD_NEW_STOCK_ITEM     32810
#define ID_SALES_MODIFY_ITEM            32811
#define ID_SALES_MODIFYSTOCKITEMPRICE   32976
#define ID_SETUP_CURRENCYSETTINGS       32787
#define ID_SETUP_ADDMETHODOFPAYMENT     32818
#define ID_SETUP_SERVICEMASTER          32831
#define ID_TRANSACTION_TRANSACTIONDETAILS 32801
#define ID_TRANSACTION_EDITTRANSACTIONDETAILS 32809
#define ID_TRANSACTION_CANCEL_TRANSACTION 32925
#define ID_VIEW_TOOLBAR_MAINTOOLBAR     32985
#define ID_VIEW_FULLSCREEN              32999
#define ID_VIEW_CLEAR_ALL               32868
/////////////////////////////////////////////////////////////////////////////
// CSmpOEMEventsDlg dialog

class CSmpOEMEventsDlg : public CDialog
{
// Construction
public:
	void SetDefaultValues();
	CSmpOEMEventsDlg(CWnd* pParent = NULL);   // standard constructor
	CComPtr<ISmpOEM> SmpOEM;
	

// Dialog Data
	//{{AFX_DATA(CSmpOEMEventsDlg)
	enum { IDD = IDD_DIALOG_SMP_OEM_EVENTS };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpOEMEventsDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpOEMEventsDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonInvokeCustomAccountsMenu();
	afx_msg void OnButtonInvokeCustomFileMenu();
	afx_msg void OnButtonAcceptPaymentSet();
	afx_msg void OnButtonAddCustomerSet();
	afx_msg void OnButtonRefundToCustomerSet();
	afx_msg void OnButtonEditCustomerSet();
	afx_msg void OnButtonDeleteCustomerSet();
	afx_msg void OnButtonFindCustomerSet();
	afx_msg void OnButtonBackupDataSet();
	afx_msg void OnButtonRegisterHelpSet();
	afx_msg void OnButtonHelpTopicsSet();
	afx_msg void OnButtonMenuShortcutKeysSet();
	afx_msg void OnButtonDailyReportSet();
	afx_msg void OnButtonMonthlyReportSet();
	afx_msg void OnButtonAnnualReportSet();
	afx_msg void OnButtonAddNewStockItemSet();
	afx_msg void OnButtonModifyStockItemSet();
	afx_msg void OnButtonModifyStockItemPriceSet();
	afx_msg void OnButtonCurrencySettingsSet();
	afx_msg void OnButtonMethodOfPaymentSet();
	afx_msg void OnButtonServiceMasterSet();
	afx_msg void OnButtonAddTransactionSet();
	afx_msg void OnButtonEditTransactionSet();
	afx_msg void OnButtonCancelTransactionSet();
	afx_msg void OnButtonToolbarSet();
	afx_msg void OnButtonStatusSet();
	afx_msg void OnButtonFullScreenSet();
	afx_msg void OnButtonClearAllSet();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPOEMEVENTSDLG_H__E8A8508C_138F_4CF3_9E25_1A53E1D9A3A2__INCLUDED_)
