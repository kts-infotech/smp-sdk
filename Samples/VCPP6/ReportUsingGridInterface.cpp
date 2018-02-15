// ReportUsingGridInterface.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "resource.h"
#include "ReportUsingGridInterface.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CReportUsingGridInterface dialog


CReportUsingGridInterface::CReportUsingGridInterface(CWnd* pParent /*=NULL*/)
	: CDialog(CReportUsingGridInterface::IDD, pParent)
{
	//{{AFX_DATA_INIT(CReportUsingGridInterface)
	m_bCellColor = FALSE;
	m_bCellFont = FALSE;
	m_bFontSize = FALSE;
	m_bFontType = FALSE;
	m_bReadOnly = FALSE;
	m_bUpdateCol = FALSE;
	m_bUpdateRow = FALSE;
	//}}AFX_DATA_INIT
}


void CReportUsingGridInterface::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CReportUsingGridInterface)
	DDX_Control(pDX, IDC_EDIT_CELL_TEXT, m_editCellText);
	DDX_Control(pDX, IDC_COMBO_ROW_HEIGHT, m_cboRowHeight);
	DDX_Control(pDX, IDC_COMBO_ROW, m_cboRow);
	DDX_Control(pDX, IDC_COMBO_NO_OF_ROWS, m_cboNoOfRows);
	DDX_Control(pDX, IDC_COMBO_NO_OF_FIXED_ROWS, m_cboNoOfFixedRows);
	DDX_Control(pDX, IDC_COMBO_NO_OF_FIXED_COLS, m_cboNoOfFixedCols);
	DDX_Control(pDX, IDC_COMBO_NO_OF_COLS, m_cboNoOfCols);
	DDX_Control(pDX, IDC_COMBO_INSERT_OR_DELETE_ROW, m_cboInsOrDelRow);
	DDX_Control(pDX, IDC_COMBO_INSERT_OR_DELETE_COL, m_cboInsOrDelCol);
	DDX_Control(pDX, IDC_COMBO_VERTICAL_GRID_LINE, m_cboVerticalGridLine);
	DDX_Control(pDX, IDC_COMBO_HORIZONTAL_GRID_LINE, m_cboHorizontalGridLine);
	DDX_Control(pDX, IDC_COMBO_COL_WIDTH, m_cboColWidth);
	DDX_Control(pDX, IDC_COMBO_COL, m_cboCol);
	DDX_Control(pDX, IDC_COMBO_CELL_TEXT_COLOR, m_cboCellTextColor);
	DDX_Control(pDX, IDC_COMBO_CELL_FONT_TYPE, m_cboCellFontType);
	DDX_Control(pDX, IDC_COMBO_CELL_FONT_SIZE, m_cboCellFontSize);
	DDX_Control(pDX, IDC_COMBO_CELL_FONT, m_cboCellFont);
	DDX_Control(pDX, IDC_COMBO_CELL_COLOR, m_cboCellColor);
	DDX_Check(pDX, IDC_CHECK_CELL_COLOR, m_bCellColor);
	DDX_Check(pDX, IDC_CHECK_CELL_FONT, m_bCellFont);
	DDX_Check(pDX, IDC_CHECK_FONT_SIZE, m_bFontSize);
	DDX_Check(pDX, IDC_CHECK_FONT_TYPE, m_bFontType);
	DDX_Check(pDX, IDC_CHECK_READ_ONLY, m_bReadOnly);
	DDX_Check(pDX, IDC_CHECK_UPDATE_COL, m_bUpdateCol);
	DDX_Check(pDX, IDC_CHECK_UPDATE_ROW, m_bUpdateRow);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CReportUsingGridInterface, CDialog)
	//{{AFX_MSG_MAP(CReportUsingGridInterface)
	ON_BN_CLICKED(IDC_BUTTON_DELETE, OnButtonDelete)
	ON_BN_CLICKED(IDC_BUTTON_INSERT, OnButtonInsert)
	ON_BN_CLICKED(IDC_CHECK_UPDATE_ROW, OnCheckUpdateRow)
	ON_BN_CLICKED(IDC_CHECK_UPDATE_COL, OnCheckUpdateCol)
	ON_BN_CLICKED(IDC_CHECK_CELL_COLOR, OnCheckCellColor)
	ON_BN_CLICKED(IDC_CHECK_CELL_FONT, OnCheckCellFont)
	ON_BN_CLICKED(IDC_CHECK_FONT_SIZE, OnCheckFontSize)
	ON_BN_CLICKED(IDC_CHECK_FONT_TYPE, OnCheckFontType)
	ON_BN_CLICKED(IDC_CHECK_READ_ONLY, OnCheckReadOnly)
	
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CReportUsingGridInterface message handlers

