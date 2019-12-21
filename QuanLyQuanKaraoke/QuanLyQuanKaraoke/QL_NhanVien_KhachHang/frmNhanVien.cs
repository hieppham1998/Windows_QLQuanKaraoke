using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanKaraoke.QL_NhanVien_KhachHang;
using QuanLyQuanKaraoke.QL_TaiKhoan_PhanQuyen;
using System.Data.SqlClient;

namespace QuanLyQuanKaraoke
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTS_QL_NhanVien.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dTS_QL_NhanVien.NhanVien);

        }

        private void xulyEnable( bool gt)
        {
            txtTen_NV.Enabled = gt;
            txt_DiaChiNV.Enabled = gt;
            txt_SDTNV.Enabled = gt;
            txt_CMNDNV.Enabled = gt;
            cbb_GioiTinhNV.Enabled = gt;
            DTI_NgayVaoLam.Enabled = gt;
            DTI_NgaySinh.Enabled = gt;
        }

        private void xulyClear()
        {
            txtMa_NV.Clear();
            txtTen_NV.Clear();
            txt_DiaChiNV.Clear();
            txt_CMNDNV.Clear();
            txt_SDTNV.Clear();
            cbb_GioiTinhNV.SelectedIndex = 0;
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (btn_ThemNV.Text == "Thêm")
            {
                xulyEnable(true);
                dgvNhanVien.Enabled = false;
                btn_SuaNV.Enabled = false;
                btn_ThemNV.Text = "Lưu";
                btn_ThemNV.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                xulyClear();
            }
            else 
            {
                if (KT_Rong())
                {
                    if (kt_tuoi())
                    {
                        dgvNhanVien.Enabled = true;
                        btn_SuaNV.Enabled = true;
                        btn_ThemNV.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
                        btn_ThemNV.Text = "Thêm";
                        xulyEnable(false);
                        using (LinqNhanVienDataContext db = new LinqNhanVienDataContext())
                        {
                            NhanVien Them = new NhanVien();
                            Them.TenNV = txtTen_NV.Text;
                            Them.GioiTinh = cbb_GioiTinhNV.SelectedItem.ToString();
                            Them.NgaySinh = DTI_NgaySinh.Value;
                            Them.SDT = txt_SDTNV.Text;
                            Them.DiaChi = txt_DiaChiNV.Text;
                            Them.CMND = txt_CMNDNV.Text;
                            Them.NgayVaoLam = DTI_NgayVaoLam.Value;
                            Them.MaNV = txtMa_NV.Text;

                            db.NhanViens.InsertOnSubmit(Them);
                            db.SubmitChanges();
                            this.nhanVienTableAdapter.Fill(this.dTS_QL_NhanVien.NhanVien);
                            DialogResult r = MessageBox.Show("Thêm nhân viên thành công! Bạn có muốn cấp tài khoản cho nhân viên ngay bây giờ ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (r == DialogResult.OK)
                            {
                                this.Close();
                                ThemTaiKhoan themtk = new ThemTaiKhoan();
                                themtk.ShowDialog();
                            }
                        }
                    }
                }

            }
        }

        private void dienmaNV()
        {
            if (txtTen_NV.Text.Length > 0 && txt_DiaChiNV.Text.Length > 0 && txt_SDTNV.Text.Length > 0 
                && txt_CMNDNV.Text.Length >0 )
            {
                using(LinqNhanVienDataContext db = new LinqNhanVienDataContext())
                {
                    int count = (from h in db.NhanViens select h.MaNV).Count();
                    count++;
                    string s;
                    if (count < 10)
                        s = string.Format("NV00{0}", count);
                    else if (count < 100)
                        s = string.Format("NV0{0}", count);
                    else
                        s = string.Format("NV{0}", count);
                    txtMa_NV.Text = s;
                }
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (btn_SuaNV.Text == "Sửa")
            {
                xulyEnable(true);
                btn_ThemNV.Enabled = false;
                btn_SuaNV.Text = "Lưu";
                btn_SuaNV.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
            }
            else
            {
                if (KT_Rong())
                {
                    if (kt_tuoi())
                    {
                        btn_SuaNV.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
                        btn_SuaNV.Text = "Sửa";
                        btn_ThemNV.Enabled = true;
                        xulyEnable(false);

                        using (LinqNhanVienDataContext db = new LinqNhanVienDataContext())
                        {
                            string maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();

                            NhanVien Sua = db.NhanViens.Where(h => h.MaNV.Equals(maNV)).SingleOrDefault();
                            Sua.TenNV = txtTen_NV.Text;
                            Sua.DiaChi = txt_DiaChiNV.Text;
                            Sua.NgaySinh = DTI_NgaySinh.Value;
                            Sua.GioiTinh = cbb_GioiTinhNV.SelectedItem.ToString();
                            Sua.SDT = txt_SDTNV.Text;
                            Sua.CMND = txt_CMNDNV.Text;
                            Sua.NgayVaoLam = DTI_NgayVaoLam.Value;

                            db.SubmitChanges();
                            this.nhanVienTableAdapter.Fill(this.dTS_QL_NhanVien.NhanVien);
                            MessageBox.Show("Sửa thông tin nhân viên thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtTen_NV_TextChanged(object sender, EventArgs e)
        {
            dienmaNV();
        }

        private bool kt_tuoi()
        {
            DateTime ngaysinh = Convert.ToDateTime(DTI_NgaySinh.Value.ToShortDateString());
            DateTime ngayvaolam = Convert.ToDateTime(DTI_NgayVaoLam.Value.ToShortDateString());
            TimeSpan Time = ngayvaolam - ngaysinh;
            int TongSoNgay = Time.Days;
            if (TongSoNgay < 6570)
            {
                MessageBox.Show("Tuổi của nhân viên phải lớp hơn hoặc bằng 18!");
                return false;
            }
            else
                return true;
        }

        private bool KT_Rong()
        {
            if (string.IsNullOrEmpty(this.txtTen_NV.Text))
            {
                MessageBox.Show("Không được bỏ trống tên nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTen_NV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_DiaChiNV.Text))
            {
                MessageBox.Show("Không được bỏ trống địa chỉ của nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_DiaChiNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_SDTNV.Text))
            {
                MessageBox.Show("Không được bỏ trống số điện thoại của nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_SDTNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_CMNDNV.Text))
            {
                MessageBox.Show("Không được bỏ trống chứng minh nhân dân của nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_CMNDNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.DTI_NgayVaoLam.Text))
            {
                MessageBox.Show("Không được bỏ trống ngày vào làm của nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DTI_NgayVaoLam.Focus();
                return false;
            }
            return true;
        }

        private void txt_SDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDTNV_Leave(object sender, EventArgs e)
        {
            if (txt_SDTNV.Text.Length != 10 || txt_SDTNV.Text.Substring(0, 1) != "0")
            {
                MessageBox.Show("Số điện thoại phải bắt đầu từ 0 và có 10 chữ số !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDTNV.Focus();
            }
        }


    }
}
