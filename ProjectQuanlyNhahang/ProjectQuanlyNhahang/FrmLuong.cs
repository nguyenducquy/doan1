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
    public partial class FrmLuong : Form
    {
        public FrmLuong()
        {
            InitializeComponent();
        }

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

            var kq1 = from k in dbs.NHANVIENs
                      select k;
            TenNV.DataSource = kq1;
            TenNV.DisplayMember = "HoTenNV";
            TenNV.ValueMember = "ID";

            var kq = from p in dbs.LUONGs
                     where p.TrangThai == true
                     select new
                     {
                         p.ID_NV,
                         p.TenNV,
                         p.LuongCB,
                         p.Thuong,
                         p.TongLuong
                     };
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;
            this.btnxem1.Enabled = true;
            this.btnxem2.Enabled = true;
            this.btnxem3.Enabled = true;
            dgvLuong.DataSource = kq;


        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLuong_Load(object sender, EventArgs e)
        {
           
            txtma.Enabled = false;
            txttong.Enabled = false;
            txtLuong.ResetText();
            txtThuong.ResetText();
            txttong.ResetText();
            txtLuong.Focus();
            LoadDaTa();
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 = from nv in dbs.NHANVIENs
                      select nv;
            cbxMANV.DataSource = kq1.ToList();
            cbxMANV.DisplayMember = "HoTenNV";
            cbxMANV.ValueMember = "ID";

            int r = dgvLuong.CurrentCell.RowIndex;
            txtma.Text = dgvLuong.Rows[r].Cells[0].Value.ToString();
            cbxMANV.SelectedValue = dgvLuong.Rows[r].Cells[1].Value;
            txtLuong.Text = dgvLuong.Rows[r].Cells[2].Value.ToString();
            txtThuong.Text = dgvLuong.Rows[r].Cells[3].Value.ToString();
            txttong.Text = dgvLuong.Rows[r].Cells[4].Value.ToString();
        }

        private void btnxem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDaTa();
        }

        private void btnxem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            var kq1 = from k in dbs.NHANVIENs
                      select k;
            TenNV.DataSource = kq1;
            TenNV.DisplayMember = "HoTenNV";
            TenNV.ValueMember = "ID";

            var kq = from p in dbs.LUONGs
                     where p.TrangThai == false
                     select new
                     {
                         p.ID_NV,
                         p.TenNV,
                         p.LuongCB,
                         p.Thuong,
                         p.TongLuong
                     };
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;
            this.btnxem1.Enabled = true;
            this.btnxem2.Enabled = true;
            this.btnxem3.Enabled = true;
            dgvLuong.DataSource = kq;
        }

        private void btnxem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            var kq1 = from k in dbs.NHANVIENs
                      select k;
            TenNV.DataSource = kq1;
            TenNV.DisplayMember = "HoTenNV";
            TenNV.ValueMember = "ID";

            var kq = from p in dbs.LUONGs
                     select new
                     {
                         p.ID_NV,
                         p.TenNV,
                         p.LuongCB,
                         p.Thuong,
                         p.TongLuong
                     };
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;
            this.btnxem1.Enabled = true;
            this.btnxem2.Enabled = true;
            this.btnxem3.Enabled = true;
            dgvLuong.DataSource = kq;
            dgvLuong_CellClick(null, null);
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
            txtLuong.ResetText();
            txtThuong.ResetText();
            txttong.ResetText();
            cbxMANV.ResetText();
            cbxMANV.Focus();
        }
        public void xoa(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            LUONG dc = dbs.LUONGs.Single(p => p.ID_NV.ToString() == a);
            dc.TrangThai = false;
            dbs.SubmitChanges();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtma.Enabled = false;
            txttong.Enabled = false;
            DialogResult tl = MessageBox.Show("Thanh Toán Lương Cho Nhân Viên" + " " + cbxMANV.Text + "?", "Thông báo!",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                int r = dgvLuong.CurrentCell.RowIndex;
                string id = dgvLuong.Rows[r].Cells[0].Value.ToString();
                xoa(id);
                MessageBox.Show("Đã Thanh Toán", "Thông Báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDaTa();
            }
            if (tl == DialogResult.Cancel)
            {
                LoadDaTa();
            }
        }

        void TinhLuong()
        {



        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            DialogResult tl = MessageBox.Show("Tính lương nhân viên", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {

                if (txtLuong.Text == " " || txtThuong.Text == " ")
                {
                    MessageBox.Show("Nhập Lương/Thưởng");
                    txtLuong.ResetText();
                    txtThuong.ResetText();
                    txtLuong.Focus();
                }
                else
                {
                    if (!Check(txtLuong.Text) || !Check(txtThuong.Text))
                    {
                        MessageBox.Show("Lương/Thưởng Nhập Không hợp lệ");
                        txtThuong.ResetText();
                        txtLuong.ResetText();
                        txtLuong.Focus();
                    }
                    else
                    {
                        RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                        LUONG L = new LUONG();
                        L.TenNV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
                        L.LuongCB = Convert.ToInt32(txtLuong.Text);
                        L.Thuong = Convert.ToInt32(txtThuong.Text);
                        L.TongLuong = Convert.ToInt32(txtLuong.Text) + Convert.ToInt32(txtThuong.Text);
                        L.TrangThai = true;
                        dbs.LUONGs.InsertOnSubmit(L);
                        dbs.SubmitChanges();
                        MessageBox.Show("Đã Tính Xong!", "Thông báo!",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDaTa();
                        txtLuong.ResetText();
                        txtThuong.ResetText();
                        txttong.ResetText();
                        txtLuong.Focus();
                    }
                }
            }
            else
            {
                LoadDaTa();
            }
        }
    }
}