#if !defined(AFX_SMPFILEMENUOPERATIONINTERFACE_H__45B91027_29A0_42FF_AB06_F103AB3A1332__INCLUDED_)
#define AFX_SMPFILEMENUOPERATIONINTERFACE_H__45B91027_29A0_42FF_AB06_F103AB3A1332__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Smpfilemenuoperationinterface.h : header file
//
#include"resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSmpfilemenuoperationinterface dialog

class CSmpfilemenuoperationinterface : public CDialog
{
// Construction
public:
	CSmpfilemenuoperationinterface(CWnd* pParent = NULL);   // standard constructor

	CComPtr<ISmpFileMenuOperations>m_ISmpFileMenuOperations; 
	HRESULT hr;

// Dialog Data
	//{{AFX_DATA(CSmpfilemenuoperationinterface)
	enum { IDD = IDD_DIALOG_SMP_FILE_MENU_OPERATIONS_INTERFACE };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpfilemenuoperationinterface)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpfilemenuoperationinterface)
	afx_msg void OnButtonBackupdata();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonChangePassword();
	afx_msg void OnButtonExit();
	afx_msg void OnButtonExportReport();
	afx_msg void OnButtonLogin();
	afx_msg void OnButtonLogout();
	afx_msg void OnButtonPrint();
	afx_msg void OnButtonPrintoldreceipt();
	afx_msg void OnButtonPrintPreview();
	afx_msg void OnButtonPrintSetup();
	afx_msg void OnButtonRestoreData();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPFILEMENUOPERATIONINTERFACE_H__45B91027_29A0_42FF_AB06_F103AB3A1332__INCLUDED_)
