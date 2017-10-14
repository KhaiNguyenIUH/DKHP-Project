using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHocPhan
{
    public partial class frmPDT : Form
    {
        public frmPDT()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsUIButtonPanel3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(tileControl1);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.panel1.Controls.Clear();
            MoLop d = new MoLop();
            d.TopLevel = false;
            this.panel1.Controls.Add(d);
            d.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.panel1.Controls.Clear();
            QLSV d = new QLSV();
            d.TopLevel = false;
            this.panel1.Controls.Add(d);
            d.Show();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
