#if !defined(AFX_SETTINGSINTERFACEDLG_H__CE1A1421_F310_43DD_BCAA_34F0513DE93A__INCLUDED_)
#define AFX_SETTINGSINTERFACEDLG_H__CE1A1421_F310_43DD_BCAA_34F0513DE93A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SettingsinterfaceDlg.h : header file
//
#include"resource.h"
/////////////////////////////////////////////////////////////////////////////
// CSettingsinterfaceDlg dialog

class CSettingsinterfaceDlg : public CDialog
{
// Construction
public:
	CSettingsinterfaceDlg(CWnd* pParent = NULL);   // standard constructor

	CComPtr<ISettings>m_ISettings; 
	HRESULT hr;

// Dialog Data
	//{{AFX_DATA(CSettingsinterfaceDlg)
	enum { IDD = IDD_DIALOG_SETTINGS_INTERFACE };
	CEdit	m_settings_out;
	CString	m_Paymentmethod;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSettingsinterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSettingsinterfaceDlg)
	afx_msg void OnButtonCompactDatabase();
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAutomaticbackup();
	afx_msg void OnButtonautomaticCompact();
	afx_msg void OnButtonDateFormat();
	afx_msg void OnButtonDefaultMembershipfee();
	afx_msg void OnButtonDefaultSecurityDeposit();
	afx_msg void OnButtonPaymentMethod();
	afx_msg void OnButtonPictureFolder();
	afx_msg void OnButtonLaunchOnStartup();
	afx_msg void OnButtonNoOfDisplayRecords();
	afx_msg void OnButtonOverrideExDataOn();
	afx_msg void OnButtonUseEnterKey();
	afx_msg void OnButtonSetPaymentMethod();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SETTINGSINTERFACEDLG_H__CE1A1421_F310_43DD_BCAA_34F0513DE93A__INCLUDED_)
