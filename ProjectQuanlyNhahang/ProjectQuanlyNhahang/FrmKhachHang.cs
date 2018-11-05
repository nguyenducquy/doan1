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
using System.IO;
namespace ProjectQuanlyNhahang
{
    public partial class FrmKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog upPicture = new OpenFileDialog();
            upPicture.InitialDirectory = "E:\\Image Project 1";
            DialogResult tl = upPicture.ShowDialog();
            if (tl == DialogResult.OK)
            {
                picNhanvien.Image = Image.FromFile(upPicture.FileName);
            }
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelTimKH.Show();
            txtTimDiachi.Enabled = false;
            txtTimMa.Enabled = false;
            txtTimTen.Enabled = false;
            txtTimSDT.Enabled = false;
            ckbTimnu.Enabled = false;
            ckbTimnam.Enabled = false;
            //GridNhanvien.Enabled = false;
        }
        public void LoadData()
        {
            panelQuanli.Enabled = false;
            txtID.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLoad.Enabled = true;
            //btnSearch.Visible = true;
            panelTimKH.Hide();
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var ketqua =
                from p in dbs.KHACHHANGs//chọn những khách hàng trong bảng khách hàng 
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
            // loadCombo1();
            GridNhanvien.DataSource = ketqua;

        }
        bool them = false;
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelQuanli.Enabled = true;
            them = true;
            txtID.ResetText();
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            ckbNu.CheckState = CheckState.Unchecked;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            int r = GridNhanvien.CurrentCell.RowIndex;
            string strMaNV = GridNhanvien.Rows[r].Cells[0].Value.ToString();
            KHACHHANG kh = dbs.KHACHHANGs.Single(p => p.ID.ToString() == strMaNV && p.TrangThai == true);// bang nhan vien
            kh.TrangThai = false;
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dbs.SubmitChanges();
            LoadData();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            them = false;
            panelQuanli.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnLoad.Enabled = true;

            btnXoa.Enabled = false;
            txtID.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (them)
            {
                Them(txtHoten.Text, txtDiachi.Text, txtSDT.Text, Convert.ToBoolean(ckbNu.CheckState));
                LoadData();
            }
            else
            {
                int r = GridNhanvien.CurrentCell.RowIndex;
                string a = GridNhanvien.Rows[r].Cells[0].Value.ToString();
                sua(a);
                LoadData();
                MessageBox.Show("đã sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
        public void Them(string ten, string mk, string dt, bool loai)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            KHACHHANG nv = new KHACHHANG();// bang nhan vien
            try
            {
                //nv.nhanvienid = id;
                nv.TenKH = ten;
                nv.DiaChi = mk;
                nv.SoDienThoai = dt;
                nv.Nu = loai;
                if (picNhanvien.Image == null)
                {
                    nv.Hinh = null;
                }
                else
                {
                    nv.Hinh = imgToByteArray(picNhanvien.Image);
                }
                nv.TrangThai = true;
                dbs.KHACHHANGs.InsertOnSubmit(nv);
                dbs.SubmitChanges();
                MessageBox.Show("Thêm thành công");

            }
            catch
            {

            }
        }
        public void sua(string a)
        {

            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            KHACHHANG nv = dbs.KHACHHANGs.Single(p => p.ID.ToString() == a);

            nv.TenKH = txtHoten.Text;
            nv.DiaChi = txtDiachi.Text;
            nv.SoDienThoai = txtSDT.Text;
            bool gioitinh2 = false;
            if (ckbNu.CheckState == CheckState.Checked)
            {
                gioitinh2 = true;
            }
            else
            {
                gioitinh2 = false;
            }
            if (picNhanvien.Image == null)
            {
                nv.Hinh = null;
            }
            else
            {
                nv.Hinh = imgToByteArray(picNhanvien.Image);
            }
            nv.Nu = gioitinh2;
            dbs.SubmitChanges();
        }
        private void btnLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void GridNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                panelQuanli.Enabled = false;
                int r = GridNhanvien.CurrentCell.RowIndex;

                txtID.Text = GridNhanvien.Rows[r].Cells[0].Value.ToString();
                txtHoten.Text = GridNhanvien.Rows[r].Cells[1].Value.ToString();
                txtSDT.Text = GridNhanvien.Rows[r].Cells[2].Value.ToString();
                txtDiachi.Text = GridNhanvien.Rows[r].Cells[3].Value.ToString();
                KHACHHANG abc = dbs.KHACHHANGs.Single(p => (p.TrangThai == true) && (p.ID.ToString() == txtID.Text));
                if (abc.Hinh == null)
                {
                    picNhanvien.Image = picNhanvien.BackgroundImage;
                }
                else
                {
                    picNhanvien.Image = byteArrayToImage(abc.Hinh.ToArray());
                }
                string gt = GridNhanvien.Rows[r].Cells[5].Value.ToString();
                if (gt.Equals("True"))
                    ckbNu.CheckState = CheckState.Checked;
                else
                    ckbNu.CheckState = CheckState.Unchecked;
            }
            catch
            {
                DialogResult tl = MessageBox.Show("BẠN CÓ MUỐN SỬA ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tl == DialogResult.OK)
                {
                    btnSua_ItemClick(null, null);
                }
                else
                {

                }
                    
            }
        }

        private void GridNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTen.ResetText();
            txtTimDiachi.ResetText();
            txtTimSDT.ResetText();
            txtTimMa.ResetText();

            txtTimDiachi.Enabled = false;
            txtTimMa.Enabled = true;
            txtTimTen.Enabled = false;
            txtTimSDT.Enabled = false;
            ckbTimnu.Enabled = false;
        }

        private void radioTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTen.Enabled = true;

            txtTimTen.ResetText();
            txtTimDiachi.ResetText();
            txtTimSDT.ResetText();
            txtTimMa.ResetText();

            txtTimMa.Enabled = false;
            txtTimDiachi.Enabled = false;
            txtTimSDT.Enabled = false;

            ckbTimnu.Enabled = false;
            ckbTimnu.CheckState = CheckState.Unchecked;
            ckbTimnam.Enabled = false;
            ckbTimnam.CheckState = CheckState.Unchecked;
        }

        private void radioLoai_CheckedChanged(object sender, EventArgs e)
        {
            txtTimDiachi.Enabled = true;

            txtTimTen.ResetText();
            txtTimDiachi.ResetText();
            txtTimSDT.ResetText();
            txtTimMa.ResetText();

            txtTimMa.Enabled = false;
            txtTimTen.Enabled = false;
            txtTimSDT.Enabled = false;

            ckbTimnu.Enabled = false;
            ckbTimnu.CheckState = CheckState.Unchecked;
            ckbTimnam.Enabled = false;
            ckbTimnam.CheckState = CheckState.Unchecked;
        }

        private void radioSdt_CheckedChanged(object sender, EventArgs e)
        {
            txtTimSDT.Enabled = true;

            txtTimTen.ResetText();
            txtTimDiachi.ResetText();
            txtTimSDT.ResetText();
            txtTimMa.ResetText();

            txtTimMa.Enabled = false;
            txtTimDiachi.Enabled = false;
            txtTimTen.Enabled = false;

            ckbTimnu.Enabled = false;
            ckbTimnu.CheckState = CheckState.Unchecked;
            ckbTimnam.Enabled = false;
            ckbTimnam.CheckState = CheckState.Unchecked;
        }

        private void radioGioitinh_CheckedChanged(object sender, EventArgs e)
        {
            ckbTimnu.Enabled = true;
            ckbTimnu.CheckState = CheckState.Unchecked;
            ckbTimnam.Enabled = true;
            ckbTimnam.CheckState = CheckState.Unchecked;

            txtTimTen.ResetText();
            txtTimDiachi.ResetText();
            txtTimSDT.ResetText();
            txtTimMa.ResetText();

            txtTimMa.Enabled = false;
            txtTimTen.Enabled = false;
            txtTimDiachi.Enabled = false;
            txtTimSDT.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            try
            {
       
                    var kq1 =
                       from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
                       where p.ID == Convert.ToInt32(txtTimMa.Text) && p.TrangThai == true
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
                {
                    txtTimMa.ResetText();
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
            }
        }


        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.TenKH.StartsWith(txtTimTen.Text) && p.TrangThai == true
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

        private void txtTimDiachi_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.DiaChi.StartsWith(txtTimDiachi.Text) && p.TrangThai == true
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

        private void txtTimSDT_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where p.SoDienThoai.StartsWith(txtTimSDT.Text) && p.TrangThai == true
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

        private void ckbTimnu_CheckedChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            if(ckbTimnu.CheckState == CheckState.Checked)
            {
            ckbTimnam.CheckState = CheckState.Unchecked;
            var kq1 =
               from p in dbs.KHACHHANGs //chọn những nvách hàng trong bảng nvách hàng 
               where  p.Nu == true
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

        private void ckbTimnam_CheckedChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            if (ckbTimnam.CheckState == CheckState.Checked)
            {
                ckbTimnu.CheckState = CheckState.Unchecked;
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
        private void txtSDT_Leave_1(object sender, EventArgs e)
        {
            if (checksdt(txtSDT.Text) == false)
            {
                MessageBox.Show("ERROR PHONE NUMBER INVALID",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                if (them == true)
                    txtSDT.ResetText();
                txtSDT.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoahinh_Click(object sender, EventArgs e)
        {
            picNhanvien.Image = null;
        }
    }
}