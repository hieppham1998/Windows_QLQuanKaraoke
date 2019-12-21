using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_DangNhap;
using System.Data.SqlClient;

namespace QuanLyQuanKaraoke.QL_TaiKhoan_PhanQuyen
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Control_dangnhap.get_TenDangNhap;
            kn.Open();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt_trong())
                {
                    if (txtMKmoi.Text == txtNhapLai.Text)
                    {
                        string sql_kt = "select * from QL_TaiKhoan where TenDangNhap='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "'";
                        SqlCommand cmd_kt = new SqlCommand(sql_kt, kn);
                        SqlDataReader doc = cmd_kt.ExecuteReader();
                        if (doc.Read())
                        {
                            doc.Close();
                            string sql_UD = "update QL_TaiKhoan set MatKhau='" + txtMKmoi.Text + "' where TenDangNhap='" + txtTenDangNhap.Text + "'";
                            SqlCommand cmd_UD = new SqlCommand(sql_UD, kn);
                            cmd_UD.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            doc.Close();
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu mới và phần nhập lại không khớp !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtMatKhau.Clear();
                    txtMKmoi.Clear();
                    txtNhapLai.Clear();
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool kt_trong()
        {
            if (string.IsNullOrEmpty(this.txtTenDangNhap.Text))
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMatKhau.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtMKmoi.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMKmoi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNhapLai.Text))
            {
                MessageBox.Show("Không được bỏ trống nhập lại mật khẩu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNhapLai.Focus();
                return false;
            }
            return true;
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }
    }
}
