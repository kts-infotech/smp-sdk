// SmpGridControlDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpGridControlDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpGridControlDlg dialog


CSmpGridControlDlg::CSmpGridControlDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpGridControlDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpGridControlDlg)
	//}}AFX_DATA_INIT
}


void CSmpGridControlDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpGridControlDlg)
	DDX_Control(pDX, IDC_EDIT_SET_DEFAULT_ROW_HEIGHT, m_strdefaultRowHeight);
	DDX_Control(pDX, IDC_EDIT_DEFAULT_COLUMN_WIDTH, m_strDefaultColumnWidth);
	DDX_Control(pDX, IDC_COMBO_SET_TEXT_WRAP_COLUMN, m_cboCellTextWrapColumn);
	DDX_Control(pDX, IDC_COMBO_SET_TEXT_WRAP_ROW, m_cboCellTextWrapRow);
	DDX_Control(pDX, IDC_COMBO_SET_CELL_TEXT_ALIGNMENT_COLUMN, m_cboSetCellTextAlignmentColumn);
	DDX_Control(pDX, IDC_COMBO_SET_CELL_TEXT_ALIGNMENT_ROW, m_cboCellTextAlignmentRow);
	DDX_Control(pDX, IDC_EDIT_CELL_TEXT, m_strCellText);
	DDX_Control(pDX, IDC_COMBO_SET_CELL_TEXT_ROW, m_cboCellTextRow);
	DDX_Control(pDX, IDC_COMBO_SET_CELL_TEXT_COLUMN, m_cboCellTextColumn);
	DDX_Control(pDX, IDC_COMBO_CELL_IMAGE_EX_ROW, m_cboCellImageExSelectRow);
	DDX_Control(pDX, IDC_COMBO_CELL_IMAGE_EX_COLUMN, m_cboCellImageExSelectColumn);
	DDX_Control(pDX, IDC_COMBO_CELL_IMAGE_COLUMN, m_cboCellImageSelectColumn);
	DDX_Control(pDX, IDC_COMBO_CELL_IMAGE_ROW, m_cboCellImageSelectRow);
	DDX_Control(pDX, IDC_COMBO_SELECT_COLUMN, m_cboSelectColumn);
	DDX_Control(pDX, IDC_COMBO_SELECT_ROW, m_cboSelectRow);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpGridControlDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpGridControlDlg)
	ON_BN_CLICKED(IDC_BUTTON_AUTOSIZE, OnButtonAutosize)
	ON_BN_CLICKED(IDC_BUTTON_BUSINESS_LOGO, OnButtonBusinessLogo)
	ON_BN_CLICKED(IDC_BUTTON_DELETE_ALLIMAGES, OnButtonDeleteAllimages)
	ON_BN_CLICKED(IDC_BUTTON_DELETE_ALL_ITEMS, OnButtonDeleteAllItems)
	ON_BN_CLICKED(IDC_BUTTON_REFRESH_CONTROL, OnButtonRefreshControl)
	ON_BN_CLICKED(IDC_BUTTON_SET_CELL_IMAGE, OnButtonSetCellImage)
	ON_BN_CLICKED(IDC_BUTTON_BROWSE_IMAGE, OnButtonBrowseImage)
	ON_BN_CLICKED(IDC_BUTTON_CREATE_BASIC_REPORT, OnButtonCreateBasicReport)
	ON_BN_CLICKED(IDC_BUTTON_CREATE_DETAIL_REPORT, OnButtonCreateDetailReport)
	ON_BN_CLICKED(IDC_BUTTON_SET_CELL_IMAGE_RESOURCE, OnButtonSetCellImageResource)
	ON_BN_CLICKED(IDC_BUTTON_SET_CELL_TEXT, OnButtonSetCellText)
	ON_BN_CLICKED(IDC_BUTTON_SET_ALIGNMENT, OnButtonSetAlignment)
	ON_BN_CLICKED(IDC_BUTTON_SET_CELL_TEXT_WRAP, OnButtonSetCellTextWrap)
	ON_BN_CLICKED(IDC_BUTTON_SET_DEFAULT_COLUMN_WIDTH, OnButtonSetDefaultColumnWidth)
	ON_BN_CLICKED(IDC_BUTTON_SET_DEFAULT_ROW_HEIGHT, OnButtonSetDefaultRowHeight)
	ON_BN_CLICKED(IDC_BUTTON_SET_GRID_DISPLAY_READ_ONLY, OnButtonSetGridDisplayReadOnly)
	ON_BN_CLICKED(IDC_BUTTON_SET_WORD_WRAP_MODE, OnButtonSetWordWrapMode)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpGridControlDlg message handlers

BOOL CSmpGridControlDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
		InitializeComboBxes();
	

	// TODO: Add extra initialization here
			
		HRESULT hr=S_OK;

	hr =SmpGrid.CoCreateInstance(CLSID_Grid);
	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("SmpGrid is Not Implemented on the Installed Version of SalesMate + . Please use the Latest Version of SalesMate + Application"));
		return FALSE;
	}

	hr =SmpGridCtrl.CoCreateInstance(CLSID_SmpGridCtrl);
	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("SmpGridCtrl is Not Implemented on the Installed Version of SalesMate + . Please use the Latest Version of SalesMate + Application"));
		return FALSE;
	}
		hr =SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);

	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("SmpPluginTab is Not Implemented on the Installed Version of SalesMate + . Please use the Latest Version of SalesMate + Application"));
		return FALSE;
	}
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpGridControlDlg::OnButtonAutosize() 
{
	// TODO: Add your control notification handler code here

	HRESULT hr=S_OK;
	
		InitializeGrid();

	

	//First delete all items
//	SmpGridCtrl->DeleteAllItems();
	SmpGrid->put_HorizondalGridLine(3L);
	
	int HeaderRows=17;
	int ContentRows=10;
	int FooterRows=20;

	int iHeaderRowIndex=0;

	int TotalRows=HeaderRows+ContentRows+FooterRows;

	int MaxNoOfCoumns=15;

	float fHandlingCharges,fSalesDiscAmount,fGrantTotal;
	
	CString strHandlingCharges,strSalesDiscAmount,strGrantTotal;
	CString strShopName,strShopAddress,strShopCity,strShopPhone,strShopGSTIN,strCustomerId,strCustomerGSTIN="",strCustomerName,strCustomerAddress;
	CString strShopBankAccountNo,strShopBankIFSC;
	
	BOOL bUseLogo=TRUE;

	SmpGrid->put_NoOfRows(HeaderRows+ContentRows+FooterRows);

	SmpGrid->put_NoOfColumns(MaxNoOfCoumns);
	
	//Put the folumn width
	for(int i=0;i<MaxNoOfCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,60);
	}

	strShopName=_T("KTS INFOTECH");
	strShopAddress=_T("Pala");
	strShopCity=_T("Kottayam");
	strShopPhone=_T("123456789");
	strShopGSTIN=_T("32GST1233HF");
	strShopBankAccountNo=_T("570123456789");
	strShopBankIFSC=_T("SBIN000000");


	CString SQL,SQLTRAN,strPayType,strBillType,strSalesDate,strConsumerState;
	float fGrUnitprice=0,fGrQuantity=0,fGrGrossValue=0,fGrCashDisc=0,fGrTaxAmount=0,fGrTotal=0;
	float fNetAmtWithoutTax=0,fTotalSGST=0,fTotalCGST=0,fTotalIGST=0,fTotalGST=0,fTotalCess=0;
	CString SQLSTATE,strSelectQuery,strSelectStateQuery,strShopStateName,strShopStateID,strShopStateTin;
	CComVariant ComVariant;

 




	

	
		strSalesDate=_T("10/05/2017");
	

		COleDateTime dtOtherTimestamp;
		dtOtherTimestamp.ParseDateTime(strSalesDate);
		strSalesDate = dtOtherTimestamp.Format(_T("%d %B %Y"));


		strCustomerId=_T("Gopu");

	
		fHandlingCharges=10;
	    strHandlingCharges.Format(_T("%0.2f"),fHandlingCharges);


		fSalesDiscAmount=10;
		

		
	
		strPayType=_T("Cash");


		fGrantTotal=1000.00;
					
	
		strGrantTotal.Format(_T("%0.2f"),fGrantTotal);

	
			strConsumerState=_T("Kerala");
			
	


	strShopStateTin=_T("123456");
	strShopStateID=_T("32");
	strShopStateName=_T("Kerala");

	//Get shipping datails
	CString strReverseCharge="No",strTransMode="",strVehicleNo="";

	CString strSupplyStateTin,strSupplyStateID,strSupplyStateName,strConsumerLocation;

	strSupplyStateTin=_T("12345");
	strSupplyStateID=_T("32");
	strSupplyStateName=_T("Kerala");


	//Get customer details
	
	CString strFirstName,strLastName;

		strFirstName = _T("KTS");
	
	
		strLastName = _T("Infotech");
		

		strCustomerAddress = _T("Pala");


	
	strCustomerName=strFirstName+_T(" ")+strLastName;

	//Get Customer GSTIN

	CString SQLCUSTGSTIN;


	//Put all report data Read Only
	SmpGridCtrl->SetGridDisplayReadOnly(TRUE);


		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,40);
		SmpGrid->put_RowHeight(iHeaderRowIndex,44);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopName),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;

	
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,27);
	SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopAddress+_T(", ")+strShopCity+_T(", Mobile: ")+strShopPhone),DT_CENTER|DT_WORDBREAK);
	iHeaderRowIndex++;
	

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,21);
		
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(_T("Header Text")),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;


	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,27);
	SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("GSTIN : 32fghb2544"),DT_CENTER|DT_WORDBREAK);
	iHeaderRowIndex++;

	//Now Merge header Rows/cells
	if(bUseLogo) //Check for Logo
	{

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,1);
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,11);
		SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex+1,MaxNoOfCoumns-1);

		//Put The logo
		SmpGridCtrl->SetBusinessLogo(iHeaderRowIndex,0,150,45);
		SmpGrid->put_RowHeight(iHeaderRowIndex,27);
		//Set the Invoice Text
		SmpGrid->put_CellFontSize(iHeaderRowIndex,2,38);
		SmpGrid->put_CellTextColour(iHeaderRowIndex,2,RGB(0,0,255));
		SmpGridCtrl->SetCellText(iHeaderRowIndex,2,CComBSTR(strBillType),DT_CENTER|DT_WORDBREAK);
		SmpGrid->put_CellText(iHeaderRowIndex,13,CComBSTR(_T("Duplicate")));
		SmpGrid->put_CellFontSize(iHeaderRowIndex,12,25);
		SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("")));

	}
	else
	{
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,12);
		SmpGrid->MergeCells(iHeaderRowIndex,13,iHeaderRowIndex+1,MaxNoOfCoumns-1);

		//Put Some Value
		SmpGrid->put_CellFontSize(0,0,40);
		SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Tax Invoice")));
		
		SmpGrid->put_CellFontSize(iHeaderRowIndex,12,25);
		SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("")));
	
	}
	iHeaderRowIndex+=2;
	//Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);
	iHeaderRowIndex++;
	//End Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Reverse Charge : "+strReverseCharge)));
SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Invoice No : 10 ")));

		SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
		SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Invoice Date : "+strSalesDate)));
	


	SmpGrid->MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	SmpGrid->put_CellText(iHeaderRowIndex,9,CComBSTR(_T("State : "+strShopStateName)));
	
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("State Code : "+strShopStateID)));
	iHeaderRowIndex++;

	/////////////////////////////////////////////////

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Transporation Mode : ash")));
	SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
	SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Vehicle No : "+strVehicleNo)));
	SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
	SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Date Of Supply : "+strSalesDate)));

	SmpGrid->MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	SmpGrid->put_CellText(iHeaderRowIndex,9,CComBSTR(_T("Place Of supply : "+strSupplyStateName)));
	
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("State Code : "+strSupplyStateID)));
	iHeaderRowIndex++;
	///
	//Gao
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);
	iHeaderRowIndex++;
	/////////////////////////////
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,25);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Details Of The Receiver | Billed To")));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,8,25);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Details Of The Consignee | Shipped To")));
	iHeaderRowIndex++;
	

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Name        : "+strCustomerName)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Name        : "+strCustomerName)));
	iHeaderRowIndex++;

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Address    : "+strCustomerAddress)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Address    : "+strCustomerAddress)));
	iHeaderRowIndex++;

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,2);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("GSTIN : "+strCustomerGSTIN)));

	SmpGrid->MergeCells(iHeaderRowIndex,3,iHeaderRowIndex,4);
	SmpGrid->put_CellText(iHeaderRowIndex,3,CComBSTR(_T("State : "+strSupplyStateName)));
	SmpGrid->MergeCells(iHeaderRowIndex,5,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,5,CComBSTR(_T("State Code : "+strSupplyStateID)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,10);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("GSTIN : "+strCustomerGSTIN)));

	SmpGrid->MergeCells(iHeaderRowIndex,11,iHeaderRowIndex,12);
	SmpGrid->put_CellText(iHeaderRowIndex,11,CComBSTR(_T("State : "+strSupplyStateName)));
	SmpGrid->MergeCells(iHeaderRowIndex,13,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,13,CComBSTR(_T("State Code : "+strSupplyStateID)));
	iHeaderRowIndex++;

	CString strIncludeHSN=_T("False");
	static const TCHAR szSection[]	= _T("SMPOSSCREEN");
	static const TCHAR szKeyIH[]	= _T("IncludeHSN");
	strIncludeHSN = AfxGetApp()->GetProfileString(szSection, szKeyIH, strIncludeHSN);

	bool bHSNCodeAvailable = false;
	
		bHSNCodeAvailable=true;

	//Now demarcate the next area
	//GAP
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,10);
	SmpGrid->put_CellColour(iHeaderRowIndex,0,(long)RGB(0,0,0));
	iHeaderRowIndex++;
	//End GAP
	//Now set the Item Headers
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,0);
	SmpGrid->put_ColumnWidth(0,45);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Sr.No.")));
	
	SmpGrid->MergeCells(iHeaderRowIndex,1,iHeaderRowIndex+1,1);
	SmpGrid->put_ColumnWidth(1,150);
	SmpGrid->put_CellText(iHeaderRowIndex,1,CComBSTR(_T("Name of Product / Service")));

	if(bHSNCodeAvailable)
	{
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("HSN")));
	}
	else
	{
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Item ID")));
	}
	


	SmpGrid->MergeCells(iHeaderRowIndex,3,iHeaderRowIndex+1,3);
	SmpGrid->put_ColumnWidth(3,40);
	SmpGrid->put_CellText(iHeaderRowIndex,3,CComBSTR(_T("Qty")));

	SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex+1,4);
	SmpGrid->put_ColumnWidth(4,70);
	SmpGrid->put_CellText(iHeaderRowIndex,4,CComBSTR(_T("Rate")));

	SmpGrid->MergeCells(iHeaderRowIndex,5,iHeaderRowIndex+1,5);
	SmpGrid->put_ColumnWidth(5,75);
	SmpGrid->put_CellText(iHeaderRowIndex,5,CComBSTR(_T("Amount")));
	
	SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex+1,6);
	SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Discount")));

	SmpGrid->MergeCells(iHeaderRowIndex,7,iHeaderRowIndex+1,7);
	SmpGrid->put_ColumnWidth(7,80);
	SmpGrid->put_CellText(iHeaderRowIndex,7,CComBSTR(_T("Taxable Value")));
	//CGST
	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,9);
	SmpGridCtrl->SetCellTextAlignment(14,8,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("SGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,8,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,9,CComBSTR(_T("Amount")));

	///SGST
	SmpGrid->MergeCells(iHeaderRowIndex,10,iHeaderRowIndex,11);
	SmpGridCtrl->SetCellTextAlignment(iHeaderRowIndex,10,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,10,CComBSTR(_T("CGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,10,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,11,CComBSTR(_T("Amount")));

	//IGST
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,13);
	SmpGridCtrl->SetCellTextAlignment(iHeaderRowIndex,12,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("IGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,12,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,13,CComBSTR(_T("Amount")));

	//Total
	SmpGrid->MergeCells(iHeaderRowIndex,14,iHeaderRowIndex+1,14);
	SmpGrid->put_ColumnWidth(14,85);
	SmpGrid->put_CellText(iHeaderRowIndex,14,CComBSTR(_T("Total")));
	iHeaderRowIndex+=2;
	//Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);


	try
 	{
		

	

		CString strTinText,strCstText,strCitydet,strVATHeading,strFormTxt;
	

		
		
		CString strLargestItemName=_T("");

		CString strLargestItemID=_T("");
		float fCessAmt=0;

		
		CString strGrUnitprice,strGrQuantity,strGrGrossValue,strGrCashDisc,strGrTaxAmount,strGrTotal,strSalesDate;

	

		int iTempRow,iTempCol;
		int iTranCount;
		float fTrDiscAmt=0,fItemDiscount=0;
		CString strRecCount,strTranCount,strItemId,strHSNCode,strName,strTrTaxRate;
		CString strTrUnitPrice,strTrQty,strGrValue,strTrDiscAmt,strTrCatName;
		CString strTrCatId,strTrNetAmt,strTrTaxAmt,strTotalPrice,strItemDiscount;

		int iFooterStartIndex=0;
		iTempRow=HeaderRows+1;
		iTranCount=0;
		iTempCol=0;
		float fCessStateTotalTaxAmt = 0.0;
		float fCessIGSTTotalTaxAmt = 0.0;
		CString strSgstTaxId,strCgstTaxId,strIgstTaxId;
	

	

					{
			

				
				//	SmpGrid->put_RowHeight(1,25);
            SmpGridCtrl->SetCellText(20,0,CComBSTR(_T("1")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
			SmpGridCtrl->SetCellText(20,1,CComBSTR(_T("Salemate +")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
			SmpGridCtrl->SetCellText(20,2,CComBSTR(_T("1234")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
					SmpGridCtrl->SetCellText(20,3,CComBSTR(_T("2")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);

				//	SmpGrid->put_RowHeight(1,25);
					SmpGridCtrl->SetCellText(20,4,CComBSTR(_T("2500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

				//	SmpGrid->put_RowHeight(1,25);
					SmpGridCtrl->SetCellText(20,5,CComBSTR(_T("5000")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

				//	SmpGrid->put_RowHeight(1,25);
					SmpGridCtrl->SetCellText(20,6,CComBSTR(_T("500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					SmpGridCtrl->SetCellText(20,7,CComBSTR(_T("4500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
						SmpGridCtrl->SetCellText(20,8,CComBSTR(_T("9")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,9,CComBSTR(_T("405")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,10,CComBSTR(_T("9")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,11,CComBSTR(_T("405")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,14,CComBSTR(_T("5310")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					//SmpGrid->put_RowHeight(20,25);
					SmpGridCtrl->SetCellText(1,7,CComBSTR(_T("23")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
 
                    SmpGridCtrl->SetCellText(2,3,_T("2"),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);

					//SmpGrid->put_RowHeight(iTempRow,25);
					SmpGridCtrl->SetCellText(2,4,_T("25"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

					//SmpGrid->put_RowHeight(iTempRow,25);
					SmpGridCtrl->SetCellText(2,5,_T("25"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

					//SmpGrid->put_RowHeight(iTempRow,25);
					SmpGridCtrl->SetCellText(2,6,_T("2"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

					//SmpGrid->put_RowHeight(iTempRow,25);
					SmpGridCtrl->SetCellText(2,7,_T("23"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					//Calculate SGST,CGST,IGST rate and amount

					CString strTaxPercentage,strTaxAmount,strTaxCategoryId,strCessId,strCessTransId;
					//CString strSgstTaxId,strCgstTaxId,strIgstTaxId;

					float fCessIGST=0,fCessState=0;
			
					iFooterStartIndex=25;
		SmpGrid->MergeCells(iFooterStartIndex,0,iFooterStartIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iFooterStartIndex,1);
		
		iFooterStartIndex=iFooterStartIndex+1;
		SmpGrid->MergeCells(iFooterStartIndex,0,iFooterStartIndex,8);
		SmpGrid->put_CellText(iFooterStartIndex,0,CComBSTR(_T("Total Invoice Amount in Words:")));
		
		CString strDigiWords;
	//	strDigiWords=GetApp()->ConvertDigitToWord(strGrantTotal);

		SmpGrid->MergeCells(iFooterStartIndex+1,0,iFooterStartIndex+6,8);
		SmpGrid->put_CellFontSize(iFooterStartIndex+1,0,30);
		SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR("Five Thousand Only"),DT_WORDBREAK);

		//Now the Amount Section
		SmpGrid->MergeCells(iFooterStartIndex,9,iFooterStartIndex,12);
		SmpGrid->put_CellText(iFooterStartIndex,9,CComBSTR(_T("Total Amount Before Tax")));
		SmpGrid->MergeCells(iFooterStartIndex,13,iFooterStartIndex,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex,13,CComBSTR("4500"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//CGST
		SmpGrid->MergeCells(iFooterStartIndex+1,9,iFooterStartIndex+1,12);
		SmpGrid->put_CellText(iFooterStartIndex+1,9,CComBSTR(_T("Add : CGST")));
		SmpGrid->MergeCells(iFooterStartIndex+1,13,iFooterStartIndex+1,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+1,13,CComBSTR("405"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		//SGST
		SmpGrid->MergeCells(iFooterStartIndex+2,9,iFooterStartIndex+2,12);
		SmpGrid->put_CellText(iFooterStartIndex+2,9,CComBSTR(_T("Add : SGST")));
		SmpGrid->MergeCells(iFooterStartIndex+2,13,iFooterStartIndex+2,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+2,13,CComBSTR("405"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		//IGST
		SmpGrid->MergeCells(iFooterStartIndex+3,9,iFooterStartIndex+3,12);
		SmpGrid->put_CellText(iFooterStartIndex+3,9,CComBSTR(_T("Add : IGST")));
		SmpGrid->MergeCells(iFooterStartIndex+3,13,iFooterStartIndex+3,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+3,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		
		//CESS amount GST
		SmpGrid->MergeCells(iFooterStartIndex+4,9,iFooterStartIndex+4,12);
		SmpGrid->put_CellText(iFooterStartIndex+4,9,CComBSTR(_T("CESS (+)")));
		SmpGrid->MergeCells(iFooterStartIndex+4,13,iFooterStartIndex+4,14);
		
		SmpGridCtrl->SetCellText(iFooterStartIndex+4,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Discount amount 
		SmpGrid->MergeCells(iFooterStartIndex+5,9,iFooterStartIndex+5,12);
		SmpGrid->put_CellText(iFooterStartIndex+5,9,CComBSTR(_T("Handling/Transportation  Charges (+) ")));
		SmpGrid->MergeCells(iFooterStartIndex+5,13,iFooterStartIndex+5,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+5,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Handling/Transportation  Charges:
	//	strSalesDiscAmount.Format(_T("%0.2f"),fTotalDiskAmt);
		SmpGrid->MergeCells(iFooterStartIndex+6,9,iFooterStartIndex+6,12);
		SmpGrid->put_CellText(iFooterStartIndex+6,9,CComBSTR(_T("Total Discount (-) ")));
		SmpGrid->MergeCells(iFooterStartIndex+6,13,iFooterStartIndex+6,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+6,13,CComBSTR("1000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Total Tax Amount after Tax
		SmpGrid->MergeCells(iFooterStartIndex+7,9,iFooterStartIndex+7,12);
		SmpGrid->put_CellFontSize(iFooterStartIndex+7,9,25);
		SmpGrid->put_CellFontSize(iFooterStartIndex+7,13,25);
		SmpGrid->put_RowHeight(iFooterStartIndex+7,30);
		SmpGrid->put_CellText(iFooterStartIndex+7,9,CComBSTR(_T("Grant Total")));
		SmpGrid->MergeCells(iFooterStartIndex+7,13,iFooterStartIndex+7,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("10620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Last Footer Area
		
		CString strDisplayBankInfo,strDeclaration;
		
	

		//Payment Type
		SmpGrid->MergeCells(iFooterStartIndex+7,0,iFooterStartIndex+7,2);
		SmpGrid->put_CellText(iFooterStartIndex+7,0,CComBSTR(_T("Payment Type")));
		SmpGrid->MergeCells(iFooterStartIndex+7,3,iFooterStartIndex+7,6);
		SmpGrid->put_CellText(iFooterStartIndex+7,3,CComBSTR("Cash"));
		
	
			//Add Bank details
			SmpGrid->MergeCells(iFooterStartIndex+8,0,iFooterStartIndex+8,6);
			SmpGrid->put_CellText(iFooterStartIndex+8,0,CComBSTR(_T("Bank details")));
			//Bank Account Number
			SmpGrid->MergeCells(iFooterStartIndex+9,0,iFooterStartIndex+9,2);
			SmpGrid->put_CellText(iFooterStartIndex+9,0,CComBSTR(_T("Bank Account Number")));
			SmpGrid->MergeCells(iFooterStartIndex+9,3,iFooterStartIndex+9,6);
			SmpGrid->put_CellText(iFooterStartIndex+9,3,CComBSTR("67012548223"));
			//Bank Branch IfSC
			SmpGrid->MergeCells(iFooterStartIndex+10,0,iFooterStartIndex+10,2);
			SmpGrid->put_CellText(iFooterStartIndex+10,0,CComBSTR(_T("Bank Branch IFSC")));
			SmpGrid->MergeCells(iFooterStartIndex+10,3,iFooterStartIndex+10,6);
			SmpGrid->put_CellText(iFooterStartIndex+10,3,CComBSTR("SBIN0700001"));
			//Terms and Conditions
		
			SmpGrid->MergeCells(iFooterStartIndex+11,0,iFooterStartIndex+14,6);
			SmpGridCtrl->SetCellText(iFooterStartIndex+11,0,CComBSTR(_T("Terms and Conditions:\n     ")+strDeclaration),DT_TOP|DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
		
			//Gap
	

		//Office Seal
		SmpGrid->MergeCells(iFooterStartIndex+7,7,iFooterStartIndex+14,8);	
		SmpGrid->put_CellText(iFooterStartIndex+7,7,CComBSTR(_T("Office Seal")));
		
			//Reverse Charge
			SmpGrid->MergeCells(iFooterStartIndex+8,9,iFooterStartIndex+8,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+8,9,CComBSTR(_T("GST Payable On Reverse Charge ")));
			SmpGrid->MergeCells(iFooterStartIndex+8,13,iFooterStartIndex+8,MaxNoOfCoumns-1);
			if(strReverseCharge==_T("Yes"))
			{
				fGrantTotal=fGrantTotal-fTotalGST-fTotalCess;
				strGrantTotal.Format(_T("%0.2f"),fGrantTotal);

				SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR(strDigiWords),DT_WORDBREAK);

				SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("9000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
				SmpGridCtrl->SetCellText(iFooterStartIndex+8,13,CComBSTR("1620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
			}
			else
			{
				SmpGrid->put_CellText(iFooterStartIndex+8,13,CComBSTR(_T("N/A")));
			}
			//Certified
			SmpGrid->MergeCells(iFooterStartIndex+9,9,iFooterStartIndex+9,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+9,9,CComBSTR(_T("Certified that the particulars given above are true and correct.")));
			
			SmpGrid->MergeCells(iFooterStartIndex+10,9,iFooterStartIndex+10,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+10,9,CComBSTR(_T("For, ")+strShopName));
			
			SmpGrid->MergeCells(iFooterStartIndex+11,9,iFooterStartIndex+13,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+11,9,CComBSTR(_T("Authorized Signatory :")));

			//Display Operator Name
		
			SmpGrid->MergeCells(iFooterStartIndex+14,9,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+14,9,CComBSTR(_T("Operator Name ")));
			SmpGrid->MergeCells(iFooterStartIndex+14,13,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+14,13,CComBSTR("KTS InfoTech"));
	
			//Break
			SmpGrid->MergeCells(iFooterStartIndex+8,9,iFooterStartIndex+8,MaxNoOfCoumns-1);

			//Reverse Charge
			SmpGrid->MergeCells(iFooterStartIndex+9,9,iFooterStartIndex+9,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+9,9,CComBSTR(_T("GST Payable On Reverse Charge ")));
			SmpGrid->MergeCells(iFooterStartIndex+9,13,iFooterStartIndex+9,MaxNoOfCoumns-1);
			if(strReverseCharge==_T("Yes"))
			{
				fGrantTotal=fGrantTotal-fTotalGST-fTotalCess;
				strGrantTotal.Format(_T("%0.2f"),fGrantTotal);
				SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR("Five THousand"),DT_WORDBREAK);

				SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("9000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
				SmpGridCtrl->SetCellText(iFooterStartIndex+9,13,CComBSTR("1620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
			}
			else
			{
				SmpGrid->put_CellText(iFooterStartIndex+9,13,CComBSTR(_T("N/A")));
			}

			//Certified
			SmpGrid->MergeCells(iFooterStartIndex+10,9,iFooterStartIndex+10,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+10,9,CComBSTR(_T("Certified that the particulars given above are true and correct.")));
			
			SmpGrid->MergeCells(iFooterStartIndex+11,9,iFooterStartIndex+11,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+11,9,CComBSTR(_T("For, ")+strShopName));
			
			SmpGrid->MergeCells(iFooterStartIndex+12,9,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+12,9,CComBSTR(_T("Authorized Signatory :")));
	

		CString strExtraField1,strExtraField2;


		SmpGrid->MergeCells(iFooterStartIndex+15,0,iFooterStartIndex+15,6);

		SmpGrid->MergeCells(iFooterStartIndex+15,7,iFooterStartIndex+15,MaxNoOfCoumns-1);


		SmpGrid->MergeCells(TotalRows-5,0,TotalRows-2,MaxNoOfCoumns-1);
		SmpGridCtrl->SetCellText(TotalRows-5,0,CComBSTR("Thank You Visit Again"),DT_CENTER|DT_NOCLIP|DT_WORDBREAK);
	
		//Set the Current Tab to Report Tab
		SmpPluginTab->SetCurrentView(0);
	}

}	
 	catch(_com_error &ex)
 	
	{
		AfxMessageBox(ex.Description());
 	}

 	catch(...)
 	
	{
		
	

 	}



		SmpGridCtrl->AutoSize();

	
	//Set the Current Tab to Report Tab
	SmpPluginTab->SetCurrentView(0);
}

void CSmpGridControlDlg::OnButtonBusinessLogo() 
{
	// TODO: Add your control notification handler code here

	HRESULT hr=S_OK;
	InitializeGrid();
	CString strColumnNumber,strRowNumber;
	 m_cboSelectColumn.GetWindowText(strColumnNumber);
	 m_cboSelectRow.GetWindowText(strRowNumber);
	 int NoofColumns=ConvertToInt(strColumnNumber);
	 int NoofRows=ConvertToInt(strRowNumber);

    

		SmpGridCtrl->SetBusinessLogo(NoofRows,NoofColumns,150,45);
		SmpGrid->put_RowHeight(NoofRows,50);


	//Set the Current Tab to Report Tab
	SmpPluginTab->SetCurrentView(0);
	 
}

void CSmpGridControlDlg::OnButtonDeleteAllimages() 
{
	// TODO: Add your control notification handler code here
//	InitializeGrid();
	
	SmpGridCtrl->DeleteAllImages();
	//SmpGridCtrl->RefreshCtrl();
	SmpPluginTab->SetCurrentView(0);
}

void CSmpGridControlDlg::InitializeComboBxes()
{
	 CString strNumber ;
    
	for(int iCount=0;iCount<=14;iCount++)
	{
		strNumber.Format(_T("%d"),iCount);		

		m_cboSelectRow.InsertString(iCount,strNumber);
		m_cboCellImageSelectRow.InsertString(iCount,strNumber);
		m_cboCellImageExSelectRow.InsertString(iCount,strNumber);
		m_cboCellTextRow.InsertString(iCount,strNumber);
		m_cboCellTextAlignmentRow.InsertString(iCount,strNumber);
		m_cboCellTextWrapRow.InsertString(iCount,strNumber);
		
	}
	m_cboSelectRow.SetCurSel(0);
	m_cboCellImageSelectRow.SetCurSel(0);
	m_cboCellImageExSelectRow.SetCurSel(0);
	m_cboCellTextRow.SetCurSel(0);
	m_cboCellTextAlignmentRow.SetCurSel(0);
	m_cboCellTextWrapRow.SetCurSel(0);
	for(int iColumnCount=0;iCount<=5;iCount++)
	{
		strNumber.Format(_T("%d"),iCount);		
		m_cboSelectColumn.InsertString(iColumnCount,strNumber);
		m_cboCellImageSelectColumn.InsertString(iColumnCount,strNumber);
		m_cboCellImageExSelectColumn.InsertString(iColumnCount,strNumber);
		m_cboCellTextColumn.InsertString(iColumnCount,strNumber);
		m_cboSetCellTextAlignmentColumn.InsertString(iColumnCount,strNumber);
		m_cboCellTextWrapColumn.InsertString(iColumnCount,strNumber);
		
	}

     
	 m_cboSelectColumn.SetCurSel(0);
	 m_cboCellImageSelectColumn.SetCurSel(0);
	 m_cboCellImageExSelectColumn.SetCurSel(0);
	 m_cboCellTextColumn.SetCurSel(0);
	 m_cboSetCellTextAlignmentColumn.SetCurSel(0);
	 m_cboCellTextWrapColumn.SetCurSel(0);

}

int CSmpGridControlDlg::ConvertToInt(CString strValue)
{
	#ifdef _UNICODE

	 return _ttoi(strValue) ;
	#else

		return (int) atoi(strValue);
	#endif
}

void CSmpGridControlDlg::InitializeGrid()
{
 
	
	SmpGridCtrl->DeleteAllItems();
   
    int iRows=15;
	int iCoumns=6;
	
	 
	SmpGrid->put_NoOfRows(iRows);

	SmpGrid->put_NoOfColumns(iCoumns);
	
	//Put the folumn width
	for(int i=0;i<iCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,200);
	}
}

void CSmpGridControlDlg::OnButtonDeleteAllItems() 
{
	// TODO: Add your control notification handler code here
		SmpGridCtrl->DeleteAllItems();
        
}

void CSmpGridControlDlg::OnButtonRefreshControl() 
{
	// TODO: Add your control notification handler code here
	SmpGridCtrl->RefreshCtrl();
	
}

void CSmpGridControlDlg::OnButtonSetCellImage() 
{
	// TODO: Add your control notification handler code here
	CString strColumnNumber,strRowNumber;
	InitializeGrid();
	m_cboCellImageSelectColumn.GetWindowText(strColumnNumber);
	m_cboCellImageSelectRow.GetWindowText(strRowNumber);
	int NoofColumns=ConvertToInt(strColumnNumber);
	int NoofRows=ConvertToInt(strRowNumber);
	if(m_strImagePath==(_T("")))
	{
	 AfxMessageBox(_T("Please select an image"));
	 return;
	}

	SmpGridCtrl->SetCellImage(NoofRows,NoofColumns,CComBSTR(m_strImagePath),100,50);
	SmpGrid->put_RowHeight(NoofRows,50);

	SmpPluginTab->SetCurrentView(0);
	
}



void CSmpGridControlDlg::OnButtonBrowseImage() 
{
	// TODO: Add your control notification handler code here
		CString strCaption;
		
		CString m_strImageName;
		CString m_strFileEx;
		CString m_pPicBuffer;
		CString m_lPicBuffSize;
		GetDlgItem(IDC_BUTTON_BROWSE_IMAGE)->GetWindowText(strCaption);

			CString strFilter=_T("All Picture Files (*.bmp;*.jpg;*.jpe;*.jpeg;*.gif;*.tif;*.tiff)|*.bmp;*.jpg;*.jpe;*.jpeg;*.gif;*.tif;*.tiff|");
			strFilter+=_T("BMP Files (*.bmp)|*.bmp|JPG Files (*.jpg;*.jpe;*.jpeg)|*.jpg;*.jpe;*.jpeg|");
			strFilter+=_T("GIF Files (*.gif)|*.gif|TIFF Files (*.tif;*.tiff)|*.tiff;*.tiff|");
			strFilter+=_T("All Files (*.*)|*.*||");

			CFileDialog FileDialog(TRUE,NULL,NULL,OFN_HIDEREADONLY,strFilter);
			
			if(FileDialog.DoModal()==IDOK)

			{
				
				m_strImagePath=FileDialog.GetPathName();

				m_strImageName=FileDialog.GetFileName();

				m_strFileEx=FileDialog.GetFileExt();


		
			}	
}


void CSmpGridControlDlg::OnButtonCreateBasicReport() 
{
	// TODO: Add your control notification handler code here

		InitializeGrid();
	
		SmpGrid->put_HorizondalGridLine(3L);
	CString strShopName,strShopAddress,strShopCity,strShopPhone,strShopGSTIN,strCustomerId,strCustomerGSTIN;
		CString strHandlingCharges,strSalesDiscAmount,strSalesDate,strBillType,strTotalCessAmount,strSupplyStateName;

		CString strCustomer=_T("");

		CString strGrUnitprice,strGrQuantity, strGrGrossValue, strGrCashDisc, strGrTaxAmount,strGrTotal;
		CString strSGST,strCGST,strIGST,strPayType;

		CString strConsumerLocation,strCustomerName;
		CString strConsumerState=_T("");
		bool bHSNCodeAvailable = false;

		float fHandlingCharges=0,fSalesDiscAmount=0,fGrantTotal;
		CString strTaxInfoCheck="False";
		static const TCHAR szSection[]	= _T("SMPOSSCREEN");
		static const TCHAR szKeyIH[]	= _T("DetailedTaxInfo");
		strTaxInfoCheck = AfxGetApp()->GetProfileString(szSection, szKeyIH, strTaxInfoCheck);
			strShopName=_T("KTS INFOTECH");
	strShopAddress=_T("Pala");
	strShopCity=_T("Kottayam");
	strShopPhone=_T("123456789");
	strShopGSTIN=_T("32GST1233HF");
	strSalesDate=_T("10/05/2017");
			COleDateTime dtOtherTimestamp;
		dtOtherTimestamp.ParseDateTime(strSalesDate);
		strSalesDate = dtOtherTimestamp.Format(_T("%d %B %Y"));


		strCustomerId=_T("Gopu");

	
		fHandlingCharges=10;
	    strHandlingCharges.Format(_T("%0.2f"),fHandlingCharges);

	
		fSalesDiscAmount=10;
	
		strPayType=_T("Cash");


		fGrantTotal=1000.00;
					
	
			strConsumerState=_T("Kerala");
			
	

		int HeaderRows=12;
		int ContentRows=0;
		int FooterRows=12;
		
		int TotalRows=HeaderRows+ContentRows+FooterRows;
		int MaxNoOfCoumns=10;

		int iHeaderRowIndex=0,strSupplyStateID;

		BOOL bUseLogo=TRUE;

		SmpGrid->put_NoOfRows(HeaderRows+ContentRows+FooterRows);

		SmpGrid->put_NoOfColumns(MaxNoOfCoumns);
		
		//Put the folumn width
		for(int i=0;i<MaxNoOfCoumns;i++)
		{
			SmpGrid->put_ColumnWidth(i,25);
		}
		//Put all report data Read Only
		SmpGridCtrl->SetGridDisplayReadOnly(TRUE);

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,2);
		SmpGrid->put_CellColour(iHeaderRowIndex,0,(long)RGB(0,0,0));
		iHeaderRowIndex++;


			SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
			SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);

			if(strShopName.GetLength()>24)
			{
				SmpGrid->put_RowHeight(iHeaderRowIndex,55);
			}
			else
			{
				SmpGrid->put_RowHeight(iHeaderRowIndex,35);
			}
			SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopName),DT_CENTER|DT_WORDBREAK);
			iHeaderRowIndex++;
	
			SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
			SmpGrid->put_RowHeight(iHeaderRowIndex,0);
			iHeaderRowIndex++;
	
			SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
			SmpGrid->put_CellFontSize(iHeaderRowIndex,0,15);
			SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("PRINT TYPE"),DT_CENTER|DT_WORDBREAK);
			iHeaderRowIndex++;

			SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
			SmpGrid->put_RowHeight(iHeaderRowIndex,0);
			iHeaderRowIndex++;

		

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,30);
		
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopAddress+strShopCity+ ", Phone: "+strShopPhone),DT_CENTER|DT_WORDBREAK);

		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,15);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("GSTIN: " + strShopGSTIN),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
		SmpGrid->put_RowHeight(iHeaderRowIndex,27);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("Tax Invoice"),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		//Gap
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,1);
		iHeaderRowIndex++;
		//End Gap

		//Header Text first row
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,4);
		SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Invoice No: 10" )));
		SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex,9);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,4,CComBSTR("Date: 05/10/2017" ),DT_RIGHT|DT_WORDBREAK);
		iHeaderRowIndex++;
		
	

		strSupplyStateID=32;
		strSupplyStateName=_T("Kerala");

		//Header Text second row
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,4);
		SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Billed To: " + strCustomerName)));

		SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex,9);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,4,CComBSTR("State: "+strSupplyStateName),DT_RIGHT|DT_WORDBREAK);
		iHeaderRowIndex++;

		//Header Text third row
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,4);
		SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("GSTIN: ") + strCustomerGSTIN));

		SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex,9);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,4,CComBSTR("State Code: "+strSupplyStateID),DT_RIGHT|DT_WORDBREAK);
		iHeaderRowIndex++;

		//GAP
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,1);
		iHeaderRowIndex++;
		//End GAP

		//Now set the Item Headers
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,2);
		SmpGrid->put_ColumnWidth(0,80);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("Item Name"),DT_CENTER|DT_WORDBREAK);

		SmpGrid->MergeCells(iHeaderRowIndex,3,iHeaderRowIndex+1,3);
		SmpGrid->put_ColumnWidth(3,30);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,3,CComBSTR("Qty"),DT_CENTER|DT_WORDBREAK);

		SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex+1,5);
		SmpGrid->put_ColumnWidth(4,40);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,4,CComBSTR("Rate"),DT_CENTER|DT_WORDBREAK);

		if(strTaxInfoCheck==_T("True"))
		{
			SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex+1,6);
			SmpGrid->put_ColumnWidth(6,40);
			SmpGridCtrl->SetCellText(iHeaderRowIndex,6,CComBSTR("Tax %"),DT_CENTER|DT_WORDBREAK);

			SmpGrid->MergeCells(iHeaderRowIndex,7,iHeaderRowIndex+1,9);
			SmpGrid->put_ColumnWidth(7,20);
			SmpGridCtrl->SetCellText(iHeaderRowIndex,7,CComBSTR("Taxable Amount"),DT_CENTER|DT_WORDBREAK);
		}
		else
		{
			SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex+1,6);
			SmpGrid->put_ColumnWidth(6,0);

			SmpGrid->MergeCells(iHeaderRowIndex,7,iHeaderRowIndex+1,9);
			SmpGrid->put_ColumnWidth(7,20);
			SmpGridCtrl->SetCellText(iHeaderRowIndex,7,CComBSTR("Taxable Amount"),DT_CENTER|DT_WORDBREAK);
		}
		iHeaderRowIndex++;

	
		//float fTrTaxRate,fTrUnitPrice,fTrQty,fGrValue;
		CString strRecCount,strTranCount,strItemId,strHSNCode,strName,strTrTaxRate;
		CString strTrUnitPrice,strTrQty,strGrValue,strTrDiscAmt,strTrCatName;
		CString strTrCatId,strTrNetAmt,strTrTaxAmt,strTotalPrice;

		float fTotal;
		float fTotalItemDiscount = 0;;
		float fSubTotal = 0.0;
		float fSGSTTotalTaxAmt = 0.0;
		float fCGSTTotalTaxAmt = 0.0;
		float fIGSTTotalTaxAmt = 0.0;
		float fCessStateTotalTaxAmt = 0.0;
		float fCessIGSTTotalTaxAmt = 0.0;


		int iContentRowIndex=iHeaderRowIndex+1;

			SmpGrid->put_NoOfRows(HeaderRows+5+FooterRows);
			SmpGrid->put_NoOfColumns(MaxNoOfCoumns);

			int iIndex = 0;

					int iRowHeight=45;
					SmpGrid->put_RowHeight(iContentRowIndex,iRowHeight);

					SmpGrid->MergeCells(iContentRowIndex,0,iContentRowIndex,2);
					//SmpGrid->put_RowHeight(iContentRowIndex,30);
					SmpGridCtrl->SetCellText(iContentRowIndex,0,CComBSTR(_T("Salesmate +")),DT_LEFT|DT_WORDBREAK);

					SmpGrid->put_RowHeight(iContentRowIndex,iRowHeight);
					SmpGridCtrl->SetCellText(iContentRowIndex,3,CComBSTR(_T("2")),DT_LEFT|DT_WORDBREAK);

					SmpGrid->MergeCells(iContentRowIndex,4,iContentRowIndex,5);
					SmpGrid->put_RowHeight(iContentRowIndex,iRowHeight);
					SmpGridCtrl->SetCellText(iContentRowIndex,4,CComBSTR(_T("4500")),DT_RIGHT|DT_WORDBREAK);

					
						SmpGrid->put_RowHeight(iContentRowIndex,iRowHeight);
						SmpGridCtrl->SetCellText(iContentRowIndex,6,CComBSTR(_T("9")),DT_RIGHT|DT_WORDBREAK);

						SmpGrid->MergeCells(iContentRowIndex,7,iContentRowIndex,9);
						SmpGrid->put_RowHeight(iContentRowIndex,iRowHeight);
						SmpGridCtrl->SetCellText(iContentRowIndex,7,CComBSTR(_T("5310")),DT_RIGHT|DT_WORDBREAK);
			
					
					float fCessIGST=0,fCessState=0;
					//GET TAX DETAILS
					


					float fSGST=0,fCGST=0,fIGST=0;
				
					
					fTotalItemDiscount = 1000;
					fSGSTTotalTaxAmt = 405;
					fCGSTTotalTaxAmt = 405;
					fIGSTTotalTaxAmt = 0;
				
					fSubTotal = 10620;
					iContentRowIndex++;
					iIndex++;
			
		
		int iFooterIndex=0;
		float fDiscount =0.00;
		float fTotalCessAmount =0.0;

		CString strTotal,strSubTotal,strSGSTTotal,strCGSTTotal,strIGSTTotal,strCessIGSTTotal,strCessStateTotal, strTotalDiscount;
		strSubTotal.Format(_T("%0.2f"),fSubTotal);
		strSGSTTotal.Format(_T("%0.2f"),fSGSTTotalTaxAmt);
		strCGSTTotal.Format(_T("%0.2f"),fCGSTTotalTaxAmt);
		strIGSTTotal.Format(_T("%0.2f"),fIGSTTotalTaxAmt);
	
		fDiscount=fDiscount+fTotalItemDiscount;
		strTotalDiscount.Format(_T("%0.2f"),fDiscount);
		

		if(fDiscount==0)
		{
			iFooterIndex++;	
		}

		if(fHandlingCharges<=0)
		{	
			iFooterIndex++;
		}

		if(strConsumerLocation == "Inside State")
		{
			iFooterIndex++;
			if(fTotalCessAmount<=0)
			{
				iFooterIndex++;
			}

			SmpGrid->put_NoOfRows(iContentRowIndex+FooterRows-iFooterIndex);
			fTotal = fSubTotal+fSGSTTotalTaxAmt+fCGSTTotalTaxAmt+fTotalCessAmount+fHandlingCharges-(fDiscount);
			strTotal.Format(_T("%0.2f"),fTotal);
		}
		else
		{
			iFooterIndex = iFooterIndex+2;
			if(fTotalCessAmount<=0)
			{
				iFooterIndex++;
			}

			SmpGrid->put_NoOfRows(iContentRowIndex+FooterRows-iFooterIndex);

			fTotal = fSubTotal+fIGSTTotalTaxAmt+fTotalCessAmount+fHandlingCharges-(fDiscount);
			
			strTotal.Format(_T("%0.2f"),fTotal);
		}
		SmpGrid->put_NoOfColumns(MaxNoOfCoumns);
		
//		int iIndex=0;
		int iFooterStartIndex=iContentRowIndex;
		//Now the Amount Section
		SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
		SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("Sub Total")));
		
		SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
		SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strSubTotal),DT_RIGHT|DT_WORDBREAK);
		iIndex++;

		if(strConsumerLocation == "Inside State")
		{
			//CGST
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
			SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("CGST")));
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);

			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strCGSTTotal),DT_RIGHT|DT_WORDBREAK);
			iIndex++;

			//SGST
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
			SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("SGST")));
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strSGSTTotal),DT_RIGHT|DT_WORDBREAK);
			iIndex++;
		}
		else
		{
			//IGST
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
			SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("IGST")));
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strIGSTTotal),DT_RIGHT|DT_WORDBREAK);
			iIndex++;
		}

		//CESS
		if(fTotalCessAmount>0)
		{
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
			SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("Cess")));
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
			
			

			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strTotalCessAmount),DT_RIGHT|DT_WORDBREAK);
			iIndex++;
		}

		//Handling Charges
		if(fHandlingCharges>0)
		{
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
			SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("Handling Charges")));
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strHandlingCharges),DT_RIGHT|DT_WORDBREAK);
			iIndex++;
		}

		//Discount
	
		
		//Total Tax Amount after Tax
		SmpGrid->MergeCells(iFooterStartIndex+iIndex,3,iFooterStartIndex+iIndex,6);
		SmpGrid->put_CellText(iFooterStartIndex+iIndex,3,CComBSTR(_T("Total Invoice")));
		SmpGrid->MergeCells(iFooterStartIndex+iIndex,7,iFooterStartIndex+iIndex,9);
		SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,7,CComBSTR(strTotal),DT_RIGHT|DT_WORDBREAK);
		iIndex++;

		SmpGrid->MergeCells(iFooterStartIndex+iIndex,0,iFooterStartIndex+iIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iFooterStartIndex+iIndex,0,25);
		SmpGrid->put_RowHeight(iFooterStartIndex+iIndex,27);
		SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,0,CComBSTR("BILL AMOUNT: "+strTotal+"/-"),DT_CENTER|DT_WORDBREAK);
		iIndex++;

	
			CString strOperatorName=_T("KTS InfoTech");
			SmpGrid->MergeCells(iFooterStartIndex+iIndex,0,iFooterStartIndex+iIndex,MaxNoOfCoumns-1);
			SmpGrid->put_CellFontSize(iFooterStartIndex+iIndex,0,13);
			SmpGrid->put_RowHeight(iFooterStartIndex+iIndex,20);
			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,0,CComBSTR("Cashier Name: "+strOperatorName),DT_CENTER|DT_WORDBREAK);
			iIndex++;
	

				SmpGrid->put_RowHeight(iFooterStartIndex+iIndex,35);
		

			SmpGrid->MergeCells(iFooterStartIndex+iIndex,0,iFooterStartIndex+iIndex,MaxNoOfCoumns-1);
			SmpGridCtrl->SetCellText(iFooterStartIndex+iIndex,0,CComBSTR("Thank You Visit Again"),DT_CENTER|DT_WORDBREAK);
			iIndex++;
	

		//merge left footer cells 
		SmpGrid->MergeCells(iFooterStartIndex,0,iFooterStartIndex+iIndex-3,2);
		
		//bottom margin
		SmpGrid->MergeCells(iFooterStartIndex+iIndex,0,iFooterStartIndex+iIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iFooterStartIndex+iIndex,2);
		SmpGrid->put_CellColour(iFooterStartIndex+iIndex,0,(long)RGB(0,0,0));

		
		//Set the Current Tab to Report Tab
		SmpPluginTab->SetCurrentView(0);


	
}

