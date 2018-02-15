Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SalesMatePlusLib
Imports System.Data.SqlClient

Namespace CSharpSDKTest

	Partial Public Class IDatabaseDlg
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Adbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Adbtn.Click
			If FldNmeTxt.Text = "" Then
				MessageBox.Show("Enter the Field Name")
			Else
				FLdNmeListBox.Items.Add(FldNmeTxt.Text)

				FldNmeTxt.Clear()
			End If
		End Sub

		Private Sub Clsbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clsbtn.Click
			Me.Close()
		End Sub
		Private Sub Exebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Exebtn.Click
			Try
				Dim m_Database As IDatabase
				m_Database = New DatabaseClass()

				Dim sCommand As String = String.Empty

				If MSaccesbtn.Checked = True Then
					Dim iMsAcess As Integer
					iMsAcess= m_Database.IsMSAccess
				End If

				If opertncmbobox.Text = "SELECT" Then
					Dim objconnection As Object = m_Database.ConnectionInterface
					Dim strDataBase As String = Tabletxt.Text
					Dim ds As New DataSet()

					For icount As Integer = 0 To FLdNmeListBox.Items.Count - 1
						sCommand = "SELECT "
						Dim strFldName As String = FLdNmeListBox.Items(icount).ToString()

						sCommand &= " " & strFldName & " "

						sCommand &= " FROM " & strDataBase
						Dim outRecordset As Object = New Object()
						m_Database.ExecuteQueryEx(sCommand, outRecordset)
						Dim objRec As ADODB.Recordset = CType(outRecordset, ADODB.Recordset)
						Dim da As New System.Data.OleDb.OleDbDataAdapter()
						da.Fill(ds, objRec, strFldName)
						RsltGrid.DataSource = ds.DefaultViewManager
						sCommand = String.Empty

					Next icount
				End If
			Catch Ex As Exception
				MessageBox.Show(Ex.ToString())
			End Try

		End Sub

		Private Sub IDatabaseDlg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Dim m_Database As IDatabase
			m_Database = New DatabaseClass()
			DBPathlist.Items.Add(m_Database.DBPath)
		End Sub

		Private Sub MSaccesbtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MSaccesbtn.CheckedChanged
			If MSaccesbtn.Checked = True Then
				Sqlbtn.Checked = False
			End If
		End Sub

		Private Sub Sqlbtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Sqlbtn.CheckedChanged
			If Sqlbtn.Checked=True Then
				MSaccesbtn.Checked=False
			End If

		End Sub
	End Class

End Namespace