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
using System.IO;
namespace DKHocPhan
{
    public partial class frmDiem : Form
    {
        DKHPDataContext db;
        public frmDiem(string input)
        {
            InitializeComponent();
            textBox1.Text = input;
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            var t = (from f in db.GiangViens
                     join g in db.LopHocPhans on f.maGV equals g.maGV
                     join h in db.MonHocs on g.maMH equals h.maMH
                     where f.maGV == Int32.Parse(textBox1.Text)
                     select new
                     {
                         g.tenLop,
                         h.tenMon,
                         g.maLopHP
                     });
            cboLopHP.DataSource = t;
            cboLopHP.DisplayMember = "tenLop";
            cboLopHP.ValueMember = "maLopHP";
        }

        private void cboLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int hk = 0;
            //int.TryParse(cboHocKy.Text.ToString(), out hk);
            //loadGridMon(hk);
            textBox2.Text= cboLopHP.SelectedValue.ToString();
            //MessageBox.Show(lp.ToString());
            int malop = 0;
            int.TryParse(textBox2.Text.ToString(), out malop);
            loadds(malop);
        }
        private void loadds(int malhp)
        {
            db = new DKHPDataContext();
            var h = (from p in db.SinhVienDangKies
                     join f in db.SinhViens on p.maSV equals f.maSV
                     join t in db.LopHocPhans on p.maLopHP equals t.maLopHP
                     where t.maLopHP == malhp
                     select new
                     {
                         t.maLopHP,
                         f.maSV,
                         f.hotenSV,
                         p.ThuongKi,
                         p.GiuaKi,
                         p.CuoiKi
                     }
                    );
            dgrSV.DataSource = h;
        }

        private void loadSVtoTextBox(DataGridViewRow dtr)
        {
            if(dgrSV.DataSource!=null)
            {
                txtMLHP.Text = dtr.Cells[0].Value.ToString();
                txtMaSV.Text = dtr.Cells[1].Value.ToString();               
            }
        }

        private void dgrSV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrSV.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                loadSVtoTextBox(dtr);
            }
            if (dgrSV.RowCount == 0)
            {
                clearTextBox();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "" && txtGK.Text != "" && txtCK.Text != "")
            {
                db = new DKHPDataContext();
                SinhVienDangKy h = db.SinhVienDangKies.Where(p => p.maSV == Int32.Parse(txtMaSV.Text) && p.maLopHP == Int32.Parse(txtMLHP.Text)).FirstOrDefault();
                h.ThuongKi = Int32.Parse(txtTK.Text);
                h.GiuaKi = Int32.Parse(txtGK.Text);
                h.CuoiKi = Int32.Parse(txtCK.Text);
                db.SubmitChanges();
                cboLopHP_SelectedIndexChanged(cboLopHP, null);
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Chưa Nhập Dữ Liệu");
            }
        }
        private void clearTextBox()
        {
            txtMLHP.Clear();
            txtMaSV.Clear();
            txtGK.Clear();
            txtCK.Clear();
            txtTK.Clear();
        }

    }
}
