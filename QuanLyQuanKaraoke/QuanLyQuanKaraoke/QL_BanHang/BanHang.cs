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
using System.Runtime;

namespace QuanLyQuanKaraoke
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();          
        }

        Connection ketnoi = new Connection();
        SqlConnection kn = Connection.GetDBConnection();
        public static string _maphong;
        public static string _sdtkhachhang;
        public static string _maphucvu;
        public static bool showNutThemKhach;
        public static bool datphong;
        public static int tiencoc = 0;

        private void BanHang_Load(object sender, EventArgs e)
        {
            kn.Open();
            string s = "select * from dichvu";
            ketnoi.autoText(txtTK, kn, s, "TenDichVu");
            if (_maphucvu == null)
                lb_MaPhucVu.Text = ketnoi.TaoMaTuDong(kn, string.Empty, "hoadon", "MaHD");
            else
                lb_MaPhucVu.Text = _maphucvu;
            lb_MaPhong.Text = _maphong;
            if (showNutThemKhach)
                btnThemKhachHang.Visible = true;
            else
            {
                // trường hợp từ form trả phòng qua
                btnThemKhachHang.Visible = false;
                this.khachHang1TableAdapter.Fill(this.dataQuanLy.KhachHang1, _sdtkhachhang);
                string sql_loaddv = "select CTHD_Tam.MaDV, DichVu.TenDichVu,CTHD_Tam.SoLuong, DichVu.DonGiaBan, CTHD_Tam.DonViTinh from CTHD_Tam,DichVu where MaPV='" + _maphucvu + "' and CTHD_Tam.MaDV= DichVu.MaDV";
                SqlDataAdapter adt = new SqlDataAdapter(sql_loaddv,kn);
                DataTable table = new DataTable();
                adt.Fill(table);
                foreach (DataRow dong in table.Rows)
                {
                    int row = 0;
                    tamTinhDataGridView.Rows.Add();
                    row = tamTinhDataGridView.Rows.Count - 1;
                    tamTinhDataGridView.Rows[row].Cells[0].Value = dong[0];
                    tamTinhDataGridView.Rows[row].Cells[1].Value = dong[1];
                    tamTinhDataGridView.Rows[row].Cells[2].Value = dong[2];
                    tamTinhDataGridView.Rows[row].Cells[3].Value = dong[3];
                    tamTinhDataGridView.Rows[row].Cells[4].Value = dong[4];
                    tamTinhDataGridView.Refresh();
                }
            }
            // TODO: This line of code loads data into the 'dataQuanLy.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dataQuanLy.DichVu);      
        }

        private void dichVuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool kt= true;
                if (dataGridViewX1.Rows.Count == 0)
                    MessageBox.Show("Bạn phải thêm khách hàng trước !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (dichVuDataGridView.CurrentRow.Cells[3].Value.ToString() == "")
                        MessageBox.Show("Mặt hàng này chưa có giá bán. Bạn cần cập nhật giá bán trước!","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else
                    {
                        int index = dichVuDataGridView.CurrentCell.RowIndex;
                        int sltru = Int32.Parse(dichVuDataGridView.Rows[index].Cells[2].Value.ToString());
                        if (sltru == 0)
                        {
                            MessageBox.Show("Số lượng trong kho không đủ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sltru--;
                            dichVuDataGridView.Rows[index].Cells[2].Value = sltru;
                            for (int i = 0; i < tamTinhDataGridView.Rows.Count; i++)
                            {
                                if (dichVuDataGridView.Rows[index].Cells[0].Value.ToString() == tamTinhDataGridView.Rows[i].Cells[0].Value.ToString())
                                {
                                    int slcong = Int32.Parse(tamTinhDataGridView.Rows[i].Cells[2].Value.ToString());
                                    slcong++;
                                    tamTinhDataGridView.Rows[i].Cells[2].Value = slcong;
                                    kt = false;
                                    break;
                                }
                            }
                            if (kt)
                            {
                                int row = 0;
                                tamTinhDataGridView.Rows.Add();
                                row = tamTinhDataGridView.Rows.Count - 1;
                                tamTinhDataGridView.Rows[row].Cells[0].Value = dichVuDataGridView.Rows[index].Cells[0].Value.ToString();
                                tamTinhDataGridView.Rows[row].Cells[1].Value = dichVuDataGridView.Rows[index].Cells[1].Value.ToString();
                                tamTinhDataGridView.Rows[row].Cells[2].Value = 1;
                                tamTinhDataGridView.Rows[row].Cells[3].Value = dichVuDataGridView.Rows[index].Cells[3].Value.ToString();
                                tamTinhDataGridView.Rows[row].Cells[4].Value = dichVuDataGridView.Rows[index].Cells[4].Value.ToString();
                                tamTinhDataGridView.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (showNutThemKhach || datphong)
                {
                    if (kn.State == ConnectionState.Closed)
                        kn.Open();
                    //cập nhật tình trạng
                    string updatephong = "update phong set tinhtrang=N'Đang Hát' where maphong='" + _maphong + "'";
                    SqlCommand cnPhong = new SqlCommand(updatephong, kn);
                    cnPhong.ExecuteNonQuery();
                    //lưu hóa đơn tạm
                    hoaDon_TamTableAdapter.Insert(lb_MaPhucVu.Text, lb_MaPhong.Text, dataGridViewX1.Rows[0].Cells[1].Value.ToString(), DateTime.Now,tiencoc);
                    //lưu CTHD_Tạm
                    for (int i = 0; i < tamTinhDataGridView.Rows.Count; i++)
                    {
                        cTHD_TamTableAdapter.Insert(lb_MaPhucVu.Text, tamTinhDataGridView.Rows[i].Cells[0].Value.ToString(), Int32.Parse(tamTinhDataGridView.Rows[i].Cells[2].Value.ToString()), tamTinhDataGridView.Rows[i].Cells[4].Value.ToString());
                    }
                    // cập nhật số lượng trong kho
                    for (int i = 0; i < dichVuDataGridView.Rows.Count; i++)
                    {
                        string sql_UDsl = "update DichVu set SoLuong=" + Int32.Parse(dichVuDataGridView.Rows[i].Cells[2].Value.ToString()) + " where MaDV='" + dichVuDataGridView.Rows[i].Cells[0].Value.ToString() + "'";
                        SqlCommand cmd_UDsl = new SqlCommand(sql_UDsl, kn);
                        cmd_UDsl.ExecuteNonQuery();
                    }
                    this.Close();
                }
                else
                {
                    //lưu CTHD_Tạm
                    if (kn.State == ConnectionState.Closed)
                        kn.Open();
                    for (int i = 0; i < tamTinhDataGridView.Rows.Count; i++)
                    {
                        try
                        {
                            cTHD_TamTableAdapter.Insert(lb_MaPhucVu.Text, tamTinhDataGridView.Rows[i].Cells[0].Value.ToString(), Int32.Parse(tamTinhDataGridView.Rows[i].Cells[2].Value.ToString()), tamTinhDataGridView.Rows[i].Cells[4].Value.ToString());
                        }
                        catch
                        {
                            string sql_UDslmoi = "update CTHD_Tam set SoLuong=" + Int32.Parse(tamTinhDataGridView.Rows[i].Cells[2].Value.ToString()) + " where MaPV='" + lb_MaPhucVu.Text + "' and MaDV='" + tamTinhDataGridView.Rows[i].Cells[0].Value.ToString() + "'";
                            SqlCommand cmd_UDslmoi = new SqlCommand(sql_UDslmoi, kn);
                            cmd_UDslmoi.ExecuteNonQuery();
                        }
                    }

                    // cập nhật số lượng trong kho
                    for (int i = 0; i < dichVuDataGridView.Rows.Count; i++)
                    {
                        string sql_UDsl = "update DichVu set SoLuong=" + Int32.Parse(dichVuDataGridView.Rows[i].Cells[2].Value.ToString()) + " where MaDV='" + dichVuDataGridView.Rows[i].Cells[0].Value.ToString() + "'";
                        SqlCommand cmd_UDsl = new SqlCommand(sql_UDsl, kn);
                        cmd_UDsl.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            kn.Close();
            if (datphong)
            {

            }
            else
            {
                if (showNutThemKhach)
                {
                    FormMain fm = new FormMain();
                    fm.Show();
                }
                else
                {
                    TraPhong tp = new TraPhong();
                    tp.Show();
                }
            }
            _maphong = null;
            _sdtkhachhang = null;
            _maphucvu = null;
            tiencoc = 0;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "")
            {
                string tk = "select*from dichvu where TenDichVu like N'%" + txtTK.Text + "%'";
                //string tk = "select * from dichvu where tendichvu =N'" + txtTK.Text + "'";
                SqlCommand cmd = new SqlCommand(tk, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                dichVuDataGridView.DataSource = table;
            }
            else
            {
                string tk = "select * from dichvu";
                SqlCommand cmd = new SqlCommand(tk, kn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();//tạo bảng ảo trong hệ thống
                com.Fill(table);// đổ dữ liệu vào bảng ảo
                dichVuDataGridView.DataSource = table;
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang.showNutThemVaoPhong = true;            
            KhachHang kh = new KhachHang();            
            kh.ShowDialog();
            this.Show();
            if (_sdtkhachhang != null)
            {
                this.khachHang1TableAdapter.Fill(this.dataQuanLy.KhachHang1, _sdtkhachhang);
            }
        }

        private void tamTinhDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = tamTinhDataGridView.CurrentCell.RowIndex;
                int sltru = Int32.Parse(tamTinhDataGridView.Rows[index].Cells[2].Value.ToString());
                sltru--;
                if (sltru == 0)
                {
                    tamTinhDataGridView.Rows[index].Cells[2].Value = sltru;
                    for (int i = 0; i < dichVuDataGridView.Rows.Count; i++)
                    {
                        if (tamTinhDataGridView.Rows[index].Cells[0].Value.ToString() == dichVuDataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(dichVuDataGridView.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            dichVuDataGridView.Rows[i].Cells[2].Value = slcong;
                            break;
                        }
                    }
                    tamTinhDataGridView.Rows.RemoveAt(index);
                }
                else
                {
                    tamTinhDataGridView.Rows[index].Cells[2].Value = sltru;
                    for (int i = 0; i < dichVuDataGridView.Rows.Count; i++)
                    {
                        if (tamTinhDataGridView.Rows[index].Cells[0].Value.ToString() == dichVuDataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(dichVuDataGridView.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            dichVuDataGridView.Rows[i].Cells[2].Value = slcong;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
