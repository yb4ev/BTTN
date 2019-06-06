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
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyVVP.Views
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        static string connectstr = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString;
        SqlConnection con = new SqlConnection(connectstr);
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDangnhap_Click(object sender, EventArgs e)
        {   

            if (TxtTaikhoan.Text == "")
            {
                dxErrorProvider1.SetError(TxtTaikhoan, "Nhập tên đăng nhập!");
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }

            if (TxtMatkhau.Text == "")
            {
                dxErrorProvider1.SetError(TxtMatkhau, "Nhập mật khẩu!");
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            };
            //Kiểm tra theo id,pw trong sql
            string id, pw;
            id = TxtTaikhoan.Text;
            pw = TxtMatkhau.Text;
            string sql = "Select *from NGUOIDUNG where Tendn= '" + id + "'and Matkhau = '" + pw + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                this.Hide();
                LbThongbao.Visible = false;
                Trangchu a = new Trangchu
                {
                    Message = TxtTaikhoan.Text
                };
                a.ShowDialog();
            }
            else
            {
                timer1.Enabled = true;
                LbThongbao.Visible = true;
                LbThongbao.Text = "TÀI KHOẢN HOẶC MẤT KHẨU KHÔNG CHÍNH XÁC!";
                TxtTaikhoan.Text = "";
                TxtMatkhau.Text = "";
                TxtTaikhoan.Focus();

            }
            con.Close();


        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbThongbao.Text = "";
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}