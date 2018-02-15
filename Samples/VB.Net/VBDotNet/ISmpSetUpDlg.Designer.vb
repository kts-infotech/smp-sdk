Imports Microsoft.VisualBasic
Imports System
Namespace CSharpSDKTest
	Partial Public Class ISmpSetUpDlg
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
			Me.CategoryMasterbtn = New System.Windows.Forms.Button()
			Me.CurrencySettingsbtn = New System.Windows.Forms.Button()
			Me.DefaultSettingsbtn = New System.Windows.Forms.Button()
			Me.DefaultSettingsExtbtn = New System.Windows.Forms.Button()
			Me.DeleteOldDatabtn = New System.Windows.Forms.Button()
			Me.ManageUsersbtn = New System.Windows.Forms.Button()
			Me.MethodOfPaymentbtn = New System.Windows.Forms.Button()
			Me.MiscItemMasterbtn = New System.Windows.Forms.Button()
			Me.ServiceMasterbtn = New System.Windows.Forms.Button()
			Me.SetupWizardbtn = New System.Windows.Forms.Button()
			Me.ShopInfobtn = New System.Windows.Forms.Button()
			Me.StockMasterbtn = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' CategoryMasterbtn
			' 
			Me.CategoryMasterbtn.Location = New System.Drawing.Point(24, 23)
			Me.CategoryMasterbtn.Name = "CategoryMasterbtn"
			Me.CategoryMasterbtn.Size = New System.Drawing.Size(145, 36)
			Me.CategoryMasterbtn.TabIndex = 0
			Me.CategoryMasterbtn.Text = "Category Master"
			Me.CategoryMasterbtn.UseVisualStyleBackColor = True
'			Me.CategoryMasterbtn.Click += New System.EventHandler(Me.CategoryMasterbtn_Click);
			' 
			' CurrencySettingsbtn
			' 
			Me.CurrencySettingsbtn.Location = New System.Drawing.Point(24, 75)
			Me.CurrencySettingsbtn.Name = "CurrencySettingsbtn"
			Me.CurrencySettingsbtn.Size = New System.Drawing.Size(145, 36)
			Me.CurrencySettingsbtn.TabIndex = 1
			Me.CurrencySettingsbtn.Text = "Currency Settings"
			Me.CurrencySettingsbtn.UseVisualStyleBackColor = True
'			Me.CurrencySettingsbtn.Click += New System.EventHandler(Me.CurrencySettingsbtn_Click);
			' 
			' DefaultSettingsbtn
			' 
			Me.DefaultSettingsbtn.Location = New System.Drawing.Point(24, 128)
			Me.DefaultSettingsbtn.Name = "DefaultSettingsbtn"
			Me.DefaultSettingsbtn.Size = New System.Drawing.Size(145, 36)
			Me.DefaultSettingsbtn.TabIndex = 2
			Me.DefaultSettingsbtn.Text = "Default Settings"
			Me.DefaultSettingsbtn.UseVisualStyleBackColor = True
'			Me.DefaultSettingsbtn.Click += New System.EventHandler(Me.DefaultSettingsbtn_Click);
			' 
			' DefaultSettingsExtbtn
			' 
			Me.DefaultSettingsExtbtn.Location = New System.Drawing.Point(24, 176)
			Me.DefaultSettingsExtbtn.Name = "DefaultSettingsExtbtn"
			Me.DefaultSettingsExtbtn.Size = New System.Drawing.Size(145, 36)
			Me.DefaultSettingsExtbtn.TabIndex = 3
			Me.DefaultSettingsExtbtn.Text = "Default Settings Ext"
			Me.DefaultSettingsExtbtn.UseVisualStyleBackColor = True
'			Me.DefaultSettingsExtbtn.Click += New System.EventHandler(Me.DefaultSettingsExtbtn_Click);
			' 
			' DeleteOldDatabtn
			' 
			Me.DeleteOldDatabtn.Location = New System.Drawing.Point(24, 226)
			Me.DeleteOldDatabtn.Name = "DeleteOldDatabtn"
			Me.DeleteOldDatabtn.Size = New System.Drawing.Size(145, 36)
			Me.DeleteOldDatabtn.TabIndex = 4
			Me.DeleteOldDatabtn.Text = "Delete Old Data"
			Me.DeleteOldDatabtn.UseVisualStyleBackColor = True
'			Me.DeleteOldDatabtn.Click += New System.EventHandler(Me.DeleteOldDatabtn_Click);
			' 
			' ManageUsersbtn
			' 
			Me.ManageUsersbtn.Location = New System.Drawing.Point(24, 272)
			Me.ManageUsersbtn.Name = "ManageUsersbtn"
			Me.ManageUsersbtn.Size = New System.Drawing.Size(145, 36)
			Me.ManageUsersbtn.TabIndex = 5
			Me.ManageUsersbtn.Text = "Manage Users"
			Me.ManageUsersbtn.UseVisualStyleBackColor = True
'			Me.ManageUsersbtn.Click += New System.EventHandler(Me.ManageUsersbtn_Click);
			' 
			' MethodOfPaymentbtn
			' 
			Me.MethodOfPaymentbtn.Location = New System.Drawing.Point(198, 23)
			Me.MethodOfPaymentbtn.Name = "MethodOfPaymentbtn"
			Me.MethodOfPaymentbtn.Size = New System.Drawing.Size(145, 36)
			Me.MethodOfPaymentbtn.TabIndex = 6
			Me.MethodOfPaymentbtn.Text = "Method Of Payment"
			Me.MethodOfPaymentbtn.UseVisualStyleBackColor = True
