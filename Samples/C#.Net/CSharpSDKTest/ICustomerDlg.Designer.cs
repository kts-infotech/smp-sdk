namespace CSharpSDKTest
{
    partial class ICustomerDlg
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
            this.clsbtn = new System.Windows.Forms.Button();
            this.FindCustomerbtn = new System.Windows.Forms.Button();
            this.Cstmrdtlsbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custIdTxt = new System.Windows.Forms.TextBox();
            this.FldNmeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustIdlbl = new System.Windows.Forms.Label();
            this.FldNmelbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsbtn
            // 
            this.clsbtn.Location = new System.Drawing.Point(266, 347);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(57, 29);
            this.clsbtn.TabIndex = 0;
            this.clsbtn.Text = "close";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // FindCustomerbtn
            // 
            this.FindCustomerbtn.Location = new System.Drawing.Point(107, 250);
            this.FindCustomerbtn.Name = "FindCustomerbtn";
            this.FindCustomerbtn.Size = new System.Drawing.Size(124, 45);
            this.FindCustomerbtn.TabIndex = 1;
            this.FindCustomerbtn.Text = "Find Customer";
            this.FindCustomerbtn.UseVisualStyleBackColor = true;
            this.FindCustomerbtn.Click += new System.EventHandler(this.FindCustomerbtn_Click);
            // 
            // Cstmrdtlsbtn
            // 
            this.Cstmrdtlsbtn.Location = new System.Drawing.Point(72, 132);
            this.Cstmrdtlsbtn.Name = "Cstmrdtlsbtn";
            this.Cstmrdtlsbtn.Size = new System.Drawing.Size(124, 45);
            this.Cstmrdtlsbtn.TabIndex = 2;
            this.Cstmrdtlsbtn.Text = "Get Customer Details";
            this.Cstmrdtlsbtn.UseVisualStyleBackColor = true;
            this.Cstmrdtlsbtn.Click += new System.EventHandler(this.Cstmrdtlsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Field Name";
            // 
            // custIdTxt
            // 
            this.custIdTxt.Location = new System.Drawing.Point(173, 49);
            this.custIdTxt.Name = "custIdTxt";
            this.custIdTxt.Size = new System.Drawing.Size(100, 20);
            this.custIdTxt.TabIndex = 5;
            // 
            // FldNmeTxt
            // 
            this.FldNmeTxt.Location = new System.Drawing.Point(138, 80);
            this.FldNmeTxt.Name = "FldNmeTxt";
            this.FldNmeTxt.Size = new System.Drawing.Size(100, 20);
            this.FldNmeTxt.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FldNmelbl);
            this.groupBox1.Controls.Add(this.FldNmeTxt);
            this.groupBox1.Controls.Add(this.CustIdlbl);
            this.groupBox1.Controls.Add(this.Cstmrdtlsbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(35, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // CustIdlbl
            // 
            this.CustIdlbl.AutoSize = true;
            this.CustIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIdlbl.ForeColor = System.Drawing.Color.Red;
            this.CustIdlbl.Location = new System.Drawing.Point(135, 50);
            this.CustIdlbl.Name = "CustIdlbl";
            this.CustIdlbl.Size = new System.Drawing.Size(117, 13);
            this.CustIdlbl.TabIndex = 0;
            this.CustIdlbl.Text = "Enter Valid Customer Id";
            this.CustIdlbl.Visible = false;
            // 
            // FldNmelbl
            // 
            this.FldNmelbl.AutoSize = true;
            this.FldNmelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FldNmelbl.ForeColor = System.Drawing.Color.Red;
            this.FldNmelbl.Location = new System.Drawing.Point(135, 103);
            this.FldNmelbl.Name = "FldNmelbl";
            this.FldNmelbl.Size = new System.Drawing.Size(114, 13);
            this.FldNmelbl.TabIndex = 7;
            this.FldNmelbl.Text = "Enter Valid Field Name";
            this.FldNmelbl.Visible = false;
            // 
            // ICustomerDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 388);
            this.Controls.Add(this.custIdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindCustomerbtn);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ICustomerDlg";
            this.Text = "ICustomerDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.Button FindCustomerbtn;
        private System.Windows.Forms.Button Cstmrdtlsbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custIdTxt;
        private System.Windows.Forms.TextBox FldNmeTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FldNmelbl;
        private System.Windows.Forms.Label CustIdlbl;
    }
}