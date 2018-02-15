Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IDatabaseDlg
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.opertncmbobox = New System.Windows.Forms.ComboBox()
			Me.FldNmeTxt = New System.Windows.Forms.TextBox()
			Me.Adbtn = New System.Windows.Forms.Button()
			Me.FLdNmeListBox = New System.Windows.Forms.ListBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.Tabletxt = New System.Windows.Forms.TextBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.RsltGrid = New System.Windows.Forms.DataGrid()
			Me.Sqlbtn = New System.Windows.Forms.RadioButton()
			Me.MSaccesbtn = New System.Windows.Forms.RadioButton()
			Me.Clsbtn = New System.Windows.Forms.Button()
			Me.Exebtn = New System.Windows.Forms.Button()
			Me.groupBox5 = New System.Windows.Forms.GroupBox()
			Me.groupBox6 = New System.Windows.Forms.GroupBox()
			Me.DBPathlist = New System.Windows.Forms.ListBox()
			Me.dataSet1 = New System.Data.DataSet()
			Me.groupBox3.SuspendLayout()
			Me.groupBox4.SuspendLayout()
			CType(Me.RsltGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox5.SuspendLayout()
			Me.groupBox6.SuspendLayout()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(19, 35)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(50, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "DB Path "
			' 
			' opertncmbobox
			' 
			Me.opertncmbobox.Items.AddRange(New Object() { "SELECT"})
			Me.opertncmbobox.Location = New System.Drawing.Point(56, 137)
			Me.opertncmbobox.Name = "opertncmbobox"
			Me.opertncmbobox.Size = New System.Drawing.Size(154, 21)
			Me.opertncmbobox.TabIndex = 3
			Me.opertncmbobox.Text = "        ------Select------"
			' 
			' FldNmeTxt
			' 
			Me.FldNmeTxt.Location = New System.Drawing.Point(56, 219)
			Me.FldNmeTxt.Name = "FldNmeTxt"
			Me.FldNmeTxt.Size = New System.Drawing.Size(102, 20)
			Me.FldNmeTxt.TabIndex = 4
			Me.FldNmeTxt.Text = "CustomerId"
			' 
			' Adbtn
			' 
			Me.Adbtn.Location = New System.Drawing.Point(164, 216)
			Me.Adbtn.Name = "Adbtn"
			Me.Adbtn.Size = New System.Drawing.Size(46, 23)
			Me.Adbtn.TabIndex = 5
			Me.Adbtn.Text = "Add"
			Me.Adbtn.UseVisualStyleBackColor = True
'			Me.Adbtn.Click += New System.EventHandler(Me.Adbtn_Click);
			' 
			' FLdNmeListBox
			' 
			Me.FLdNmeListBox.FormattingEnabled = True
			Me.FLdNmeListBox.Location = New System.Drawing.Point(56, 254)
			Me.FLdNmeListBox.Name = "FLdNmeListBox"
			Me.FLdNmeListBox.Size = New System.Drawing.Size(154, 108)
			Me.FLdNmeListBox.TabIndex = 6
			' 
			' groupBox1
			' 
			Me.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox1.Location = New System.Drawing.Point(39, 110)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(184, 71)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Database Operation"
			' 
			' groupBox2
			' 
			Me.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox2.Location = New System.Drawing.Point(39, 196)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(184, 192)
			Me.groupBox2.TabIndex = 8
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Fields"
			' 
			' Tabletxt
			' 
			Me.Tabletxt.Location = New System.Drawing.Point(17, 31)
			Me.Tabletxt.Name = "Tabletxt"
			Me.Tabletxt.Size = New System.Drawing.Size(154, 20)
			Me.Tabletxt.TabIndex = 9
			Me.Tabletxt.Text = "SM_CUSTOMER_TB"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.Tabletxt)
			Me.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox3.Location = New System.Drawing.Point(39, 415)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(184, 78)
			Me.groupBox3.TabIndex = 10
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Table Name"
			' 
			' groupBox4
			' 
			Me.groupBox4.Controls.Add(Me.RsltGrid)
			Me.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox4.Location = New System.Drawing.Point(243, 110)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(242, 278)
			Me.groupBox4.TabIndex = 12
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "Result"
			' 
			' RsltGrid
			' 
			Me.RsltGrid.CaptionText = "Database Fields"
			Me.RsltGrid.DataMember = ""
			Me.RsltGrid.Dock = System.Windows.Forms.DockStyle.Left
			Me.RsltGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.RsltGrid.Location = New System.Drawing.Point(3, 16)
			Me.RsltGrid.Name = "RsltGrid"
			Me.RsltGrid.ParentRowsVisible = False
			Me.RsltGrid.Size = New System.Drawing.Size(239, 259)
			Me.RsltGrid.TabIndex = 2
			' 
			' Sqlbtn
			' 
			Me.Sqlbtn.AutoSize = True
			Me.Sqlbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Sqlbtn.Location = New System.Drawing.Point(136, 31)
			Me.Sqlbtn.Name = "Sqlbtn"
			Me.Sqlbtn.Size = New System.Drawing.Size(80, 17)
			Me.Sqlbtn.TabIndex = 13
			Me.Sqlbtn.TabStop = True
			Me.Sqlbtn.Text = "SQL Server"
			Me.Sqlbtn.UseVisualStyleBackColor = True
'			Me.Sqlbtn.CheckedChanged += New System.EventHandler(Me.Sqlbtn_CheckedChanged);
			' 
			' MSaccesbtn
			' 
			Me.MSaccesbtn.AutoSize = True
			Me.MSaccesbtn.Location = New System.Drawing.Point(258, 425)
			Me.MSaccesbtn.Name = "MSaccesbtn"
			Me.MSaccesbtn.Size = New System.Drawing.Size(79, 17)
			Me.MSaccesbtn.TabIndex = 14
			Me.MSaccesbtn.TabStop = True
			Me.MSaccesbtn.Text = "MS Access"
			Me.MSaccesbtn.UseVisualStyleBackColor = True
'			Me.MSaccesbtn.CheckedChanged += New System.EventHandler(Me.MSaccesbtn_CheckedChanged);
			' 
			' Clsbtn
			' 
			Me.Clsbtn.Location = New System.Drawing.Point(394, 499)
			Me.Clsbtn.Name = "Clsbtn"
			Me.Clsbtn.Size = New System.Drawing.Size(75, 23)
			Me.Clsbtn.TabIndex = 15
			Me.Clsbtn.Text = "Close"
			Me.Clsbtn.UseVisualStyleBackColor = True
'			Me.Clsbtn.Click += New System.EventHandler(Me.Clsbtn_Click);
			' 
			' Exebtn
			' 
			Me.Exebtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Exebtn.Location = New System.Drawing.Point(74, 65)
			Me.Exebtn.Name = "Exebtn"
			Me.Exebtn.Size = New System.Drawing.Size(92, 28)
			Me.Exebtn.TabIndex = 16
			Me.Exebtn.Text = "Execute"
			Me.Exebtn.UseVisualStyleBackColor = True
'			Me.Exebtn.Click += New System.EventHandler(Me.Exebtn_Click);
			' 
			' groupBox5
			' 
			Me.groupBox5.Controls.Add(Me.Exebtn)
			Me.groupBox5.Controls.Add(Me.Sqlbtn)
			Me.groupBox5.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox5.Location = New System.Drawing.Point(243, 394)
			Me.groupBox5.Name = "groupBox5"
			Me.groupBox5.Size = New System.Drawing.Size(242, 99)
			Me.groupBox5.TabIndex = 17
			Me.groupBox5.TabStop = False
			Me.groupBox5.Text = "Database Type"
			' 
			' groupBox6
			' 
			Me.groupBox6.Controls.Add(Me.DBPathlist)
			Me.groupBox6.Controls.Add(Me.label1)
			Me.groupBox6.Location = New System.Drawing.Point(17, 12)
			Me.groupBox6.Name = "groupBox6"
			Me.groupBox6.Size = New System.Drawing.Size(485, 520)
			Me.groupBox6.TabIndex = 18
			Me.groupBox6.TabStop = False
			' 
			' DBPathlist
			' 
			Me.DBPathlist.FormattingEnabled = True
			Me.DBPathlist.HorizontalScrollbar = True
			Me.DBPathlist.Location = New System.Drawing.Point(73, 35)
			Me.DBPathlist.Name = "DBPathlist"
			Me.DBPathlist.Size = New System.Drawing.Size(395, 43)
			Me.DBPathlist.TabIndex = 20
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			' 
			' IDatabaseDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(514, 555)
			Me.Controls.Add(Me.Clsbtn)
			Me.Controls.Add(Me.MSaccesbtn)
			Me.Controls.Add(Me.FLdNmeListBox)
			Me.Controls.Add(Me.Adbtn)
			Me.Controls.Add(Me.FldNmeTxt)
			Me.Controls.Add(Me.opertncmbobox)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox4)
			Me.Controls.Add(Me.groupBox5)
			Me.Controls.Add(Me.groupBox6)
			Me.Name = "IDatabaseDlg"
			Me.Text = "IDatabaseDlg"
'			Me.Load += New System.EventHandler(Me.IDatabaseDlg_Load);
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.groupBox4.ResumeLayout(False)
			CType(Me.RsltGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox5.ResumeLayout(False)
			Me.groupBox5.PerformLayout()
			Me.groupBox6.ResumeLayout(False)
			Me.groupBox6.PerformLayout()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private opertncmbobox As System.Windows.Forms.ComboBox
		Private FldNmeTxt As System.Windows.Forms.TextBox
		Private WithEvents Adbtn As System.Windows.Forms.Button
		Private FLdNmeListBox As System.Windows.Forms.ListBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private Tabletxt As System.Windows.Forms.TextBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private WithEvents Sqlbtn As System.Windows.Forms.RadioButton
		Private WithEvents MSaccesbtn As System.Windows.Forms.RadioButton
		Private WithEvents Clsbtn As System.Windows.Forms.Button
		Private WithEvents Exebtn As System.Windows.Forms.Button
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private groupBox6 As System.Windows.Forms.GroupBox
		Private DBPathlist As System.Windows.Forms.ListBox
		Private dataSet1 As System.Data.DataSet
		Private RsltGrid As System.Windows.Forms.DataGrid

	End Class
End Namespace