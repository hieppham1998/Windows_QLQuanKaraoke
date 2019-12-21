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
using QuanLyQuanKaraoke.Phong_QLPhong;

namespace QuanLyQuanKaraoke
{
    public partial class frmThietBi : Form
    {
        LINQDataContext _Linq = new LINQDataContext();
        public frmThietBi()
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
        public void LayDSThietBi() {
            var ThietBi = from tb in _Linq.ThietBis select tb;
            dataThietBi.DataSource = ThietBi;
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            LayDSThietBi();
            binding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThietBi _ThietBi = _Linq.ThietBis.Where(kh => kh.MaThietBi ==
                            dataThietBi.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
            if (_ThietBi != null)
            {
                _ThietBi.TenThietBi = txtTenTB.Text;
                _ThietBi.SoLuong = int.Parse(txtSL.Text);                
                _Linq.SubmitChanges();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                if (txtTK.Text.Length != 0)
                {
                    string tk = "select * from thietbi where tenthietbi like N'%" + txtTK.Text + "%'";
                    SqlCommand cmd = new SqlCommand(tk, conn);

                    SqlDataAdapter com = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                    com.Fill(table);// đổ dữ liệu vào bảng ảo
                    dataThietBi.DataSource = table;
                }
                if (txtTK.Text.Length == 0)
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

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void binding()
        {
            int i = dataThietBi.CurrentRow.Index;
            txtMaTB.Text = dataThietBi.Rows[i].Cells[0].Value.ToString();
            txtTenTB.Text = dataThietBi.Rows[i].Cells[1].Value.ToString();
            txtSL.Text = dataThietBi.Rows[i].Cells[2].Value.ToString();
        }
       
    }
}
