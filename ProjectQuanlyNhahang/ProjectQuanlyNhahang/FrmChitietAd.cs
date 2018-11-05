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
    public partial class FrmChitietAd : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmChitietAd()
        {
            InitializeComponent();
        }

        
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                panelChitiet.Enabled = false;
                int r = dgvMenu.CurrentCell.RowIndex;

                txtTaikhoan.Text = dgvMenu.Rows[r].Cells[0].Value.ToString();
                txtMatkhau.Text = dgvMenu.Rows[r].Cells[1].Value.ToString();
                txtNgay.Text = dgvMenu.Rows[r].Cells[2].Value.ToString();
                txtHoten.Text = dgvMenu.Rows[r].Cells[3].Value.ToString();
                txtSdt.Text = dgvMenu.Rows[r].Cells[4].Value.ToString();
                cbbLoaiTK.SelectedValue = dgvMenu.Rows[r].Cells[5].Value;
            }
            catch
            {
                DialogResult tl1 = MessageBox.Show("Bạn Có Muốn Cập Nhật Loại Tài Khoản Cho Tài Khoản Này Không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tl1 == DialogResult.OK)
                {
                    btnSua_ItemClick(null, null);
                }

            }
        }
        bool them = false;
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelChitiet.Enabled = true;
            them = true;
            txtTaikhoan.Enabled = true;
            txtTaikhoan.ResetText();
            txtMatkhau.ResetText();
            txtNgay.ResetText();
            txtHoten.ResetText();
            txtSdt.ResetText();
            cbbLoaiTK.ResetText();
            txtNgay.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            int r = dgvMenu.CurrentCell.RowIndex;
            string strMaNV = dgvMenu.Rows[r].Cells[0].Value.ToString();
            TAIKHOAN kh = dbs.TAIKHOANs.Single(p => p.TenDangNhap.ToString() == strMaNV && p.TrangThai == true);// bang nhan vien
            kh.TrangThai = false;
            MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dbs.SubmitChanges();
            LoadData();
        }       

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            them = false;
            panelChitiet.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;

            btnXoa.Enabled = false;
            txtNgay.Enabled = false;
            txtTaikhoan.Enabled = false;

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (them)
            {
                txtNgay.Text = Convert.ToString(DateTime.Now);
                Them(txtTaikhoan.Text, txtMatkhau.Text, Convert.ToDateTime(txtNgay.Text),txtHoten.Text,txtSdt.Text, cbbLoaiTK.SelectedValue.ToString());
                LoadData();

            }
            else
            {
                int r = dgvMenu.CurrentCell.RowIndex;
                string a = dgvMenu.Rows[r].Cells[0].Value.ToString();
                sua(a);
                LoadData();
                MessageBox.Show("đã sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void FrmChitietAd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        public void LoadData()
        {
            txtTaikhoan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            //btnSearch.Visible = true;
            panelChitiet.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
                from p in dbs.TAIKHOANs 

                select p;
            LoaiTK_.DisplayMember = "LoaiTK";
            LoaiTK_.ValueMember = "LoaiTK";
            LoaiTK_.DataSource = kq;

            var kq2 = from p in dbs.LOAITKs
                      select p;
            cbbLoaiTK.DataSource = kq2;
            cbbLoaiTK.DisplayMember = "LoaiTK1";
            cbbLoaiTK.ValueMember = "ID";
            var ketqua =
                from p in dbs.TAIKHOANs //chọn những khách hàng trong bảng khách hàng 
                where p.TrangThai == true
                select new
                {
                    p.TenDangNhap,
                    p.MatKhau, 
                    p.NgayDangKi,
                    p.HoTen,
                    p.SoDienThoai,
                    p.LoaiTK,
                };
            // loadCombo1();
            dgvMenu.DataSource = ketqua;
            dgvMenu_CellClick(null, null);
        }
        public void Them(string ten, string mk,DateTime ngay, string hoten, string dt,string loai)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
           TAIKHOAN nv = new TAIKHOAN();// bang nhan vien
            //nv.nhanvienid = id;
            nv.TenDangNhap = ten;
            try
            {
                if (!dbs.TAIKHOANs.Where(cls => cls.TenDangNhap == ten).Any())
                {
                    nv.MatKhau = mk;

                    nv.NgayDangKi = ngay;
                    nv.HoTen = hoten;
                    nv.SoDienThoai = dt;

                    nv.LoaiTK = int.Parse(loai);
                    nv.TrangThai = true;
                    dbs.TAIKHOANs.InsertOnSubmit(nv);
                    dbs.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("TÊN ĐĂNG NHẬP ĐÃ ĐƯỢC SỬ DỤNG!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                
            }
          
        }
        public void sua(string a)
        {
           
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            TAIKHOAN nv = dbs.TAIKHOANs.Single(p => p.TenDangNhap.ToString() == a);

            nv.TenDangNhap = txtTaikhoan.Text;
            nv.MatKhau = txtMatkhau.Text;
            nv.HoTen = txtHoten.Text;
            nv.SoDienThoai = txtSdt.Text;
            nv.LoaiTK = Convert.ToInt16(cbbLoaiTK.SelectedValue);
            dbs.SubmitChanges();
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        bool checksdt(string a)
        {
            if (a.Equals(""))
                return true;
            try
            {
                int.Parse(a);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void txtSdt_Leave(object sender, EventArgs e)
        {

            if (checksdt(txtSdt.Text) == false)
            {
                MessageBox.Show("ERROR PHONE NUMBER INVALID",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                if (them == true)
                    txtSdt.ResetText();
                txtSdt.Focus();
            }
        }
    }
}