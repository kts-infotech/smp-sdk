#if !defined(AFX_ACCNTSREPORTTESTDLG_H__8E5BE94E_909A_4E15_B6E9_51458AE55378__INCLUDED_)
#define AFX_ACCNTSREPORTTESTDLG_H__8E5BE94E_909A_4E15_B6E9_51458AE55378__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// AccntsReportTestDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CAccntsReportTestDlg dialog

class CAccntsReportTestDlg : public CPropertyPage
{
	DECLARE_DYNCREATE(CAccntsReportTestDlg)

// Construction
public:
	CAccntsReportTestDlg();
	~CAccntsReportTestDlg();
    CPropertySheet* pSheet;
// Dialog Data
	//{{AFX_DATA(CAccntsReportTestDlg)
	enum { IDD = IDD_DIALOG_ACCNTS_REP_TEST_DLG };
		// NOTE - ClassWizard will add data members here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_DATA


// Overrides
	// ClassWizard generate virtual function overrides
	//{{AFX_VIRTUAL(CAccntsReportTestDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	// Generated message map functions
	//{{AFX_MSG(CAccntsReportTestDlg)
	virtual void OnOK();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_ACCNTSREPORTTESTDLG_H__8E5BE94E_909A_4E15_B6E9_51458AE55378__INCLUDED_)
