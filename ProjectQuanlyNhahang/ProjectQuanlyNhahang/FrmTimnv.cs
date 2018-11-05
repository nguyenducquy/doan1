using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
namespace ProjectQuanlyNhahang
{
    public partial class FrmTimnv : DevExpress.XtraEditors.XtraForm
    {
        public FrmTimnv()
        {
            InitializeComponent();
        }

        private void FrmTimnv_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtID.Enabled = false;
            txtCMND.Enabled = false;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;

            ckbNu.Enabled = false;
            ckbNam.Enabled = false;

            //panelQuanli.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            var kq1 =
               from p in dbs.NHANVIENs 
               where p.TrangThai == true
               select new
               {
                   p.ID,
                   p.HoTenNV,
                   p.DiaChi,
                   p.CMND,
                   p.SoDienThoai,
                   p.NgayNhanViec,
                   p.Nu,
                   p.Hinh,
                   p.LoaiNV,
               };

            GridNhanvien.DataSource = kq1;

        }
        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
               where p.HoTenNV.StartsWith(txtHoten.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.HoTenNV,
                   p.DiaChi,
                   p.CMND,
                   p.SoDienThoai,
                   p.NgayNhanViec,
                   p.Nu,
                   p.Hinh,
                   p.LoaiNV,
               };

            GridNhanvien.DataSource = kq1;
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtHoten.Enabled = false;
            txtCMND.Enabled = false;
            txtID.Enabled = true;
            txtSDT.Enabled = false;
           
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioTen_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();
            txtHoten.Enabled = true;
            txtCMND.Enabled = false;
            txtID.Enabled = false;
            txtSDT.Enabled = false;
           
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioLoai_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();

            txtCMND.Enabled = false;
            txtID.Enabled = false;
            txtSDT.Enabled = false;
         
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioCmnd_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtID.Enabled = false;
            txtCMND.Enabled = true;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;
        
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioSdt_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtID.Enabled = false;
            txtCMND.Enabled = false;
            txtHoten.Enabled = false;
           
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
            txtSDT.Enabled = true;
        }

        private void radioGioitinh_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtID.Enabled = false;
            txtCMND.Enabled = false;
            txtHoten.Enabled = false;
           
            ckbNu.Enabled = true;
            ckbNam.Enabled = true;
            txtSDT.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            try
            {
                var kq1 =
                   from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.ID == int.Parse(txtID.Text) && p.TrangThai == true
                   select new
                   {
                       p.ID,
                       p.HoTenNV,
                       p.DiaChi,
                       p.CMND,
                       p.SoDienThoai,
                       p.NgayNhanViec,
                       p.Nu,
                       p.Hinh,
                       p.LoaiNV,
                   };

                GridNhanvien.DataSource = kq1;
            }
            catch
            {
                DialogResult tl = MessageBox.Show("Xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (tl == DialogResult.OK)
                    LoadData();
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
               where p.CMND.StartsWith(txtCMND.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.HoTenNV,
                   p.DiaChi,
                   p.CMND,
                   p.SoDienThoai,
                   p.NgayNhanViec,
                   p.Nu,
                   p.Hinh,
                   p.LoaiNV,
               };

            GridNhanvien.DataSource = kq1;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
               where p.SoDienThoai.StartsWith(txtSDT.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.HoTenNV,
                   p.DiaChi,
                   p.CMND,
                   p.SoDienThoai,
                   p.NgayNhanViec,
                   p.Nu,
                   p.Hinh,
                   p.LoaiNV,
               };

            GridNhanvien.DataSource = kq1;
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            if (ckbNu.CheckState == CheckState.Checked)
            {
                ckbNam.CheckState = CheckState.Unchecked;
                var kq1 =
                   from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.Nu == true
                   select new
                   {
                       p.ID,
                       p.HoTenNV,
                       p.DiaChi,
                       p.CMND,
                       p.SoDienThoai,
                       p.NgayNhanViec,
                       p.Nu,
                       p.Hinh,
                       p.LoaiNV,
                   };

                GridNhanvien.DataSource = kq1;
            }
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            if (ckbNam.CheckState == CheckState.Checked)
            {
                ckbNu.CheckState = CheckState.Unchecked;
                var kq1 =
                   from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.Nu == false
                   select new
                   {
                       p.ID,
                       p.HoTenNV,
                       p.DiaChi,
                       p.CMND,
                       p.SoDienThoai,
                       p.NgayNhanViec,
                       p.Nu,
                       p.Hinh,
                       p.LoaiNV,
                   };

                GridNhanvien.DataSource = kq1;
            }
        }
    }
}
