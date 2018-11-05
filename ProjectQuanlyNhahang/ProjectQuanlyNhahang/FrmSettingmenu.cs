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
    public partial class FrmSettingmenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmSettingmenu()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void FrmSettingmenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtTimTen.ResetText();
            txtTimDonGia.ResetText();
            txtTimMa.ResetText();


            txtTimMa.Enabled = false;
            txtTimTen.Enabled = false;
            txtTimDonGia.Enabled = false;
            //txtMaNV.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnLoad.Enabled = true;
            //btnSearch.Visible = true;
            panelTimMon.Hide();
            panelMonan.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var ketqua =
                from p in dbs.SANPHAMs //chọn những khách hàng trong bảng khách hàng 
                where p.TrangThai == true
                select new
                {
                    p.ID,
                    p.TenSP,
                    p.DonGia,
                    p.Hinh,
                };
            // loadCombo1();
            dgvMenu.DataSource = ketqua;
           
        }
        bool them = false;
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMonan.Enabled = true;
            them = true;
            txtMamon.ResetText();
            txtTenmon.ResetText();
            txtTimDonGia.ResetText();
            txtDongia.ResetText();
            txtMamon.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            int r = dgvMenu.CurrentCell.RowIndex;
            string strMaNV = dgvMenu.Rows[r].Cells[0].Value.ToString();
            SANPHAM kh = dbs.SANPHAMs.Single(p => p.ID.ToString() == strMaNV && p.TrangThai == true);// bang nhan vien
            kh.TrangThai = false;
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dbs.SubmitChanges();
            LoadData();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            them = false;
            panelMonan.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnLoad.Enabled = true;

            btnXoa.Enabled = false;
            txtMamon.Enabled = false;
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
        public void Them(string ten, int mk)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            SANPHAM nv = new SANPHAM();
         
                nv.TenSP = ten;
                nv.DonGia = mk;
                if (picMonan.Image == null)
                {
                    nv.Hinh = null;
                }
                else
                {
                    nv.Hinh = imgToByteArray(picMonan.Image);
                }
                nv.TrangThai = true;
                dbs.SANPHAMs.InsertOnSubmit(nv);
                dbs.SubmitChanges();
                MessageBox.Show("Thêm thành công");
        }
        public void sua(string a)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            SANPHAM nv = dbs.SANPHAMs.Single(p => p.ID.ToString() == a);

            nv.TenSP = txtTenmon.Text;
            nv.DonGia = Convert.ToInt32(txtDongia.Text);
            if (picMonan.Image == null)
            {
                nv.Hinh = null;
            }
            else
            {
                nv.Hinh = imgToByteArray(picMonan.Image);
            }
            dbs.SubmitChanges();
        }
        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (them)
            {
                Them(txtTenmon.Text,Convert.ToInt32(txtDongia.Text));
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

        private void btnLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnTim_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelTimMon.Show();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            panelMonan.Enabled = false;
            int r = dgvMenu.CurrentCell.RowIndex;

            txtMamon.Text = dgvMenu.Rows[r].Cells[0].Value.ToString();
            txtTenmon.Text = dgvMenu.Rows[r].Cells[1].Value.ToString();
            txtDongia.Text = dgvMenu.Rows[r].Cells[2].Value.ToString();
            SANPHAM abc = dbs.SANPHAMs.Single(p => (p.TrangThai == true) && (p.ID.ToString() == txtMamon.Text));
            if (abc.Hinh == null)
            {
                picMonan.Image = picMonan.BackgroundImage;
            }
            else
            {
                picMonan.Image = byteArrayToImage(abc.Hinh.ToArray());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTen.ResetText();
            txtTimDonGia.ResetText();
            txtTimMa.ResetText();

            
            txtTimMa.Enabled = true;
            txtTimTen.Enabled = false;
            txtTimDonGia.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTen.ResetText();
            txtTimDonGia.ResetText();
            txtTimMa.ResetText();


            txtTimMa.Enabled = false;
            txtTimTen.Enabled = true;
            txtTimDonGia.Enabled = false;
        }

        private void radioLoai_CheckedChanged(object sender, EventArgs e)
        {
            txtTimTen.ResetText();
            txtTimDonGia.ResetText();
            txtTimMa.ResetText();


            txtTimMa.Enabled = false;
            txtTimTen.Enabled = false;
            txtTimDonGia.Enabled = true;
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
             RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
             try
             {

                 var kq1 =
                    from p in dbs.SANPHAMs //chọn những nvách hàng trong bảng nvách hàng 
                    where p.ID == Convert.ToInt32(txtTimMa.Text) && p.TrangThai == true
                    select new
                    {
                        p.ID,
                        p.TenSP,
                        p.DonGia,
                        p.Hinh,

                    };

                 dgvMenu.DataSource = kq1;
             }
             catch { }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
             RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
                from p in dbs.SANPHAMs //chọn những nvách hàng trong bảng nvách hàng 
                where p.TenSP.StartsWith(txtTimTen.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenSP,
                   p.DonGia,
                   p.Hinh,
               };

            dgvMenu.DataSource = kq1;
        }

        private void txtTimDonGia_TextChanged(object sender, EventArgs e)
        {

            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
                from p in dbs.SANPHAMs //chọn những nvách hàng trong bảng nvách hàng 
                where p.DonGia.ToString().StartsWith(txtDongia.Text) && p.TrangThai == true
                select new
                {
                    p.ID,
                    p.TenSP,
                    p.DonGia,
                    p.Hinh,
                };

            dgvMenu.DataSource = kq1;
        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog upPicture = new OpenFileDialog();
            upPicture.InitialDirectory = "E:\\Image Project 1";
            DialogResult tl = upPicture.ShowDialog();
            if (tl == DialogResult.OK)
            {
                picMonan.Image = Image.FromFile(upPicture.FileName);
            }
        }

        private void btnXoahinh_Click(object sender, EventArgs e)
        {
            picMonan.Image = null;
        }
    }
}