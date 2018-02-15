#if !defined(AFX_SMPRECEPTSETTINGSDLG_H__6FA06298_1894_4E2C_8CD3_02D4B551268C__INCLUDED_)
#define AFX_SMPRECEPTSETTINGSDLG_H__6FA06298_1894_4E2C_8CD3_02D4B551268C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SMPReceptSettingsDlg.h : header file
//
/////////////////////////////////////////////////////////////////////////////
// CSMPReceptSettingsDlg dialog

class CSMPReceptSettingsDlg : public CDialog
{

// Construction
public:
	BSTR strfile;
	CComPtr<ISmpReceiptSettings>m_SmpReceiptSettings;
	CSMPReceptSettingsDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CSMPReceptSettingsDlg)
	enum { IDD = IDD_DIALOG_SMP_RECEIPT_SETTINGS };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSMPReceptSettingsDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSMPReceptSettingsDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnButtonPrintSalesReceipt();
	afx_msg void OnButtonBypassPrint();
	afx_msg void OnButtonEnDfltReceiptPrntr();
	afx_msg void OnButtonReceiptPrinterName();
	afx_msg void OnButtonPrintFooterTxt();
	afx_msg void OnButtonFooterTxt();
	afx_msg void OnButtonReceiptSpacing();
	afx_msg void OnButtonAlwysPrntFooterTime();
	afx_msg void OnButtonPrntReceiptCntsly();
	afx_msg void OnButtonFooterPhNo();
	afx_msg void OnButtonHeaderShpNme();
	afx_msg void OnButtonSetEscPosMode();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SMPRECEPTSETTINGSDLG_H__6FA06298_1894_4E2C_8CD3_02D4B551268C__INCLUDED_)
