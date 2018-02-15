namespace CSharpSDKTest
{
    partial class ISmpHelpDlg
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
            this.AboutBoxbtn = new System.Windows.Forms.Button();
            this.HelTopicsbtn = new System.Windows.Forms.Button();
            this.MenuShortcutKeybtn = new System.Windows.Forms.Button();
            this.InvokeRegisterbtn = new System.Windows.Forms.Button();
            this.TipOfTheDayDlgbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutBoxbtn
            // 
            this.AboutBoxbtn.Location = new System.Drawing.Point(19, 34);
            this.AboutBoxbtn.Name = "AboutBoxbtn";
            this.AboutBoxbtn.Size = new System.Drawing.Size(128, 36);
            this.AboutBoxbtn.TabIndex = 0;
            this.AboutBoxbtn.Text = "About Box";
            this.AboutBoxbtn.UseVisualStyleBackColor = true;
            this.AboutBoxbtn.Click += new System.EventHandler(this.AboutBoxbtn_Click);
            // 
            // HelTopicsbtn
            // 
            this.HelTopicsbtn.Location = new System.Drawing.Point(122, 96);
            this.HelTopicsbtn.Name = "HelTopicsbtn";
            this.HelTopicsbtn.Size = new System.Drawing.Size(128, 36);
            this.HelTopicsbtn.TabIndex = 1;
            this.HelTopicsbtn.Text = "HelpTopics";
            this.HelTopicsbtn.UseVisualStyleBackColor = true;
            this.HelTopicsbtn.Click += new System.EventHandler(this.HelTopicsbtn_Click);
            // 
            // MenuShortcutKeybtn
            // 
            this.MenuShortcutKeybtn.Location = new System.Drawing.Point(19, 159);
            this.MenuShortcutKeybtn.Name = "MenuShortcutKeybtn";
            this.MenuShortcutKeybtn.Size = new System.Drawing.Size(128, 36);
            this.MenuShortcutKeybtn.TabIndex = 2;
            this.MenuShortcutKeybtn.Text = "Menu ShortcutKey";
            this.MenuShortcutKeybtn.UseVisualStyleBackColor = true;
            this.MenuShortcutKeybtn.Click += new System.EventHandler(this.MenuShortcutKeybtn_Click);
            // 
            // InvokeRegisterbtn
            // 
            this.InvokeRegisterbtn.Location = new System.Drawing.Point(230, 34);
            this.InvokeRegisterbtn.Name = "InvokeRegisterbtn";
            this.InvokeRegisterbtn.Size = new System.Drawing.Size(128, 36);
            this.InvokeRegisterbtn.TabIndex = 3;
            this.InvokeRegisterbtn.Text = " Register";
            this.InvokeRegisterbtn.UseVisualStyleBackColor = true;
            this.InvokeRegisterbtn.Click += new System.EventHandler(this.InvokeRegisterbtn_Click);
            // 
            // TipOfTheDayDlgbtn
            // 
            this.TipOfTheDayDlgbtn.Location = new System.Drawing.Point(230, 159);
            this.TipOfTheDayDlgbtn.Name = "TipOfTheDayDlgbtn";
            this.TipOfTheDayDlgbtn.Size = new System.Drawing.Size(128, 36);
            this.TipOfTheDayDlgbtn.TabIndex = 4;
            this.TipOfTheDayDlgbtn.Text = "Tip Of The Day";
            this.TipOfTheDayDlgbtn.UseVisualStyleBackColor = true;
            this.TipOfTheDayDlgbtn.Click += new System.EventHandler(this.TipOfTheDayDlgbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipOfTheDayDlgbtn);
            this.groupBox1.Controls.Add(this.InvokeRegisterbtn);
            this.groupBox1.Controls.Add(this.MenuShortcutKeybtn);
            this.groupBox1.Controls.Add(this.HelTopicsbtn);
            this.groupBox1.Controls.Add(this.AboutBoxbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // HelpDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "HelpDlg";
            this.Text = "HelpDlg";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutBoxbtn;
        private System.Windows.Forms.Button HelTopicsbtn;
        private System.Windows.Forms.Button MenuShortcutKeybtn;
        private System.Windows.Forms.Button InvokeRegisterbtn;
        private System.Windows.Forms.Button TipOfTheDayDlgbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}