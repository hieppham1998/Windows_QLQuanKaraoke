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

namespace QuanLyQuanKaraoke
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_TaiKhoan.QL_PhanQuyenTaiKhoan' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTaiKhoanTableAdapter.Fill(this.qL_TaiKhoan.QL_PhanQuyenTaiKhoan);
            // TODO: This line of code loads data into the 'qL_TaiKhoan._QL_TaiKhoan' table. You can move, or remove it, as needed.
            this.qL_TaiKhoanTableAdapter.Fill(this.qL_TaiKhoan._QL_TaiKhoan);                  
            // TODO: This line of code loads data into the 'qL_TaiKhoan.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.qL_TaiKhoan.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'qL_TaiKhoan.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.qL_TaiKhoan.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'qL_TaiKhoan.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill_tk(this.qL_TaiKhoan.DataTable1);
            //load bảng phân quyền theo nhóm chức năng
            this.tableAdapterTableAdapter.Fill(this.qL_TaiKhoan.PhanQuyenTheoNhomND, cbb_NhomND.SelectedValue.ToString());
            //load bảng phân quyền theo tài khoản
            this.phanQuyenTheoTaiKhoanTableAdapter.Fill(this.qL_TaiKhoan.PhanQuyenTheoTaiKhoan, cbb_tentaikhoan.SelectedValue.ToString());

            kn.Open();
            binding();
        }


        private void binding()
        {
            cbbnhomND.DataBindings.Clear();
            cbbnhomND.DataBindings.Add("text", dgvTaiKhoan.DataSource, "TenNhom");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themtk = new ThemTaiKhoan();
            themtk.ShowDialog();
            // TODO: This line of code loads data into the 'qL_TaiKhoan.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill_tk(this.qL_TaiKhoan.DataTable1);
            //load bảng phân quyền theo tài khoản
            this.phanQuyenTheoTaiKhoanTableAdapter.Fill(this.qL_TaiKhoan.PhanQuyenTheoTaiKhoan, cbb_tentaikhoan.SelectedValue.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đổi thông tin của tài khoản " + txtTaiKhoan.Text + " !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    bool hd;
                    if (ckbHoatDong.Checked == true)
                        hd = true;
                    else
                        hd = false;
                    string sql_updateTK = "update QL_TaiKhoan set HoatDong='"+hd+"', NhomNguoiDung='"+cbbnhomND.SelectedValue.ToString()+"' where TenDangNhap='"+txtTaiKhoan.Text+"'";
                    SqlCommand cmd = new SqlCommand(sql_updateTK, kn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatQuyenTheoNhomND(cbbnhomND.SelectedValue.ToString(), txtTaiKhoan.Text);
                    this.dataTable1TableAdapter.Fill_tk(this.qL_TaiKhoan.DataTable1);
                    binding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn reset mật khẩu của tài khoản " + txtTaiKhoan.Text + " !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    string sql_resetmk = "update QL_TaiKhoan set MatKhau='11111' where TenDangNhap='" + txtTaiKhoan.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql_resetmk, kn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reset mật khẩu thành công! Mật Khẩu mặc đinh là: 11111", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnadd.Text == "Thêm")
                {
                    txtmanhom.Clear();
                    txttennhom.Clear();
                    btnadd.Text = "Lưu";
                    xulyEnableThem(false);
                    btnadd.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                }
                else
                {                    
                    if (KT_TrongNhomND())
                    {
                        xulyEnableThem(true);
                        btnadd.Text = "Thêm";
                        btnadd.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
                        qL_NhomNguoiDungTableAdapter.Insert(txtmanhom.Text, txttennhom.Text, txtghichu.Text);
                        ThemQuyenChoNhomMoi(txtmanhom.Text);
                        this.qL_NhomNguoiDungTableAdapter.Fill(this.qL_TaiKhoan.QL_NhomNguoiDung);
                        MessageBox.Show("Thêm nhóm người dùng thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mã nhóm người dùng đã tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xulyEnableThem(bool xuly)
        {
            bntchange.Enabled = xuly;
            bntdelete.Enabled = xuly;
            dgvNhomNguoiDung.Enabled = xuly;
        }

        private void xulyEnableSua(bool xuly)
        {
            btnadd.Enabled = xuly;
            bntdelete.Enabled = xuly;
            dgvNhomNguoiDung.Enabled = xuly;
            txtmanhom.Enabled = xuly;
        }

        private void bntchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (bntchange.Text == "Sửa")
                {
                    bntchange.Text = "Lưu";
                    xulyEnableSua(false);
                    bntchange.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                }
                else
                {
                    if (KT_TrongNhomND())
                    {
                        xulyEnableSua(true);
                        bntchange.Text = "Sửa";
                        bntchange.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_update_user_48;
                        string sql_UDNhomND = "update QL_NhomNguoiDung set TenNhom=N'" + txttennhom.Text + "', GhiChu=N'" + txtghichu.Text + "' where MaNhom='" + txtmanhom.Text + "'";
                        SqlCommand cmd_UDNhomND = new SqlCommand(sql_UDNhomND, kn);
                        cmd_UDNhomND.ExecuteNonQuery();
                        MessageBox.Show("Sửa nhóm người dùng thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm người dùng " + txttennhom.Text + " !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    string maNh = dgvNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
                    string tenNh = dgvNhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
                    string GC = dgvNhomNguoiDung.CurrentRow.Cells[2].Value.ToString();
                    string sql_kt = "select * from QL_TaiKhoan where NhomNguoiDung='"+maNh+"'";
                    SqlCommand cmdkt = new SqlCommand(sql_kt, kn);
                    SqlDataReader doc = cmdkt.ExecuteReader();
                    if (doc.Read())
                    {
                        MessageBox.Show("Đang có tài khoản thuộc nhóm này, Không thể xóa Nhóm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        doc.Close();
                    }
                    else
                    {
                        doc.Close();
                        XoaQuyenChoNhom(maNh);
                        int kq = qL_NhomNguoiDungTableAdapter.Delete(maNh, tenNh, GC);
                        this.qL_NhomNguoiDungTableAdapter.Fill(this.qL_TaiKhoan.QL_NhomNguoiDung);
                        if (kq == 1)
                            MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KT_TrongNhomND()
        {
            if (string.IsNullOrEmpty(this.txtmanhom.Text))
            {
                MessageBox.Show("Không được bỏ trống mã nhóm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtmanhom.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txttennhom.Text))
            {
                MessageBox.Show("Không được bỏ trống tên nhóm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txttennhom.Focus();
                return false;
            }
            return true;
        }

        private void qL_NhomNguoiDungComboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tableAdapterTableAdapter.Fill(this.qL_TaiKhoan.PhanQuyenTheoNhomND, cbb_NhomND.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maCN=null;
                string maND = cbb_NhomND.SelectedValue.ToString();
                bool CoQuyen;
                int tongsodong= dvgPhanQuyenTheoNhom.Rows.Count;
                for (int i = 0; i <tongsodong ; i++)
                {
                    maCN = dvgPhanQuyenTheoNhom.Rows[i].Cells[0].Value.ToString();
                    CoQuyen = (bool)dvgPhanQuyenTheoNhom.Rows[i].Cells[2].Value;
                    string sql_CNquyen = "update QL_PhanQuyen set CoQuyen='" + CoQuyen + "' where MaNhomNguoiDung='" + maND + "' and MaChucNang='" + maCN + "'";
                    SqlCommand cmd_UD = new SqlCommand(sql_CNquyen, kn);
                    cmd_UD.ExecuteNonQuery();
                    CapNhatTatCaTKtheoNhom(maND,maCN,CoQuyen);
                }                
                MessageBox.Show("Cập nhật quyền thành công !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CapNhatTatCaTKtheoNhom(string MaNHOM, string MaCHUCNANG, bool CoQUYEN)
        {
            try
            {
                List<string> tendn = new List<string>();
                string TenDangNhap = null, MaChucNang = null;
                bool quyenNhom;
                string sql_layTDN = "select TenDangNhap, NhomNguoiDung from QL_TaiKhoan where NhomNguoiDung='" + MaNHOM + "'";
                SqlCommand cmd_layTDN = new SqlCommand(sql_layTDN, kn);
                SqlDataReader doc = cmd_layTDN.ExecuteReader();
                while (doc.Read())
                {
                    tendn.Add(doc.GetString(0));
                }
                doc.Close();
                foreach (string item in tendn)
                {
                    TenDangNhap = item;
                    string sql_UDQuyenTKtheoNhom = "update QL_PhanQuyenTaiKhoan set Quyen='" + CoQUYEN + "' where TenDN='" + TenDangNhap + "' and MaCN='" + MaCHUCNANG + "'";
                    SqlCommand cmd_UDQuyenTKtheoNhom = new SqlCommand(sql_UDQuyenTKtheoNhom,kn);
                    cmd_UDQuyenTKtheoNhom.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuanLyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kn.State == ConnectionState.Open)
            {
                kn.Close();
            }
        }

        private void cbb_tentaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                this.phanQuyenTheoTaiKhoanTableAdapter.Fill(this.qL_TaiKhoan.PhanQuyenTheoTaiKhoan, cbb_tentaikhoan.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_luu_pqtk_Click(object sender, EventArgs e)
        {
            try
            {
                string maCN = null;
                string TenDN = cbb_tentaikhoan.SelectedValue.ToString();
                bool CoQuyen;
                int tongsodong = dgv_PhanQuyenTK.Rows.Count;
                for (int i = 0; i < tongsodong ; i++)
                {
                    maCN = dgv_PhanQuyenTK.Rows[i].Cells[0].Value.ToString();
                    CoQuyen = (bool)dgv_PhanQuyenTK.Rows[i].Cells[2].Value;
                    string sql_CNquyenTK = "update QL_PhanQuyenTaiKhoan set Quyen='"+CoQuyen+"' where TenDN='"+TenDN+"' and MaCN='"+maCN+"'";
                    SqlCommand cmd_UD = new SqlCommand(sql_CNquyenTK, kn);
                    cmd_UD.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật quyền thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CapNhatQuyenTheoNhomND(string manhom, string tendangnhap)
        {
            try
            {
                string sql_updateQuyenTheoNhomND = "select * from QL_PhanQuyen where QL_PhanQuyen.MaNhomNguoiDung='"+manhom+"'";
                SqlCommand cmdread = new SqlCommand(sql_updateQuyenTheoNhomND,kn);
                SqlDataAdapter adt = new SqlDataAdapter(cmdread);                
                DataTable table = new DataTable();
                adt.Fill(table);
                foreach (DataRow item in table.Rows)
                {
                    string sql_CNquyenTK = "update QL_PhanQuyenTaiKhoan set Quyen='" + item[2] + "' where TenDN='" + tendangnhap + "' and MaCN='" + item[1] + "'";
                    SqlCommand cmd_UD = new SqlCommand(sql_CNquyenTK, kn);
                    cmd_UD.ExecuteNonQuery();
                }
            }
             catch (Exception ex)
            {                 
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemQuyenChoNhomMoi(string maNH)
        {
            try
            {
                bool CoQuyen = false;
                string sql_maCN = "select MaChucNang from QL_ChucNang";
                SqlCommand cmd_newNhom = new SqlCommand(sql_maCN, kn);
                SqlDataReader doc = cmd_newNhom.ExecuteReader();
                while (doc.Read())
                {
                    this.qL_PhanQuyenTableAdapter.Insert(maNH, doc.GetString(0), CoQuyen);
                }
                doc.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XoaQuyenChoNhom(string maNhom)
        {
            try
            {
                string sql_laynhom = "select * from QL_PhanQuyen where MaNhomNguoiDung='"+maNhom+"'";
                SqlCommand cmd_xoaQuyen = new SqlCommand(sql_laynhom, kn);
                SqlDataReader doc = cmd_xoaQuyen.ExecuteReader();
                while (doc.Read())
                {
                    this.qL_PhanQuyenTableAdapter.Delete(doc.GetString(0), doc.GetString(1), doc.GetBoolean(2));
                }
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
    }
}
