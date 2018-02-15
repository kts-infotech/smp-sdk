#if !defined(AFX_SMPSETUPDLG_H__46F5ED4A_AD35_404D_A981_BA8D7B7EA41F__INCLUDED_)
#define AFX_SMPSETUPDLG_H__46F5ED4A_AD35_404D_A981_BA8D7B7EA41F__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPSetupDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPSetupDlg dialog

class CSMPSetupDlg : public CDialog
{
// Construction
public:
	CSMPSetupDlg(CWnd* pParent = NULL);   // standard constructor
    CComPtr<ISmpSetup>m_SmpSetup; 
	HRESULT hr;
// Dialog Data
	//{{AFX_DATA(CSMPSetupDlg)
	enum { IDD = IDD_DIALOG_SMPSETUP };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPSetupDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSMPSetupDlg)
	afx_msg void OnButtonCatagoryMaster();
	afx_msg void OnButtonCurrencySettings();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonDeleteOlddata();
	afx_msg void OnButtonManageUser();
	afx_msg void OnButtonMethodOfPayment();
	afx_msg void OnButtonMiscItemMaster();
	afx_msg void OnButtonServiceMaster();
	afx_msg void OnButtonSetupWizard();
	afx_msg void OnButtonShopInfo();
	afx_msg void OnButtonStockMaster();
	afx_msg void OnButtonDefaultSetngs();
	afx_msg void OnButtonDefaultSetngsExt();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPSETUPDLG_H__46F5ED4A_AD35_404D_A981_BA8D7B7EA41F__INCLUDED_)
