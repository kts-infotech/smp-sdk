namespace CSharpSDKTest
{
    partial class ISmpPluginTabDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateView = new System.Windows.Forms.Button();
            this.buttonCreateFormView = new System.Windows.Forms.Button();
            this.buttonCreateHTMLView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrentView = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateHTMLView);
            this.groupBox1.Controls.Add(this.buttonCreateFormView);
            this.groupBox1.Controls.Add(this.buttonCreateView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSet);
            this.groupBox2.Controls.Add(this.textBoxCurrentView);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonCreateView
            // 
            this.buttonCreateView.Location = new System.Drawing.Point(16, 29);
            this.buttonCreateView.Name = "buttonCreateView";
            this.buttonCreateView.Size = new System.Drawing.Size(99, 23);
            this.buttonCreateView.TabIndex = 0;
            this.buttonCreateView.Text = "Create View";
            this.buttonCreateView.UseVisualStyleBackColor = true;
            this.buttonCreateView.Click += new System.EventHandler(this.buttonCreateView_Click);
            // 
            // buttonCreateFormView
            // 
            this.buttonCreateFormView.Location = new System.Drawing.Point(135, 29);
            this.buttonCreateFormView.Name = "buttonCreateFormView";
            this.buttonCreateFormView.Size = new System.Drawing.Size(105, 23);
            this.buttonCreateFormView.TabIndex = 1;
            this.buttonCreateFormView.Text = "Create Form View";
            this.buttonCreateFormView.UseVisualStyleBackColor = true;
            this.buttonCreateFormView.Click += new System.EventHandler(this.buttonCreateFormView_Click);
            // 
            // buttonCreateHTMLView
            // 
            this.buttonCreateHTMLView.Location = new System.Drawing.Point(16, 72);
            this.buttonCreateHTMLView.Name = "buttonCreateHTMLView";
            this.buttonCreateHTMLView.Size = new System.Drawing.Size(224, 23);
            this.buttonCreateHTMLView.TabIndex = 2;
            this.buttonCreateHTMLView.Text = "Create HTML View";
            this.buttonCreateHTMLView.UseVisualStyleBackColor = true;
            this.buttonCreateHTMLView.Click += new System.EventHandler(this.buttonCreateHTMLView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Current View To :";
            // 
            // textBoxCurrentView
            // 
            this.textBoxCurrentView.Location = new System.Drawing.Point(131, 28);
            this.textBoxCurrentView.Name = "textBoxCurrentView";
            this.textBoxCurrentView.Size = new System.Drawing.Size(49, 20);
            this.textBoxCurrentView.TabIndex = 1;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(197, 26);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(49, 23);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // ISmpPluginTabDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ISmpPluginTabDlg";
            this.Text = "ISmpPluginTabDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateHTMLView;
        private System.Windows.Forms.Button buttonCreateFormView;
        private System.Windows.Forms.Button buttonCreateView;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textBoxCurrentView;
        private System.Windows.Forms.Label label1;
    }
}