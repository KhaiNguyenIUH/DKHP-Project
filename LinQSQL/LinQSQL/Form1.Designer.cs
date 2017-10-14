namespace LinQSQL
{
    partial class frmQLNV
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
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhsuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.btnHuyPB = new System.Windows.Forms.Button();
            this.btnCapNhatPB = new System.Windows.Forms.Button();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnChinhSua1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnCapnhat1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(43, 38);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(264, 24);
            this.cboPhongBan.TabIndex = 0;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnChinhsuaPB);
            this.groupBox1.Controls.Add(this.btnThemPB);
            this.groupBox1.Controls.Add(this.btnHuyPB);
            this.groupBox1.Controls.Add(this.btnCapNhatPB);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật Phòng Ban";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(10, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 65);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhsuaPB
            // 
            this.btnChinhsuaPB.Location = new System.Drawing.Point(164, 104);
            this.btnChinhsuaPB.Name = "btnChinhsuaPB";
            this.btnChinhsuaPB.Size = new System.Drawing.Size(104, 23);
            this.btnChinhsuaPB.TabIndex = 2;
            this.btnChinhsuaPB.Text = "Chỉnh sửa";
            this.btnChinhsuaPB.UseVisualStyleBackColor = true;
            this.btnChinhsuaPB.Click += new System.EventHandler(this.btnChinhsuaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(83, 104);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(75, 23);
            this.btnThemPB.TabIndex = 2;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuyPB
            // 
            this.btnHuyPB.Enabled = false;
            this.btnHuyPB.Location = new System.Drawing.Point(164, 140);
            this.btnHuyPB.Name = "btnHuyPB";
            this.btnHuyPB.Size = new System.Drawing.Size(104, 29);
            this.btnHuyPB.TabIndex = 2;
            this.btnHuyPB.Text = "Hủy";
            this.btnHuyPB.UseVisualStyleBackColor = true;
            this.btnHuyPB.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhatPB
            // 
            this.btnCapNhatPB.Enabled = false;
            this.btnCapNhatPB.Location = new System.Drawing.Point(83, 140);
            this.btnCapNhatPB.Name = "btnCapNhatPB";
            this.btnCapNhatPB.Size = new System.Drawing.Size(75, 29);
            this.btnCapNhatPB.TabIndex = 2;
            this.btnCapNhatPB.Text = "Cập Nhật";
            this.btnCapNhatPB.UseVisualStyleBackColor = true;
            this.btnCapNhatPB.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Location = new System.Drawing.Point(83, 76);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(185, 22);
            this.txtTenPB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên PB";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Location = new System.Drawing.Point(83, 37);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(185, 22);
            this.txtMaPB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PB";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Location = new System.Drawing.Point(365, 38);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(659, 213);
            this.lvNhanVien.TabIndex = 2;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvNhanVien_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa1);
            this.groupBox2.Controls.Add(this.btnChinhSua1);
            this.groupBox2.Controls.Add(this.btnThem1);
            this.groupBox2.Controls.Add(this.btnHuy1);
            this.groupBox2.Controls.Add(this.btnCapnhat1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật Nhân Viên";
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(649, 75);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(104, 41);
            this.btnXoa1.TabIndex = 3;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnChinhSua1
            // 
            this.btnChinhSua1.Location = new System.Drawing.Point(349, 75);
            this.btnChinhSua1.Name = "btnChinhSua1";
            this.btnChinhSua1.Size = new System.Drawing.Size(104, 41);
            this.btnChinhSua1.TabIndex = 2;
            this.btnChinhSua1.Text = "Chỉnh sửa";
            this.btnChinhSua1.UseVisualStyleBackColor = true;
            this.btnChinhSua1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.Location = new System.Drawing.Point(199, 75);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(104, 41);
            this.btnThem1.TabIndex = 2;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnHuy1
            // 
            this.btnHuy1.Enabled = false;
            this.btnHuy1.Location = new System.Drawing.Point(799, 75);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(104, 41);
            this.btnHuy1.TabIndex = 2;
            this.btnHuy1.Text = "Hủy";
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click);
            // 
            // btnCapnhat1
            // 
            this.btnCapnhat1.Enabled = false;
            this.btnCapnhat1.Location = new System.Drawing.Point(499, 75);
            this.btnCapnhat1.Name = "btnCapnhat1";
            this.btnCapnhat1.Size = new System.Drawing.Size(104, 41);
            this.btnCapnhat1.TabIndex = 2;
            this.btnCapnhat1.Text = "Cập Nhật";
            this.btnCapnhat1.UseVisualStyleBackColor = true;
            this.btnCapnhat1.Click += new System.EventHandler(this.btnCapnhat1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(811, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Phòng Ban";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(559, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(135, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(332, 28);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(167, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(108, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhân viên";
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 414);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPhongBan);
            this.Name = "frmQLNV";
            this.Text = "Quản lý NHÂN VIÊN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChinhsuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.Button btnHuyPB;
        private System.Windows.Forms.Button btnCapNhatPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChinhSua1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnCapnhat1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoa1;
    }
}

