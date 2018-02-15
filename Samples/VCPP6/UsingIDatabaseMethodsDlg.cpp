// UsingIDatabaseMethodsDlg.cpp : implementation file
//

#include "stdafx.h"
#include "resource.h"
#include "UsingIDatabaseMethodsDlg.h"
#include <afxdb.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CUsingIDatabaseMethodsDlg dialog


CUsingIDatabaseMethodsDlg::CUsingIDatabaseMethodsDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CUsingIDatabaseMethodsDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CUsingIDatabaseMethodsDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CUsingIDatabaseMethodsDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CUsingIDatabaseMethodsDlg)
	DDX_Control(pDX, IDC_EDIT_DB_PATH, m_editDBPath);
	DDX_Control(pDX, IDC_STATIC_STATUS, m_staticResult);
	DDX_Control(pDX, IDC_LIST_RESULT, m_listCtrlResult);
	DDX_Control(pDX, IDC_LIST_DATABASE_FIELDS, m_listDatabaseFields);
	DDX_Control(pDX, IDC_EDIT_TABLE_NAME, m_editTableName);
	DDX_Control(pDX, IDC_EDIT_FIELD_NAME, m_editFieldName);
	DDX_Control(pDX, IDC_COMBO_DATABASE_OPERATION, m_cboDatabaseOperation);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CUsingIDatabaseMethodsDlg, CDialog)
	//{{AFX_MSG_MAP(CUsingIDatabaseMethodsDlg)
	ON_BN_CLICKED(IDC_BUTTON_ADD_FIELD, OnButtonAddField)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CUsingIDatabaseMethodsDlg message handlers

void CUsingIDatabaseMethodsDlg::OnButtonAddField() 
{
	// TODO: Add your control notification handler code here
	CString strField;
	m_editFieldName.GetWindowText(strField);
	if(strField.IsEmpty())
	{
		AfxMessageBox(_T("Please Enter a field name"));
		return;
	}
	strField.TrimLeft();
	strField.TrimRight();
	m_listDatabaseFields.AddString(strField);
	m_editFieldName.SetWindowText(_T(""));
}

void CUsingIDatabaseMethodsDlg::OnOK() 
{
	// TODO: Add extra validation here
	int nCurSel=m_cboDatabaseOperation.GetCurSel();
	CString strCurSel;
	m_cboDatabaseOperation.GetLBText(nCurSel,strCurSel);
	BOOL bRet(FALSE);
	if(CBO_OPERATION_SELECT==strCurSel)
	{
		bRet=ExecuteSelectQuery();
	}
	else if(CBO_OPERATION_DELETE==strCurSel)
	{
	}
	else if(CBO_OPERATION_INSERT==strCurSel)
	{
	}
	else if(CBO_OPERATION_UPDATE==strCurSel)
	{
	}
	if(bRet)
	{
		m_staticResult.SetWindowText(_T("Query Successfully Executed"));
	}
	else
	{
		m_staticResult.SetWindowText(_T("Failed to Execute Query"));
	}
}

void CUsingIDatabaseMethodsDlg::Initialise()
{
	//IDatabase
	HRESULT hr=m_IDatabase.CoCreateInstance(CLSID_Database);
	if(FAILED(hr))
	{
		AfxMessageBox(_T("Failed to initialise IDatabase object"));
	}
	//m_cboDatabaseOperation
	m_cboDatabaseOperation.AddString(CBO_OPERATION_SELECT);
	//m_cboDatabaseOperation.AddString(CBO_OPERATION_INSERT);
	//m_cboDatabaseOperation.AddString(CBO_OPERATION_DELETE);
	//m_cboDatabaseOperation.AddString(CBO_OPERATION_UPDATE);
	m_cboDatabaseOperation.SetCurSel(0);

	//DB Type
	long lmsAcces=-1;
	m_IDatabase->get_IsMSAccess(&lmsAcces);
	if(lmsAcces!=0)
	{
		((CButton*)GetDlgItem(IDC_RADIO_MS_ACCESS))->SetCheck(TRUE);
	}
	else
	{
		((CButton*)GetDlgItem(IDC_RADIO_SQL_SERVER))->SetCheck(TRUE);
	}

	//DBPath
	BSTR dbPath;
	m_IDatabase->get_DBPath(&dbPath);
	m_editDBPath.SetWindowText(CString(dbPath));
	
}

BOOL CUsingIDatabaseMethodsDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	Initialise();
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

