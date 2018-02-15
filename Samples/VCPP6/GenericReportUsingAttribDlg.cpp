// GenericReportUsingAttribDlg.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "GenericReportUsingAttribDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CGenericReportUsingAttribDlg dialog


CGenericReportUsingAttribDlg::CGenericReportUsingAttribDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CGenericReportUsingAttribDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CGenericReportUsingAttribDlg)
	m_bHeaderBold = FALSE;
	m_bFooterItalic = FALSE;
	m_bFooterBold = FALSE;
	m_bBodyBold = FALSE;
	m_bBodyItalic = FALSE;
	m_bShowHeading = FALSE;
	//}}AFX_DATA_INIT
}


void CGenericReportUsingAttribDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CGenericReportUsingAttribDlg)
	DDX_Control(pDX, IDC_LIST_BODY_CONTENT, m_lstBodyContents);
	DDX_Control(pDX, IDC_EDIT_BODY_CONTENT_NAME, m_editBodyContentName);
	DDX_Control(pDX, IDC_EDIT_BODY_CONTENT, m_editBodyContent);
	DDX_Control(pDX, IDC_COMBO_HEADER_ALIGNMENT, m_cboHeaderAlignment);
	DDX_Control(pDX, IDC_COMBO_FOOTER_ALIGNMENT, m_cboFooterAlignment);
	DDX_Control(pDX, IDC_COMBO_BODY_ROW, m_cboBodyRow);
	DDX_Control(pDX, IDC_COMBO_BODY_MAX_ROW, m_cboBodyMaxRow);
	DDX_Control(pDX, IDC_COMBO_BODY_MAX_COL, m_cboBodyMaxcol);
	DDX_Control(pDX, IDC_COMBO_BODY_FONT_SIZE, m_cboBodyFontSize);
	DDX_Control(pDX, IDC_COMBO_BODY_COL, m_cboBodyCol);
	DDX_Control(pDX, IDC_COMBO_BODY_ALIGNMENT, m_cboBodyAlignment);
	DDX_Control(pDX, IDC_COMBO_HEADER_ROWS, m_cboHeaderRows);
	DDX_Control(pDX, IDC_COMBO_HEADER_MAX_ROWS, m_cboHeaderMaxRows);
	DDX_Control(pDX, IDC_COMBO_HEADER_MAX_COLUMNS, m_cboHeaderMaxCols);
	DDX_Control(pDX, IDC_COMBO_HEADER_FONT_SIZE, m_cboHeaderFontSize);
	DDX_Control(pDX, IDC_COMBO_HEADER_FONT_COLOR, m_cboHeaderFontColor);
	DDX_Control(pDX, IDC_COMBO_HEADER_FONT, m_cboHeaderFont);
	DDX_Control(pDX, IDC_COMBO_HEADER_COLUMNS, m_cboHeaderCols);
	DDX_Control(pDX, IDC_COMBO_FOOTER_ROWS, m_cboFooterRows);
	DDX_Control(pDX, IDC_COMBO_FOOTER_MAX_ROWS, m_cboFooterMaxRows);
	DDX_Control(pDX, IDC_COMBO_FOOTER_MAX_COLUMNS, m_cboFooterMaxCols);
	DDX_Control(pDX, IDC_COMBO_FOOTER_FONT_SIZE, m_cboFooterFontSize);
	DDX_Control(pDX, IDC_COMBO_FOOTER_FONT_COLOR, m_cboFooterFontColor);
	DDX_Control(pDX, IDC_COMBO_FOOTER_FONT, m_cboFooterFont);
	DDX_Control(pDX, IDC_COMBO_FOOTER_COLUMNS, m_cboFooterCols);
	DDX_Control(pDX, IDC_EDIT_FOOTER, m_editFooter);
	DDX_Control(pDX, IDC_EDIT_HEADING, m_editHeader);
	DDX_Check(pDX, IDC_CHECK_HEADER_BOLD, m_bHeaderBold);
	DDX_Check(pDX, IDC_CHECK_FOOTER_ITALIC, m_bFooterItalic);
	DDX_Check(pDX, IDC_CHECK_FOOTER_BOLD, m_bFooterBold);
	DDX_Check(pDX, IDC_CHECK_BODY_BOLD, m_bBodyBold);
	DDX_Check(pDX, IDC_CHECK_BODY_ITALIC, m_bBodyItalic);
	DDX_Check(pDX, IDC_CHECK_SHOWHEADING, m_bShowHeading);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CGenericReportUsingAttribDlg, CDialog)
	//{{AFX_MSG_MAP(CGenericReportUsingAttribDlg)
	ON_BN_CLICKED(IDC_BUTTON_ADD_BODY, OnButtonAddBody)
	ON_BN_CLICKED(IDC_BUTTON_REMOVE_BODY, OnButtonRemoveBody)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CGenericReportUsingAttribDlg message handlers

