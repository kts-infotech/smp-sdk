#if !defined(AFX_GENERICREPORTUSINGATTRIBDLG_H__9501412F_6BC0_480D_B40E_E15F058B994B__INCLUDED_)
#define AFX_GENERICREPORTUSINGATTRIBDLG_H__9501412F_6BC0_480D_B40E_E15F058B994B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// GenericReportUsingAttribDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CGenericReportUsingAttribDlg dialog

class CGenericReportUsingAttribDlg : public CDialog
{
// Construction
public:
	void FillBodyContents();
	void InitializeBodyContents();
	void InitializeComboBoxes();
	int ConvertToInt(CString strValue);
	void GetAttributeValues();
	CGenericReportUsingAttribDlg(CWnd* pParent = NULL);   // standard constructor

	CString m_strFooter;
	CString m_strHeader;

	CString m_strFooterCols;	
	CString m_strFooterFont;
	CString m_strFooterFontColor;
	CString m_strFooterFontSize;	
	CString m_strFooterMaxCols;
	CString m_strFooterMaxRows;
	CString m_strFooterRows;
	CString m_strFooterAlignment;

	CString m_strHeaderCols;	
	CString m_strHeaderFont;
	CString m_strHeaderFontColor;
	CString m_strHeaderFontSize;
	CString m_strHeaderMaxCols;
	CString m_strHeaderMaxRows;
	CString m_strHeaderRows;
	CString m_strHeaderAlignment;

	CString m_strBodyCols;	
	CString m_strBodyFontSize;
	CString m_strBodyMaxCols;
	CString m_strBodyMaxRows;
	CString m_strBodyRows;
	CString m_strBodyAlignment;

	CString m_strBodyContentName;
	CString m_strBodyContent;

	int iBodyContentsListCount;

	CStringArray m_strarrBodyContentName;
	CStringArray m_strarrBodyContent;
	


// Dialog Data
	//{{AFX_DATA(CGenericReportUsingAttribDlg)
	enum { IDD = IDD_DIALOG_GENERIC_REPORT_USING_ATTRIBUTE };
	CListCtrl	m_lstBodyContents;
	CEdit	m_editBodyContentName;
	CEdit	m_editBodyContent;
	CComboBox	m_cboHeaderAlignment;
	CComboBox	m_cboFooterAlignment;
	CComboBox	m_cboBodyRow;
	CComboBox	m_cboBodyMaxRow;
	CComboBox	m_cboBodyMaxcol;
	CComboBox	m_cboBodyFontSize;
	CComboBox	m_cboBodyCol;
	CComboBox	m_cboBodyAlignment;
	CComboBox	m_cboHeaderRows;
	CComboBox	m_cboHeaderMaxRows;
	CComboBox	m_cboHeaderMaxCols;
	CComboBox	m_cboHeaderFontSize;
	CComboBox	m_cboHeaderFontColor;
	CComboBox	m_cboHeaderFont;
	CComboBox	m_cboHeaderContentType;
	CComboBox	m_cboHeaderCols;
	CComboBox	m_cboFooterRows;
	CComboBox	m_cboFooterMaxRows;
	CComboBox	m_cboFooterMaxCols;
	CComboBox	m_cboFooterFontSize;
	CComboBox	m_cboFooterFontColor;
	CComboBox	m_cboFooterFont;
	CComboBox	m_cboFooterContentType;
	CComboBox	m_cboFooterCols;
	CEdit	m_editFooter;
	CEdit	m_editHeader;
	BOOL	m_bHeaderBold;
	BOOL	m_bFooterItalic;
	BOOL	m_bFooterBold;
	BOOL	m_bBodyBold;
	BOOL	m_bBodyItalic;
	BOOL	m_bShowHeading;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CGenericReportUsingAttribDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CGenericReportUsingAttribDlg)
	virtual void OnOK();
	afx_msg void OnButtonAddBody();
	afx_msg void OnButtonRemoveBody();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_GENERICREPORTUSINGATTRIBDLG_H__9501412F_6BC0_480D_B40E_E15F058B994B__INCLUDED_)
