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
using Control_DangNhap;
using QuanLyQuanKaraoke.QL_TaiKhoan_PhanQuyen;
using QuanLyQuanKaraoke.QL_NhanVien_KhachHang;
using QuanLyQuanKaraoke.BaoCao_ThongKe;
using QuanLyQuanKaraoke.Phong_QLPhong;

namespace QuanLyQuanKaraoke
{
    public partial class FormMain : Form
    { 
        public FormMain()
        {
            InitializeComponent();
        }

        string maphong;
        //string tinhtrang;

        SqlConnection kn = Connection.GetDBConnection();
        Button btnChon;

        public void capnhatphong()
        {
            string ktra_dat1 = "select DISTINCT datphong.maphong from phong, datphong where phong.maphong=datphong.maphong and year(GioNhanPhong)!=YEAR(getdate()) or MONTH(gionhanphong)!=month(getdate()) or day(GioNhanPhong)!=day(GETDATE())";
            SqlCommand cmd11 = new SqlCommand(ktra_dat1, kn);
            SqlDataAdapter com1 = new SqlDataAdapter(cmd11);
            DataTable table1 = new DataTable();//tạo bảng ảo trong hệ thống
            com1.Fill(table1);// đổ dữ liệu vào bảng ảo
            foreach (DataRow row1 in table1.Rows)
            {
                string cm_phong1 = "update phong set tinhtrang =N'Trống' where maphong ='" + row1[0] + "'";
                SqlCommand cnPhong1 = new SqlCommand(cm_phong1, kn);
                cnPhong1.ExecuteNonQuery();
            }
            string ktra_dat = "select datphong.maphong from phong, datphong where phong.maphong=datphong.maphong and year(GioNhanPhong)=YEAR(getdate()) and MONTH(gionhanphong)=month(getdate()) and day(GioNhanPhong)=day(GETDATE())";
            SqlCommand cmd1 = new SqlCommand(ktra_dat, kn);
            SqlDataAdapter com = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
            com.Fill(table);// đổ dữ liệu vào bảng ảo

            foreach (DataRow row in table.Rows)
            {
                //kiểm tra phòng có trong hóa đơn tạm chưa nếu chưa có thì trạng thái đã đặt, nếu có chuyển sang tình trạng đang hát
                string ktra_phong = "select*from hoadon_tam where maphong='" + row[0] + "'";
                SqlCommand com_Ktra = new SqlCommand(ktra_phong, kn);
                SqlDataReader dr = com_Ktra.ExecuteReader();
                if (!dr.Read())
                {
                    dr.Close();
                    string cm_phong = "update phong set tinhtrang =N'Đã Đặt' where maphong ='" + row[0] + "'";
                    SqlCommand cnPhong = new SqlCommand(cm_phong, kn);
                    cnPhong.ExecuteNonQuery();
                }
                else
                {
                    dr.Close();
                    string cm_phong_hat = "update phong set tinhtrang =N'Đang Hát' where maphong ='" + row[0] + "'";
                    SqlCommand cnPhong_hat = new SqlCommand(cm_phong_hat, kn);
                    cnPhong_hat.ExecuteNonQuery();
                }
            }
        }

