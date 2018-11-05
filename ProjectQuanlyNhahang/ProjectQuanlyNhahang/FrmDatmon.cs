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
using System.Text.RegularExpressions;

namespace ProjectQuanlyNhahang
{
    public partial class FrmDatmon : DevExpress.XtraEditors.XtraForm
    {
        public FrmDatmon()
        {
       
            InitializeComponent();
        }
        public FrmDatmon(int IDbanNhan)
        {
            Ban = IDbanNhan;
            InitializeComponent();
        }
        int Ban;
        public delegate void KieuDulieuTruyenRa(string a);
        private void FrmDatmon_Load(object sender, EventArgs e)
        {
            label7.Text = Ban.ToString();
            btnOrder.Hide();    // moi vao khong duoc order 
            btnHoaDon.Hide();   //moi vao không duoc dat ban
            cmbNhanVien.ResetText();

            loadcmb();

            loadData();

        }
        public void loadData()
        {
            //Load menu lên listbox
            
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq2 = from p in dbs.KHACHHANGs
                      select p;
            cmbKH.DataSource = kq2;
            cmbKH.DisplayMember = "TenKH";
            cmbKH.ValueMember = "ID";
            var kq =
                from p in dbs.SANPHAMs
                where p.TrangThai == true
               
                select new
                {
                    p.ID,
                    p.TenSP,
                    p.DonGia,
                    //p.Hinh,

                };

            lsbThucUong.DataSource = kq;
            lsbThucUong.DisplayMember = "name";

            checkButton();      //sử lý nút Undo 

            loadcmb();
            for (int i = 0; i <= n; i++)        //Khởi tạo số lượng món ăn bằng 0
            {
                B[i] = 0;
            }
            cmbLoaiThucUong.ResetText();

        }
        public void loadcmb()
        {
            // Load tên cần thiết lên cmb
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

            var kq =
                from p in dbs.SANPHAMs
                where p.TrangThai == true
                select p;

            cmbLoaiThucUong.DataSource = kq;
            cmbLoaiThucUong.DisplayMember = "TenSP";
            cmbLoaiThucUong.ValueMember = "ID";

            idCafeCategory.DisplayMember = "TenSp";
            idCafeCategory.ValueMember = "ID";
            idCafeCategory.DataSource = kq;

            var kh =
             from p in dbs.KHACHHANGs
             where p.TrangThai == true
             select p;
            cmbNhanVien.DataSource = kh;
            cmbNhanVien.DisplayMember = "TenKH";
            cmbNhanVien.ValueMember = "ID";

            var nv =
              from p in dbs.NHANVIENs
              where p.TrangThai == true
              select p;
            cmbNhanVien.DataSource = nv;
            cmbNhanVien.DisplayMember = "HoTenNV";
            cmbNhanVien.ValueMember = "ID";



            var ban =
                from p in dbs.BANs
                where p.TrangThai == 1 && p.status == 0
                select p;
            cmbBan.DataSource = ban;
            cmbBan.DisplayMember = "TenBan";
            cmbBan.ValueMember = "ID";

        }

        private void cmbLoaiThucUong_SelectionChangeCommitted(object sender, EventArgs e)
        {

          

        }
        string[] A = new string[100];// Tạo mảng 1 chiều chứa tên các món
        int[] B = new int[100];     //tạo mảng 1 chiều chứa số lượng món
        int[] C = new int[100];
        int n = -1;     //khởi tạo biến chạy cho vòng for
        int max = -1;   //khởi tạo biến chạy cho vòng for

        void sinh()     // Sinh button sau đó đưa vào trong flowlayfoutpanel
        {

            for (int i = 0; i <= n; i++)
            {

                TextBox txt = new TextBox() { Height = 100, Width = 250 };

                txt.Text = A[i] + "     " + (B[i]).ToString() + "\n";

                flpOrder.Controls.Add(txt);
                txtSoLuong.ResetText();
                txtSoLuong.Focus();
            }


        }



        void checkButton()
        {
            if (n == -1)    //nếu chưa order sản phẩm thì ẩn nút undo
                btnUndo.Visible = false;
            else
                btnUndo.Visible = true;


        }

        public void Them_HD(int Manv,int Maban, bool tt,int Makh,int Tien)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            HOADONBH b = new HOADONBH();    //Tạo 1 hóa đơn mới
          
            b.MaNV = Manv;
            b.MaBan = Maban;
            b.TrangThai = tt;
            b.MaKH = Makh;
            b.TongTien = Tien;
            dbs.HOADONBHs.InsertOnSubmit(b);
            dbs.SubmitChanges();


        }

