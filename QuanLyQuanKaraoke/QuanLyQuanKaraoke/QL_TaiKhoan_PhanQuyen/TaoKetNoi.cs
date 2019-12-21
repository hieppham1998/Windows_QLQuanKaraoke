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
using System.Data.Sql;

namespace QuanLyQuanKaraoke
{
    public partial class TaoKetNoi : Form
    {
        public TaoKetNoi()
        {
            InitializeComponent();
        }

        DataTable db_server = new DataTable();

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbb_servername.Text))
            {
                MessageBox.Show("Không được bỏ trống ServerName !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbb_servername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.cbb_database.Text))
            {
                MessageBox.Show("Không được bỏ trống Database !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbb_database.Focus();
                return;
            }
            if (cbb_authentication.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(this.txtuser.Text))
                {
                    MessageBox.Show("Không được bỏ trống User ID !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtuser.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.txtpass.Text))
                {
                    MessageBox.Show("Không được bỏ trống Password !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtpass.Focus();
                    return;
                }
            }

            string strconn = "";
            if (cbb_authentication.SelectedIndex == 0)
            {
                strconn = "Data Source=" + cbb_servername.Text + ";Initial Catalog=" + cbb_database.Text + ";Integrated Security=True";
            }
            else
            {
                strconn = "Data Source=" + cbb_servername.Text + ";Initial Catalog=" + cbb_database.Text + ";User ID=" + txtuser.Text + "; Password=" + txtpass.Text + "";
            }
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                Properties.Settings.Default.strString = strconn;
                Properties.Settings.Default.Save();                
                MessageBox.Show("Kết nối thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                //DangNhap frm1 = new DangNhap();
                //frm1.Show();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Clear();
                txtpass.Clear();
                cbb_servername.Focus();
                conn.Close();
            }
        }

        private void TaoKetNoi_Load(object sender, EventArgs e)
        {
            // load Authentication
            cbb_authentication.Items.Add("Windows Athentication");
            cbb_authentication.Items.Add("SQL Server Authentication");
            cbb_authentication.SelectedIndex = 0;

            // Load Server Name
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            cbb_servername.DataSource = table;
            cbb_servername.DisplayMember = "ServerName";

            db_server = table;

            // Load Database
            cbb_database.DataSource = GetDBName(cbb_servername.Text);
            cbb_database.DisplayMember = "Name";
            cbb_database.SelectedIndex = -1;
        }

        public DataTable GetDBName(string pServer)
        {
            DataTable dt_db = new DataTable();
            int loi = 1;
            foreach(DataRow row in db_server.Rows)
            {
                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {
                    if (item.ToString() == pServer)
                    {
                        loi = 0;
                        break;
                    }  
                }             
            }
            if (loi==0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT NAME FROM sys.Databases", "Data Source =" + pServer + ";Initial Catalog=master; Integrated Security=True");
                da.Fill(dt_db);
            }
            else
            {
                MessageBox.Show("ServerName không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt_db;
        }

        private void cbb_authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_authentication.SelectedIndex == 0)
            {
                txtuser.Enabled = false;
                txtpass.Enabled = false;
            }
            else
            {
                txtuser.Enabled = true;
                txtpass.Enabled = true;
            }
        }

        private void cbb_servername_Leave(object sender, EventArgs e)
        {
            // Load Database
            cbb_database.DataSource = GetDBName(cbb_servername.Text);
            cbb_database.DisplayMember = "Name";
            cbb_database.SelectedIndex = -1;
        }


    }
}
