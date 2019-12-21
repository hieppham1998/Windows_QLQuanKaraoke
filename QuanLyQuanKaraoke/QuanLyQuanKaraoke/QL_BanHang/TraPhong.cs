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
using QuanLyQuanKaraoke.QL_BanHang;
namespace QuanLyQuanKaraoke
{
    public partial class TraPhong : Form
    {
        DataSet ds = new DataSet();
        public TraPhong()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();
        Connection ketnoi = new Connection();
        public static string _maphong;
        public static string _manhanvien;
        string sdt_khach;
        bool co = false;
        int tienCoc;
        int tienKM;
        int tienphong;
        int tienDV;
        int tienDenBu;
        int tongtien;

        private void TraPhong_Load(object sender, EventArgs e)
        {
            try
            {
                kn.Open();
                string s="select * from dichvu";
                ketnoi.autoText(txtTK, kn, s, "TenDichVu");
                txtTenPhong.Text = _maphong;
                string sql_mapv = "select MaPhucVu from HoaDon_Tam where MaPhong='"+_maphong+"'";
                SqlCommand cmd_mapv = new SqlCommand(sql_mapv,kn);
                txtMaThuePhong.Text = cmd_mapv.ExecuteScalar().ToString();

                // TODO: This line of code loads data into the 'dataQuanLy.ChiTietHoaDon' table. You can move, or remove it, as needed.
                this.chiTietHoaDonTableAdapter.Fill(this.dataQuanLy.ChiTietHoaDon);
                // TODO: This line of code loads data into the 'dataQuanLy.HoaDon' table. You can move, or remove it, as needed.
                this.hoaDonTableAdapter.Fill(this.dataQuanLy.HoaDon);
                //lấy sdt khách hàng
                string sdt = "select sdt_kh from hoadon_tam where maphong='" + _maphong + "'";
                SqlCommand cmd_sdt = new SqlCommand(sdt, kn);
                sdt_khach = cmd_sdt.ExecuteScalar().ToString();
                // lấy thông tin khách hàng
                string tt_khach="select*from khachhang where sdt='"+sdt_khach+"'";
                DataTable dt = new DataTable();
                SqlCommand tt = new SqlCommand(tt_khach, kn);
                SqlDataAdapter adt_khachhang = new SqlDataAdapter(tt);
                adt_khachhang.Fill(dt);
                dataKhachHang.DataSource = dt;

                //lấy tiền cọc
                string sql_laytiencoc = "select TienDatCoc from HoaDon_Tam where MaPhong='" + _maphong + "'";
                SqlCommand cmd_tiencoc = new SqlCommand(sql_laytiencoc, kn);
                txtTienCoc.Text = cmd_tiencoc.ExecuteScalar().ToString();
                tienCoc = int.Parse(txtTienCoc.Text);

                // TODO: This line of code loads data into the 'dataQuanLy.PhuThu' table. You can move, or remove it, as needed.
                this.phuThuTableAdapter.Fill(this.dataQuanLy.PhuThu);
                // TODO: This line of code loads data into the 'dataQuanLy.DichVu' table. You can move, or remove it, as needed.
                this.dichVuTableAdapter.Fill(this.dataQuanLy.DichVu);
                // TODO: This line of code loads data into the 'dataQuanLy.HoaDon_Tam' table. You can move, or remove it, as needed.
                this.hoaDon_TamTableAdapter.Fill(this.dataQuanLy.HoaDon_Tam);
                lbKetThuc.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                this.tamTinhTableAdapter.Fill(this.dataQuanLy.TamTinh, txtTenPhong.Text);
                       
                if (kn.State.ToString() == "Open")
                {
                    string tinhtrang = "select giobd from hoadon_tam where maphong='" + _maphong + "'";
                                
                    SqlDataAdapter com = new SqlDataAdapter(tinhtrang, kn);
                    com.Fill(ds, "giobd");
                    DataRow dr = ds.Tables["giobd"].Rows[0];
                    lbBatDau.Text = dr["giobd"].ToString();
                }
                //Tính số phút
                string thoigian = "SELECT DATEDIFF(minute,'" + lbBatDau.Text + "','" + lbKetThuc.Text + "')";
                SqlCommand cmd = new SqlCommand(thoigian, kn);
                int tg = (int)cmd.ExecuteScalar();
                //Tính giá phòng
                string giatien = "select (giaphong*"+tg+") as tienPhong from phong where maphong='" + _maphong + "'";
                SqlDataAdapter comGT = new SqlDataAdapter(giatien, kn);
                comGT.Fill(ds, "giap");
                DataRow drGP = ds.Tables["giap"].Rows[0];
                txtTienPhong.Text = drGP["tienPhong"].ToString();
                //Tính tiền dịch vụ
                string dvu = "select sum(CTHD_Tam.SoLuong*DonGiaBan) as thanhtien from HoaDon_Tam hdt, CTHD_Tam,DichVu where hdt.MaPhucVu=CTHD_Tam.MaPV and CTHD_Tam.MaDV=DichVu.MaDV and hdt.MaPhong='" + _maphong + "'";
                SqlDataAdapter comDV = new SqlDataAdapter(dvu, kn);
                comDV.Fill(ds, "giadv");
                DataRow drDV = ds.Tables["giadv"].Rows[0];
                txtTienDichVu.Text = drDV["thanhtien"].ToString();

                //tính khuyến mãi
                int diemKH =(int)dataKhachHang.Rows[0].Cells[2].Value;            
                if (diemKH ==3)
                {
                    tienKM = 100000;
                    txtKhuyenMai.Text = tienKM.ToString();
                }
                else
                {
                    tienKM = 0;
                }
                //Tính tiền
                    tienphong = int.Parse(drGP["tienPhong"].ToString());
                    tienDV = int.Parse(drDV["thanhtien"].ToString());                    
                    cbbPhuThu.SelectedIndex = 0;
                    tinhtien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TraPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (co)
            {
                BanHang bh = new BanHang();
                BanHang.showNutThemKhach = false;
                BanHang._maphucvu = txtMaThuePhong.Text;
                BanHang._maphong = txtTenPhong.Text;
                BanHang._sdtkhachhang = sdt_khach;
                bh.Show();
            }
            else
            {
                kn.Close();
                FormMain fm = new FormMain();
                fm.Show();
            }
        }

        private void txtTienPhong_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTienPhong.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTienPhong.Text = String.Format(culture, "{0:N0}", value);
            txtTienPhong.Select(txtTienPhong.Text.Length, 0);
            tinhtien();
        }

