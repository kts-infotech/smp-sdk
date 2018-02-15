#if !defined(AFX_SMPGRIDDLG_H__F03401CB_2D3C_4A79_9F4A_1A6056F66889__INCLUDED_)
#define AFX_SMPGRIDDLG_H__F03401CB_2D3C_4A79_9F4A_1A6056F66889__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpGridDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CSmpGridDlg dialog

class CSmpGridDlg : public CDialog
{
// Construction
public:
	CSmpGridDlg(CWnd* pParent = NULL);   // standard constructor
	CComPtr<ISmpGrid>Grid;
	CComPtr<IGrid>SmpGrid;
	CComPtr<ISmpPluginTab> SmpPluginTab;
	CComPtr<ISmpGridCtrl> SmpGridCtrl;

// Dialog Data
	//{{AFX_DATA(CSmpGridDlg)
	enum { IDD = IDD_DIALOG_SMP_GRID };
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpGridDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
     
	// Generated message map functions
	//{{AFX_MSG(CSmpGridDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAutosize();
	afx_msg void OnButtonSetAutosizeStyle();
	afx_msg void OnButtonSetFocusCell();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPGRIDDLG_H__F03401CB_2D3C_4A79_9F4A_1A6056F66889__INCLUDED_)
