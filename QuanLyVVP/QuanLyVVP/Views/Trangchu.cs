using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLyVVP.Views.Report;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyVVP.Views
{
    public partial class Trangchu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        private void BarButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            SP a = new SP
            {
                MdiParent = this
            };
            a.Show();
            
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void BarButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Loaisp a = new Loaisp
            {
                MdiParent = this
            };
            a.Show();
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void ThongKeSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraReportThongKeHT report = new XtraReportThongKeHT();
            report.ShowRibbonPreview();
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void DanhSachNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            NCC a = new NCC
            {
                MdiParent = this
            };
            a.Show();
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void SanPhamNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            SPNCC a = new SPNCC
            {
                MdiParent = this
            };
            a.Show();
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void ThongTinKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhachHang a = new KhachHang
            {
                MdiParent = this
            };
            a.Show();
            //barHeaderItemInfor.Caption = "Thông tin: Có ... sản phẩm";
        }

        private void BtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Xác nhận đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                DangNhap a = new DangNhap();
                a.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void BtnDathang_ItemClick(object sender, ItemClickEventArgs e)
        {
            DatHang a = new DatHang
            {
                MdiParent = this
            };
            a.Show();
        }

        private void BtnNhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapHang a = new NhapHang
            {
                MdiParent = this
            };
            a.Show();
        }

        private void BtnBanhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            BanHang a = new BanHang
            {
                MdiParent = this
            };
            a.Show();
        }

        private void BarBtnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Hiện chưa có bản cập nhật mới","Thông báo");
        }

        private void BarBtnInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Phiên bản hiện tại : 1.0","Thông báo");
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            TenNgDung();
            QuyenDN();
        }
        private void TenNgDung()
        {
            SqlCommand sql = new SqlCommand("SELECT Tenngdung FROM NGUOIDUNG WHERE Tendn =@Tendn", con);
            sql.CommandType = CommandType.Text;
            sql.Parameters.AddWithValue("Tendn", Message);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(sql);
            SqlDataReader dr1 = sql.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);//đổ dữ liệu vào kho                       
            barEditItem2.EditValue = dt1.Rows[0]["Tenngdung"].ToString().Trim(); //Load dữ liệu lên từng textbox        
            con.Close();
        }

        private void BtnNgdung_ItemClick(object sender, ItemClickEventArgs e)
        {

            ThongtinNgDung a = new ThongtinNgDung
            {
                Idngdung = Message
            };
            a.ShowDialog();
        }
        private void QuyenDN()
        {
            string quyendn;
            string sql = "SELECT Quyendn FROM NHOMNGDUNG where Idngdung = (Select Idngdung from NGUOIDUNG where Tenngdung = @Tenngdung)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Tenngdung",barEditItem2.EditValue);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            SqlDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);//đổ dữ liệu vào kho                       
            quyendn = dt1.Rows[0]["Quyendn"].ToString().Trim(); //Load dữ liệu lên từng textbox        
            con.Close();
            switch (quyendn)
            {
                case "Bán hàng":
                    BtnNhaphang.Enabled = BtnDathang.Enabled = DanhSachNCC.Enabled = SanPhamNCC.Enabled = PhanLoaiSP.Enabled  = false;
                    break;
                case "Nhập hàng":
                     DanhSachNCC.Enabled = SanPhamNCC.Enabled = PhanLoaiSP.Enabled =  ThongTinKH.Enabled=BtnDathang.Enabled= false;
                    BtnBanhang.Enabled = false;
                    break;
                case "Quản lý":
                    DanhSachSP.Enabled = false;
                    break;
                case "Xử lý hoá đơn":
                     
                    ThongTinKH.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void BarBtnDN_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Chưa phát triển");
        }
    }
}