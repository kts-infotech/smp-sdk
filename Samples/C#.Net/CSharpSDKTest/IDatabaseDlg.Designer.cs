namespace CSharpSDKTest
{
    partial class IDatabaseDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.opertncmbobox = new System.Windows.Forms.ComboBox();
            this.FldNmeTxt = new System.Windows.Forms.TextBox();
            this.Adbtn = new System.Windows.Forms.Button();
            this.FLdNmeListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tabletxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RsltGrid = new System.Windows.Forms.DataGrid();
            this.Sqlbtn = new System.Windows.Forms.RadioButton();
            this.MSaccesbtn = new System.Windows.Forms.RadioButton();
            this.Clsbtn = new System.Windows.Forms.Button();
            this.Exebtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DBPathlist = new System.Windows.Forms.ListBox();
            this.dataSet1 = new System.Data.DataSet();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RsltGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB Path ";
            // 
            // opertncmbobox
            // 
            this.opertncmbobox.Items.AddRange(new object[] {
            "SELECT"});
            this.opertncmbobox.Location = new System.Drawing.Point(56, 137);
            this.opertncmbobox.Name = "opertncmbobox";
            this.opertncmbobox.Size = new System.Drawing.Size(154, 21);
            this.opertncmbobox.TabIndex = 3;
            this.opertncmbobox.Text = "        ------Select------";
            // 
            // FldNmeTxt
            // 
            this.FldNmeTxt.Location = new System.Drawing.Point(56, 219);
            this.FldNmeTxt.Name = "FldNmeTxt";
            this.FldNmeTxt.Size = new System.Drawing.Size(102, 20);
            this.FldNmeTxt.TabIndex = 4;
            this.FldNmeTxt.Text = "CustomerId";
            // 
            // Adbtn
            // 
            this.Adbtn.Location = new System.Drawing.Point(164, 216);
            this.Adbtn.Name = "Adbtn";
            this.Adbtn.Size = new System.Drawing.Size(46, 23);
            this.Adbtn.TabIndex = 5;
            this.Adbtn.Text = "Add";
            this.Adbtn.UseVisualStyleBackColor = true;
            this.Adbtn.Click += new System.EventHandler(this.Adbtn_Click);
            // 
            // FLdNmeListBox
            // 
            this.FLdNmeListBox.FormattingEnabled = true;
            this.FLdNmeListBox.Location = new System.Drawing.Point(56, 254);
            this.FLdNmeListBox.Name = "FLdNmeListBox";
            this.FLdNmeListBox.Size = new System.Drawing.Size(154, 108);
            this.FLdNmeListBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(39, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Operation";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(39, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 192);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fields";
            // 
            // Tabletxt
            // 
            this.Tabletxt.Location = new System.Drawing.Point(17, 31);
            this.Tabletxt.Name = "Tabletxt";
            this.Tabletxt.Size = new System.Drawing.Size(154, 20);
            this.Tabletxt.TabIndex = 9;
            this.Tabletxt.Text = "SM_CUSTOMER_TB";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tabletxt);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(39, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RsltGrid);
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(243, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 278);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // RsltGrid
            // 
            this.RsltGrid.CaptionText = "Database Fields";
            this.RsltGrid.DataMember = "";
            this.RsltGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.RsltGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.RsltGrid.Location = new System.Drawing.Point(3, 16);
            this.RsltGrid.Name = "RsltGrid";
            this.RsltGrid.ParentRowsVisible = false;
            this.RsltGrid.Size = new System.Drawing.Size(239, 259);
            this.RsltGrid.TabIndex = 2;
            // 
            // Sqlbtn
            // 
            this.Sqlbtn.AutoSize = true;
            this.Sqlbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sqlbtn.Location = new System.Drawing.Point(136, 31);
            this.Sqlbtn.Name = "Sqlbtn";
            this.Sqlbtn.Size = new System.Drawing.Size(80, 17);
            this.Sqlbtn.TabIndex = 13;
            this.Sqlbtn.TabStop = true;
            this.Sqlbtn.Text = "SQL Server";
            this.Sqlbtn.UseVisualStyleBackColor = true;
            this.Sqlbtn.CheckedChanged += new System.EventHandler(this.Sqlbtn_CheckedChanged);
            // 
            // MSaccesbtn
            // 
            this.MSaccesbtn.AutoSize = true;
            this.MSaccesbtn.Location = new System.Drawing.Point(258, 425);
            this.MSaccesbtn.Name = "MSaccesbtn";
            this.MSaccesbtn.Size = new System.Drawing.Size(79, 17);
            this.MSaccesbtn.TabIndex = 14;
            this.MSaccesbtn.TabStop = true;
            this.MSaccesbtn.Text = "MS Access";
            this.MSaccesbtn.UseVisualStyleBackColor = true;
            this.MSaccesbtn.CheckedChanged += new System.EventHandler(this.MSaccesbtn_CheckedChanged);
            // 
            // Clsbtn
            // 
            this.Clsbtn.Location = new System.Drawing.Point(394, 499);
            this.Clsbtn.Name = "Clsbtn";
            this.Clsbtn.Size = new System.Drawing.Size(75, 23);
            this.Clsbtn.TabIndex = 15;
            this.Clsbtn.Text = "Close";
            this.Clsbtn.UseVisualStyleBackColor = true;
            this.Clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // Exebtn
            // 
            this.Exebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exebtn.Location = new System.Drawing.Point(74, 65);
            this.Exebtn.Name = "Exebtn";
            this.Exebtn.Size = new System.Drawing.Size(92, 28);
            this.Exebtn.TabIndex = 16;
            this.Exebtn.Text = "Execute";
            this.Exebtn.UseVisualStyleBackColor = true;
            this.Exebtn.Click += new System.EventHandler(this.Exebtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Exebtn);
            this.groupBox5.Controls.Add(this.Sqlbtn);
            this.groupBox5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox5.Location = new System.Drawing.Point(243, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 99);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Database Type";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DBPathlist);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(17, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 520);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // DBPathlist
            // 
            this.DBPathlist.FormattingEnabled = true;
            this.DBPathlist.HorizontalScrollbar = true;
            this.DBPathlist.Location = new System.Drawing.Point(73, 35);
            this.DBPathlist.Name = "DBPathlist";
            this.DBPathlist.Size = new System.Drawing.Size(395, 43);
            this.DBPathlist.TabIndex = 20;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // IDatabaseDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 555);
            this.Controls.Add(this.Clsbtn);
            this.Controls.Add(this.MSaccesbtn);
            this.Controls.Add(this.FLdNmeListBox);
            this.Controls.Add(this.Adbtn);
            this.Controls.Add(this.FldNmeTxt);
            this.Controls.Add(this.opertncmbobox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "IDatabaseDlg";
            this.Text = "IDatabaseDlg";
            this.Load += new System.EventHandler(this.IDatabaseDlg_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RsltGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox opertncmbobox;
        private System.Windows.Forms.TextBox FldNmeTxt;
        private System.Windows.Forms.Button Adbtn;
        private System.Windows.Forms.ListBox FLdNmeListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Tabletxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Sqlbtn;
        private System.Windows.Forms.RadioButton MSaccesbtn;
        private System.Windows.Forms.Button Clsbtn;
        private System.Windows.Forms.Button Exebtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox DBPathlist;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGrid RsltGrid;

    }
}