BOOL CUsingIDatabaseMethodsDlg::ExecuteSelectQuery()
{
	int nCnt=m_listDatabaseFields.GetCount();
	CString strQryFlds;
	for(int nIndex(0);nIndex<nCnt;nIndex++)
	{
		CString strFld;
		m_listDatabaseFields.GetText(nIndex,strFld);
		if(nIndex>0)
		{
			strQryFlds+=_T(",");
		}
		m_strFieldsArray.Add(strFld);
		strQryFlds+=strFld;
		m_listCtrlResult.InsertColumn(nIndex,strFld);
		m_listCtrlResult.SetColumnWidth(nIndex,90);
	}
	CString strSQL;
	VARIANT vResult;
	::VariantInit(&vResult);
	//Create query.
	strSQL=CBO_OPERATION_SELECT;
	strSQL+=_T(" ");
	strSQL+=strQryFlds;
	strSQL+=_T(" FROM ");
	CString strTbl;
	m_editTableName.GetWindowText(strTbl);
	strSQL+=strTbl;

	//Execute the query
	HRESULT hr=m_IDatabase->ExecuteQuery(strSQL.AllocSysString(),&vResult);
	if(FAILED(hr))
	{
		return FALSE;
	}
	FillResultsListCtrl(&vResult);
	return TRUE;
}

BOOL CUsingIDatabaseMethodsDlg::FillResultsListCtrl(VARIANT *pQueryResult)
{
	try

	{
		IDispatch* pdspRec=pQueryResult->pdispVal;
		if(pdspRec!=NULL)
		{
			VARIANT vCnn;
			::VariantInit(&vCnn);
			m_IDatabase->get_ConnectionInterface(&vCnn);
			_Recordset* QueryRecSet=(_Recordset*)pdspRec;
			if(QueryRecSet==NULL)
			{
				return FALSE;
			}

			int nRecCnt=QueryRecSet->GetRecordCount();
			VARIANT_BOOL fValue = VARIANT_FALSE;
			HRESULT hr= QueryRecSet->get_EndOfFile(&fValue);
			while(fValue != VARIANT_TRUE)
			{
				CComVariant pvarValue;
				CComPtr<Fields> pFields;
				hr = QueryRecSet->get_Fields(&pFields);
				for(int nIndex(0);nIndex<m_strFieldsArray.GetSize();nIndex++)
				{
					CComPtr<Field> pField;
					hr = pFields->get_Item(CComVariant(m_strFieldsArray.GetAt(nIndex)), &pField);
					
					hr = pField->get_Value(&pvarValue);

					CString strResult=CrackStrVariant(pvarValue);

					int nitems=m_listCtrlResult.GetItemCount();
					
					if(nIndex==0)
					{
						m_listCtrlResult.InsertItem(nitems,strResult);
					}
					else
					{
						m_listCtrlResult.SetItemText(nitems-1,nIndex,strResult);
					}

				}
				QueryRecSet->MoveNext();
				hr= QueryRecSet->get_EndOfFile(&fValue);
			}
		}
		return TRUE;
	}
	catch(_com_error &ex)
	{
		BSTR btsr=ex.Description();
		CString str(btsr);
		return FALSE;
	}
	catch(...)
	{
		DWORD dwErr=GetLastError();
		return FALSE;
	}
}


