namespace DKHocPhan
{
    partial class frmPDT
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPDT));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLichThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXemDiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMLHP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DoiMau = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnLichThi);
            this.panel3.Controls.Add(this.btnXemDiem);
            this.panel3.Controls.Add(this.btnMLHP);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 643);
            this.panel3.TabIndex = 1;
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
            // btnLichThi
            // 
            this.btnLichThi.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnLichThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLichThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichThi.BorderRadius = 5;
            this.btnLichThi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLichThi.ButtonText = "    Thông Tin Giảng Viên";
            this.btnLichThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLichThi, BunifuAnimatorNS.DecorationType.None);
            this.btnLichThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnLichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLichThi.Iconimage = null;
            this.btnLichThi.Iconimage_right = null;
            this.btnLichThi.Iconimage_right_Selected = null;
            this.btnLichThi.Iconimage_Selected = null;
            this.btnLichThi.IconMarginLeft = 0;
            this.btnLichThi.IconMarginRight = 0;
            this.btnLichThi.IconRightVisible = true;
            this.btnLichThi.IconRightZoom = 0D;
            this.btnLichThi.IconVisible = true;
            this.btnLichThi.IconZoom = 90D;
            this.btnLichThi.IsTab = true;
            this.btnLichThi.Location = new System.Drawing.Point(10, 302);
            this.btnLichThi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLichThi.Name = "btnLichThi";
            this.btnLichThi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLichThi.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnLichThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLichThi.selected = false;
            this.btnLichThi.Size = new System.Drawing.Size(243, 53);
            this.btnLichThi.TabIndex = 0;
            this.btnLichThi.Text = "    Thông Tin Giảng Viên";
            this.btnLichThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichThi.Textcolor = System.Drawing.Color.White;
            this.btnLichThi.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichThi.Click += new System.EventHandler(this.btnLichThi_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnXemDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemDiem.BorderRadius = 5;
            this.btnXemDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnXemDiem.ButtonText = "    Thông Tin Sinh Viên";
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
            this.btnXemDiem.Location = new System.Drawing.Point(10, 215);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnXemDiem.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnXemDiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXemDiem.selected = false;
            this.btnXemDiem.Size = new System.Drawing.Size(243, 53);
            this.btnXemDiem.TabIndex = 0;
            this.btnXemDiem.Text = "    Thông Tin Sinh Viên";
            this.btnXemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiem.Textcolor = System.Drawing.Color.White;
            this.btnXemDiem.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnMLHP
            // 
            this.btnMLHP.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnMLHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMLHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMLHP.BorderRadius = 5;
            this.btnMLHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnMLHP.ButtonText = "    Mở Lớp Học Phần";
            this.btnMLHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMLHP, BunifuAnimatorNS.DecorationType.None);
            this.btnMLHP.DisabledColor = System.Drawing.Color.Gray;
            this.btnMLHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMLHP.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMLHP.Iconimage = null;
            this.btnMLHP.Iconimage_right = null;
            this.btnMLHP.Iconimage_right_Selected = null;
            this.btnMLHP.Iconimage_Selected = null;
            this.btnMLHP.IconMarginLeft = 0;
            this.btnMLHP.IconMarginRight = 0;
            this.btnMLHP.IconRightVisible = true;
            this.btnMLHP.IconRightZoom = 0D;
            this.btnMLHP.IconVisible = true;
            this.btnMLHP.IconZoom = 90D;
            this.btnMLHP.IsTab = true;
            this.btnMLHP.Location = new System.Drawing.Point(10, 128);
            this.btnMLHP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMLHP.Name = "btnMLHP";
            this.btnMLHP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMLHP.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnMLHP.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMLHP.selected = false;
            this.btnMLHP.Size = new System.Drawing.Size(243, 53);
            this.btnMLHP.TabIndex = 0;
            this.btnMLHP.Text = "    Mở Lớp Học Phần";
            this.btnMLHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMLHP.Textcolor = System.Drawing.Color.White;
            this.btnMLHP.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMLHP.Click += new System.EventHandler(this.btnMLHP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(268, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 648);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // DoiMau
            // 
            this.DoiMau.Enabled = true;
            this.DoiMau.Tick += new System.EventHandler(this.DoiMau_Tick);
            // 
            // frmPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPDT";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btnThoat;
        private Bunifu.Framework.UI.BunifuFlatButton btnLichThi;
        private Bunifu.Framework.UI.BunifuFlatButton btnXemDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnMLHP;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer DoiMau;
    }
}