void CGenericReportUsingAttribDlg::OnOK() 
{
	try
	{
		USES_CONVERSION;

		UpdateData();

		GetAttributeValues();


		COLORREF BackColor = RGB(10,100,20);
		OLE_COLOR BackgroundColor = RGB(255,153,0);
	
		OLE_COLOR ForgroundColor_Red = RGB(255,0,0); //RED
		OLE_COLOR ForgroundColor_Green = RGB(35,115,50);//GREEN
		OLE_COLOR ForgroundColor_Blue = RGB(16,36,230);//BLUE

		CString strFooterFont = "Verdana";
		CString strHeadingFont = "Monotype Corsiva";
	
		
		CComPtr<IISmpGenericReport>m_SMPGenericReport; 

		HRESULT hr = m_SMPGenericReport.CoCreateInstance(CLSID_ISmpGenericReport);

		if(SUCCEEDED(hr))
		{

			CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Body;

			HRESULT hresult_Body = m_SMPReportItemAttributes_Body.CoCreateInstance(CLSID_SmpReportItemAttributes);

			CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Header;

			HRESULT hresult_Header = m_SMPReportItemAttributes_Header.CoCreateInstance(CLSID_SmpReportItemAttributes);

			CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Footer;

			HRESULT hresult_Footer = m_SMPReportItemAttributes_Footer.CoCreateInstance(CLSID_SmpReportItemAttributes);
			if(SUCCEEDED(hresult_Header) && SUCCEEDED(hresult_Footer) && SUCCEEDED(hresult_Body))
			{

				CComPtr<IItem>m_SMPHeaderItem;

				HRESULT HResult_Header = m_SMPHeaderItem.CoCreateInstance(CLSID_Item);

				CComPtr<IItem>m_SMPFooterItem;

				HRESULT HResult_Footer = m_SMPFooterItem.CoCreateInstance(CLSID_Item);
				if(SUCCEEDED(HResult_Header) && SUCCEEDED(HResult_Footer))
				{							
				
					m_SMPHeaderItem->put_Col(ConvertToInt(m_strHeaderCols));
					m_SMPHeaderItem->put_Content(m_strHeader.AllocSysString());
					m_SMPHeaderItem->put_ContentType(0);
					m_SMPHeaderItem->put_HAlign(ConvertToInt(m_strHeaderAlignment));
					m_SMPHeaderItem->put_MaxCol(ConvertToInt(m_strHeaderMaxCols));
					m_SMPHeaderItem->put_MaxRow(ConvertToInt(m_strHeaderMaxRows));
					m_SMPHeaderItem->put_Row(ConvertToInt(m_strHeaderRows));

					m_SMPFooterItem->put_Col(ConvertToInt(m_strFooterCols));
					m_SMPFooterItem->put_Content(m_strFooter.AllocSysString());
					m_SMPFooterItem->put_ContentType(0);
					m_SMPFooterItem->put_HAlign(ConvertToInt(m_strFooterAlignment));
					m_SMPFooterItem->put_MaxCol(ConvertToInt(m_strFooterMaxCols));
					m_SMPFooterItem->put_MaxRow(ConvertToInt(m_strFooterMaxRows));
					m_SMPFooterItem->put_Row(ConvertToInt(m_strFooterRows));
					
					//Header Properties
					if(m_strHeaderFontColor == _T("RED"))
						m_SMPReportItemAttributes_Header->put_ForgroundColor(ForgroundColor_Red);			
									
					else if(m_strHeaderFontColor == _T("GREEN"))
						m_SMPReportItemAttributes_Header->put_ForgroundColor(ForgroundColor_Green);						

					else
						m_SMPReportItemAttributes_Header->put_ForgroundColor(ForgroundColor_Blue);
					

					//m_SMPReportItemAttributes_Header->put_BackgroundColor(BackgroundColor);	
					m_SMPReportItemAttributes_Header->put_HeadingBold(m_bHeaderBold);
					m_SMPReportItemAttributes_Header->put_HeadingFont(m_strHeaderFont.AllocSysString());
					m_SMPReportItemAttributes_Header->put_HeadingFontSize(ConvertToInt(m_strHeaderFontSize));
					m_SMPReportItemAttributes_Header->put_ItemCount(5);
					m_SMPReportItemAttributes_Header->put_Item(0,m_SMPHeaderItem);

					//Body Properties
				    m_SMPReportItemAttributes_Body->put_NormalBold(m_bBodyBold);
					m_SMPReportItemAttributes_Body->put_NormalFontSize(ConvertToInt(m_strBodyFontSize));
					m_SMPReportItemAttributes_Body->put_NormalItalic(m_bBodyItalic);
					m_SMPReportItemAttributes_Body->put_ShowHeading(m_bShowHeading); 				


					//Footer Properties
					if(m_strFooterFontColor == _T("RED"))
						m_SMPReportItemAttributes_Footer->put_ForgroundColor(ForgroundColor_Red);				
					
					else if(m_strFooterFontColor == _T("GREEN"))
						m_SMPReportItemAttributes_Footer->put_ForgroundColor(ForgroundColor_Green);
				
					else
						m_SMPReportItemAttributes_Footer->put_ForgroundColor(ForgroundColor_Blue);
					
					m_SMPReportItemAttributes_Footer->put_FooterBold(1);
					m_SMPReportItemAttributes_Footer->put_FooterFont(m_strFooterFont.AllocSysString());
					m_SMPReportItemAttributes_Footer->put_FooterFontSize(ConvertToInt(m_strFooterFontSize));
					m_SMPReportItemAttributes_Footer->put_FooterItalic(1);
					m_SMPReportItemAttributes_Footer->put_ItemCount(5);
					m_SMPReportItemAttributes_Footer->put_Item(0,m_SMPFooterItem);					

					
					m_SMPGenericReport->put_BodyProperties(m_SMPReportItemAttributes_Body);					
				
					m_SMPGenericReport->put_HeaderProperties(m_SMPReportItemAttributes_Header);			

					m_SMPGenericReport->put_FooterProperties(m_SMPReportItemAttributes_Footer);

					//m_SMPGenericReport->put_GenericReportProperties(m_SMPReportItemAttributes_Body);
	

					for(int iCount=0;iCount<iBodyContentsListCount;iCount++)
					{

						CString strBodyContentName = m_strarrBodyContentName.GetAt(iCount);
						CString strBodyContent = m_strarrBodyContent.GetAt(iCount);
					
						m_SMPGenericReport->AddBodyContentsEx(ConvertToInt(m_strBodyRows),ConvertToInt(m_strBodyCols),strBodyContentName.AllocSysString(),DT_RIGHT,1);
						m_SMPGenericReport->AddBodyContentsEx(ConvertToInt(m_strBodyRows),ConvertToInt(m_strBodyCols)+1,strBodyContent.AllocSysString(),DT_RIGHT,1);

					}
					
				
					m_SMPGenericReport->FillReport();				

				}
			
			}	
		}
	}
	catch(...)
	{
		return; 
	}
	
	CDialog::OnOK();
}

void CGenericReportUsingAttribDlg::OnButtonAddBody() 
{
	
	
	UpdateData();

	FillBodyContents();

	UpdateData(FALSE);		

	m_lstBodyContents.InsertItem(0,m_strBodyRows);
	
	m_lstBodyContents.SetItemText(0,1,m_strBodyCols);

	m_lstBodyContents.SetItemText(0,2,m_strBodyMaxRows);		

	m_lstBodyContents.SetItemText(0,3,m_strBodyMaxCols);	

	m_lstBodyContents.SetItemText(0,4,m_strBodyContentName);	

	m_lstBodyContents.SetItemText(0,5,m_strBodyContent);	

	m_lstBodyContents.SetItemText(0,6,m_strBodyAlignment);

	m_lstBodyContents.SetItemText(0,7,m_strBodyFontSize);
	

	iBodyContentsListCount++;
	
}

void CGenericReportUsingAttribDlg::OnButtonRemoveBody() 
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

void CGenericReportUsingAttribDlg::GetAttributeValues()
{

	m_editFooter.GetWindowText(m_strFooter);

	m_editHeader.GetWindowText(m_strHeader);


	m_cboHeaderCols.GetWindowText(m_strHeaderCols);

	m_cboHeaderMaxCols.GetWindowText(m_strHeaderMaxCols);

	m_cboHeaderRows.GetWindowText(m_strHeaderRows);

	m_cboHeaderMaxRows.GetWindowText(m_strHeaderMaxRows);

	m_cboHeaderAlignment.GetWindowText(m_strHeaderAlignment);

	m_cboHeaderFontColor.GetWindowText(m_strHeaderFontColor);

	m_cboHeaderFont.GetWindowText(m_strHeaderFont);	

	m_cboHeaderFontSize .GetWindowText(m_strHeaderFontSize);
	

	m_cboFooterCols.GetWindowText(m_strFooterCols);	

	m_cboFooterMaxCols.GetWindowText(m_strFooterMaxCols);		

	m_cboFooterRows.GetWindowText(m_strFooterRows);	

	m_cboFooterMaxRows.GetWindowText(m_strFooterMaxRows);	

	m_cboFooterAlignment.GetWindowText(m_strFooterAlignment);	

	m_cboFooterFontColor.GetWindowText(m_strFooterFontColor);

	m_cboFooterFont.GetWindowText(m_strFooterFont);

	m_cboFooterFontSize .GetWindowText(m_strFooterFontSize);

}

