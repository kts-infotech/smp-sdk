#if !defined(AFX_SMPUSERSETTINGSDLG_H__D64B8587_E990_47C7_A0AD_DE4F7B8FBA0A__INCLUDED_)
#define AFX_SMPUSERSETTINGSDLG_H__D64B8587_E990_47C7_A0AD_DE4F7B8FBA0A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPUserSettingsDlg.h : header file
//
#include "resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPUserSettingsDlg dialog

class CSMPUserSettingsDlg : public CDialog
{
// Construction
public:
	CSMPUserSettingsDlg(CWnd* pParent = NULL);   // standard constructor
    CComPtr<ISmpUser>m_SmpUser; 
    HRESULT hr;
	CString strLoginUser;
	BSTR loginuser;
// Dialog Data
	//{{AFX_DATA(CSMPUserSettingsDlg)
	enum { IDD = IDD_DIALOG_SMP_USER };
	CButton	m_Login;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPUserSettingsDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSMPUserSettingsDlg)
	afx_msg void OnButtonLogin();
	afx_msg void OnButtonChngePass();
	virtual BOOL OnInitDialog();
	afx_msg void OnTimer(UINT nIDEvent);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPUSERSETTINGSDLG_H__D64B8587_E990_47C7_A0AD_DE4F7B8FBA0A__INCLUDED_)
