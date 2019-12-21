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
    public partial class ThemDichVu : Form
    {
        public ThemDichVu()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();

        private void ThemDichVu_Load(object sender, EventArgs e)
        {
            kn.Open();
            // điền mã dịch vụ
            string demdong = "select count(*) from DichVu";
            SqlCommand cmd_demdong = new SqlCommand(demdong, kn);
            int count = (int)cmd_demdong.ExecuteScalar();
            count++;
            if (count < 10)
                txt_madvthem.Text = "DV00" + count.ToString();
            else
                if (count < 100)
                    txt_madvthem.Text = "DV0" + count.ToString();
                else
                    txt_madvthem.Text = "DV" + count.ToString();
        }

        private void btn_luudv_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string sql_themdv = "insert into DichVu (MaDV,TenDichVu,SoLuong, DVT) values('" + txt_madvthem.Text + "',N'" + txt_tendvthem.Text + "',0,N'" + txt_dvtthem.Text + "')";
                SqlCommand cmd_themdv = new SqlCommand(sql_themdv,kn);
                cmd_themdv.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ thành công !","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private bool KiemTraTrong()
        {
            if (string.IsNullOrEmpty(this.txt_tendvthem.Text))
            {
                MessageBox.Show("Không được bỏ trống tên dịch vụ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_tendvthem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_dvtthem.Text))
            {
                MessageBox.Show("Không được bỏ trống đơn vị tính nhỏ nhất !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dvtthem.Focus();
                return false;
            }
            return true;
        }

        private void ThemDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }
    }
}
