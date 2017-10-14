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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myimage = Image.FromFile(file);
            pictureBox1.Image = myimage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Png);
            DKHPDataContext db = new DKHPDataContext();
            SinhVien sv = new SinhVien();
            sv.hotenSV = txtTen.Text;
            sv.maSV = Int32.Parse(txtMSV.Text);
            sv.lop = txtLop.Text;
            sv.nganh = txtChuyenNganh.Text;
            sv.khoa = txtKhoa.Text;
            sv.image = stream.ToArray();
            db.SinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();
        }
    }
}
