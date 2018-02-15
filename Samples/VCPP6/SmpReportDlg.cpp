// SmpReportDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpReportDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpReportDlg dialog


CSmpReportDlg::CSmpReportDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpReportDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpReportDlg)
	//}}AFX_DATA_INIT
}


void CSmpReportDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpReportDlg)
	DDX_Control(pDX, IDC_COMBO_TABLELIST, m_ComboTableList);
	DDX_Control(pDX, IDC_EDIT2, m_EditItem2);
	DDX_Control(pDX, IDC_STATIC_ITEM5, m_LableItem5);
	DDX_Control(pDX, IDC_STATIC_ITEM4, m_LableItem4);
	DDX_Control(pDX, IDC_STATIC_ITEM3, m_LableItem3);
	DDX_Control(pDX, IDC_STATIC_ITEM2, m_LableItem2);
	DDX_Control(pDX, IDC_STATIC_ITEM1, m_LableItem1);
	DDX_Control(pDX, IDC_EDIT5, m_EditItem5);
	DDX_Control(pDX, IDC_EDIT4, m_EditItem4);
	DDX_Control(pDX, IDC_EDIT3, m_EditItem3);
	DDX_Control(pDX, IDC_EDIT1, m_EditItem1);
	DDX_Control(pDX, IDC_COMBO_ITEMS, m_ComboItems);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpReportDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpReportDlg)
	ON_BN_CLICKED(IDC_BUTTON_GENREPORT, OnButtonGenreport)
	ON_BN_CLICKED(IDC_BUTTON_PRINTREPORT, OnButtonPrintreport)
	ON_BN_CLICKED(IDC_BUTTON_RESETSTYLES, OnButtonResetstyles)
	ON_BN_CLICKED(IDC_BUTTON_SAVE, OnButtonSave)
	ON_CBN_SELCHANGE(IDC_COMBO_ITEMS, OnSelchangeComboItems)
	ON_BN_CLICKED(IDC_BUTTON_ADDTABLE, OnButtonAddtable)
	ON_BN_CLICKED(IDC_BUTTON_CANCEL, OnButtonCancel)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpReportDlg message handlers

void CSmpReportDlg::OnButtonGenreport() 
{
	// TODO: Add your control notification handler code here
    CString strSelectedItem;
	m_ComboTableList.GetWindowText(strSelectedItem);

	if(strSelectedItem=="")
	{
		AfxMessageBox(_T("Select a table from the list"));
		return;
	}
    
    m_strSQLQuery=_T("SELECT * FROM "+ strSelectedItem);
	m_bstrSQLQuery=m_strSQLQuery.AllocSysString();

    m_SmpReport->FillReport(m_bstrSQLQuery);

    m_ComboTableList.SetCurSel(0);
}

void CSmpReportDlg::OnButtonPrintreport() 
{
	// TODO: Add your control notification handler code here
   m_SmpReport->PrintReport();

   m_ComboTableList.SetCurSel(0);

}

void CSmpReportDlg::OnButtonResetstyles() 
{
	// TODO: Add your control notification handler code here
   m_SmpReport->ResetContent();

   ClearControls();
    
   m_ComboItems.SetCurSel(0);
   m_ComboTableList.SetCurSel(0);

   AfxMessageBox(_T("Successfully cleared the contents"));
}

void CSmpReportDlg::OnButtonSave() 
{

	// TODO: Add your control notification handler code here
	CString strSelectedItem;
	m_ComboItems.GetWindowText(strSelectedItem);

	if(strSelectedItem=="")
	{
		AfxMessageBox(_T("Select an item to edit"));
		return;
	}
	if(strSelectedItem=="Body Format")
	{
	    OnSaveBodyFormat();
		return;
	}
	if(strSelectedItem=="Footer Format")
	{
	    OnSaveFooterFormat();
		return;
	}
	if(strSelectedItem=="Footer Info")
	{
	    OnSaveFooterInfo();
		return;
	}
	if(strSelectedItem=="Header Format")
	{
	    OnSaveHeaderFormat();
		return;
	}
	if(strSelectedItem=="Header Info")
	{
	    OnSaveHeaderInfo();
		return;
	}
}

