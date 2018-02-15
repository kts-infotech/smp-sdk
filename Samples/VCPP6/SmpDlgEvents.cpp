// ISmpDialogEvents Implementation
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"
#define ID_DIALOG_EDIT_STOCK_ITEM	146
#define IDD_DIALOG_MONTHLY_STATISTICS   189
#define ID_BUTTON_SDK_TEST			10001
#define ID_CHECK_BOX_SDK_TEST		10002


STDMETHODIMP CSMPCPPAddin::OnDialogWndProc(VARIANT hWndHandle, LONG lDialogID, LONG message, VARIANT wParam, VARIANT lParam, LONG lDialogeType)
{
	switch(lDialogID)
	{
	case ID_DIALOG_EDIT_STOCK_ITEM:
		{
			if(WM_INITDIALOG==message)
			{
				CWnd *edtstckdlg=NULL;
				edtstckdlg = CWnd::FromHandle((HWND)hWndHandle.byref);
				m_SDKButton->Create(_T("From SDK Test"),BS_PUSHBUTTON|WS_VISIBLE|WS_CHILD,CRect(427, 22, 547, 45),edtstckdlg,ID_BUTTON_SDK_TEST);
			}
			if(WM_COMMAND==message)
			{
				if(ID_BUTTON_SDK_TEST==LOWORD(wParam.lVal))
				{
					//Use your command hadler here
					CString strID;
					strID.Format(_T("?From SDK Test? Button Clicked"));
					strID.Replace('?','"');
					AfxMessageBox(strID);
				}
			}
		break;
		}
	case IDD_DIALOG_MONTHLY_STATISTICS:
		{
			if(WM_INITDIALOG==message)//BS_CHECKBOX
			{
				CWnd *edtstckdlg=NULL;
				edtstckdlg = CWnd::FromHandle((HWND)hWndHandle.byref);
				CRect rect;
				edtstckdlg->GetWindowRect(rect);
				rect.bottom+=30;
				edtstckdlg->MoveWindow(rect);
				CWnd * okbutton=edtstckdlg->GetDlgItem(IDOK);
				if(okbutton!=NULL)
				{
					CRect btnRect;
					okbutton->GetWindowRect(btnRect);
					btnRect.top-=40;
					btnRect.bottom-=40;
					okbutton->MoveWindow(btnRect);
				}
				else
				{
					AfxMessageBox(_T("button==NULL"));
				}
				CWnd * cancelbutton=edtstckdlg->GetDlgItem(IDCANCEL);
				if(cancelbutton!=NULL)
				{
					CRect btnRect;
					cancelbutton->GetWindowRect(btnRect);
					btnRect.top-=40;
					btnRect.bottom-=40;
					cancelbutton->MoveWindow(btnRect);
				}
				else
				{
					AfxMessageBox(_T("button==NULL"));
				}
				m_SDKCheckBox->Create(_T("From SDK Test"),BS_CHECKBOX|WS_VISIBLE|WS_CHILD|BST_UNCHECKED,CRect(rect.left+45, rect.top+250, rect.right-110, rect.bottom-120),edtstckdlg,ID_CHECK_BOX_SDK_TEST);
			}
			if(WM_COMMAND==message)
			{
				if(ID_CHECK_BOX_SDK_TEST==LOWORD(wParam.lVal))
				{
					if(m_SDKCheckBox->GetCheck())
					{
						m_SDKCheckBox->SetCheck(BST_UNCHECKED);
					}
					else
					{
						m_SDKCheckBox->SetCheck(BST_CHECKED);
					}

				}
				if(IDOK==LOWORD(wParam.lVal))
				{
					if(m_SDKCheckBox->GetCheck())
					{
						AfxMessageBox(_T("From SDK Test Checked"));
					}
					else
					{
						AfxMessageBox(_T("From SDK Test UnChecked"));
					}
				}
			}
			break;
		}
	}
	return S_OK;
}