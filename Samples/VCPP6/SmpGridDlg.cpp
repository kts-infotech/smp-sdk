// SmpGridDlg.cpp : implementation file
//

#include "stdafx.h"
#include "sdktest.h"
#include "SmpGridDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSmpGridDlg dialog


CSmpGridDlg::CSmpGridDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmpGridDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSmpGridDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CSmpGridDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSmpGridDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSmpGridDlg, CDialog)
	//{{AFX_MSG_MAP(CSmpGridDlg)
	ON_BN_CLICKED(IDC_BUTTON_AUTOSIZE, OnButtonAutosize)
	ON_BN_CLICKED(IDC_BUTTON_SET_AUTOSIZE_STYLE, OnButtonSetAutosizeStyle)
	ON_BN_CLICKED(IDC_BUTTON_SET_FOCUS_CELL, OnButtonSetFocusCell)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSmpGridDlg message handlers

BOOL CSmpGridDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	// TODO: Add extra initialization here

	
	HRESULT hr=S_OK;


	hr =SmpGrid.CoCreateInstance(CLSID_Grid);
	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("SmpGrid is Not Implemented on the Installed Version of SalesMate + ."));

		return FALSE;
	}

	hr =SmpGridCtrl.CoCreateInstance(CLSID_SmpGridCtrl);
	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("ISmpGridCtrl is Not Implemented on the Installed Version of SalesMate + . Please use the Latest Version of SalesMate + Application"));

		return FALSE;
	}

	hr =Grid.CoCreateInstance(CLSID_SmpGrid);
	if(!SUCCEEDED(hr))
	{
		AfxMessageBox(_T("SmpGrid is Not Implemented on the Installed Version of SalesMate + ."));

		return FALSE;
	}

	hr =SmpPluginTab.CoCreateInstance(CLSID_SmpPluginTab);

	if(!SUCCEEDED(hr))
	{
        AfxMessageBox(_T("SmpPluginTab is Not Implemented on the Installed Version of SalesMate + ."));

		return FALSE;
	}

	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSmpGridDlg::OnButtonAutosize() 
{
	// TODO: Add your control notification handler code here
     HRESULT hr=S_OK;

	SmpGridCtrl->DeleteAllItems();
   
    int iRows=17;
	int iCoumns=6;
	
	 
	SmpGrid->put_NoOfRows(iRows);

	SmpGrid->put_NoOfColumns(iCoumns);
	
	//Put the folumn width
	for(int i=0;i<iCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,200);
	}
    
    SmpGridCtrl->SetCellText(3,2,CComBSTR("Test"),DT_CENTER|DT_WORDBREAK);
    SmpGridCtrl->SetCellText(4,2,CComBSTR("Kts Infotech"),DT_CENTER|DT_WORDBREAK);
    SmpGridCtrl->SetCellText(5,4,CComBSTR("SalesMate Plus"),DT_CENTER|DT_WORDBREAK);
    SmpGridCtrl->SetCellText(8,3,CComBSTR("Sample Text"),DT_CENTER|DT_WORDBREAK); 

     SmpGridCtrl->AutoSize();

	
	//Set the Current Tab to Report Tab
	SmpPluginTab->SetCurrentView(0);


}


void CSmpGridDlg::OnButtonSetAutosizeStyle() 
{
	// TODO: Add your control notification handler code here

    HRESULT hr=S_OK;

    SmpGridCtrl->DeleteAllItems();
   
    int iRows=12;
	int iCoumns=6;
	
	 
	SmpGrid->put_NoOfRows(iRows);

	SmpGrid->put_NoOfColumns(iCoumns);
	
	//Put the folumn width
	for(int i=0;i<iCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,200);
	}

	SmpGridCtrl->SetCellText(3,2,CComBSTR("Test"),DT_CENTER|DT_WORDBREAK);

    
	Grid->SetAutoSizeStyle(48);

	SmpPluginTab->SetCurrentView(0);
	
}

void CSmpGridDlg::OnButtonSetFocusCell() 
{
	// TODO: Add your control notification handler code here
   
	 HRESULT hr=S_OK;

	SmpGridCtrl->DeleteAllItems();
   
    int iRows=10;
	int iCoumns=8;
	
	 
	SmpGrid->put_NoOfRows(iRows);

	SmpGrid->put_NoOfColumns(iCoumns);
	
	//Put the folumn width
	for(int i=0;i<iCoumns;i++)
	{
		SmpGrid->put_ColumnWidth(i,200);
	}

	Grid->SetFocusCell(3,3);

    SmpPluginTab->SetCurrentView(0);

	
}
