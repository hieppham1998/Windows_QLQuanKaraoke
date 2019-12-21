using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    public partial class ThemThietBi : Form
    {
        public ThemThietBi()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();

        private void btn_luutb_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string sql_themdv = "insert into ThietBi(MaThietBi,TenThietBi, SoLuong) values('" + txt_matbthem.Text + "',N'" + txt_tentbthem .Text+ "',0)";
                SqlCommand cmd_themdv = new SqlCommand(sql_themdv, kn);
                cmd_themdv.ExecuteNonQuery();
                MessageBox.Show("Thêm thiết bị thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemThietBi_Load(object sender, EventArgs e)
        {
            kn.Open();
            // điền mã thiết bị
            string demdong = "select count(*) from ThietBi";
            SqlCommand cmd_demdong = new SqlCommand(demdong, kn);
            int count = (int)cmd_demdong.ExecuteScalar();
            count++;
            if (count < 10)
                txt_matbthem.Text = "TB0" + count.ToString();
            else
                txt_matbthem.Text = "TB" + count.ToString();
        }

        private bool KiemTraTrong()
        {
            if (string.IsNullOrEmpty(this.txt_tentbthem.Text))
            {
                MessageBox.Show("Không được bỏ trống tên thiết bị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_tentbthem.Focus();
                return false;
            }
            return true;
        }

        private void ThemThietBi_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }


    }
}
