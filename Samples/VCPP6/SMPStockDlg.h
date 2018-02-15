#if !defined(AFX_SMPSTOCKDLG_H__F747FBC7_ACB8_4405_ABFF_C122A68BBB14__INCLUDED_)
#define AFX_SMPSTOCKDLG_H__F747FBC7_ACB8_4405_ABFF_C122A68BBB14__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPStockDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPStockDlg dialog

class CSMPStockDlg : public CDialog
{
// Construction
public:
	CSMPStockDlg(CWnd* pParent = NULL);   // standard constructor
    CComPtr<ISmpStock>m_SmpStock; 
    HRESULT hr;
// Dialog Data
	//{{AFX_DATA(CSMPStockDlg)
	enum { IDD = IDD_DIALOG_SMP_STOCK };
	CEdit	m_ItemName;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPStockDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSMPStockDlg)
	afx_msg void OnButtonAddNewStock();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonCancel();
	afx_msg void OnButtonCheckout();
	afx_msg void OnButtonEditStock();
	afx_msg void OnButtonModItmPrice();
	afx_msg void OnButtonStockRate();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPSTOCKDLG_H__F747FBC7_ACB8_4405_ABFF_C122A68BBB14__INCLUDED_)
