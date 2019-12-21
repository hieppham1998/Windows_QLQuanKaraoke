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
namespace QuanLyQuanKaraoke.BaoCao_ThongKe
{
    public partial class ChiTietPhieuNhap : Form
    {
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        string LoaiPhieu;

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            cbb_loaiHT.SelectedIndex = 0;
            cbb_thang.SelectedIndex = 0;
            DateTime ngayht = DateTime.Now;
            nbr_Nam.Value = ngayht.Year;           
        }

        private void cbb_loaiHT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loaiHT.SelectedIndex == 1)
                LoaiPhieu = "DV";
            else
                if (cbb_loaiHT.SelectedIndex == 2)
                    LoaiPhieu = "TB";
                else LoaiPhieu = null;
            cbb_thang_SelectedIndexChanged(sender, e);
        }

        private void cbb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //phiếu nhập dịch vụ hoặc phiếu nhập thiết bị
                if (cbb_loaiHT.SelectedIndex == 1 || cbb_loaiHT.SelectedIndex == 2)
                {
                    if (cbb_thang.SelectedIndex != 0)
                    {
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_PhieuNhap.DataSource = from pndv in db.PhieuNhaps
                                                       from nv in db.NhanViens
                                                       where pndv.MaNhanVien == nv.MaNV
                                                       where pndv.MaPhieNhap.Substring(0, 2) == LoaiPhieu
                                                       where pndv.NgayNhap.Value.Year == nbr_Nam.Value
                                                       where pndv.NgayNhap.Value.Month == cbb_thang.SelectedIndex
                                                       select new
                                                       {
                                                           Mã_Phiếu_Nhập_Dịch_Vụ = pndv.MaPhieNhap,
                                                           Mã_Nhân_Viên = pndv.MaNhanVien,
                                                           Tên_Nhân_Viên = nv.TenNV,
                                                           Ngày_Nhập = pndv.NgayNhap,
                                                           Tổng_Phiếu_Nhập = pndv.TongPN
                                                       };
                        }
                    }
                    else
                    {
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_PhieuNhap.DataSource = from pndv in db.PhieuNhaps
                                                       from nv in db.NhanViens
                                                       where pndv.MaNhanVien == nv.MaNV
                                                       where pndv.MaPhieNhap.Substring(0, 2) == LoaiPhieu
                                                       where pndv.NgayNhap.Value.Year == nbr_Nam.Value
                                                       select new
                                                       {
                                                           Mã_Phiếu_Nhập_Dịch_Vụ = pndv.MaPhieNhap,
                                                           Mã_Nhân_Viên = pndv.MaNhanVien,
                                                           Tên_Nhân_Viên = nv.TenNV,
                                                           Ngày_Nhập = pndv.NgayNhap,
                                                           Tổng_Phiếu_Nhập = pndv.TongPN
                                                       };
                        }
                    }
                }
                else
                {
                    // phiếu thu
                    if (cbb_thang.SelectedIndex != 0)
                    {
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_PhieuNhap.DataSource = from hd in db.HoaDons
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
                        }
                    }
                    else
                    {                        
                        using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                        {
                            dgv_PhieuNhap.DataSource = from hd in db.HoaDons
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
                        }
                    }
                }
                

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void nbr_Nam_ValueChanged(object sender, EventArgs e)
        {
            cbb_thang_SelectedIndexChanged(sender, e);
        }

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // phiếu thu
            if (cbb_loaiHT.SelectedIndex == 0)
            {
                using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                {
                    int vt = dgv_PhieuNhap.CurrentCell.RowIndex;
                    dgv_ChiTiet.DataSource = from cthd in db.ChiTietHoaDons
                                             from dv in db.DichVus
                                             where cthd.MaDV == dv.MaDV
                                             where cthd.MaHD == dgv_PhieuNhap.Rows[vt].Cells[0].Value.ToString()
                                             select new
                                             {
                                                 Mã_Hóa_Đơn = cthd.MaHD,
                                                 Mã_Dịch_Vụ = cthd.MaDV,
                                                 Tên_Dịch_Vụ = dv.TenDichVu,
                                                 Số_Lượng = cthd.SoLuong,
                                                 Đơn_Giá = cthd.DonGia,
                                                 Đơn_Vị_Tính = cthd.DVT,
                                                 Thành_Tiền = cthd.ThanhTien
                                             };
                }
            }
            else
            {
                using (LinQ_BaoCaoThongKeDataContext db = new LinQ_BaoCaoThongKeDataContext())
                {
                    if (cbb_loaiHT.SelectedIndex == 1)
                    {
                        int vt = dgv_PhieuNhap.CurrentCell.RowIndex;
                        dgv_ChiTiet.DataSource = from nhapdv in db.CTPN_DichVus
                                                 from dv in db.DichVus
                                                 where nhapdv.MaDichVu == dv.MaDV
                                                 where nhapdv.MaPN_DichVu == dgv_PhieuNhap.Rows[vt].Cells[0].Value.ToString()
                                                 select new
                                                 {
                                                     Mã_Phiếu_Nhập_Dịch_Vụ = nhapdv.MaPN_DichVu,
                                                     Mã_Dịch_Vụ = nhapdv.MaDichVu,
                                                     Tên_Dịch_Vụ = dv.TenDichVu,
                                                     Số_Lượng_Nhập = nhapdv.SL_DichVuNhap,
                                                     Đơn_Giá_Nhập = nhapdv.DG_DichVuNhap,
                                                     Đơn_Vị_Tính = nhapdv.DVT_DichVuNhap,
                                                 };
                    }
                    else
                    {
                        int vt = dgv_PhieuNhap.CurrentCell.RowIndex;
                        dgv_ChiTiet.DataSource = from nhaptb in db.CTPN_ThietBis
                                                 from tb in db.ThietBis
                                                 where nhaptb.MaTB == tb.MaThietBi
                                                 where nhaptb.MaPN_ThietBi == dgv_PhieuNhap.Rows[vt].Cells[0].Value.ToString()
                                                 select new
                                                 {
                                                     Mã_Phiếu_Nhập_Thiết_Bị = nhaptb.MaPN_ThietBi,
                                                     Mã_Thiết_Bị = nhaptb.MaTB,
                                                     Tên_Thiết_Bị = tb.TenThietBi,
                                                     Số_Lượng_Nhập = nhaptb.SL_ThietBiNhap,
                                                     Đơn_Giá_Nhập = nhaptb.DG_ThietBiNhap,
                                                 };
                    }
                }
            }
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
                xuatExcel(dgv_ChiTiet, @"D:\QuanLyQuanKaraoke\", "Chi tiết phiếu nhập " + dgv_ChiTiet.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                xuatExcel(dgv_ChiTiet, @"D:\", "Chi tiết phiếu nhập " + dgv_ChiTiet.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //=======================================
    }
}
