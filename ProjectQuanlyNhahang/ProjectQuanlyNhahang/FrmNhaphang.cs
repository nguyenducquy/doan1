using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ProjectQuanlyNhahang
{
    public partial class FrmNhaphang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmNhaphang()
        {
            InitializeComponent();
        }

        bool Them;
        int? DG;
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
            NV.DataSource = kq1;
            NV.DisplayMember = "HoTenNV";
            NV.ValueMember = "ID";
            var kq2 = from k in dbs.NHACUNGCAPs
                      select k;
            NSX.DataSource = kq2;
            NSX.DisplayMember = "TenNhaCungCap";
            NSX.ValueMember = "ID";
            var kq3 = from k in dbs.NGUYENLIEUs
                      select k;
            SP.DataSource = kq3;
            SP.DisplayMember = "TenSP";
            SP.ValueMember = "ID";
            var kq = from p in dbs.HOADONNHs
                     where p.TrangThai == true
                     select new
                     {
                       p.ID,
                       p.NV,
                       p.NSX,
                       p.SP,
                       p.SoLuong,
                       p.DonGia,
                       p.ThanhTien,
                       p.Ngay
                     };
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;
            dgvNH.DataSource = kq;

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelQuanli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhaphang_Load(object sender, EventArgs e)
        {
            LoadDaTa();
        }

        private void GridNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            var kq1 = from nv in dbs.NHANVIENs
                      select nv;
            cbxMANV.DataSource = kq1.ToList();
            cbxMANV.DisplayMember = "HoTenNV";
            cbxMANV.ValueMember = "ID";

            var kq2 = from k in dbs.NHACUNGCAPs
                      select k;
            cbxNSX.DataSource = kq2;
            cbxNSX.DisplayMember = "TenNhaCungCap";
            cbxNSX.ValueMember = "ID";

            var kq3 = from nv in dbs.NGUYENLIEUs
                      select nv;
            cbxSP.DataSource = kq3.ToList();
            cbxSP.DisplayMember = "TenSP";
            cbxSP.ValueMember = "ID";
            int r = dgvNH.CurrentCell.RowIndex;
            txtma.Text = dgvNH.Rows[r].Cells[0].Value.ToString();
            cbxMANV.SelectedValue = dgvNH.Rows[r].Cells[1].Value;
            cbxNSX.SelectedValue = dgvNH.Rows[r].Cells[2].Value;
            cbxSP.SelectedValue = dgvNH.Rows[r].Cells[3].Value;
            txtSoLuong.Text = dgvNH.Rows[r].Cells[4].Value.ToString();
            txtgia.Text = dgvNH.Rows[r].Cells[5].Value.ToString();
            txttong.Text = dgvNH.Rows[r].Cells[6].Value.ToString();
            txtngay.Text = dgvNH.Rows[r].Cells[7].Value.ToString();
        }

        private void cbxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq = from k in dbs.NGUYENLIEUs
                     where k.TenSP == cbxSP.Text
                     select new
                     {
                         k.DonGia
                     };
            if (kq.ToArray().Length > 0)
            {
                DG = kq.ToArray()[0].DonGia;
                txtgia.Text = DG.ToString();

            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {

            LoadDaTa();
            pnql.Enabled = true;
            txtma.ResetText();
            txtgia.ResetText();
            txtngay.ResetText();
            txttong.ResetText();
            cbxMANV.ResetText();
            cbxNSX.ResetText();
            cbxSP.ResetText();
            cbxMANV.Focus();
        }


        public void them(string nv, string nsx,string sp, string sl, string gia,string tong,string ngay, bool trangthai)
        {
            
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            HOADONNH HD = new HOADONNH();
            txttong.Text = (DG * txtSoLuong.Value).ToString();
            HD.NV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
            HD.NSX = Convert.ToInt32(cbxNSX.SelectedValue.ToString());
            HD.SP= Convert.ToInt32(cbxSP.SelectedValue.ToString());
            HD.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            HD.DonGia= Convert.ToInt32(txtgia.Text);
            HD.ThanhTien = Convert.ToInt32(txttong.Text);
            HD.Ngay = DateTime.Now;
            HD.TrangThai = true;
            dbs.HOADONNHs.InsertOnSubmit(HD);
            dbs.SubmitChanges();
        }

        public void sua(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            HOADONNH HD = dbs.HOADONNHs.Single(p => p.ID.ToString() == a);
            txttong.Text = (DG * txtSoLuong.Value).ToString();
            HD.NV = Convert.ToInt32(cbxMANV.SelectedValue.ToString());
            HD.NSX = Convert.ToInt32(cbxNSX.SelectedValue.ToString());
            HD.SP = Convert.ToInt32(cbxSP.SelectedValue.ToString());
            HD.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            HD.DonGia = Convert.ToInt32(txtgia.Text);
            HD.ThanhTien = Convert.ToInt32(txttong.Text);
            dbs.SubmitChanges();
        }

        public void xoa(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            HOADONNH hd = dbs.HOADONNHs.Single(p => p.ID.ToString()== a);
            hd.TrangThai = false;
            dbs.SubmitChanges();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Them = false;
            this.pnql.Enabled = true;
            this.txtma.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnXoa.Enabled = false;
            this.btnThem.Enabled = false;
            this.txtngay.Enabled = false;
            txtma.Enabled = false;
            txttong.Enabled = false;
            txtgia.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Them = true;
            this.pnql.Enabled = true;
            this.txtma.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            txtSoLuong.ResetText();
            txttong.ResetText();
            cbxMANV.Focus();
            this.txtngay.Enabled = false;
            this.txtma.Enabled = false;
            this.txttong.Enabled = false;
            this.txtgia.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa dữ liệu?", "Thông báo!",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                int r = dgvNH.CurrentCell.RowIndex;
                string id = dgvNH.Rows[r].Cells[0].Value.ToString();
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

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(txtSoLuong.Text==" ")
            {
                MessageBox.Show("Nhập Số Lượng");
                txtSoLuong.Focus();
            }
            else
            {
                if(!Them)
                {
                    DialogResult tl = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (tl == DialogResult.OK)
                    {
                        int r = dgvNH.CurrentCell.RowIndex;
                        string a = dgvNH.Rows[r].Cells[0].Value.ToString();
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
                        them(cbxMANV.Text,cbxNSX.Text,cbxSP.Text,txtSoLuong.Text,txtgia.Text,txttong.Text,txtngay.Text,true);
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

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDaTa();
        }
    }
}