#if !defined(AFX_SMPREPORTSETTINGSDLG_H__1324EE77_6E8B_4813_8E1C_03417C7382BC__INCLUDED_)
#define AFX_SMPREPORTSETTINGSDLG_H__1324EE77_6E8B_4813_8E1C_03417C7382BC__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpReportSettingsDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSmpReportSettingsDlg dialog

class CSmpReportSettingsDlg : public CDialog
{
// Construction
public:
	long m_lValue;
	CSmpReportSettingsDlg(CWnd* pParent = NULL);   // standard constructor
	CComPtr<ISmpReportSettings>m_objCSmpReportSettingsDlg;
// Dialog Data
	//{{AFX_DATA(CSmpReportSettingsDlg)
	enum { IDD = IDD_DIALOG_SMP_REPORT_SETTINGS };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpReportSettingsDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpReportSettingsDlg)
	afx_msg void OnButtonBypassprint();
	afx_msg void OnButtonPrintshopnameatheader();
	afx_msg void OnButtonPrintmembershipform();
	afx_msg void OnButtonPrinttimeatfooter();
	afx_msg void OnButtonPrintshoplogo();
	afx_msg void OnButtonPrintphnoatfooter();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPREPORTSETTINGSDLG_H__1324EE77_6E8B_4813_8E1C_03417C7382BC__INCLUDED_)
