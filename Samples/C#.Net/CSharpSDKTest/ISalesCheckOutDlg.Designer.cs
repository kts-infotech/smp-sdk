namespace CSharpSDKTest
{
    partial class ISalesCheckOutDlg
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
            this.SalesCheckoutbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesCheckoutbtn
            // 
            this.SalesCheckoutbtn.Location = new System.Drawing.Point(67, 46);
            this.SalesCheckoutbtn.Name = "SalesCheckoutbtn";
            this.SalesCheckoutbtn.Size = new System.Drawing.Size(99, 41);
            this.SalesCheckoutbtn.TabIndex = 0;
            this.SalesCheckoutbtn.Text = "Sales Checkout";
            this.SalesCheckoutbtn.UseVisualStyleBackColor = true;
            this.SalesCheckoutbtn.Click += new System.EventHandler(this.SalesCheckoutbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalesCheckoutbtn);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // SalesCheckOutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 174);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesCheckOutDlg";
            this.Text = "CheckOutDlg";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalesCheckoutbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}