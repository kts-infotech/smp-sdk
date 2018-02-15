# Microsoft Developer Studio Project File - Name="SDKTest" - Package Owner=<4>
# Microsoft Developer Studio Generated Build File, Format Version 6.00
# ** DO NOT EDIT **

# TARGTYPE "Win32 (x86) Dynamic-Link Library" 0x0102

CFG=SDKTest - Win32 Debug
!MESSAGE This is not a valid makefile. To build this project using NMAKE,
!MESSAGE use the Export Makefile command and run
!MESSAGE 
!MESSAGE NMAKE /f "SDKTest.mak".
!MESSAGE 
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE 
!MESSAGE NMAKE /f "SDKTest.mak" CFG="SDKTest - Win32 Debug"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "SDKTest - Win32 Debug" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "SDKTest - Win32 Unicode Debug" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "SDKTest - Win32 Release MinSize" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "SDKTest - Win32 Release MinDependency" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "SDKTest - Win32 Unicode Release MinSize" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE "SDKTest - Win32 Unicode Release MinDependency" (based on "Win32 (x86) Dynamic-Link Library")
!MESSAGE 

# Begin Project
# PROP AllowPerConfigDependencies 0
# PROP Scc_ProjName ""
# PROP Scc_LocalPath ""
CPP=cl.exe
MTL=midl.exe
RSC=rc.exe

!IF  "$(CFG)" == "SDKTest - Win32 Debug"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 1
# PROP BASE Output_Dir "Debug"
# PROP BASE Intermediate_Dir "Debug"
# PROP BASE Target_Dir ""
# PROP Use_MFC 1
# PROP Use_Debug_Libraries 1
# PROP Output_Dir "Debug"
# PROP Intermediate_Dir "Debug"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /Yu"stdafx.h" /FD /GZ /c
# ADD CPP /nologo /MTd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_MBCS" /D "_USRDLL" /D "_WINDLL" /FR /Yu"stdafx.h" /FD /GZ /c
# ADD BASE MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "_DEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "_DEBUG"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /pdbtype:sept
# ADD LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /pdbtype:sept
# Begin Custom Build - Performing registration
OutDir=.\Debug
TargetPath=.\Debug\SDKTest.dll
InputPath=.\Debug\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	
# End Custom Build

!ELSEIF  "$(CFG)" == "SDKTest - Win32 Unicode Debug"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 1
# PROP BASE Output_Dir "DebugU"
# PROP BASE Intermediate_Dir "DebugU"
# PROP BASE Target_Dir ""
# PROP Use_MFC 1
# PROP Use_Debug_Libraries 1
# PROP Output_Dir "DebugU"
# PROP Intermediate_Dir "DebugU"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Yu"stdafx.h" /FD /GZ /c
# ADD CPP /nologo /MTd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_USRDLL" /D "_UNICODE" /D "_WINDLL" /FR /Yu"stdafx.h" /FD /GZ /c
# ADD BASE MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "_DEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "_DEBUG"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /pdbtype:sept
# ADD LINK32 /nologo /subsystem:windows /dll /debug /machine:I386 /pdbtype:sept
# Begin Custom Build - Performing registration
OutDir=.\DebugU
TargetPath=.\DebugU\SDKTest.dll
InputPath=.\DebugU\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	if "%OS%"=="" goto NOTNT 
	if not "%OS%"=="Windows_NT" goto NOTNT 
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	goto end 
	:NOTNT 
	echo Warning : Cannot register Unicode DLL on Windows 95 
	:end 
	
# End Custom Build

!ELSEIF  "$(CFG)" == "SDKTest - Win32 Release MinSize"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "ReleaseMinSize"
# PROP BASE Intermediate_Dir "ReleaseMinSize"
# PROP BASE Target_Dir ""
# PROP Use_MFC 2
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "ReleaseMinSize"
# PROP Intermediate_Dir "ReleaseMinSize"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /D "_ATL_DLL" /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /machine:I386
# ADD LINK32 /nologo /subsystem:windows /dll /machine:I386
# Begin Custom Build - Performing registration
OutDir=.\ReleaseMinSize
TargetPath=.\ReleaseMinSize\SDKTest.dll
InputPath=.\ReleaseMinSize\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	
# End Custom Build

!ELSEIF  "$(CFG)" == "SDKTest - Win32 Release MinDependency"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "ReleaseMinDependency"
# PROP BASE Intermediate_Dir "ReleaseMinDependency"
# PROP BASE Target_Dir ""
# PROP Use_MFC 2
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "ReleaseMinDependency"
# PROP Intermediate_Dir "ReleaseMinDependency"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_MBCS" /D "_USRDLL" /D "_ATL_STATIC_REGISTRY" /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /machine:I386
# ADD LINK32 /nologo /subsystem:windows /dll /machine:I386
# Begin Custom Build - Performing registration
OutDir=.\ReleaseMinDependency
TargetPath=.\ReleaseMinDependency\SDKTest.dll
InputPath=.\ReleaseMinDependency\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	
# End Custom Build

