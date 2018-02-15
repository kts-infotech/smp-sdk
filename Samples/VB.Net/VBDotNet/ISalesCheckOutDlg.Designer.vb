Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISalesCheckOutDlg
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
			Me.SalesCheckoutbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' SalesCheckoutbtn
			' 
			Me.SalesCheckoutbtn.Location = New System.Drawing.Point(67, 46)
			Me.SalesCheckoutbtn.Name = "SalesCheckoutbtn"
			Me.SalesCheckoutbtn.Size = New System.Drawing.Size(99, 41)
			Me.SalesCheckoutbtn.TabIndex = 0
			Me.SalesCheckoutbtn.Text = "Sales Checkout"
			Me.SalesCheckoutbtn.UseVisualStyleBackColor = True
'			Me.SalesCheckoutbtn.Click += New System.EventHandler(Me.SalesCheckoutbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.SalesCheckoutbtn)
			Me.groupBox1.Location = New System.Drawing.Point(20, 20)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(247, 129)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			' 
			' SalesCheckOutDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(287, 174)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SalesCheckOutDlg"
			Me.Text = "CheckOutDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents SalesCheckoutbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace