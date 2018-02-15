// SMPCPPAddin.cpp : Implementation of CSMPCPPAddin
#include "stdafx.h"
#include "SDKTest.h"
#include "SMPCPPAddin.h"
#include "SMPReceptSettingsDlg.h"
#include "GenericReportDirectMehodDlg.h"
#include "GenericReportUsingAttribDlg.h"
#include "UsingIAccountsInterfaceDlg.h"
#include "UsingISmpViewInterfaceDlg.h"
#include "UsingICustomerInterfaceDlg.h"
#include "SMPHelpDlg.h"
#include "UsingIDatabaseMethodsDlg.h"
#include "SecurityinterfaceDlg.h"
#include "SMPSetupDlg.h"
#include "SMPStockDlg.h"
#include "SMPUserSettingsDlg.h"
#include "Smpfilemenuoperationinterface.h"
#include "SettingsinterfaceDlg.h"
#include "SmpframeDlg.h"
#include "UsingISmpCommands.h"
#include "SmpReportDlg.h"
#include "ReportDlg.h"
#include "Transaction.h"
#include "SmpReportSettingsDlg.h"
#include "SmpReportMenuDlg.h"
#include "ISalesCheckoutDlg.h"
#include "IItemDlg.h"
#include "SmpappinterfaceDlg.h"
#include "SMPPluginTabDlg.h"
#include "ReportUsingGridInterface.h"
#include "SmpOEMDlg.h"
#include "SmpOEMEventsDlg.h"
#include "SmpGridDlg.h"
#include "SmpSettingsExDlg.h"
/////////////////////////////////////////////////////////////////////////////
// CSMPCPPAddin


STDMETHODIMP CSMPCPPAddin::GenericReportUsingMethod()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CGenericReportDirectMehodDlg GenericReportDirectMehodDlg;

	GenericReportDirectMehodDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::GenericReportUsingAttribute()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CGenericReportUsingAttribDlg GenericReportUsingAttribDlg;

	GenericReportUsingAttribDlg.DoModal();

	return S_OK;
}

BOOL CSMPCPPAddin::LoadLongResource(CString &str, UINT nID)
{
		try
		{
			HRSRC               hRes;
			BOOL                bResult            = FALSE;
		
			//if you want standard HTML type
			hRes = FindResource(AfxGetInstanceHandle(), MAKEINTRESOURCE(nID), RT_HTML);
			if (hRes == NULL)
			{
				//trace error
				str = _T("Error: Resource could not be found\r\n");
			}
			else
			{
				DWORD dwSize = SizeofResource(AfxGetInstanceHandle(), hRes);
				if (dwSize == 0)
				{
					str.Empty();
					bResult = TRUE;
				}
				else
				{
					HGLOBAL hGlob = LoadResource(AfxGetInstanceHandle(), hRes);
					if (hGlob != NULL)
					{
						LPVOID lpData = LockResource(hGlob);
						if (lpData != NULL)
						{
							str            = (LPCSTR)lpData;
							bResult        = TRUE;
						}
						FreeResource(hGlob);
					}
				}
				if (!bResult)
				str = _T("Error: Resource could not be load\r\n");
			}
			return bResult;
		}
		catch(CResourceException* ex)
		{
			ex->Delete();
			return FALSE;
		}
		catch(...)
		{
			return FALSE;
		}

}

STDMETHODIMP CSMPCPPAddin::UsingIAccountsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	// TODO: Add your implementation code here
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingIAccountsInterface()"));
	CUsingIAccountsInterfaceDlg IAccountsInterfaceDlg;
	IAccountsInterfaceDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingICustomerInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	UsingICustomerInterfaceDlg ICustomerInterfaceDlg;
	ICustomerInterfaceDlg.DoModal();
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingICustomerInterface()"));
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingIDatabaseMethods()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CUsingIDatabaseMethodsDlg UsingIDatabaseMethodsDlg;
	UsingIDatabaseMethodsDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingIGridInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CReportUsingGridInterface ReportUsingGridInterface;

	ReportUsingGridInterface.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingIISmpCommandsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CUsingISMPCommands m_UsingISmpCommandsDlg;
	m_UsingISmpCommandsDlg.DoModal();
	// TODO: Add your implementation code here
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingIISmpCommandsInterface()"));
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingIItemInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CIItemDlg IItemDlg;
	IItemDlg.DoModal();
	// TODO: Add your implementation code here
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingIItemInterface()"));
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingIReportsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingIReportsInterface()"));
	// TODO: Add your implementation code here
    CReportDlg objCReportDlg;
	objCReportDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISalesCheckoutInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CISalesCheckoutDlg ISalesCheckoutDlg;
	ISalesCheckoutDlg.DoModal();

	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingISalesCheckoutInterface()"));
	// TODO: Add your implementation code here

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISecurityInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CSecurityinterfaceDlg m_SecurityinterfaceDlg;
	m_SecurityinterfaceDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISettingsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CSettingsinterfaceDlg m_SettingsinterfaceDlg;
	m_SettingsinterfaceDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpAppInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSmpappinterfaceDlg  m_SmpappinterfaceDlg;
	m_SmpappinterfaceDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpFileMenuOperationsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

	CSmpfilemenuoperationinterface m_Smpfilemenuoperationinterface;
	m_Smpfilemenuoperationinterface.DoModal();

