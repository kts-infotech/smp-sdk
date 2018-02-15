#if !defined(AFX_USINGICUSTOMERINTERFACEDLG_H__9FB6C858_EE77_4341_8187_ECF3AACD02E3__INCLUDED_)
#define AFX_USINGICUSTOMERINTERFACEDLG_H__9FB6C858_EE77_4341_8187_ECF3AACD02E3__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// UsingICustomerInterfaceDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// UsingICustomerInterfaceDlg dialog

class UsingICustomerInterfaceDlg : public CDialog
{
// Construction
public:
	CComPtr<ICustomer>m_ICustomer;
	UsingICustomerInterfaceDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(UsingICustomerInterfaceDlg)
	enum { IDD = IDD_DIALOG_ICUSTOMER_INTERFACE };
	CEdit	m_EditFieldName;
	CEdit	m_EditCustId;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(UsingICustomerInterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(UsingICustomerInterfaceDlg)
	afx_msg void OnButtonFind();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonInvokeFindcustomerDlg();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_USINGICUSTOMERINTERFACEDLG_H__9FB6C858_EE77_4341_8187_ECF3AACD02E3__INCLUDED_)
