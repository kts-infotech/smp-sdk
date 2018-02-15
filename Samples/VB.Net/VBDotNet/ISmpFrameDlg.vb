Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib

Namespace CSharpSDKTest
	Partial Public Class ISmpFrameDlg
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainToolbarbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MainToolbarbtn.Click
            Dim m_SmpFrame As ISmpFrame
            m_SmpFrame = New SmpFrameClass()

            Dim lMaintoolBar As Long
            lMaintoolBar = CLng(m_SmpFrame.LeftToolbarHandle)
            Dim strvalue As String
            strvalue = lMaintoolBar.ToString()
            MessageBox.Show(strvalue)

		   'object objMainToolBar;
		   'objMainToolBar = m_SmpFrame.MainFrameHandle;  

			'objMainToolBar = m_SmpFrame.MainToolbarHandle;


		End Sub


	End Class
End Namespace