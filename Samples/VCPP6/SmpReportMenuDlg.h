#if !defined(AFX_SMPREPORTMENUDLG_H__875C508F_038A_451F_9933_5612D8F8E634__INCLUDED_)
#define AFX_SMPREPORTMENUDLG_H__875C508F_038A_451F_9933_5612D8F8E634__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpReportMenuDlg.h : header file
//
#include "resource.h"

/////////////////////////////////////////////////////////////////////////////
// CSmpReportMenuDlg dialog

class CSmpReportMenuDlg : public CDialog
{
// Construction
public:
	CSmpReportMenuDlg(CWnd* pParent = NULL);   // standard constructor
    CComPtr<ISmpReportMenu>m_SmpReportMenu;
// Dialog Data
	//{{AFX_DATA(CSmpReportMenuDlg)
	enum { IDD = IDD_DIALOG_SMP_REPORT_MENU };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpReportMenuDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpReportMenuDlg)
	afx_msg void OnButtonAnnualaccount();
	afx_msg void OnButtonAnnualsatistics();
	afx_msg void OnButtonCanceledsales();
	afx_msg void OnButtonCanceledtransactions();
	afx_msg void OnButtonCustomerbalanceamt();
	afx_msg void OnButtonCustomerinact();
	afx_msg void OnButtonCustomerlist();
	afx_msg void OnButtonCustomermostact();
	afx_msg void OnButtonCustomerpayment();
	afx_msg void OnButtonCustomerrefund();
	afx_msg void OnButtonCustomertransactions();
	afx_msg void OnButtonCustomersales();
	afx_msg void OnButtonDailysummary();
	afx_msg void OnButtonDailyaccount();
	afx_msg void OnButtonDiscountsales();
	afx_msg void OnButtonMonthlyaccount();
	afx_msg void OnButtonMonthlystatistics();
	afx_msg void OnButtonReorderlist();
	afx_msg void OnButtonRollback();
	afx_msg void OnButtonSaleslist();
	afx_msg void OnButtonServicedelivrd();
	afx_msg void OnButtonServicelist();
	afx_msg void OnButtonSpecfdperiodaccnt();
	afx_msg void OnButtonStocklist();
	afx_msg void OnButtonTransactionlist();
	afx_msg void OnButtonMisctranslist();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPREPORTMENUDLG_H__875C508F_038A_451F_9933_5612D8F8E634__INCLUDED_)