void CSmpReportDlg::OnSelectBodyFormat()
{

	m_LableItem1.SetWindowText(_T("Font"));
	m_LableItem2.SetWindowText(_T("Size"));
	m_LableItem3.SetWindowText(_T("Colour"));

	m_EditItem1.ShowWindow(SW_SHOW);
	m_EditItem2.ShowWindow(SW_SHOW);
	m_EditItem3.ShowWindow(SW_SHOW);

    m_SmpReport->GetBodyFormat(&m_bstrFont,&m_lSize,&m_lColour);

	m_strFont=m_bstrFont;
    m_strSize.Format(_T("%ld"),m_lSize);
	m_strColour.Format(_T("%ld"),m_lColour);

    m_EditItem1.SetWindowText(m_strFont);
	m_EditItem2.SetWindowText(m_strSize);
	m_EditItem3.SetWindowText(m_strColour);
}

void CSmpReportDlg::OnSelectFooterFormat()
{
   	m_LableItem1.SetWindowText(_T("Font"));
	m_LableItem2.SetWindowText(_T("Size"));
	m_LableItem3.SetWindowText(_T("Colour"));

	m_EditItem1.ShowWindow(SW_SHOW);
	m_EditItem2.ShowWindow(SW_SHOW);
	m_EditItem3.ShowWindow(SW_SHOW);

	m_SmpReport->GetFooterFormat(&m_bstrFont,&m_lSize,&m_lColour);

	m_strFont=m_bstrFont;
    m_strSize.Format(_T("%ld"),m_lSize);
	m_strColour.Format(_T("%ld"),m_lColour);

    m_EditItem1.SetWindowText(m_strFont);
	m_EditItem2.SetWindowText(m_strSize);
	m_EditItem3.SetWindowText(m_strColour);
}

void CSmpReportDlg::OnSelectFooterInfo()
{
    m_LableItem1.SetWindowText(_T("Footer1"));
	m_LableItem2.SetWindowText(_T("Footer2"));
	m_LableItem3.SetWindowText(_T("Footer3"));

	m_EditItem1.ShowWindow(SW_SHOW);
	m_EditItem2.ShowWindow(SW_SHOW);
	m_EditItem3.ShowWindow(SW_SHOW);

	m_SmpReport->GetFooterInfo(&m_bstrFooter1,&m_bstrFooter2,&m_bstrFooter3);

	m_strFooter1=m_bstrFooter1;
	m_strFooter2=m_bstrFooter2;
	m_strFooter3=m_bstrFooter3;

	m_EditItem1.SetWindowText(m_strFooter1);
	m_EditItem2.SetWindowText(m_strFooter2);
	m_EditItem3.SetWindowText(m_strFooter3);

}

void CSmpReportDlg::OnSelectHeaderFormat()
{
    m_LableItem1.SetWindowText(_T("Font"));
	m_LableItem2.SetWindowText(_T("Size"));
	m_LableItem3.SetWindowText(_T("Colour"));

	m_EditItem1.ShowWindow(SW_SHOW);
	m_EditItem2.ShowWindow(SW_SHOW);
	m_EditItem3.ShowWindow(SW_SHOW);

	m_SmpReport->GetHeaderFormat(&m_bstrFont,&m_lSize,&m_lColour);

	m_strFont=m_bstrFont;
    m_strSize.Format(_T("%ld"),m_lSize);
	m_strColour.Format(_T("%ld"),m_lColour);

    m_EditItem1.SetWindowText(m_strFont);
	m_EditItem2.SetWindowText(m_strSize);
	m_EditItem3.SetWindowText(m_strColour);
}

