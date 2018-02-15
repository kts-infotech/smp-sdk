// GenericReportDirectMehodDlg.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "GenericReportDirectMehodDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CGenericReportDirectMehodDlg dialog


CGenericReportDirectMehodDlg::CGenericReportDirectMehodDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CGenericReportDirectMehodDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CGenericReportDirectMehodDlg)
	//}}AFX_DATA_INIT
}


void CGenericReportDirectMehodDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CGenericReportDirectMehodDlg)
	DDX_Control(pDX, IDC_COMBO_BODY_MAX_COL, m_cboBodyMaxCol);
	DDX_Control(pDX, IDC_EDIT_BODY_CONTENT_NAME, m_editBodyContentName);
	DDX_Control(pDX, IDC_EDIT_BODY_CONTENT, m_editBodyContent);
	DDX_Control(pDX, IDC_COMBO_HEADER_ROW, m_cboHeaderRow);
	DDX_Control(pDX, IDC_COMBO_HEADER_MAX_ROW, m_cboHeaderMaxRow);
	DDX_Control(pDX, IDC_COMBO_HEADER_MAX_COL, m_cboHeaderMaxCol);
	DDX_Control(pDX, IDC_COMBO_HEADER_COL, m_cboHeaderCol);
	DDX_Control(pDX, IDC_COMBO_HEADER_ALIGNMENT, m_cboHeaderAlignment);
	DDX_Control(pDX, IDC_COMBO_FOOTER_ROW, m_cboFooterRow);
	DDX_Control(pDX, IDC_COMBO_FOOTER_MAX_ROW, m_cboFooterMaxRow);
	DDX_Control(pDX, IDC_COMBO_FOOTER_MAX_COL, m_cboFooterMaxCol);
	DDX_Control(pDX, IDC_COMBO_FOOTER_COL, m_cboFooterCol);
	DDX_Control(pDX, IDC_COMBO_FOOTER_ALIGNMENT, m_cboFooterAlignment);
	DDX_Control(pDX, IDC_COMBO_BODY_ROW, m_cboBodyRow);
	DDX_Control(pDX, IDC_COMBO_BODY_MAX_ROW, m_cboBodyMaxRow);
	DDX_Control(pDX, IDC_COMBO_BODY_COL, m_cboBodyCol);
	DDX_Control(pDX, IDC_COMBO_BODY_ALIGNMENT, m_cboBodyAlignment);
	DDX_Control(pDX, IDC_EDIT_HEADING, m_editHeader);
	DDX_Control(pDX, IDC_EDIT_FOOTER, m_editFooter);
	DDX_Control(pDX, IDC_LIST_BODY_CONTENT, m_lstBodyContents);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CGenericReportDirectMehodDlg, CDialog)
	//{{AFX_MSG_MAP(CGenericReportDirectMehodDlg)
	ON_BN_CLICKED(IDC_BUTTON_ADD_BODY, OnButtonAddBody)
	ON_BN_CLICKED(IDC_BUTTON_REMOVE_BODY, OnButtonRemoveBody)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CGenericReportDirectMehodDlg message handlers

void CGenericReportDirectMehodDlg::OnOK() 
{
	try
	{
		UpdateData();

		GetAttributeValues();

		CComPtr<IISmpGenericReport>m_SMPGenericReport; 

		HRESULT hr = m_SMPGenericReport.CoCreateInstance(CLSID_ISmpGenericReport);

		if(SUCCEEDED(hr))
		{
		
			m_SMPGenericReport->AddReportHeading(ConvertToInt(m_strHeaderRow),ConvertToInt(m_strHeaderCol),ConvertToInt(m_strHeaderMaxRow),ConvertToInt(m_strHeaderMaxCol),m_strHeader.AllocSysString(),DT_CENTER,0);
				
			for(int iCount=0;iCount<iBodyContentsListCount;iCount++)
			{

				CString strBodyContentName = m_strarrBodyContentName.GetAt(iCount);
				CString strBodyContent = m_strarrBodyContent.GetAt(iCount);
			
				m_SMPGenericReport->AddBodyContentsEx(ConvertToInt(m_strBodyRow),ConvertToInt(m_strBodyCol),strBodyContentName.AllocSysString(),DT_RIGHT,1);
				m_SMPGenericReport->AddBodyContentsEx(ConvertToInt(m_strBodyRow),ConvertToInt(m_strBodyCol)+1,strBodyContent.AllocSysString(),DT_RIGHT,1);

			}

			m_SMPGenericReport->AddFooterContents(ConvertToInt(m_strFooterRow),ConvertToInt(m_strFooterCol),ConvertToInt(m_strFooterMaxRow),ConvertToInt(m_strFooterMaxCol),m_strFooter.AllocSysString(),DT_CENTER,0);

			m_SMPGenericReport->FillReport();
		}

		
	}
	catch(...)
	{
	
	}
	CDialog::OnOK();
}

void CGenericReportDirectMehodDlg::OnButtonAddBody() 
{

	
	UpdateData();

	FillBodyContents();	

	m_lstBodyContents.InsertItem(0,m_strBodyRow);
	
	m_lstBodyContents.SetItemText(0,1,m_strBodyCol);

	m_lstBodyContents.SetItemText(0,2,m_strBodyMaxRow);		

	m_lstBodyContents.SetItemText(0,3,m_strBodyMaxCol);	

	m_lstBodyContents.SetItemText(0,4,m_strBodyContentName);	

	m_lstBodyContents.SetItemText(0,5,m_strBodyContent);	

	m_lstBodyContents.SetItemText(0,6,m_strBodyAlignment);	

	iBodyContentsListCount++;

	
}

