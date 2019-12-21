using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Data.SqlClient;
namespace QuanLyQuanKaraoke
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();       
        }
    
        private void DichVu_Load(object sender, EventArgs e)
        {
            kn.Open();
            txtTimKiem.Focus();
            string s="select * from dichvu";
            ketnoi.autoText(txtTimKiem, kn, s, "TenDichVu");
            // TODO: This line of code loads data into the 'dataQuanLy.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dataQuanLy.DichVu);
        }

        SqlConnection kn = Connection.GetDBConnection();
        Connection ketnoi = new Connection();

        private void xuly_Enable_DV(bool kieunhap, bool kieunut)
        {
            txtTenDV.Enabled = kieunhap;
            nbSoLuong.Enabled = kieunhap;
            txtDonGiaNhap.Enabled = kieunhap;
            txtDonGiaBan.Enabled = kieunhap;
            txtDVT.Enabled = kieunhap;            
            btnXuatEX.Enabled = kieunut;
            DataDV.Enabled = kieunut;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text=="Sửa")
            {
                xuly_Enable_DV(true, false);
                btnSua.Text = "Lưu";
                btnSua.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
            }
            else
            {
                if(KT_Rong())
                {
                xuly_Enable_DV(false, true);
                btnSua.Text = "Sửa";
                btnSua.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
                string sua = "update dichvu set tendichvu=N'"+txtTenDV.Text+"',soluong="+int.Parse(nbSoLuong.Value.ToString())+",dongianhap="+int.Parse(txtDonGiaNhap.Text)+",dongiaban="+int.Parse(txtDonGiaBan.Text)+",dvt=N'"+txtDVT.Text+"' where madv='"+txtMaDV.Text+"'";
                SqlCommand cmd = new SqlCommand(sua, kn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dichVuTableAdapter.Fill(this.dataQuanLy.DichVu);
                }
            }
        }

        private bool KT_Rong()
        {
            if (string.IsNullOrEmpty(this.txtTenDV.Text))
            {
                MessageBox.Show("Không được bỏ trống tên dịch vụ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenDV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDonGiaNhap.Text))
            {
                MessageBox.Show("Không được bỏ trống đơn giá nhập !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDonGiaNhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDonGiaBan.Text))
            {
                MessageBox.Show("Không được bỏ trống đơn giá bán !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDonGiaBan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDVT.Text))
            {
                MessageBox.Show("Không được bỏ trống đơn vị tính !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDVT.Focus();
                return false;
            }    
            return true;
        }

        public void xuatExcel(DataGridView DataDV,string duongdan,string tenTep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < DataDV.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = DataDV.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DataDV.Rows.Count; i++)
            {
                for (int j = 0; j < DataDV.Columns.Count; j++)
                {
                    if (DataDV.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = DataDV.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenTep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnXuatEX_Click(object sender, EventArgs e)
        {
            try
            {
                xuatExcel(DataDV, @"D:\QuanLyQuanKaraoke\", "Danh sách dịch vụ");
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                xuatExcel(DataDV, @"D:\", "Danh sách dịch vụ");
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                string kh = "select * from dichvu";
                SqlCommand cmd = new SqlCommand(kh, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                System.Data.DataTable table = new System.Data.DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                DataDV.DataSource = table;
            }
            else
            {                                
                string kh = "select*from dichvu where TenDichVu like N'%" + txtTimKiem .Text+ "%'";
                SqlCommand cmd = new SqlCommand(kh, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                System.Data.DataTable table = new System.Data.DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                DataDV.DataSource = table;
            }


        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
