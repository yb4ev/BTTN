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
using System.Configuration;

namespace QuanLyVVP.Views
{
    public partial class ThongtinNgDung : DevExpress.XtraEditors.XtraForm
    {
        private string _message;
        public string Idngdung
        {
            get { return _message; }
            set { _message = value; }
        }
        string matkhau;
        public ThongtinNgDung()
        {
            InitializeComponent();
        }
        static string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        private void ThongtinNgDung_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            ThongTin();

        }

        private void BtnDoiPass_Click(object sender, EventArgs e)
        {
            TxtPassCu.ReadOnly = TxtPassMoi.ReadOnly = false;
            BtnOK.Enabled = true;
            BtnDoiPass.Enabled = false;
            TxtPassCu.Focus();

            XtraMessageBox.Show("Nhập mật khẩu cũ để xác thực!");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            BtnDoiPass.Enabled = true;
            BtnOK.Enabled = false;
            TxtPassCu.ReadOnly = TxtPassMoi.ReadOnly = true;
            DoiMK();
        }
        private void ThongTin()
        {   string sql = "SELECT Idngdung,Tenngdung,Chucvu,Matkhau  FROM NGUOIDUNG where Tendn = @Tendn";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Tendn", Idngdung);
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            SqlDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);//đổ dữ liệu vào kho                       
            TxtHoten.EditValue = dt1.Rows[0]["Tenngdung"].ToString().Trim();
            TxtIdngdung.EditValue = dt1.Rows[0]["Idngdung"].ToString().Trim();
            TxtChucvu.EditValue = dt1.Rows[0]["Chucvu"].ToString().Trim();
            matkhau = dt1.Rows[0]["Matkhau"].ToString().Trim();
            //Load dữ liệu lên từng textbox        
            con.Close();

        }

        private void DoiMK()
        {
            if (TxtPassCu.Text == matkhau)
            {
                try
                {
                    string sql = "Update NGUOIDUNG Set Matkhau = @Matkhau where Tendn = @Tendn";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("Matkhau", TxtPassMoi.Text);
                    cmd.Parameters.AddWithValue("Tendn", Idngdung);
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    DataTable dt1 = new DataTable();
                    dt1.Load(dr1);//đổ dữ liệu vào kho                                      
                                        
                    con.Close();
                    XtraMessageBox.Show("Đổi mật khẩu thành công!");
                }
                catch (SqlException)
                {

                    XtraMessageBox.Show("Lỗi không xác định!");
                }
               
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng!");
            }
            
        }
    }
}