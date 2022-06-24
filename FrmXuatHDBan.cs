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
    
    public partial class frmXuatHoaDonBan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql;
        string constr = "Data Source=DESKTOP-744AGTM;Initial Catalog=QLNT;Integrated Security=True";
        public frmXuatHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(constr);

            sql = "Select * from CTHDBan left outer join Thuoc on CTHDBan.Mathuoc=Thuoc.Mathuoc left outer join HDBan on CTHDBan.SoHDB=HDBan.SoHDB left outer join KH on HDBan.MaKH = KH.MaKH left outer join NV on HDBan.MaNV = NV.MaNV where CTHDBan.SoHDB = N'"+ FrmHDBan.MaHD +"' ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

            conn.Close();
            conn.Dispose();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
