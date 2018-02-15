namespace CSharpSDKTest
{
    partial class IAccountsDlg
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
            this.Adbtn = new System.Windows.Forms.Button();
            this.Sbtractbtn = new System.Windows.Forms.Button();
            this.AcceptPaymentbtn = new System.Windows.Forms.Button();
            this.RefundToCustomerbtn = new System.Windows.Forms.Button();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.SubtractTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Adlbl = new System.Windows.Forms.Label();
            this.Sublbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adbtn
            // 
            this.Adbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Adbtn.Location = new System.Drawing.Point(180, 31);
            this.Adbtn.Name = "Adbtn";
            this.Adbtn.Size = new System.Drawing.Size(75, 33);
            this.Adbtn.TabIndex = 0;
            this.Adbtn.Text = "Add";
            this.Adbtn.UseVisualStyleBackColor = true;
            this.Adbtn.Click += new System.EventHandler(this.Adbtn_Click);
            // 
            // Sbtractbtn
            // 
            this.Sbtractbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sbtractbtn.Location = new System.Drawing.Point(180, 30);
            this.Sbtractbtn.Name = "Sbtractbtn";
            this.Sbtractbtn.Size = new System.Drawing.Size(75, 33);
            this.Sbtractbtn.TabIndex = 1;
            this.Sbtractbtn.Text = "Subtract";
            this.Sbtractbtn.UseVisualStyleBackColor = true;
            this.Sbtractbtn.Click += new System.EventHandler(this.Sbtractbtn_Click);
            // 
            // AcceptPaymentbtn
            // 
            this.AcceptPaymentbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AcceptPaymentbtn.Location = new System.Drawing.Point(194, 42);
            this.AcceptPaymentbtn.Name = "AcceptPaymentbtn";
            this.AcceptPaymentbtn.Size = new System.Drawing.Size(128, 35);
            this.AcceptPaymentbtn.TabIndex = 2;
            this.AcceptPaymentbtn.Text = "Accept Payment";
            this.AcceptPaymentbtn.UseVisualStyleBackColor = true;
            this.AcceptPaymentbtn.Click += new System.EventHandler(this.AcceptPaymentbtn_Click);
            // 
            // RefundToCustomerbtn
            // 
            this.RefundToCustomerbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RefundToCustomerbtn.Location = new System.Drawing.Point(46, 42);
            this.RefundToCustomerbtn.Name = "RefundToCustomerbtn";
            this.RefundToCustomerbtn.Size = new System.Drawing.Size(128, 35);
            this.RefundToCustomerbtn.TabIndex = 3;
            this.RefundToCustomerbtn.Text = "Refund To Customer";
            this.RefundToCustomerbtn.UseVisualStyleBackColor = true;
            this.RefundToCustomerbtn.Click += new System.EventHandler(this.RefundToCustomerbtn_Click);
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(46, 40);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(108, 20);
            this.AdTxt.TabIndex = 4;
            // 
            // SubtractTxt
            // 
            this.SubtractTxt.Location = new System.Drawing.Point(46, 37);
            this.SubtractTxt.Name = "SubtractTxt";
            this.SubtractTxt.Size = new System.Drawing.Size(108, 20);
            this.SubtractTxt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Adlbl);
            this.groupBox1.Controls.Add(this.AdTxt);
            this.groupBox1.Controls.Add(this.Adbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add To Shop Balance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sublbl);
            this.groupBox2.Controls.Add(this.SubtractTxt);
            this.groupBox2.Controls.Add(this.Sbtractbtn);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(30, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subtract From Shop Balance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefundToCustomerbtn);
            this.groupBox3.Controls.Add(this.AcceptPaymentbtn);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(30, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 112);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoke Dialog";
            // 
            // Adlbl
            // 
            this.Adlbl.AutoSize = true;
            this.Adlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adlbl.ForeColor = System.Drawing.Color.Red;
            this.Adlbl.Location = new System.Drawing.Point(261, 41);
            this.Adlbl.Name = "Adlbl";
            this.Adlbl.Size = new System.Drawing.Size(78, 13);
            this.Adlbl.TabIndex = 5;
            this.Adlbl.Text = "Invalid Number";
            this.Adlbl.Visible = false;
            // 
            // Sublbl
            // 
            this.Sublbl.AutoSize = true;
            this.Sublbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sublbl.ForeColor = System.Drawing.Color.Red;
            this.Sublbl.Location = new System.Drawing.Point(261, 40);
            this.Sublbl.Name = "Sublbl";
            this.Sublbl.Size = new System.Drawing.Size(78, 13);
            this.Sublbl.TabIndex = 9;
            this.Sublbl.Text = "Invalid Number";
            this.Sublbl.Visible = false;
            // 
            // IAccountsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IAccountsDlg";
            this.Text = "IAccountsDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adbtn;
        private System.Windows.Forms.Button Sbtractbtn;
        private System.Windows.Forms.Button AcceptPaymentbtn;
        private System.Windows.Forms.Button RefundToCustomerbtn;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.TextBox SubtractTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Adlbl;
        private System.Windows.Forms.Label Sublbl;
    }
}