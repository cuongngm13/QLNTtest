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

namespace QLNTtest
{
    public partial class FormXuatHoaDonNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql;
        string constr = "Data Source=DESKTOP-744AGTM;Initial Catalog=QLNT;Integrated Security=True";
        public FormXuatHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormXuatHoaDonNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);

            sql = "Select * from CTHDNhap left outer join Thuoc on CTHDNhap.Mathuoc=Thuoc.Mathuoc left outer join HDNhap on CTHDNhap.SoHDN=HDNhap.SoHDN left outer join NCC on HDNhap.MaNCC = NCC.MaNCC left outer join NV on HDNhap.MaNCC = NV.MaNV where CTHDNhap.SoHDN = N'" + FormHDNhap.MaHD + "' ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

            conn.Close();
            conn.Dispose();
        }
    }
}