'			Me.MethodOfPaymentbtn.Click += New System.EventHandler(Me.MethodOfPaymentbtn_Click);
			' 
			' MiscItemMasterbtn
			' 
			Me.MiscItemMasterbtn.Location = New System.Drawing.Point(198, 75)
			Me.MiscItemMasterbtn.Name = "MiscItemMasterbtn"
			Me.MiscItemMasterbtn.Size = New System.Drawing.Size(145, 36)
			Me.MiscItemMasterbtn.TabIndex = 7
			Me.MiscItemMasterbtn.Text = "Miscellaneous Item Master"
			Me.MiscItemMasterbtn.UseVisualStyleBackColor = True
'			Me.MiscItemMasterbtn.Click += New System.EventHandler(Me.MiscItemMasterbtn_Click);
			' 
			' ServiceMasterbtn
			' 
			Me.ServiceMasterbtn.Location = New System.Drawing.Point(198, 128)
			Me.ServiceMasterbtn.Name = "ServiceMasterbtn"
			Me.ServiceMasterbtn.Size = New System.Drawing.Size(145, 36)
			Me.ServiceMasterbtn.TabIndex = 8
			Me.ServiceMasterbtn.Text = "Service Master"
			Me.ServiceMasterbtn.UseVisualStyleBackColor = True
'			Me.ServiceMasterbtn.Click += New System.EventHandler(Me.ServiceMasterbtn_Click);
			' 
			' SetupWizardbtn
			' 
			Me.SetupWizardbtn.Location = New System.Drawing.Point(198, 176)
			Me.SetupWizardbtn.Name = "SetupWizardbtn"
			Me.SetupWizardbtn.Size = New System.Drawing.Size(145, 36)
			Me.SetupWizardbtn.TabIndex = 9
			Me.SetupWizardbtn.Text = "Setup Wizard"
			Me.SetupWizardbtn.UseVisualStyleBackColor = True
'			Me.SetupWizardbtn.Click += New System.EventHandler(Me.SetupWizardbtn_Click);
			' 
			' ShopInfobtn
			' 
			Me.ShopInfobtn.Location = New System.Drawing.Point(198, 226)
			Me.ShopInfobtn.Name = "ShopInfobtn"
			Me.ShopInfobtn.Size = New System.Drawing.Size(145, 36)
			Me.ShopInfobtn.TabIndex = 10
			Me.ShopInfobtn.Text = "Shop Information"
			Me.ShopInfobtn.UseVisualStyleBackColor = True
'			Me.ShopInfobtn.Click += New System.EventHandler(Me.ShopInfobtn_Click);
			' 
			' StockMasterbtn
			' 
			Me.StockMasterbtn.Location = New System.Drawing.Point(198, 272)
			Me.StockMasterbtn.Name = "StockMasterbtn"
			Me.StockMasterbtn.Size = New System.Drawing.Size(145, 36)
			Me.StockMasterbtn.TabIndex = 11
			Me.StockMasterbtn.Text = "Stock Master"
			Me.StockMasterbtn.UseVisualStyleBackColor = True
'			Me.StockMasterbtn.Click += New System.EventHandler(Me.StockMasterbtn_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.StockMasterbtn)
			Me.groupBox1.Controls.Add(Me.ShopInfobtn)
			Me.groupBox1.Controls.Add(Me.SetupWizardbtn)
			Me.groupBox1.Controls.Add(Me.ServiceMasterbtn)
			Me.groupBox1.Controls.Add(Me.MiscItemMasterbtn)
			Me.groupBox1.Controls.Add(Me.MethodOfPaymentbtn)
			Me.groupBox1.Controls.Add(Me.ManageUsersbtn)
			Me.groupBox1.Controls.Add(Me.DeleteOldDatabtn)
			Me.groupBox1.Controls.Add(Me.DefaultSettingsExtbtn)
			Me.groupBox1.Controls.Add(Me.DefaultSettingsbtn)
			Me.groupBox1.Controls.Add(Me.CurrencySettingsbtn)
			Me.groupBox1.Controls.Add(Me.CategoryMasterbtn)
			Me.groupBox1.Location = New System.Drawing.Point(20, 25)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(364, 339)
			Me.groupBox1.TabIndex = 12
			Me.groupBox1.TabStop = False
			' 
			' SMPSetUpDlg
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(406, 386)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SMPSetUpDlg"
			Me.Text = "SMPSetUp"
'			Me.Load += New System.EventHandler(Me.SMPSetUp_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents CategoryMasterbtn As System.Windows.Forms.Button
		Private WithEvents CurrencySettingsbtn As System.Windows.Forms.Button
		Private WithEvents DefaultSettingsbtn As System.Windows.Forms.Button
		Private WithEvents DefaultSettingsExtbtn As System.Windows.Forms.Button
		Private WithEvents DeleteOldDatabtn As System.Windows.Forms.Button
		Private WithEvents ManageUsersbtn As System.Windows.Forms.Button
		Private WithEvents MethodOfPaymentbtn As System.Windows.Forms.Button
		Private WithEvents MiscItemMasterbtn As System.Windows.Forms.Button
		Private WithEvents ServiceMasterbtn As System.Windows.Forms.Button
		Private WithEvents SetupWizardbtn As System.Windows.Forms.Button
		Private WithEvents ShopInfobtn As System.Windows.Forms.Button
		Private WithEvents StockMasterbtn As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace