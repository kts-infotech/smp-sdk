// IItemDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "IItemDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CIItemDlg dialog


CIItemDlg::CIItemDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CIItemDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CIItemDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CIItemDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CIItemDlg)
	DDX_Control(pDX, IDC_STATIC_PUT_ITEM, m_StaticPutItem);
	DDX_Control(pDX, IDC_STATIC_GET_ITEM_OUTPUT, m_StaticGetItemOutput);
	DDX_Control(pDX, IDC_EDIT_PUT_ITEM, m_EditPutItem);
	DDX_Control(pDX, IDC_EDIT_GET_ITEM_OUTPUT, m_EditGetItemOutput);
	DDX_Control(pDX, IDC_COMBO_SELECT_PUT_ITEM, m_CboSelectPutItem);
	DDX_Control(pDX, IDC_COMBO_SELECT_GET_ITEM, m_CboSelectGetItem);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CIItemDlg, CDialog)
	//{{AFX_MSG_MAP(CIItemDlg)
	ON_BN_CLICKED(IDC_BUTTON_PUT, OnButtonPut)
	ON_BN_CLICKED(IDC_BUTTON_GET, OnButtonGet)
	ON_CBN_SELCHANGE(IDC_COMBO_SELECT_GET_ITEM, OnSelchangeComboSelectGetItem)
	ON_CBN_SELCHANGE(IDC_COMBO_SELECT_PUT_ITEM, OnSelchangeComboSelectPutItem)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CIItemDlg message handlers

BOOL CIItemDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	HRESULT hr;
	/*hr=m_IItem.CoCreateInstance(CLSID_Item);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("IItem Interface initialisation failed"));
		return FALSE;
	}*/
	/*hr=m_SmpReportItemAttributes.CoCreateInstance(CLSID_SmpReportItemAttributes);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("ISmpReportItemAttributes Interface initialisation failed"));
		return FALSE;
	}*/
	hr=m_IISmpGenericReport.CoCreateInstance(CLSID_ISmpGenericReport);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("ISmpGenericReport Interface initialisation failed"));
		return FALSE;
	}
	m_CboSelectGetItem.SetCurSel(0);
	m_CboSelectPutItem.SetCurSel(0);

	m_StaticGetItemOutput.SetWindowText(_T("HAlign Value"));
	m_StaticPutItem.SetWindowText(_T("HAlign Value"));

	CreateSampleReport();

	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CIItemDlg::OnButtonPut() 
{

	PerformPutOperation();

}

void CIItemDlg::OnButtonGet() 
{
	PerformGetOperation();	
}

void CIItemDlg::OnSelchangeComboSelectGetItem() 
{
	// TODO: Add your control notification handler code here
	CString strSelText;
	int iSelIndex=-1;

	iSelIndex=m_CboSelectGetItem.GetCurSel();

	switch(iSelIndex)
	{
		case 0:
				   m_StaticGetItemOutput.SetWindowText(_T("HAlign Value:"));
				   break;
		case 1:
				   m_StaticGetItemOutput.SetWindowText(_T("Row Value:"));
					break;
		case 2:
				   m_StaticGetItemOutput.SetWindowText(_T("Col Value:"));
					break;
		case 3:
				   m_StaticGetItemOutput.SetWindowText(_T("Max Rows:"));
					break;
		case 4:
				   m_StaticGetItemOutput.SetWindowText(_T("Max Cols:"));
					break;
		case 5:
				   m_StaticGetItemOutput.SetWindowText(_T("Content Val:"));
					break;
		case 6:
				   m_StaticGetItemOutput.SetWindowText(_T("Content Type:"));
					break;
		case -1:
					AfxMessageBox(_T("Please select an action from list"));
	}	
	
}

void CIItemDlg::OnSelchangeComboSelectPutItem() 
{
	CString strSelText;
	int iSelIndex=-1;

	iSelIndex=m_CboSelectPutItem.GetCurSel();

	switch(iSelIndex)
	{
		case 0:
				   m_StaticPutItem.SetWindowText(_T("HAlign Value:"));
				   break;
		case 1:
				   m_StaticPutItem.SetWindowText(_T("Row Value:"));
					break;
		case 2:
				   m_StaticPutItem.SetWindowText(_T("Col Value:"));
					break;
		case 3:
				   m_StaticPutItem.SetWindowText(_T("Max Rows:"));
					break;
		case 4:
				   m_StaticPutItem.SetWindowText(_T("Max Cols:"));
					break;
		case 5:
				   m_StaticPutItem.SetWindowText(_T("Content Val:"));
					break;
		case 6:
				   m_StaticPutItem.SetWindowText(_T("Content Type:"));
					break;
		case -1:
					AfxMessageBox(_T("Please select an action from list"));
	}	
}

void CIItemDlg::PerformPutOperation()
{
	CString strSelText;
	int iSelIndex=-1;
	long lVal;
	iSelIndex=m_CboSelectPutItem.GetCurSel();
	if(iSelIndex>=0)
	{
		m_EditPutItem.GetWindowText(strSelText);
		if(strSelText.GetLength()<=0)
		{
			AfxMessageBox(_T("Please enter value to set"));
			return;
		}
	}
	else
	{
		AfxMessageBox(_T("Please select an action from list"));
		return;
	}
	if(iSelIndex!=5)
	{
#ifdef UNICODE
				unsigned short  *stopstring;
				lVal = wcstol((strSelText),&stopstring,10);
#else
				lVal=atol((LPCTSTR)strSelText);
#endif
	}
	CComPtr<IItem> item;
	HRESULT hr=item.CoCreateInstance(CLSID_Item);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create IITem object"));
		return;
	}
	m_IISmpGenericReport->get_BodyItem(1,&item.p);
	switch(iSelIndex)
	{
		case 0:
					//HAlign value
				   item->put_HAlign(lVal);
				   break;
		case 1:
					//row value
					item->put_Row(lVal);
					break;
		case 2:
				   //"Col Value:"
					item->put_Col(lVal);
					break;
		case 3:
				   //"Max Rows:"
					item->put_MaxRow(lVal);
					break;
		case 4:
				   //"Max Cols:"
					item->put_MaxCol(lVal);
					break;
		case 5:
				   //"Content Value:"
				   item->put_Content(strSelText.AllocSysString());
					break;
		case 6:
				   //"Content Type:"
					item->put_ContentType(lVal);
					break;
		case -1:
					AfxMessageBox(_T("Please select an action from list"));
					return;
	}
	
	CComPtr<ISmpReportItemAttributes>m_SmpReportItemAttributes;
	HRESULT hr1=m_SmpReportItemAttributes.CoCreateInstance(CLSID_SmpReportItemAttributes);
	if(FAILED(hr1))
	{
		AfxMessageBox(_T("ISmpReportItemAttributes Interface initialisation failed"));
		return;
	}

	m_IISmpGenericReport->get_BodyProperties(&m_SmpReportItemAttributes.p);
	m_SmpReportItemAttributes->put_Item(1,item.p);
	m_IISmpGenericReport->put_BodyProperties(m_SmpReportItemAttributes);
	m_IISmpGenericReport->FillReport();
	//VARIANT Var;
	//Var.byref=m_IISmpGenericReport;
	//m_IISmpGenericReport->SetGenericReportObj(Var);
	AfxMessageBox(_T("Successfully Put the value"));
}

