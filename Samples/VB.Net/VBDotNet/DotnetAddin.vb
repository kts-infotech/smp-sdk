Imports Microsoft.VisualBasic
Imports System
Imports System.Runtime.InteropServices
Imports SalesMatePlusLib
Imports System.IO
Imports System.Xml
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading

'using System.Windows.Forms;

Namespace CSharpSDKTest
	''' <summary>
	''' Summary description for Class1.
	''' </summary>
	''' 

	'Change this GUID for your own plugin...
    <ClassInterface(ClassInterfaceType.AutoDispatch), Guid("CA20D230-8AB7-4fe5-B77C-06C3C4F8FC17")> _
 Public Class CAddinDotNet
        Implements SalesMatePlusLib.ISmpAddin, SalesMatePlusLib.ISmpPluginTabEvents, SalesMatePlusLib.ISmpDialogEvents, SalesMatePlusLib.SmpOEMEvents

        Private AddinFormThread As Thread
        Private appContext As ApplicationContext
        Private lPluginTab As Integer
        Private Const OMP_TAB_VIEW_ID As Integer = -100
        Private Const SMP_WM_SIZE As Integer = 5

        Private lWindowHandle As System.UInt32

        'CReceiptsettings objReceiptsettings;
        Public Sub New()
            '
            ' TODO: Add constructor logic here
            '
            'objReceiptsettings = new CReceiptsettings();
            lPluginTab = -1

        End Sub


#Region "Component Category Registration"

        <ComRegisterFunction(), ComVisible(False)> _
        Public Shared Sub RegisterFunction(ByVal t As Type)

            Dim sKey As String = "\CLSID\{" & t.GUID.ToString() & "}\Implemented Categories"

            Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(sKey, True)

            If regKey IsNot Nothing Then

                regKey.CreateSubKey("{66DBC8C6-B4D0-48C4-988D-47D7B35E127B}")

            End If

        End Sub



        <ComUnregisterFunction(), ComVisible(False)> _
        Public Shared Sub UnregisterFunction(ByVal t As Type)

            Dim sKey As String = "\CLSID\{" & t.GUID.ToString() & "}\Implemented Categories"

            Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(sKey, True)

            If regKey IsNot Nothing Then

                regKey.DeleteSubKey("{66DBC8C6-B4D0-48C4-988D-47D7B35E127B}")

            End If

        End Sub

#End Region


#Region "ISmpAddin Members"

        Public Sub CheckCredentials(ByRef pStrOrganizationName As String, ByRef pStrKey As String) Implements SalesMatePlusLib.ISmpAddin.CheckCredentials
            ' TODO:  Add CAddinDotNet.CheckCredentials implementation
            pStrOrganizationName = "SalesMate + VB.NET Sample Addin"
            pStrKey = "26746995"
        End Sub

        Public Sub InvokeAboutBox() Implements SalesMatePlusLib.ISmpAddin.InvokeAboutBox
            ' TODO:  Add CAddinDotNet.InvokeAboutBox implementation
        End Sub

        Public Sub ApplicationLaunched() Implements SalesMatePlusLib.ISmpAddin.ApplicationLaunched
            ' TODO:  Add CAddinDotNet.ApplicationLaunched implementation
        End Sub
        Private Sub StartMessageLoop()
            Application.Run(appContext)
        End Sub
        Private Sub ApplicationContext(ByVal MainForm As Object)

        End Sub

        Public Sub InitializeDatabase(ByVal lSessionID As Integer, ByRef plStatus As Integer) Implements SalesMatePlusLib.ISmpAddin.InitializeDatabase
            ' TODO:  Add CAddinDotNet.InitializeDatabase implementation
        End Sub

        Public Sub DeleteOldData(ByVal strSpecifiedDate As String) Implements SalesMatePlusLib.ISmpAddin.DeleteOldData
            ' TODO:  Add CAddinDotNet.DeleteOldData implementation
        End Sub

        Private Sub Initialize(ByVal lSessionID As Integer, ByVal pApp As SmpApp, ByVal bFirstTime As Object) Implements SalesMatePlusLib.ISmpAddin.Initialize
            ' TODO:  Add CAddinDotNet.SalesMatePlusLib.ISmpAddin.Initialize implementation
            Dim thisAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            'Read the embedded XML menu resource
            Dim rgbxml As Stream = thisAssembly.GetManifestResourceStream("AddinXML.xml")

            Dim rgbBmp As Stream = thisAssembly.GetManifestResourceStream("Bitmap1.bmp")

            Dim bmp As New Bitmap(rgbBmp)

            Dim doc As New XmlDocument()
            doc.Load(rgbxml)
            Dim strMenuXML As String = doc.InnerXml
            'MessageBox.Show(strMenuXML);
            Dim bitMapHandle As IntPtr = bmp.GetHbitmap()
            'pApp.SetAddInInfo(lSessionID, 0, strMenuXML, CInt(Fix(bitMapHandle)), CInt(Fix(bitMapHandle)))
            pApp.SetAddInInfo(lSessionID, 0, strMenuXML, bitMapHandle, bitMapHandle)
        End Sub

        Public Sub UpdateAddinCmdUI(ByVal lCommandID As Integer, ByRef pbEnable As Integer) Implements SalesMatePlusLib.ISmpAddin.UpdateAddinCmdUI
            ' TODO:  Add CAddinDotNet.UpdateAddinCmdUI implementation
        End Sub


        Public Sub Uninitialize(ByVal lSessionID As Integer) Implements SalesMatePlusLib.ISmpAddin.Uninitialize
            ' TODO:  Add CAddinDotNet.Uninitialize implementation
            GC.Collect()
        End Sub

