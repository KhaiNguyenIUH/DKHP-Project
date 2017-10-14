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
    public partial class frmDKHP2 : Form
    {
        DKHPDataContext db = new DKHPDataContext();
        public frmDKHP2(string input)//sử dụng Constructor trao đổi dữ liệu giữa 2 form
        {
            InitializeComponent();
            textBox1.Text = input;
        }


        private void frmDKHP2_Load(object sender, EventArgs e)
        {
            
        }
        public void loadGridMon(int hk)
        {
            DKHPDataContext db = new DKHPDataContext();
            //var nvCol = db.MonHocs.Where(mahk => mahk.MaHK == hk);
            var nv = (from s in db.MonHocs
                      join w in db.HocKies on s.MaHK equals w.maHK
                      where w.hocKy == hk
                     select new
                     {
                         s.maMH,
                         s.tinChi,
                         s.tenMon,                         
                         s.MaHK
                    });
            //var nvcal=db.MonHocs.Where(mahj=>mahj.maMH==nvCol)
            dgrMon.DataSource = nv;
            //dgrMon.DataSource = from u in db.MonHocs
            //                    join et in db.HocKies on u.MaHK equals et.maHK
            //                    select u;
            formatGrid();
        }
        public void loadGridLHP(string mamon)
        {
            DKHPDataContext db = new DKHPDataContext();
            var n = (from s in db.MonHocs
                     join c in db.LopHocPhans on s.maMH equals c.maMH
                     where s.maMH == mamon
                     select new
                     {
                         c.maLopHP,
                         s.tenMon,                        
                         c.tenLop,
                         s.tinChi
                     });
            dgrLopHocPhan.DataSource = n;
        }
        public void formatGrid()
        {
            if (dgrMon.Columns["lyThuyet"] != null)
            {
                dgrMon.Columns["lyThuyet"].Visible = false;
            }
            if (dgrMon.Columns["thucHanh"] != null)
            {
                dgrMon.Columns["thucHanh"].Visible = false;
            }
            if (dgrMon.Columns["maHK"] != null)
            {
                dgrMon.Columns["maHK"].Visible = false;
            }
            if (dgrMon.Columns["maMH"] != null)
            {
                dgrMon.Columns["maMH"].HeaderText = "Mã Môn Học";
                dgrMon.Columns["maMH"].Width = 30 * dgrMon.Width / 100;
            }
            if (dgrMon.Columns["tenMon"] != null)
            {
                dgrMon.Columns["tenMon"].HeaderText = "Môn";
                dgrMon.Columns["tenMon"].Width = 50 * dgrMon.Width / 100;
            }
            if (dgrMon.Columns["tinChi"] != null)
            {
                dgrMon.Columns["tinChi"].HeaderText = "Tín Chỉ";
                dgrMon.Columns["tinChi"].Width = 20 * dgrMon.Width / 100;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 1)
            {
                loadGridMon(1);
            }
            else
                loadGridMon(2);
        }

        private void frmDKHP2_Load_1(object sender, EventArgs e)
        {

        }

        private void dgrMon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrMon.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                lblMaLopHP.Text = "";
                lblSoLuong.Text = "";
                lblTenGiaoVien.Text = "";
                lblTongso.Text = "";
                loadGridLHP(dtr.Cells[0].Value.ToString());
            }
            if (dgrMon.RowCount == 0)
            {
                dgrLopHocPhan.DataSource = null;
            }
        }

        private void dgrLopHocPhan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrLopHocPhan.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {              
                loadTTLHP(Int32.Parse(dtr.Cells[0].Value.ToString()));
            }
            if (dgrLopHocPhan.RowCount == 0)
            {
                lblMaLopHP.Text = "";
                lblSoLuong.Text = "";
                lblTenGiaoVien.Text = "";
                lblTongso.Text = "";
            }
            
        }
        public void loadTTLHP(int ma)
        {
            DKHPDataContext db = new DKHPDataContext();
            
            var v = (from a in db.ChiTietLopHocPhans
                     join r in db.GiangViens on a.maGV equals r.maGV
                     where a.maLopHP==ma
                     select new
                     {
                         a.maLopHP,
                         a.soLuongHienTai,
                         a.soLuongToiDa,
                         r.hotenGV
                     });
            foreach(var x in v)
            {
                lblMaLopHP.Text = x.maLopHP.ToString();
                lblTenGiaoVien.Text = x.hotenGV.ToString();
                lblSoLuong.Text = x.soLuongHienTai.ToString();
                lblTongso.Text = x.soLuongToiDa.ToString();
            }
        }
    }
}
