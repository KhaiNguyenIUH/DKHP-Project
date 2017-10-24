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
    public partial class FrmTKB : Form
    {
        DKHPDataContext db;
        public FrmTKB(string input)
        {
            InitializeComponent();
            textBox1.Text = input;
        }

        private void dgrTKB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTKB_Load(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            var g = (from u in db.SinhVienDangKies
                     join f in db.LopHocPhans on u.maLopHP equals f.maLopHP
                     join t in db.MonHocs on f.maMH equals t.maMH
                     join h in db.HocKies on f.maHK equals h.maHK
                     where u.maSV == Int32.Parse(textBox1.Text)
                     orderby h.hocKy1
                     select new
                     {
                         t.tenMon,
                         f.PhongHoc,
                         f.LichHoc,
                         f.ThoiGianBDHoc,
                         f.ThoiGianKetThuc,
                         h.hocKy1
                     }
                );
            dgrTKB.DataSource = g;
        }
    }
}
