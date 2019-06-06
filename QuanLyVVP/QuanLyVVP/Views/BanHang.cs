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
    public partial class BanHang : DevExpress.XtraEditors.XtraForm
    {
        public BanHang()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;
        private void BanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.KHACHHANG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLyVVPDataSetAll.SANPHAM);
            // TODO: This line of code loads data into the 'qLyVVPDataSet_IdHD.View_IdHD' table. You can move, or remove it, as needed.
            this.view_IdHDTableAdapter.Fill(this.qLyVVPDataSet_IdHD.View_IdHD);
            con = new SqlConnection(conString);           
        }

        private string AutoIdhang(string HT)
        {
            string Matusinh = "";
            int count = 0;

            count = viewIdHDBindingSource.Count; //lấy số dòng của dgv.
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
            SqlCommand cmt = new SqlCommand("sp_ShowHD", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt.Parameters.AddWithValue("Idhd", TxtIdhd.Text);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmt);//chuyển dữ liệu về
            SqlDataReader dr = cmt.ExecuteReader();
            DataTable dt = new DataTable();  //tạo kho  ảo để lưu dữ liệu
            dt.Load(dr);//đổ dữ liệu vào kho
            gridControl1.DataSource = dt;//Load dữ liệu lên
            con.Close();
        }

        private void TxtIdhd_EditValueChanged(object sender, EventArgs e)
        {
            LoadDL();
            LayIdsp();
            BtnIn.Enabled = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtTensp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tensp");
            TxtDvt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dvt");
            TxtSoluong.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Soluong");
            TxtThoigian.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Thoigian");
            TxtThanhtien.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Thanhtien");
            TxtGiaxuat.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Giaxuat");
            TxtTenkh.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tenkh");
            CbHinhthuc.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Hinhthuc");

        }

        private void BtnThemSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 1;
            if (gridView1.DataRowCount > 0)
            {
                BtnBoSP.Enabled = true;
            }
            BtnHuy.Enabled = true;
            BtnSua.Enabled = false;
            BtnCapnhat.Enabled = true;
            CbHinhthuc.ReadOnly = false;
        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 2;
            if (gridView1.DataRowCount > 0)
            {
                BtnBoSP.Enabled = true;
            }
            BtnHuy.Enabled = true;
            BtnThemSP.Enabled = false;
        }

        private void BtnCapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (stt)
            {
                case 0:
                    {
                        LoadDL();
                        LayIdsp();
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 1:
                    {
                        ThemSP_HD();
                        LoadDL();
                        LayIdsp();
                        BtnHuy.Enabled = false;
                        if (gridView1.DataRowCount > 0)
                        {
                            BtnBoSP.Enabled = true;
                        }
                        BtnSua.Enabled = true;
                        BtnThemSP.Enabled = true;
                        stt = 0;
                        break;
                    }
                case 2:
                    {
                        SuaSP_HD();
                        LoadDL();
                        LayIdsp();
                        BtnHuy.Enabled = false;
                        if (gridView1.DataRowCount > 0)
                        {
                            BtnBoSP.Enabled = true;
                        }
                        BtnThemSP.Enabled = true;
                        stt = 0;
                        break;
                    }


            }
            BtnCapnhat.Enabled = false;
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            BtnHuy.Enabled = false;
            //TxtIdloaisp.Enabled = false;
            //TxtTenloaisp.Enabled = false;
            if (gridView1.DataRowCount > 0)
            {
                BtnBoSP.Enabled = true;
            }
            BtnSua.Enabled = true;
            BtnThemSP.Enabled = true;
            BtnCapnhat.Enabled = false;
        }

        private void BtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            if(CbHinhthuc.Text == "Sỉ")
            {
                GiamSoluong();
                XtraReportHD_Si report = new XtraReportHD_Si();
                report.Parameters["parameter1"].Value = TxtIdhd.Text;
                report.Parameters["Hinhthuc"].Value = CbHinhthuc.Text;
                report.ShowRibbonPreviewDialog();
            }
            if(CbHinhthuc.Text == "Lẻ")
            {
                GiamSoluong();
                XtraReportHD_Le report = new XtraReportHD_Le();
                report.Parameters["parameter1"].Value = TxtIdhd.Text;
                report.ShowRibbonPreviewDialog();
            }
           
        }

        private void BtnThemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TxtIdhd.Text = AutoIdhang("0");
            BtnThemSP.Enabled = true;
            BtnSua.Enabled = true;
            if(gridView1.DataRowCount>0)
            {
                BtnBoSP.Enabled = true;
            }           
            
            BtnIn.Enabled =CbHinhthuc.ReadOnly =true;
        }

        private void TxtIdsp_EditValueChanged(object sender, EventArgs e)
        {   
            try
            {
                string sql = "SELECT Tensp,Dvt,Giaxuat FROM SANPHAM WHERE Idsp = @Idsp";
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
                TxtGiaxuat.Text = dt1.Rows[0]["Giaxuat"].ToString().Trim();
                //Load dữ liệu lên từng textbox        
                con.Close();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hãy chọn mã sản phẩm!");
            }
        }

        private void LayIdsp()
        {
            string Layidsp = "SELECT Idsp FROM SANPHAM EXCEPT (SELECT Idsp FROM HOADON WHERE Idhd = @Idhd)";
            SqlCommand cmt1 = new SqlCommand(Layidsp, con)
            {
                CommandType = CommandType.Text
            };
            cmt1.Parameters.AddWithValue("Idhd", TxtIdhd.EditValue);
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

        private void TxtSoluong_KeyUp(object sender, KeyEventArgs e)
        {
            int a = Convert.ToInt32(TxtSoluong.EditValue);
            int b = Convert.ToInt32(TxtGiaxuat.EditValue);
            int c = a * b;
            TxtThanhtien.Text = c.ToString();
        }

        private void ThemSP_HD()
        {
            //sp_InsertPD
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertHD", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                add.Parameters.AddWithValue("Idhd", TxtIdhd.EditValue);
                add.Parameters.AddWithValue("Idsp", TxtIdsp.EditValue);
                add.Parameters.AddWithValue("Tenngdung","");
                if (CbHinhthuc.Text == "Lẻ")
                {
                    add.Parameters.AddWithValue("Idkh", "006");
                }
                else if (CbHinhthuc.Text=="Sỉ")
                {
                    add.Parameters.AddWithValue("Idkh", TxtIdkh.Text);
                } 
                add.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                add.Parameters.AddWithValue("Dvt", TxtDvt.EditValue);
                add.Parameters.AddWithValue("Soluong", TxtSoluong.EditValue);
                add.Parameters.AddWithValue("Giaxuat",TxtGiaxuat.EditValue);
                add.Parameters.AddWithValue("Thanhtien", TxtThanhtien.EditValue);
                add.Parameters.AddWithValue("Thoigian", TxtThoigian.EditValue);
                add.Parameters.AddWithValue("Hinhthuc", CbHinhthuc.EditValue); 
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

        private void XoaSP_HD()
        {
            //sp_DelPD
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_DelHD", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idhd", TxtIdhd.EditValue);
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

        private void SuaSP_HD()
        {
            try
            {
                string sql = "UPDATE HOADON SET Soluong = @Soluong,Giaxuat = @Giaxuat,Thanhtien=@Thanhtien WHERE Idhd = @Idhd and Idsp = (SELECT Idsp FROM SANPHAM WHERE Tensp = @Tensp)";
                SqlCommand cmt1 = new SqlCommand(sql, con)
                {
                    CommandType = CommandType.Text
                };
                cmt1.Parameters.AddWithValue("Idhd", TxtIdhd.EditValue);
                cmt1.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                cmt1.Parameters.AddWithValue("Soluong", TxtSoluong.EditValue);
                cmt1.Parameters.AddWithValue("Giaxuat", TxtGiaxuat.EditValue);
                cmt1.Parameters.AddWithValue("Thanhtien", TxtThanhtien.EditValue);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                SqlDataReader dr1 = cmt1.ExecuteReader();
                XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            catch (SqlException exc)
            {
                XtraMessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbHinhthuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbHinhthuc.EditValue == "Lẻ")
            {
                TxtIdkh.Text = "";
                layoutControlItem11.Enabled = false;
                TxtTenkh.Text = "Khách lẻ";
                TxtTenkh.ReadOnly = true;
            }
            if(CbHinhthuc.EditValue =="Sỉ")
            {
                layoutControlItem11.Enabled = true;
                TxtIdkh.Enabled = true;
                this.kHACHHANGTableAdapter.Fill(this.qLyVVPDataSetAll.KHACHHANG);
                TxtTenkh.Text = "";
            }
        }

        private void TxtIdkh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Tenkh FROM KHACHHANG WHERE Idkh= @Idkh";
                SqlCommand cmt1 = new SqlCommand(sql, con)
                {
                    CommandType = CommandType.Text
                };
                cmt1.Parameters.AddWithValue("Idkh", TxtIdkh.EditValue);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                SqlDataReader dr1 = cmt1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);//đổ dữ liệu vào kho                       
                TxtTenkh.Text = dt1.Rows[0]["Tenkh"].ToString().Trim();     
                con.Close();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hãy chọn mã khách hàng!");
            }
        }

        private void BtnBoSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaSP_HD();
            LayIdsp();
        }
        private void GiamSoluong()
        {   //sp_ThemSL
            string a;

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                a = gridView1.GetRowCellValue(i, "Idsp").ToString();

                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_GiamSL", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idsp", a);
                    cmt1.Parameters.AddWithValue("Idhd", TxtIdhd.EditValue);
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

        private void TxtSoluong_EditValueChanged(object sender, EventArgs e)
        {
            //int soluongban = Convert.ToInt32(TxtSoluong.Value);
            //string sql = "SELECT Soluong FROM SANPHAM WHERE Idsp = @Idsp";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("Idsp", TxtIdsp.Text);
            //con.Open();
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            //SqlDataReader dr1 = cmd.ExecuteReader();
            //DataTable dt1 = new DataTable();
            //dt1.Load(dr1);//đổ dữ liệu vào kho                       
            //string soluongsp = dt1.Rows[0]["Soluong"].ToString().Trim();
            //con.Close();
            //if(soluongban > Convert.ToInt32(soluongsp))
            //{
            //    XtraMessageBox.Show("Số lượng bán đã tối đa!");
            //    TxtSoluong.EditValue = soluongsp;
            //}
        }
    }
}