        private void CapNhat_TinhTrangPhong()
        {
            int slPHat = 0, slpDon = 0, slPBaoTri = 0, slpTrong = 0, slDat = 0;
            //--------------------------
            string sql_phong = "select * from phong";
            SqlCommand cmd1 = new SqlCommand(sql_phong, kn);
            SqlDataAdapter com = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
            com.Fill(table);// đổ dữ liệu vào bảng ảo
            foreach (DataRow row in table.Rows)
            {
                // cập nhật màu Button
                foreach (Button btn in pn_show.Controls.OfType<Button>())
                {
                    if (btn.Name.ToString() == row[0].ToString())
                    {
                        if (row[3].ToString() == "Đang Dọn")
                        {
                            btn.BackColor = System.Drawing.Color.Orange;
                            slpDon++;
                        }
                        else
                            if (row[3].ToString() == "Đang Hát")
                            {
                                btn.BackColor = System.Drawing.Color.Red;
                                slPHat++;
                            }
                            else
                                if (row[3].ToString() == "Bảo Trì")
                                {
                                    btn.BackColor = System.Drawing.Color.Brown;
                                    slPBaoTri++;
                                }
                                else
                                    if (row[3].ToString() == "Đã Đặt")
                                    {
                                        btn.BackColor = System.Drawing.Color.Blue;
                                        slDat++;
                                    }
                                    else
                                    {
                                        btn.BackColor = System.Drawing.Color.Green;
                                        slpTrong++;
                                    }
                        // cập nhật trạng thái Label
                        foreach (Label lb in pn_show.Controls.OfType<Label>())
                        {
                            if (lb.Name.ToString() == "lb"+row[0].ToString())
                            {
                                if (row[3].ToString() == "Đang Dọn")
                                    lb.Text = "Đang Dọn";
                                else
                                    if (row[3].ToString() == "Đang Hát")
                                        lb.Text = "Đang Hát";
                                    else
                                        if (row[3].ToString() == "Bảo Trì")
                                            lb.Text = "Bảo Trì";
                                        else
                                            if (row[3].ToString() == "Đã Đặt")
                                                lb.Text = "Đã Đặt";
                                            else
                                                lb.Text = "Trống";

                            }
                        }
                    }
                }
                btnTrong.Text = "Phòng trống: " + slpTrong.ToString();
                btnBaoTri.Text = "Bảo trì: " + slPBaoTri.ToString();
                btnDangDon.Text = "Đang dọn: " + slpDon.ToString();
                btnDangHat.Text = "Đang hát: " + slPHat.ToString();
                btnDaDat.Text = "Đã đặt: " + slDat.ToString();
            }
        }

        public void load_phong(string sql_phong) 
        {
            int i = 0;
            int j = 0;
            //--------------------------
            SqlCommand cmd1 = new SqlCommand(sql_phong, kn);
            SqlDataAdapter com = new SqlDataAdapter(cmd1);
            DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
            com.Fill(table);// đổ dữ liệu vào bảng ảo
            foreach (DataRow row in table.Rows)
            {                    
                Button b = new Button();
                Label lb = new Label();
                //định dạng lable
                lb.Name = "lb" + row[0].ToString();
                lb.Text = row[3].ToString();
                lb.Width = 190;
                lb.Top = 143 + i * 170;
                lb.Left = 95 + j * 240;
                lb.TextAlign = ContentAlignment.BottomCenter;
                lb.ForeColor = System.Drawing.Color.Green;
                lb.BackColor = System.Drawing.Color.White;
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pn_show.Controls.Add(lb);
                // định dạng Button
                b.Name = row[0].ToString();
                b.Width = 220;
                b.Height = 150;
                b.Top = 30 + i * 170;
                b.Left = 80 + j * 240;
                b.Text = "Phòng "+row[0].ToString();
                b.ForeColor = System.Drawing.Color.White;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_microphone_64;
                b.TextAlign = ContentAlignment.TopCenter;
                pn_show.Controls.Add(b);                   
                //thêm sự kiên
                    b.Click += new System.EventHandler(b_Click);
                    b.MouseDown += new MouseEventHandler(b_MouseDown);
                    b.ContextMenuStrip = contextMenuStrip1;
                    lb.ContextMenuStrip = contextMenuStrip1;
                    j++;
                if (j == 5)
                {
                    i++;
                    j = 0;
                }
             }
            CapNhat_TinhTrangPhong();                                      
        }

        private void b_MouseDown(object sender, MouseEventArgs e)
        {
            btnChon = ((Button)sender);
        }

        public delegate void delPassData(String text);

