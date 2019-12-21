using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanKaraoke.QL_TaiKhoan_PhanQuyen;
using QuanLyQuanKaraoke.QL_NhanVien_KhachHang;
using QuanLyQuanKaraoke.BaoCao_ThongKe;

namespace QuanLyQuanKaraoke
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //QuanLyQuanKaraoke.Properties.Settings.Default.strString=@"Data Source=desktop-6kep9gd\sqlexpress;Initial Catalog=QuanLyQuanKaraoke;Integrated Security=True";

            try
            {
                SqlConnection kn = new SqlConnection(Properties.Settings.Default.strString);
                kn.Open();
                kn.Close();
                Application.Run(new DangNhap());
            }
            catch
            {
                Application.Run(new TaoKetNoi());
            }
        }
    }
}
