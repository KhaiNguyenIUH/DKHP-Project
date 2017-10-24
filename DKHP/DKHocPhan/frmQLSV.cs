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
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }
        Boolean sua;
        Boolean Them;
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myimage = Image.FromFile(file);
            pictureBox1.Image = myimage;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DKHPDataContext db = new DKHPDataContext();
            if(txtMSV.Text!="" && txtLop.Text!="" && txtTen.Text!="" && txtKhoa.Text!="" && txtChuyenNganh.Text!="" && pictureBox1.Image!=null)
            { 
                if(sua)
                {
                    SinhVien f = db.SinhViens.Single(p => p.maSV == Int32.Parse(txtMSV.Text));
                    f.hotenSV = txtTen.Text;
                    f.khoa = txtKhoa.Text;
                    f.lop = txtLop.Text;
                    f.nganh = txtChuyenNganh.Text;
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, ImageFormat.Png);
                    f.image = stream.ToArray();
                    db.SubmitChanges();
                    setEnableControl(false);
                    btnLuu.Enabled = false;
                    txtMSV.Enabled = true;
                }
                if(Them)
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, ImageFormat.Png);
                        SinhVien sv = new SinhVien();
                        sv.hotenSV = txtTen.Text;
                        sv.maSV = Int32.Parse(txtMSV.Text);
                        sv.lop = txtLop.Text;
                        sv.nganh = txtChuyenNganh.Text;
                        sv.khoa = txtKhoa.Text;
                        if (pictureBox1.Image != null)
                        sv.image = stream.ToArray();
                        db.SinhViens.InsertOnSubmit(sv);
                        db.SubmitChanges();
                        setEnableControl(false);
                        btnLuu.Enabled = false;
                        txtMSV.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Sai kiểu dữ liệu");
                        txtKhoa.Clear();
                        txtLop.Clear();
                        txtMSV.Clear();
                        txtTen.Clear();
                        txtChuyenNganh.Clear();
                        txtMSV.Focus();
                        pictureBox1.Image = null;

                    }

                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đầy Đủ Thông Tin");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {          
            DKHPDataContext db = new DKHPDataContext();
            try
            {
                if (txtMSV.Text != "")
                {
                    var d = db.SinhViens.Where(g => g.maSV == Int32.Parse(txtMSV.Text)).FirstOrDefault();
                    if (d != null)
                    {
                        txtTen.Text = d.hotenSV;
                        txtLop.Text = d.lop;
                        txtKhoa.Text = d.khoa;
                        txtChuyenNganh.Text = d.nganh;
                        if (d.image != null)
                        {
                            MemoryStream memory = new MemoryStream(d.image.ToArray());
                            Image img = Image.FromStream(memory);
                            if (img == null)
                                return;
                            pictureBox1.Image = img;
                        }
                        loadLHP(Int32.Parse(txtMSV.Text));
                        btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không Tìm Thấy Sinh Viên");//Thay Đổi
                        txtChuyenNganh.Clear();
                        txtKhoa.Clear();
                        txtLop.Clear();
                        txtMSV.Clear();
                        txtTen.Clear();
                        txtMSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Nhập MSSV");
                }
            }
            catch
            {
                MessageBox.Show("MSSV là số");
            }
        }
        private void loadLHP(int masv)
        {
            DKHPDataContext db = new DKHPDataContext();
            var g = (from y in db.SinhVienDangKies
                     join h in db.LopHocPhans on y.maLopHP equals h.maLopHP
                     where y.maSV == masv
                     select new
                     {
                         h.maLopHP,
                         h.LichHoc,
                         h.tenLop,
                         h.ThoiGianBDHoc,
                         h.ThoiGianKetThuc
                     });
            dgrLHP.DataSource = g;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            sua = true;
            Them = false;
            btnLuu.Enabled = true;
            txtMSV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            sua = false;
            Them = true;
            txtChuyenNganh.Clear();
            txtKhoa.Clear();
            txtLop.Clear();
            txtMSV.Clear();
            txtTen.Clear();
            txtMSV.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }
        private void setEnableControl(Boolean s)
        {
            txtChuyenNganh.Enabled = s;
            txtKhoa.Enabled = s;
            txtLop.Enabled = s;
            txtMSV.Enabled = s;
            txtTen.Enabled = s;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dgrLHP.CurrentRow;
            if (dtr != null && !dtr.IsNewRow)
            {
                DKHPDataContext db = new DKHPDataContext();
                var j = db.SinhVienDangKies.Where(p => p.maLopHP == Int32.Parse((dtr.Cells[0].Value.ToString())) && p.maSV == Int32.Parse(txtMSV.Text)).FirstOrDefault();
                db.SinhVienDangKies.DeleteOnSubmit(j);
                db.SubmitChanges();
                loadLHP(Int32.Parse(txtMSV.Text));
            }
        }
    }
}
