namespace DKHocPhan
{
    partial class frmDiem
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboLopHP = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgrSV = new System.Windows.Forms.DataGridView();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtGK = new System.Windows.Forms.TextBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMLHP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nhập Điểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1006, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(13, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // cboLopHP
            // 
            this.cboLopHP.FormattingEnabled = true;
            this.cboLopHP.Location = new System.Drawing.Point(133, 38);
            this.cboLopHP.Name = "cboLopHP";
            this.cboLopHP.Size = new System.Drawing.Size(194, 24);
            this.cboLopHP.TabIndex = 9;
            this.cboLopHP.SelectedIndexChanged += new System.EventHandler(this.cboLopHP_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1006, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(13, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // dgrSV
            // 
            this.dgrSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSV.Location = new System.Drawing.Point(133, 93);
            this.dgrSV.Name = "dgrSV";
            this.dgrSV.RowTemplate.Height = 24;
            this.dgrSV.Size = new System.Drawing.Size(782, 399);
            this.dgrSV.TabIndex = 11;
            this.dgrSV.SelectionChanged += new System.EventHandler(this.dgrSV_SelectionChanged);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(421, 498);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(52, 22);
            this.txtTK.TabIndex = 1;
            // 
            // txtGK
            // 
            this.txtGK.Location = new System.Drawing.Point(591, 498);
            this.txtGK.Name = "txtGK";
            this.txtGK.Size = new System.Drawing.Size(52, 22);
            this.txtGK.TabIndex = 2;
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(756, 498);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(52, 22);
            this.txtCK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thường Kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giữa Kì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cuối Kì";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(234, 498);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(52, 22);
            this.txtMaSV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Sinh Viên";
            // 
            // txtMLHP
            // 
            this.txtMLHP.Location = new System.Drawing.Point(1006, 55);
            this.txtMLHP.Name = "txtMLHP";
            this.txtMLHP.Size = new System.Drawing.Size(13, 22);
            this.txtMLHP.TabIndex = 12;
            this.txtMLHP.Visible = false;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCK);
            this.Controls.Add(this.txtGK);
            this.Controls.Add(this.txtMLHP);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.dgrSV);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboLopHP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboLopHP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgrSV;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtGK;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMLHP;
    }
}