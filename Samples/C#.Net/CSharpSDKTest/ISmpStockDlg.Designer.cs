namespace CSharpSDKTest
{
    partial class ISmpStockDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewStockbtn = new System.Windows.Forms.Button();
            this.CancelSalesbtn = new System.Windows.Forms.Button();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            this.EditStockbtn = new System.Windows.Forms.Button();
            this.ModifyStockItemPricebtn = new System.Windows.Forms.Button();
            this.StockRateSettingsbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewStockbtn
            // 
            this.AddNewStockbtn.Location = new System.Drawing.Point(14, 21);
            this.AddNewStockbtn.Name = "AddNewStockbtn";
            this.AddNewStockbtn.Size = new System.Drawing.Size(135, 45);
            this.AddNewStockbtn.TabIndex = 0;
            this.AddNewStockbtn.Text = "Add New Stock";
            this.AddNewStockbtn.UseVisualStyleBackColor = true;
            this.AddNewStockbtn.Click += new System.EventHandler(this.AddNewStockbtn_Click);
            // 
            // CancelSalesbtn
            // 
            this.CancelSalesbtn.Location = new System.Drawing.Point(14, 93);
            this.CancelSalesbtn.Name = "CancelSalesbtn";
            this.CancelSalesbtn.Size = new System.Drawing.Size(135, 45);
            this.CancelSalesbtn.TabIndex = 1;
            this.CancelSalesbtn.Text = "Cancel Sales";
            this.CancelSalesbtn.UseVisualStyleBackColor = true;
            this.CancelSalesbtn.Click += new System.EventHandler(this.CancelSalesbtn_Click);
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.Location = new System.Drawing.Point(14, 165);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(135, 45);
            this.Checkoutbtn.TabIndex = 2;
            this.Checkoutbtn.Text = "Check out";
            this.Checkoutbtn.UseVisualStyleBackColor = true;
            this.Checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // EditStockbtn
            // 
            this.EditStockbtn.Location = new System.Drawing.Point(175, 21);
            this.EditStockbtn.Name = "EditStockbtn";
            this.EditStockbtn.Size = new System.Drawing.Size(135, 45);
            this.EditStockbtn.TabIndex = 3;
            this.EditStockbtn.Text = "Edit Stock";
            this.EditStockbtn.UseVisualStyleBackColor = true;
            this.EditStockbtn.Click += new System.EventHandler(this.EditStockbtn_Click);
            // 
            // ModifyStockItemPricebtn
            // 
            this.ModifyStockItemPricebtn.Location = new System.Drawing.Point(175, 93);
            this.ModifyStockItemPricebtn.Name = "ModifyStockItemPricebtn";
            this.ModifyStockItemPricebtn.Size = new System.Drawing.Size(135, 45);
            this.ModifyStockItemPricebtn.TabIndex = 4;
            this.ModifyStockItemPricebtn.Text = "Modify Stock Item Price";
            this.ModifyStockItemPricebtn.UseVisualStyleBackColor = true;
            this.ModifyStockItemPricebtn.Click += new System.EventHandler(this.ModifyStockItemPricebtn_Click);
            // 
            // StockRateSettingsbtn
            // 
            this.StockRateSettingsbtn.Location = new System.Drawing.Point(175, 165);
            this.StockRateSettingsbtn.Name = "StockRateSettingsbtn";
            this.StockRateSettingsbtn.Size = new System.Drawing.Size(135, 45);
            this.StockRateSettingsbtn.TabIndex = 5;
            this.StockRateSettingsbtn.Text = "Stock Rate Settings";
            this.StockRateSettingsbtn.UseVisualStyleBackColor = true;
            this.StockRateSettingsbtn.Click += new System.EventHandler(this.StockRateSettingsbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StockRateSettingsbtn);
            this.groupBox1.Controls.Add(this.ModifyStockItemPricebtn);
            this.groupBox1.Controls.Add(this.EditStockbtn);
            this.groupBox1.Controls.Add(this.Checkoutbtn);
            this.groupBox1.Controls.Add(this.CancelSalesbtn);
            this.groupBox1.Controls.Add(this.AddNewStockbtn);
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SmpStockDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "SmpStockDlg";
            this.Text = "SmpStockDlg";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewStockbtn;
        private System.Windows.Forms.Button CancelSalesbtn;
        private System.Windows.Forms.Button Checkoutbtn;
        private System.Windows.Forms.Button EditStockbtn;
        private System.Windows.Forms.Button ModifyStockItemPricebtn;
        private System.Windows.Forms.Button StockRateSettingsbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}