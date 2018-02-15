Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ITransactionDlg
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
			Me.AddMiscExpenseBtn = New System.Windows.Forms.Button()
			Me.AddMiscIncomebtn = New System.Windows.Forms.Button()
			Me.AddTransactionbtn = New System.Windows.Forms.Button()
			Me.CancelTransactionbtn = New System.Windows.Forms.Button()
			Me.EditMiscExpensebtn = New System.Windows.Forms.Button()
			Me.EditMiscIncomebtn = New System.Windows.Forms.Button()
			Me.EditTransactionbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' AddMiscExpenseBtn
			' 
			Me.AddMiscExpenseBtn.Location = New System.Drawing.Point(10, 24)
			Me.AddMiscExpenseBtn.Name = "AddMiscExpenseBtn"
			Me.AddMiscExpenseBtn.Size = New System.Drawing.Size(167, 32)
			Me.AddMiscExpenseBtn.TabIndex = 0
			Me.AddMiscExpenseBtn.Text = "Add Miscellaneous Expense"
			Me.AddMiscExpenseBtn.UseVisualStyleBackColor = True
'			Me.AddMiscExpenseBtn.Click += New System.EventHandler(Me.AddMiscExpenseBtn_Click);
			' 
			' AddMiscIncomebtn
			' 
			Me.AddMiscIncomebtn.Location = New System.Drawing.Point(10, 72)
			Me.AddMiscIncomebtn.Name = "AddMiscIncomebtn"
			Me.AddMiscIncomebtn.Size = New System.Drawing.Size(167, 32)
			Me.AddMiscIncomebtn.TabIndex = 1
			Me.AddMiscIncomebtn.Text = "Add Miscellaneous Income"
			Me.AddMiscIncomebtn.UseVisualStyleBackColor = True
'			Me.AddMiscIncomebtn.Click += New System.EventHandler(Me.AddMiscIncomebtn_Click);
			' 
			' AddTransactionbtn
			' 
			Me.AddTransactionbtn.Location = New System.Drawing.Point(201, 120)
			Me.AddTransactionbtn.Name = "AddTransactionbtn"
			Me.AddTransactionbtn.Size = New System.Drawing.Size(152, 32)
			Me.AddTransactionbtn.TabIndex = 2
			Me.AddTransactionbtn.Text = "Add Transaction"
			Me.AddTransactionbtn.UseVisualStyleBackColor = True
'			Me.AddTransactionbtn.Click += New System.EventHandler(Me.AddTransactionbtn_Click);
			' 
			' CancelTransactionbtn
			' 
			Me.CancelTransactionbtn.Location = New System.Drawing.Point(201, 72)
			Me.CancelTransactionbtn.Name = "CancelTransactionbtn"
			Me.CancelTransactionbtn.Size = New System.Drawing.Size(152, 32)
			Me.CancelTransactionbtn.TabIndex = 3
			Me.CancelTransactionbtn.Text = "Cancel Transaction"
			Me.CancelTransactionbtn.UseVisualStyleBackColor = True
'			Me.CancelTransactionbtn.Click += New System.EventHandler(Me.CancelTransactionbtn_Click);
			' 
			' EditMiscExpensebtn
			' 
			Me.EditMiscExpensebtn.Location = New System.Drawing.Point(10, 120)
			Me.EditMiscExpensebtn.Name = "EditMiscExpensebtn"
			Me.EditMiscExpensebtn.Size = New System.Drawing.Size(167, 32)
			Me.EditMiscExpensebtn.TabIndex = 4
			Me.EditMiscExpensebtn.Text = "Edit Miscellaneous Expense"
			Me.EditMiscExpensebtn.UseVisualStyleBackColor = True
'			Me.EditMiscExpensebtn.Click += New System.EventHandler(Me.EditMiscExpensebtn_Click);
			' 
			' EditMiscIncomebtn
			' 
			Me.EditMiscIncomebtn.Location = New System.Drawing.Point(10, 170)
			Me.EditMiscIncomebtn.Name = "EditMiscIncomebtn"
			Me.EditMiscIncomebtn.Size = New System.Drawing.Size(167, 32)
			Me.EditMiscIncomebtn.TabIndex = 5
			Me.EditMiscIncomebtn.Text = "Edit Miscellaneous Income"
			Me.EditMiscIncomebtn.UseVisualStyleBackColor = True
'			Me.EditMiscIncomebtn.Click += New System.EventHandler(Me.EditMiscIncomebtn_Click);
			' 
			' EditTransactionbtn
			' 
			Me.EditTransactionbtn.Location = New System.Drawing.Point(201, 24)
			Me.EditTransactionbtn.Name = "EditTransactionbtn"
			Me.EditTransactionbtn.Size = New System.Drawing.Size(152, 32)
			Me.EditTransactionbtn.TabIndex = 6
			Me.EditTransactionbtn.Text = "Edit Transaction"
			Me.EditTransactionbtn.UseVisualStyleBackColor = True
'			Me.EditTransactionbtn.Click += New System.EventHandler(Me.EditTransactionbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.EditTransactionbtn)
			Me.groupBox1.Controls.Add(Me.EditMiscIncomebtn)
			Me.groupBox1.Controls.Add(Me.EditMiscExpensebtn)
			Me.groupBox1.Controls.Add(Me.CancelTransactionbtn)
			Me.groupBox1.Controls.Add(Me.AddTransactionbtn)
			Me.groupBox1.Controls.Add(Me.AddMiscIncomebtn)
			Me.groupBox1.Controls.Add(Me.AddMiscExpenseBtn)
			Me.groupBox1.Location = New System.Drawing.Point(12, 9)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(391, 217)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			' 
			' TransactionDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(415, 238)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "TransactionDlg"
			Me.Text = "TransactionDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents AddMiscExpenseBtn As System.Windows.Forms.Button
		Private WithEvents AddMiscIncomebtn As System.Windows.Forms.Button
		Private WithEvents AddTransactionbtn As System.Windows.Forms.Button
		Private WithEvents CancelTransactionbtn As System.Windows.Forms.Button
		Private WithEvents EditMiscExpensebtn As System.Windows.Forms.Button
		Private WithEvents EditMiscIncomebtn As System.Windows.Forms.Button
		Private WithEvents EditTransactionbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace