using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyQuanKaraoke
{
    class Connection
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.strString);
            return conn;
        }

        public void autoText(TextBox txt, SqlConnection conn, string sql, string thamso1)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    coll.Add(rd[thamso1].ToString());
                }
                rd.Close();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = coll;
            }
            catch 
            {
                MessageBox.Show("Lỗi tìm kiếm"); 
            }
        }

        public void autoText(TextBox txt, SqlConnection conn, string sql, string thamso1, string thamso2)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    coll.Add(rd[thamso1].ToString());
                    coll.Add(rd[thamso2].ToString());
                }
                rd.Close();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = coll;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
            }
        }

        public void autoText(TextBox txt, SqlConnection conn, string sql, string thamso1, string thamso2, string thamso3)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    coll.Add(rd[thamso1].ToString());
                    coll.Add(rd[thamso2].ToString());
                    coll.Add(rd[thamso3].ToString());
                }
                rd.Close();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = coll;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
            }
        }

        string ma;
        public string TaoMaTuDong(SqlConnection conn,string kytuboxung, string bang, string cot)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            ma = TaoMaRandom();
            string MaMoi = kytuboxung + ma;
            string sql = "select * from "+bang+" where "+cot+"='"+MaMoi+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read() == true)
            {
                dtr.Close();
                TaoMaTuDong(conn, kytuboxung, bang, cot);
                break;
            }
            conn.Close();
            return MaMoi;            
        }

        private string TaoMaRandom()
        {
            Random rd = new Random();
            string mard = "";
            for (int i = 0; i < 8; i++)
            {
                int chon = rd.Next(1, 4);
                if (chon == 3)
                {
                    string chuhoa = Convert.ToString((char)rd.Next(65, 91));
                    mard = mard + chuhoa;
                }
                if (chon == 2)
                {
                    string chuthuong = Convert.ToString((char)rd.Next(97, 123));
                    mard = mard + chuthuong;
                }
                if (chon == 1)
                {
                    string so = rd.Next(0, 10).ToString();
                    mard = mard + so;
                }
            }
            return mard;
        }

    }
}
