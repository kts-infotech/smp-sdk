#if !defined(AFX_SMPREPORTDLG_H__A04A0EC1_67D2_464A_814B_7F1A9D29E60D__INCLUDED_)
#define AFX_SMPREPORTDLG_H__A04A0EC1_67D2_464A_814B_7F1A9D29E60D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpReportDlg.h : header file
//
#include "resource.h"
#include <TCHAR.h>
/////////////////////////////////////////////////////////////////////////////
// CSmpReportDlg dialog

class CSmpReportDlg : public CDialog
{
// Construction
public:
	void OnSaveHeaderInfo();
	void OnSaveHeaderFormat();
	void OnSaveFooterInfo();
	void OnSaveFooterFormat();
	void OnSaveBodyFormat();
	BSTR m_bstrSQLQuery,m_bstrFont,m_bstrFooter1,m_bstrFooter2,m_bstrFooter3,m_bstrMainHeading1,m_bstrMainHeading2,m_bstrSubHeading1,m_bstrSubHeading2,m_bstrHeaderImagePath;
	CString m_strSQLQuery,m_strFont,m_strSize,m_strColour,m_strFooter1,m_strFooter2,m_strFooter3,m_strMainHeading1,m_strMainHeading2,m_strSubHeading1,m_strSubHeading2,m_strHeaderImagePath;
	long m_lSize,m_lColour;
	void ClearControls();
	void OnSelectHeaderInfo();
	void OnSelectHeaderFormat();
	void OnSelectFooterInfo();
	void OnSelectFooterFormat();
	void OnSelectBodyFormat();
    CComPtr<ISmpReport>m_SmpReport;
	CSmpReportDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CSmpReportDlg)
	enum { IDD = IDD_DIALOG_SMP_REPORT };
	CComboBox	m_ComboTableList;
	CEdit	m_EditItem2;
	CStatic	m_LableItem5;
	CStatic	m_LableItem4;
	CStatic	m_LableItem3;
	CStatic	m_LableItem2;
	CStatic	m_LableItem1;
	CEdit	m_EditItem5;
	CEdit	m_EditItem4;
	CEdit	m_EditItem3;
	CEdit	m_EditItem1;
	CComboBox	m_ComboItems;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpReportDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpReportDlg)
	afx_msg void OnButtonGenreport();
	afx_msg void OnButtonPrintreport();
	afx_msg void OnButtonResetstyles();
	afx_msg void OnButtonSave();
	afx_msg void OnSelchangeComboItems();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAddtable();
	afx_msg void OnButtonCancel();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPREPORTDLG_H__A04A0EC1_67D2_464A_814B_7F1A9D29E60D__INCLUDED_)
