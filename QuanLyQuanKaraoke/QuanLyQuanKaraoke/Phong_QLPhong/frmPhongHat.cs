using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyQuanKaraoke
{
    public partial class frmPhongHat : Form
    {
        public frmPhongHat()
        {
            InitializeComponent();
            autoText();
        }
        void autoText()
        {
            txtTK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTK.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                string s = "select * from thietbi";
                SqlCommand cmd = new SqlCommand(s, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //String ten = rd.GetString("TENKH");
                    coll.Add(rd["tenthietbi"].ToString());
                }
                txtTK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTK.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTK.AutoCompleteCustomSource = coll;

            }
            catch { MessageBox.Show("Lỗi"); }

        }
        private void frmPhongHat_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dataQuanLy.ThietBi_Phong' table. You can move, or remove it, as needed.
                this.thietBi_PhongTableAdapter.Fill(this.dataQuanLy.ThietBi_Phong);
                // TODO: This line of code loads data into the 'dataQuanLy.ThietBi' table. You can move, or remove it, as needed.
                this.thietBiTableAdapter.Fill(this.dataQuanLy.ThietBi);
                //cbbPhong.Items.Add("Tất cả");
                // TODO: This line of code loads data into the 'dataQuanLy.Phong' table. You can move, or remove it, as needed.
                this.phongTableAdapter.Fill(this.dataQuanLy.Phong);
                // TODO: This line of code loads data into the 'dataQuanLy.ThietBiP' table. You can move, or remove it, as needed.
                // this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP,);
                this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP, cbbPhong.SelectedValue.ToString());
                cbbPhong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP, cbbPhong.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = dataThietBi.CurrentCell.RowIndex;
            string ktrama = "select count(*) from thietbi_phong where mathietbi='" + dataThietBi.Rows[i].Cells[0].Value.ToString() + "' and maphong='" + cbbPhong.SelectedValue.ToString()+"'";
             SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(ktrama, conn);
                int j = (int)cmd.ExecuteScalar();
                if (j < 1)
                {
                    this.thietBi_PhongTableAdapter.Insert(cbbPhong.SelectedValue.ToString(), dataThietBi.Rows[i].Cells[0].Value.ToString(), 1);
                    this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP, cbbPhong.SelectedValue.ToString());                    
                }
                else
                {
                    string update = "update thietbi_phong set soluong=soluong+1 where maphong='"+cbbPhong.SelectedValue.ToString()+"' and mathietbi='"+dataThietBi.Rows[i].Cells[0].Value.ToString()+"'";
                    SqlCommand cmd1 = new SqlCommand(update, conn);
                    cmd1.ExecuteNonQuery();
                    this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP, cbbPhong.SelectedValue.ToString());                    
                }
                string updateTB = "update thietbi set soluong=soluong-1 where mathietbi='" + dataThietBi.Rows[i].Cells[0].Value.ToString() + "'";
                SqlCommand cmd_Up = new SqlCommand(updateTB, conn);
                cmd_Up.ExecuteNonQuery();
                this.thietBiTableAdapter.Fill(this.dataQuanLy.ThietBi);
        }

        public delegate void delPassData(String text);

        private void btnXoa_Click(object sender, EventArgs e)
        {
           int i = dataTBPhong.CurrentCell.RowIndex;
           string maphong = dataTBPhong.Rows[i].Cells[1].Value.ToString();
           string matb = dataTBPhong.Rows[i].Cells[0].Value.ToString();
           string sl = dataTBPhong.Rows[i].Cells[3].Value.ToString();
            SoLuongTB tb = new SoLuongTB(maphong,matb,sl);
            tb.ShowDialog();
            this.thietBiTableAdapter.Fill(this.dataQuanLy.ThietBi);
            this.thietBiPTableAdapter.Fill(this.dataQuanLy.ThietBiP, cbbPhong.SelectedValue.ToString());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                if (txtTK.Text.Length!=0)
                {                  
                    string tk = "select * from thietbi where tenthietbi like N'%" + txtTK.Text + "%'";
                    SqlCommand cmd = new SqlCommand(tk, conn);

                    SqlDataAdapter com = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                    com.Fill(table);// đổ dữ liệu vào bảng ảo
                    dataThietBi.DataSource = table;
                }
                if(txtTK.Text.Length==0)
                {
                    string tk = "select * from thietbi";
                    SqlCommand cmd = new SqlCommand(tk, conn);

                    SqlDataAdapter com = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                    com.Fill(table);// đổ dữ liệu vào bảng ảo
                    dataThietBi.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Giá trị bạn nhập chưa chính xác");
            }

        }

      
    }
}