void CReportUsingGridInterface::OnButtonDelete() 
{
	CComPtr<IGrid>m_Grid; 

	HRESULT hr = m_Grid.CoCreateInstance(CLSID_Grid);

	if(SUCCEEDED(hr))
	{
		m_Grid->DeleteRow(ConvertToInt(m_strRow));

		m_Grid->DeleteColumn(ConvertToInt(m_strCol));
	}

	
}

void CReportUsingGridInterface::OnButtonInsert() 
{
	CComPtr<IGrid>m_Grid; 

	HRESULT hr = m_Grid.CoCreateInstance(CLSID_Grid);

	if(SUCCEEDED(hr))
	{
		m_Grid->InsertRow(ConvertToInt(m_strRow));

		m_Grid->InsertColumn(ConvertToInt(m_strCol));
	}
	
}

void CReportUsingGridInterface::OnCancel() 
{
	// TODO: Add extra cleanup here
	
	CDialog::OnCancel();
}

void CReportUsingGridInterface::OnOK() 
{

	COLORREF BackColor = RGB(10,100,20);
	OLE_COLOR BackgroundColor = RGB(255,153,0);

	OLE_COLOR ForgroundColor_Red = RGB(255,0,0); //RED
	OLE_COLOR ForgroundColor_Green = RGB(35,115,50);//GREEN
	OLE_COLOR ForgroundColor_Blue = RGB(16,36,230);//BLUE

	UpdateData();

	FillValues();
	
	CComPtr<IReports>m_Reports;

	CComPtr<IGrid>m_Grid; 

	HRESULT hr = m_Grid.CoCreateInstance(CLSID_Grid);

	if(SUCCEEDED(hr))
	{
		m_Grid->ResetGrid();

		if(m_bCellFont)
			m_Grid->put_CellFont(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ConvertToInt(m_strCellFont));
	
		if(m_bFontSize)
			m_Grid->put_CellFontSize(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ConvertToInt(m_strCellFontSize));

		if(m_bFontType)
			m_Grid->put_CellFontType(ConvertToInt(m_strRow),ConvertToInt(m_strCol),m_strCellFontType.AllocSysString());
		
		m_Grid->put_CellText(ConvertToInt(m_strRow),ConvertToInt(m_strCol),m_strCellText.AllocSysString());


		m_Grid->put_NoOfColumns(ConvertToInt(m_strNoOfCols));

		m_Grid->put_NoOfFixedColumns(ConvertToInt(m_strNoOfFixedCols));

		m_Grid->put_NoOfFixedRows(ConvertToInt(m_strNoOfFixedRows));

		m_Grid->put_NoOfRows(ConvertToInt(m_strNoOfRows));

		m_Grid->put_ReadOnly(m_bReadOnly);

		m_Grid->put_RowHeight(ConvertToInt(m_strRow),ConvertToInt(m_strRowHeight));	

		m_Grid->put_ColumnWidth(ConvertToInt(m_strCol),ConvertToInt(m_strColWidth));

		
		
		if(m_strCellColor == _T("RED"))
			m_Grid->put_CellColour(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ForgroundColor_Red);			
						
		else if(m_strCellColor == _T("GREEN"))
			m_Grid->put_CellColour(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ForgroundColor_Green);						

		else
			m_Grid->put_CellColour(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ForgroundColor_Blue);


		m_Grid->UnmergeCells(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ConvertToInt(m_strRow)+1,ConvertToInt(m_strCol)+1);


		m_Grid->MergeCells(ConvertToInt(m_strRow),ConvertToInt(m_strCol),ConvertToInt(m_strRow)+1,ConvertToInt(m_strCol)+1);
		
	
	}
	
	CDialog::OnOK();
}

