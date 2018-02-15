namespace CSharpSDKTest
{
    partial class ISmpViewDlg
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
            this.PrintInDosModebtn = new System.Windows.Forms.Button();
            this.PrintReportbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintInDosModebtn
            // 
            this.PrintInDosModebtn.Location = new System.Drawing.Point(27, 28);
            this.PrintInDosModebtn.Name = "PrintInDosModebtn";
            this.PrintInDosModebtn.Size = new System.Drawing.Size(100, 44);
            this.PrintInDosModebtn.TabIndex = 0;
            this.PrintInDosModebtn.Text = "Print In Dos Mode";
            this.PrintInDosModebtn.UseVisualStyleBackColor = true;
            this.PrintInDosModebtn.Click += new System.EventHandler(this.PrintInDosModebtn_Click);
            // 
            // PrintReportbtn
            // 
            this.PrintReportbtn.Location = new System.Drawing.Point(133, 28);
            this.PrintReportbtn.Name = "PrintReportbtn";
            this.PrintReportbtn.Size = new System.Drawing.Size(100, 44);
            this.PrintReportbtn.TabIndex = 1;
            this.PrintReportbtn.Text = "Print Report";
            this.PrintReportbtn.UseVisualStyleBackColor = true;
            this.PrintReportbtn.Click += new System.EventHandler(this.PrintReportbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintReportbtn);
            this.groupBox1.Controls.Add(this.PrintInDosModebtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // SmpViewDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "SmpViewDlg";
            this.Text = "SmpViewDlg";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintInDosModebtn;
        private System.Windows.Forms.Button PrintReportbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}