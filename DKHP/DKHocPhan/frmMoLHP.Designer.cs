namespace DKHocPhan
{
    partial class frmMoLHP
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
            this.txtMaLHP = new System.Windows.Forms.TextBox();
            this.txtTenLHP = new System.Windows.Forms.TextBox();
            this.txtLichHoc = new System.Windows.Forms.TextBox();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChapNhan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNhapLai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.Location = new System.Drawing.Point(344, 130);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(129, 22);
            this.txtMaLHP.TabIndex = 0;
            // 
            // txtTenLHP
            // 
            this.txtTenLHP.Location = new System.Drawing.Point(344, 184);
            this.txtTenLHP.Name = "txtTenLHP";
            this.txtTenLHP.Size = new System.Drawing.Size(129, 22);
            this.txtTenLHP.TabIndex = 0;
            // 
            // txtLichHoc
            // 
            this.txtLichHoc.Location = new System.Drawing.Point(625, 130);
            this.txtLichHoc.Name = "txtLichHoc";
            this.txtLichHoc.Size = new System.Drawing.Size(141, 22);
            this.txtLichHoc.TabIndex = 0;
            // 
            // txtPhongHoc
            // 
            this.txtPhongHoc.Location = new System.Drawing.Point(625, 184);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(47, 22);
            this.txtPhongHoc.TabIndex = 0;
            // 
            // dtpBD
            // 
            this.dtpBD.Location = new System.Drawing.Point(625, 232);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(141, 22);
            this.dtpBD.TabIndex = 1;
            this.dtpBD.Value = new System.DateTime(2017, 10, 19, 22, 11, 29, 0);
            // 
            // dtpKT
            // 
            this.dtpKT.Location = new System.Drawing.Point(625, 284);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(141, 22);
            this.dtpKT.TabIndex = 1;
            this.dtpKT.Value = new System.DateTime(2017, 10, 19, 22, 11, 38, 0);
            // 
            // cboHocKi
            // 
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Location = new System.Drawing.Point(344, 284);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(129, 24);
            this.cboHocKi.TabIndex = 2;
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(344, 342);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(129, 24);
            this.cboMon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Lớp Học Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Lớp Học Phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lịch Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học Kì";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày Bắt Đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Kết Thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phòng Học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Môn";
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.FormattingEnabled = true;
            this.cboGiangVien.Location = new System.Drawing.Point(344, 234);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(129, 24);
            this.cboGiangVien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giảng Viên";
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChapNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChapNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChapNhan.BorderRadius = 7;
            this.btnChapNhan.ButtonText = "Xác Nhận";
            this.btnChapNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChapNhan.DisabledColor = System.Drawing.Color.Gray;
            this.btnChapNhan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChapNhan.Iconimage = null;
            this.btnChapNhan.Iconimage_right = null;
            this.btnChapNhan.Iconimage_right_Selected = null;
            this.btnChapNhan.Iconimage_Selected = null;
            this.btnChapNhan.IconMarginLeft = 0;
            this.btnChapNhan.IconMarginRight = 0;
            this.btnChapNhan.IconRightVisible = true;
            this.btnChapNhan.IconRightZoom = 0D;
            this.btnChapNhan.IconVisible = true;
            this.btnChapNhan.IconZoom = 90D;
            this.btnChapNhan.IsTab = false;
            this.btnChapNhan.Location = new System.Drawing.Point(445, 442);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChapNhan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChapNhan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChapNhan.selected = false;
            this.btnChapNhan.Size = new System.Drawing.Size(321, 59);
            this.btnChapNhan.TabIndex = 4;
            this.btnChapNhan.Text = "Xác Nhận";
            this.btnChapNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChapNhan.Textcolor = System.Drawing.Color.White;
            this.btnChapNhan.TextFont = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNhapLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhapLai.BorderRadius = 7;
            this.btnNhapLai.ButtonText = "Nhập Lại";
            this.btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapLai.DisabledColor = System.Drawing.Color.Gray;
            this.btnNhapLai.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNhapLai.Iconimage = null;
            this.btnNhapLai.Iconimage_right = null;
            this.btnNhapLai.Iconimage_right_Selected = null;
            this.btnNhapLai.Iconimage_Selected = null;
            this.btnNhapLai.IconMarginLeft = 0;
            this.btnNhapLai.IconMarginRight = 0;
            this.btnNhapLai.IconRightVisible = true;
            this.btnNhapLai.IconRightZoom = 0D;
            this.btnNhapLai.IconVisible = true;
            this.btnNhapLai.IconZoom = 90D;
            this.btnNhapLai.IsTab = false;
            this.btnNhapLai.Location = new System.Drawing.Point(209, 442);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNhapLai.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNhapLai.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNhapLai.selected = false;
            this.btnNhapLai.Size = new System.Drawing.Size(104, 59);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhapLai.Textcolor = System.Drawing.Color.White;
            this.btnNhapLai.TextFont = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // frmMoLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 648);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.cboGiangVien);
            this.Controls.Add(this.cboHocKi);
            this.Controls.Add(this.dtpKT);
            this.Controls.Add(this.dtpBD);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.txtLichHoc);
            this.Controls.Add(this.txtTenLHP);
            this.Controls.Add(this.txtMaLHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMoLHP";
            this.Text = "frmMoLHP";
            this.Load += new System.EventHandler(this.frmMoLHP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLHP;
        private System.Windows.Forms.TextBox txtTenLHP;
        private System.Windows.Forms.TextBox txtLichHoc;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnChapNhan;
        private Bunifu.Framework.UI.BunifuFlatButton btnNhapLai;
    }
}