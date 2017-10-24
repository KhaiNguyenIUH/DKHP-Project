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
        public frmDKHP2(string input,string input2)//sử dụng Constructor trao đổi dữ liệu giữa 2 form
        {
            InitializeComponent();
            textBox1.Text = input;
            textBox2.Text = input2;
        }
  
        public void loadGridMon(int hk)
        {
            DKHPDataContext db = new DKHPDataContext();
            var nv = (from s in db.MonHocs
                      join w in db.HocKies on s.MaHK equals w.maHK
                      where w.hocKy1 == hk && !(from a in db.SinhVienDangKies
                                                join b in db.LopHocPhans on a.maLopHP equals b.maLopHP
                                                join n in db.MonHocs on b.maMH equals n.maMH
                                                where a.maSV == Int32.Parse(textBox1.Text)
                                                select n.tenMon).Contains(s.tenMon)
                      select new
                      {
                          s.maMH,
                          s.tinChi,
                          s.tenMon,
                          w.hocKy1
                      });
            dgrMon.DataSource = nv;

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
            
        private void frmDKHP2_Load_1(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            loadgridLHPDK(Int32.Parse(textBox1.Text));
            var j = (from g in db.HocKies
                     where g.NamHoc <= Int32.Parse(textBox2.Text)
                     select new
                     {
                         g.NamHoc,
                         g.hocKy1
                     });
            cboHocKy.DataSource = j;
            cboHocKy.DisplayMember = "hocKy1";
            cboHocKy.ValueMember = "NamHoc";
            
        }
        //Sự Kiện Lấy Giá Trị Trên DgrMon
        private void dgrMon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrMon.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                loadGridLHP(dtr.Cells[0].Value.ToString());
            }
            if (dgrMon.RowCount == 0)
            {
                dgrLopHocPhan.DataSource = null;
            }
        }
        //Sự Kiện Lấy Giá Trị Trên DgrLopHocPhan
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

            var v = (from a in db.LopHocPhans
                     join r in db.GiangViens on a.maGV equals r.maGV
                     where a.maLopHP == ma
                     select new
                     {
                         a.maLopHP,
                         a.tenLop,
                         a.LichHoc,
                         r.hotenGV
                     });
            foreach (var x in v)
            {
                lblMaLopHP.Text = x.maLopHP.ToString();
                lblTenGiaoVien.Text = x.hotenGV.ToString();
                lblSoLuong.Text = x.LichHoc.ToString();
                lblTongso.Text = x.tenLop.ToString();
            }
        }
        public void loadgridLHPDK(int ma)
        {
            DKHPDataContext db = new DKHPDataContext();
            var v = (from a in db.SinhVienDangKies                     
                     join b in db.LopHocPhans on a.maLopHP equals b.maLopHP
                     join n in db.MonHocs on b.maMH equals n.maMH
                     where a.maSV == ma
                     select new
                     {
                         b.maLopHP,
                         n.tenMon,
                         n.tinChi
                     });
            dgrLHPDK.DataSource = v;
        }
        private void btnDK_Click(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrLopHocPhan.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                int hk = 0;
                int.TryParse(cboHocKy.Text.ToString(), out hk);
                db = new DKHPDataContext();
                SinhVienDangKy g = new SinhVienDangKy();
                g.maSV = Int32.Parse(textBox1.Text);
                g.maLopHP = Int32.Parse(dtr.Cells[0].Value.ToString());
                db.SinhVienDangKies.InsertOnSubmit(g);
                db.SubmitChanges();
                loadgridLHPDK(Int32.Parse(textBox1.Text));
                cboHocKy_SelectedIndexChanged(cboHocKy, null);
                dgrMon_SelectionChanged(dgrMon, null);
                //loadGridMon(hk);
            }
            else
            {
                MessageBox.Show("Chưa Chọn Lớp");
            }

        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hk = 0;
            int.TryParse(cboHocKy.Text.ToString(),out hk);
            loadGridMon(hk);
            
            
            //MessageBox.Show(cboHocKy.Text.ToString());
        }

        private void dgrMon_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgrMon.RowCount > 0)
               dgrMon.Rows[0].Cells[0].Selected = true;
        }
    }
}