CString CUsingIDatabaseMethodsDlg::CrackStrVariant(const COleVariant& var)
{
    CString strRet;
    strRet = _T("<Unknown>");
    switch(var.vt)
	{
		case VT_EMPTY:
		case VT_NULL:
			strRet = _T("NULL");
			break;
		case VT_I2:
			strRet.Format(_T("%hd"), V_I2(&var));
			break;
		case VT_I4:
			strRet.Format(_T("%d"),V_I4(&var));
			break;
		case VT_R4:
			strRet.Format(_T("%e"), (double)V_R4(&var));
			break;
		case VT_R8:
			strRet.Format(_T("%e"), V_R8(&var));
			break;
		case VT_CY:
			strRet = COleCurrency(var).Format();
			break;
		case VT_DATE:
			strRet = COleDateTime(var).Format(_T("%c"));
			break;
		case VT_BSTR:
			strRet = V_BSTR(&var);
			break;
		case VT_DISPATCH:
			strRet = _T("VT_DISPATCH");
			break;
		case VT_ERROR:
			strRet = _T("VT_ERROR");
			break;
		case VT_BOOL:
			return ( V_BOOL(&var) ? _T("TRUE") : _T("FALSE"));
		case VT_VARIANT:
			strRet = _T("VT_VARIANT");
			break;
		case VT_UNKNOWN:
			strRet = _T("VT_UNKNOWN");
			break;
		case VT_I1:
			strRet = _T("VT_I1");
			break;
		case VT_UI1:
			strRet.Format(_T("0x%02hX"), (unsigned short)V_UI1(&var));
			break;
		case VT_UI2:
			strRet = _T("VT_UI2");
			break;
		case VT_UI4:
			strRet = _T("VT_UI4");
			break;
		case VT_I8:
			strRet = _T("VT_I8");
			break;
		case VT_UI8:
			strRet = _T("VT_UI8");
			break;
		case VT_INT:
			strRet = _T("VT_INT");
			break;
		case VT_UINT:
			strRet = _T("VT_UINT");
			break;
		case VT_VOID:
			strRet = _T("VT_VOID");
			break;
		case VT_HRESULT:
			strRet = _T("VT_HRESULT");
			break;
		case VT_PTR:
			strRet = _T("VT_PTR");
			break;
		case VT_SAFEARRAY:
			strRet = _T("VT_SAFEARRAY");
			break;
		case VT_CARRAY:
			strRet = _T("VT_CARRAY");
			break;
		case VT_USERDEFINED:
			strRet = _T("VT_USERDEFINED");
			break;
		case VT_LPSTR:
			strRet = _T("VT_LPSTR");
			break;
		case VT_LPWSTR:
			strRet = _T("VT_LPWSTR");
			break;
		case VT_FILETIME:
			strRet = _T("VT_FILETIME");
			break;
		case VT_BLOB:
			strRet = _T("VT_BLOB");
			break;
		case VT_STREAM:
			strRet = _T("VT_STREAM");
			break;
		case VT_STORAGE:
			strRet = _T("VT_STORAGE");
			break;
		case VT_STREAMED_OBJECT:
			strRet = _T("VT_STREAMED_OBJECT");
			break;
		case VT_STORED_OBJECT:
			strRet = _T("VT_STORED_OBJECT");
			break;
		case VT_BLOB_OBJECT:
			strRet = _T("VT_BLOB_OBJECT");
			break;
		case VT_CF:
			strRet = _T("VT_CF");
			break;
		case VT_CLSID:
			strRet = _T("VT_CLSID");
			break;
    }
    
	WORD vt = var.vt;
    if(vt & VT_ARRAY)
	{
        vt = vt & ~VT_ARRAY;
        strRet = _T("Array of ");
    }
    
	if(vt & VT_BYREF)
	{
        vt = vt & ~VT_BYREF;
        strRet += _T("Pointer to ");
    }
    
	if(vt != var.vt)
	{
        switch(vt)
		{
			case VT_EMPTY:
				strRet += _T("VT_EMPTY");
				break;
			case VT_NULL:
				strRet += _T("VT_NULL");
				break;
			case VT_I2:
				strRet += _T("VT_I2");
				break;
			case VT_I4:
				strRet += _T("VT_I4");
				break;
			case VT_R4:
				strRet += _T("VT_R4");
				break;
			case VT_R8:
				strRet += _T("VT_R8");
				break;
			case VT_CY:
				strRet += _T("VT_CY");
				break;
			case VT_DATE:
				strRet += _T("VT_DATE");
				break;
			case VT_BSTR:
				strRet += _T("VT_BSTR");
				break;
			case VT_DISPATCH:
				strRet += _T("VT_DISPATCH");
				break;
			case VT_ERROR:
				strRet += _T("VT_ERROR");
				break;
			case VT_BOOL:
				strRet += _T("VT_BOOL");
				break;
			case VT_VARIANT:
				strRet += _T("VT_VARIANT");
				break;
			case VT_UNKNOWN:
				strRet += _T("VT_UNKNOWN");
				break;
			case VT_I1:
				strRet += _T("VT_I1");
				break;
			case VT_UI1:
				strRet += _T("VT_UI1");
				break;
			case VT_UI2:
				strRet += _T("VT_UI2");
				break;
			case VT_UI4:
				strRet += _T("VT_UI4");
				break;
			case VT_I8:
				strRet += _T("VT_I8");
				break;
			case VT_UI8:
				strRet += _T("VT_UI8");
				break;
			case VT_INT:
				strRet += _T("VT_INT");
				break;
			case VT_UINT:
				strRet += _T("VT_UINT");
				break;
			case VT_VOID:
				strRet += _T("VT_VOID");
				break;
			case VT_HRESULT:
				strRet += _T("VT_HRESULT");
				break;
			case VT_PTR:
				strRet += _T("VT_PTR");
				break;
			case VT_SAFEARRAY:
				strRet += _T("VT_SAFEARRAY");
				break;
			case VT_CARRAY:
				strRet += _T("VT_CARRAY");
				break;
			case VT_USERDEFINED:
				strRet += _T("VT_USERDEFINED");
				break;
			case VT_LPSTR:
				strRet += _T("VT_LPSTR");
				break;
			case VT_LPWSTR:
				strRet += _T("VT_LPWSTR");
				break;
			case VT_FILETIME:
				strRet += _T("VT_FILETIME");
				break;
			case VT_BLOB:
				strRet += _T("VT_BLOB");
				break;
			case VT_STREAM:
				strRet += _T("VT_STREAM");
				break;
			case VT_STORAGE:
				strRet += _T("VT_STORAGE");
				break;
			case VT_STREAMED_OBJECT:
				strRet += _T("VT_STREAMED_OBJECT");
				break;
			case VT_STORED_OBJECT:
				strRet += _T("VT_STORED_OBJECT");
				break;
			case VT_BLOB_OBJECT:
				strRet += _T("VT_BLOB_OBJECT");
				break;
			case VT_CF:
				strRet += _T("VT_CF");
				break;
			case VT_CLSID:
				strRet += _T("VT_CLSID");
				break;
        }
    }
    
	return strRet;
}

CString CUsingIDatabaseMethodsDlg::GetDBPath()
{
	BSTR bstrDBPath;
	m_IDatabase->get_DBPath(&bstrDBPath);
	return CString(bstrDBPath);
}
