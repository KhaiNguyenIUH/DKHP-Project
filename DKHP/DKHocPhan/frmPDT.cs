using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHocPhan
{
    public partial class frmPDT : Form
    {
        List<Color> colors = new List<Color>();
        int curcolor = 0;
        int loop = 0;
        public frmPDT()
        {
            InitializeComponent();
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

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frmQLSV dk = new frmQLSV();
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            bunifuTransition1.Show(panel2);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frmQLGV dk = new frmQLGV();
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            bunifuTransition1.Show(panel2);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
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

        private void btnMLHP_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frmMoLHP dk = new frmMoLHP();
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            bunifuTransition1.Show(panel2);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
