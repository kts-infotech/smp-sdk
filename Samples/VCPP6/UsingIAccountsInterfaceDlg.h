#if !defined(AFX_USINGIACCOUNTSINTERFACEDLG_H__25054C0B_5F9F_4D7D_B8BC_C1EDA17F0939__INCLUDED_)
#define AFX_USINGIACCOUNTSINTERFACEDLG_H__25054C0B_5F9F_4D7D_B8BC_C1EDA17F0939__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// UsingIAccountsInterfaceDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CUsingIAccountsInterfaceDlg dialog

class CUsingIAccountsInterfaceDlg : public CDialog
{
// Construction
public:
	CComPtr<IAccounts>m_IAccountsInterface;
	CUsingIAccountsInterfaceDlg(CWnd* pParent = NULL);   // standard constructor
	
// Dialog Data
	//{{AFX_DATA(CUsingIAccountsInterfaceDlg)
	enum { IDD = IDD_DIALOG_USING_ACCOUNTS_INTERFACE };
	CEdit	m_EditSubVal;
	CEdit	m_EditAddVal;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CUsingIAccountsInterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CUsingIAccountsInterfaceDlg)
	afx_msg void OnButtonInvokeAcceptPaymentDlg();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonInvokeRefundToCustomer();
	afx_msg void OnButtonAddToShopBalance();
	afx_msg void OnButtonSubFromShopBalance();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_USINGIACCOUNTSINTERFACEDLG_H__25054C0B_5F9F_4D7D_B8BC_C1EDA17F0939__INCLUDED_)
