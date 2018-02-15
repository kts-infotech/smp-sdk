#if !defined(AFX_IITEMDLG_H__36396915_10FE_4004_B4E2_98D69E111E12__INCLUDED_)
#define AFX_IITEMDLG_H__36396915_10FE_4004_B4E2_98D69E111E12__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// IItemDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CIItemDlg dialog

class CIItemDlg : public CDialog
{
// Construction
public:
	void PerformGetOperation();
	void CreateSampleReport();
	void PerformPutOperation();
	CComPtr<IItem>m_IItem;
	CComPtr<IISmpGenericReport>m_IISmpGenericReport;

	CIItemDlg(CWnd* pParent = NULL);   // standard constructor


// Dialog Data
	//{{AFX_DATA(CIItemDlg)
	enum { IDD = IDD_DIALOG_IITEM_INTERFACE };
	CStatic	m_StaticPutItem;
	CStatic	m_StaticGetItemOutput;
	CEdit	m_EditPutItem;
	CEdit	m_EditGetItemOutput;
	CComboBox	m_CboSelectPutItem;
	CComboBox	m_CboSelectGetItem;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CIItemDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CIItemDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonPut();
	afx_msg void OnButtonGet();
	afx_msg void OnSelchangeComboSelectGetItem();
	afx_msg void OnSelchangeComboSelectPutItem();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_IITEMDLG_H__36396915_10FE_4004_B4E2_98D69E111E12__INCLUDED_)