void CGenericReportDirectMehodDlg::OnButtonRemoveBody() 
{

	POSITION pos = m_lstBodyContents.GetFirstSelectedItemPosition();

	while (pos == NULL)
	{
		m_lstBodyContents.DeleteItem(iBodyContentsListCount);
	}

	while (pos != NULL)
	{

		int nItem = m_lstBodyContents.GetNextSelectedItem(pos);

		m_lstBodyContents.DeleteItem(nItem);

		pos = m_lstBodyContents.GetFirstSelectedItemPosition();
	} 
	iBodyContentsListCount--;

	
}

BOOL CGenericReportDirectMehodDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();

	iBodyContentsListCount = 0;

	InitializeComboBoxes();

	InitializeBodyContents();	
	
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}
                   
void CGenericReportDirectMehodDlg::GetAttributeValues()
{
	
	m_editFooter.GetWindowText(m_strFooter);

	m_editHeader.GetWindowText(m_strHeader);


	m_cboHeaderCol.GetWindowText(m_strHeaderCol);

	m_cboHeaderMaxCol.GetWindowText(m_strHeaderMaxCol);

	m_cboHeaderRow.GetWindowText(m_strHeaderRow);

	m_cboHeaderMaxRow.GetWindowText(m_strHeaderMaxRow);

	m_cboHeaderAlignment.GetWindowText(m_strHeaderAlignment);


	m_cboFooterCol.GetWindowText(m_strFooterCol);	

	m_cboFooterMaxCol.GetWindowText(m_strFooterMaxCol);		

	m_cboFooterRow.GetWindowText(m_strFooterRow);	

	m_cboFooterMaxRow.GetWindowText(m_strFooterMaxRow);	

	m_cboFooterAlignment.GetWindowText(m_strFooterAlignment);	


}

void CGenericReportDirectMehodDlg::InitializeComboBoxes()
{
	CString strNumber , strAlignment;

	for(int iCount=0;iCount<=50;iCount++)
	{
		strNumber.Format(_T("%d"),iCount);		

		m_cboBodyCol.InsertString(iCount,strNumber); 

		m_cboBodyMaxCol.InsertString(iCount,strNumber); 

		m_cboBodyRow.InsertString(iCount,strNumber); 

		m_cboBodyMaxRow.InsertString(iCount,strNumber); 

		m_cboHeaderCol.InsertString(iCount,strNumber); 

		m_cboHeaderMaxCol.InsertString(iCount,strNumber); 

		m_cboHeaderRow.InsertString(iCount,strNumber); 

		m_cboHeaderMaxRow.InsertString(iCount,strNumber); 

		m_cboFooterCol.InsertString(iCount,strNumber); 

		m_cboFooterMaxCol.InsertString(iCount,strNumber); 

		m_cboFooterRow.InsertString(iCount,strNumber); 

		m_cboFooterMaxRow.InsertString(iCount,strNumber); 

	}

	for(int iAlignment=0 ; iAlignment<3;iAlignment++)
	{
		if(iAlignment == 0)
			strAlignment = _T("Center");

		else if(iAlignment == 0)
			strAlignment = _T("Left");

		else
			strAlignment = _T("Right");

		m_cboBodyAlignment.InsertString(iAlignment,strAlignment);
		m_cboHeaderAlignment.InsertString(iAlignment,strAlignment);
		m_cboFooterAlignment.InsertString(iAlignment,strAlignment);

	}

}

void CGenericReportDirectMehodDlg::InitializeBodyContents()
{

	m_lstBodyContents.SetExtendedStyle(m_lstBodyContents.GetExtendedStyle()| LVS_EX_FULLROWSELECT);

	m_lstBodyContents.InsertColumn(0,_T("Row"));

	m_lstBodyContents.InsertColumn(1,_T("Col"));

	m_lstBodyContents.InsertColumn(2,_T("MaxRow"));

	m_lstBodyContents.InsertColumn(3,_T("MaxCol"));

	m_lstBodyContents.InsertColumn(4,_T("Content Name"));

	m_lstBodyContents.InsertColumn(5,_T("Content"));

	m_lstBodyContents.InsertColumn(6,_T("Alignment"));

	m_lstBodyContents.SetColumnWidth(0,50);
	m_lstBodyContents.SetColumnWidth(1,50);
	m_lstBodyContents.SetColumnWidth(2,50);
	m_lstBodyContents.SetColumnWidth(3,50);
	m_lstBodyContents.SetColumnWidth(4,50);
	m_lstBodyContents.SetColumnWidth(5,50);
	m_lstBodyContents.SetColumnWidth(6,50);

}

void CGenericReportDirectMehodDlg::FillBodyContents()
{
	m_cboBodyCol.GetWindowText(m_strBodyCol);

	m_cboBodyMaxCol.GetWindowText(m_strBodyMaxCol);

	m_cboBodyRow.GetWindowText(m_strBodyRow);

	m_cboBodyMaxRow.GetWindowText(m_strBodyMaxRow);

	m_cboBodyAlignment.GetWindowText(m_strBodyAlignment);

	m_editBodyContentName.GetWindowText(m_strBodyContentName);

	m_editBodyContent.GetWindowText(m_strBodyContent);


	m_strarrBodyContentName.Add(m_strBodyContentName);

	m_strarrBodyContent.Add(m_strBodyContent);

}
int CGenericReportDirectMehodDlg::ConvertToInt(CString strValue)
{	
#ifdef _UNICODE

	 return _ttoi(strValue) ;
#else

	return (int) atoi(strValue);
#endif
}