!ELSEIF  "$(CFG)" == "SDKTest - Win32 Unicode Release MinSize"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "ReleaseUMinSize"
# PROP BASE Intermediate_Dir "ReleaseUMinSize"
# PROP BASE Target_Dir ""
# PROP Use_MFC 2
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "ReleaseUMinSize"
# PROP Intermediate_Dir "ReleaseUMinSize"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_USRDLL" /D "_UNICODE" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_USRDLL" /D "_UNICODE" /D "_ATL_DLL" /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /machine:I386
# ADD LINK32 /nologo /subsystem:windows /dll /machine:I386
# Begin Custom Build - Performing registration
OutDir=.\ReleaseUMinSize
TargetPath=.\ReleaseUMinSize\SDKTest.dll
InputPath=.\ReleaseUMinSize\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	if "%OS%"=="" goto NOTNT 
	if not "%OS%"=="Windows_NT" goto NOTNT 
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	goto end 
	:NOTNT 
	echo Warning : Cannot register Unicode DLL on Windows 95 
	:end 
	
# End Custom Build

!ELSEIF  "$(CFG)" == "SDKTest - Win32 Unicode Release MinDependency"

# PROP BASE Use_MFC 2
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "ReleaseUMinDependency"
# PROP BASE Intermediate_Dir "ReleaseUMinDependency"
# PROP BASE Target_Dir ""
# PROP Use_MFC 1
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "ReleaseUMinDependency"
# PROP Intermediate_Dir "ReleaseUMinDependency"
# PROP Ignore_Export_Lib 0
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_WINDLL" /D "_AFXDLL" /D "_USRDLL" /D "_UNICODE" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MT /W3 /GX /O1 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_USRDLL" /D "_UNICODE" /D "_ATL_STATIC_REGISTRY" /D "_WINDLL" /FR /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x409 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x409 /d "NDEBUG"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /dll /machine:I386
# ADD LINK32 /nologo /subsystem:windows /dll /machine:I386
# Begin Custom Build - Performing registration
OutDir=.\ReleaseUMinDependency
TargetPath=.\ReleaseUMinDependency\SDKTest.dll
InputPath=.\ReleaseUMinDependency\SDKTest.dll
SOURCE="$(InputPath)"

"$(OutDir)\regsvr32.trg" : $(SOURCE) "$(INTDIR)" "$(OUTDIR)"
	if "%OS%"=="" goto NOTNT 
	if not "%OS%"=="Windows_NT" goto NOTNT 
	regsvr32 /s /c "$(TargetPath)" 
	echo regsvr32 exec. time > "$(OutDir)\regsvr32.trg" 
	goto end 
	:NOTNT 
	echo Warning : Cannot register Unicode DLL on Windows 95 
	:end 
	
# End Custom Build

!ENDIF 

# Begin Target

# Name "SDKTest - Win32 Debug"
# Name "SDKTest - Win32 Unicode Debug"
# Name "SDKTest - Win32 Release MinSize"
# Name "SDKTest - Win32 Release MinDependency"
# Name "SDKTest - Win32 Unicode Release MinSize"
# Name "SDKTest - Win32 Unicode Release MinDependency"
# Begin Group "Source Files"

# PROP Default_Filter "cpp;c;cxx;rc;def;r;odl;idl;hpj;bat"
# Begin Source File

SOURCE=.\AccntsReportTestDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\AcntsEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\CstmrEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\dlldatax.c
# PROP Exclude_From_Scan -1
# PROP BASE Exclude_From_Build 1
# PROP Exclude_From_Build 1
# End Source File
# Begin Source File

SOURCE=.\GenericReportDirectMehodDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\GenericReportUsingAttribDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\IItemDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\ISalesCheckoutDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\ReportDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\ReportUsingGridInterface.cpp
# End Source File
# Begin Source File

SOURCE=.\ReportUsingGridInterface.h
# End Source File
# Begin Source File

SOURCE=.\SDKTest.cpp
# End Source File
# Begin Source File

SOURCE=.\SDKTest.def
# End Source File
# Begin Source File

SOURCE=.\SDKTest.idl
# ADD MTL /tlb ".\SDKTest.tlb" /h "SDKTest.h" /iid "SDKTest_i.c" /Oicf
# End Source File
# Begin Source File

SOURCE=.\SDKTest.rc
# End Source File
# Begin Source File

