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
using QuanLyQuanKaraoke.Phong_QLPhong;

namespace QuanLyQuanKaraoke
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
            autoText();
        }
        void autoText()
        {
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                SqlConnection conn = new SqlConnection();
                Connection kn = new Connection();
                conn = Connection.GetDBConnection();
                conn.Open();
                string s = "select * from phong";
                SqlCommand cmd = new SqlCommand(s, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //String ten = rd.GetString("TENKH");
                    coll.Add(rd["maphong"].ToString());
                }
                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTimKiem.AutoCompleteCustomSource = coll;

            }
            catch { MessageBox.Show("Lỗi"); }
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQuanLy.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.dataQuanLy.LoaiPhong);
            // TODO: This line of code loads data into the 'dataQuanLy.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataQuanLy.Phong);
            cbbLoai.SelectedIndex = 0;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhong.Text.Length != 0 || txtDonGia.Text.Length != 0)
                {

                    LINQDataContext linq = new LINQDataContext();
                    Phong _phong = new Phong();
                    _phong.MaPhong = txtMaPhong.Text;
                    _phong.MaLoaiPhong = cbbLoai.SelectedValue.ToString();
                    _phong.GiaPhong = int.Parse(txtDonGia.Text);
                    _phong.TinhTrang = "Trống";
                    linq.Phongs.InsertOnSubmit(_phong);
                    linq.SubmitChanges();
                    this.phongTableAdapter.Fill(this.dataQuanLy.Phong);
                    MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Phòng đã tồn tại bạn không thể thêm !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataPhong_Click(object sender, EventArgs e)
        {
            binding();
        }

        private void binding()
        {
            int i = dataPhong.CurrentRow.Index;
            txtMaPhong.Text = dataPhong.Rows[i].Cells[0].Value.ToString();
            cbbLoai.SelectedValue = dataPhong.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dataPhong.Rows[i].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhong.Text.Length != 0 || txtDonGia.Text.Length != 0)
                {
                    LINQDataContext linq = new LINQDataContext();
                    Phong _phong = linq.Phongs.Where(p => p.MaPhong == txtMaPhong.Text).FirstOrDefault();
                    if (_phong != null)
                    {
                        _phong.MaLoaiPhong = cbbLoai.SelectedValue.ToString();
                        _phong.GiaPhong = int.Parse(txtDonGia.Text);
                        linq.SubmitChanges();
                        this.phongTableAdapter.Fill(this.dataQuanLy.Phong);
                        MessageBox.Show("Sửa phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Phòng đã tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LINQDataContext linq = new LINQDataContext();
            if (txtTimKiem.Text.Length != 0)
            {
                var phonghat = from p in linq.Phongs where p.MaPhong == txtTimKiem.Text select p;
                dataPhong.DataSource = phonghat;
            }
            else
            {
                var phonghat = from p in linq.Phongs select p;
                dataPhong.DataSource = phonghat;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