        private void b_Click(object sender, EventArgs e)
        {
            if (kn.State == ConnectionState.Closed)
                kn.Open();
            maphong = ((Button)sender).Name.ToString();
            string tinhtrang = "select tinhtrang from phong where maphong='"+maphong+"'";
            DataSet ds = new DataSet();
            SqlDataAdapter com = new SqlDataAdapter(tinhtrang,kn);
            com.Fill(ds,"TinhTrang");
            DataRow dr = ds.Tables["TinhTrang"].Rows[0];
            string tinhtrangp = dr["tinhtrang"].ToString();
            if (tinhtrangp == "Trống" || tinhtrangp=="Đã Đặt")
            {
                BanHang._maphong = maphong;
                BanHang.showNutThemKhach = true;
                BanHang bh = new BanHang();
                this.Close();
                bh.ShowDialog();                
            }
            else
                if (tinhtrangp == "Đang Hát")
                {
                    TraPhong._maphong = maphong;                    
                    TraPhong tp = new TraPhong();
                    this.Close();
                    tp.ShowDialog();                    
                }                 
        }
      
        private void FormMain_Load(object sender, EventArgs e)
        {
            kn.Open();
            timer1.Interval = 1000;
            timer1.Start();
            capnhatphong();
            load_phong("select * from phong");      
            load_PhanQuyen(Control_dangnhap.get_TenDangNhap);
            // load mã nhân viên, tên nhân viên
            string sql_TenMa = "select QL_TaiKhoan.MaNV, NhanVien.TenNV from QL_TaiKhoan, NhanVien where QL_TaiKhoan.MaNV= NhanVien.MaNV and QL_TaiKhoan.TenDangNhap='" + Control_dangnhap.get_TenDangNhap + "'";
            SqlCommand cmd_TenMa = new SqlCommand(sql_TenMa, kn);
            SqlDataReader read = cmd_TenMa.ExecuteReader();
            if (read.Read())
            {
                txt_MaNhanVien.Text = "Mã NV: " + read[0].ToString();
                txt_TenNhanVien.Text = "Tên NV: " + read[1].ToString();
                // truyền biến Mã Nhân Viên
                NhapKho_DV.MaNV = read[0].ToString();
                NhapKho_TB.MaNV = read[0].ToString();
                TraPhong._manhanvien = read[0].ToString();
            }
            read.Close();
            
        }

        private void load_PhanQuyen(string tenDN)
        {
            string sql_PhanQuyen = "select * from QL_PhanQuyenTaiKhoan where TenDN='"+tenDN+"'";
            SqlCommand cmd_PhanQuyen = new SqlCommand(sql_PhanQuyen, kn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd_PhanQuyen);
            DataTable table = new DataTable();
            adt.Fill(table);
            foreach (DataRow item in table.Rows)
            {                
                if (item[1].ToString() == "CN01" && (bool)item[2]==false)
                    pn_show.Visible = false;
                if (item[1].ToString() == "CN02" && (bool)item[2] == false)
                    CN02.Visible = false;
                if (item[1].ToString() == "CN03" && (bool)item[2] == false)
                    btn_DoThatLac.Visible = false;
                if (item[1].ToString() == "CN04" && (bool)item[2] == false)
                    btnKhachHang.Visible = false;
                if (item[1].ToString() == "CN05" && (bool)item[2] == false)
                    bntTTphong.Visible = false;
                if (item[1].ToString() == "CN06" && (bool)item[2] == false)
                    btn_thietbiphong.Visible = false;
                if (item[1].ToString() == "CN07" && (bool)item[2] == false)
                    btn_datphong.Visible = false;
                if (item[1].ToString() == "CN08" && (bool)item[2] == false)
                    btnThietBi.Visible = false;
                if (item[1].ToString() == "CN09" && (bool)item[2] == false)
                    btnAnUong.Visible = false;
                if (item[1].ToString() == "CN10" && (bool)item[2] == false)
                    btnTK.Visible = false;
                if (item[1].ToString() == "CN11" && (bool)item[2] == false)
                    btnNhanVien.Visible = false;
                if (item[1].ToString() == "CN12" && (bool)item[2] == false)
                    btnNhapKho.Visible = false;
                if (item[1].ToString() == "CN13" && (bool)item[2] == false)
                    btn_nhapthietbi.Visible = false;
                if (item[1].ToString() == "CN14" && (bool)item[2] == false)
                    btn_khoanthu.Visible = false;
                if (item[1].ToString() == "CN15" && (bool)item[2] == false)
                    btn_khoanchi.Visible = false;
                if (item[1].ToString() == "CN16" && (bool)item[2] == false)
                    btn_chitiet.Visible = false;
            }

            if (btn_DoThatLac.Visible == false && btnKhachHang.Visible == false)
                rb_quanlykhachhang.Visible = false;
            if (bntTTphong.Visible == false && btn_thietbiphong.Visible == false && btn_datphong.Visible == false)
                rb_quanlyphong.Visible = false;
            if (btnThietBi.Visible == false && btnAnUong.Visible == false)
                rb_quanlykho.Visible = false;
            if (btnTK.Visible == false && btnNhanVien.Visible == false)
                rb_quanlynhanvien.Visible = false;
            if (btnNhapKho.Visible == false && btn_nhapthietbi.Visible == false)
                rb_quanlynhapkho.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNgayGio.Text = DateTime.Now.ToString();
            
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void btnAnUong_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            this.Hide();
            dv.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                kn.Close();
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất chương trình !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatPhong dp = new frmDatPhong();
            dp.ShowDialog();
            capnhatphong();
            pn_show.Controls.Clear();
            load_phong("select * from phong");
            this.Show();
        }

