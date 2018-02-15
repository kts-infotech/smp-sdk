#if !defined(AFX_USINGISMPVIEWINTERFACEDLG_H__28A692BA_8C58_4798_B9A1_CE4196E3E30B__INCLUDED_)
#define AFX_USINGISMPVIEWINTERFACEDLG_H__28A692BA_8C58_4798_B9A1_CE4196E3E30B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// UsingISmpViewInterfaceDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CUsingISmpViewInterfaceDlg dialog

class CUsingISmpViewInterfaceDlg : public CDialog
{
// Construction
	CComPtr<ISmpView> m_ISmpView;
public:
	CUsingISmpViewInterfaceDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CUsingISmpViewInterfaceDlg)
	enum { IDD = IDD_DIALOG_USING_ISMPVIEW_INTERFACE };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CUsingISmpViewInterfaceDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CUsingISmpViewInterfaceDlg)
	afx_msg void OnButtonPrintReport();
	afx_msg void OnButtonPrintInDosMode();
	virtual void OnOK();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_USINGISMPVIEWINTERFACEDLG_H__28A692BA_8C58_4798_B9A1_CE4196E3E30B__INCLUDED_)
