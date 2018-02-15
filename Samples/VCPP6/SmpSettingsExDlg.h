#if !defined(AFX_SMPSETTINGSEXDLG_H__DA4F649C_D782_4507_A538_7F5728C0CA94__INCLUDED_)
#define AFX_SMPSETTINGSEXDLG_H__DA4F649C_D782_4507_A538_7F5728C0CA94__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpSettingsExDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CSmpSettingsExDlg dialog

class CSmpSettingsExDlg : public CDialog
{
// Construction
public:
	CSmpSettingsExDlg(CWnd* pParent = NULL);   // standard constructor
	CComPtr<ISmpSettingsEx>m_objSmpSettingsExDlg;

// Dialog Data
	//{{AFX_DATA(CSmpSettingsExDlg)
	enum { IDD = IDD_DIALOG_SMP_SETTINGS_EX };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpSettingsExDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpSettingsExDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonReloadAllApplicationsettings();
	afx_msg void OnButtonReloadAllDefaultsettings();
	afx_msg void OnButtonReloadAllLocalsettings();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPSETTINGSEXDLG_H__DA4F649C_D782_4507_A538_7F5728C0CA94__INCLUDED_)
