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
    public partial class frmQLNV : Form
    {
        QLNVDataContext qlnv;
        Boolean them;
        
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             qlnv= new QLNVDataContext();
             setComboDataSource();
             lvNhanVien.Columns.Add("Ma NV");
             lvNhanVien.Columns.Add("Ho ten");
             lvNhanVien.Columns.Add("Dia chi");
             lvNhanVien.View = View.Details;
        

        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedItem!=null)
            {
                PhongBan pb = (PhongBan)cboPhongBan.SelectedItem;
                loadPBtoTextBox(pb);
                loadNStoListView(pb);
            }
        }
        private void loadPBtoTextBox(PhongBan pb)
        {
            txtMaPB.Text = pb.Mapb.ToString();
            txtTenPB.Text = pb.Tenpb;
        }
       
        /*private void loadNVtoListView(PhongBan pb)
        {
            lvNhanVien.Items.Clear();
            var nvs= from nv in qlnv.NhanViens
                         where nv.Mapb==pb.Mapb
                         select nv ;
            foreach(var nv in nvs)
            {
                ListViewItem lvi = new ListViewItem(nv.Manv.ToString());
                lvi.SubItems.Add(nv.Tennv);
                lvi.SubItems.Add(nv.Diachi);
                lvNhanVien.Items.Add(lvi);
            }
        }*/
        private void setEnableControl(Boolean enable )
        {
            txtMaPB.Enabled = enable;
            txtTenPB.Enabled = enable;
            btnCapNhatPB.Enabled = enable;
            btnHuyPB.Enabled = enable;
            btnThemPB.Enabled = !enable;
            btnChinhsuaPB.Enabled = !enable;          
        }
        private void clearTextBox()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaPB.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            clearTextBox();
            them = true;
           
            
        }
        private void setComboDataSource()
        {
                cboPhongBan.DataSource = null;
                qlnv = new QLNVDataContext();
                cboPhongBan.DataSource = qlnv.PhongBans;
                cboPhongBan.DisplayMember = "tenpb";
                cboPhongBan.ValueMember = "mapb";
                cboPhongBan.Refresh();
          
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //if(txtMaPB.Text!="" && txtTenPB.Text !="")
            //{
            //    if (them)
            //    {
            //        PhongBan pb = new PhongBan();
            //        pb.Mapb = txtMaPB.Text;
            //        pb.Tenpb = txtTenPB.Text;
            //        qlnv.PhongBans.InsertOnSubmit(pb);
            //        qlnv.SubmitChanges();
            //        setEnableControl(false);
            //        setComboDataSource();//cập nhật phòng ban trên combobox
            //    }
            //    else//chỉnh sửa
            //    {
            //        PhongBan pb=qlnv.PhongBans.Single(p => p.Mapb == cboPhongBan.SelectedValue.ToString());
            //        pb.Tenpb = txtTenPB.Text;
            //        qlnv.SubmitChanges();
            //        setEnableControl(false);
            //       setComboDataSource();//cập nhật phòng ban trên combobox
            //    }
            //}
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedItem != null)
            {
                PhongBan pb = (PhongBan)cboPhongBan.SelectedItem;
                loadPBtoTextBox(pb);
            }
            setEnableControl(false);
        }

        private void btnChinhsuaPB_Click(object sender, EventArgs e)
        {
            setEnableControl(true);
            txtMaPB.Enabled = false;
            them = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //PhongBan pb = qlnv.PhongBans.Single(p => p.Mapb == cboPhongBan.SelectedValue.ToString());
            //qlnv.PhongBans.DeleteOnSubmit(pb);
            //qlnv.SubmitChanges();
            //setComboDataSource();
        }
        private void setEnableControl1(Boolean enable)
        {
            txtTenNV.Enabled = enable;
            txtMaNV.Enabled = enable;
            txtDiaChi.Enabled = enable;
            btnChinhSua1.Enabled = !enable;
            btnThem1.Enabled = !enable;
            btnCapnhat1.Enabled = enable;
            btnHuy1.Enabled = enable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setEnableControl1(true);
            txtMaNV.Enabled = false;
            them = false;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            setEnableControl1(true);
            clearTextBox();
            them = true;
        }

        private void btnCapnhat1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDiaChi.Text != "")
            {
                if (them)
                {
                    NhanVien nv = new NhanVien();
                    nv.Manv = int.Parse(txtMaNV.Text);
                    nv.Tennv = txtMaNV.Text;
                    nv.Diachi = txtDiaChi.Text;
                    //nv.Mapb = cboPhongBan.SelectedValue.ToString();
                    qlnv.NhanViens.InsertOnSubmit(nv);
                    qlnv.SubmitChanges();
                    setEnableControl1(false);
                    cboPhongBan_SelectedIndexChanged(cboPhongBan, null);
                }
                else
                {
                    NhanVien nv = qlnv.NhanViens.Single(p => p.Manv == Convert.ToInt32(txtMaNV.Text));
                    nv.Tennv = txtTenNV.Text;
                    nv.Diachi = txtDiaChi.Text;                    
                    qlnv.SubmitChanges();
                    cboPhongBan_SelectedIndexChanged(cboPhongBan, null);
                    setEnableControl1(false);
                }
            }
        }

        private void loadNStoListView(PhongBan pb)
        {
            lvNhanVien.Items.Clear();
            var nvCol = qlnv.NhanViens.Where(nv => nv.Mapb == pb.Mapb);
            foreach (var n in nvCol)
            {
                ListViewItem lvi = new ListViewItem(n.Manv.ToString());
                lvi.SubItems.Add(n.Tennv);
                lvi.SubItems.Add(n.Diachi);
                lvNhanVien.Items.Add(lvi);
            }
        }
        private void lvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvItem in lvNhanVien.SelectedItems)
            {
                txtMaNV.Text = lvItem.SubItems[0].Text;
                txtTenNV.Text = lvItem.SubItems[1].Text;
                txtDiaChi.Text = lvItem.SubItems[2].Text;
                textBox1.Text = cboPhongBan.SelectedValue.ToString();
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            NhanVien nv = qlnv.NhanViens.Single(p => p.Manv == Convert.ToInt32(txtMaNV.Text));
            qlnv.NhanViens.DeleteOnSubmit(nv);
            qlnv.SubmitChanges();
            cboPhongBan_SelectedIndexChanged(cboPhongBan, null);
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            setEnableControl1(false);
        }
    }
}
