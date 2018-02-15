#if !defined(AFX_TRANSACTION_H__796EF423_2DB2_4050_8D03_8DCD13E76F42__INCLUDED_)
#define AFX_TRANSACTION_H__796EF423_2DB2_4050_8D03_8DCD13E76F42__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Transaction.h : header file
//
/////////////////////////////////////////////////////////////////////////////
// CTransaction dialog

class CTransaction : public CDialog
{
// Construction
public:
	CTransaction(CWnd* pParent = NULL);   // standard constructor
	CComPtr<ITransactions>m_Transaction;
// Dialog Data
	//{{AFX_DATA(CTransaction)
	enum { IDD = IDD_DIALOG__TRANSACTION };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTransaction)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CTransaction)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAdMiscXpnse();
	afx_msg void OnButtonAdMscIncme();
	afx_msg void OnButtonAdTrnstion();
	afx_msg void OnButtonCnclTranstion();
	afx_msg void OnButtonEditMiscXpense();
	afx_msg void OnButtonEditMiscIncme();
	afx_msg void OnButtonEditTranstion();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TRANSACTION_H__796EF423_2DB2_4050_8D03_8DCD13E76F42__INCLUDED_)
