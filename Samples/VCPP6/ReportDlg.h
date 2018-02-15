#if !defined(AFX_REPORTDLG_H__4925DBCE_B4D5_4863_903B_988C7E5C5FA2__INCLUDED_)
#define AFX_REPORTDLG_H__4925DBCE_B4D5_4863_903B_988C7E5C5FA2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ReportDlg.h : header file
//
#include "Resource.h"
/////////////////////////////////////////////////////////////////////////////
// CReportDlg dialog

class CReportDlg : public CDialog
{
// Construction
public:
	void ClearControls();
	void DisableControlsOnLoad();
	BOOL CheckEnteredValuesOnCap();
	BOOL CheckEnteredValuesOnAddInfo();
	void EnableControlsOnCaption(BOOL bStatus);
	void EnableControlsOnAddInfo(BOOL bStatus);
	CReportDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CReportDlg)
	enum { IDD = IDD_DIALOG_REPORT };
	CComboBox	m_ComboTableList;
	CButton	m_CheckShowHeader;
	CButton	m_CheckShowFooter;
	CEdit	m_EditHeading;
	CEdit	m_EditCaption;
	CEdit	m_EditAddHeading;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CReportDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CReportDlg)
	afx_msg void OnRadioNormal();
	afx_msg void OnRadioWithaddinfo();
	afx_msg void OnRadioWithcap();
	afx_msg void OnButtonReport();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAddnewtable();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_REPORTDLG_H__4925DBCE_B4D5_4863_903B_988C7E5C5FA2__INCLUDED_)
