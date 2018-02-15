#if !defined(AFX_USINGISMPCOMMANDS_H__698DFBFB_A942_47A5_9588_0F48D4C1C98D__INCLUDED_)
#define AFX_USINGISMPCOMMANDS_H__698DFBFB_A942_47A5_9588_0F48D4C1C98D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// UsingISMPCommands.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CUsingISMPCommands dialog

class CUsingISMPCommands : public CDialog
{
// Construction
public:
	void DisableInitialCtrls(BOOL bVal);
	CUsingISMPCommands(CWnd* pParent = NULL);   // standard constructor
	CComPtr<IISmpCommands>m_IISMPCommands;
// Dialog Data
	//{{AFX_DATA(CUsingISMPCommands)
	enum { IDD = IDD_DIALOG_IISMPCOMMANDS };
	CButton	m_btnSetSessionId;
	CButton	m_btnMenuString;
	CButton	m_btnNoOfCommands;
	CButton	m_btnMenuCmdId;
	CButton	m_btnMenuCmdEx;
	CEdit	m_EditSessionId;
	CEdit	m_EditNoOfCommands;
	CEdit	m_EditMenuString;
	CEdit	m_EditMenuCommandEx;
	CEdit	m_EditFunctionName;
	CEdit	m_EditCommandId;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CUsingISMPCommands)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CUsingISMPCommands)
	virtual BOOL OnInitDialog();
	afx_msg void OnSetSessionId();
	afx_msg void OnButtonGetMenucommandid();
	afx_msg void OnButtonGetMenucommandex();
	afx_msg void OnButtonMenustring();
	afx_msg void OnButtonGetNoofcommands();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_USINGISMPCOMMANDS_H__698DFBFB_A942_47A5_9588_0F48D4C1C98D__INCLUDED_)
