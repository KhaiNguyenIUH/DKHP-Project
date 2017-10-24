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
    public partial class frmDiemSV : Form
    {
        DKHPDataContext db;
        public frmDiemSV(string input)
        {
            InitializeComponent();
            textBox1.Text = input;
        }

        private void frmDiemSV_Load(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            var g = (from u in db.SinhVienDangKies
                     join f in db.SinhViens on u.maSV equals f.maSV
                     join t in db.LopHocPhans on u.maLopHP equals t.maLopHP
                     join h in db.HocKies on t.maHK equals h.maHK
                     join m in db.MonHocs on t.maMH equals m.maMH
                     where f.maSV == Int32.Parse(textBox1.Text)
                     orderby h.hocKy1
                     select new
                     {
                         t.maLopHP,
                         m.tenMon,
                         u.ThuongKi,
                         u.GiuaKi,
                         u.CuoiKi,
                         h.hocKy1
                     }
                );
            dgrDiem.DataSource = g;
        }
    }
}
