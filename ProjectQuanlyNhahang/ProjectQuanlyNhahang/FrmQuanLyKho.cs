using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanlyNhahang
{
    public partial class FrmQuanLyKho : Form
    {
        public FrmQuanLyKho()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
            Form frmNSX = new FrmNSX();
            frmNSX.ShowDialog();
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
            Form frmNL = new FrmNguyenLieu();
            frmNL.ShowDialog();
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
            Form frmNH = new FrmNhaphang();
            frmNH.ShowDialog();
            this.Close();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tl =
       MessageBox.Show("Bạn có muốn thoát!", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmQuanLyKho_Load(object sender, EventArgs e)
        {

        }
    }
}
