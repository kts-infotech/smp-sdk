#if !defined(AFX_SMPPLUGINTABDLG_H__B1F9D1B4_3BCD_4CEE_BCDE_E336A2955DF9__INCLUDED_)
#define AFX_SMPPLUGINTABDLG_H__B1F9D1B4_3BCD_4CEE_BCDE_E336A2955DF9__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPPluginTabDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPPluginTabDlg dialog

class CSMPPluginTabDlg : public CDialog
{
// Construction
public:
     int iView;
     int iFormView;
	CSMPPluginTabDlg(CWnd* pParent = NULL);   // standard constructor
    CComPtr<ISmpPluginTab>m_SmpPluginTab; 
;
// Dialog Data
	//{{AFX_DATA(CSMPPluginTabDlg)
	enum { IDD = IDD_DIALOG_SMP_PLUGINTAB };
	CString	m_ViewIndex;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPPluginTabDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSMPPluginTabDlg)
	afx_msg void OnButtonCreateView();
	afx_msg void OnButtonCrteFormView();
	virtual BOOL OnInitDialog();
	afx_msg void OnButton3();
	afx_msg void OnButtonCreateHtmlView();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPPLUGINTABDLG_H__B1F9D1B4_3BCD_4CEE_BCDE_E336A2955DF9__INCLUDED_)
