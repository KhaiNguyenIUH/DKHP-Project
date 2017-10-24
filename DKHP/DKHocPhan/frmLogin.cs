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
            if (txtID.Text != "" && txtPass.Text != "")
            {
                try
                {
                    if (tkBLL.KiemTraDangNhap(int.Parse(txtID.Text), txtPass.Text) == 1)
                    {
                        frmSinhVien fsv = new frmSinhVien(txtID.Text);
                        fsv.Show();
                        bunifuTransition1.ShowSync(fsv);
                        this.Hide();
                    }
                    else if (tkBLL.KiemTraDangNhap(int.Parse(txtID.Text), txtPass.Text) == 2)
                    {
                        frmGiangVien fgv = new frmGiangVien(txtID.Text);
                        fgv.Show();
                        bunifuTransition1.Show(fgv);
                        this.Hide();

                    }
                    else if (tkBLL.KiemTraDangNhap(int.Parse(txtID.Text), txtPass.Text) == 3)
                    {
                        frmPDT pdt = new frmPDT();
                        pdt.Show();
                        bunifuTransition1.Show(pdt);
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
                catch
                {
                    MessageBox.Show("Trường ID Là Kiểu Số");
                    txtID.Clear();
                    txtPass.Clear();
                    txtID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Thông Tin");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
