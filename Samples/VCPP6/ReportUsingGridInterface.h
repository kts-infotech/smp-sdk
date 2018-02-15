#if !defined(AFX_REPORTUSINGGRIDINTERFACE_H__80DF4525_19B9_4AA0_8F8E_13804A32DD7A__INCLUDED_)
#define AFX_REPORTUSINGGRIDINTERFACE_H__80DF4525_19B9_4AA0_8F8E_13804A32DD7A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ReportUsingGridInterface.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CReportUsingGridInterface dialog

class CReportUsingGridInterface : public CDialog
{
// Construction
public:
	void DisableControls();

	int ConvertToInt(CString strValue);
	void InitializeComboBoxes();
	void FillValues();
	CReportUsingGridInterface(CWnd* pParent = NULL);   // standard constructor


	CString m_strCellText;
	CString m_strRowHeight;
	CString m_strRow;
	CString m_strNoOfRows;
	CString m_strNoOfFixedRows;
	CString m_strNoOfCols;
	CString m_strInsOrDelRow;
	CString m_strInsOrDelCol;
	CString m_strVerticalGridLine;
	CString m_strHorizontalGridLine;
	CString m_strColWidth;
	CString m_strCol;
	CString m_strCellTextColor;
	CString m_strCellFontType;
	CString m_strCellFontSize;
	CString m_strCellFont;
	CString m_strCellColor;
	CString m_strNoOfFixedCols;

	BOOL m_bFont;
	


// Dialog Data
	//{{AFX_DATA(CReportUsingGridInterface)
	enum { IDD = IDD_DIALOG_USING_GRID_INTERFACE };
	CEdit	m_editCellText;
	CComboBox	m_cboRowHeight;
	CComboBox	m_cboRow;
	CComboBox	m_cboNoOfRows;
	CComboBox	m_cboNoOfFixedRows;
	CComboBox	m_cboNoOfFixedCols;
	CComboBox	m_cboNoOfCols;
	CComboBox	m_cboInsOrDelRow;
	CComboBox	m_cboInsOrDelCol;
	CComboBox	m_cboVerticalGridLine;
	CComboBox	m_cboHorizontalGridLine;
	CComboBox	m_cboColWidth;
	CComboBox	m_cboCol;
	CComboBox	m_cboCellTextColor;
	CComboBox	m_cboCellFontType;
	CComboBox	m_cboCellFontSize;
	CComboBox	m_cboCellFont;
	CComboBox	m_cboCellColor;
	BOOL	m_bCellColor;
	BOOL	m_bCellFont;
	BOOL	m_bFontSize;
	BOOL	m_bFontType;
	BOOL	m_bReadOnly;
	BOOL	m_bUpdateCol;
	BOOL	m_bUpdateRow;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CReportUsingGridInterface)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CReportUsingGridInterface)
	afx_msg void OnButtonDelete();
	afx_msg void OnButtonInsert();
	virtual void OnCancel();
	virtual void OnOK();
	virtual BOOL OnInitDialog();
	afx_msg void OnCheckUpdateRow();
	afx_msg void OnCheckUpdateCol();
	afx_msg void OnCheckCellColor();
	afx_msg void OnCheckCellFont();
	afx_msg void OnCheckFontSize();
	afx_msg void OnCheckFontType();
	afx_msg void OnCheckReadOnly();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_REPORTUSINGGRIDINTERFACE_H__80DF4525_19B9_4AA0_8F8E_13804A32DD7A__INCLUDED_)