void CIItemDlg::CreateSampleReport()
{
	CString  strHeading=_T("Test Heading");
	m_IISmpGenericReport->AddReportHeadingEx(1,3,strHeading.AllocSysString(),DT_CENTER,0);

	CString  strBody=_T("Body12");
	m_IISmpGenericReport->AddBodyContentsEx(1,2,strBody.AllocSysString(),DT_CENTER,1);

	strBody=__T("Body13");
	m_IISmpGenericReport->AddBodyContentsEx(1,3,strBody.AllocSysString(),DT_CENTER,1);

	strBody=_T("Body14");
	m_IISmpGenericReport->AddBodyContentsEx(1,4,strBody.AllocSysString(),DT_CENTER,1);

	strBody=_T("Body22");
	m_IISmpGenericReport->AddBodyContentsEx(2,2,strBody.AllocSysString(),DT_CENTER,1);

	strBody=_T("Body23");
	m_IISmpGenericReport->AddBodyContentsEx(2,3,strBody.AllocSysString(),DT_CENTER,1);

	strBody=_T("Body24");
	m_IISmpGenericReport->AddBodyContentsEx(2,4,strBody.AllocSysString(),DT_CENTER,1);

	strBody=_T("Footer");
	m_IISmpGenericReport->AddFooterContentsEx(2,3,strBody.AllocSysString(),DT_CENTER,0);

	m_IISmpGenericReport->FillReport();
}
/*void CIItemDlg::CreateSampleReport()
{

	COLORREF BackColor = RGB(10,100,20);
	OLE_COLOR BackgroundColor = RGB(255,153,0);

	OLE_COLOR ForgroundColor_Red = RGB(255,0,0); //RED
	OLE_COLOR ForgroundColor_Green = RGB(35,115,50);//GREEN
	OLE_COLOR ForgroundColor_Blue = RGB(16,36,230);//BLUE

	CString strFooterFont = "Verdana";
	CString strHeadingFont = "Monotype Corsiva";

	CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Body;

	HRESULT hresult_Body = m_SMPReportItemAttributes_Body.CoCreateInstance(CLSID_SmpReportItemAttributes);

	CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Header;

	HRESULT hresult_Header = m_SMPReportItemAttributes_Header.CoCreateInstance(CLSID_SmpReportItemAttributes);

	CComPtr<ISmpReportItemAttributes>m_SMPReportItemAttributes_Footer;

	HRESULT hresult_Footer = m_SMPReportItemAttributes_Footer.CoCreateInstance(CLSID_SmpReportItemAttributes);
	if(SUCCEEDED(hresult_Header) && SUCCEEDED(hresult_Footer) && SUCCEEDED(hresult_Body))
	{
		CComPtr<IItem>m_SMPHeaderItem;
		CString strFooter,strHeader;
		strFooter=_T("Footer");
		strHeader=_T("Header");

		HRESULT HResult_Header = m_SMPHeaderItem.CoCreateInstance(CLSID_Item);

		CComPtr<IItem>m_SMPFooterItem;

		HRESULT HResult_Footer = m_SMPFooterItem.CoCreateInstance(CLSID_Item);
		if(SUCCEEDED(HResult_Header) && SUCCEEDED(HResult_Footer))
		{
			CString strHeader=_T("HEADER");
			m_SMPHeaderItem->put_Col(4);
			m_SMPHeaderItem->put_Content(strHeader.AllocSysString());
			m_SMPHeaderItem->put_ContentType(0);
			m_SMPHeaderItem->put_HAlign(2);
			m_SMPHeaderItem->put_MaxCol(4);
			m_SMPHeaderItem->put_MaxRow(4);
			m_SMPHeaderItem->put_Row(4);

			CString strFooter=_T("FOOTER");
			m_SMPFooterItem->put_Col(4);
			m_SMPFooterItem->put_Content(strFooter.AllocSysString());
			m_SMPFooterItem->put_ContentType(0);
			m_SMPFooterItem->put_HAlign(2);
			m_SMPFooterItem->put_MaxCol(4);
			m_SMPFooterItem->put_MaxRow(4);
			m_SMPFooterItem->put_Row(4);
			
			//Header Properties
			m_SMPReportItemAttributes_Header->put_ForgroundColor(ForgroundColor_Red);			
								
			m_SMPReportItemAttributes_Header->put_HeadingBold(1);
			m_SMPReportItemAttributes_Header->put_HeadingFont(strHeadingFont.AllocSysString());
			m_SMPReportItemAttributes_Header->put_HeadingFontSize(10);
			m_SMPReportItemAttributes_Header->put_ItemCount(5);
			m_SMPReportItemAttributes_Header->put_Item(0,m_SMPHeaderItem);

			//Body Properties
			m_SMPReportItemAttributes_Body->put_NormalBold(1);
			m_SMPReportItemAttributes_Body->put_NormalFontSize(10);
			m_SMPReportItemAttributes_Body->put_NormalItalic(0);
			m_SMPReportItemAttributes_Body->put_ShowHeading(0); 				


			//Footer Properties
			m_SMPReportItemAttributes_Footer->put_ForgroundColor(ForgroundColor_Red);				
			
			m_SMPReportItemAttributes_Footer->put_FooterBold(1);
			m_SMPReportItemAttributes_Footer->put_FooterFont(strFooterFont.AllocSysString());
			m_SMPReportItemAttributes_Footer->put_FooterFontSize(10);
			m_SMPReportItemAttributes_Footer->put_FooterItalic(0);
			m_SMPReportItemAttributes_Footer->put_ItemCount(5);
			m_SMPReportItemAttributes_Footer->put_Item(0,m_SMPFooterItem);

			
			m_IISmpGenericReport->put_BodyProperties(m_SMPReportItemAttributes_Body);					
		
			m_IISmpGenericReport->put_HeaderProperties(m_SMPReportItemAttributes_Header);			

			m_IISmpGenericReport->put_FooterProperties(m_SMPReportItemAttributes_Footer);

			//m_SMPGenericReport->put_GenericReportProperties(m_SMPReportItemAttributes_Body);


			/*for(int iCount=0;iCount<4;iCount++)
			{

				CString strBodyContentName = _T("TEST");
				CString strBodyContent = _T("TEST1");
				int iBodyRows=iCount;
				int iBodyCols=iCount+4;
			
				m_IISmpGenericReport->AddBodyContentsEx(iBodyRows,iBodyCols,strBodyContentName.AllocSysString(),DT_RIGHT,1);
				m_IISmpGenericReport->AddBodyContentsEx(iBodyRows,iBodyCols+1,strBodyContent.AllocSysString(),DT_RIGHT,1);

			}*/