int CGenericReportUsingAttribDlg::ConvertToInt(CString strValue)
{	
#ifdef _UNICODE

	 return _ttoi(strValue) ;
#else

	return (int) atoi(strValue);
#endif
}

BOOL CGenericReportUsingAttribDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	iBodyContentsListCount = 0;

	InitializeComboBoxes();

	InitializeBodyContents();
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CGenericReportUsingAttribDlg::InitializeComboBoxes()
{

	CString strNumber , strAlignment;

	for(int iCount=0;iCount<=50;iCount++)
	{
		strNumber.Format(_T("%d"),iCount);			

		m_cboBodyCol.InsertString(iCount,strNumber); 

		m_cboBodyMaxcol.InsertString(iCount,strNumber); 

		m_cboBodyRow.InsertString(iCount,strNumber); 

		m_cboBodyMaxRow.InsertString(iCount,strNumber); 

		m_cboBodyFontSize.InsertString(iCount,strNumber);


		m_cboHeaderCols.InsertString(iCount,strNumber); 

		m_cboHeaderMaxCols.InsertString(iCount,strNumber); 

		m_cboHeaderRows.InsertString(iCount,strNumber); 

		m_cboHeaderMaxRows.InsertString(iCount,strNumber); 

		m_cboHeaderFontSize.InsertString(iCount,strNumber); 


		m_cboFooterCols.InsertString(iCount,strNumber); 

		m_cboFooterMaxCols.InsertString(iCount,strNumber); 

		m_cboFooterRows.InsertString(iCount,strNumber); 

		m_cboFooterMaxRows.InsertString(iCount,strNumber); 

		m_cboFooterFontSize.InsertString(iCount,strNumber); 
	

	}

	for(int iAlignment=0 ; iAlignment<3;iAlignment++)
	{
		if(iAlignment == 0)
			strAlignment = _T("Center");

		else if(iAlignment == 1)
			strAlignment = _T("Left");

		else
			strAlignment = _T("Right");

		m_cboBodyAlignment.InsertString(iAlignment,strAlignment);
		m_cboHeaderAlignment.InsertString(iAlignment,strAlignment);
		m_cboFooterAlignment.InsertString(iAlignment,strAlignment);

	}

	m_cboHeaderFontColor.InsertString(0,_T("RED"));
	m_cboHeaderFontColor.InsertString(1,_T("GREEN"));
	m_cboHeaderFontColor.InsertString(2,_T("BLUE"));

	m_cboFooterFontColor.InsertString(0,_T("RED"));
	m_cboFooterFontColor.InsertString(1,_T("GREEN"));
	m_cboFooterFontColor.InsertString(2,_T("BLUE"));

	m_cboHeaderFont.InsertString(0,_T("Times New Roman"));
	m_cboHeaderFont.InsertString(0,_T("Comic Sans MS"));
	m_cboHeaderFont.InsertString(0,_T("Verdana"));
	m_cboHeaderFont.InsertString(0,_T("Book Antiqua"));
	m_cboHeaderFont.InsertString(0,_T("Impact"));

	m_cboFooterFont.InsertString(0,_T("Times New Roman"));
	m_cboFooterFont.InsertString(0,_T("Comic Sans MS"));
	m_cboFooterFont.InsertString(0,_T("Verdana"));
	m_cboFooterFont.InsertString(0,_T("Book Antiqua"));
	m_cboFooterFont.InsertString(0,_T("Impact"));
	
}

