#if !defined(AFX_ISALESCHECKOUTDLG_H__209CAC4F_7C1B_4B4D_9A19_7B4197D3BF9C__INCLUDED_)
#define AFX_ISALESCHECKOUTDLG_H__209CAC4F_7C1B_4B4D_9A19_7B4197D3BF9C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ISalesCheckoutDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CISalesCheckoutDlg dialog

class CISalesCheckoutDlg : public CDialog
{
// Construction
public:
	CComPtr<ISalesCheckout>m_ISalesCheckout;
	CISalesCheckoutDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CISalesCheckoutDlg)
	enum { IDD = IDD_DIALOG_SALESCHECKOUT_INTERFACE };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CISalesCheckoutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CISalesCheckoutDlg)
	afx_msg void OnButtonInvokeSalescheckoutdlg();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ISALESCHECKOUTDLG_H__209CAC4F_7C1B_4B4D_9A19_7B4197D3BF9C__INCLUDED_)
