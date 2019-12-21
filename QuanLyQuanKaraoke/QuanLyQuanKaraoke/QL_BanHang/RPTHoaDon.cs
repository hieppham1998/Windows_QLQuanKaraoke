using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.QL_BanHang
{
    public partial class RPTHoaDon : Form
    {
        public RPTHoaDon()
        {
            InitializeComponent();
        }
        public string map;

        public RPTHoaDon(string ma)
            : this()
        {
            map = ma;

        }
        private void RPTHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon rpt = new HoaDon();
            rpt.SetParameterValue("MaHoaDon", map);

            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.Refresh();
        }
    }
}
