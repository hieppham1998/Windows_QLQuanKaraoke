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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
            autoText();
        }

        Connection ketnoi = new Connection();

        void autoText()
        {
            txtTK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTK.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                string s = "select * from datphong";
                SqlCommand cmd = new SqlCommand(s, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //String ten = rd.GetString("TENKH");
                    coll.Add(rd["sdt_khach"].ToString());
                }
                txtTK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTK.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTK.AutoCompleteCustomSource = coll;

            }
            catch { MessageBox.Show("Lỗi"); }

        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            Connection kn = new Connection();
            conn = Connection.GetDBConnection();
            conn.Open();
            try
            {
                string Loc_KH = "select*from datphong where sdt_khach like N'%" + txtTK.Text + "%'";
                SqlCommand cmd = new SqlCommand(Loc_KH, conn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                dataDatPhong.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin khách");
            }
        }

        private void btnNhanPhong_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            Connection kn = new Connection();
            conn = Connection.GetDBConnection();
            conn.Open();

            string sql_tinhtrang = "select TinhTrang from Phong where MaPhong='" + dataDatPhong.CurrentRow.Cells[1].Value.ToString() + "'";
            SqlCommand cmd_tinhtrang = new SqlCommand(sql_tinhtrang, conn);
            string tinhtrang = cmd_tinhtrang.ExecuteScalar().ToString();
            if (tinhtrang == "Bảo Trì")
            {
                MessageBox.Show("Phòng " + dataDatPhong.CurrentRow.Cells[1].Value.ToString() + " đang được bảo trì. Bạn không thể nhận phòng này!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tinhtrang == "Đang Dọn")
                {
                    MessageBox.Show("Phòng " + dataDatPhong.CurrentRow.Cells[1].Value.ToString() + " đang được dọn. Bạn không thể nhận phòng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tinhtrang == "Đang Hát")
                    {
                        MessageBox.Show("Phòng " + dataDatPhong.CurrentRow.Cells[1].Value.ToString() + " đang có người hát. Bạn không thể nhận phòng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //xử lý khách hàng
                        int i = dataDatPhong.CurrentCell.RowIndex;
                        string ktra_sdt = "select * from khachhang where sdt='" + dataDatPhong.Rows[i].Cells[3].Value.ToString() + "'";
                        SqlCommand com = new SqlCommand(ktra_sdt, conn);
                        SqlDataReader dr = com.ExecuteReader();
                        if (!dr.Read())
                        {
                            khachHangTableAdapter.Insert(dataDatPhong.Rows[i].Cells[2].Value.ToString(), dataDatPhong.Rows[i].Cells[3].Value.ToString(), 0);
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();
                            string update_diem = "update khachhang set tichdiem=tichdiem+1 where sdt='" + dataDatPhong.Rows[i].Cells[3].Value.ToString() + "'";
                            SqlCommand cmd = new SqlCommand(update_diem, conn);
                            cmd.ExecuteNonQuery();
                            dr.Close();
                        }

                        BanHang.tiencoc = int.Parse(txtTienCoc.Text);

                        //xóa đặt phòng
                        string sql_xoadp = "delete from DatPhong where MaDatPhong='" + txtMaPhong.Text + "'";
                        SqlCommand cmd_xoadp = new SqlCommand(sql_xoadp, conn);
                        cmd_xoadp.ExecuteNonQuery();

                        BanHang._sdtkhachhang = dataDatPhong.Rows[i].Cells[3].Value.ToString();
                        BanHang._maphong = dataDatPhong.Rows[i].Cells[1].Value.ToString();
                        BanHang.showNutThemKhach = false;
                        BanHang bh = new BanHang();
                        BanHang.datphong = true;
                        bh.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQuanLy.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataQuanLy.Phong);
            // TODO: This line of code loads data into the 'dataQuanLy.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dataQuanLy.KhachHang);
            // TODO: This line of code loads data into the 'dataQuanLy.DatPhong' table. You can move, or remove it, as needed.
            this.datPhongTableAdapter.Fill(this.dataQuanLy.DatPhong);
            //  string ktra_phong = "delete from datphong where gionhanphong<getdate()";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection kn = Connection.GetDBConnection();
            string madat = ketnoi.TaoMaTuDong(kn, null, "DatPhong", "MaDatPhong");
            if(btnThem.Text=="Thêm")
            {
                xuly_Them(false);
                txtMaPhong.Text = madat;
                btnThem.Text = "Lưu";
                btnThem.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
                txtTenKhach.Clear();
                txtSDT.Clear();
                txtTienCoc.Clear();
                txtGhiChu.Clear();
            }
            else
            {
                if (txtMaPhong.Text.Length != 0 && txtTenKhach.Text.Length != 0 && txtTienCoc.Text.Length != 0 && txtSDT.Text.Length != 0 && txtGhiChu.Text.Length != 0)
                {
                    xuly_Them(true);
                    btnThem.Text = "Thêm";
                    txtMaPhong.Text = madat;
                    btnThem.Image = QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
                    this.datPhongTableAdapter.Insert(madat, cbbPhong.SelectedValue.ToString(), txtTenKhach.Text, txtSDT.Text, dtNgayNhanPhong.Value, int.Parse(txtTienCoc.Text), txtGhiChu.Text);
                    this.datPhongTableAdapter.Fill(this.dataQuanLy.DatPhong);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xuly_Them(bool kieu)
        {
            btnSua.Enabled = kieu;
            btnTimKiem.Enabled = kieu;
            dataDatPhong.Enabled = kieu;
            btnNhanPhong.Enabled = kieu;
            txtTK.Enabled = kieu;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length != 0 && txtTenKhach.Text.Length != 0 && txtTienCoc.Text.Length != 0 && txtSDT.Text.Length != 0 && txtGhiChu.Text.Length != 0)
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                string update = "update datphong set maphong='"+cbbPhong.SelectedValue.ToString()+"',tenkhachdat=N'"+txtTenKhach.Text+"',sdt_khach='"+txtSDT.Text+"',gionhanphong='"+dtNgayNhanPhong.Value+"' where madatphong='"+txtMaPhong.Text+"'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                this.datPhongTableAdapter.Fill(this.dataQuanLy.DatPhong);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10 || txtSDT.Text.Substring(0, 1) != "0")
            {
                MessageBox.Show("Số điện thoại phải bắt đầu từ 0 và có 10 chữ số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
            }
        }

       
    }
}
