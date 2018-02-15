/* this ALWAYS GENERATED file contains the definitions for the interfaces */


/* File created by MIDL compiler version 5.01.0164 */
/* at Wed Feb 14 17:47:00 2018
 */
/* Compiler settings for D:\SVN\KTS Projects\SalesMatePlus\Source\SDKV5\Samples\VCPP6\SDKTest.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __SDKTest_h__
#define __SDKTest_h__

#ifdef __cplusplus
extern "C"{
#endif 

/* Forward Declarations */ 

#ifndef __ISMPCPPAddin_FWD_DEFINED__
#define __ISMPCPPAddin_FWD_DEFINED__
typedef interface ISMPCPPAddin ISMPCPPAddin;
#endif 	/* __ISMPCPPAddin_FWD_DEFINED__ */


#ifndef __SMPCPPAddin_FWD_DEFINED__
#define __SMPCPPAddin_FWD_DEFINED__

#ifdef __cplusplus
typedef class SMPCPPAddin SMPCPPAddin;
#else
typedef struct SMPCPPAddin SMPCPPAddin;
#endif /* __cplusplus */

#endif 	/* __SMPCPPAddin_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

void __RPC_FAR * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void __RPC_FAR * ); 

#ifndef __ISMPCPPAddin_INTERFACE_DEFINED__
#define __ISMPCPPAddin_INTERFACE_DEFINED__

