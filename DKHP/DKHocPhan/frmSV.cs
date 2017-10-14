using System;
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
namespace DKHocPhan
{
    public partial class frmSV : Form
    {
        
        public frmSV(string input)
        {
            InitializeComponent();
            lblMSV.Text = input;
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.panel2.Controls.Clear();
            frmDKHP2 dk = new frmDKHP2(lblMSV.Text);
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);           
            dk.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.panel2.Controls.Clear();
            frmDiem dk = new frmDiem();
            dk.TopLevel = false;
            this.panel2.Controls.Add(dk);
            dk.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(tileControl1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            DKHPDataContext db=new DKHPDataContext();
            var user = db.SinhViens.Where(x => x.maSV == Int32.Parse(lblMSV.Text)).SingleOrDefault();
            {
                lblTen.Text=user.hotenSV;
                lblKhoa.Text = user.khoa;
                lblLop.Text = user.lop;
                lblChuyenNganh.Text = user.nganh;
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmLogin flg = new frmLogin();
            flg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
