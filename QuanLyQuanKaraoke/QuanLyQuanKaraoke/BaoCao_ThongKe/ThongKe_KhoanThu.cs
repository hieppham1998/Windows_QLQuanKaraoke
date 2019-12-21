using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QuanLyQuanKaraoke.BaoCao_ThongKe
{
    public partial class ThongKe_KhoanThu : Form
    {
        public ThongKe_KhoanThu()
        {
            InitializeComponent();
        }

        int solanthaydoi = 0;

        private void cbb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                solanthaydoi++;
                if (solanthaydoi > 2)
                {
                    if (cbb_thang.SelectedIndex != 0)
                    {
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_Thu.DataSource = from hd in db.HoaDons
                                                 from nv in db.NhanViens
                                                 from kh in db.KhachHangs
                                                 from pt in db.PhuThus
                                                 where hd.GioBatDau.Value.Year == nbr_Nam.Value
                                                 where hd.GioBatDau.Value.Month == cbb_thang.SelectedIndex
                                                 where hd.MaNV == nv.MaNV
                                                 where hd.SDT_KhachHang == kh.SDT
                                                 where hd.MaPhuThu == pt.MaPhuThu
                                                 select new
                                                 {
                                                     Mã_Hóa_Đơn = hd.MaHD,
                                                     Tên_Khách_Hàng = kh.TenKH,
                                                     SĐT_Khách_Hàng = hd.SDT_KhachHang,
                                                     Mã_Phòng = hd.MaPhong,
                                                     Tên_Nhân_Viên = nv.TenNV,
                                                     Giờ_Bắt_Đầu = hd.GioBatDau,
                                                     Giờ_Kết_Thúc = hd.GioKetThuc,
                                                     Tên_Phụ_Thu = pt.TenPhuThu,
                                                     Tiền_Cọc = hd.TienCoc,
                                                     Tiền_Điền_Bù = hd.TienDenBu,
                                                     Khuyến_Mãi = hd.KhuyenMai,
                                                     Tổng_Tiền = hd.TongTien
                                                 };
                            vebieudo_Nam();
                            vebieudo_Thang();
                            load_label();
                        }
                    }
                    else
                    {
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_Thu.DataSource = from hd in db.HoaDons
                                                 from nv in db.NhanViens
                                                 from kh in db.KhachHangs
                                                 from pt in db.PhuThus
                                                 where hd.GioBatDau.Value.Year == nbr_Nam.Value
                                                 where hd.MaNV == nv.MaNV
                                                 where hd.SDT_KhachHang == kh.SDT
                                                 where hd.MaPhuThu == pt.MaPhuThu
                                                 select new
                                                 {
                                                     Mã_Hóa_Đơn = hd.MaHD,
                                                     Tên_Khách_Hàng = kh.TenKH,
                                                     SĐT_Khách_Hàng = hd.SDT_KhachHang,
                                                     Mã_Phòng = hd.MaPhong,
                                                     Tên_Nhân_Viên = nv.TenNV,
                                                     Giờ_Bắt_Đầu = hd.GioBatDau,
                                                     Giờ_Kết_Thúc = hd.GioKetThuc,
                                                     Tên_Phụ_Thu = pt.TenPhuThu,
                                                     Tiền_Cọc = hd.TienCoc,
                                                     Tiền_Điền_Bù = hd.TienDenBu,
                                                     Khuyến_Mãi = hd.KhuyenMai,
                                                     Tổng_Tiền = hd.TongTien
                                                 };
                            vebieudo_Nam();
                            load_label();
                        }
                    }

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void vebieudo_Nam()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(5);
                bieudo_nam.Value = i;
                bieudo_nam.Update();
            }
        }
        //tính tổng tiền của năm
        private double? Get_tongnam()
        {
            using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
            {
                double? tn = (from h in db.HoaDons
                                   where h.GioBatDau.Value.Year == nbr_Nam.Value
                                   select h.TongTien).Sum();
                return tn;
            }
        }
        //tính tổng tiền của tháng
        private double? Get_tongthang()
        {
            using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
            {
                double? tt = (from h in db.HoaDons
                                     where h.GioBatDau.Value.Year == nbr_Nam.Value
                                     where h.GioBatDau.Value.Month == cbb_thang.SelectedIndex
                                     select h.TongTien).Sum();
                return tt;
            }
        }

        private void load_label()
        {
            double? tongnam = Get_tongnam();
            double? tongthang = Get_tongthang();
            // giá trị tổng năm
            if (tongnam != null)
                lb_tongnam.Text = "Tổng :" + tongnam.ToString();
            else
                lb_tongnam.Text = "Tổng : 0";
            // giá trị tổng tháng
            if (tongthang != null)
            {
                double a = (double)tongthang * 100;
                double pt = a / (double)tongnam;
                lb_tongthang.Text = "Tổng :" + tongthang.ToString();
                lb_thang.Text = "Tháng: " + cbb_thang.SelectedIndex.ToString();
                string hienthi = string.Format("{0:0.0}", pt);
                lb_phantramthang.Text =  hienthi + "%";
            }
            else
            {
                lb_tongthang.Text = "Tổng : 0";
                lb_thang.Text = "Tháng: " + cbb_thang.SelectedIndex.ToString();
                lb_phantramthang.Text = "0%";
            }
        }

        private void vebieudo_Thang()
        {
            try
            {
                double? tongnam = Get_tongnam();
                double? tongthang = Get_tongthang();
                if(tongnam !=null && tongthang!= null)
                {
                    double a = (double)tongthang * 100;
                    double pt = a / (double)tongnam;
                    bieudo_thang.Minimum = 0;
                    bieudo_thang.Maximum = 100;
                    bieudo_thang.Value = 0;                    
                    for (int i = 0; i <= pt; i++)
                    {
                        Thread.Sleep(5);
                        bieudo_thang.Value = i;
                        bieudo_thang.Update();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ThongKe_KhoanThu_Load(object sender, EventArgs e)
        {
            DateTime ngayht = DateTime.Now;
            nbr_Nam.Value = ngayht.Year;
            cbb_thang.SelectedIndex = 0;
        }

        private void nbr_Nam_ValueChanged(object sender, EventArgs e)
        {
            solanthaydoi++;
            cbb_thang_SelectedIndexChanged(sender, e);
        }
        public void xuatExcel(DataGridView DataDV, string duongdan, string tenTep)
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
                xuatExcel(dgv_Thu, @"D:\QuanLyQuanKaraoke\", "Thống kê thu " + cbb_thang.SelectedIndex.ToString() + "-" + nbr_Nam.Value.ToString());
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
