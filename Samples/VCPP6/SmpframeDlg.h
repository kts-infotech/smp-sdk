#if !defined(AFX_SMPFRAMEDLG_H__75F3CE0E_A83D_4012_B678_B0AFD959F903__INCLUDED_)
#define AFX_SMPFRAMEDLG_H__75F3CE0E_A83D_4012_B678_B0AFD959F903__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpframeDlg.h : header file
//
#include"resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSmpframeDlg dialog

class CSmpframeDlg : public CDialog
{
// Construction
public:
	CSmpframeDlg(CWnd* pParent = NULL);   // standard constructor

	CComPtr<ISmpFrame>m_ISmpFrame; 

// Dialog Data
	//{{AFX_DATA(CSmpframeDlg)
	enum { IDD = IDD_DIALOG_SMP_FRAME_INTERFACE };
	CComboBox	m_red;
	CComboBox	m_green;
	CComboBox	m_blue;
	CComboBox	m_pane;
	CEdit	m_Frameoutput;
	CString	m_index;
	CString	m_Panestatus;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpframeDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpframeDlg)
	afx_msg void OnButtonLeftToolbarHandle();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonMainFrameHandle();
	afx_msg void OnButtonMainToolbarHandle();
	afx_msg void OnButtonMenuHandle();
	afx_msg void OnButtonPluginToolbarCount();
	afx_msg void OnButtonRightToolbarHandle();
	afx_msg void OnButtonStatusBarHandle();
	afx_msg void OnButtonPluginToolbarHandle();
	afx_msg void OnButtonSetPaneStatus();
	afx_msg void OnEditchangeComboPane();
	afx_msg void OnButtonDeleteMenu();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPFRAMEDLG_H__75F3CE0E_A83D_4012_B678_B0AFD959F903__INCLUDED_)
