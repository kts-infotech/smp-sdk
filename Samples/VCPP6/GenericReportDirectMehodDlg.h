#if !defined(AFX_GENERICREPORTDIRECTMEHODDLG_H__4729457E_B784_4306_AB30_0174DDEB33CF__INCLUDED_)
#define AFX_GENERICREPORTDIRECTMEHODDLG_H__4729457E_B784_4306_AB30_0174DDEB33CF__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// GenericReportDirectMehodDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CGenericReportDirectMehodDlg dialog

class CGenericReportDirectMehodDlg : public CDialog
{
// Construction
public:
	void FillBodyContents();
	void InitializeBodyContents();
	void InitializeComboBoxes();
	void GetAttributeValues();
	int ConvertToInt(CString strValue);
	CGenericReportDirectMehodDlg(CWnd* pParent = NULL);   // standard constructor
	

	CString m_strBodyCol;
	CString m_strBodyMaxCol;
	CString m_strBodyRow;
	CString m_strBodyMaxRow;
	CString m_strBodyAlignment;
	CString m_strBodyContentName;
	CString m_strBodyContent;

	CString m_strHeader;
	CString m_strHeaderCol;
	CString m_strHeaderMaxCol;
	CString m_strHeaderRow;
	CString m_strHeaderMaxRow;
	CString m_strHeaderAlignment;

	CString m_strFooter;
	CString m_strFooterCol;
	CString m_strFooterMaxCol;
	CString m_strFooterRow;
	CString m_strFooterMaxRow;
	CString m_strFooterAlignment;

	CStringArray m_strarrBodyContentName;
	CStringArray m_strarrBodyContent;

	int iBodyContentsListCount;




// Dialog Data
	//{{AFX_DATA(CGenericReportDirectMehodDlg)
	enum { IDD = IDD_DIALOG_GENERIC_REPORT_DIRECT };
	CComboBox	m_cboBodyMaxCol;
	CEdit	m_editBodyContentName;
	CEdit	m_editBodyContent;
	CComboBox	m_cboHeaderRow;
	CComboBox	m_cboHeaderMaxRow;
	CComboBox	m_cboHeaderMaxCol;
	CComboBox	m_cboHeaderCol;
	CComboBox	m_cboHeaderAlignment;
	CComboBox	m_cboFooterRow;
	CComboBox	m_cboFooterMaxRow;
	CComboBox	m_cboFooterMaxCol;
	CComboBox	m_cboFooterCol;
	CComboBox	m_cboFooterAlignment;
	CComboBox	m_cboBodyRow;
	CComboBox	m_cboBodyMaxRow;
	CComboBox	m_cboBodyCol;
	CComboBox	m_cboBodyAlignment;
	CEdit	m_editHeader;
	CEdit	m_editFooter;
	CListCtrl	m_lstBodyContents;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CGenericReportDirectMehodDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CGenericReportDirectMehodDlg)
	virtual void OnOK();
	afx_msg void OnButtonAddBody();
	afx_msg void OnButtonRemoveBody();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_GENERICREPORTDIRECTMEHODDLG_H__4729457E_B784_4306_AB30_0174DDEB33CF__INCLUDED_)