        //Tính Tiền Hóa Đơn
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            double s = 0;
            for (int i = 0; i <= n; i++)
            {
                var kq =
                    from p in dbs.SANPHAMs
                    where p.ID == Convert.ToInt32(trim(A[i]))
                    select p;
                int gia = kq.ToList().First().DonGia;
                s = s + gia * B[i];  //Giá tiền bằng số lượng nhân với giá sản phẩm
            }
            txtSum.Text = Convert.ToString(s);
        }
        string trim(string value) ///     15000 ///   
        {
	        string kq ="";
                    for (int i = 6; i < value.Length;i++)
                    {
                        if(value[i] ==44)
                        {
                             
                              break;
                         
                        }
                        kq = kq + value[i];
                    }
               
                   return kq;
                  
        }
            
        bool datban = false;
        public void ktTrung()       //Kiểm tra món được chọn bị trùng hay không
        {
            int vitri = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (A[j] == A[i])
                    {
                        vitri = j;
                        XoaTaiViTri(A, ref n, vitri);
                        B[i] = B[i] + Int32.Parse(txtSoLuong.Text);     //Số lượng được cộng dồn nếu tên trùng
                    }
                }
            }
        }
        public void XoaTaiViTri(string[] A, ref int n, int vitri)
        {
            for (int i = vitri; i < n - 1; i++)
                A[i] = A[i + 1];
            n--;
        }

        // int dem = 0;
        private void createBillDetail(int id,DateTime date,int thisCoffee, int sl)       //tạo chi tiết hóa đơn
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            //thisCoffee = dbs.SANPHAMs.Where(p => p.ID == id).ToList().Last().ID;       //tìm món có mã bằng vs mã đã chọn
            CHITIETHDBH bill = new CHITIETHDBH();
            {
                bill.IDHD=id;
                bill.Ngay=date;
                bill.SanPham = thisCoffee;           
                bill.SoLuong = sl;
                bill.TrangThai = true;
                
            };
            dbs.CHITIETHDBHs.InsertOnSubmit(bill);
            dbs.SubmitChanges();
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            datban = true;
            DialogResult tl = MessageBox.Show("Bạn có muốn gọi thêm gì không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (tl == DialogResult.No)
                {
                    txtSoLuong.Enabled = false;
                    btnChon.Enabled = false;
                    int id = Int32.Parse(cmbBan.SelectedValue.ToString());
                    RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                    BAN tb = dbs.BANs.Single(p => p.ID == id && p.TrangThai == 1);
                    tb.status = 1;          //trạng thái bàn đã được đặt
                    dbs.SubmitChanges();
                    btnOrder.Show();
                    btnUndo.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Hết Bàn Rồi!!!");
                btnOrder.Enabled = false;
            }
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
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (datban = true)
            {
                int k = n;
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                try
                {
                    //Them_HD(int idtable,int Makh,int Manv,int Maban, bool tt, string tong)
                    Them_HD(Int32.Parse(cmbNhanVien.SelectedValue.ToString()), Int32.Parse(cmbBan.SelectedValue.ToString()), true, Int32.Parse(cmbKH.SelectedValue.ToString()),Convert.ToInt32(txtSum.Text));
                    int thisRec = dbs.HOADONBHs.ToList().Last().ID;//lấy hóa đơn vừa được add vào bill
                    for (int i = 0; i <= k; i++)
                    {
                        createBillDetail(thisRec,DateTime.Now, Convert.ToInt32(trim(A[i])), B[i]); //Tạo chi tiết hóa đơn gồm nhìu món
                      
                    }
                    MessageBox.Show("Đã thêm vào chi tiết hóa đơn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSum.Text = "";
                    flpOrder.Controls.Clear();
                    label7.Text = Ban.ToString();
                    BAN tb = dbs.BANs.Single(p => p.ID == Ban);
                    tb.status = 1;
                    dbs.SubmitChanges();
                    loadData();
                    this.Close();
              

                }
                catch
                {
                    MessageBox.Show("Hết Bàn Rồi!!!");
                    cmbBan.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Chưa đặt bàn");
            }
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            btnHoaDon.Show();
            bool flag = false;
            if (txtSoLuong.Text == "")   //kiểm tra số lượng có rỗng hay không
            {
                MessageBox.Show("Nhập số lượng", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                flag = false;   //số lượng không hợp lệ 
            }
            else  //số lượng hợp lệ
            {
                flag = true;
            }

            if (flag == true)         //nếu số lượng hợp lệ
            {
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();

                n++;
                max++;
                A[n] = lsbThucUong.Text;      //khi nhấn button chọn thì A[n++]
                B[n] = Int16.Parse(txtSoLuong.Text.Trim());    //khi nhấn button chọn thì B[n++]
                checkButton();
                ktTrung();          //Loại trừ trường hợp gọi 1 món nhiều lần
            }
            flpOrder.Controls.Clear();
            sinh();       //sinh số lượng và món đã chọn
           btnTinhTien_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            cmbLoaiThucUong.ResetText();
        }

        private void btnUndo_Click_1(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Hủy lựa chọn gần nhất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                if (n >= 0)
                {
                    n--;
                    flpOrder.Controls.Clear();
                    sinh();
                }
            }
            checkButton();
            btnTinhTien_Click(null, null);
        }

        private void lsbThucUong_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtSoLuong.Focus();
        }

        private void lsbThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}