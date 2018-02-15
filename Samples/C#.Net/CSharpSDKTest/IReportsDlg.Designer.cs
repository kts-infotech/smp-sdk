namespace CSharpSDKTest
{
    partial class IReportsDlg
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
            this.NormalBtn = new System.Windows.Forms.RadioButton();
            this.Aditinalinfobtn = new System.Windows.Forms.RadioButton();
            this.Withcaptionbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tablecombo = new System.Windows.Forms.ComboBox();
            this.AdTableBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddHeadingTxt = new System.Windows.Forms.TextBox();
            this.HeadingTxt = new System.Windows.Forms.TextBox();
            this.CaptionTxt = new System.Windows.Forms.TextBox();
            this.Reportbtn = new System.Windows.Forms.Button();
            this.Clsbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NormalBtn
            // 
            this.NormalBtn.AutoSize = true;
            this.NormalBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NormalBtn.Location = new System.Drawing.Point(23, 28);
            this.NormalBtn.Name = "NormalBtn";
            this.NormalBtn.Size = new System.Drawing.Size(58, 17);
            this.NormalBtn.TabIndex = 0;
            this.NormalBtn.TabStop = true;
            this.NormalBtn.Text = "Normal";
            this.NormalBtn.UseVisualStyleBackColor = true;
            this.NormalBtn.CheckedChanged += new System.EventHandler(this.NormalBtn_CheckedChanged);
            // 
            // Aditinalinfobtn
            // 
            this.Aditinalinfobtn.AutoSize = true;
            this.Aditinalinfobtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aditinalinfobtn.Location = new System.Drawing.Point(23, 54);
            this.Aditinalinfobtn.Name = "Aditinalinfobtn";
            this.Aditinalinfobtn.Size = new System.Drawing.Size(151, 17);
            this.Aditinalinfobtn.TabIndex = 1;
            this.Aditinalinfobtn.TabStop = true;
            this.Aditinalinfobtn.Text = "With Additional Information";
            this.Aditinalinfobtn.UseVisualStyleBackColor = true;
            this.Aditinalinfobtn.CheckedChanged += new System.EventHandler(this.Aditinalinfobtn_CheckedChanged);
            // 
            // Withcaptionbtn
            // 
            this.Withcaptionbtn.AutoSize = true;
            this.Withcaptionbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Withcaptionbtn.Location = new System.Drawing.Point(23, 77);
            this.Withcaptionbtn.Name = "Withcaptionbtn";
            this.Withcaptionbtn.Size = new System.Drawing.Size(86, 17);
            this.Withcaptionbtn.TabIndex = 2;
            this.Withcaptionbtn.TabStop = true;
            this.Withcaptionbtn.Text = "With Caption";
            this.Withcaptionbtn.UseVisualStyleBackColor = true;
            this.Withcaptionbtn.CheckedChanged += new System.EventHandler(this.Withcaptionbtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Withcaptionbtn);
            this.groupBox1.Controls.Add(this.Aditinalinfobtn);
            this.groupBox1.Controls.Add(this.NormalBtn);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select report Options";
            // 
            // Tablecombo
            // 
            this.Tablecombo.FormattingEnabled = true;
            this.Tablecombo.Location = new System.Drawing.Point(35, 158);
            this.Tablecombo.Name = "Tablecombo";
            this.Tablecombo.Size = new System.Drawing.Size(130, 21);
            this.Tablecombo.TabIndex = 4;
            // 
            // AdTableBtn
            // 
            this.AdTableBtn.Location = new System.Drawing.Point(90, 202);
            this.AdTableBtn.Name = "AdTableBtn";
            this.AdTableBtn.Size = new System.Drawing.Size(75, 23);
            this.AdTableBtn.TabIndex = 5;
            this.AdTableBtn.Text = "Add Table";
            this.AdTableBtn.UseVisualStyleBackColor = true;
            this.AdTableBtn.Click += new System.EventHandler(this.AdTableBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Additional Heading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Heading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Caption";
            // 
            // AddHeadingTxt
            // 
            this.AddHeadingTxt.Enabled = false;
            this.AddHeadingTxt.Location = new System.Drawing.Point(359, 121);
            this.AddHeadingTxt.Name = "AddHeadingTxt";
            this.AddHeadingTxt.Size = new System.Drawing.Size(100, 20);
            this.AddHeadingTxt.TabIndex = 10;
            // 
            // HeadingTxt
            // 
            this.HeadingTxt.Enabled = false;
            this.HeadingTxt.Location = new System.Drawing.Point(359, 83);
            this.HeadingTxt.Name = "HeadingTxt";
            this.HeadingTxt.Size = new System.Drawing.Size(100, 20);
            this.HeadingTxt.TabIndex = 11;
            // 
            // CaptionTxt
            // 
            this.CaptionTxt.Enabled = false;
            this.CaptionTxt.Location = new System.Drawing.Point(359, 47);
            this.CaptionTxt.Name = "CaptionTxt";
            this.CaptionTxt.Size = new System.Drawing.Size(100, 20);
            this.CaptionTxt.TabIndex = 12;
            // 
            // Reportbtn
            // 
            this.Reportbtn.Location = new System.Drawing.Point(359, 188);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(100, 26);
            this.Reportbtn.TabIndex = 13;
            this.Reportbtn.Text = "Generate Report";
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Clsbtn
            // 
            this.Clsbtn.Location = new System.Drawing.Point(414, 259);
            this.Clsbtn.Name = "Clsbtn";
            this.Clsbtn.Size = new System.Drawing.Size(75, 23);
            this.Clsbtn.TabIndex = 14;
            this.Clsbtn.Text = "Close";
            this.Clsbtn.UseVisualStyleBackColor = true;
            this.Clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(215, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 224);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // IReportsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 294);
            this.Controls.Add(this.Clsbtn);
            this.Controls.Add(this.Reportbtn);
            this.Controls.Add(this.CaptionTxt);
            this.Controls.Add(this.HeadingTxt);
            this.Controls.Add(this.AddHeadingTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdTableBtn);
            this.Controls.Add(this.Tablecombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "IReportsDlg";
            this.Text = "IReportsDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton NormalBtn;
        private System.Windows.Forms.RadioButton Aditinalinfobtn;
        private System.Windows.Forms.RadioButton Withcaptionbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Tablecombo;
        private System.Windows.Forms.Button AdTableBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddHeadingTxt;
        private System.Windows.Forms.TextBox HeadingTxt;
        private System.Windows.Forms.TextBox CaptionTxt;
        private System.Windows.Forms.Button Reportbtn;
        private System.Windows.Forms.Button Clsbtn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}