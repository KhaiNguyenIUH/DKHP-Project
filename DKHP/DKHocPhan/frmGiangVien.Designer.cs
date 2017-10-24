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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btMenu = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnKhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnCo = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMGV = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.ptrAva = new System.Windows.Forms.PictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnXemDiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLichDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblNganh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DoiMau = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btMenu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.lblMGV);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ptrAva);
            this.panel3.Controls.Add(this.lblTen);
            this.panel3.Controls.Add(this.btnXemDiem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnLichDay);
            this.panel3.Controls.Add(this.lblKhoa);
            this.panel3.Controls.Add(this.lblNganh);
            this.bunifuTransition3.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 650);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btMenu
            // 
            this.btMenu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btMenu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btMenu.Appearance.Options.UseBackColor = true;
            this.btMenu.Appearance.Options.UseForeColor = true;
            this.btMenu.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btMenu.AppearanceHovered.Options.UseBackColor = true;
            this.btMenu.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMenu.AppearancePressed.Options.UseBackColor = true;
            this.btMenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bunifuTransition3.SetDecoration(this.btMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btMenu, BunifuAnimatorNS.DecorationType.None);
            this.btMenu.Location = new System.Drawing.Point(210, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(51, 23);
            this.btMenu.TabIndex = 19;
            this.btMenu.Text = "Logout";
            this.btMenu.ToolTip = "Đăng Xuất";
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.btnKhong);
            this.panel1.Controls.Add(this.btnCo);
            this.bunifuTransition3.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 217);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 72);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(216, 17);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Bạn Chắc Chắn Muốn Đăng Xuất?";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhong
            // 
            this.btnKhong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnKhong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKhong.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKhong.Appearance.Options.UseBackColor = true;
            this.btnKhong.Appearance.Options.UseFont = true;
            this.btnKhong.Appearance.Options.UseForeColor = true;
            this.btnKhong.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnKhong.AppearanceHovered.Options.UseBackColor = true;
            this.btnKhong.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhong.AppearancePressed.Options.UseBackColor = true;
            this.btnKhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bunifuTransition3.SetDecoration(this.btnKhong, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnKhong, BunifuAnimatorNS.DecorationType.None);
            this.btnKhong.Location = new System.Drawing.Point(132, 135);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(51, 23);
            this.btnKhong.TabIndex = 17;
            this.btnKhong.Text = "Không";
            this.btnKhong.ToolTip = "Đăng Xuất";
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnCo
            // 
            this.btnCo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCo.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCo.Appearance.Options.UseBackColor = true;
            this.btnCo.Appearance.Options.UseFont = true;
            this.btnCo.Appearance.Options.UseForeColor = true;
            this.btnCo.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnCo.AppearanceHovered.Options.UseBackColor = true;
            this.btnCo.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCo.AppearancePressed.Options.UseBackColor = true;
            this.btnCo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bunifuTransition3.SetDecoration(this.btnCo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnCo, BunifuAnimatorNS.DecorationType.None);
            this.btnCo.Location = new System.Drawing.Point(55, 135);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(51, 23);
            this.btnCo.TabIndex = 17;
            this.btnCo.Text = "Có";
            this.btnCo.ToolTip = "Đăng Xuất";
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // label9
            // 
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "© K ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Giảng Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Giảng Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.BorderRadius = 7;
            this.btnThoat.ButtonText = "X";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.btnThoat, BunifuAnimatorNS.DecorationType.None);
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
            // lblMGV
            // 
            this.lblMGV.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblMGV, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblMGV, BunifuAnimatorNS.DecorationType.None);
            this.lblMGV.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMGV.ForeColor = System.Drawing.Color.White;
            this.lblMGV.Location = new System.Drawing.Point(124, 159);
            this.lblMGV.Name = "lblMGV";
            this.lblMGV.Size = new System.Drawing.Size(0, 17);
            this.lblMGV.TabIndex = 15;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khoa:";
            // 
            // ptrAva
            // 
            this.bunifuTransition1.SetDecoration(this.ptrAva, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.ptrAva, BunifuAnimatorNS.DecorationType.None);
            this.ptrAva.Location = new System.Drawing.Point(44, 12);
            this.ptrAva.Name = "ptrAva";
            this.ptrAva.Size = new System.Drawing.Size(150, 100);
            this.ptrAva.TabIndex = 3;
            this.ptrAva.TabStop = false;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTen, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblTen, BunifuAnimatorNS.DecorationType.None);
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(124, 190);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(0, 17);
            this.lblTen.TabIndex = 11;
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
            this.bunifuTransition3.SetDecoration(this.btnXemDiem, BunifuAnimatorNS.DecorationType.None);
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
            this.btnXemDiem.Location = new System.Drawing.Point(26, 434);
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
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngành";
            // 
            // btnLichDay
            // 
            this.btnLichDay.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnLichDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLichDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichDay.BorderRadius = 5;
            this.btnLichDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLichDay.ButtonText = "    Xem Lịch Dạy";
            this.btnLichDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.btnLichDay, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnLichDay, BunifuAnimatorNS.DecorationType.None);
            this.btnLichDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnLichDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLichDay.Iconimage = null;
            this.btnLichDay.Iconimage_right = null;
            this.btnLichDay.Iconimage_right_Selected = null;
            this.btnLichDay.Iconimage_Selected = null;
            this.btnLichDay.IconMarginLeft = 0;
            this.btnLichDay.IconMarginRight = 0;
            this.btnLichDay.IconRightVisible = true;
            this.btnLichDay.IconRightZoom = 0D;
            this.btnLichDay.IconVisible = true;
            this.btnLichDay.IconZoom = 90D;
            this.btnLichDay.IsTab = true;
            this.btnLichDay.Location = new System.Drawing.Point(26, 371);
            this.btnLichDay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLichDay.Name = "btnLichDay";
            this.btnLichDay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLichDay.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLichDay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLichDay.selected = false;
            this.btnLichDay.Size = new System.Drawing.Size(218, 53);
            this.btnLichDay.TabIndex = 0;
            this.btnLichDay.Text = "    Xem Lịch Dạy";
            this.btnLichDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichDay.Textcolor = System.Drawing.Color.White;
            this.btnLichDay.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichDay.Click += new System.EventHandler(this.btnLichDay_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblKhoa, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblKhoa, BunifuAnimatorNS.DecorationType.None);
            this.lblKhoa.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.ForeColor = System.Drawing.Color.White;
            this.lblKhoa.Location = new System.Drawing.Point(85, 227);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(0, 17);
            this.lblKhoa.TabIndex = 14;
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblNganh, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lblNganh, BunifuAnimatorNS.DecorationType.None);
            this.lblNganh.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganh.ForeColor = System.Drawing.Color.White;
            this.lblNganh.Location = new System.Drawing.Point(90, 258);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(0, 17);
            this.lblNganh.TabIndex = 13;
            // 
            // panel2
            // 
            this.bunifuTransition3.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 647);
            this.panel2.TabIndex = 2;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // DoiMau
            // 
            this.DoiMau.Enabled = true;
            this.DoiMau.Interval = 1;
            this.DoiMau.Tick += new System.EventHandler(this.DoiMau_Tick);
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.bunifuTransition3.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition3.DefaultAnimation = animation2;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnLichDay;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer DoiMau;
        private DevExpress.XtraEditors.SimpleButton btMenu;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private DevExpress.XtraEditors.SimpleButton btnKhong;
        private DevExpress.XtraEditors.SimpleButton btnCo;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
    }
}