#End Region

        Public Sub Function1()
            MessageBox.Show("Test")
        End Sub

        Public Sub UsingISmpReceiptSettingsInterface()
            Dim objReceiptsettingsDlg As New ReceiptsettingsDlg()

            objReceiptsettingsDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpReportSettingsInterface()
            Dim objReportSettingDlg As New ISmpReportSettingDlg()

            objReportSettingDlg.ShowDialog()
        End Sub

        Public Sub UsingITransactionsInterface()
            Dim objTransactionDlg As New ITransactionDlg()

            objTransactionDlg.ShowDialog()
        End Sub
        Public Sub UsingISmpGridControlInterface()
            Dim objIsmpgridControl As New ISmpGridControlDlg()

            objIsmpgridControl.ShowDialog()
        End Sub
        Public Sub UsingISmpHelpInterface()
            Dim objHelpDlg As New ISmpHelpDlg()

            objHelpDlg.ShowDialog()
        End Sub

        Public Sub UsingISalesCheckoutInterface()
            Dim objSalesCheckOutDlg As New ISalesCheckOutDlg()

            objSalesCheckOutDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpFileMenuOperationsInterface()
            Dim objSmpFileMenuOperations As New ISmpFileMenuOperationsDlg()

            objSmpFileMenuOperations.ShowDialog()
        End Sub

        Public Sub UsingISmpSetupInterface()
            Dim objSmpSetupDlg As New ISmpSetUpDlg()

            objSmpSetupDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpStockInterface()
            Dim objSmpStockDlg As New ISmpStockDlg()

            objSmpStockDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpUserInterface()
            Dim objSmpUserDlg As New ISmpUserDlg()

            objSmpUserDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpViewInterface()
            Dim objSmpViewDlg As New ISmpViewDlg()

            objSmpViewDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpReportMenuInterface()
            Dim objReportMenuDlg As New ISmpReportMenuDlg()

            objReportMenuDlg.ShowDialog()
        End Sub

        Public Sub UsingIAccountsInterface()
            Dim objIAccountsDlg As New IAccountsDlg()

            objIAccountsDlg.ShowDialog()

        End Sub

        Public Sub UsingICustomerInterface()
            Dim objCustomerDlg As New ICustomerDlg()

            objCustomerDlg.ShowDialog()
        End Sub

        Public Sub UsingIDatabaseMethods()
            Dim objDatabaseDlg As New IDatabaseDlg()

            objDatabaseDlg.ShowDialog()
        End Sub

        Public Sub UsingISettingsInterface()
            Dim objSettingsDlg As New ISettingsDlg()

            objSettingsDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpFrameInterface()
            Dim objFrameDlg As New ISmpFrameDlg()

            objFrameDlg.ShowDialog()
        End Sub

        Public Sub UsingIISmpCommandsInterface()
            Dim objIISmpCommandsDlg As New IISmpCommandsDlg()

            objIISmpCommandsDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpAppInterface()
            Dim objSmpAppDlg As New ISmpAppDlg()

            objSmpAppDlg.ShowDialog()

        End Sub

        Public Sub UsingIReportsInterface()
            Dim objReportsDlg As New IReportsDlg()
            objReportsDlg.ShowDialog()
        End Sub

        Public Sub UsingISmpReportInterface()
            Dim objISmpReportDlg As New ISmpReportDlg()
            objISmpReportDlg.ShowDialog()
        End Sub

        Public Sub UsingISecurityInterface()
            Dim objISecurityDlg As New ISecurityDlg()
            objISecurityDlg.ShowDialog()
        End Sub

        Public Sub GenericReportUsingMethod()
            Dim objIISmpGenericReportDlg As New IISmpGenericReportDlg()
            objIISmpGenericReportDlg.ShowDialog()
        End Sub

        Public Sub GenericReportUsingAttribute()
            Dim objISmpReportItemAttributesDlg As New ISmpReportItemAttributesDlg()
            objISmpReportItemAttributesDlg.ShowDialog()
        End Sub

        Public Sub UsingIGridInterface()
            Dim objIGridDlg As New IGridDlg()
            objIGridDlg.ShowDialog()
        End Sub
        Public Sub UsingSmpOEMEventsInterface()
            Dim objSmpOEMEventsDlg As New SmpOEMEventsDlg()
            objSmpOEMEventsDlg.ShowDialog()
        End Sub
        Public Sub UsingSmpGrid()
            Dim objSmpGridDlg As New SmpGridDlg()
            objSmpGridDlg.ShowDialog()
        End Sub


#Region "ISmpPluginTabEvents Members"

        Public Sub OnSetCurView(ByVal lCurViewIndex As Integer) Implements SalesMatePlusLib.ISmpPluginTabEvents.OnSetCurView
            If lPluginTab = lCurViewIndex Then

            Else

            End If
        End Sub

#End Region

#Region "ISmpDialogEvents Members"

        Public Sub OnDialogWndProc(ByVal hWndHandle As Object, ByVal lDialogID As Integer, ByVal message As Integer, ByVal wParam As Object, ByVal lParam As Object, ByVal lDialogeType As Integer) Implements SalesMatePlusLib.ISmpDialogEvents.OnDialogWndProc
            Select Case lDialogID
                Case OMP_TAB_VIEW_ID
                    Select Case message
                        Case SMP_WM_SIZE

                            'MessageBox.Show(lDialogeType.ToString());
                            If lDialogeType = lPluginTab Then
                                Dim PluginTab As ISmpPluginTab = New SmpPluginTab()
                                Dim X As Integer = 0, Y As Integer = 0, Width As Integer = 0, Height As Integer = 0
                                PluginTab.GetWindowRect(lPluginTab, X, Y, Width, Height)

                            End If
                            Exit Select

                    End Select
                    Exit Select

            End Select
        End Sub

