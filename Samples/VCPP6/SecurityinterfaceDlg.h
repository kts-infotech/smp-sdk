#if !defined(AFX_SECURITYINTERFACEDLG_H__5E50889B_7465_4A04_9A87_A434AD8FEE9B__INCLUDED_)
#define AFX_SECURITYINTERFACEDLG_H__5E50889B_7465_4A04_9A87_A434AD8FEE9B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SecurityinterfaceDlg.h : header file
//
#include"resource.h"

/////////////////////////////////////////////////////////////////////////////
// CSecurityinterfaceDlg dialog

class CSecurityinterfaceDlg : public CDialog
{
// Construction
public:
	CSecurityinterfaceDlg(CWnd* pParent = NULL);   // standard constructor

	CComPtr<ISecurity>m_ISecurity; 


// Dialog Data
	//{{AFX_DATA(CSecurityinterfaceDlg)
	enum { IDD = IDD_DIALOG_SECURITY_INTERFACE };
	CEdit	m_output;
	CString	m_username;
	CString	m_LeafSecurityNoadName;
	CString	m_ModuleName;
	CString	m_ModuleSection;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSecurityinterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSecurityinterfaceDlg)
	afx_msg void OnButtonAccessCustomerMenu();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAccessSalesMenu();
	afx_msg void OnButtonAccessSetup();
	afx_msg void OnButtonAccessTransactionMenu();
	afx_msg void OnButtonCurrentloginUser();
	afx_msg void OnButtonCurrentUserRights();
	afx_msg void OnButtonDatabaseRights();
	afx_msg void OnButtonPrintReports();
	afx_msg void OnButtonUpdateShopeBalance();
	afx_msg void OnButtonViewReports();
	afx_msg void OnButtonUserRightsInfo();
	afx_msg void OnButtonUserRightInfo();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SECURITYINTERFACEDLG_H__5E50889B_7465_4A04_9A87_A434AD8FEE9B__INCLUDED_)
