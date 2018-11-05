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
//using System.ComponentModel.IBindingList;
using System.IO;
namespace ProjectQuanlyNhahang
{
    public partial class FrmQuanlinv : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuanlinv()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            panelQuanli.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled= true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSave.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.NHANVIENs //chọn những nvách hàng trong bảng nvách hàng 
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
            
            GridNhanvien.DataSource = kq;
        }
        bool them = false;
        private void Quanlinv_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panelQuanli.Enabled = true;
            them = true;
            txtID.ResetText();
            txtHoten.ResetText();
            txtDiachi.ResetText();
            txtCMND.ResetText();
            txtNgaynhan.ResetText();
            txtSDT.ResetText();
            txtLoainv.ResetText();
            picNhanvien.ResetText();
            txtID.Enabled = false;
            btnSave.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            picNhanvien.Image = null;
        }
        public void Them(string Hoten, string diachi,string cmnd,string sodt,DateTime ngaynhan,bool gt,int loai)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NHANVIEN nv = new NHANVIEN();
            nv.HoTenNV = Hoten;
            nv.DiaChi = diachi;
            nv.CMND = cmnd;
            nv.NgayNhanViec = ngaynhan;
            nv.SoDienThoai = sodt;
            if (picNhanvien.Image == null)
            {
                nv.Hinh = null;
            }
            else
            {
                nv.Hinh = imgToByteArray(picNhanvien.Image);
            }
            nv.LoaiNV = loai;

            nv.Nu = gt;
            nv.TrangThai = true;
            dbs.NHANVIENs.InsertOnSubmit(nv);
            dbs.SubmitChanges();
        }
        public void sua(string ma)
        {
            btnThem.Enabled = true;
            btnSave.Enabled = true;
            txtID.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            NHANVIEN nv = dbs.NHANVIENs.Single(p => p.ID.ToString() == ma);
            nv.HoTenNV = txtHoten.Text;
            nv.DiaChi = txtDiachi.Text;
            nv.CMND = txtCMND.Text;
            nv.NgayNhanViec = Convert.ToDateTime(txtNgaynhan.Text);
            bool gioitinh2 = false;
            if (ckbNu.CheckState == CheckState.Checked)
            {
                gioitinh2 = true;
            }
            else
            {
                gioitinh2 = false;
            }
            nv.Nu = gioitinh2;
            nv.SoDienThoai = txtSDT.Text;
            if (picNhanvien.Image == null)
            {
                nv.Hinh = null;
            }
            else
            {
                nv.Hinh = imgToByteArray(picNhanvien.Image);
            }
            nv.LoaiNV = int.Parse(txtLoainv.Text);
            dbs.SubmitChanges();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            them = false;
            panelQuanli.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnSave.Enabled = true;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;

            txtID.Enabled = false;
        }

        protected void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            int r = GridNhanvien.CurrentCell.RowIndex;
            string strID = GridNhanvien.Rows[r].Cells[0].Value.ToString();
            NHANVIEN kh = dbs.NHANVIENs.Single(p => p.ID.ToString() == strID && p.TrangThai == true);// bang nhan vien
            kh.TrangThai = false;
            MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dbs.SubmitChanges();
            LoadData();
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
        private void GridNhanvien_Click(object sender, EventArgs e)
        {
           
        }

        private void GridNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            int r = GridNhanvien.CurrentCell.RowIndex;
            txtID.Text = GridNhanvien.Rows[r].Cells[0].Value.ToString();
            txtHoten.Text = GridNhanvien.Rows[r].Cells[1].Value.ToString();
            txtDiachi.Text = GridNhanvien.Rows[r].Cells[2].Value.ToString();
            txtCMND.Text = GridNhanvien.Rows[r].Cells[3].Value.ToString();
            txtSDT.Text = GridNhanvien.Rows[r].Cells[4].Value.ToString();
            txtNgaynhan.Text = GridNhanvien.Rows[r].Cells[5].Value.ToString();
            string gt = GridNhanvien.Rows[r].Cells[6].Value.ToString();
            if (gt.Equals("True"))
                ckbNu.CheckState = CheckState.Checked;
            else
                ckbNu.CheckState = CheckState.Unchecked;
            NHANVIEN abc = dbs.NHANVIENs.Single(p => (p.TrangThai == true) && (p.ID.ToString() == txtID.Text));
            if (abc.Hinh == null)
            {
                picNhanvien.Image = picNhanvien.BackgroundImage;
            }
            else
            {
                picNhanvien.Image = byteArrayToImage(abc.Hinh.ToArray());
            }
            txtLoainv.Text = GridNhanvien.Rows[r].Cells[8].Value.ToString();

        }



        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (them)
            {
                Them(txtHoten.Text, txtDiachi.Text, txtCMND.Text, txtSDT.Text, Convert.ToDateTime(txtNgaynhan.Text), Convert.ToBoolean(ckbNu.CheckState), Convert.ToInt16(txtLoainv.Text));
                MessageBox.Show("Thêm thành công");
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

        private void ribbonControl_Click(object sender, EventArgs e)
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
        private void txtSDT_Leave(object sender, EventArgs e)
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

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            picNhanvien.Image = null;
        }

    }
}