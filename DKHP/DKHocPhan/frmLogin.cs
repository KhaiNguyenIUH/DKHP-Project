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
namespace DKHocPhan
{
    public partial class frmLogin : Form
    {
        TaiKhoanBLL tkBLL;
        public frmLogin()
        {
            tkBLL = new TaiKhoanBLL();
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tkBLL.KiemTraDangNhap(int.Parse(txtID.Text), txtPass.Text) == 1)
                {
                    frmSinhVien fsv = new frmSinhVien(txtID.Text);
                    fsv.Show();
                    this.Hide();
                }
                else if (tkBLL.KiemTraDangNhap(int.Parse(txtID.Text), txtPass.Text) == 2)
                {
                    frmGiangVien fgv = new frmGiangVien(txtID.Text);
                    fgv.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai Thông Tin Tài Khoản");
                    txtID.Clear();
                    txtPass.Clear();
                    txtID.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sai Định Dạng");
                txtID.Clear();
                txtPass.Clear();
                txtID.Focus();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
