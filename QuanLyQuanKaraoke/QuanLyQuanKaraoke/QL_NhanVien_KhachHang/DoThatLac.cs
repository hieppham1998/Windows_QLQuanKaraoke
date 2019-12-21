using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    public partial class DoThatLac : Form
    {
        public DoThatLac()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();

        private void DoThatLac_Load(object sender, EventArgs e)
        {
            kn.Open();
            timer1.Interval = 10;
            timer1.Start();
            // TODO: This line of code loads data into the 'dTS_QL_NhanVien.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dTS_QL_NhanVien.Phong);
            // TODO: This line of code loads data into the 'dTS_QL_NhanVien.DoThatLac' table. You can move, or remove it, as needed.
            this.doThatLacTableAdapter.Fill(this.dTS_QL_NhanVien.DoThatLac);

            binding();

        }

        private void binding()
        {
            if (dgv_dothatlac.CurrentRow != null)
            {
                cbb_MaPhong_DTL.DataBindings.Clear();
                cbb_MaPhong_DTL.DataBindings.Add("text", dgv_dothatlac.DataSource, "MaPhong");
                DateTime ngaygio = (DateTime)dgv_dothatlac.CurrentRow.Cells[1].Value;
                string gt = ngaygio.ToString("dd/MM/yyyy HH:mm:ss");
                lbngay.Text = gt.Substring(0, 10);
                lbgio.Text = gt.Substring(11);
            }
        }

        private void xuly_Enabel_Them(bool KieuNhap, bool KieuNut)
        {
            cbb_MaPhong_DTL.Enabled = KieuNhap;
            txt_GhiChu_DTL.Enabled = KieuNhap;
            dgv_dothatlac.Enabled = KieuNut;
            btn_SuaDTL.Enabled = KieuNut;
            btn_XoaDTL.Enabled = KieuNut;
        }

        private void btn_ThemDTL_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_ThemDTL.Text == "Thêm")
                {
                    txt_GhiChu_DTL.Clear();
                    btn_ThemDTL.Text = "Lưu";
                    xuly_Enabel_Them(true, false);
                    btn_ThemDTL.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                }
                else
                {
                    if (KiemTraTrong())
                    {
                        btn_ThemDTL.Text = "Thêm";
                        xuly_Enabel_Them(false, true);
                        btn_ThemDTL.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;                  
                        DateTime ngaygio = DateTime.Now;
                        string gt = ngaygio.ToString("yyyy/MM/dd HH:mm:ss");
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        DateTime dt = DateTime.ParseExact(gt, "yyyy/MM/dd HH:mm:ss", provider);

                        doThatLacTableAdapter.Insert(cbb_MaPhong_DTL.SelectedValue.ToString(), dt, txt_GhiChu_DTL.Text);
                        MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.doThatLacTableAdapter.Fill(this.dTS_QL_NhanVien.DoThatLac);
                        binding();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTrong()
        {
            if (string.IsNullOrEmpty(this.cbb_MaPhong_DTL.Text))
            {
                MessageBox.Show("Không được bỏ trống Mã Phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbb_MaPhong_DTL.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_GhiChu_DTL.Text))
            {
                MessageBox.Show("Không được bỏ trống ghi chú !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_GhiChu_DTL.Focus();
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbnow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");            
        }

        private void btn_XoaDTL_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa món đồ này !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                string maphong= dgv_dothatlac.CurrentRow.Cells[0].Value.ToString();
                DateTime ngaygio = (DateTime)dgv_dothatlac.CurrentRow.Cells[1].Value;
                string ghichu = dgv_dothatlac.CurrentRow.Cells[2].Value.ToString();
                doThatLacTableAdapter.Delete(maphong, ngaygio, ghichu);                
                // TODO: This line of code loads data into the 'dTS_QL_NhanVien.DoThatLac' table. You can move, or remove it, as needed.
                this.doThatLacTableAdapter.Fill(this.dTS_QL_NhanVien.DoThatLac);
                binding();
            }
        }

        private void xuly_Enabel_Sua(bool KieuNhap, bool KieuNut)
        {
            cbb_MaPhong_DTL.Enabled = KieuNhap;
            txt_GhiChu_DTL.Enabled = KieuNhap;
            btn_ThemDTL.Enabled = KieuNut;
            btn_XoaDTL.Enabled = KieuNut;
        }

        private void btn_SuaDTL_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_SuaDTL.Text == "Sửa")
                {
                    btn_SuaDTL.Text = "Lưu";
                    xuly_Enabel_Sua(true, false);
                    btn_SuaDTL.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                }
                else
                {
                    btn_SuaDTL.Text = "Sửa";
                    xuly_Enabel_Sua(false, true);
                    btn_SuaDTL.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
                    if (KiemTraTrong())
                    {                    
                        DateTime ngaygio = (DateTime)dgv_dothatlac.CurrentRow.Cells[1].Value;
                        string gt = ngaygio.ToString("yyyy/MM/dd HH:mm:ss");
                        string sql_UDDTL = "update DoThatLac set MaPhong='" + cbb_MaPhong_DTL.SelectedValue.ToString() + "', GhiChu=N'" + txt_GhiChu_DTL.Text + "' where NgayGio='" + gt + "'";
                        SqlCommand cmd_UDDTL = new SqlCommand(sql_UDDTL, kn);
                        cmd_UDDTL.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.doThatLacTableAdapter.Fill(this.dTS_QL_NhanVien.DoThatLac);
                        binding();                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoThatLac_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }

        private void dgv_dothatlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }


    }
}
