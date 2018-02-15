#if !defined(AFX_SMPOEMDLG_H__73498616_BB06_499D_8069_8756D5F4B2A1__INCLUDED_)
#define AFX_SMPOEMDLG_H__73498616_BB06_499D_8069_8756D5F4B2A1__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SmpOEMDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CSmpOEMDlg dialog

class CSmpOEMDlg : public CDialog
{
// Construction
public:
	CSmpOEMDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CSmpOEMDlg)
	enum { IDD = IDD_DIALOG_SMP_OEM };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpOEMDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpOEMDlg)
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPOEMDLG_H__73498616_BB06_499D_8069_8756D5F4B2A1__INCLUDED_)
