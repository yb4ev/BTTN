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
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLyVVPDataSetAll.KHACHHANG);
            con = new SqlConnection(conString);
            TxtIdkh.Focus();
        }
        private void LoadDL()
        {
            this.kHACHHANGTableAdapter.Fill(this.qLyVVPDataSetAll.KHACHHANG);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtIdkh.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idkh");
            TxtTenkh.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tenkh");
            TxtDiachi.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Diachi");
            TxtSdt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Sdt");
        }
        private string AutoIdhang(string HT)
        {
            string Matusinh = "";
            int count = 0;
            count = gridView1.RowCount; //lấy số dòng của dgv.
            int chuoiSo = 0;
            string ChuoiId = Convert.ToString(count);
            chuoiSo = Convert.ToInt32(ChuoiId.Replace(HT, ""));
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
        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 1;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnSua.Enabled = false;
            TxtIdkh.Text = AutoIdhang("0");
            TxtTenkh.Text =  TxtDiachi.Text =  TxtSdt.Text = "";
            TxtTenkh.ReadOnly = TxtDiachi.ReadOnly = TxtSdt.ReadOnly = false;

        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 2;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            TxtTenkh.ReadOnly = TxtDiachi.ReadOnly = TxtSdt.ReadOnly = false;

        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaKH();
            LoadDL();
        }

        private void BtnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (stt)
            {
                case 0:
                    {
                        LoadDL();
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 1:
                    {
                        ThemKH();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnSua.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTenkh.ReadOnly = TxtDiachi.ReadOnly = TxtSdt.ReadOnly = true;

                        stt = 0;
                        break;
                    }
                case 2:
                    {
                        SuaKH();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTenkh.ReadOnly = TxtDiachi.ReadOnly = TxtSdt.ReadOnly = true;

                        stt = 0;
                        break;
                    }


            }
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            BtnHuy.Enabled = false;
            TxtTenkh.ReadOnly = TxtDiachi.ReadOnly = TxtSdt.ReadOnly = false;
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            LoadDL();
        }

        private void ThemKH()
        {
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertKH", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (TxtIdkh.Text != "" && TxtTenkh.Text != "")
                {
                    add.Parameters.AddWithValue("Idkh", TxtIdkh.Text);
                    add.Parameters.AddWithValue("Tenkh", TxtTenkh.Text);
                    add.Parameters.AddWithValue("Diachi", TxtDiachi.Text);
                    add.Parameters.AddWithValue("Sdt", TxtSdt.Text);
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

        private void SuaKH()
        {
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_UpdKH", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idkh", TxtIdkh.Text);
                cmt1.Parameters.AddWithValue("Tenkh", TxtTenkh.Text);
                cmt1.Parameters.AddWithValue("Diachi", TxtDiachi.Text);
                cmt1.Parameters.AddWithValue("Sdt", TxtSdt.Text);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                SqlDataReader dr1 = cmt1.ExecuteReader();

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            catch (SqlException exc)
            {
                MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaKH()
        {
            if (MessageBox.Show("Có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelKH", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idkh", TxtIdkh.Text);
                    con.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
                    SqlDataReader dr1 = cmt1.ExecuteReader();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}