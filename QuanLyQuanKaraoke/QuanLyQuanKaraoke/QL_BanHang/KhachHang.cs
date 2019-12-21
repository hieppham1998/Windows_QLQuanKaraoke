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
    public partial class KhachHang : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        string maphong;

        public static bool showNutThemVaoPhong;

        public KhachHang()
        {
            InitializeComponent();
        }

        Connection ketnoi = new Connection();
        SqlConnection kn = Connection.GetDBConnection();
        bool KT_sdt = false;

        private void KhachHang_Load(object sender, EventArgs e)
        {
            btnThem.Visible = showNutThemVaoPhong;
            txtTimKiem.Focus();
            kn.Open();
            string s = "select * from khachhang";
            ketnoi.autoText(txtTimKiem, kn,s,"sdt","TenKH");
            // TODO: This line of code loads data into the 'dataQuanLy.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dataQuanLy.KhachHang);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text=="")
            {
                string kh = "select * from khachhang";
                SqlCommand cmd = new SqlCommand(kh, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                dgv_KhachHang.DataSource = table;
            }
            else
            {
                string kh = "select*from khachhang where sdt='"+txtTimKiem.Text+"' or TenKH=N'"+txtTimKiem.Text+"'";
                SqlCommand cmd= new SqlCommand(kh, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                dgv_KhachHang.DataSource = table;
                if (table.Rows.Count == 0)
                {
                    DialogResult r = MessageBox.Show("Khách hàng này không tồn tại, bạn có muốn thêm khách hàng này vào hệ thống !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        KT_sdt = true;
                        btnThemKH_Click(sender, e);
                        KT_sdt = false;
                    }
                }
            }
        }
        string ten;
        string sdt;
        string diem;
       
        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_KhachHang.CurrentCell.RowIndex;
            ten = dgv_KhachHang.Rows[i].Cells[1].Value.ToString();
            sdt = dgv_KhachHang.Rows[i].Cells[0].Value.ToString();
            diem = dgv_KhachHang.Rows[i].Cells[2].Value.ToString();
            khachHang1TableAdapter.Fill(this.dataQuanLy.KhachHang1, sdt);
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = dgv_KhachHang.CurrentCell.RowIndex;
            //BanHang bh = new BanHang();
            BanHang._sdtkhachhang = dgv_KhachHang.Rows[i].Cells[1].Value.ToString();
            this.Close();
            //bh.Show();
        }

        private void xuly_EnableThem(bool KieuNhap, bool KieuNut)
        {
            dgv_KhachHang.Enabled = KieuNut;
            txtTimKiem.Enabled = KieuNut;
            txtSDT.Enabled = KieuNhap;
            txtTenKhach.Enabled = KieuNhap;            
            btn_SuaKH.Enabled = KieuNut;
            btnTK.Enabled = KieuNut;
            btnThem.Enabled = KieuNut;
        }

        private void xuly_EnableSua(bool KieuNhap, bool KieuNut)
        {
            txtTenKhach.Enabled = KieuNhap;
            txtDiemTichLuy.Enabled = KieuNhap;
            dgv_KhachHang.Enabled = KieuNut;
            txtTimKiem.Enabled = KieuNut;
            btnThemKH.Enabled = KieuNut;
            btnTK.Enabled = KieuNut;
            btnThem.Enabled = KieuNut;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Thêm")
            {
                if (KT_sdt == true)
                    txtSDT.Text = txtTimKiem.Text;
                else
                    txtSDT.Clear();
                txtTenKhach.Clear();
                txtDiemTichLuy.Text = "0";
                btnThemKH.Text = "Lưu";
                xuly_EnableThem(true,false);
                btnThemKH.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
            }
            else
            {
                if (KiemTraTrong_KH())
                {
                    btnThemKH.Text = "Thêm";
                    xuly_EnableThem(false, true);
                    btnThemKH.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
                    string them = "insert into khachhang values(N'" + txtTenKhach.Text + "','" + txtSDT.Text + "','0')";
                    SqlCommand cmd = new SqlCommand(them, kn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.khachHangTableAdapter.Fill(this.dataQuanLy.KhachHang);
                    btnTK_Click(sender, e);
                }
            }
        }

        private void btn_SuaDTL_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_SuaKH.Text == "Sửa")
                {
                    btn_SuaKH.Text = "Lưu";
                    xuly_EnableSua(true, false);
                    btn_SuaKH.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                }
                else
                {
                    if (KiemTraTrong_KH())
                    {
                        btn_SuaKH.Text = "Sửa";
                        xuly_EnableSua(false, true);
                        btn_SuaKH.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
                        string sua = "update KhachHang set TenKH=N'" + txtTenKhach.Text + "', TichDiem='" + txtDiemTichLuy.Text + "' where SDT='" + txtSDT.Text + "'";
                        SqlCommand cmd = new SqlCommand(sua, kn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.khachHangTableAdapter.Fill(this.dataQuanLy.KhachHang);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTrong_KH()
        {
            if (string.IsNullOrEmpty(this.txtSDT.Text))
            {
                MessageBox.Show("Không được bỏ trống số điện thoại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtTenKhach.Text))
            {
                MessageBox.Show("Không được bỏ trống họ tên khách hàng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenKhach.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDiemTichLuy.Text))
            {
                MessageBox.Show("Không được bỏ trống điểm tích lũy !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDiemTichLuy.Focus();
                return false;
            }
            return true;
        }

        private void KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10 || txtSDT.Text.Substring(0, 1) != "0")
            {
                MessageBox.Show("Số điện thoại phải bắt đầu từ 0 và có 10 chữ số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


      
    }
}
