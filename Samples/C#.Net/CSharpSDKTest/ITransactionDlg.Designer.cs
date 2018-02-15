namespace CSharpSDKTest
{
    partial class ITransactionDlg
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
            this.AddMiscExpenseBtn = new System.Windows.Forms.Button();
            this.AddMiscIncomebtn = new System.Windows.Forms.Button();
            this.AddTransactionbtn = new System.Windows.Forms.Button();
            this.CancelTransactionbtn = new System.Windows.Forms.Button();
            this.EditMiscExpensebtn = new System.Windows.Forms.Button();
            this.EditMiscIncomebtn = new System.Windows.Forms.Button();
            this.EditTransactionbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMiscExpenseBtn
            // 
            this.AddMiscExpenseBtn.Location = new System.Drawing.Point(10, 24);
            this.AddMiscExpenseBtn.Name = "AddMiscExpenseBtn";
            this.AddMiscExpenseBtn.Size = new System.Drawing.Size(167, 32);
            this.AddMiscExpenseBtn.TabIndex = 0;
            this.AddMiscExpenseBtn.Text = "Add Miscellaneous Expense";
            this.AddMiscExpenseBtn.UseVisualStyleBackColor = true;
            this.AddMiscExpenseBtn.Click += new System.EventHandler(this.AddMiscExpenseBtn_Click);
            // 
            // AddMiscIncomebtn
            // 
            this.AddMiscIncomebtn.Location = new System.Drawing.Point(10, 72);
            this.AddMiscIncomebtn.Name = "AddMiscIncomebtn";
            this.AddMiscIncomebtn.Size = new System.Drawing.Size(167, 32);
            this.AddMiscIncomebtn.TabIndex = 1;
            this.AddMiscIncomebtn.Text = "Add Miscellaneous Income";
            this.AddMiscIncomebtn.UseVisualStyleBackColor = true;
            this.AddMiscIncomebtn.Click += new System.EventHandler(this.AddMiscIncomebtn_Click);
            // 
            // AddTransactionbtn
            // 
            this.AddTransactionbtn.Location = new System.Drawing.Point(201, 120);
            this.AddTransactionbtn.Name = "AddTransactionbtn";
            this.AddTransactionbtn.Size = new System.Drawing.Size(152, 32);
            this.AddTransactionbtn.TabIndex = 2;
            this.AddTransactionbtn.Text = "Add Transaction";
            this.AddTransactionbtn.UseVisualStyleBackColor = true;
            this.AddTransactionbtn.Click += new System.EventHandler(this.AddTransactionbtn_Click);
            // 
            // CancelTransactionbtn
            // 
            this.CancelTransactionbtn.Location = new System.Drawing.Point(201, 72);
            this.CancelTransactionbtn.Name = "CancelTransactionbtn";
            this.CancelTransactionbtn.Size = new System.Drawing.Size(152, 32);
            this.CancelTransactionbtn.TabIndex = 3;
            this.CancelTransactionbtn.Text = "Cancel Transaction";
            this.CancelTransactionbtn.UseVisualStyleBackColor = true;
            this.CancelTransactionbtn.Click += new System.EventHandler(this.CancelTransactionbtn_Click);
            // 
            // EditMiscExpensebtn
            // 
            this.EditMiscExpensebtn.Location = new System.Drawing.Point(10, 120);
            this.EditMiscExpensebtn.Name = "EditMiscExpensebtn";
            this.EditMiscExpensebtn.Size = new System.Drawing.Size(167, 32);
            this.EditMiscExpensebtn.TabIndex = 4;
            this.EditMiscExpensebtn.Text = "Edit Miscellaneous Expense";
            this.EditMiscExpensebtn.UseVisualStyleBackColor = true;
            this.EditMiscExpensebtn.Click += new System.EventHandler(this.EditMiscExpensebtn_Click);
            // 
            // EditMiscIncomebtn
            // 
            this.EditMiscIncomebtn.Location = new System.Drawing.Point(10, 170);
            this.EditMiscIncomebtn.Name = "EditMiscIncomebtn";
            this.EditMiscIncomebtn.Size = new System.Drawing.Size(167, 32);
            this.EditMiscIncomebtn.TabIndex = 5;
            this.EditMiscIncomebtn.Text = "Edit Miscellaneous Income";
            this.EditMiscIncomebtn.UseVisualStyleBackColor = true;
            this.EditMiscIncomebtn.Click += new System.EventHandler(this.EditMiscIncomebtn_Click);
            // 
            // EditTransactionbtn
            // 
            this.EditTransactionbtn.Location = new System.Drawing.Point(201, 24);
            this.EditTransactionbtn.Name = "EditTransactionbtn";
            this.EditTransactionbtn.Size = new System.Drawing.Size(152, 32);
            this.EditTransactionbtn.TabIndex = 6;
            this.EditTransactionbtn.Text = "Edit Transaction";
            this.EditTransactionbtn.UseVisualStyleBackColor = true;
            this.EditTransactionbtn.Click += new System.EventHandler(this.EditTransactionbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditTransactionbtn);
            this.groupBox1.Controls.Add(this.EditMiscIncomebtn);
            this.groupBox1.Controls.Add(this.EditMiscExpensebtn);
            this.groupBox1.Controls.Add(this.CancelTransactionbtn);
            this.groupBox1.Controls.Add(this.AddTransactionbtn);
            this.groupBox1.Controls.Add(this.AddMiscIncomebtn);
            this.groupBox1.Controls.Add(this.AddMiscExpenseBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // TransactionDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransactionDlg";
            this.Text = "TransactionDlg";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMiscExpenseBtn;
        private System.Windows.Forms.Button AddMiscIncomebtn;
        private System.Windows.Forms.Button AddTransactionbtn;
        private System.Windows.Forms.Button CancelTransactionbtn;
        private System.Windows.Forms.Button EditMiscExpensebtn;
        private System.Windows.Forms.Button EditMiscIncomebtn;
        private System.Windows.Forms.Button EditTransactionbtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}