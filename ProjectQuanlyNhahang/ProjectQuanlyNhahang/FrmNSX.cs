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
    public partial class FrmNSX : Form
    {
        public FrmNSX()
        {
            InitializeComponent();
        }

        bool Them;

        bool Check(string a)
        {
            try
            {
                Int32.Parse(a);
                return true;
            }

            catch
            {
                return false;
            }
        }

        void LoadDaTa()
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq = from p in dbs.NHACUNGCAPs
                     where p.TrangThai == true
                     select new
                     {
                         p.ID,
                         p.TenNhaCungCap,
                         p.NgayHopTac
                     };
            this.pnql.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;

            dgvNSX.DataSource = kq;
            
        }

        private void FrmNSX_Load(object sender, EventArgs e)
        {
            LoadDaTa();
        }
        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNSX.CurrentCell.RowIndex;
            txtma.Text = dgvNSX.Rows[r].Cells[0].Value.ToString();
            txtten.Text = dgvNSX.Rows[r].Cells[1].Value.ToString();
            txtngay.Text = dgvNSX.Rows[r].Cells[2].Value.ToString();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tl =
      MessageBox.Show("Bạn có muốn thoát!", "Thông báo",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Hide();
                Form frmHT = new FrmQuanLyKho();
                frmHT.ShowDialog();
            }
            else
            {
                LoadDaTa();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDaTa();
            pnql.Enabled = true;
            txtma.ResetText();
            txtten.ResetText();
            txtngay.ResetText();
            txtten.Focus();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDaTa();
        }


        public void them(string ten, string ngay, bool Trangthai)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NHACUNGCAP nl = new NHACUNGCAP();
            nl.TenNhaCungCap = ten;
            nl.NgayHopTac = DateTime.Now;
            nl.TrangThai = true;
            dbs.NHACUNGCAPs.InsertOnSubmit(nl);
            dbs.SubmitChanges();
        }

        public void sua(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NHACUNGCAP dc = dbs.NHACUNGCAPs.Single(p => p.ID.ToString() == a);
            dc.TenNhaCungCap = txtten.Text;
            dbs.SubmitChanges();
        }

        public void xoa(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NHACUNGCAP dc = dbs.NHACUNGCAPs.Single(p => p.ID.ToString() == a);
            dc.TrangThai = false;
            dbs.SubmitChanges();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Them = false;
            this.pnql.Enabled = true;
            this.txtma.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnThem.Enabled = false;
            txtma.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Them = true;
            this.pnql.Enabled = true;
            this.txtma.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            txtten.ResetText();
            this.txtngay.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa dữ liệu?", "Thông báo!",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                int r = dgvNSX.CurrentCell.RowIndex;
                string id = dgvNSX.Rows[r].Cells[0].Value.ToString();
                xoa(id);
                MessageBox.Show("Xóa thành công", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDaTa();
            }
            if (tl == DialogResult.Cancel)
            {
                LoadDaTa();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtten.Text == " ")
            {
                MessageBox.Show("Nhập Tên Nguyên Liệu");
                txtten.Focus();
            }
            else
            {
                if (Check(txtten.Text))
                {
                    MessageBox.Show("Tên Nguyên Liệu Không Hợp Lệ");
                    txtten.ResetText();
                    txtten.Focus();
                }
                else
                {
                    if (!Them)
                    {
                        DialogResult tl = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo!",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tl == DialogResult.OK)
                        {
                            int r = dgvNSX.CurrentCell.RowIndex;
                            string a = dgvNSX.Rows[r].Cells[0].Value.ToString();
                            sua(a);
                            MessageBox.Show("Lưu thành công!", "Thông báo!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDaTa();
                        }
                        if (tl == DialogResult.Cancel)
                        {
                            LoadDaTa();
                        }
                    }
                    else
                    {
                        DialogResult tl1 = MessageBox.Show("Bạn có muốn thêm?", "Thông báo!",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tl1 == DialogResult.OK)
                        {
                            them(txtten.Text, txtngay.Text, true);
                            MessageBox.Show("Thêm thành công!", "Thông báo!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDaTa();
                        }

                        if (tl1 == DialogResult.Cancel)
                        {
                            LoadDaTa();
                        }
                    }
                }
            }
        }
    }
}
