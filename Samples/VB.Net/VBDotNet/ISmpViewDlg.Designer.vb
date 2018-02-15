Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpViewDlg
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
			Me.PrintInDosModebtn = New System.Windows.Forms.Button()
			Me.PrintReportbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' PrintInDosModebtn
			' 
			Me.PrintInDosModebtn.Location = New System.Drawing.Point(27, 28)
			Me.PrintInDosModebtn.Name = "PrintInDosModebtn"
			Me.PrintInDosModebtn.Size = New System.Drawing.Size(100, 44)
			Me.PrintInDosModebtn.TabIndex = 0
			Me.PrintInDosModebtn.Text = "Print In Dos Mode"
			Me.PrintInDosModebtn.UseVisualStyleBackColor = True
'			Me.PrintInDosModebtn.Click += New System.EventHandler(Me.PrintInDosModebtn_Click);
			' 
			' PrintReportbtn
			' 
			Me.PrintReportbtn.Location = New System.Drawing.Point(133, 28)
			Me.PrintReportbtn.Name = "PrintReportbtn"
			Me.PrintReportbtn.Size = New System.Drawing.Size(100, 44)
			Me.PrintReportbtn.TabIndex = 1
			Me.PrintReportbtn.Text = "Print Report"
			Me.PrintReportbtn.UseVisualStyleBackColor = True
'			Me.PrintReportbtn.Click += New System.EventHandler(Me.PrintReportbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.PrintReportbtn)
			Me.groupBox1.Controls.Add(Me.PrintInDosModebtn)
			Me.groupBox1.Location = New System.Drawing.Point(12, 21)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(263, 99)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			' 
			' SmpViewDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 141)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SmpViewDlg"
			Me.Text = "SmpViewDlg"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents PrintInDosModebtn As System.Windows.Forms.Button
		Private WithEvents PrintReportbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace