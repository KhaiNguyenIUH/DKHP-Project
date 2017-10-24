namespace DKHocPhan
{
    partial class FrmTKB
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
            this.dgrTKB = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrTKB
            // 
            this.dgrTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTKB.Location = new System.Drawing.Point(139, 50);
            this.dgrTKB.Name = "dgrTKB";
            this.dgrTKB.RowTemplate.Height = 24;
            this.dgrTKB.Size = new System.Drawing.Size(746, 493);
            this.dgrTKB.TabIndex = 0;
            this.dgrTKB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTKB_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(920, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // FrmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 648);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgrTKB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTKB";
            this.Text = "FrmTKB";
            this.Load += new System.EventHandler(this.FrmTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrTKB;
        private System.Windows.Forms.TextBox textBox1;
    }
}