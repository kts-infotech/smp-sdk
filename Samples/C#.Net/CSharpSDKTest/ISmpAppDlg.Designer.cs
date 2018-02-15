namespace CSharpSDKTest
{
    partial class ISmpAppDlg
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
            this.windowTxt = new System.Windows.Forms.TextBox();
            this.Windowbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setaddininfobtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddinSecurityinfotxt = new System.Windows.Forms.Button();
            this.SendStatusbtn = new System.Windows.Forms.Button();
            this.SendStatusTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Clsbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowTxt
            // 
            //this.windowTxt.Location = new System.Drawing.Point(38, 35);
            //this.windowTxt.Name = "windowTxt";
            //this.windowTxt.Size = new System.Drawing.Size(226, 20);
            //this.windowTxt.TabIndex = 0;
            //this.windowTxt.TextChanged += new System.EventHandler(this.GetwindowTxt_TextChanged);
            // 
            // Windowbtn
            // 
            this.Windowbtn.Location = new System.Drawing.Point(128, 75);
            this.Windowbtn.Name = "Windowbtn";
            this.Windowbtn.Size = new System.Drawing.Size(136, 35);
            this.Windowbtn.TabIndex = 1;
            this.Windowbtn.Text = "Get Window Handle";
            this.Windowbtn.UseVisualStyleBackColor = true;
            this.Windowbtn.Click += new System.EventHandler(this.GetWindowbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Windowbtn);
            this.groupBox1.Controls.Add(this.windowTxt);
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // setaddininfobtn
            // 
            this.setaddininfobtn.Location = new System.Drawing.Point(163, 241);
            this.setaddininfobtn.Name = "setaddininfobtn";
            this.setaddininfobtn.Size = new System.Drawing.Size(136, 35);
            this.setaddininfobtn.TabIndex = 3;
            this.setaddininfobtn.Text = "Set Addin Info";
            this.setaddininfobtn.UseVisualStyleBackColor = true;
            this.setaddininfobtn.Click += new System.EventHandler(this.setaddininfobtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(35, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // AddinSecurityinfotxt
            // 
            this.AddinSecurityinfotxt.Location = new System.Drawing.Point(533, 241);
            this.AddinSecurityinfotxt.Name = "AddinSecurityinfotxt";
            this.AddinSecurityinfotxt.Size = new System.Drawing.Size(134, 35);
            this.AddinSecurityinfotxt.TabIndex = 5;
            this.AddinSecurityinfotxt.Text = "Set Addin Security Info";
            this.AddinSecurityinfotxt.UseVisualStyleBackColor = true;
            this.AddinSecurityinfotxt.Click += new System.EventHandler(this.AddinSecurityinfotxt_Click);
            // 
            // SendStatusbtn
            // 
            this.SendStatusbtn.Location = new System.Drawing.Point(547, 118);
            this.SendStatusbtn.Name = "SendStatusbtn";
            this.SendStatusbtn.Size = new System.Drawing.Size(120, 29);
            this.SendStatusbtn.TabIndex = 6;
            this.SendStatusbtn.Text = "Send Status";
            this.SendStatusbtn.UseVisualStyleBackColor = true;
            this.SendStatusbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendStatusTxt
            // 
            this.SendStatusTxt.Location = new System.Drawing.Point(473, 72);
            this.SendStatusTxt.Name = "SendStatusTxt";
            this.SendStatusTxt.Size = new System.Drawing.Size(194, 20);
            this.SendStatusTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(377, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 133);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(377, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // Clsbtn
            // 
            this.Clsbtn.Location = new System.Drawing.Point(656, 328);
            this.Clsbtn.Name = "Clsbtn";
            this.Clsbtn.Size = new System.Drawing.Size(75, 35);
            this.Clsbtn.TabIndex = 11;
            this.Clsbtn.Text = "Close";
            this.Clsbtn.UseVisualStyleBackColor = true;
            this.Clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // ISmpAppDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 375);
            this.Controls.Add(this.Clsbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendStatusTxt);
            this.Controls.Add(this.SendStatusbtn);
            this.Controls.Add(this.AddinSecurityinfotxt);
            this.Controls.Add(this.setaddininfobtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "ISmpAppDlg";
            this.Text = "ISmpAppDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox windowTxt;
        private System.Windows.Forms.Button Windowbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setaddininfobtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddinSecurityinfotxt;
        private System.Windows.Forms.Button SendStatusbtn;
        private System.Windows.Forms.TextBox SendStatusTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Clsbtn;
    }
}