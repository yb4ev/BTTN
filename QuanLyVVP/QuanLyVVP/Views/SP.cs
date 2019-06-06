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
    public partial class SP : DevExpress.XtraEditors.XtraForm
    {
        public SP()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;
        private void SP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.LOAISP' table. You can move, or remove it, as needed.
            this.lOAISPTableAdapter.Fill(this.qLyVVPDataSetAll.LOAISP);
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLyVVPDataSetAll.SANPHAM);
            con = new SqlConnection(conString);
        }
        private void LoadDL()
        {
            this.sANPHAMTableAdapter.Fill(this.qLyVVPDataSetAll.SANPHAM);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtIdsp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idsp");
            TxtTensp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tensp");
            CbIdloaisp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idloaisp");
            TxtDvt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dvt");
            TxtSoluong.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Soluong");
            TxtGianhap.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Gianhap");
            TxtGiaxuat.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Giaxuat");
        }
        private string AutoIdhang(string HT)
        {
            string Matusinh = "";
            int count = 0;            
            count = gridView1.DataRowCount; //lấy số dòng của dgv.
            //Matusinh = (count+1).ToString();
            int chuoiSo = 0;
            string ChuoiId = Convert.ToString(count);
            chuoiSo = Convert.ToInt32(ChuoiId.Replace(HT, ""));
            if (chuoiSo + 1 < 10)
            {
                Matusinh = HT + "0" + (chuoiSo + 1).ToString();
            }
            else if (chuoiSo + 1 > 100)
            {
                Matusinh = HT + "" + (chuoiSo + 1).ToString();
            }
            else if(chuoiSo+1<1000)
            {
                Matusinh = (count+1).ToString();
            }

            return Matusinh;
        }
        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 1;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnSua.Enabled = false;
            TxtIdsp.Text = AutoIdhang("0");
            TxtTensp.Text =  TxtSoluong.Text =  TxtGiaxuat.Text =  TxtDvt.Text =  CbIdloaisp.Text = TxtGianhap.Text = "";
            TxtTensp.ReadOnly =  CbIdloaisp.ReadOnly = TxtSoluong.ReadOnly = TxtGianhap.ReadOnly = TxtGiaxuat.ReadOnly = TxtDvt.ReadOnly=false;
        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            stt = 2;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            TxtDvt.ReadOnly = TxtTensp.ReadOnly = CbIdloaisp.ReadOnly = TxtSoluong.ReadOnly = TxtGianhap.ReadOnly = TxtGiaxuat.ReadOnly = false;

            //TxtIdloaisp.Enabled = true;
            //TxtTenloaisp.Enabled = true;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaSP();
            LoadDL();
        }

        private void BtnCapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (stt)
            {
                case 0:
                    {
                        LoadDL();
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 1:
                    {
                        ThemSP();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnSua.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtDvt.ReadOnly = TxtTensp.ReadOnly = CbIdloaisp.ReadOnly = TxtSoluong.ReadOnly = TxtGianhap.ReadOnly = TxtGiaxuat.ReadOnly = true;

                        stt = 0;
                        break;
                    }
                case 2:
                    {
                        SuaSP();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtDvt.ReadOnly = TxtTensp.ReadOnly = CbIdloaisp.ReadOnly = TxtSoluong.ReadOnly = TxtGianhap.ReadOnly = TxtGiaxuat.ReadOnly = true;

                        stt = 0;
                        break;
                    }


            }
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            LoadDL();
            BtnHuy.Enabled = false;
           
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            TxtDvt.ReadOnly = TxtTensp.ReadOnly = CbIdloaisp.ReadOnly = TxtSoluong.ReadOnly = TxtGianhap.ReadOnly = TxtGiaxuat.ReadOnly = true;

        }

        private void ThemSP()
        {
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertSP", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (TxtIdsp.Text != "" && CbIdloaisp.Text != "")
                {
                    add.Parameters.AddWithValue("Idloaisp", CbIdloaisp.Text);
                    add.Parameters.AddWithValue("Idsp", TxtIdsp.Text);
                    add.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                    add.Parameters.AddWithValue("Dvt", TxtDvt.Text);
                    add.Parameters.AddWithValue("Soluong", TxtSoluong.EditValue);
                    add.Parameters.AddWithValue("Gianhap", TxtGianhap.EditValue);
                    add.Parameters.AddWithValue("Giaxuat", TxtGiaxuat.EditValue);
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                    return;
                }
                con.Open();
                add.ExecuteNonQuery();
                MessageBox.Show("Thêm hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2671)
                {
                    MessageBox.Show("Mã hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("\tLỗi không xác định\n\tVui lòng ấn cập nhật\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
        private void SuaSP()
        {
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_UpdSP", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idloaisp", CbIdloaisp.Text);
                cmt1.Parameters.AddWithValue("Idsp", TxtIdsp.Text);
                cmt1.Parameters.AddWithValue("Tensp", TxtTensp.Text);
                cmt1.Parameters.AddWithValue("Dvt", TxtDvt.Text);
                cmt1.Parameters.AddWithValue("Soluong", TxtSoluong.EditValue);
                cmt1.Parameters.AddWithValue("Gianhap", TxtGianhap.EditValue);
                cmt1.Parameters.AddWithValue("Giaxuat", TxtGiaxuat.EditValue);
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
        private void XoaSP()
        {
            if (XtraMessageBox.Show("Có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelSP", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idsp", TxtIdsp.Text);
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                    SqlDataReader dr1 = cmt1.ExecuteReader();
                    XtraMessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                }
                catch (SqlException exc)
                {
                    XtraMessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}