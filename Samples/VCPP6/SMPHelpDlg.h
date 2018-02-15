#if !defined(AFX_SMPHELPDLG_H__592951EC_670F_4F66_8E82_F607661365AF__INCLUDED_)
#define AFX_SMPHELPDLG_H__592951EC_670F_4F66_8E82_F607661365AF__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPHelpDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPHelpDlg dialog

class CSMPHelpDlg : public CDialog
{
// Construction
public:
	BSTR strfile;
	CSMPHelpDlg(CWnd* pParent = NULL);   // standard constructor
    
// Dialog Data
	//{{AFX_DATA(CSMPHelpDlg)
	enum { IDD = IDD_DIALOG_SMP_HELP };
	CEdit	m_HelpFilepath;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPHelpDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	// Generated message map functions
	//{{AFX_MSG(CSMPHelpDlg)
	afx_msg void OnButtonAbout();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonTip();
	afx_msg void OnButtonShortkey();
	afx_msg void OnButtonHelp();
	afx_msg void OnButtonRegister();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPHELPDLG_H__592951EC_670F_4F66_8E82_F607661365AF__INCLUDED_)
