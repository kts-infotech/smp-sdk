#if !defined(AFX_STOCKITEMSDKTESTPAGE_H__D5BFD7F5_4A7B_4649_B408_D7C1126D4833__INCLUDED_)
#define AFX_STOCKITEMSDKTESTPAGE_H__D5BFD7F5_4A7B_4649_B408_D7C1126D4833__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// StockItemSDKTestPage.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CStockItemSDKTestPage dialog

class CStockItemSDKTestPage : public CPropertyPage
{
	DECLARE_DYNCREATE(CStockItemSDKTestPage)
	CString m_strMessage;
// Construction
public:
	void SetMessage(CString strMsg);

	CStockItemSDKTestPage();
	~CStockItemSDKTestPage();
	CPropertySheet* m_pPropertySheet;
// Dialog Data
	//{{AFX_DATA(CStockItemSDKTestPage)
	enum { IDD = IDD_DIALOG_STOCK_ITEM_PAGE_SDK_TEST };
		// NOTE - ClassWizard will add data members here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_DATA


// Overrides
	// ClassWizard generate virtual function overrides
	//{{AFX_VIRTUAL(CStockItemSDKTestPage)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	virtual LRESULT WindowProc(UINT message, WPARAM wParam, LPARAM lParam);
	//}}AFX_VIRTUAL

// Implementation
protected:
	// Generated message map functions
	//{{AFX_MSG(CStockItemSDKTestPage)
	virtual void OnOK();
	virtual void OnCancel();
	virtual BOOL OnInitDialog();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_STOCKITEMSDKTESTPAGE_H__D5BFD7F5_4A7B_4649_B408_D7C1126D4833__INCLUDED_)
