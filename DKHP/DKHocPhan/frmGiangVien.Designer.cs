namespace DKHocPhan
{
    partial class frmGiangVien
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btndrop = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMGV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.btnThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ptrAva = new System.Windows.Forms.PictureBox();
            this.btnXemDiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDKHP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DoiMau = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btndrop);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.ptrAva);
            this.panel3.Controls.Add(this.btnXemDiem);
            this.panel3.Controls.Add(this.btnDKHP);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 650);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label9
            // 
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "© K ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndrop
            // 
            this.btndrop.Appearance.ForeColor = System.Drawing.Color.White;
            this.btndrop.Appearance.Options.UseForeColor = true;
            this.btndrop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bunifuTransition1.SetDecoration(this.btndrop, BunifuAnimatorNS.DecorationType.None);
            this.btndrop.Location = new System.Drawing.Point(230, 12);
            this.btndrop.Name = "btndrop";
            this.btndrop.Size = new System.Drawing.Size(31, 23);
            this.btndrop.TabIndex = 17;
            this.btndrop.Text = "...";
            this.btndrop.Click += new System.EventHandler(this.btndrop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.lblMGV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblKhoa);
            this.panel1.Controls.Add(this.lblNganh);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(17, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 217);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblLogout, BunifuAnimatorNS.DecorationType.None);
            this.lblLogout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(139, 187);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(88, 21);
            this.lblLogout.TabIndex = 17;
            this.lblLogout.Text = "Đăng Xuất";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Giảng Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Giảng Viên";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 167);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(261, 16);
            this.bunifuSeparator2.TabIndex = 16;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblMGV
            // 
            this.lblMGV.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblMGV, BunifuAnimatorNS.DecorationType.None);
            this.lblMGV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMGV.ForeColor = System.Drawing.Color.White;
            this.lblMGV.Location = new System.Drawing.Point(141, 23);
            this.lblMGV.Name = "lblMGV";
            this.lblMGV.Size = new System.Drawing.Size(0, 21);
            this.lblMGV.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khoa:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTen, BunifuAnimatorNS.DecorationType.None);
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(141, 54);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(0, 21);
            this.lblTen.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngành";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblKhoa, BunifuAnimatorNS.DecorationType.None);
            this.lblKhoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.Color.White;
            this.lblKhoa.Location = new System.Drawing.Point(72, 91);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(0, 21);
            this.lblKhoa.TabIndex = 14;
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblNganh, BunifuAnimatorNS.DecorationType.None);
            this.lblNganh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganh.ForeColor = System.Drawing.Color.White;
            this.lblNganh.Location = new System.Drawing.Point(77, 122);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(0, 21);
            this.lblNganh.TabIndex = 13;
            // 
            // btnThoat
            // 
            this.btnThoat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.BorderRadius = 7;
            this.btnThoat.ButtonText = "X";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnThoat, BunifuAnimatorNS.DecorationType.None);
            this.btnThoat.DisabledColor = System.Drawing.Color.Gray;
            this.btnThoat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThoat.Iconimage = null;
            this.btnThoat.Iconimage_right = null;
            this.btnThoat.Iconimage_right_Selected = null;
            this.btnThoat.Iconimage_Selected = null;
            this.btnThoat.IconMarginLeft = 0;
            this.btnThoat.IconMarginRight = 0;
            this.btnThoat.IconRightVisible = true;
            this.btnThoat.IconRightZoom = 0D;
            this.btnThoat.IconVisible = true;
            this.btnThoat.IconZoom = 90D;
            this.btnThoat.IsTab = false;
            this.btnThoat.Location = new System.Drawing.Point(3, -1);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Normalcolor = System.Drawing.Color.Black;
            this.btnThoat.OnHovercolor = System.Drawing.Color.Gray;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThoat.selected = false;
            this.btnThoat.Size = new System.Drawing.Size(32, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "X";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.Textcolor = System.Drawing.Color.White;
            this.btnThoat.TextFont = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 117);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(211, 33);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ptrAva
            // 
            this.bunifuTransition1.SetDecoration(this.ptrAva, BunifuAnimatorNS.DecorationType.None);
            this.ptrAva.Location = new System.Drawing.Point(58, 12);
            this.ptrAva.Name = "ptrAva";
            this.ptrAva.Size = new System.Drawing.Size(150, 100);
            this.ptrAva.TabIndex = 3;
            this.ptrAva.TabStop = false;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnXemDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemDiem.BorderRadius = 5;
            this.btnXemDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnXemDiem.ButtonText = "    Nhập Điểm";
            this.btnXemDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnXemDiem, BunifuAnimatorNS.DecorationType.None);
            this.btnXemDiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnXemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXemDiem.Iconimage = null;
            this.btnXemDiem.Iconimage_right = null;
            this.btnXemDiem.Iconimage_right_Selected = null;
            this.btnXemDiem.Iconimage_Selected = null;
            this.btnXemDiem.IconMarginLeft = 0;
            this.btnXemDiem.IconMarginRight = 0;
            this.btnXemDiem.IconRightVisible = true;
            this.btnXemDiem.IconRightZoom = 0D;
            this.btnXemDiem.IconVisible = true;
            this.btnXemDiem.IconZoom = 90D;
            this.btnXemDiem.IsTab = true;
            this.btnXemDiem.Location = new System.Drawing.Point(26, 328);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnXemDiem.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnXemDiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXemDiem.selected = false;
            this.btnXemDiem.Size = new System.Drawing.Size(218, 53);
            this.btnXemDiem.TabIndex = 0;
            this.btnXemDiem.Text = "    Nhập Điểm";
            this.btnXemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiem.Textcolor = System.Drawing.Color.White;
            this.btnXemDiem.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDKHP
            // 
            this.btnDKHP.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnDKHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnDKHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDKHP.BorderRadius = 5;
            this.btnDKHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDKHP.ButtonText = "    Xem Lịch Dạy";
            this.btnDKHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDKHP, BunifuAnimatorNS.DecorationType.None);
            this.btnDKHP.DisabledColor = System.Drawing.Color.Gray;
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKHP.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDKHP.Iconimage = null;
            this.btnDKHP.Iconimage_right = null;
            this.btnDKHP.Iconimage_right_Selected = null;
            this.btnDKHP.Iconimage_Selected = null;
            this.btnDKHP.IconMarginLeft = 0;
            this.btnDKHP.IconMarginRight = 0;
            this.btnDKHP.IconRightVisible = true;
            this.btnDKHP.IconRightZoom = 0D;
            this.btnDKHP.IconVisible = true;
            this.btnDKHP.IconZoom = 90D;
            this.btnDKHP.IsTab = true;
            this.btnDKHP.Location = new System.Drawing.Point(26, 265);
            this.btnDKHP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnDKHP.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDKHP.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDKHP.selected = false;
            this.btnDKHP.Size = new System.Drawing.Size(218, 53);
            this.btnDKHP.TabIndex = 0;
            this.btnDKHP.Text = "    Xem Lịch Dạy";
            this.btnDKHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDKHP.Textcolor = System.Drawing.Color.White;
            this.btnDKHP.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 647);
            this.panel2.TabIndex = 2;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // DoiMau
            // 
            this.DoiMau.Enabled = true;
            this.DoiMau.Interval = 1;
            this.DoiMau.Tick += new System.EventHandler(this.DoiMau_Tick);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btndrop;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblMGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblNganh;
        private Bunifu.Framework.UI.BunifuFlatButton btnThoat;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox ptrAva;
        private Bunifu.Framework.UI.BunifuFlatButton btnXemDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnDKHP;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer DoiMau;
    }
}