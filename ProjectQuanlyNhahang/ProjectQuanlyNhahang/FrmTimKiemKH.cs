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

namespace ProjectQuanlyNhahang
{
    public partial class FrmTimKiemKH : DevExpress.XtraEditors.XtraForm
    {
        public FrmTimKiemKH()
        {
            InitializeComponent();
        }

        private void FrmTimKiemKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtDiachi.Enabled = false;
            txtID.Enabled = true;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioTen_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtDiachi.Enabled = false;
            txtHoten.Enabled = true;
            txtSDT.Enabled = false;
            txtID.Enabled = false;
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioLoai_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtDiachi.Enabled = true;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;
            txtID.Enabled = false;
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioSdt_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtDiachi.Enabled = false;
            txtHoten.Enabled = false;
            txtSDT.Enabled = true;
            txtID.Enabled = false;

            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
        }

        private void radioGioitinh_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            txtID.ResetText();

            txtDiachi.Enabled = false;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;
            txtID.Enabled = false;
            ckbNu.Enabled = true;
            ckbNam.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            try
            {
                var kq1 =
                   from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.ID == Convert.ToInt32(txtID.Text) && p.TrangThai == true
                   select new
                   {
                       p.ID,
                       p.TenKH,
                       p.SoDienThoai,
                       p.DiaChi,
                       p.Hinh,
                       p.Nu,
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

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.TenKH.StartsWith(txtHoten.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenKH,
                   p.SoDienThoai,
                   p.DiaChi,
                   p.Hinh,
                   p.Nu,
               };

            GridNhanvien.DataSource = kq1;
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.DiaChi.StartsWith(txtDiachi.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenKH,
                   p.SoDienThoai,
                   p.DiaChi,
                   p.Hinh,
                   p.Nu,
               };

            GridNhanvien.DataSource = kq1;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.SoDienThoai.StartsWith(txtSDT.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenKH,
                   p.SoDienThoai,
                   p.DiaChi,
                   p.Hinh,
                   p.Nu,
               };

            GridNhanvien.DataSource = kq1;
        }
        public void LoadData()
        {
            txtDiachi.Enabled = false;
            txtHoten.Enabled = false;
            txtSDT.Enabled = false;
            txtID.Enabled = false;
            ckbNu.Enabled = false;
            ckbNam.Enabled = false;
            //panelQuanli.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenKH,
                   p.SoDienThoai,
                   p.DiaChi,
                   p.Hinh,
                   p.Nu,
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
                   from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.Nu == true
                   select new
                   {
                       p.ID,
                       p.TenKH,
                       p.SoDienThoai,
                       p.DiaChi,
                       p.Hinh,
                       p.Nu,
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
                   from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
                   where p.Nu == false
                   select new
                   {
                       p.ID,
                       p.TenKH,
                       p.SoDienThoai,
                       p.DiaChi,
                       p.Hinh,
                       p.Nu,
                   };

                GridNhanvien.DataSource = kq1;
            }
        }
    }
}