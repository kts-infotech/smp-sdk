Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class IAccountsDlg
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
			Me.Adbtn = New System.Windows.Forms.Button()
			Me.Sbtractbtn = New System.Windows.Forms.Button()
			Me.AcceptPaymentbtn = New System.Windows.Forms.Button()
			Me.RefundToCustomerbtn = New System.Windows.Forms.Button()
			Me.AdTxt = New System.Windows.Forms.TextBox()
			Me.SubtractTxt = New System.Windows.Forms.TextBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.Adlbl = New System.Windows.Forms.Label()
			Me.Sublbl = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' Adbtn
			' 
			Me.Adbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Adbtn.Location = New System.Drawing.Point(180, 31)
			Me.Adbtn.Name = "Adbtn"
			Me.Adbtn.Size = New System.Drawing.Size(75, 33)
			Me.Adbtn.TabIndex = 0
			Me.Adbtn.Text = "Add"
			Me.Adbtn.UseVisualStyleBackColor = True
'			Me.Adbtn.Click += New System.EventHandler(Me.Adbtn_Click);
			' 
			' Sbtractbtn
			' 
			Me.Sbtractbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.Sbtractbtn.Location = New System.Drawing.Point(180, 30)
			Me.Sbtractbtn.Name = "Sbtractbtn"
			Me.Sbtractbtn.Size = New System.Drawing.Size(75, 33)
			Me.Sbtractbtn.TabIndex = 1
			Me.Sbtractbtn.Text = "Subtract"
			Me.Sbtractbtn.UseVisualStyleBackColor = True
'			Me.Sbtractbtn.Click += New System.EventHandler(Me.Sbtractbtn_Click);
			' 
			' AcceptPaymentbtn
			' 
			Me.AcceptPaymentbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.AcceptPaymentbtn.Location = New System.Drawing.Point(194, 42)
			Me.AcceptPaymentbtn.Name = "AcceptPaymentbtn"
			Me.AcceptPaymentbtn.Size = New System.Drawing.Size(128, 35)
			Me.AcceptPaymentbtn.TabIndex = 2
			Me.AcceptPaymentbtn.Text = "Accept Payment"
			Me.AcceptPaymentbtn.UseVisualStyleBackColor = True
'			Me.AcceptPaymentbtn.Click += New System.EventHandler(Me.AcceptPaymentbtn_Click);
			' 
			' RefundToCustomerbtn
			' 
			Me.RefundToCustomerbtn.ForeColor = System.Drawing.SystemColors.ControlText
			Me.RefundToCustomerbtn.Location = New System.Drawing.Point(46, 42)
			Me.RefundToCustomerbtn.Name = "RefundToCustomerbtn"
			Me.RefundToCustomerbtn.Size = New System.Drawing.Size(128, 35)
			Me.RefundToCustomerbtn.TabIndex = 3
			Me.RefundToCustomerbtn.Text = "Refund To Customer"
			Me.RefundToCustomerbtn.UseVisualStyleBackColor = True
'			Me.RefundToCustomerbtn.Click += New System.EventHandler(Me.RefundToCustomerbtn_Click);
			' 
			' AdTxt
			' 
			Me.AdTxt.Location = New System.Drawing.Point(46, 40)
			Me.AdTxt.Name = "AdTxt"
			Me.AdTxt.Size = New System.Drawing.Size(108, 20)
			Me.AdTxt.TabIndex = 4
			' 
			' SubtractTxt
			' 
			Me.SubtractTxt.Location = New System.Drawing.Point(46, 37)
			Me.SubtractTxt.Name = "SubtractTxt"
			Me.SubtractTxt.Size = New System.Drawing.Size(108, 20)
			Me.SubtractTxt.TabIndex = 5
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.Adlbl)
			Me.groupBox1.Controls.Add(Me.AdTxt)
			Me.groupBox1.Controls.Add(Me.Adbtn)
			Me.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox1.Location = New System.Drawing.Point(30, 26)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(374, 91)
			Me.groupBox1.TabIndex = 6
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Add To Shop Balance"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.Sublbl)
			Me.groupBox2.Controls.Add(Me.SubtractTxt)
			Me.groupBox2.Controls.Add(Me.Sbtractbtn)
			Me.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox2.Location = New System.Drawing.Point(30, 144)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(374, 87)
			Me.groupBox2.TabIndex = 7
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Subtract From Shop Balance"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.RefundToCustomerbtn)
			Me.groupBox3.Controls.Add(Me.AcceptPaymentbtn)
			Me.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue
			Me.groupBox3.Location = New System.Drawing.Point(30, 261)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(374, 112)
			Me.groupBox3.TabIndex = 8
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Invoke Dialog"
			' 
			' Adlbl
			' 
			Me.Adlbl.AutoSize = True
			Me.Adlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Adlbl.ForeColor = System.Drawing.Color.Red
			Me.Adlbl.Location = New System.Drawing.Point(261, 41)
			Me.Adlbl.Name = "Adlbl"
			Me.Adlbl.Size = New System.Drawing.Size(78, 13)
			Me.Adlbl.TabIndex = 5
			Me.Adlbl.Text = "Invalid Number"
			Me.Adlbl.Visible = False
			' 
			' Sublbl
			' 
			Me.Sublbl.AutoSize = True
			Me.Sublbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Sublbl.ForeColor = System.Drawing.Color.Red
			Me.Sublbl.Location = New System.Drawing.Point(261, 40)
			Me.Sublbl.Name = "Sublbl"
			Me.Sublbl.Size = New System.Drawing.Size(78, 13)
			Me.Sublbl.TabIndex = 9
			Me.Sublbl.Text = "Invalid Number"
			Me.Sublbl.Visible = False
			' 
			' IAccountsDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(432, 410)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "IAccountsDlg"
			Me.Text = "IAccountsDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents Adbtn As System.Windows.Forms.Button
		Private WithEvents Sbtractbtn As System.Windows.Forms.Button
		Private WithEvents AcceptPaymentbtn As System.Windows.Forms.Button
		Private WithEvents RefundToCustomerbtn As System.Windows.Forms.Button
		Private AdTxt As System.Windows.Forms.TextBox
		Private SubtractTxt As System.Windows.Forms.TextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private Adlbl As System.Windows.Forms.Label
		Private Sublbl As System.Windows.Forms.Label
	End Class
End Namespace