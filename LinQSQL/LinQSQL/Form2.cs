using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        QLNVDataContext qlnv;
        Boolean them;
        private void Form2_Load(object sender, EventArgs e)
        {
            qlnv = new QLNVDataContext();
            setComboDataSource();
        }
        private void setComboDataSource()
        {
            cboPhongBan.DataSource = null;
            //dataGridView1.DataSource = null;
            qlnv = new QLNVDataContext();

            cboPhongBan.DataSource = qlnv.PhongBans;
            cboPhongBan.DisplayMember = "tenpb";
            cboPhongBan.ValueMember = "mapb";
            //dataGridView1.DataSource=qlnv.NhanViens;
            cboPhongBan.Refresh();
        }
        private void loadNStoGridView(PhongBan pb)
        {
            var nvCol = qlnv.NhanViens.Where(nv => nv.Mapb == pb.Mapb);
            //var nvCol = qlnv.getNhanVienbyMapb(pb.Mapb);
            //var nvCol =qlnv.get
            dataGridView1.DataSource = nvCol;
        }
        private void clearTextBox()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            textBox1.Clear();
            txtMaNV.Focus();
        }
        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPhongBan.SelectedItem!=null)
            {
                PhongBan pb = (PhongBan)cboPhongBan.SelectedItem;
                loadNStoGridView(pb);
            }
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            qlnv.SubmitChanges();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dtr = dataGridView1.CurrentRow;
            if(dtr !=null && !dtr.IsNewRow)
            {
                loadNVtoTextBox(dtr);
            }
            if(dataGridView1.RowCount==0)
            {
                clearTextBoxNV();
            }
        }
        private void clearTextBoxNV()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            textBox1.Clear();
        }
        private void loadNVtoTextBox(DataGridViewRow dtr)
        {
            txtMaNV.Text = dtr.Cells[0].Value.ToString();
            txtTenNV.Text = dtr.Cells[1].Value.ToString();
            txtDiaChi.Text = dtr.Cells[2].Value.ToString();
            textBox1.Text = cboPhongBan.Text;
        }
        //mặc định dòng đầu tiên của datagridview là selected
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                dataGridView1.Rows[0].Cells[0].Selected = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            clearTextBox();
            them = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            txtMaNV.Enabled = false;
            textBox1.Enabled = false;
            them = false;
        }
        private void setEnableControl(Boolean enable)
        {
            txtMaNV.Enabled = enable;
            txtTenNV.Enabled = enable;
            txtDiaChi.Enabled = enable;
            button5.Enabled = enable;
            /*btnHuyPB.Enabled = enable;
            btnThemPB.Enabled = !enable;
            btnChinhsuaPB.Enabled = !enable;
            */
        }
        /*private bool Kiemtrama(int maso)
        {
            var col =qlnv.NhanViens.Where(p => p.Manv == maso);
            foreach (var ms in col)
            {
                if(ms.Manv=maso)
            }
         
        }*/
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                if (them)
                {
                    /*if (Kiemtrama(Convert.ToInt32(txtMaNV.Text)) == true)
                    {*/
                        NhanVien nv = new NhanVien();
                        nv.Manv = int.Parse(txtMaNV.Text);
                        nv.Tennv = txtMaNV.Text;
                        nv.Diachi = txtDiaChi.Text;
                        //nv.Mapb = cboPhongBan.SelectedValue;
                        qlnv.NhanViens.InsertOnSubmit(nv);
                        qlnv.SubmitChanges();
                        setEnableControl(false);
                        dataGridView1.Refresh();
                        cboPhongBan_SelectedIndexChanged(cboPhongBan, null);
                        //loadNStoGridView(pb);
                   /* }
                    else
                        MessageBox.Show("Mã bị trùng!!");*/
                }
                else
                {
                    NhanVien nv = qlnv.NhanViens.Single(p => p.Manv == Convert.ToInt32(txtMaNV.Text));
                    nv.Tennv = txtTenNV.Text;
                    nv.Diachi = txtDiaChi.Text;
                    qlnv.SubmitChanges();
                    cboPhongBan_SelectedIndexChanged(cboPhongBan, null);
                    setEnableControl(true);
                }
            }
        }

    }
}