void CSmpGridControlDlg::OnButtonCreateDetailReport() 
{
	// TODO: Add your control notification handler code here
		InitializeGrid();
	
	

	//First delete all items
//	SmpGridCtrl->DeleteAllItems();
	SmpGrid->put_HorizondalGridLine(3L);
	
	int HeaderRows=17;
	int ContentRows=10;
	int FooterRows=20;

	int iHeaderRowIndex=0;

	int TotalRows=HeaderRows+ContentRows+FooterRows;

	int MaxNoOfCoumns=15;

	float fHandlingCharges,fSalesDiscAmount,fGrantTotal;
	
	CString strHandlingCharges,strSalesDiscAmount,strGrantTotal;
	CString strShopName,strShopAddress,strShopCity,strShopPhone,strShopGSTIN,strCustomerId,strCustomerGSTIN="",strCustomerName,strCustomerAddress;
	CString strShopBankAccountNo,strShopBankIFSC;
	
	BOOL bUseLogo=TRUE;

	SmpGrid->put_NoOfRows(HeaderRows+ContentRows+FooterRows);

	SmpGrid->put_NoOfColumns(MaxNoOfCoumns);
	
	//Put the folumn width
	for(int i=0;i<MaxNoOfCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,60);
	}

	strShopName=_T("KTS INFOTECH");
	strShopAddress=_T("Pala");
	strShopCity=_T("Kottayam");
	strShopPhone=_T("123456789");
	strShopGSTIN=_T("32GST1233HF");
	strShopBankAccountNo=_T("570123456789");
	strShopBankIFSC=_T("SBIN000000");


	CString SQL,SQLTRAN,strPayType,strBillType,strSalesDate,strConsumerState;
	float fGrUnitprice=0,fGrQuantity=0,fGrGrossValue=0,fGrCashDisc=0,fGrTaxAmount=0,fGrTotal=0;
	float fNetAmtWithoutTax=0,fTotalSGST=0,fTotalCGST=0,fTotalIGST=0,fTotalGST=0,fTotalCess=0;
	CString SQLSTATE,strSelectQuery,strSelectStateQuery,strShopStateName,strShopStateID,strShopStateTin;
	CComVariant ComVariant;

 
		strSalesDate=_T("10/05/2017");


		COleDateTime dtOtherTimestamp;
		dtOtherTimestamp.ParseDateTime(strSalesDate);
		strSalesDate = dtOtherTimestamp.Format(_T("%d %B %Y"));


		strCustomerId=_T("Gopu");

	
		fHandlingCharges=10;
	    strHandlingCharges.Format(_T("%0.2f"),fHandlingCharges);

	
		fSalesDiscAmount=10;
	
		strPayType=_T("Cash");

	
		fGrantTotal=1000.00;
					
		
		strGrantTotal.Format(_T("%0.2f"),fGrantTotal);

	
			strConsumerState=_T("Kerala");
			
	

	strShopStateTin=_T("123456");
	strShopStateID=_T("32");
	strShopStateName=_T("Kerala");

	//Get shipping datails
	CString strReverseCharge="No",strTransMode="",strVehicleNo="";

	CString strSupplyStateTin,strSupplyStateID,strSupplyStateName,strConsumerLocation;

	strSupplyStateTin=_T("12345");
	strSupplyStateID=_T("32");
	strSupplyStateName=_T("Kerala");



	CString strFirstName,strLastName;
 
		strFirstName = _T("KTS");
	

		strLastName = _T("Infotech");
		

		strCustomerAddress = _T("Pala");


	
	strCustomerName=strFirstName+_T(" ")+strLastName;

	//Get Customer GSTIN

	CString SQLCUSTGSTIN;
	

	//Put all report data Read Only
	SmpGridCtrl->SetGridDisplayReadOnly(TRUE);


		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,40);
		SmpGrid->put_RowHeight(iHeaderRowIndex,44);
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopName),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;

	
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,27);
	SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(strShopAddress+_T(", ")+strShopCity+_T(", Mobile: ")+strShopPhone),DT_CENTER|DT_WORDBREAK);
	iHeaderRowIndex++;
	

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_CellFontSize(iHeaderRowIndex,0,21);
		
		SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR(_T("Header Text")),DT_CENTER|DT_WORDBREAK);
		iHeaderRowIndex++;

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iHeaderRowIndex,0);
		iHeaderRowIndex++;


	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,27);
	SmpGridCtrl->SetCellText(iHeaderRowIndex,0,CComBSTR("GSTIN : 32fghb2544"),DT_CENTER|DT_WORDBREAK);
	iHeaderRowIndex++;

	//Now Merge header Rows/cells
	if(bUseLogo) //Check for Logo
	{

		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,1);
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,11);
		SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex+1,MaxNoOfCoumns-1);

		//Put The logo
		SmpGridCtrl->SetBusinessLogo(iHeaderRowIndex,0,150,45);
		SmpGrid->put_RowHeight(iHeaderRowIndex,27);
		//Set the Invoice Text
		SmpGrid->put_CellFontSize(iHeaderRowIndex,2,38);
		SmpGrid->put_CellTextColour(iHeaderRowIndex,2,RGB(0,0,255));
		SmpGridCtrl->SetCellText(iHeaderRowIndex,2,CComBSTR(strBillType),DT_CENTER|DT_WORDBREAK);
		SmpGrid->put_CellText(iHeaderRowIndex,13,CComBSTR(_T("Duplicate")));
		SmpGrid->put_CellFontSize(iHeaderRowIndex,12,25);
		SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("")));

	}
	else
	{
		SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,12);
		SmpGrid->MergeCells(iHeaderRowIndex,13,iHeaderRowIndex+1,MaxNoOfCoumns-1);

		//Put Some Value
		SmpGrid->put_CellFontSize(0,0,40);
		SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Tax Invoice")));
		
		SmpGrid->put_CellFontSize(iHeaderRowIndex,12,25);
		SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("")));
		//SmpGrid->put_CellText(iHeaderRowIndex,13,CComBSTR(_T("Duplicate for Driver")));
	}
	iHeaderRowIndex+=2;
	//Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);
	iHeaderRowIndex++;
	//End Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Reverse Charge : "+strReverseCharge)));
SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Invoice No : 10 ")));

		SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
		SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Invoice Date : "+strSalesDate)));
	


	SmpGrid->MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	SmpGrid->put_CellText(iHeaderRowIndex,9,CComBSTR(_T("State : "+strShopStateName)));
	
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("State Code : "+strShopStateID)));
	iHeaderRowIndex++;

	/////////////////////////////////////////////////

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,1);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Transporation Mode : ash")));
	SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex,5);
	SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Vehicle No : "+strVehicleNo)));
	SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex,8);
	SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Date Of Supply : "+strSalesDate)));

	SmpGrid->MergeCells(iHeaderRowIndex,9,iHeaderRowIndex,11);
	SmpGrid->put_CellText(iHeaderRowIndex,9,CComBSTR(_T("Place Of supply : "+strSupplyStateName)));
	
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("State Code : "+strSupplyStateID)));
	iHeaderRowIndex++;
	///
	//Gao
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);
	iHeaderRowIndex++;
	/////////////////////////////
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,0,25);
	SmpGrid->put_RowHeight(iHeaderRowIndex,25);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Details Of The Receiver | Billed To")));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellFontSize(iHeaderRowIndex,8,25);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Details Of The Consignee | Shipped To")));
	iHeaderRowIndex++;
	

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Name        : "+strCustomerName)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Name        : "+strCustomerName)));
	iHeaderRowIndex++;

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Address    : "+strCustomerAddress)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("Address    : "+strCustomerAddress)));
	iHeaderRowIndex++;

	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,2);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("GSTIN : "+strCustomerGSTIN)));

	SmpGrid->MergeCells(iHeaderRowIndex,3,iHeaderRowIndex,4);
	SmpGrid->put_CellText(iHeaderRowIndex,3,CComBSTR(_T("State : "+strSupplyStateName)));
	SmpGrid->MergeCells(iHeaderRowIndex,5,iHeaderRowIndex,7);
	SmpGrid->put_CellText(iHeaderRowIndex,5,CComBSTR(_T("State Code : "+strSupplyStateID)));

	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,10);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("GSTIN : "+strCustomerGSTIN)));

	SmpGrid->MergeCells(iHeaderRowIndex,11,iHeaderRowIndex,12);
	SmpGrid->put_CellText(iHeaderRowIndex,11,CComBSTR(_T("State : "+strSupplyStateName)));
	SmpGrid->MergeCells(iHeaderRowIndex,13,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_CellText(iHeaderRowIndex,13,CComBSTR(_T("State Code : "+strSupplyStateID)));
	iHeaderRowIndex++;

	CString strIncludeHSN=_T("False");
	static const TCHAR szSection[]	= _T("SMPOSSCREEN");
	static const TCHAR szKeyIH[]	= _T("IncludeHSN");
	strIncludeHSN = AfxGetApp()->GetProfileString(szSection, szKeyIH, strIncludeHSN);

	bool bHSNCodeAvailable = false;

		bHSNCodeAvailable=true;


	//Now demarcate the next area
	//GAP
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,10);
	SmpGrid->put_CellColour(iHeaderRowIndex,0,(long)RGB(0,0,0));
	iHeaderRowIndex++;
	//End GAP
	//Now set the Item Headers
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex+1,0);
	SmpGrid->put_ColumnWidth(0,45);
	SmpGrid->put_CellText(iHeaderRowIndex,0,CComBSTR(_T("Sr.No.")));
	
	SmpGrid->MergeCells(iHeaderRowIndex,1,iHeaderRowIndex+1,1);
	SmpGrid->put_ColumnWidth(1,150);
	SmpGrid->put_CellText(iHeaderRowIndex,1,CComBSTR(_T("Name of Product / Service")));

	if(bHSNCodeAvailable)
	{
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("HSN")));
	}
	else
	{
		SmpGrid->MergeCells(iHeaderRowIndex,2,iHeaderRowIndex+1,2);
		SmpGrid->put_CellText(iHeaderRowIndex,2,CComBSTR(_T("Item ID")));
	}
	
	

	SmpGrid->MergeCells(iHeaderRowIndex,3,iHeaderRowIndex+1,3);
	SmpGrid->put_ColumnWidth(3,40);
	SmpGrid->put_CellText(iHeaderRowIndex,3,CComBSTR(_T("Qty")));

	SmpGrid->MergeCells(iHeaderRowIndex,4,iHeaderRowIndex+1,4);
	SmpGrid->put_ColumnWidth(4,70);
	SmpGrid->put_CellText(iHeaderRowIndex,4,CComBSTR(_T("Rate")));

	SmpGrid->MergeCells(iHeaderRowIndex,5,iHeaderRowIndex+1,5);
	SmpGrid->put_ColumnWidth(5,75);
	SmpGrid->put_CellText(iHeaderRowIndex,5,CComBSTR(_T("Amount")));
	
	SmpGrid->MergeCells(iHeaderRowIndex,6,iHeaderRowIndex+1,6);
	SmpGrid->put_CellText(iHeaderRowIndex,6,CComBSTR(_T("Discount")));

	SmpGrid->MergeCells(iHeaderRowIndex,7,iHeaderRowIndex+1,7);
	SmpGrid->put_ColumnWidth(7,80);
	SmpGrid->put_CellText(iHeaderRowIndex,7,CComBSTR(_T("Taxable Value")));
	//CGST
	SmpGrid->MergeCells(iHeaderRowIndex,8,iHeaderRowIndex,9);
	SmpGridCtrl->SetCellTextAlignment(14,8,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,8,CComBSTR(_T("SGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,8,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,9,CComBSTR(_T("Amount")));

	///SGST
	SmpGrid->MergeCells(iHeaderRowIndex,10,iHeaderRowIndex,11);
	SmpGridCtrl->SetCellTextAlignment(iHeaderRowIndex,10,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,10,CComBSTR(_T("CGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,10,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,11,CComBSTR(_T("Amount")));

	//IGST
	SmpGrid->MergeCells(iHeaderRowIndex,12,iHeaderRowIndex,13);
	SmpGridCtrl->SetCellTextAlignment(iHeaderRowIndex,12,DT_CENTER);
	SmpGrid->put_CellText(iHeaderRowIndex,12,CComBSTR(_T("IGST")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,12,CComBSTR(_T("Rate")));
	SmpGrid->put_CellText(iHeaderRowIndex+1,13,CComBSTR(_T("Amount")));

	//Total
	SmpGrid->MergeCells(iHeaderRowIndex,14,iHeaderRowIndex+1,14);
	SmpGrid->put_ColumnWidth(14,85);
	SmpGrid->put_CellText(iHeaderRowIndex,14,CComBSTR(_T("Total")));
	iHeaderRowIndex+=2;
	//Gap
	SmpGrid->MergeCells(iHeaderRowIndex,0,iHeaderRowIndex,MaxNoOfCoumns-1);
	SmpGrid->put_RowHeight(iHeaderRowIndex,1);


	try
 	{
		

		

		CString strTinText,strCstText,strCitydet,strVATHeading,strFormTxt;
		

		
		
		CString strLargestItemName=_T("");

		CString strLargestItemID=_T("");
		float fCessAmt=0;

	
		
		CString strGrUnitprice,strGrQuantity,strGrGrossValue,strGrCashDisc,strGrTaxAmount,strGrTotal,strSalesDate;

	
		int iTempRow,iTempCol;
		int iTranCount;
		
		CString strRecCount,strTranCount,strItemId,strHSNCode,strName,strTrTaxRate;
		CString strTrUnitPrice,strTrQty,strGrValue,strTrDiscAmt,strTrCatName;
		CString strTrCatId,strTrNetAmt,strTrTaxAmt,strTotalPrice,strItemDiscount;

		int iFooterStartIndex=0;
		iTempRow=HeaderRows+1;
		iTranCount=0;
		iTempCol=0;
		float fCessStateTotalTaxAmt = 0.0;
		float fCessIGSTTotalTaxAmt = 0.0;
		CString strSgstTaxId,strCgstTaxId,strIgstTaxId;
	{


            SmpGridCtrl->SetCellText(20,0,CComBSTR(_T("1")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
			SmpGridCtrl->SetCellText(20,1,CComBSTR(_T("Salemate +")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
			SmpGridCtrl->SetCellText(20,2,CComBSTR(_T("1234")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
					SmpGridCtrl->SetCellText(20,3,CComBSTR(_T("2")),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);

			
					SmpGridCtrl->SetCellText(20,4,CComBSTR(_T("2500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

				
					SmpGridCtrl->SetCellText(20,5,CComBSTR(_T("5000")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

				
					SmpGridCtrl->SetCellText(20,6,CComBSTR(_T("500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					SmpGridCtrl->SetCellText(20,7,CComBSTR(_T("4500")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
						SmpGridCtrl->SetCellText(20,8,CComBSTR(_T("9")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,9,CComBSTR(_T("405")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,10,CComBSTR(_T("9")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,11,CComBSTR(_T("405")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
							SmpGridCtrl->SetCellText(20,14,CComBSTR(_T("5310")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					
					SmpGridCtrl->SetCellText(1,7,CComBSTR(_T("23")),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
 
                    SmpGridCtrl->SetCellText(2,3,_T("2"),DT_LEFT|DT_NOCLIP|DT_WORDBREAK);

					
					SmpGridCtrl->SetCellText(2,4,_T("25"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

					SmpGridCtrl->SetCellText(2,5,_T("25"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

				
					SmpGridCtrl->SetCellText(2,6,_T("2"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

					
					SmpGridCtrl->SetCellText(2,7,_T("23"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
					//Calculate SGST,CGST,IGST rate and amount

					CString strTaxPercentage,strTaxAmount,strTaxCategoryId,strCessId,strCessTransId;
					

					float fCessIGST=0,fCessState=0;
	
					iFooterStartIndex=25;
		SmpGrid->MergeCells(iFooterStartIndex,0,iFooterStartIndex,MaxNoOfCoumns-1);
		SmpGrid->put_RowHeight(iFooterStartIndex,1);
		
		iFooterStartIndex=iFooterStartIndex+1;
		SmpGrid->MergeCells(iFooterStartIndex,0,iFooterStartIndex,8);
		SmpGrid->put_CellText(iFooterStartIndex,0,CComBSTR(_T("Total Invoice Amount in Words:")));
		
		CString strDigiWords;
	//	strDigiWords=GetApp()->ConvertDigitToWord(strGrantTotal);

		SmpGrid->MergeCells(iFooterStartIndex+1,0,iFooterStartIndex+6,8);
		SmpGrid->put_CellFontSize(iFooterStartIndex+1,0,30);
		SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR("Ten Thousand six hundred and twenty Only"),DT_WORDBREAK);

		//Now the Amount Section
		SmpGrid->MergeCells(iFooterStartIndex,9,iFooterStartIndex,12);
		SmpGrid->put_CellText(iFooterStartIndex,9,CComBSTR(_T("Total Amount Before Tax")));
		SmpGrid->MergeCells(iFooterStartIndex,13,iFooterStartIndex,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex,13,CComBSTR("4500"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//CGST
		SmpGrid->MergeCells(iFooterStartIndex+1,9,iFooterStartIndex+1,12);
		SmpGrid->put_CellText(iFooterStartIndex+1,9,CComBSTR(_T("Add : CGST")));
		SmpGrid->MergeCells(iFooterStartIndex+1,13,iFooterStartIndex+1,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+1,13,CComBSTR("405"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		//SGST
		SmpGrid->MergeCells(iFooterStartIndex+2,9,iFooterStartIndex+2,12);
		SmpGrid->put_CellText(iFooterStartIndex+2,9,CComBSTR(_T("Add : SGST")));
		SmpGrid->MergeCells(iFooterStartIndex+2,13,iFooterStartIndex+2,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+2,13,CComBSTR("405"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		//IGST
		SmpGrid->MergeCells(iFooterStartIndex+3,9,iFooterStartIndex+3,12);
		SmpGrid->put_CellText(iFooterStartIndex+3,9,CComBSTR(_T("Add : IGST")));
		SmpGrid->MergeCells(iFooterStartIndex+3,13,iFooterStartIndex+3,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+3,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		
		//CESS amount GST
		SmpGrid->MergeCells(iFooterStartIndex+4,9,iFooterStartIndex+4,12);
		SmpGrid->put_CellText(iFooterStartIndex+4,9,CComBSTR(_T("CESS (+)")));
		SmpGrid->MergeCells(iFooterStartIndex+4,13,iFooterStartIndex+4,14);
		/*if(strConsumerLocation == "Inside State")
		{
			SmpGridCtrl->SetCellText(iFooterStartIndex+4,13,CComBSTR(strTotalCessAmount),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		}
		else
		{
			SmpGridCtrl->SetCellText(iFooterStartIndex+4,13,CComBSTR(strTotalCessAmount),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
		}*/
		SmpGridCtrl->SetCellText(iFooterStartIndex+4,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Discount amount 
		SmpGrid->MergeCells(iFooterStartIndex+5,9,iFooterStartIndex+5,12);
		SmpGrid->put_CellText(iFooterStartIndex+5,9,CComBSTR(_T("Handling/Transportation  Charges (+) ")));
		SmpGrid->MergeCells(iFooterStartIndex+5,13,iFooterStartIndex+5,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+5,13,CComBSTR("0"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Handling/Transportation  Charges:
	//	strSalesDiscAmount.Format(_T("%0.2f"),fTotalDiskAmt);
		SmpGrid->MergeCells(iFooterStartIndex+6,9,iFooterStartIndex+6,12);
		SmpGrid->put_CellText(iFooterStartIndex+6,9,CComBSTR(_T("Total Discount (-) ")));
		SmpGrid->MergeCells(iFooterStartIndex+6,13,iFooterStartIndex+6,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+6,13,CComBSTR("1000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Total Tax Amount after Tax
		SmpGrid->MergeCells(iFooterStartIndex+7,9,iFooterStartIndex+7,12);
		SmpGrid->put_CellFontSize(iFooterStartIndex+7,9,25);
		SmpGrid->put_CellFontSize(iFooterStartIndex+7,13,25);
		SmpGrid->put_RowHeight(iFooterStartIndex+7,30);
		SmpGrid->put_CellText(iFooterStartIndex+7,9,CComBSTR(_T("Grant Total")));
		SmpGrid->MergeCells(iFooterStartIndex+7,13,iFooterStartIndex+7,14);
		SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("10620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);

		//Last Footer Area
		
		CString strDisplayBankInfo,strDeclaration;
		
	

		//Payment Type
		SmpGrid->MergeCells(iFooterStartIndex+7,0,iFooterStartIndex+7,2);
		SmpGrid->put_CellText(iFooterStartIndex+7,0,CComBSTR(_T("Payment Type")));
		SmpGrid->MergeCells(iFooterStartIndex+7,3,iFooterStartIndex+7,6);
		SmpGrid->put_CellText(iFooterStartIndex+7,3,CComBSTR("Cash"));
		
	
			//Add Bank details
			SmpGrid->MergeCells(iFooterStartIndex+8,0,iFooterStartIndex+8,6);
			SmpGrid->put_CellText(iFooterStartIndex+8,0,CComBSTR(_T("Bank details")));
			//Bank Account Number
			SmpGrid->MergeCells(iFooterStartIndex+9,0,iFooterStartIndex+9,2);
			SmpGrid->put_CellText(iFooterStartIndex+9,0,CComBSTR(_T("Bank Account Number")));
			SmpGrid->MergeCells(iFooterStartIndex+9,3,iFooterStartIndex+9,6);
			SmpGrid->put_CellText(iFooterStartIndex+9,3,CComBSTR("67012548223"));
			//Bank Branch IfSC
			SmpGrid->MergeCells(iFooterStartIndex+10,0,iFooterStartIndex+10,2);
			SmpGrid->put_CellText(iFooterStartIndex+10,0,CComBSTR(_T("Bank Branch IFSC")));
			SmpGrid->MergeCells(iFooterStartIndex+10,3,iFooterStartIndex+10,6);
			SmpGrid->put_CellText(iFooterStartIndex+10,3,CComBSTR("SBIN0700001"));
			//Terms and Conditions
			
			SmpGrid->MergeCells(iFooterStartIndex+11,0,iFooterStartIndex+14,6);
			SmpGridCtrl->SetCellText(iFooterStartIndex+11,0,CComBSTR(_T("Terms and Conditions:\n     ")+strDeclaration),DT_TOP|DT_LEFT|DT_NOCLIP|DT_WORDBREAK);
		
			//Gap
		

		//Office Seal
		SmpGrid->MergeCells(iFooterStartIndex+7,7,iFooterStartIndex+14,8);	
		SmpGrid->put_CellText(iFooterStartIndex+7,7,CComBSTR(_T("Office Seal")));
		//Footer Memo
		//Break
		
			//Reverse Charge
			SmpGrid->MergeCells(iFooterStartIndex+8,9,iFooterStartIndex+8,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+8,9,CComBSTR(_T("GST Payable On Reverse Charge ")));
			SmpGrid->MergeCells(iFooterStartIndex+8,13,iFooterStartIndex+8,MaxNoOfCoumns-1);
			if(strReverseCharge==_T("Yes"))
			{
				fGrantTotal=fGrantTotal-fTotalGST-fTotalCess;
				strGrantTotal.Format(_T("%0.2f"),fGrantTotal);
				SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR(strDigiWords),DT_WORDBREAK);

				SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("9000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
				SmpGridCtrl->SetCellText(iFooterStartIndex+8,13,CComBSTR("1620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
			}
			else
			{
				SmpGrid->put_CellText(iFooterStartIndex+8,13,CComBSTR(_T("N/A")));
			}
			//Certified
			SmpGrid->MergeCells(iFooterStartIndex+9,9,iFooterStartIndex+9,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+9,9,CComBSTR(_T("Certified that the particulars given above are true and correct.")));
			
			SmpGrid->MergeCells(iFooterStartIndex+10,9,iFooterStartIndex+10,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+10,9,CComBSTR(_T("For, ")+strShopName));
			
			SmpGrid->MergeCells(iFooterStartIndex+11,9,iFooterStartIndex+13,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+11,9,CComBSTR(_T("Authorized Signatory :")));

			//Display Operator Name
	
			SmpGrid->MergeCells(iFooterStartIndex+14,9,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+14,9,CComBSTR(_T("Operator Name ")));
			SmpGrid->MergeCells(iFooterStartIndex+14,13,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+14,13,CComBSTR("KTS InfoTech"));
		
			//Break
			SmpGrid->MergeCells(iFooterStartIndex+8,9,iFooterStartIndex+8,MaxNoOfCoumns-1);

			//Reverse Charge
			SmpGrid->MergeCells(iFooterStartIndex+9,9,iFooterStartIndex+9,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+9,9,CComBSTR(_T("GST Payable On Reverse Charge ")));
			SmpGrid->MergeCells(iFooterStartIndex+9,13,iFooterStartIndex+9,MaxNoOfCoumns-1);
			if(strReverseCharge==_T("Yes"))
			{
				fGrantTotal=fGrantTotal-fTotalGST-fTotalCess;
				strGrantTotal.Format(_T("%0.2f"),fGrantTotal);

				SmpGridCtrl->SetCellText(iFooterStartIndex+1,0,CComBSTR("Ten Thousand six hundred and twenty"),DT_WORDBREAK);

				SmpGridCtrl->SetCellText(iFooterStartIndex+7,13,CComBSTR("9000"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
				SmpGridCtrl->SetCellText(iFooterStartIndex+9,13,CComBSTR("1620"),DT_RIGHT|DT_NOCLIP|DT_WORDBREAK);
			}
			else
			{
				SmpGrid->put_CellText(iFooterStartIndex+9,13,CComBSTR(_T("N/A")));
			}

			//Certified
			SmpGrid->MergeCells(iFooterStartIndex+10,9,iFooterStartIndex+10,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+10,9,CComBSTR(_T("Certified that the particulars given above are true and correct.")));
			
			SmpGrid->MergeCells(iFooterStartIndex+11,9,iFooterStartIndex+11,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+11,9,CComBSTR(_T("For, ")+strShopName));
			
			SmpGrid->MergeCells(iFooterStartIndex+12,9,iFooterStartIndex+14,MaxNoOfCoumns-1);
			SmpGrid->put_CellText(iFooterStartIndex+12,9,CComBSTR(_T("Authorized Signatory :")));


		CString strExtraField1,strExtraField2;


		SmpGrid->MergeCells(iFooterStartIndex+15,0,iFooterStartIndex+15,6);

		SmpGrid->MergeCells(iFooterStartIndex+15,7,iFooterStartIndex+15,MaxNoOfCoumns-1);

		SmpGrid->MergeCells(TotalRows-5,0,TotalRows-2,MaxNoOfCoumns-1);
		SmpGridCtrl->SetCellText(TotalRows-5,0,CComBSTR("Thank You Visit Again"),DT_CENTER|DT_NOCLIP|DT_WORDBREAK);
		
		//Set the Current Tab to Report Tab
		SmpPluginTab->SetCurrentView(0);
	}

}	
 	catch(_com_error &ex)
 	
	{

		AfxMessageBox(ex.Description());
 		
 	}

 	catch(...)
 	
	{
		
		
 	}


	
}

void CSmpGridControlDlg::OnButtonSetCellImageResource() 
{
	// TODO: Add your control notification handler code here
	CString strColumnNumber,strRowNumber;
	InitializeGrid();
	m_cboCellImageExSelectColumn.GetWindowText(strColumnNumber);
	m_cboCellImageExSelectRow.GetWindowText(strRowNumber);
	int NoofColumns=ConvertToInt(strColumnNumber);
	int NoofRows=ConvertToInt(strRowNumber);
	
	SmpGridCtrl->SetCellImageEx(NoofRows,NoofColumns,IDB_BITMAP_LOGO,(long)AfxGetInstanceHandle(),48,48);
	SmpGrid->put_RowHeight(NoofRows,100);

	SmpGridCtrl->SetCellImageEx(NoofRows,NoofColumns+1,IDB_BITMAP1_ONE_MORE,(long)AfxGetInstanceHandle(),50,50);
	

	SmpPluginTab->SetCurrentView(0);
	
	
}

void CSmpGridControlDlg::OnButtonSetCellText() 
{
	// TODO: Add your control notification handler code here
	 CString strColumnNumber,strRowNumber,strCellText;
     InitializeGrid();
     m_cboCellTextColumn.GetWindowText(strColumnNumber);
	 m_cboCellTextRow.GetWindowText(strRowNumber);
	 m_strCellText.GetWindowText(strCellText);
	 int NoofColumns=ConvertToInt(strColumnNumber);
	 int NoofRows=ConvertToInt(strRowNumber);
	 SmpGridCtrl->SetCellText(NoofRows,NoofColumns,CComBSTR(strCellText),DT_CENTER|DT_WORDBREAK);
	 SmpGrid->put_RowHeight(NoofRows,50);

	 SmpPluginTab->SetCurrentView(0);

	
}

void CSmpGridControlDlg::OnButtonSetAlignment() 
{
	// TODO: Add your control notification handler code here
	CString strColumnNumber,strRowNumber;
    
     m_cboSetCellTextAlignmentColumn.GetWindowText(strColumnNumber);
	 m_cboCellTextAlignmentRow.GetWindowText(strRowNumber);
	 
	 int NoofColumns=ConvertToInt(strColumnNumber);
	 int NoofRows=ConvertToInt(strRowNumber);
	 SmpGridCtrl->SetCellTextAlignment(NoofRows,NoofColumns,DT_CENTER);
	 SmpGrid->put_RowHeight(NoofRows,50);

	 SmpPluginTab->SetCurrentView(0);
}

void CSmpGridControlDlg::OnButtonSetCellTextWrap() 
{
	// TODO: Add your control notification handler code here
		CString strColumnNumber,strRowNumber;
     //InitializeGrid();
     m_cboCellTextWrapColumn.GetWindowText(strColumnNumber);
	 m_cboCellTextWrapRow.GetWindowText(strRowNumber);
	 
	 int NoofColumns=ConvertToInt(strColumnNumber);
	 int NoofRows=ConvertToInt(strRowNumber);
	 SmpGridCtrl->SetCellTextWrap(NoofRows,NoofColumns,DT_RIGHT);
	 

	 SmpPluginTab->SetCurrentView(0);
	
}

void CSmpGridControlDlg::OnButtonSetDefaultColumnWidth() 
{
	// TODO: Add your control notification handler code here
	CString strColumnWidth;
	int columnWidth;
	InitializeGrid();
	m_strDefaultColumnWidth.GetWindowText(strColumnWidth);
	columnWidth=ConvertToInt(strColumnWidth);
	SmpGridCtrl->SetDefaultColumnWidth(columnWidth);
	SmpPluginTab->SetCurrentView(0);
	
}

void CSmpGridControlDlg::OnButtonSetDefaultRowHeight() 
{
	// TODO: Add your control notification handler code here
		CString strRowHeight;
	int RowHeight;
	InitializeGrid();
	m_strdefaultRowHeight.GetWindowText(strRowHeight);
	RowHeight=ConvertToInt(strRowHeight);
	SmpGridCtrl->SetDefaultRowHeight(RowHeight);
	 SmpPluginTab->SetCurrentView(0);
	
}

void CSmpGridControlDlg::OnButtonSetGridDisplayReadOnly() 
{
	// TODO: Add your control notification handler code here
	InitializeGrid();
	SmpGridCtrl->SetGridDisplayReadOnly(TRUE);
	SmpPluginTab->SetCurrentView(0);
	
}

void CSmpGridControlDlg::OnButtonSetWordWrapMode() 
{
	// TODO: Add your control notification handler code here
	InitializeGrid();
	SmpGridCtrl->SetWordWrapMode(DT_WORDBREAK);
	SmpPluginTab->SetCurrentView(0);
}
