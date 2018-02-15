#if !defined(AFX_SMPGRIDCONTROLDLG_H__CD43F3CF_8608_46BE_8688_91F519979FE2__INCLUDED_)
#define AFX_SMPGRIDCONTROLDLG_H__CD43F3CF_8608_46BE_8688_91F519979FE2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
#include "Resource.h"
// SmpGridControlDlg.h : header file
//
/////////////////////////////////////////////////////////////////////////////
// CSmpGridControlDlg dialog

class CSmpGridControlDlg : public CDialog
{
// Construction 
public:
	CString SetPicturePath(CString strPhotoPath, CString strFileExtenction);
	void InitializeGrid();
	int ConvertToInt(CString strValue);
	void InitializeComboBxes();
	CSmpGridControlDlg(CWnd* pParent = NULL);   // standard constructor
	CString m_strImagePath;
	CComPtr<IGrid> SmpGrid;
	CComPtr<ISmpPluginTab> SmpPluginTab;
	CComPtr<ISmpGridCtrl> SmpGridCtrl;
     
// Dialog Data
	//{{AFX_DATA(CSmpGridControlDlg)
	enum { IDD = IDD_DIALOG_SMP_GRID_CONTROL };
	CEdit	m_strdefaultRowHeight;
	CEdit	m_strDefaultColumnWidth;
	CComboBox	m_cboCellTextWrapColumn;
	CComboBox	m_cboCellTextWrapRow;
	CComboBox	m_cboSetCellTextAlignmentColumn;
	CComboBox	m_cboCellTextAlignmentRow;
	CEdit	m_strCellText;
	CComboBox	m_cboCellTextRow;
	CComboBox	m_cboCellTextColumn;
	CComboBox	m_cboCellImageExSelectRow;
	CComboBox	m_cboCellImageExSelectColumn;
	CComboBox	m_cboCellImageSelectColumn;
	CComboBox	m_cboCellImageSelectRow;
	CComboBox	m_cboSelectColumn;
	CComboBox	m_cboSelectRow;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSmpGridControlDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSmpGridControlDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonAutosize();
	afx_msg void OnButtonBusinessLogo();
	afx_msg void OnButtonDeleteAllimages();
	afx_msg void OnButtonDeleteAllItems();
	afx_msg void OnButtonRefreshControl();
	afx_msg void OnButtonSetCellImage();
	afx_msg void OnButtonBrowse();
	afx_msg void OnButtonBrowseImage();
	afx_msg void OnButtonCreateBasicReport();
	afx_msg void OnButtonCreateDetailReport();
	afx_msg void OnButtonSetCellImageResource();
	afx_msg void OnButtonSetCellText();
	afx_msg void OnButtonSetAlignment();
	afx_msg void OnButtonSetCellTextWrap();
	afx_msg void OnButtonSetDefaultColumnWidth();
	afx_msg void OnButtonSetDefaultRowHeight();
	afx_msg void OnButtonSetGridDisplayReadOnly();
	afx_msg void OnButtonSetWordWrapMode();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPGRIDCONTROLDLG_H__CD43F3CF_8608_46BE_8688_91F519979FE2__INCLUDED_)
