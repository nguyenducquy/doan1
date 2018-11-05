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
    public partial class FrmNguyenLieu : Form
    {
        public FrmNguyenLieu()
        {
            InitializeComponent();
        }

        private void dgvNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelQuanli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            txtma.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq = from p in dbs.NGUYENLIEUs
                     where p.TrangThai == true
                     select new
                     {
                         p.ID,
                         p.TenSP,
                         p.DonGia
                     };
            this.pnql.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnThoat.Enabled = true;

            dgvNL.DataSource = kq;

        }

        private void FrmNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadDaTa();
        }

        private void dgvNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNL.CurrentCell.RowIndex;
            txtma.Text = dgvNL.Rows[r].Cells[0].Value.ToString();
            txtten.Text = dgvNL.Rows[r].Cells[1].Value.ToString();
            txtgia.Text = dgvNL.Rows[r].Cells[2].Value.ToString();
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
            txtgia.ResetText();
            txtten.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa dữ liệu?", "Thông báo!",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                int r = dgvNL.CurrentCell.RowIndex;
                string id = dgvNL.Rows[r].Cells[0].Value.ToString();
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

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDaTa();
        }

        public void them(string ten, string gia, bool Trangthai)
        {
            txtma.Enabled = true;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.TenSP = ten;
            nl.DonGia = Convert.ToInt32(txtgia.Text);
            nl.TrangThai = true;
            dbs.NGUYENLIEUs.InsertOnSubmit(nl);
            dbs.SubmitChanges();
        }

        public void sua(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NGUYENLIEU dc = dbs.NGUYENLIEUs.Single(p => p.ID.ToString() == a);
            dc.TenSP = txtten.Text;
            dc.DonGia = Convert.ToInt32(txtgia.Text);
            dbs.SubmitChanges();
        }

        public void xoa(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NGUYENLIEU dc = dbs.NGUYENLIEUs.Single(p => p.ID.ToString() == a);
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
            txtgia.ResetText();
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
                if (txtgia.Text == " ")
                {
                    MessageBox.Show("Nhập Giá Nguyên Liệu");
                    txtgia.Focus();
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
                        if (!Check(txtgia.Text))
                        {
                            MessageBox.Show("Giá Không Hợp Lệ");
                            txtgia.ResetText();
                            txtgia.Focus();
                        }
                        else
                        {
                            if (!Them)
                            {
                                DialogResult tl = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo!",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (tl == DialogResult.OK)
                                {
                                    int r = dgvNL.CurrentCell.RowIndex;
                                    string a = dgvNL.Rows[r].Cells[0].Value.ToString();
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
                                    them(txtten.Text, txtgia.Text, true);
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
            
        
    }
}
