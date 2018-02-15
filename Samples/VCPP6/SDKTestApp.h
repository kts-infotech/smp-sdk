#if !defined SDK_TEST_APP_H
#define SDK_TEST_APP_H
#include "Resource.h"

class CSDKTestApp : public CWinApp
{
public:
	LONG m_lSessionID;
	IDispatch *m_SmpApp;	

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSDKTestApp)
	public:
    virtual BOOL InitInstance();
    virtual int ExitInstance();
	//}}AFX_VIRTUAL

	//{{AFX_MSG(CSDKTestApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};
#endif