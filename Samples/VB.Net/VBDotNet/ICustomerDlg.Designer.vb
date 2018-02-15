Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ICustomerDlg
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
			Me.clsbtn = New System.Windows.Forms.Button()
			Me.FindCustomerbtn = New System.Windows.Forms.Button()
			Me.Cstmrdtlsbtn = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.custIdTxt = New System.Windows.Forms.TextBox()
			Me.FldNmeTxt = New System.Windows.Forms.TextBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.CustIdlbl = New System.Windows.Forms.Label()
			Me.FldNmelbl = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' clsbtn
			' 
			Me.clsbtn.Location = New System.Drawing.Point(266, 347)
			Me.clsbtn.Name = "clsbtn"
			Me.clsbtn.Size = New System.Drawing.Size(57, 29)
			Me.clsbtn.TabIndex = 0
			Me.clsbtn.Text = "close"
			Me.clsbtn.UseVisualStyleBackColor = True
'			Me.clsbtn.Click += New System.EventHandler(Me.clsbtn_Click);
			' 
			' FindCustomerbtn
			' 
			Me.FindCustomerbtn.Location = New System.Drawing.Point(107, 250)
			Me.FindCustomerbtn.Name = "FindCustomerbtn"
			Me.FindCustomerbtn.Size = New System.Drawing.Size(124, 45)
			Me.FindCustomerbtn.TabIndex = 1
			Me.FindCustomerbtn.Text = "Find Customer"
			Me.FindCustomerbtn.UseVisualStyleBackColor = True
'			Me.FindCustomerbtn.Click += New System.EventHandler(Me.FindCustomerbtn_Click);
			' 
			' Cstmrdtlsbtn
			' 
			Me.Cstmrdtlsbtn.Location = New System.Drawing.Point(72, 132)
			Me.Cstmrdtlsbtn.Name = "Cstmrdtlsbtn"
			Me.Cstmrdtlsbtn.Size = New System.Drawing.Size(124, 45)
			Me.Cstmrdtlsbtn.TabIndex = 2
			Me.Cstmrdtlsbtn.Text = "Get Customer Details"
			Me.Cstmrdtlsbtn.UseVisualStyleBackColor = True
'			Me.Cstmrdtlsbtn.Click += New System.EventHandler(Me.Cstmrdtlsbtn_Click);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(58, 50)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(79, 16)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Customer Id"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(23, 83)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(78, 16)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Field Name"
			' 
			' custIdTxt
			' 
			Me.custIdTxt.Location = New System.Drawing.Point(173, 49)
			Me.custIdTxt.Name = "custIdTxt"
			Me.custIdTxt.Size = New System.Drawing.Size(100, 20)
			Me.custIdTxt.TabIndex = 5
			' 
			' FldNmeTxt
			' 
			Me.FldNmeTxt.Location = New System.Drawing.Point(138, 80)
			Me.FldNmeTxt.Name = "FldNmeTxt"
			Me.FldNmeTxt.Size = New System.Drawing.Size(100, 20)
			Me.FldNmeTxt.TabIndex = 6
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.FldNmelbl)
			Me.groupBox1.Controls.Add(Me.FldNmeTxt)
			Me.groupBox1.Controls.Add(Me.CustIdlbl)
			Me.groupBox1.Controls.Add(Me.Cstmrdtlsbtn)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Location = New System.Drawing.Point(35, 22)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(267, 194)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			' 
			' groupBox2
			' 
			Me.groupBox2.Location = New System.Drawing.Point(35, 222)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(267, 108)
			Me.groupBox2.TabIndex = 8
			Me.groupBox2.TabStop = False
			' 
			' CustIdlbl
			' 
			Me.CustIdlbl.AutoSize = True
			Me.CustIdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CustIdlbl.ForeColor = System.Drawing.Color.Red
			Me.CustIdlbl.Location = New System.Drawing.Point(135, 50)
			Me.CustIdlbl.Name = "CustIdlbl"
			Me.CustIdlbl.Size = New System.Drawing.Size(117, 13)
			Me.CustIdlbl.TabIndex = 0
			Me.CustIdlbl.Text = "Enter Valid Customer Id"
			Me.CustIdlbl.Visible = False
			' 
			' FldNmelbl
			' 
			Me.FldNmelbl.AutoSize = True
			Me.FldNmelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FldNmelbl.ForeColor = System.Drawing.Color.Red
			Me.FldNmelbl.Location = New System.Drawing.Point(135, 103)
			Me.FldNmelbl.Name = "FldNmelbl"
			Me.FldNmelbl.Size = New System.Drawing.Size(114, 13)
			Me.FldNmelbl.TabIndex = 7
			Me.FldNmelbl.Text = "Enter Valid Field Name"
			Me.FldNmelbl.Visible = False
			' 
			' ICustomerDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(335, 388)
			Me.Controls.Add(Me.custIdTxt)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.FindCustomerbtn)
			Me.Controls.Add(Me.clsbtn)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.Name = "ICustomerDlg"
			Me.Text = "ICustomerDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents clsbtn As System.Windows.Forms.Button
		Private WithEvents FindCustomerbtn As System.Windows.Forms.Button
		Private WithEvents Cstmrdtlsbtn As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private custIdTxt As System.Windows.Forms.TextBox
		Private FldNmeTxt As System.Windows.Forms.TextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private FldNmelbl As System.Windows.Forms.Label
		Private CustIdlbl As System.Windows.Forms.Label
	End Class
End Namespace