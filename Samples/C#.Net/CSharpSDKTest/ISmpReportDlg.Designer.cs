namespace CSharpSDKTest
{
    partial class ISmpReportDlg
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
            this.selectitemcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.ColourLbl = new System.Windows.Forms.Label();
            this.ColourTxt = new System.Windows.Forms.TextBox();
            this.SizeTxt = new System.Windows.Forms.TextBox();
            this.FontTxt = new System.Windows.Forms.TextBox();
            this.Subheading2Lbl = new System.Windows.Forms.Label();
            this.ImagePathLbl = new System.Windows.Forms.Label();
            this.ImagePathTxt = new System.Windows.Forms.TextBox();
            this.Subheading2Txt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ResetallBtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selecttablecombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adtabltbtn = new System.Windows.Forms.Button();
            this.prntrptbtn = new System.Windows.Forms.Button();
            this.Generaterptbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clsbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectitemcombo
            // 
            this.selectitemcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectitemcombo.Items.AddRange(new object[] {
            "",
            "Body Format",
            "Footer Format",
            "Footer Info",
            "Header Format",
            "Header Info"});
            this.selectitemcombo.Location = new System.Drawing.Point(122, 33);
            this.selectitemcombo.Name = "selectitemcombo";
            this.selectitemcombo.Size = new System.Drawing.Size(164, 21);
            this.selectitemcombo.TabIndex = 0;
            this.selectitemcombo.SelectedIndexChanged += new System.EventHandler(this.selectitemcombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select item to edit";
            // 
            // FontLbl
            // 
            this.FontLbl.AutoSize = true;
            this.FontLbl.Location = new System.Drawing.Point(25, 73);
            this.FontLbl.Name = "FontLbl";
            this.FontLbl.Size = new System.Drawing.Size(28, 13);
            this.FontLbl.TabIndex = 2;
            this.FontLbl.Text = "Font";
            this.FontLbl.Visible = false;
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Location = new System.Drawing.Point(25, 114);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(27, 13);
            this.SizeLbl.TabIndex = 3;
            this.SizeLbl.Text = "Size";
            this.SizeLbl.Visible = false;
            // 
            // ColourLbl
            // 
            this.ColourLbl.AutoSize = true;
            this.ColourLbl.Location = new System.Drawing.Point(25, 151);
            this.ColourLbl.Name = "ColourLbl";
            this.ColourLbl.Size = new System.Drawing.Size(37, 13);
            this.ColourLbl.TabIndex = 4;
            this.ColourLbl.Text = "Colour";
            this.ColourLbl.Visible = false;
            // 
            // ColourTxt
            // 
            this.ColourTxt.Location = new System.Drawing.Point(122, 148);
            this.ColourTxt.Name = "ColourTxt";
            this.ColourTxt.Size = new System.Drawing.Size(164, 20);
            this.ColourTxt.TabIndex = 5;
            this.ColourTxt.Visible = false;
            // 
            // SizeTxt
            // 
            this.SizeTxt.Location = new System.Drawing.Point(122, 111);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.Size = new System.Drawing.Size(164, 20);
            this.SizeTxt.TabIndex = 6;
            this.SizeTxt.Visible = false;
            // 
            // FontTxt
            // 
            this.FontTxt.Location = new System.Drawing.Point(122, 70);
            this.FontTxt.Name = "FontTxt";
            this.FontTxt.Size = new System.Drawing.Size(164, 20);
            this.FontTxt.TabIndex = 7;
            this.FontTxt.Visible = false;
            // 
            // Subheading2Lbl
            // 
            this.Subheading2Lbl.AutoSize = true;
            this.Subheading2Lbl.Location = new System.Drawing.Point(25, 190);
            this.Subheading2Lbl.Name = "Subheading2Lbl";
            this.Subheading2Lbl.Size = new System.Drawing.Size(75, 13);
            this.Subheading2Lbl.TabIndex = 8;
            this.Subheading2Lbl.Text = "Sub Heading2";
            this.Subheading2Lbl.Visible = false;
            // 
            // ImagePathLbl
            // 
            this.ImagePathLbl.AutoSize = true;
            this.ImagePathLbl.Location = new System.Drawing.Point(25, 232);
            this.ImagePathLbl.Name = "ImagePathLbl";
            this.ImagePathLbl.Size = new System.Drawing.Size(61, 13);
            this.ImagePathLbl.TabIndex = 9;
            this.ImagePathLbl.Text = "Image Path";
            this.ImagePathLbl.Visible = false;
            // 
            // ImagePathTxt
            // 
            this.ImagePathTxt.Location = new System.Drawing.Point(122, 229);
            this.ImagePathTxt.Name = "ImagePathTxt";
            this.ImagePathTxt.Size = new System.Drawing.Size(164, 20);
            this.ImagePathTxt.TabIndex = 10;
            this.ImagePathTxt.Visible = false;
            // 
            // Subheading2Txt
            // 
            this.Subheading2Txt.Location = new System.Drawing.Point(122, 187);
            this.Subheading2Txt.Name = "Subheading2Txt";
            this.Subheading2Txt.Size = new System.Drawing.Size(164, 20);
            this.Subheading2Txt.TabIndex = 11;
            this.Subheading2Txt.Visible = false;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(28, 279);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 12;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ResetallBtn
            // 
            this.ResetallBtn.Location = new System.Drawing.Point(122, 279);
            this.ResetallBtn.Name = "ResetallBtn";
            this.ResetallBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetallBtn.TabIndex = 13;
            this.ResetallBtn.Text = "Reset All";
            this.ResetallBtn.UseVisualStyleBackColor = true;
            this.ResetallBtn.Click += new System.EventHandler(this.ResetallBtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(211, 279);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 14;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.ResetallBtn);
            this.groupBox1.Controls.Add(this.selectitemcombo);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Subheading2Txt);
            this.groupBox1.Controls.Add(this.FontLbl);
            this.groupBox1.Controls.Add(this.ImagePathTxt);
            this.groupBox1.Controls.Add(this.SizeLbl);
            this.groupBox1.Controls.Add(this.ImagePathLbl);
            this.groupBox1.Controls.Add(this.ColourLbl);
            this.groupBox1.Controls.Add(this.Subheading2Lbl);
            this.groupBox1.Controls.Add(this.ColourTxt);
            this.groupBox1.Controls.Add(this.FontTxt);
            this.groupBox1.Controls.Add(this.SizeTxt);
            this.groupBox1.Location = new System.Drawing.Point(18, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 333);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Selecttablecombo
            // 
            this.Selecttablecombo.FormattingEnabled = true;
            this.Selecttablecombo.Items.AddRange(new object[] {
            "",
            "SM_SALES_TB",
            "SM_SALES_TRANSACTION_TB",
            "SM_SERVICE_TB",
            "SM_STOCK_TB",
            "SM_STOCK_TRANSACTION_TB",
            "SM_STOCK_TYPE_TB",
            "SM_CUSTOMER_TB"});
            this.Selecttablecombo.Location = new System.Drawing.Point(441, 106);
            this.Selecttablecombo.Name = "Selecttablecombo";
            this.Selecttablecombo.Size = new System.Drawing.Size(135, 21);
            this.Selecttablecombo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select table";
            // 
            // adtabltbtn
            // 
            this.adtabltbtn.Location = new System.Drawing.Point(501, 153);
            this.adtabltbtn.Name = "adtabltbtn";
            this.adtabltbtn.Size = new System.Drawing.Size(75, 23);
            this.adtabltbtn.TabIndex = 18;
            this.adtabltbtn.Text = "Add table";
            this.adtabltbtn.UseVisualStyleBackColor = true;
            this.adtabltbtn.Click += new System.EventHandler(this.adtabltbtn_Click);
            // 
            // prntrptbtn
            // 
            this.prntrptbtn.Location = new System.Drawing.Point(421, 281);
            this.prntrptbtn.Name = "prntrptbtn";
            this.prntrptbtn.Size = new System.Drawing.Size(129, 23);
            this.prntrptbtn.TabIndex = 19;
            this.prntrptbtn.Text = "Print Report ";
            this.prntrptbtn.UseVisualStyleBackColor = true;
            this.prntrptbtn.Click += new System.EventHandler(this.prntrptbtn_Click);
            // 
            // Generaterptbtn
            // 
            this.Generaterptbtn.Location = new System.Drawing.Point(421, 229);
            this.Generaterptbtn.Name = "Generaterptbtn";
            this.Generaterptbtn.Size = new System.Drawing.Size(129, 23);
            this.Generaterptbtn.TabIndex = 20;
            this.Generaterptbtn.Text = "Generate Report";
            this.Generaterptbtn.UseVisualStyleBackColor = true;
            this.Generaterptbtn.Click += new System.EventHandler(this.Generaterptbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(344, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 333);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // Clsbtn
            // 
            this.Clsbtn.Location = new System.Drawing.Point(533, 399);
            this.Clsbtn.Name = "Clsbtn";
            this.Clsbtn.Size = new System.Drawing.Size(75, 23);
            this.Clsbtn.TabIndex = 22;
            this.Clsbtn.Text = "Close";
            this.Clsbtn.UseVisualStyleBackColor = true;
            this.Clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // ISmpReportDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 434);
            this.Controls.Add(this.Clsbtn);
            this.Controls.Add(this.Generaterptbtn);
            this.Controls.Add(this.prntrptbtn);
            this.Controls.Add(this.adtabltbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selecttablecombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ISmpReportDlg";
            this.Text = "ISmpReprotDlg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ISmpReportDlg_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectitemcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FontLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.Label ColourLbl;
        private System.Windows.Forms.TextBox ColourTxt;
        private System.Windows.Forms.TextBox SizeTxt;
        private System.Windows.Forms.TextBox FontTxt;
        private System.Windows.Forms.Label Subheading2Lbl;
        private System.Windows.Forms.Label ImagePathLbl;
        private System.Windows.Forms.TextBox ImagePathTxt;
        private System.Windows.Forms.TextBox Subheading2Txt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button ResetallBtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Selecttablecombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adtabltbtn;
        private System.Windows.Forms.Button prntrptbtn;
        private System.Windows.Forms.Button Generaterptbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clsbtn;
    }
}