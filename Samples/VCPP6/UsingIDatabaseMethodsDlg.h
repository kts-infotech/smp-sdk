#if !defined(AFX_USINGIDATABASEMETHODSDLG_H__A0D6E6F4_95C2_4F79_9E4E_725CF42FB056__INCLUDED_)
#define AFX_USINGIDATABASEMETHODSDLG_H__A0D6E6F4_95C2_4F79_9E4E_725CF42FB056__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// UsingIDatabaseMethodsDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CUsingIDatabaseMethodsDlg dialog
#define CBO_OPERATION_SELECT	_T("SELECT")
#define CBO_OPERATION_DELETE	_T("DELETE")
#define CBO_OPERATION_INSERT	_T("INSERT")
#define CBO_OPERATION_UPDATE	_T("UPDATE")

class CUsingIDatabaseMethodsDlg : public CDialog
{
// Construction
public:
	CString GetDBPath();
	CStringArray m_strFieldsArray;
	CComPtr<IDatabase> m_IDatabase;
	CString CrackStrVariant(const COleVariant& var);
	BOOL FillResultsListCtrl(VARIANT *pQueryResult);
	BOOL ExecuteSelectQuery();
	void Initialise();
	CUsingIDatabaseMethodsDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CUsingIDatabaseMethodsDlg)
	enum { IDD = IDD_DIALOG_USING_IDATABASE_METHODS };
	CEdit	m_editDBPath;
	CStatic	m_staticResult;
	CListCtrl	m_listCtrlResult;
	CListBox	m_listDatabaseFields;
	CEdit	m_editTableName;
	CEdit	m_editFieldName;
	CComboBox	m_cboDatabaseOperation;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CUsingIDatabaseMethodsDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CUsingIDatabaseMethodsDlg)
	afx_msg void OnButtonAddField();
	virtual void OnOK();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_USINGIDATABASEMETHODSDLG_H__A0D6E6F4_95C2_4F79_9E4E_725CF42FB056__INCLUDED_)