/*	CSmpfilemenuoperationinterface m_Smpfilemenuoperationinterface;
	if(IDOK==m_Smpfilemenuoperationinterface.DoModal())
	{
		//m_Smpfilemenuoperationinterface.m_ISmpFileMenuOperations->InvokeExit();
		CComPtr<ISmpFileMenuOperations>ISmpFileMenuOperations;
		HRESULT hr = ISmpFileMenuOperations.CoCreateInstance(CLSID_SmpFileMenuOperations);
		ISmpFileMenuOperations->InvokeExit();
	}*/


	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpFrameInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSmpframeDlg m_SmpframeDlg;
	m_SmpframeDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpHelpInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSMPHelpDlg m_SMPHelpDlg;
    m_SMPHelpDlg.DoModal();
	// TODO: Add your implementation code here
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpPluginTabInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
    CSMPPluginTabDlg m_SMPPluginTab;
    m_SMPPluginTab.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpReceiptSettingsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingISmpReceiptSettingsInterface()"));
	// TODO: Add your implementation code here
	CSMPReceptSettingsDlg m_SMPReceptSettingsDlg;
	m_SMPReceptSettingsDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpReportInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingISmpReportInterface()"));
	// TODO: Add your implementation code here
    CSmpReportDlg objCSmpReportDlg;
	objCSmpReportDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpReportMenuInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingISmpReportMenuInterface()"));
	// TODO: Add your implementation code here
    CSmpReportMenuDlg objCSmpReportMenuDlg;
	objCSmpReportMenuDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpReportSettingsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingISmpReportSettingsInterface()"));
	// TODO: Add your implementation code here
    CSmpReportSettingsDlg objCSmpReportSettingsDlg;
	objCSmpReportSettingsDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpSetupInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSMPSetupDlg m_SMPSetupDlg;
    m_SMPSetupDlg.DoModal();

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpStockInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
    CSMPStockDlg m_SMPStockDlg;
    m_SMPStockDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpUserInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSMPUserSettingsDlg m_SMPUserSettingsDlg;
    m_SMPUserSettingsDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpViewInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	// TODO: Add your implementation code here
	CUsingISmpViewInterfaceDlg UsingISmpViewInterfaceDlg;
	UsingISmpViewInterfaceDlg.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingITransactionsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	//AfxMessageBox(_T("STDMETHODIMP CSMPCPPAddin::UsingITransactionsInterface()"));
	// TODO: Add your implementation code here
    CTransaction objCTransaction;
	objCTransaction.DoModal();
	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingSmpGridControlMethod()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
 CSmpGridControlDlg objSmpGridcontrol;
	objSmpGridcontrol.DoModal();
	// TODO: Add your implementation code here

	return S_OK;
}

//DEL STDMETHODIMP CSMPCPPAddin::AutoSize()
//DEL {
//DEL 	AFX_MANAGE_STATE(AfxGetStaticModuleState())
//DEL     
//DEL 	// TODO: Add your implementation code here
//DEL 
//DEL 	return S_OK;
//DEL }

STDMETHODIMP CSMPCPPAddin::UsingISmpOEMInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
		CSmpOEMDlg objSmpOEMDlg;
	    objSmpOEMDlg.DoModal();


	// TODO: Add your implementation code here

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpOEMEventsInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
		CSmpOEMEventsDlg objSmpOEMEventsDlg;
	     objSmpOEMEventsDlg.DoModal();
	   

	// TODO: Add your implementation code here

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingSmpGridInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())

		CSmpGridDlg objSmpGrid;
	    objSmpGrid.DoModal();

	// TODO: Add your implementation code here

	return S_OK;
}

STDMETHODIMP CSMPCPPAddin::UsingISmpSettingsExInterface()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState())
	CSmpSettingsExDlg objSmpSettingsExDlg;
	objSmpSettingsExDlg.DoModal();
	return S_OK;
}
