using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using DAL;
using BusinessLogic;
namespace DKHocPhan
{
    public partial class frmGV : Form
    {
        public frmGV(string input)
        {
            InitializeComponent();
            lblMGV.Text = input;
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(tileControl1);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.panel2.Controls.Clear();
            frmDiem d = new frmDiem();
            d.TopLevel = false;
            this.panel2.Controls.Add(d);
            d.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            DKHPDataContext db = new DKHPDataContext();
            var user = db.GiangViens.Where(x => x.maGV == Int32.Parse(lblMGV.Text)).SingleOrDefault();
            {
                lblTenGv.Text = user.hotenGV;
                //lblKhoa.Text = user;
                lblNganh.Text = user.nganh;
                //lblMGV.Text = user.maGV;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