#End Region

       

        Public Sub InvokeCustomAccountsMenuDlg1(ByVal iMenuType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomAccountsMenuDlg
            Select Case iMenuType
                Case 32990
                    MessageBox.Show("Successfully bypass Accept Payment Dlg")
                Case 32994
                    MessageBox.Show("Successfully bypass Refund to customer Dlg")

            End Select

        End Sub

        Public Sub InvokeCustomCustomerMenuDlg1(ByVal iMenuType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomCustomerMenuDlg
            Select Case iMenuType
                Case 32833
                    MessageBox.Show("Successfully bypass Add Customer Dlg")
                Case 32837
                    MessageBox.Show("Successfully bypass Edit Customer Dlg")
                Case 32870
                    MessageBox.Show("Successfully bypass Delete Customer Dlg")
                Case 32835
                    MessageBox.Show("Successfully bypass Find Customer Dlg")

            End Select
        End Sub

        Public Sub InvokeCustomFileMenuDlg1(ByVal iMenuType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomFileMenuDlg
            Select Case iMenuType
                Case 32771
                    MessageBox.Show("Successfully bypass Backup Data Dlg")

            End Select

        End Sub

        Public Sub InvokeCustomHelpMenuDlg1(ByVal iHelpMenuType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomHelpMenuDlg
            Select Case iHelpMenuType

                Case 32931
                    MessageBox.Show("Successfully bypass Register Dlg")
                Case 32797
                    MessageBox.Show("Successfully bypass help Topics Dlg")
                Case 32988
                    MessageBox.Show("Successfully bypass Menu ShortCut Dlg")

            End Select
        End Sub

        Public Sub InvokeCustomReportMenuDlg1(ByVal iDlgType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomReportMenuDlg
            Select Case iDlgType

                Case 32825
                    MessageBox.Show("Successfully bypass Daily Report Dlg")
                Case 32826
                    MessageBox.Show("Successfully bypass Monthly Report Dlg")
                Case 32867
                    MessageBox.Show("Successfully bypass Yearly Report Dlg")

            End Select
        End Sub

        Public Sub InvokeCustomSalesMenuDlg1(ByVal iDialogType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomSalesMenuDlg
            Select Case iDialogType
                
                Case 32810
                    MessageBox.Show("Successfully bypass Add New Stock Item Dlg")
                Case 32811
                    MessageBox.Show("Successfully bypass Modify Iteam Dlg")
                Case 32976
                    MessageBox.Show("Successfully bypass Modify Stock Iteam Price Dlg")

            End Select
        End Sub

        Public Sub InvokeCustomSetupMenuDlg1(ByVal iDialogType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomSetupMenuDlg

            Select Case iDialogType
                Case 32787
                    MessageBox.Show("Successfully bypass Currency settings Dlg")
                Case 32818
                    MessageBox.Show("Successfully bypass Add Method of Payment Dlg")
                Case 32831
                    MessageBox.Show("Successfully bypass Service Master Dlg")

            End Select



        End Sub

        Public Sub InvokeCustomTransactionMenuDlg1(ByVal iDialogType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomTransactionMenuDlg
            Select Case iDialogType
                Case 32801
                    MessageBox.Show("Successfully bypass Transaction Dlg")
                Case 32809
                    MessageBox.Show("Successfully bypass Edit Transaction Dlg")
                Case 32925
                    MessageBox.Show("Successfully bypass Cancel Transaction Dlg")

            End Select
        End Sub

        Public Sub InvokeCustomViewMenu1(ByVal iMenuType As Integer) Implements SalesMatePlusLib.ISmpOEMEvents.InvokeCustomViewMenu
            Select Case iMenuType
                Case 32985
                    MessageBox.Show("Successfully bypass Main Toolbar Dlg")
                Case 32999
                    MessageBox.Show("Successfully bypass Full Screen Dlg")
                Case 32868
                    MessageBox.Show("Successfully bypass Clear Dlg")

            End Select
        End Sub
    End Class
End Namespace
