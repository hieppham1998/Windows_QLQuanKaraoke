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
    public partial class NhapKho_TB : Form
    {
        public NhapKho_TB()
        {
            InitializeComponent();
        }

        SqlConnection kn = Connection.GetDBConnection();
        Connection ketnoi = new Connection();
        public static string MaNV;
        float ThanhTienXoa;

        private void txt_tentb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txt_tentb.Text))
                {
                    MessageBox.Show("Không được bỏ trống tên thiết bị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (kn.State == ConnectionState.Closed)
                        kn.Open();
                    string sql_layma = "select MaThietBi from ThietBi where TenThietBi=N'" + txt_tentb .Text+ "'";
                    SqlCommand cmd_layma = new SqlCommand(sql_layma, kn);
                    txt_matb.Text = cmd_layma.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                DialogResult r = MessageBox.Show("Thiết bị này chưa có trong kho! Bạn phải thêm vào kho trước", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    ThemThietBi themtb = new ThemThietBi();
                    themtb.ShowDialog();
                    // gọi lại autoText
                    string s = "select * from ThietBi";
                    ketnoi.autoText(txt_tentb, kn, s, "TenThietBi");
                    txt_tentb.Focus();
                }
            }
        }

        private void NhapKho_TB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTS_QL_NhanVien.CTPN_ThietBi' table. You can move, or remove it, as needed.
            this.cTPN_ThietBiTableAdapter.Fill(this.dTS_QL_NhanVien.CTPN_ThietBi);
            // TODO: This line of code loads data into the 'dTS_QL_NhanVien.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dTS_QL_NhanVien.PhieuNhap);
            kn.Open();
            string s = "select * from ThietBi";
            ketnoi.autoText(txt_tentb, kn, s, "TenThietBi");            
            DTI_ngaynhap.Value = DateTime.Now.Date;
            txt_manv.Text = MaNV;
            txt_mapn.Text = ketnoi.TaoMaTuDong(kn, "TB", "PhieuNhap", "MaPhieNhap");
            btn_LuuPN.Enabled = false;
        }

        private void btn_themchitiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTrong())
                {
                    if (KiemTraTrungMa())
                    {
                        int row = 0;
                        dgv_chitietnhap.Rows.Add();
                        row = dgv_chitietnhap.Rows.Count - 1;
                        dgv_chitietnhap.Rows[row].Cells[0].Value = txt_matb.Text;
                        dgv_chitietnhap.Rows[row].Cells[1].Value = txt_tentb.Text;
                        dgv_chitietnhap.Rows[row].Cells[2].Value = txt_sln.Text;
                        dgv_chitietnhap.Rows[row].Cells[3].Value = txt_dgn.Text;                        
                        dgv_chitietnhap.Rows[row].Cells[4].Value = (double)(Int32.Parse(txt_sln.Text) * float.Parse(txt_dgn.Text));
                        dgv_chitietnhap.Refresh();
                        // clear textbox
                        txt_matb.Clear();
                        txt_tentb.Clear();
                        txt_sln.Clear();
                        txt_dgn.Clear();                        
                    }
                    else
                        MessageBox.Show("Thiết bị này đã tồn tại trong chi tiết !", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTrong()
        {
            if (string.IsNullOrEmpty(this.txt_matb.Text))
            {
                MessageBox.Show("Mã thiết bị không hợp lệ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_tentb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_tentb.Text))
            {
                MessageBox.Show("Không được bỏ trống tên thiết bị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_tentb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_sln.Text))
            {
                MessageBox.Show("Không được bỏ trống số lượng nhập !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_sln.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_dgn.Text))
            {
                MessageBox.Show("Không được bỏ trống đơn giá nhập !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dgn.Focus();
                return false;
            }
            return true;
        }

        private bool KiemTraTrungMa()
        {
            for (int i = 0; i < dgv_chitietnhap.Rows.Count; i++)
            {
                if (txt_matb.Text == dgv_chitietnhap.Rows[i].Cells[0].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_suachitiet_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                //if (KiemTraTrungMa())
                {
                    int vt = dgv_chitietnhap.CurrentCell.RowIndex;
                    dgv_chitietnhap.Rows[vt].Cells[0].Value = txt_matb.Text;
                    dgv_chitietnhap.Rows[vt].Cells[1].Value = txt_tentb.Text;
                    dgv_chitietnhap.Rows[vt].Cells[2].Value = txt_sln.Text;
                    dgv_chitietnhap.Rows[vt].Cells[3].Value = txt_dgn.Text;                    
                    dgv_chitietnhap.Rows[vt].Cells[4].Value = (double)(Int32.Parse(txt_sln.Text) * float.Parse(txt_dgn.Text));
                    dgv_chitietnhap.Refresh();
                }
                //else
                //    MessageBox.Show("Mặt hàng này đã tồn tại !","Thống Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_xoachitiet_Click(object sender, EventArgs e)
        {
            int vt = dgv_chitietnhap.CurrentCell.RowIndex;
            ThanhTienXoa =float.Parse(dgv_chitietnhap.Rows[vt].Cells[4].Value.ToString());
            dgv_chitietnhap.Rows.RemoveAt(vt);            
        }

        private void dgv_chitietnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_chitietnhap.CurrentCell.RowIndex;
            txt_matb.Text = dgv_chitietnhap.Rows[vt].Cells[0].Value.ToString();
            txt_tentb.Text = dgv_chitietnhap.Rows[vt].Cells[1].Value.ToString();
            txt_sln.Text = dgv_chitietnhap.Rows[vt].Cells[2].Value.ToString();
            txt_dgn.Text = dgv_chitietnhap.Rows[vt].Cells[3].Value.ToString();            
        }

        private void dgv_chitietnhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_chitietnhap.Rows.Count > 0)
            {
                double? tongtien = 0;
                for (int i = 0; i < dgv_chitietnhap.Rows.Count; i++)
                {
                    tongtien += (double?)dgv_chitietnhap.Rows[i].Cells[4].Value;
                }
                if (tongtien == null)
                    txt_tongpn.Text = "0";
                else
                    txt_tongpn.Text = tongtien.ToString();
            }
        }

        private void btn_LuuPN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn lưu phiếu nhập !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    // thêm vào bảng Phiếu Nhập với mã DV
                    phieuNhapTableAdapter.Insert(txt_mapn.Text, txt_manv.Text, DTI_ngaynhap.Value, float.Parse(txt_tongpn.Text));
                    // thêm vào bảng Chi Tiết Phiếu Nhập DV
                    for (int i = 0; i < dgv_chitietnhap.Rows.Count; i++)
                    {
                        string matbdgv = dgv_chitietnhap.Rows[i].Cells[0].Value.ToString();
                        int slndgv = Int32.Parse(dgv_chitietnhap.Rows[i].Cells[2].Value.ToString());
                        float dgndgv = float.Parse(dgv_chitietnhap.Rows[i].Cells[3].Value.ToString());
                        cTPN_ThietBiTableAdapter.Insert(txt_mapn.Text, matbdgv, slndgv, dgndgv);                            
                        // cập nhật số lượng mặt hàng trong kho Dịch Vụ
                            //lấy số lượng đang có trong kho
                        string sql_slcu = "select SoLuong from ThietBi where MaThietBi='" + matbdgv + "'";
                        SqlCommand cmd_slcu = new SqlCommand(sql_slcu, kn);
                        int slcu = Int32.Parse(cmd_slcu.ExecuteScalar().ToString());
                        int slmoi = slcu + slndgv;
                            //cập nhật số lượng mới
                        string sql_UDsoluong = "update ThietBi set SoLuong="+slmoi+" where MaThietBi='"+matbdgv+"'";
                        SqlCommand cmd_UDsoluong = new SqlCommand(sql_UDsoluong, kn);
                        cmd_UDsoluong.ExecuteNonQuery();
                    }
                    MessageBox.Show("Lưu phiếu nhập thiết bị thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_chitietnhap_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float tongUD = float.Parse(txt_tongpn.Text) - ThanhTienXoa;
            txt_tongpn.Text = tongUD.ToString();
            if (dgv_chitietnhap.Rows.Count > 0)
                btn_LuuPN.Enabled = true;
            else
                btn_LuuPN.Enabled = false;
        }

        private void dgv_chitietnhap_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_chitietnhap.Rows.Count > 0)
                btn_LuuPN.Enabled = true;
            else
                btn_LuuPN.Enabled = false;
        }

        private void txt_sln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        //=====================================
    }
}
