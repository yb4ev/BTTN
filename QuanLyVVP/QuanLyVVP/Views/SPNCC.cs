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
using DevExpress.DataProcessing;

namespace QuanLyVVP.Views
{
    public partial class SPNCC : DevExpress.XtraEditors.XtraForm
    {
        public SPNCC()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string conString = ConfigurationManager.ConnectionStrings["QuanLyVVP"].ConnectionString.ToString();
        //stt = 0 : mặc định
        //stt = 1 : thêm 
        //stt = 2 : sửa
        int stt = 0;
        private void SPNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLyVVPDataSetAll.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.qLyVVPDataSetAll.NCC);
            con = new SqlConnection(conString);
        }
        
        private void LoadDL()
        {
            SqlCommand cmt = new SqlCommand("sp_ShowSPNCC", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt.Parameters.AddWithValue("Tenncc", TxtTenncc.Text);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmt);//chuyển dữ liệu về
            SqlDataReader dr = cmt.ExecuteReader();
            DataTable dt = new DataTable();  //tạo kho  ảo để lưu dữ liệu
            dt.Load(dr);//đổ dữ liệu vào kho
            gridControl1.DataSource = dt;//Load dữ liệu lên
            con.Close();
        }

        private void TxtTenncc_Properties_EditValueChanged(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtMasp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Idsp");
            TxtGiacc.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Giacc");
            TxtDvt.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dvt");
            TxtTensp.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tensp");

        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 1;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnSua.Enabled = false;
            TxtGiacc.ReadOnly = false;
            TxtGiacc.Text = "";
            TxtMasp.Text = TxtTensp.Text = TxtDvt.Text = "";

            LayIdsp();


        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 2;
            BtnXoa.Enabled = false;
            BtnHuy.Enabled = true;
            BtnThem.Enabled = false;
            TxtGiacc.ReadOnly = false;

            //TxtIdloaisp.Enabled = true;
            //TxtTenloaisp.Enabled = true;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XoaSPNCC();
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
                        ThemSPNCC();
                        LoadDL();
                      
                        stt = 0;
                        break;
                    }
                case 2:
                    {
                        SuaSPNCC();
                        LoadDL();
                        
                        stt = 0;
                        break;
                    }


            }
        }

        private void BtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stt = 0;
            BtnHuy.Enabled = false;
            //TxtIdloaisp.Enabled = false;
            //TxtTenloaisp.Enabled = false;
            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            TxtGiacc.ReadOnly = true;
        }
        private void ThemSPNCC()
        {
          
            try
            {
                BtnHuy.Enabled = false;
                BtnXoa.Enabled = true;
                BtnSua.Enabled = true;
                BtnThem.Enabled = true;
                TxtGiacc.ReadOnly = true;
                SqlCommand add = new SqlCommand("sp_InsertSPNCC", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (TxtGiacc.Text != "" && TxtMasp.Text != "")
                {
                    add.Parameters.AddWithValue("Idncc", TxtTenncc.EditValue);
                    add.Parameters.AddWithValue("Idsp", TxtMasp.Text);
                    add.Parameters.AddWithValue("Giacc", TxtGiacc.Text);
                    
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
        private void SuaSPNCC()
        {
            
            try
            {
                BtnHuy.Enabled = false;
                BtnXoa.Enabled = true;
                BtnThem.Enabled = true;
                TxtGiacc.ReadOnly = true;
                SqlCommand cmt1 = new SqlCommand("sp_UpdSPNCC", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmt1.Parameters.AddWithValue("Idncc", TxtTenncc.EditValue);
                cmt1.Parameters.AddWithValue("Idsp", TxtMasp.Text);
                cmt1.Parameters.AddWithValue("Giacc", TxtGiacc.Text);
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
        private void XoaSPNCC()
        {
            //sp_DelSPNCC
            if (MessageBox.Show("Có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                try
                {
                    SqlCommand cmt1 = new SqlCommand("sp_DelSPNCC", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmt1.Parameters.AddWithValue("Idncc", TxtTenncc.EditValue);
                    cmt1.Parameters.AddWithValue("Idsp", TxtMasp.Text);

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

        private void LayIdsp()
        {
            SqlCommand cmt1 = new SqlCommand("sp_PickIdspNCC", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmt1.Parameters.AddWithValue("Idncc", TxtTenncc.EditValue);       
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(cmt1);
            SqlDataReader dr1 = cmt1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);//đổ dữ liệu vào kho           
            TxtMasp.Properties.DataSource = dt1;
            TxtMasp.Properties.DisplayMember = "Idsp";
            TxtMasp.Properties.ValueMember = "Idsp";
            con.Close();
        }
    
        private void BtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            XtraReportBaoGia report = new XtraReportBaoGia();
            report.Parameters["parameter1"].Value = TxtTenncc.Text;
           
            
            report.ShowRibbonPreviewDialog();
        }

        private void TxtTenncc_EditValueChanged(object sender, EventArgs e)
        {
            BtnIn.Enabled = true;
            BtnThem.Enabled = BtnSua.Enabled = BtnXoa.Enabled = BtnCapnhat.Enabled = true;
        }
    }
}