void CGenericReportUsingAttribDlg::InitializeBodyContents()
{

	m_lstBodyContents.SetExtendedStyle(m_lstBodyContents.GetExtendedStyle()| LVS_EX_FULLROWSELECT);

	m_lstBodyContents.InsertColumn(0,_T("Row"));

	m_lstBodyContents.InsertColumn(1,_T("Col"));

	m_lstBodyContents.InsertColumn(2,_T("MaxRow"));

	m_lstBodyContents.InsertColumn(3,_T("MaxCol"));

	m_lstBodyContents.InsertColumn(4,_T("Content Name"));

	m_lstBodyContents.InsertColumn(5,_T("Content"));

	m_lstBodyContents.InsertColumn(6,_T("Alignment"));

	m_lstBodyContents.InsertColumn(7,_T("Font size"));

	

	m_lstBodyContents.SetColumnWidth(0,50);
	m_lstBodyContents.SetColumnWidth(1,50);
	m_lstBodyContents.SetColumnWidth(2,50);
	m_lstBodyContents.SetColumnWidth(3,50);
	m_lstBodyContents.SetColumnWidth(4,50);
	m_lstBodyContents.SetColumnWidth(5,50);
	m_lstBodyContents.SetColumnWidth(6,50);
	m_lstBodyContents.SetColumnWidth(7,50);

}

void CGenericReportUsingAttribDlg::FillBodyContents()
{
	m_cboBodyCol.GetWindowText(m_strBodyCols);

	m_cboBodyMaxcol.GetWindowText(m_strBodyMaxCols);

	m_cboBodyRow.GetWindowText(m_strBodyRows);

	m_cboBodyMaxRow.GetWindowText(m_strBodyMaxRows);

	m_cboBodyAlignment.GetWindowText(m_strBodyAlignment);

	m_cboBodyFontSize.GetWindowText(m_strBodyFontSize);	

	m_editBodyContentName.GetWindowText(m_strBodyContentName);

	m_editBodyContent.GetWindowText(m_strBodyContent);


	m_strarrBodyContentName.Add(m_strBodyContentName);

	m_strarrBodyContent.Add(m_strBodyContent);

}