SOURCE=.\SecurityinterfaceDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SettingsinterfaceDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SlsCheckoutEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpappinterfaceDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPCPPAddin.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpDlgEvents.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpDlgExt.cpp
# End Source File
# Begin Source File

SOURCE=.\Smpfilemenuoperationinterface.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpframeDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpGridControlDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpGridDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPHelpDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpOEMDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpOEMEventsDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPPluginTabDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpPluginTabEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPReceptSettingsDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpReportDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpReportMenuDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpReportMenuEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpReportSettingsDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpSettingsExDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPSetupDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpSetupEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPStockDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpStockEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SmpUserEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPUserSettingsDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\StdAfx.cpp
# ADD CPP /Yc"stdafx.h"
# End Source File
# Begin Source File

SOURCE=.\StockItemSDKTestPage.cpp
# End Source File
# Begin Source File

SOURCE=.\TansactionEvnts.cpp
# End Source File
# Begin Source File

SOURCE=.\Transaction.cpp
# End Source File
# Begin Source File

SOURCE=.\UsingIAccountsInterfaceDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\UsingICustomerInterfaceDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\UsingIDatabaseMethodsDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\UsingISMPCommands.cpp
# End Source File
# Begin Source File

SOURCE=.\UsingISmpViewInterfaceDlg.cpp
# End Source File
# End Group
# Begin Group "Header Files"

# PROP Default_Filter "h;hpp;hxx;hm;inl"
# Begin Source File

SOURCE=.\AccntsReportTestDlg.h
# End Source File
# Begin Source File

SOURCE=.\dlldatax.h
# PROP Exclude_From_Scan -1
# PROP BASE Exclude_From_Build 1
# PROP Exclude_From_Build 1
# End Source File
# Begin Source File

SOURCE=.\GenericReportDirectMehodDlg.h
# End Source File
# Begin Source File

SOURCE=.\GenericReportUsingAttribDlg.h
# End Source File
# Begin Source File

SOURCE=.\IItemDlg.h
# End Source File
# Begin Source File

SOURCE=.\ISalesCheckoutDlg.h
# End Source File
# Begin Source File

SOURCE=.\ReportDlg.h
# End Source File
# Begin Source File

SOURCE=.\Resource.h
# End Source File
# Begin Source File

SOURCE=.\SDKTestApp.h
# End Source File
# Begin Source File

SOURCE=.\SecurityinterfaceDlg.h
# End Source File
# Begin Source File

SOURCE=.\SettingsinterfaceDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpappinterfaceDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPCPPAddin.h
# End Source File
# Begin Source File

SOURCE=.\Smpfilemenuoperationinterface.h
# End Source File
# Begin Source File

SOURCE=.\SmpframeDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpGridControlDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpGridDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPHelpDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpOEMDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpOEMEventsDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPPluginTabDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPReceptSettingsDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpReportDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpReportMenuDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpReportSettingsDlg.h
# End Source File
# Begin Source File

SOURCE=.\SmpSettingsExDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPSetupDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPStockDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPUserEventDlg.cpp
# End Source File
# Begin Source File

SOURCE=.\SMPUserEventDlg.h
# End Source File
# Begin Source File

SOURCE=.\SMPUserSettingsDlg.h
# End Source File
# Begin Source File

SOURCE=.\StdAfx.h
# End Source File
# Begin Source File

SOURCE=.\StockItemSDKTestPage.h
# End Source File
# Begin Source File

SOURCE=.\Transaction.h
# End Source File
# Begin Source File

SOURCE=.\UsingIAccountsInterfaceDlg.h
# End Source File
# Begin Source File

SOURCE=.\UsingICustomerInterfaceDlg.h
# End Source File
# Begin Source File

SOURCE=.\UsingIDatabaseMethodsDlg.h
# End Source File
# Begin Source File

SOURCE=.\UsingISMPCommands.h
# End Source File
# Begin Source File

SOURCE=.\UsingISmpViewInterfaceDlg.h
# End Source File
# End Group
# Begin Group "Resource Files"

# PROP Default_Filter "ico;cur;bmp;dlg;rc2;rct;bin;rgs;gif;jpg;jpeg;jpe"
# Begin Source File

SOURCE=.\bitmap1.bmp
# End Source File
# Begin Source File

SOURCE=.\Item557.bmp
# End Source File
# Begin Source File

SOURCE=.\SMPCPPAddin.rgs
# End Source File
# Begin Source File

SOURCE=.\toolbar1.bmp
# End Source File
# End Group
# Begin Source File

SOURCE=.\htm00001.htm
# End Source File
# Begin Source File

SOURCE=.\sdk_test.htm
# End Source File
# End Target
# End Project
