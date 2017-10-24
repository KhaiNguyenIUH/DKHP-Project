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
    public partial class frmQLGV : Form
    {
        Boolean sua;
        Boolean Them;
        public frmQLGV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            sua = false;
            Them = true;
            txtChuyenNganh.Clear();
            txtKhoa.Clear();
            txtMGV.Clear();
            txtTen.Clear();
            txtMGV.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }
        private void setEnableControl(Boolean s)
        {
            txtChuyenNganh.Enabled = s;
            txtKhoa.Enabled = s;
            txtMGV.Enabled = s;
            txtTen.Enabled = s;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            sua = true;
            Them = false;
            btnLuu.Enabled = true;
            txtMGV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DKHPDataContext db = new DKHPDataContext();
            if (txtMGV.Text != "" && txtTen.Text != "" && txtKhoa.Text != "" && txtChuyenNganh.Text != "" && pictureBox1.Image!=null)
            {
                if (sua)
                {
                    GiangVien f = db.GiangViens.Single(p => p.maGV == Int32.Parse(txtMGV.Text));
                    f.hotenGV = txtTen.Text;
                    f.khoa = txtKhoa.Text;
                    f.nganh = txtChuyenNganh.Text;
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, ImageFormat.Png);
                    f.image = stream.ToArray();
                    db.SubmitChanges();
                    setEnableControl(false);
                    btnLuu.Enabled = false;
                    txtMGV.Enabled = true;
                }
                if (Them)
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, ImageFormat.Png);
                        GiangVien sv = new GiangVien();
                        sv.hotenGV = txtTen.Text;
                        sv.maGV = Int32.Parse(txtMGV.Text);
                        sv.nganh = txtChuyenNganh.Text;
                        sv.khoa = txtKhoa.Text;
                        if(pictureBox1.Image!=null)
                        sv.image = stream.ToArray();                 
                        db.GiangViens.InsertOnSubmit(sv);
                        db.SubmitChanges();
                        setEnableControl(false);
                        btnLuu.Enabled = false;
                        txtMGV.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Sai kiểu dữ liệu");
                        txtKhoa.Clear();
                        txtMGV.Clear();
                        txtTen.Clear();
                        txtChuyenNganh.Clear();
                        txtMGV.Focus();
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
                if (txtMGV.Text != "")
                {
                    var d = db.GiangViens.Where(g => g.maGV == Int32.Parse(txtMGV.Text)).FirstOrDefault();
                    if (d != null)
                    {
                        txtTen.Text = d.hotenGV;
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
                        btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không Tìm Thấy Giảng Viên");//Thay Đổi
                        txtChuyenNganh.Clear();
                        txtKhoa.Clear();
                        txtMGV.Clear();
                        txtTen.Clear();
                        txtMGV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Nhập MSGV");
                }
            }
            catch
            {
                MessageBox.Show("MSGV là số");
            }
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

        private void frmQLGV_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
        }
    }
}