void CSmpReportDlg::OnSelectHeaderInfo()
{
    m_LableItem1.SetWindowText(_T("MainHeading1"));
	m_LableItem2.SetWindowText(_T("SubHeading1"));
	m_LableItem3.SetWindowText(_T("MainHeading2"));
	m_LableItem4.SetWindowText(_T("SubHeading2"));
	m_LableItem5.SetWindowText(_T("ImagePath"));

	m_EditItem1.ShowWindow(SW_SHOW);
	m_EditItem2.ShowWindow(SW_SHOW);
	m_EditItem3.ShowWindow(SW_SHOW);
	m_EditItem4.ShowWindow(SW_SHOW);
	m_EditItem5.ShowWindow(SW_SHOW);

	m_SmpReport->GetHeaderInfo(&m_bstrMainHeading1,&m_bstrSubHeading1,&m_bstrMainHeading2,&m_bstrSubHeading2,&m_bstrHeaderImagePath);

	m_strMainHeading1=m_bstrMainHeading1;
	m_strSubHeading1=m_bstrSubHeading1;
	m_strMainHeading2=m_bstrMainHeading2;
	m_strSubHeading2=m_bstrSubHeading2;
	m_strHeaderImagePath=m_bstrHeaderImagePath;

	m_EditItem1.SetWindowText(m_strMainHeading1);
	m_EditItem2.SetWindowText(m_strSubHeading1);
	m_EditItem3.SetWindowText(m_strMainHeading2);
	m_EditItem4.SetWindowText(m_strSubHeading2);
	m_EditItem5.SetWindowText(m_strHeaderImagePath);
}

void CSmpReportDlg::ClearControls()
{
    m_LableItem1.SetWindowText(_T(""));
	m_LableItem2.SetWindowText(_T(""));
	m_LableItem3.SetWindowText(_T(""));
	m_LableItem4.SetWindowText(_T(""));
	m_LableItem5.SetWindowText(_T(""));

	m_EditItem1.SetWindowText(_T(""));
	m_EditItem2.SetWindowText(_T(""));
	m_EditItem3.SetWindowText(_T(""));
	m_EditItem4.SetWindowText(_T(""));
	m_EditItem5.SetWindowText(_T(""));

	m_EditItem1.ShowWindow(SW_HIDE);
	m_EditItem2.ShowWindow(SW_HIDE);
	m_EditItem3.ShowWindow(SW_HIDE);
	m_EditItem4.ShowWindow(SW_HIDE);
	m_EditItem5.ShowWindow(SW_HIDE);
}

void CSmpReportDlg::OnSelchangeComboItems() 
{
	ClearControls();
	// TODO: Add your control notification handler code here
	CString strSelectedItem;
	m_ComboItems.GetWindowText(strSelectedItem);
	if(strSelectedItem=="")
	{
		AfxMessageBox(_T("Select an item to edit"));
		return;
	}
	if(strSelectedItem=="Body Format")
	{
	    OnSelectBodyFormat();
		return;
	}
	if(strSelectedItem=="Footer Format")
	{
	    OnSelectFooterFormat();
		return;
	}
	if(strSelectedItem=="Footer Info")
	{
	    OnSelectFooterInfo();
		return;
	}
	if(strSelectedItem=="Header Format")
	{
	    OnSelectHeaderFormat();
		return;
	}
	if(strSelectedItem=="Header Info")
	{
	    OnSelectHeaderInfo();
		return;
	}
}

BOOL CSmpReportDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr=m_SmpReport.CoCreateInstance(CLSID_SmpReport);

	if(FAILED(hr))
	{
		AfxMessageBox(_T("SMPReport Failed"));
		return FALSE;
	}
	// TODO: Add extra initialization here
	ClearControls();
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpReportDlg::OnSaveBodyFormat()
{
   
	m_EditItem1.GetWindowText(m_strFont);
	m_EditItem2.GetWindowText(m_strSize);
	m_EditItem3.GetWindowText(m_strColour);

	m_bstrFont=m_strFont.AllocSysString();
#ifdef UNICODE
		unsigned short  *stopstring1,*stopstring2;
		m_lSize = wcstol((m_strSize),&stopstring1,10);
		m_lColour = wcstol((m_strColour),&stopstring2,10);
#else
		m_lSize=atol((LPCTSTR)m_strSize);
		m_lColour=atol((LPCTSTR)m_strColour);
#endif
	//m_lSize=atol(m_strSize);
	//m_lColour=atol(m_strColour);

	m_SmpReport->SetBodyFormat(m_bstrFont,m_lSize,m_lColour);

	ClearControls();
    
	m_ComboItems.SetCurSel(0);
}