/* interface ISMPCPPAddin */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_ISMPCPPAddin;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("7B99B3C8-DF79-42DD-984D-85453CDFA989")
    ISMPCPPAddin : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GenericReportUsingMethod( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GenericReportUsingAttribute( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIAccountsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingICustomerInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIDatabaseMethods( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIGridInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIISmpCommandsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIItemInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingIReportsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISalesCheckoutInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISecurityInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISettingsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpAppInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpFileMenuOperationsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpFrameInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpHelpInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpPluginTabInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpReceiptSettingsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpReportInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpReportMenuInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpReportSettingsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpSetupInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpStockInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpUserInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpViewInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingITransactionsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpOEMInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpOEMEventsInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingSmpGridControlMethod( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingSmpGridInterface( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE UsingISmpSettingsExInterface( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct ISMPCPPAddinVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            ISMPCPPAddin __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            ISMPCPPAddin __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            ISMPCPPAddin __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            ISMPCPPAddin __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            ISMPCPPAddin __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GenericReportUsingMethod )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GenericReportUsingAttribute )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIAccountsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingICustomerInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIDatabaseMethods )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIGridInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIISmpCommandsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIItemInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingIReportsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISalesCheckoutInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISecurityInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISettingsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpAppInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpFileMenuOperationsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpFrameInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpHelpInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpPluginTabInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpReceiptSettingsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpReportInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpReportMenuInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpReportSettingsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpSetupInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpStockInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpUserInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpViewInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingITransactionsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpOEMInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpOEMEventsInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingSmpGridControlMethod )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingSmpGridInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *UsingISmpSettingsExInterface )( 
            ISMPCPPAddin __RPC_FAR * This);
        
        END_INTERFACE
    } ISMPCPPAddinVtbl;

    interface ISMPCPPAddin
    {
        CONST_VTBL struct ISMPCPPAddinVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ISMPCPPAddin_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define ISMPCPPAddin_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define ISMPCPPAddin_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define ISMPCPPAddin_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define ISMPCPPAddin_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define ISMPCPPAddin_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define ISMPCPPAddin_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define ISMPCPPAddin_GenericReportUsingMethod(This)	\
    (This)->lpVtbl -> GenericReportUsingMethod(This)

#define ISMPCPPAddin_GenericReportUsingAttribute(This)	\
    (This)->lpVtbl -> GenericReportUsingAttribute(This)

#define ISMPCPPAddin_UsingIAccountsInterface(This)	\
    (This)->lpVtbl -> UsingIAccountsInterface(This)

#define ISMPCPPAddin_UsingICustomerInterface(This)	\
    (This)->lpVtbl -> UsingICustomerInterface(This)

#define ISMPCPPAddin_UsingIDatabaseMethods(This)	\
    (This)->lpVtbl -> UsingIDatabaseMethods(This)

#define ISMPCPPAddin_UsingIGridInterface(This)	\
    (This)->lpVtbl -> UsingIGridInterface(This)

#define ISMPCPPAddin_UsingIISmpCommandsInterface(This)	\
    (This)->lpVtbl -> UsingIISmpCommandsInterface(This)

#define ISMPCPPAddin_UsingIItemInterface(This)	\
    (This)->lpVtbl -> UsingIItemInterface(This)

#define ISMPCPPAddin_UsingIReportsInterface(This)	\
    (This)->lpVtbl -> UsingIReportsInterface(This)

#define ISMPCPPAddin_UsingISalesCheckoutInterface(This)	\
    (This)->lpVtbl -> UsingISalesCheckoutInterface(This)

#define ISMPCPPAddin_UsingISecurityInterface(This)	\
    (This)->lpVtbl -> UsingISecurityInterface(This)

#define ISMPCPPAddin_UsingISettingsInterface(This)	\
    (This)->lpVtbl -> UsingISettingsInterface(This)

#define ISMPCPPAddin_UsingISmpAppInterface(This)	\
    (This)->lpVtbl -> UsingISmpAppInterface(This)

#define ISMPCPPAddin_UsingISmpFileMenuOperationsInterface(This)	\
    (This)->lpVtbl -> UsingISmpFileMenuOperationsInterface(This)

#define ISMPCPPAddin_UsingISmpFrameInterface(This)	\
    (This)->lpVtbl -> UsingISmpFrameInterface(This)

#define ISMPCPPAddin_UsingISmpHelpInterface(This)	\
    (This)->lpVtbl -> UsingISmpHelpInterface(This)

#define ISMPCPPAddin_UsingISmpPluginTabInterface(This)	\
    (This)->lpVtbl -> UsingISmpPluginTabInterface(This)

#define ISMPCPPAddin_UsingISmpReceiptSettingsInterface(This)	\
    (This)->lpVtbl -> UsingISmpReceiptSettingsInterface(This)

#define ISMPCPPAddin_UsingISmpReportInterface(This)	\
    (This)->lpVtbl -> UsingISmpReportInterface(This)

#define ISMPCPPAddin_UsingISmpReportMenuInterface(This)	\
    (This)->lpVtbl -> UsingISmpReportMenuInterface(This)

#define ISMPCPPAddin_UsingISmpReportSettingsInterface(This)	\
    (This)->lpVtbl -> UsingISmpReportSettingsInterface(This)

#define ISMPCPPAddin_UsingISmpSetupInterface(This)	\
    (This)->lpVtbl -> UsingISmpSetupInterface(This)

#define ISMPCPPAddin_UsingISmpStockInterface(This)	\
    (This)->lpVtbl -> UsingISmpStockInterface(This)

#define ISMPCPPAddin_UsingISmpUserInterface(This)	\
    (This)->lpVtbl -> UsingISmpUserInterface(This)

#define ISMPCPPAddin_UsingISmpViewInterface(This)	\
    (This)->lpVtbl -> UsingISmpViewInterface(This)

#define ISMPCPPAddin_UsingITransactionsInterface(This)	\
    (This)->lpVtbl -> UsingITransactionsInterface(This)

#define ISMPCPPAddin_UsingISmpOEMInterface(This)	\
    (This)->lpVtbl -> UsingISmpOEMInterface(This)

#define ISMPCPPAddin_UsingISmpOEMEventsInterface(This)	\
    (This)->lpVtbl -> UsingISmpOEMEventsInterface(This)

#define ISMPCPPAddin_UsingSmpGridControlMethod(This)	\
    (This)->lpVtbl -> UsingSmpGridControlMethod(This)

#define ISMPCPPAddin_UsingSmpGridInterface(This)	\
    (This)->lpVtbl -> UsingSmpGridInterface(This)

#define ISMPCPPAddin_UsingISmpSettingsExInterface(This)	\
    (This)->lpVtbl -> UsingISmpSettingsExInterface(This)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_GenericReportUsingMethod_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_GenericReportUsingMethod_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_GenericReportUsingAttribute_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_GenericReportUsingAttribute_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIAccountsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIAccountsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingICustomerInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingICustomerInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIDatabaseMethods_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIDatabaseMethods_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIGridInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIGridInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIISmpCommandsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIISmpCommandsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIItemInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIItemInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingIReportsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingIReportsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISalesCheckoutInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISalesCheckoutInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISecurityInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISecurityInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISettingsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISettingsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpAppInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpAppInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpFileMenuOperationsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpFileMenuOperationsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpFrameInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpFrameInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpHelpInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpHelpInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpPluginTabInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpPluginTabInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpReceiptSettingsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpReceiptSettingsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpReportInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpReportInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpReportMenuInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpReportMenuInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpReportSettingsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpReportSettingsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpSetupInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpSetupInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpStockInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpStockInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpUserInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpUserInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpViewInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpViewInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingITransactionsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingITransactionsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpOEMInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpOEMInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpOEMEventsInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpOEMEventsInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingSmpGridControlMethod_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingSmpGridControlMethod_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingSmpGridInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingSmpGridInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ISMPCPPAddin_UsingISmpSettingsExInterface_Proxy( 
    ISMPCPPAddin __RPC_FAR * This);


void __RPC_STUB ISMPCPPAddin_UsingISmpSettingsExInterface_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __ISMPCPPAddin_INTERFACE_DEFINED__ */



#ifndef __SDKTESTLib_LIBRARY_DEFINED__
#define __SDKTESTLib_LIBRARY_DEFINED__

/* library SDKTESTLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_SDKTESTLib;

EXTERN_C const CLSID CLSID_SMPCPPAddin;

#ifdef __cplusplus

class DECLSPEC_UUID("6E58B088-98BA-4AA9-B124-006AA96D9DF0")
SMPCPPAddin;
#endif
#endif /* __SDKTESTLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif
