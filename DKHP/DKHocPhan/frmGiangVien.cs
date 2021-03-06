﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessEntity;
using DAL;
using System.Data.Linq;
using System.IO;

namespace DKHocPhan
{
    public partial class frmGiangVien : Form
    {
        List<Color> colors = new List<Color>();
        int curcolor = 0;
        int loop = 0;
        public frmGiangVien(string input)
        {
            InitializeComponent();
            lblMGV.Text = input;
            colors.Add(Color.FromArgb(0, 58, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            DKHPDataContext db = new DKHPDataContext();
            var user = db.GiangViens.Where(x => x.maGV == Int32.Parse(lblMGV.Text)).SingleOrDefault();
            {
                lblTen.Text = user.hotenGV;
                lblNganh.Text = user.nganh;
                if (user.image != null)
                {
                    MemoryStream memory = new MemoryStream(user.image.ToArray());
                    Image img = Image.FromStream(memory);
                    if (img == null)
                        return;
                    ptrAva.Image = img;
                }
                

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
        Bunifu.Framework.UI.Drag drag = new Bunifu.Framework.UI.Drag();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag.Grab(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag.Release();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MoveObject();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DoiMau_Tick(object sender, EventArgs e)
        {
            if (curcolor < colors.Count - 1)
            {
                label9.ForeColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, colors[curcolor], colors[curcolor + 1]);
                if (loop < 100)
                {
                    loop++;
                }
                else
                {
                    loop = 0;
                    curcolor++;
                }
            }
            else
                curcolor = 0;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            frmLogin t = new frmLogin();
            t.Show();
            this.Hide();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnLichDay_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            this.panel2.Controls.Clear();
            frmLichDay dk = new frmLichDay(lblMGV.Text);
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            bunifuTransition1.Show(panel2);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            this.panel2.Controls.Clear();
            frmDiem dk = new frmDiem(lblMGV.Text);
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            bunifuTransition1.Show(panel2);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                bunifuTransition3.Show(panel1);
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
    }
}
