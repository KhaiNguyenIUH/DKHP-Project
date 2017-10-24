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
    public partial class frmLichDay : Form
    {
        DKHPDataContext db;

        public frmLichDay(string input)
        {
            InitializeComponent();
            textBox1.Text = input;
        }

        private void frmLichDay_Load(object sender, EventArgs e)
        {
            db = new DKHPDataContext();
            var g = (from u in db.GiangViens
                     join f in db.LopHocPhans on u.maGV equals f.maGV
                     join t in db.MonHocs on f.maMH equals t.maMH
                     join h in db.HocKies on f.maHK equals h.maHK
                     where u.maGV == Int32.Parse(textBox1.Text)
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
            dgrLichDay.DataSource = g;
        }
    }
}