/*			CString  strBody=_T("Body12");
			m_IISmpGenericReport->AddBodyContentsEx(1,2,strBody.AllocSysString(),DT_CENTER,1);

			strBody=__T("Body13");
			m_IISmpGenericReport->AddBodyContentsEx(1,3,strBody.AllocSysString(),DT_CENTER,1);

			strBody=_T("Body14");
			m_IISmpGenericReport->AddBodyContentsEx(1,4,strBody.AllocSysString(),DT_CENTER,1);

			strBody=_T("Body22");
			m_IISmpGenericReport->AddBodyContentsEx(2,2,strBody.AllocSysString(),DT_CENTER,1);

			strBody=_T("Body23");
			m_IISmpGenericReport->AddBodyContentsEx(2,3,strBody.AllocSysString(),DT_CENTER,1);

			strBody=_T("Body24");
			m_IISmpGenericReport->AddBodyContentsEx(2,4,strBody.AllocSysString(),DT_CENTER,1);

			m_IISmpGenericReport->FillReport();

		}
	}
}*/

void CIItemDlg::PerformGetOperation()
{
#if 1
	CString strSelText;
	int iSelIndex=-1;
	long lVal;
	iSelIndex=m_CboSelectGetItem.GetCurSel();
	if(iSelIndex<0)
	{
		AfxMessageBox(_T("Please select an action from list"));
		return;
	}
	CComPtr<IItem> item;
	HRESULT hr=item.CoCreateInstance(CLSID_Item);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create IITem object"));
		return;
	}
	
	CComPtr<ISmpReportItemAttributes>m_SmpReportItemAttributes;
	HRESULT hr1=m_SmpReportItemAttributes.CoCreateInstance(CLSID_SmpReportItemAttributes);
	if(FAILED(hr1))
	{
		AfxMessageBox(_T("ISmpReportItemAttributes Interface initialisation failed"));
		return;
	}
	//m_IISmpGenericReport->get_BodyProperties(&m_SmpReportItemAttributes.p);
	//m_IISmpGenericReport->get_
	//m_SmpReportItemAttributes->get_Item(1,&item.p);
	///m_IISmpGenericReport->get_BodyItem(1,&item.p);
	m_IISmpGenericReport->get_BodyProperties(&m_SmpReportItemAttributes.p);
	long lVal1;
	m_SmpReportItemAttributes->get_ItemCount(&lVal1);
	for(int iIndex=0;iIndex<lVal1;iIndex++)
	{
		//m_SmpReportItemAttributes->get_Item(iIndex,&item.p);
		m_IISmpGenericReport->get_BodyItem(iIndex,&item.p);
		CString strVal;
		BSTR bstrContent;
		CString strCont;
		switch(iSelIndex)
		{
			case 0:
					   //HAlign value
					   item->get_HAlign(&lVal);
					   strVal.Format(_T("%ld"),lVal);
					   AfxMessageBox(strVal);
					   break;
			case 1:
						//row value
						item->get_Row(&lVal);
						strVal.Format(_T("%ld"),lVal);
						AfxMessageBox(strVal);
						break;
			case 2:
					   //"Col Value:"
						item->get_Col(&lVal);
						strVal.Format(_T("%ld"),lVal);
						AfxMessageBox(strVal);
						break;
			case 3:
					   //"Max Rows:"
						item->get_MaxRow(&lVal);
						strVal.Format(_T("%ld"),lVal);
						AfxMessageBox(strVal);
						break;
			case 4:
					   //"Max Cols:"
						item->get_MaxCol(&lVal);
						strVal.Format(_T("%ld"),lVal);
						AfxMessageBox(strVal);
						break;
			case 5:
					   //"Content Value:"
						item->get_Content(&bstrContent);
						strCont=(CString)bstrContent;
						AfxMessageBox(strCont);
						
						break;
			case 6:
					   //"Content Type:"
						item->get_ContentType(&lVal);
						strVal.Format(_T("%ld"),lVal);
						AfxMessageBox(strVal);
						break;
			case -1:
						AfxMessageBox(_T("Please select an action from list"));
						break;
		}	
		if(iSelIndex==5)
		{
			m_EditGetItemOutput.SetWindowText(strCont);
		}
		else
		{
			m_EditGetItemOutput.SetWindowText(strVal);
		}
	}
#else
	CComPtr<IItem> item;
	HRESULT hr=item.CoCreateInstance(CLSID_Item);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to create IITem object"));
		return;
	}
	m_IISmpGenericReport->get_BodyItem(1,&item.p);
	long lbdyCnt;
	m_IISmpGenericReport->get_BodyCellArrayCount(&lbdyCnt);
	for(long lIndx=0;lIndx<lbdyCnt;lIndx++)
	{
		m_IISmpGenericReport->get_BodyItem(lIndx,&item.p);
		BSTR strContent;
		item->get_Content(&strContent);
		AfxMessageBox(CString(strContent));
	}
#endif
}
