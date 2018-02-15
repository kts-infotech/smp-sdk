namespace CSharpSDKTest
{
    partial class SmpGridDlg
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
            this.button_AUTO_SIZE = new System.Windows.Forms.Button();
            this.button_SET_AUTO_SIZE_STYLE = new System.Windows.Forms.Button();
            this.button_SET_FOCUS_CELL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AUTO_SIZE
            // 
            this.button_AUTO_SIZE.Location = new System.Drawing.Point(12, 69);
            this.button_AUTO_SIZE.Name = "button_AUTO_SIZE";
            this.button_AUTO_SIZE.Size = new System.Drawing.Size(125, 38);
            this.button_AUTO_SIZE.TabIndex = 0;
            this.button_AUTO_SIZE.Text = "Auto Size";
            this.button_AUTO_SIZE.UseVisualStyleBackColor = true;
            this.button_AUTO_SIZE.Click += new System.EventHandler(this.button_AUTO_SIZE_Click);
            // 
            // button_SET_AUTO_SIZE_STYLE
            // 
            this.button_SET_AUTO_SIZE_STYLE.Location = new System.Drawing.Point(178, 69);
            this.button_SET_AUTO_SIZE_STYLE.Name = "button_SET_AUTO_SIZE_STYLE";
            this.button_SET_AUTO_SIZE_STYLE.Size = new System.Drawing.Size(125, 38);
            this.button_SET_AUTO_SIZE_STYLE.TabIndex = 1;
            this.button_SET_AUTO_SIZE_STYLE.Text = "Set Auto Size Style";
            this.button_SET_AUTO_SIZE_STYLE.UseVisualStyleBackColor = true;
            this.button_SET_AUTO_SIZE_STYLE.Click += new System.EventHandler(this.button_SET_AUTO_SIZE_STYLE_Click);
            // 
            // button_SET_FOCUS_CELL
            // 
            this.button_SET_FOCUS_CELL.Location = new System.Drawing.Point(350, 69);
            this.button_SET_FOCUS_CELL.Name = "button_SET_FOCUS_CELL";
            this.button_SET_FOCUS_CELL.Size = new System.Drawing.Size(125, 38);
            this.button_SET_FOCUS_CELL.TabIndex = 2;
            this.button_SET_FOCUS_CELL.Text = "Set Focus Cell";
            this.button_SET_FOCUS_CELL.UseVisualStyleBackColor = true;
            this.button_SET_FOCUS_CELL.Click += new System.EventHandler(this.button_SET_FOCUS_CELL_Click);
            // 
            // SmpGridDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 198);
            this.Controls.Add(this.button_SET_FOCUS_CELL);
            this.Controls.Add(this.button_SET_AUTO_SIZE_STYLE);
            this.Controls.Add(this.button_AUTO_SIZE);
            this.Name = "SmpGridDlg";
            this.Text = "SmpGridDlg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AUTO_SIZE;
        private System.Windows.Forms.Button button_SET_AUTO_SIZE_STYLE;
        private System.Windows.Forms.Button button_SET_FOCUS_CELL;
    }
}