        private void txtTienDichVu_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTienDichVu.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTienDichVu.Text = String.Format(culture, "{0:N0}", value);
            txtTienDichVu.Select(txtTienPhong.Text.Length, 0);
            tinhtien();
        }

        int tienPhuThu;
        private void cbbPhuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbPhuThu.SelectedValue != null)
                {
                    string giaPhuThu = "select sotien from phuthu where maphuthu='" + cbbPhuThu.SelectedValue.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(giaPhuThu, kn);
                    tienPhuThu = (int)cmd.ExecuteScalar();
                    txtPhuThu.Text = tienPhuThu.ToString();
                    tinhtien();
                }                
            }
            catch {
                MessageBox.Show("Lỗi !!");

            }
        }

        private void tinhtien()
        {
            if (txtTienDenBu.Text != "")
                tienDenBu = int.Parse(txtTienDenBu.Text);
            else
                tienDenBu = 0;
            if (txtKhuyenMai.Text != "")
                tienKM = int.Parse(txtKhuyenMai.Text);
            else
                tienKM = 0;
            tongtien = tienDV + tienPhuThu + tienphong + tienDenBu - tienCoc - tienKM;
            if (tongtien < 0)
                txtTongTien.Text = "0";
            else
                txtTongTien.Text = tongtien.ToString();
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtPhuThu.Text, System.Globalization.NumberStyles.AllowThousands);
            txtPhuThu.Text = String.Format(culture, "{0:N0}", value);
            txtPhuThu.Select(txtPhuThu.Text.Length, 0);
            tinhtien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thanh toán !","Thông Báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    btnInHoaDon.Enabled = true;
                    btnThanhToan.Enabled = false;
                    btnCNMon.Enabled = false;
                    if (txtKhuyenMai.Text == "100000")
                    {
                        string updateDiemTru = "update khachhang set tichdiem=0 where sdt='" + dataKhachHang.Rows[0].Cells[1].Value.ToString() + "'";
                        SqlCommand cdmDiemT = new SqlCommand(updateDiemTru, kn);
                        cdmDiemT.ExecuteNonQuery();
                    }
                    else
                    {
                        string updateDiem = "update khachhang set tichdiem=tichdiem+1 where sdt='" + dataKhachHang.Rows[0].Cells[1].Value.ToString() + "'";
                        SqlCommand cdmDiem = new SqlCommand(updateDiem, kn);
                        cdmDiem.ExecuteNonQuery();
                    }

                    hoaDonTableAdapter.Insert(txtMaThuePhong.Text, dataKhachHang.Rows[0].Cells[1].Value.ToString(), _maphong.ToString(), _manhanvien, Convert.ToDateTime(lbBatDau.Text), DateTime.Now, cbbPhuThu.SelectedValue.ToString(), tienCoc, tienKM, tienDenBu, tongtien);
                    for (int i = 0; i <= dataDV.RowCount - 1; i++)
                    {
                        chiTietHoaDonTableAdapter.Insert(txtMaThuePhong.Text, dataDV.Rows[i].Cells[5].Value.ToString(), int.Parse(dataDV.Rows[i].Cells[1].Value.ToString()), int.Parse(dataDV.Rows[i].Cells[2].Value.ToString()), dataDV.Rows[i].Cells[3].Value.ToString(), double.Parse(dataDV.Rows[i].Cells[4].Value.ToString()));
                    }
                    //Xóa hóa đơn tạm và chi tiết tạm
                    //Cập nhật lại tình trạng phòng
                    string xoa_cthd_tam = "delete from cthd_tam where mapv='" + txtMaThuePhong.Text + "'";
                    SqlCommand cmd_cthoadon_tam = new SqlCommand(xoa_cthd_tam, kn);
                    cmd_cthoadon_tam.ExecuteNonQuery();
                    string xoa_hd_tam = "delete from hoadon_tam where maphucvu='" + txtMaThuePhong.Text + "'";
                    SqlCommand cmd_hoadon_tam = new SqlCommand(xoa_hd_tam, kn);
                    cmd_hoadon_tam.ExecuteNonQuery();
                    string ktra_dat = "select datphong.maphong from phong, datphong where phong.maphong=datphong.maphong and year(GioNhanPhong)=YEAR(getdate()) and MONTH(gionhanphong)=month(getdate()) and day(GioNhanPhong)=day(GETDATE()) and datphong.maphong='" + _maphong + "'";
                    SqlCommand com_Ktra = new SqlCommand(ktra_dat, kn);
                    SqlDataReader dr = com_Ktra.ExecuteReader();
                    if (!dr.Read())
                    {
                        dr.Close();
                        string update_tinhTrang = "update phong set tinhtrang=N'Đang Dọn' where maphong='" + _maphong.ToString() + "'";
                        SqlCommand cmd_tinhtrang = new SqlCommand(update_tinhTrang, kn);
                        cmd_tinhtrang.ExecuteNonQuery();
                    }
                    else
                    {
                        dr.Close();
                        string update_tinhTrang1 = "update phong set tinhtrang=N'Đã Đặt' where maphong='" + _maphong.ToString() + "'";
                        SqlCommand cmd_tinhtrang1 = new SqlCommand(update_tinhTrang1, kn);
                        cmd_tinhtrang1.ExecuteNonQuery();
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTongTien.Text = String.Format(culture, "{0:N0}", value);
            txtTongTien.Select(txtTongTien.Text.Length, 0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCNMon_Click(object sender, EventArgs e)
        {
            co = true;
            this.Close();
        }
        public string map;
        private void btnInHoaDon_Click_1(object sender, EventArgs e)
        {
            map = txtMaThuePhong.Text;
            RPTHoaDon rpt = new RPTHoaDon(map);
            rpt.Show();
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void txtTienDenBu_TextChanged(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            tinhtien();
        }

        private void txtTienDenBu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
