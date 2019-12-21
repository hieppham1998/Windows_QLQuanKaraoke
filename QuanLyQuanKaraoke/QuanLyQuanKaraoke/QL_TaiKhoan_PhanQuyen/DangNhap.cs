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
using Control_DangNhap;

namespace QuanLyQuanKaraoke
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.strString);
            Control_dangnhap.ketnoisql = conn;
            Control_dangnhap.tenbang = "QL_TaiKhoan";
            Control_dangnhap.txt1 = "tendangnhap";
            Control_dangnhap.txt2 = "matkhau";
            Control_dangnhap.CotTinhTrang = 3;
            Control_dangnhap.GiaTriCotTinhTrang = "True";
            Control_dangnhap.form_Dong = this;
            FormMain fmm = new FormMain();
            Control_dangnhap.form_DuocMo = fmm;    
        }
    }
}
