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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int IDban;
        public FrmMain(string user,string password,int admin)
        {
            tentaikhoan = user;
            matkhau = password;
            Admin = admin;
            InitializeComponent();
        }
        string tentaikhoan, matkhau;
        int Admin;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDoiMK Doimk = new FrmDoiMK(tentaikhoan,matkhau);
            Doimk.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            loadData();
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();  //Nếu là admin thì có quyền cao nhất 
            if (Admin == 4)
            {
                label2.Text = "Xin chào " + "    " + tentaikhoan;
            }
           
            else if (Admin == 1)    
            {
                label2.Text = "Xin chào " + "    " + tentaikhoan;
                ribbonPageGroup3.Enabled = false;
                ribbonPageGroup4.Enabled = false;
                ribbonPageGroup6.Enabled = false;
                ribbonPageGroup10.Enabled = false;
                ribbonPageGroup13.Enabled = false;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;


            }
            else if(Admin==2)
            {
                
            }
            if(Admin==3)
            {

            }
            if(Admin==4)
            {

            }
            SetUpTable();
        }
        public void loadData()
        {
            panel1.Enabled = false;
            txtMaban.ResetText();
            txtTenBan.ResetText();

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
         
            btnSua.Enabled = true;

            btnLuu.Enabled = false;
         
          
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq = from p in dbs.BANs

                     where p.TrangThai == 1

                     select new
                     {
                         p.ID,
                         p.TenBan,
                         p.status

                     };



            dgvTable.DataSource = kq;
            dgvTable.BackgroundColor = Color.White;

            dgvTable_CellClick(null, null);

        }
        private void btnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSettingmenu menu = new FrmSettingmenu();
            menu.ShowDialog();
        }

        private void btnNhansu_ItemClick(object sender, ItemClickEventArgs e)
        {
           FrmQuanlinv nv = new FrmQuanlinv();
           nv.ShowDialog();
        }

        private void btnTim_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTimnv Searchnv = new FrmTimnv();
            Searchnv.ShowDialog();
        }

        private void btnQuanliAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChitietAd QLAdmin = new FrmChitietAd();
            QLAdmin.ShowDialog();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnKhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowDialog();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMenu mn = new FrmMenu();
            mn.ShowDialog();
          
        }
        int tagtext;
        public void SetUpTable()        //Tạo button Bàn tương ứng
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            foreach (BAN item in dbs.BANs)
            {
                if (item.TrangThai == 1)
                {
                    Button btn = new Button() { Width = 140, Height = 150 };
                    panelTable.Controls.Add(btn);
                    if (item.status == 1)
                    {
                        btn.Name = item.ID.ToString();
                        btn.Text = item.TenBan + "\n" + "(Full)";
                        btn.BackColor = Color.Violet;
                    }
                    else
                    {
                        btn.Name = item.ID.ToString();
                        btn.Text = item.TenBan + "\n" + "(Trống)";
                        btn.ForeColor = Color.Black;
                    }
                    btn.Click += btn_Click;
             
                    btn.Tag = item;

                    btn.Image = Image.FromFile(@"C:\Users\AVISHOP\Desktop\Image Project 1\OK.png");
                    btn.BackgroundImageLayout = ImageLayout.Tile;
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                }
            }
        }
        
       

        private void btn_Click(object sender, EventArgs e)
        {

            
                 Button bt = (Button)sender;    //lấy button đang được click // nút có tên Des là btn1
                 tagtext = Convert.ToInt32(((Button)sender).Name);
                 string temp = Convert.ToString(((Button)sender).Text);


                 
                 RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                 int statusOfThisTable = Convert.ToInt32(dbs.BANs.Where(P => P.ID == tagtext).ToList().First().status);  //Lấy id bàn bằng với bàn đang chọn
                 
                 IDban = statusOfThisTable;
                 if (statusOfThisTable != 0)         //Thanh toán bàn đang chọn
                 {
                     DialogResult tl1 = MessageBox.Show("Thanh Toán Không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                     if (tl1 == DialogResult.OK)
                     {
                         FrmXemmon f = new FrmXemmon(tagtext.ToString());
                         f.ShowDialog();
                         DialogResult tl = MessageBox.Show("Thanh Toán Hóa Đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         if (tl == DialogResult.Yes)
                         {
                             ThanhToan(tagtext);
                         }
                        
                     }
                     else
                     {

                     }
                 }
                 else
                 {
                     DialogResult tl1 = MessageBox.Show("Đặt Món ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    
                     if (tl1 == DialogResult.OK)
                     {
                         FrmDatmon dat = new FrmDatmon(tagtext);
                         dat.ShowDialog();
                         //DialogResult tl = MessageBox.Show("Bạn Đã Đặt Món Chưa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         RestaurantManagerDataContext dbs1 = new RestaurantManagerDataContext();
                         BAN ban = dbs1.BANs.Single(p => p.ID == tagtext);
                         if (ban.TrangThai == 1)
                         {
                           
                             if (ban.status == 1)
                             {
                               
                                 bt.Text = ban.TenBan + "\n" + "(Full)";
                                 bt.BackColor = Color.Violet;
                             }
                             else
                             {
                                
                                 bt.Text = ban.TenBan + "\n" + "(Trống)";
                                 bt.ForeColor = Color.Black;
                             }
                         }
                         dgvTable.Update();
                         loadData();
                     }
                     else
                     {

                     }
                 }
            
        }
        private void ThanhToan(Int32 mb)      //Hàm thanh toán
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            Int32 MaCanSua = mb;
            Sua2(MaCanSua);
            //HOADONBH hd = dbs.HOADONBHs.FirstOrDefault(p => p.MaBan == mb);
            //hd.TrangThai = false;
            MessageBox.Show("Thanh Toán Thành Công!!!");
            dgvTable.Update();
            loadData();
            panelTable.Controls.Clear();
            SetUpTable();

            //dbs.SubmitChanges();
        }
        private void Datmon(Int32 mb)      //Hàm thanh toán
        {
            Int32 MaCanSua = mb;
            Sua1(MaCanSua); 

            panelTable.Controls.Clear();
            SetUpTable();

            //dbs.SubmitChanges();
        }
        public void Sua1(Int32 id)        //Sửa theo id bàn đang chọn
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            BAN tb = dbs.BANs.Single(p => p.ID == id);
            //BAN tb = new BAN();
            //btnLuu_Click(null, null);
            tb.status = 1;
         
            dbs.SubmitChanges();
        }

        public void Sua2(Int32 id)        //Sửa theo id bàn đang chọn
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            BAN tb = dbs.BANs.Single(p => p.ID == id);
            //BAN tb = new BAN();
            //btnLuu_Click(null, null);
            tb.status = 0;
           
            dbs.SubmitChanges();
        }

		private void btnNhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyKho ql = new FrmQuanLyKho();
            ql.ShowDialog();
        }

        private void btnTimThongtinKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTimKiemKH tim = new FrmTimKiemKH();
            tim.ShowDialog();
        }

        private void panelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmHoadonBH bh = new FrmHoadonBH();
            bh.ShowDialog();
        }

        private void txtTrangThai_ValueChanged(object sender, EventArgs e)
        {

        }
        bool Them=false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            Them = true;
            panel1.Enabled = true;
            txtMaban.Enabled = false;
            txtMaban.ResetText();
            txtTenBan.ResetText();
            txtTrangThai.ResetText();
           

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
           
            txtTenBan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            panel1.Enabled = true;
            dgvTable_CellClick(null, null);
           
            btnLuu.Enabled = true;
        
            txtMaban.Enabled = false;
            txtTenBan.Focus();
            //Tat reload, them , sua ,xoa,tro ve

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        
        }
        public void Them_Ban(string tenban, int status, int tt)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            BAN tb = new BAN();
            tb.TenBan = tenban;
            tb.status = status;
            tb.TrangThai = tt;


            dbs.BANs.InsertOnSubmit(tb);
            dbs.SubmitChanges();
        }
        public void Sua(int id)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            BAN tb = dbs.BANs.Single(p => p.ID == id);
            tb.TenBan = txtTenBan.Text;
            tb.status = Int32.Parse(txtTrangThai.Text);
            dbs.SubmitChanges();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                Them_Ban(txtTenBan.Text, 0, 1);
                Button btn = new Button() { Width = 140, Height = 150 };             //Tạo button bàn 
                panelTable.Controls.Add(btn);
                btn.Text = txtTenBan.Text + "\n" + "(Trống)";
                btn.ForeColor = Color.Black;
                btn.Image = Image.FromFile(@"C:\Users\AVISHOP\Desktop\Image Project 1\OK.png");
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                MessageBox.Show("Thêm thành công");
                panelTable.Controls.Clear();
                SetUpTable();
                loadData();
            }
            else
            {
                int r = dgvTable.CurrentCell.RowIndex;
                int MaCanSua = Int32.Parse(dgvTable.Rows[r].Cells[0].Value.ToString());
                Sua(MaCanSua);
                MessageBox.Show("Sửa thành công");
                panelTable.Controls.Clear();
                SetUpTable();
                loadData();
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTable.CurrentCell.RowIndex;

            txtMaban.Text = dgvTable.Rows[r].Cells[0].Value.ToString();
            txtTenBan.Text = dgvTable.Rows[r].Cells[1].Value.ToString();
            txtTrangThai.Text = dgvTable.Rows[r].Cells[2].Value.ToString();

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLuong luong = new FrmLuong();
            luong.ShowDialog();
        }

        private void btnHoadonNH_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNhaphang nh = new FrmNhaphang();
            nh.ShowDialog();
        }
    }
}