void CReportUsingGridInterface::FillValues()
{

	m_cboCellColor.GetWindowText(m_strCellColor);

	m_cboCellFont.GetWindowText(m_strCellFont);

	m_cboCellFontSize.GetWindowText(m_strCellFontSize);

	m_cboCellFontType.GetWindowText(m_strCellFontType);

	m_cboCellTextColor.GetWindowText(m_strCellTextColor);

	m_cboCol.GetWindowText(m_strCol);

	m_cboColWidth.GetWindowText(m_strColWidth);

	m_cboHorizontalGridLine.GetWindowText(m_strHorizontalGridLine);

	m_cboInsOrDelCol.GetWindowText(m_strInsOrDelCol);

	m_cboInsOrDelRow.GetWindowText(m_strInsOrDelRow);	

	m_cboNoOfCols.GetWindowText(m_strNoOfCols);

	m_cboNoOfFixedCols.GetWindowText(m_strNoOfFixedCols);	

	m_cboNoOfFixedRows.GetWindowText(m_strNoOfFixedRows);

	m_cboNoOfRows.GetWindowText(m_strNoOfRows);	

	m_cboRow.GetWindowText(m_strRow);	

	m_cboRowHeight.GetWindowText(m_strRowHeight);	

	m_cboVerticalGridLine.GetWindowText(m_strVerticalGridLine);	

	m_editCellText.GetWindowText(m_strCellText);	

	}

void CReportUsingGridInterface::InitializeComboBoxes()
{
	CString strNumber , strAlignment;

	for(int iCount=0;iCount<=50;iCount++)
	{
		strNumber.Format(_T("%d"),iCount);			

		m_cboCellFontSize.InsertString(iCount,strNumber); 

		m_cboCol.InsertString(iCount,strNumber); 

		m_cboColWidth.InsertString(iCount,strNumber); 

		m_cboInsOrDelCol.InsertString(iCount,strNumber); 

		m_cboInsOrDelRow.InsertString(iCount,strNumber); 

		m_cboNoOfCols.InsertString(iCount,strNumber); 

		m_cboNoOfFixedCols.InsertString(iCount,strNumber); 

		m_cboNoOfFixedRows.InsertString(iCount,strNumber); 

		m_cboNoOfRows.InsertString(iCount,strNumber); 

		m_cboRow.InsertString(iCount,strNumber); 

		m_cboRowHeight.InsertString(iCount,strNumber); 
	}

	m_cboCellColor.InsertString(0,_T("RED"));
	m_cboCellColor.InsertString(1,_T("GREEN"));
	m_cboCellColor.InsertString(2,_T("BLUE"));

	m_cboCellTextColor.InsertString(0,_T("RED"));
	m_cboCellTextColor.InsertString(1,_T("GREEN"));
	m_cboCellTextColor.InsertString(2,_T("BLUE"));

	m_cboCellFont.InsertString(0,_T("Times New Roman"));
	m_cboCellFont.InsertString(0,_T("Comic Sans MS"));
	m_cboCellFont.InsertString(0,_T("Verdana"));
	m_cboCellFont.InsertString(0,_T("Book Antiqua"));
	m_cboCellFont.InsertString(0,_T("Impact"));


}

BOOL CReportUsingGridInterface::OnInitDialog() 
{
	CDialog::OnInitDialog();

	DisableControls();
	
	InitializeComboBoxes();
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

int CReportUsingGridInterface::ConvertToInt(CString strValue)
{
#ifdef _UNICODE

	 return _ttoi(strValue) ;
#else

	return (int) atoi(strValue);
#endif

}

void CReportUsingGridInterface::OnCheckUpdateRow() 
{
	UpdateData();
	m_cboInsOrDelRow.EnableWindow(m_bUpdateRow);    
	
}

void CReportUsingGridInterface::OnCheckUpdateCol() 
{
	UpdateData();
	m_cboInsOrDelCol.EnableWindow(m_bUpdateCol);    
	
}

void CReportUsingGridInterface::OnCheckCellColor() 
{
	UpdateData();
	m_cboCellColor.EnableWindow(m_bCellColor);    
	
}

void CReportUsingGridInterface::OnCheckCellFont() 
{
	UpdateData();
	m_cboCellFont.EnableWindow(m_bCellFont);    

}

void CReportUsingGridInterface::OnCheckFontSize() 
{
	UpdateData();
	m_cboCellFontSize.EnableWindow(m_bFontSize);    

}

void CReportUsingGridInterface::OnCheckFontType() 
{
	UpdateData();
	m_cboCellFontType.EnableWindow(m_bFontType);  

}

void CReportUsingGridInterface::OnCheckReadOnly() 
{
	
}

void CReportUsingGridInterface::DisableControls()
{
	m_cboInsOrDelRow.EnableWindow(FALSE); 
	
	m_cboInsOrDelCol.EnableWindow(FALSE);    

	m_cboCellColor.EnableWindow(FALSE);   
	
	m_cboCellFont.EnableWindow(FALSE);   
		
	m_cboCellFontSize.EnableWindow(FALSE);  

	m_cboCellFontType.EnableWindow(FALSE);
}