void CSmpReportDlg::OnSaveFooterFormat()
{

	m_EditItem1.GetWindowText(m_strFont);
	m_EditItem2.GetWindowText(m_strSize);
	m_EditItem3.GetWindowText(m_strColour);

	m_bstrFont=m_strFont.AllocSysString();
#ifdef UNICODE
		unsigned short  *stopstring1,*stopstring2;
		m_lSize = wcstol((m_strSize),&stopstring1,10);
		m_lColour = wcstol((m_strColour),&stopstring2,10);
#else
		m_lSize=atol((LPCTSTR)m_strSize);
		m_lColour=atol((LPCTSTR)m_strColour);
#endif
	//m_lSize=atol(m_strSize);
	//m_lColour=atol(m_strColour);

	m_SmpReport->SetFooterFormat(m_bstrFont,m_lSize,m_lColour);

	ClearControls();
    
	m_ComboItems.SetCurSel(0);
}

void CSmpReportDlg::OnSaveFooterInfo()
{
    m_EditItem1.GetWindowText(m_strFooter1);
	m_EditItem2.GetWindowText(m_strFooter2);
	m_EditItem3.GetWindowText(m_strFooter3);
    
	m_bstrFooter1=m_strFooter1.AllocSysString();
	m_bstrFooter2=m_strFooter2.AllocSysString();
	m_bstrFooter3=m_strFooter3.AllocSysString();

	m_SmpReport->SetFooterInfo(m_bstrFooter1,m_bstrFooter2,m_bstrFooter3);

	ClearControls();
    
	m_ComboItems.SetCurSel(0);
}

void CSmpReportDlg::OnSaveHeaderFormat()
{

	m_EditItem1.GetWindowText(m_strFont);
	m_EditItem2.GetWindowText(m_strSize);
	m_EditItem3.GetWindowText(m_strColour);

	m_bstrFont=m_strFont.AllocSysString();
#ifdef UNICODE
		unsigned short  *stopstring1,*stopstring2;
		m_lSize = wcstol((m_strSize),&stopstring1,10);
		m_lColour = wcstol((m_strColour),&stopstring2,10);
#else
		m_lSize=atol((LPCTSTR)m_strSize);
		m_lColour=atol((LPCTSTR)m_strColour);
#endif
	//m_lSize=atol(m_strSize);
	//m_lColour=atol(m_strColour);

	m_SmpReport->SetHeaderFormat(m_bstrFont,m_lSize,m_lColour);

	ClearControls();
    
	m_ComboItems.SetCurSel(0);
}

void CSmpReportDlg::OnSaveHeaderInfo()
{
	m_EditItem1.GetWindowText(m_strMainHeading1);
	m_EditItem2.GetWindowText(m_strSubHeading1);
	m_EditItem3.GetWindowText(m_strMainHeading2);
    m_EditItem4.GetWindowText(m_strSubHeading2);
	m_EditItem5.GetWindowText(m_strHeaderImagePath);

	m_bstrMainHeading1=m_strMainHeading1.AllocSysString();
	m_bstrSubHeading1=m_strSubHeading1.AllocSysString();
	m_bstrMainHeading2=m_strMainHeading2.AllocSysString();
	m_bstrSubHeading2=m_strSubHeading2.AllocSysString();
	m_bstrHeaderImagePath=m_strHeaderImagePath.AllocSysString();

	m_SmpReport->SetHeaderInfo(m_bstrMainHeading1,m_bstrSubHeading1,m_bstrMainHeading2,m_bstrSubHeading2,m_bstrHeaderImagePath);

    ClearControls();
    
	m_ComboItems.SetCurSel(0);

}

void CSmpReportDlg::OnButtonAddtable() 
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

void CSmpReportDlg::OnButtonCancel() 
{
	// TODO: Add your control notification handler code here
	ClearControls();
	
    m_ComboItems.SetCurSel(0);
}
