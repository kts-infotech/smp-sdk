#if !defined(AFX_SMPAPPINTERFACEDLG_H__7402715F_15F5_4665_87DA_2917B17152A5__INCLUDED_)
#define AFX_SMPAPPINTERFACEDLG_H__7402715F_15F5_4665_87DA_2917B17152A5__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpappinterfaceDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSmpappinterfaceDlg dialog

class CSmpappinterfaceDlg : public CDialog
{
// Construction
public:
	BOOL LoadLongResource(CString &str, UINT nID);
	CSmpappinterfaceDlg(CWnd* pParent = NULL);   // standard constructor

	CComPtr<ISmpApp>m_ISmpApp; 
	CString strSecurityXML;

// Dialog Data
	//{{AFX_DATA(CSmpappinterfaceDlg)
	enum { IDD = IDD_DIALOG_SMPAPP_INTERFACE };
	CEdit	m_windowhandle;
	CString	m_sendstatus;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpappinterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpappinterfaceDlg)
	afx_msg void OnButtonGetWindowHandle();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonSendStatus();
	afx_msg void OnButtonSetAddinInfo();
	afx_msg void OnButtonSetAddinSecurityInfo();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPAPPINTERFACEDLG_H__7402715F_15F5_4665_87DA_2917B17152A5__INCLUDED_)
