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
    public partial class NgDung : DevExpress.XtraEditors.XtraForm
    {
        public NgDung()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;
        private void NgDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.qLyVVPDataSetAll.NGUOIDUNG);
            con = new SqlConnection(conString);
        }
        private void LoadDL()
        {
            this.nGUOIDUNGTableAdapter.Fill(this.qLyVVPDataSetAll.NGUOIDUNG);
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
            TxtIdngdung.Text = AutoIdhang("0");
            TxtTendn.Text =  TxtChucvu.Text =  TxtTenngdung.Text = TxtMatkhau.Text = "";
            TxtTendn.ReadOnly = TxtChucvu.ReadOnly = TxtTenngdung.ReadOnly = TxtMatkhau.ReadOnly = false;



        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 2;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            TxtTendn.ReadOnly = TxtChucvu.ReadOnly = TxtTenngdung.ReadOnly = TxtMatkhau.ReadOnly = false;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaNgDung();
            LoadDL();
        }

        private void BtnCapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                        ThemNgDung();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnSua.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTendn.ReadOnly = TxtChucvu.ReadOnly = TxtTenngdung.ReadOnly = TxtMatkhau.ReadOnly = true;
                        stt = 0;
                        break;
                    }
                case 2:
                    {
                        SuaNgDung();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTendn.ReadOnly = TxtChucvu.ReadOnly = TxtTenngdung.ReadOnly = TxtMatkhau.ReadOnly = true;
                        stt = 0;
                        break;
                    }
            }
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            BtnHuy.Enabled = false;
           
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            TxtTendn.ReadOnly = TxtChucvu.ReadOnly = TxtTenngdung.ReadOnly = TxtMatkhau.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtIdngdung.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idngdung");
            TxtTenngdung.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tenngdung");
            TxtChucvu.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Chucvu");
            TxtTendn.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tendn");
            TxtMatkhau.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Matkhau");

        }

        private void ThemNgDung()
        {
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertNgDUng", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (TxtIdngdung.Text != "" && TxtTendn.Text != "")
                {
                    add.Parameters.AddWithValue("Idngdung", TxtIdngdung.Text);
                    add.Parameters.AddWithValue("Tenngdung", TxtTenngdung.Text);
                    add.Parameters.AddWithValue("Chucvu", TxtChucvu.Text);
                    add.Parameters.AddWithValue("Tendn", TxtTendn.Text);
                    add.Parameters.AddWithValue("Matkhau", TxtMatkhau.Text);
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                    return;
                }
                con.Open();
                add.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2671)
                {
                    MessageBox.Show("Mã đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("\tLỗi không xác định\n\tVui lòng ấn cập nhật\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void SuaNgDung()
        {
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_UpdNgDung", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idngdung", TxtIdngdung.Text);
                cmt1.Parameters.AddWithValue("Tenngdung", TxtTenngdung.Text);
                cmt1.Parameters.AddWithValue("Chucvu", TxtChucvu.Text);
                cmt1.Parameters.AddWithValue("Tendn", TxtTendn.Text);
                cmt1.Parameters.AddWithValue("Matkhau", TxtMatkhau.Text);
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

        private void XoaNgDung()
        {
            if (MessageBox.Show("Có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelNgDung", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idngdung",TxtIdngdung.Text);
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