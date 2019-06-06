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
    public partial class Loaisp : DevExpress.XtraEditors.XtraForm
    {
        public Loaisp()
        {
            InitializeComponent();
           
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtIdloaisp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idloaisp");
            TxtTenloaisp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tenloaisp");
        }
        private void LoadDL()
        {
             this.lOAISPTableAdapter.Fill(this.qLyVVPDataSetLoaiSP.LOAISP);
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
        private void ThemLoaiSP()
        {
            //sp_InsertLoaiSP
            try
            {
                SqlCommand add = new SqlCommand("sp_InsertLoaiSP", con)
                {
                    CommandType = CommandType.StoredProcedure
                }; 
                if (TxtTenloaisp.Text !="" && TxtIdloaisp.Text != "")
                {
                    add.Parameters.AddWithValue("Idloaisp", TxtIdloaisp.Text);
                    add.Parameters.AddWithValue("Tenloaisp", TxtTenloaisp.Text);
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
        private void Loaisp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetLoaiSP.LOAISP' table. You can move, or remove it, as needed.
            this.lOAISPTableAdapter.Fill(this.qLyVVPDataSetLoaiSP.LOAISP);
            con = new SqlConnection(conString);

        }
        
        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 1;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnSua.Enabled = false;
            TxtTenloaisp.Enabled = true;
            TxtIdloaisp.Text = AutoIdhang("0");
            TxtTenloaisp.Text = "";
            TxtTenloaisp.ReadOnly = false;
        }
        private void XoaLoaiSP()
        {
            if (MessageBox.Show("Có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelLoaiSP", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idloaisp", TxtIdloaisp.Text);
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
        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   

            XoaLoaiSP();
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
                        ThemLoaiSP();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnSua.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTenloaisp.ReadOnly = false;

                        stt = 0;
                    break;
                    }
                case 2:
                    {
                        SuaLoaiSP();
                        LoadDL();
                        BtnHuy.Enabled = false;
                        BtnXoa.Enabled = true;
                        BtnThem.Enabled = true;
                        TxtTenloaisp.ReadOnly = false;
                        stt = 0;
                    break;
                    }

                
            }
         
         
        

        }
        private void SuaLoaiSP()
        {          
            try
            {
                SqlCommand cmt1 = new SqlCommand("sp_UpdLoaiSP", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idloaisp", TxtIdloaisp.Text);
                cmt1.Parameters.AddWithValue("Tenloaisp", TxtTenloaisp.Text);
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
        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 2;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            TxtIdloaisp.Enabled = true;
            TxtTenloaisp.Enabled = true;

        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            BtnHuy.Enabled = false;
           
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            TxtTenloaisp.ReadOnly = true;

            LoadDL();

        }
    }
}