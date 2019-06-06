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
    public partial class NhapHang : DevExpress.XtraEditors.XtraForm
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLyVVPDataSetAll.NCC);
            // TODO: This line of code loads data into the 'qLyVVPDataSet_Idpn.View_Idpn' table. You can move, or remove it, as needed.
            this.view_IdpnTableAdapter.Fill(this.qLyVVPDataSet_Idpn.View_Idpn);
            con = new SqlConnection(conString);
            


        }

        private void LayIdsp()
        {      
                SqlCommand cmt1 = new SqlCommand("sp_ShowIdsp_PN", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idncc", TxtNCC.EditValue);
                cmt1.Parameters.AddWithValue("Idpn", TxtIdpn.EditValue);
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

        private string AutoIdhang(string HT)
        {
            string Matusinh = "";
            int count = 0;

            count = viewIdpnBindingSource.Count; //lấy số dòng của dgv.
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
            SqlCommand cmt = new SqlCommand("sp_ShowPhieuNhap", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt.Parameters.AddWithValue("Idpn", TxtIdpn.EditValue);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmt);//chuyển dữ liệu về
            SqlDataReader dr = cmt.ExecuteReader();
            DataTable dt = new DataTable();  //tạo kho  ảo để lưu dữ liệu
            dt.Load(dr);//đổ dữ liệu vào kho
            gridControl1.DataSource = dt;//Load dữ liệu lên
            con.Close();
        }

        private void TxtIdpn_EditValueChanged(object sender, EventArgs e)
        {
            LoadDL();
            
        }

        private void TxtNCC_EditValueChanged(object sender, EventArgs e)
        {            
            LayIdsp();
            TxtIdsp.Text = "";
            TxtIdsp.ReadOnly =  TxtThanhtien.ReadOnly = false;
        }

        private void TxtIdsp_EditValueChanged(object sender, EventArgs e)
        {   
            if(TxtIdsp.Text !="")
            {
                try
                {
                    string sql = "SELECT Tensp,Dvt,Gianhap FROM SANPHAM WHERE Idsp = @Idsp";
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
                    TxtDvt.Text = dt1.Rows[0]["Dvt"].ToString().Trim();
                    TxtGianhap.Text = dt1.Rows[0]["Gianhap"].ToString().Trim();//Load dữ liệu lên từng textbox        
                    con.Close();
                    TxtSLdat.ReadOnly = TxtSLnhan.ReadOnly = false;
                    BtnLuu.Enabled = true;

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Hãy chọn mã sản phẩm!");
                }
            }

           


        }

        private void TxtGianhap_KeyUp(object sender, KeyEventArgs e)
        {
            int a = Convert.ToInt32(TxtSLnhan.EditValue);
            int b = Convert.ToInt32(TxtGianhap.EditValue);
            int c = a * b;
            TxtThanhtien.Text = c.ToString();
        }

        private void BtnTaoPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnThemsp.Enabled = true;
            BtnIn.Enabled = true;
          
            BtnBosp.Enabled = true;
            TxtIdsp.ReadOnly = false;
            TxtThoigian.ReadOnly = false;
            TxtIdpn.Text = AutoIdhang("0");
            gridControl1.DataSource = null;
            TxtIdsp.Text = TxtDvt.Text =  TxtGianhap.Text =  TxtNCC.Text = "";
            TxtNCC.ReadOnly = false;
            TxtNggiao.ReadOnly = false;



        }

        private void BtnThemsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnHuy.Enabled = true;
            BtnThemsp.Enabled = false;
            if (gridView1.DataRowCount > 0)
            {
                BtnBosp.Enabled = true;
            }
            TxtIdsp.Text = TxtDvt.Text = TxtGianhap.Text = TxtNCC.Text =TxtTensp.Text ="";
            TxtSLdat.Text = TxtSLnhan.Text = TxtThoigian.Text = TxtThanhtien.Text ="";
        }

        private void BtnBosp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaSP_NhapHang();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //TxtIdsp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idsp");
            TxtTensp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tensp");
            TxtDvt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dvt");
            TxtSLdat.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Soluonggiao");
            TxtSLnhan.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Soluongnhap");
            TxtGianhap.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Gianhap");
            TxtThanhtien.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Thanhtien");
            TxtThoigian.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Thoigian");
            TxtNggiao.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Nguoigiao");
        }
        private void ThemSP_PhieuNhap()
        {
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertPN", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                add.Parameters.AddWithValue("Idpn", TxtIdpn.EditValue);
                add.Parameters.AddWithValue("Idsp", TxtIdsp.EditValue);
                add.Parameters.AddWithValue("Idncc", TxtNCC.EditValue);
                add.Parameters.AddWithValue("Tenngdung", " ");
                add.Parameters.AddWithValue("Nguoigiao", TxtNggiao.Text);
                add.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                add.Parameters.AddWithValue("Dvt", TxtDvt.EditValue);
                add.Parameters.AddWithValue("Soluonggiao", TxtSLdat.EditValue);
                add.Parameters.AddWithValue("Soluongnhap", TxtSLnhan.EditValue);
                add.Parameters.AddWithValue("Gianhap", TxtGianhap.EditValue);
                add.Parameters.AddWithValue("Thanhtien", TxtThanhtien.EditValue);
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
                    XtraMessageBox.Show("\tLỗi không xác định" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
        private void XoaSP_NhapHang()
        {
            
                //sp_DelPD
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelPN", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idpn", TxtIdpn.Text);
                    cmt1.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                    SqlDataReader dr1 = cmt1.ExecuteReader();
                    XtraMessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    LoadDL();

                }
                catch (SqlException exc)
                {
                    XtraMessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void TxtSLnhan_EditValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TxtSLnhan.EditValue);
            int b = Convert.ToInt32(TxtSLdat.EditValue);
            if (a > b)
            {
                XtraMessageBox.Show("Số lượng nhận không được lớn hơn số lượng đặt!");
                a = b;
                TxtSLnhan.Text = b.ToString();
            }
        }

        private void BtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                TxtNCC.ReadOnly = true;
                ThemSP_PhieuNhap();
                LoadDL();
                BtnThemsp.Enabled = true;
            }
            catch (SqlException)
            {

                XtraMessageBox.Show("Không được để trống!");
            }
            
        }

        private void BtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemSoLuong();
            XtraReportPhieuNhap report = new XtraReportPhieuNhap();
            report.Parameters["parameter1"].Value = TxtIdpn.Text;     
            report.ShowRibbonPreviewDialog();
            //string x, y;
            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    x = gridView1.GetDataRow(i).ToString();
                
            //}

        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnHuy.Enabled = false;
            BtnThemsp.Enabled = true;
        }

        private void ThemSoLuong()
        {   //sp_ThemSL
            string a; 
            
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                a = gridView1.GetRowCellValue(i, "Idsp").ToString();
               
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_ThemSL", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idsp", a);
                    cmt1.Parameters.AddWithValue("Idpn",TxtIdpn.EditValue);
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                    SqlDataReader dr1 = cmt1.ExecuteReader();
                    con.Close();

                }
                catch (SqlException exc)
                {
                    XtraMessageBox.Show("Lỗi không xác định:\n " + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}