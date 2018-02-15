#if !defined(AFX_SMPUSEREVENTDLG_H__70CAC095_FAE9_4CDC_A3B3_DA06E2BCAE67__INCLUDED_)
#define AFX_SMPUSEREVENTDLG_H__70CAC095_FAE9_4CDC_A3B3_DA06E2BCAE67__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPUserEventDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CSMPUserEventDlg dialog
#include "resource.h"
class CSMPUserEventDlg : public CPropertyPage
{
	DECLARE_DYNCREATE(CSMPUserEventDlg)

// Construction
public:
	CSMPUserEventDlg();
	~CSMPUserEventDlg();
	CPropertySheet* m_pPropertySheet;
// Dialog Data
	//{{AFX_DATA(CSMPUserEventDlg)
	enum { IDD = IDD_DIALOG_USER_EVENT };
		// NOTE - ClassWizard will add data members here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_DATA


// Overrides
	// ClassWizard generate virtual function overrides
	//{{AFX_VIRTUAL(CSMPUserEventDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	// Generated message map functions
	//{{AFX_MSG(CSMPUserEventDlg)
	virtual void OnOK();
	virtual void OnCancel();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPUSEREVENTDLG_H__70CAC095_FAE9_4CDC_A3B3_DA06E2BCAE67__INCLUDED_)
