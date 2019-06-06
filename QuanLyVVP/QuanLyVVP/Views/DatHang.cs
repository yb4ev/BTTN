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
using QuanLyVVP.Views.Report;
using DevExpress.XtraReports.UI;

namespace QuanLyVVP.Views
{
    public partial class DatHang : DevExpress.XtraEditors.XtraForm
    {
        public DatHang()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        //int stt = 0;
        private void DatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLyVVPDataSetAll.NCC);
            // TODO: This line of code loads data into the 'qLyVVPDataSet_Idphieudat.View_Idphieudat' table. You can move, or remove it, as needed.
            this.view_IdphieudatTableAdapter.Fill(this.qLyVVPDataSet_Idphieudat.View_Idphieudat);
            con = new SqlConnection(conString);

        }
        private string AutoIdhang(string HT)
        {
            string Matusinh = "";
            int count = 0;

            count = viewIdphieudatBindingSource.Count; //lấy số dòng của dgv.
            int chuoiSo = 0;
            string ChuoiId = Convert.ToString(count);
            chuoiSo = Convert.ToInt32(ChuoiId.Replace(HT, "0"));
            if (chuoiSo + 1 < 10)
            {
                Matusinh = HT + "0" + (chuoiSo + 1).ToString();
            }
            else if (chuoiSo + 1 < 100)
            {
                Matusinh = HT + "" + (chuoiSo + 1).ToString();
            }

            return Matusinh;
        }
        private void LoadDL()
        {
            gridView1.FocusInvalidRow();
            SqlCommand cmt = new SqlCommand("sp_ShowPhieuDat", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt.Parameters.AddWithValue("Idpd", TxtIdpd.Text);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmt);//chuyển dữ liệu về
            SqlDataReader dr = cmt.ExecuteReader();
            DataTable dt = new DataTable();  //tạo kho  ảo để lưu dữ liệu
            dt.Load(dr);//đổ dữ liệu vào kho
            gridControl1.DataSource = dt;//Load dữ liệu lên
            con.Close();
        }

        private void TxtIdpd_EditValueChanged(object sender, EventArgs e)
        {
            LoadDL();
            BtnIn.Enabled = true;
        }
        private void LayIdsp()
        {
            SqlCommand cmt1 = new SqlCommand("sp_ShowIdsp_PhieuDat", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt1.Parameters.AddWithValue("Idncc", TxtNCC.EditValue);
            cmt1.Parameters.AddWithValue("Idpd", TxtIdpd.EditValue);

            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
            SqlDataReader dr1 = cmt1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);//đổ dữ liệu vào kho           
            TxtIdsp.Properties.DataSource = dt1;
            TxtIdsp.Properties.DisplayMember = "Idsp";
            TxtIdsp.Properties.ValueMember = "Idsp";
            con.Close();
        }
        private void BtnThemPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnThemSP.Enabled = true;
           
            BtnLuu.Enabled = true;
            BtnHuy.Enabled = true;
            BtnBoSP.Enabled = true;
            TxtIdsp.ReadOnly = false;
            TxtNCC.ReadOnly = false;
            TxtThoigian.ReadOnly = false;
            TxtIdpd.Text = AutoIdhang("0");
            gridControl1.DataSource = null;
            
        }

        private void TxtNCC_EditValueChanged(object sender, EventArgs e)
        {
            LayIdsp();
        }
       
        private void BtnThemSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnHuy.Enabled = true;
            BtnIn.Enabled = true;

        }

        private void TxtIdsp_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Tensp,Dvt FROM SANPHAM WHERE Idsp = @Idsp";
                SqlCommand cmt1 = new SqlCommand(sql, con)
                {
                    CommandType = CommandType.Text
                };
                cmt1.Parameters.AddWithValue("Idsp", TxtIdsp.EditValue);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                SqlDataReader dr1 = cmt1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);//đổ dữ liệu vào kho                       
                TxtTensp.Text = dt1.Rows[0]["Tensp"].ToString().Trim();
                TxtDvt.Text = dt1.Rows[0]["Dvt"].ToString().Trim(); //Load dữ liệu lên từng textbox        
                con.Close();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hãy chọn mã sản phẩm!");
            }
            
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnHuy.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            TxtTensp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tensp");
            TxtDvt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dvt");
            TxtSoluong.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Soluongdat");
            TxtThoigian.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Thoigian");
        }
        private void ThemSP_PhieuDat()
        {
            //sp_InsertPD
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertPD", con)
                {
                    CommandType = CommandType.StoredProcedure
                };              
                    add.Parameters.AddWithValue("Idpd", TxtIdpd.EditValue);
                    add.Parameters.AddWithValue("Idsp", TxtIdsp.EditValue);
                    add.Parameters.AddWithValue("Idncc", TxtNCC.EditValue);
                    add.Parameters.AddWithValue("Tennv", " ");
                    add.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                    add.Parameters.AddWithValue("Dvt", TxtDvt.Text);
                    add.Parameters.AddWithValue("Soluongdat", TxtSoluong.EditValue);
                    add.Parameters.AddWithValue("Thoigian", TxtThoigian.EditValue);

                con.Open();
                add.ExecuteNonQuery();
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2671)
                {
                    XtraMessageBox.Show("Mã đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("\tLỗi không xác định\n\tVui lòng ấn cập nhật\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void XoaSP_PhieuDat()
        {
            //sp_DelPD
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_DelPD", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idpd", TxtIdpd.Text);
                cmt1.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                SqlDataReader dr1 = cmt1.ExecuteReader();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                con.Close();
                LoadDL();

            }
            catch (SqlException exc)
            {
                MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TxtNCC.ReadOnly = true;
            ThemSP_PhieuDat();
            LoadDL();
            LayIdsp();
            BtnIn.Enabled = false;
        }

        private void BtnBoSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaSP_PhieuDat();
            
        }

        private void BtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TxtNCC.ReadOnly = false;

            XtraReportDatHang report = new XtraReportDatHang();
            report.Parameters["parameter1"].Value = TxtIdpd.Text;
            report.Parameters["Tenncc"].Value = TxtNCC.Text;
            report.ShowRibbonPreviewDialog();
        }
    }
}