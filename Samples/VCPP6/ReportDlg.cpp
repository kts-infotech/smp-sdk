// ReportDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "ReportDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CReportDlg dialog


CReportDlg::CReportDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CReportDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CReportDlg)
	//}}AFX_DATA_INIT
}


void CReportDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CReportDlg)
	DDX_Control(pDX, IDC_COMBO_TABLELIST, m_ComboTableList);
	DDX_Control(pDX, IDC_CHECK_SHOWHEADER, m_CheckShowHeader);
	DDX_Control(pDX, IDC_CHECK_SHOWFOOTER, m_CheckShowFooter);
	DDX_Control(pDX, IDC_EDIT_HEADING, m_EditHeading);
	DDX_Control(pDX, IDC_EDIT_CAPTION, m_EditCaption);
	DDX_Control(pDX, IDC_EDIT_ADDHEADING, m_EditAddHeading);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CReportDlg, CDialog)
	//{{AFX_MSG_MAP(CReportDlg)
	ON_BN_CLICKED(IDC_RADIO_NORMAL, OnRadioNormal)
	ON_BN_CLICKED(IDC_RADIO_WITHADDINFO, OnRadioWithaddinfo)
	ON_BN_CLICKED(IDC_RADIO_WITHCAP, OnRadioWithcap)
	ON_BN_CLICKED(IDC_BUTTON_REPORT, OnButtonReport)
	ON_BN_CLICKED(IDC_BUTTON_ADDNEWTABLE, OnButtonAddnewtable)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CReportDlg message handlers

void CReportDlg::OnRadioNormal() 
{
	// TODO: Add your control notification handler code here
    EnableControlsOnAddInfo(FALSE);
	EnableControlsOnCaption(FALSE);
	ClearControls();
}

void CReportDlg::OnRadioWithaddinfo() 
{
	// TODO: Add your control notification handler code here
    EnableControlsOnAddInfo(TRUE);
	EnableControlsOnCaption(FALSE);
	ClearControls();
}

void CReportDlg::OnRadioWithcap() 
{
	// TODO: Add your control notification handler code here
	EnableControlsOnAddInfo(FALSE);
	EnableControlsOnCaption(TRUE);
	ClearControls();

}

void CReportDlg::OnButtonReport() 
{
    CString strInput;
    m_ComboTableList.GetWindowText(strInput);
	if(strInput=="")
	{
        AfxMessageBox(_T("Select a valid table name"));
		return;
	}

	// TODO: Add your control notification handler code here
	CComPtr<IReports>m_Reports;

	CString strHeading,strAdditionalHeading,strCaption;
	long bShowHeader,bShowFooter;
    BSTR bstrHeading,bstrAdditionalHeading,bstrSQLQuery;
	CString strSQLQuery=_T("SELECT * FROM "+strInput);
	VARIANT varSQLQuery;
	VARIANT varCaption;
    varSQLQuery.vt=VT_BSTR;
	varCaption.vt=VT_BSTR;
	varSQLQuery.bstrVal=strSQLQuery.AllocSysString();


	HRESULT hr = m_Reports.CoCreateInstance(CLSID_Reports);

	if(SUCCEEDED(hr))
	{
        if(((CButton*)GetDlgItem(IDC_RADIO_NORMAL))->GetCheck())
		{
            m_Reports->FillReport(varSQLQuery);
		}
		else if(((CButton*)GetDlgItem(IDC_RADIO_WITHADDINFO))->GetCheck())
		{
			if(CheckEnteredValuesOnAddInfo())
			{
				 m_EditHeading.GetWindowText(strHeading);
				 m_EditAddHeading.GetWindowText(strAdditionalHeading);
				 bstrHeading=strHeading.AllocSysString();
				 bstrAdditionalHeading=strAdditionalHeading.AllocSysString();
				 bShowHeader=((CButton*)GetDlgItem(IDC_CHECK_SHOWHEADER))->GetCheck();
                 bShowFooter=((CButton*)GetDlgItem(IDC_CHECK_SHOWFOOTER))->GetCheck();
				 bstrSQLQuery=strSQLQuery.AllocSysString();
				 m_Reports->FillReportEx(bstrSQLQuery,bstrHeading,bstrAdditionalHeading,bShowHeader,bShowFooter);
				 
			}
			             
		}
		else if(((CButton*)GetDlgItem(IDC_RADIO_WITHCAP))->GetCheck())
		{
			if(CheckEnteredValuesOnCap())
			{
				m_EditCaption.GetWindowText(strCaption);
				varCaption.bstrVal=strCaption.AllocSysString();
				m_Reports->FillReportWithCaption(varSQLQuery,varCaption);
			}
			
		}
	}
	
}

void CReportDlg::EnableControlsOnAddInfo(BOOL bStatus)
{
     m_EditAddHeading.EnableWindow(bStatus);
     m_EditHeading.EnableWindow(bStatus);

	 if(bStatus)
	 {
		m_CheckShowFooter.ShowWindow(SW_SHOW);
		m_CheckShowHeader.ShowWindow(SW_SHOW);
	 }
	 else
	 {
		m_CheckShowFooter.ShowWindow(SW_HIDE);
		m_CheckShowHeader.ShowWindow(SW_HIDE);
	 }

}

void CReportDlg::EnableControlsOnCaption(BOOL bStatus)
{
	m_EditCaption.EnableWindow(bStatus);

}

BOOL CReportDlg::CheckEnteredValuesOnAddInfo()
{
	CString strInput;
    m_EditHeading.GetWindowText(strInput);

	if(strInput=="")
	{
		AfxMessageBox(_T("Enter a valid heading"));
		return FALSE;
	}
    
	m_EditAddHeading.GetWindowText(strInput);

	if(strInput=="")
	{
		AfxMessageBox(_T("Enter a valid additional heading"));
		return FALSE;
	}

    return TRUE;
}

BOOL CReportDlg::CheckEnteredValuesOnCap()
{
	CString strInput;
    m_EditCaption.GetWindowText(strInput);

	if(strInput=="")
	{
		AfxMessageBox(_T("Enter a valid caption"));
		return FALSE;
	}


	return TRUE;
}

BOOL CReportDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	// TODO: Add extra initialization here
	DisableControlsOnLoad();
	ClearControls();
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CReportDlg::DisableControlsOnLoad()
{

	EnableControlsOnAddInfo(FALSE);
	EnableControlsOnCaption(FALSE);
    ((CButton*)GetDlgItem(IDC_RADIO_NORMAL))->SetCheck(BST_CHECKED);
}

void CReportDlg::ClearControls()
{

	m_EditAddHeading.SetWindowText(_T(""));
	m_EditHeading.SetWindowText(_T(""));
	m_EditCaption.SetWindowText(_T(""));
	((CButton*)GetDlgItem(IDC_CHECK_SHOWHEADER))->SetCheck(BST_UNCHECKED);
	((CButton*)GetDlgItem(IDC_CHECK_SHOWFOOTER))->SetCheck(BST_UNCHECKED);

}

void CReportDlg::OnButtonAddnewtable() 
{
	// TODO: Add your control notification handler code here
	CString strInput;
	m_ComboTableList.GetWindowText(strInput);

	if(strInput=="")
	{
	    AfxMessageBox(_T("Enter a valid table name"));
		return;
	}
	if(m_ComboTableList.FindString(0,strInput)==-1)
	{
		m_ComboTableList.AddString(strInput);
	}
}
