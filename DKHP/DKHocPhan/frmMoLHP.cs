using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using DAL;
namespace DKHocPhan
{
    public partial class frmMoLHP : Form
    {
        DKHPDataContext db;
        public frmMoLHP()
        {
            InitializeComponent();
        }

        private void frmMoLHP_Load(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            cboGiangVien.DataSource = db.GiangViens;
            cboGiangVien.DisplayMember = "hotenGV";
            cboGiangVien.ValueMember = "maGV";
            //
            cboHocKi.DataSource = db.HocKies;
            cboHocKi.DisplayMember = "maHK";
            cboHocKi.ValueMember = "hocKy1";
            //
            cboMon.DataSource = db.MonHocs;
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "maMH";
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {            
            if (txtTenLHP.Text != "" && txtPhongHoc.Text != "" && txtMaLHP.Text != "" && txtLichHoc.Text != "" )
            {
                try
                {
                    db = new DKHPDataContext();
                    LopHocPhan h = new LopHocPhan();
                    h.maGV = Int32.Parse(cboGiangVien.SelectedValue.ToString());
                    h.maHK = Int32.Parse(cboHocKi.SelectedValue.ToString());
                    h.maMH = cboMon.SelectedValue.ToString();
                    h.tenLop = txtTenLHP.Text;
                    h.maLopHP = Int32.Parse(txtMaLHP.Text);
                    h.PhongHoc = txtPhongHoc.Text;
                    h.LichHoc = txtLichHoc.Text;
                    h.ThoiGianBDHoc = dtpBD.Value;
                    h.ThoiGianKetThuc = dtpKT.Value;
                    db.LopHocPhans.InsertOnSubmit(h);
                    db.SubmitChanges();
                    MessageBox.Show("Mở Lớp Thành Công");
                    XoaTextBox();
                }
                catch
                {
                    MessageBox.Show("Sai Kiểu Dữ Liệu");
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
            }
        }
        public void XoaTextBox()
        {
            txtLichHoc.Clear();
            txtMaLHP.Clear();
            txtPhongHoc.Clear();
            txtTenLHP.Clear();
            txtMaLHP.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaTextBox();
        }
    }
}