        private void btn_DoThatLac_Click(object sender, EventArgs e)
        {
            DoThatLac dtl = new DoThatLac();            
            dtl.ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }

        private void kháchVàoHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_Click(btnChon,e); 
        }

        private void TrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_Click(btnChon, e); 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string sql_tinhtrang = "select TinhTrang from Phong where MaPhong='"+btnChon.Name.ToString()+"'";
            SqlCommand cmd_tinhtrang = new SqlCommand(sql_tinhtrang, kn);
            string tinhtrang = cmd_tinhtrang.ExecuteScalar().ToString();
            if (tinhtrang == "Trống")
            {
                kháchVàoHátToolStripMenuItem.Enabled = true;
                TrảPhòngToolStripMenuItem.Enabled = false;
                đổiPhòngToolStripMenuItem.Enabled = false;
                dọnPhòngToolStripMenuItem.Text = "Dọn phòng";
                dọnPhòngToolStripMenuItem.Enabled = true;
                bảoTrìToolStripMenuItem.Text = "Bảo trì";
                bảoTrìToolStripMenuItem.Enabled = true;
            }
            else
                if (tinhtrang == "Đang Hát")
                {
                    kháchVàoHátToolStripMenuItem.Enabled = false;
                    TrảPhòngToolStripMenuItem.Enabled = true;
                    đổiPhòngToolStripMenuItem.Enabled = true;
                    dọnPhòngToolStripMenuItem.Text = "Dọn phòng";
                    dọnPhòngToolStripMenuItem.Enabled = false;
                    bảoTrìToolStripMenuItem.Text = "Bảo trì";
                    bảoTrìToolStripMenuItem.Enabled = false;
                }
                else
                    if (tinhtrang == "Đang Dọn")
                    {
                        kháchVàoHátToolStripMenuItem.Enabled = false;
                        TrảPhòngToolStripMenuItem.Enabled = false;
                        đổiPhòngToolStripMenuItem.Enabled = false;
                        dọnPhòngToolStripMenuItem.Text = "Hoàn thành dọn phòng";
                        dọnPhòngToolStripMenuItem.Enabled = true;
                        bảoTrìToolStripMenuItem.Text = "Bảo trì";
                        bảoTrìToolStripMenuItem.Enabled = false;
                    }
                    else
                        if (tinhtrang == "Bảo Trì")
                        {
                            kháchVàoHátToolStripMenuItem.Enabled = false;
                            TrảPhòngToolStripMenuItem.Enabled = false;
                            đổiPhòngToolStripMenuItem.Enabled = false;
                            dọnPhòngToolStripMenuItem.Text = "Dọn phòng";
                            dọnPhòngToolStripMenuItem.Enabled = false;
                            bảoTrìToolStripMenuItem.Text = "Hoàn thành bảo trì";
                            bảoTrìToolStripMenuItem.Enabled = true;
                        }
        }

        private void dọnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dọnPhòngToolStripMenuItem.Text == "Hoàn thành dọn phòng")
            {
                string sql_UDDangDon = "update Phong set TinhTrang=N'Trống' where MaPhong='" + btnChon.Name.ToString() + "'";
                SqlCommand cmd_UDDangDon = new SqlCommand(sql_UDDangDon, kn);
                cmd_UDDangDon.ExecuteNonQuery();
                CapNhat_TinhTrangPhong();
            }
            else
            {
                string sql_UDDangDon = "update Phong set TinhTrang=N'Đang Dọn' where MaPhong='" + btnChon.Name.ToString() + "'";
                SqlCommand cmd_UDDangDon = new SqlCommand(sql_UDDangDon, kn);
                cmd_UDDangDon.ExecuteNonQuery();
                CapNhat_TinhTrangPhong();
            }
        }

        private void bảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bảoTrìToolStripMenuItem.Text == "Hoàn thành bảo trì")
            {
                string sql_UDBaoTri = "update Phong set TinhTrang=N'Trống' where MaPhong='" + btnChon.Name.ToString() + "'";
                SqlCommand cmd_UDDBaoTri = new SqlCommand(sql_UDBaoTri, kn);
                cmd_UDDBaoTri.ExecuteNonQuery();
                CapNhat_TinhTrangPhong();
            }
            else
            {
                string sql_UDBaoTri = "update Phong set TinhTrang=N'Bảo Trì' where MaPhong='" + btnChon.Name.ToString() + "'";
                SqlCommand cmd_UDDBaoTri = new SqlCommand(sql_UDBaoTri, kn);
                cmd_UDDBaoTri.ExecuteNonQuery();
                CapNhat_TinhTrangPhong();
            }
        }

        private void đổiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            frmThietBi tb = new frmThietBi();
            this.Hide();
            tb.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang.showNutThemVaoPhong = false;
            KhachHang kh = new KhachHang();            
            kh.ShowDialog();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            NhapKho_DV nk = new NhapKho_DV();
            this.Hide();
            nk.ShowDialog();
            this.Show();
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            ThongKe_KhoanThu thu = new ThongKe_KhoanThu();
            this.Hide();
            thu.ShowDialog();
            this.Show();
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            ThongKe_KhoanChi chi = new ThongKe_KhoanChi();
            this.Hide();
            chi.ShowDialog();
            this.Show();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            NhapKho_TB tb = new NhapKho_TB();
            this.Hide();
            tb.ShowDialog();
            this.Show();
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            this.Hide();
            ctpn.ShowDialog();
            this.Show();
        }

        private void LoaiTatCa_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong");
        }

        private void LoaiVip_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where MaLoaiPhong='LP01'");
        }

        private void LoaiThuong_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where MaLoaiPhong='LP02'");
        }

        private void LoaiALL_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong");
        }

        private void loaitrong_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where TinhTrang=N'Trống'");
        }

        private void LoaiDangHat_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where TinhTrang=N'Đang Hát'");
        }

        private void LoaiDangDon_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where TinhTrang=N'Đang Dọn'");
        }

        private void LoaiBaoTri_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            load_phong("select * from phong where TinhTrang=N'Bảo Trì'");
        }

        private void bntTTphong_Click(object sender, EventArgs e)
        {
            frmPhong p = new frmPhong();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void btn_thietbiphong_Click(object sender, EventArgs e)
        {
            frmPhongHat ph = new frmPhongHat();
            this.Hide();
            ph.ShowDialog();
            this.Show();
        }


    }
}
