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
    public partial class SoLuongTB : Form
    {
        public string maphong;
        public string mathietbi;
        public string soluong;
        public SoLuongTB()
        {
            InitializeComponent();
        }
        public SoLuongTB(string map, string matb,string sl):this()
        {
            maphong = map;
            mathietbi = matb;
            soluong = sl;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = Connection.GetDBConnection();
            conn.Open();
            if (rdSL.Checked == true)
            {
                if (int.Parse(soluong) > int.Parse(nbSL.Value.ToString()))
                {
                    string updateP = "update thietbi_phong set soluong=soluong-"+int.Parse(nbSL.Value.ToString())+" where mathietbi='"+mathietbi+"' and maphong='"+maphong+"'";
                    SqlCommand cmd_P = new SqlCommand(updateP, conn);
                    cmd_P.ExecuteNonQuery();
                    string update1 = "update thietbi set soluong=soluong+" + int.Parse(nbSL.Value.ToString()) + " where mathietbi='" + mathietbi + "'";
                    SqlCommand cmd_UP1 = new SqlCommand(update1, conn);
                    cmd_UP1.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa " + nbSL.Value.ToString() + " thiết bị ra khỏi phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(int.Parse(soluong)<int.Parse(nbSL.Value.ToString())){
                    MessageBox.Show("Số lượng bạn chọn lớn hơn số lượng có","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                          if(int.Parse(soluong)==int.Parse(nbSL.Value.ToString()))
                          {
                            string deleteTB1 = "delete from thietbi_phong where maphong='" + maphong + "' and mathietbi='" + mathietbi + "'";
                            SqlCommand cmd = new SqlCommand(deleteTB1, conn);
                            cmd.ExecuteNonQuery();
                            string update2 = "update thietbi set soluong=soluong+" + int.Parse(soluong) + " where mathietbi='" + mathietbi + "'";
                            SqlCommand cmd_UP2 = new SqlCommand(update2, conn);
                            cmd_UP2.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa thiết bị ra khỏi phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                   }
                }
            }
           if(rdTatCa.Checked==true)
            {
                string deleteTB = "delete from thietbi_phong where maphong='" + maphong + "' and mathietbi='" + mathietbi + "'";
                SqlCommand cmd = new SqlCommand(deleteTB, conn);
                cmd.ExecuteNonQuery();
                string update = "update thietbi set soluong=soluong+" + int.Parse(soluong) + " where mathietbi='" + mathietbi + "'";
                SqlCommand cmd_UP = new SqlCommand(update, conn);
                cmd_UP.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thiết bị ra khỏi phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
