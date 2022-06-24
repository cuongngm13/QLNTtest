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
    public partial class FrmHDBan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public static string MaHD;
        //int i;
        public FrmHDBan()
        {
            InitializeComponent();
        }

        private void dtgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int line;
            line = dtgHoaDon.CurrentRow.Index;

            txtHD.Text = dtgHoaDon[0, line].Value.ToString();
            txtKH.Text = dtgHoaDon[2, line].Value.ToString();
            dtpHD.Value = DateTime.Parse(dtgHoaDon[4, line].Value.ToString());
            conn = new SqlConnection(constr);
            sql = "Select HDBan.SoHDB as 'Mã HD', Tenthuoc as 'Tên thuốc', SLB as 'Số lượng', Giaban as 'Đơn giá', Tongtien as 'Thành tiền' From HDBan inner join CTHDBan on HDBan.SoHDB=CTHDBan.SoHDB inner join Thuoc on CTHDBan.Mathuoc=Thuoc.Mathuoc where HDBan.SoHDB = N'"+ dtgHoaDon[0,line].Value.ToString() +"'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dtgCTHD.DataSource = dt;

            conn.Close();
            conn.Dispose();
        }

   

        private void Form2_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-744AGTM;Initial Catalog=QLNT;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select SoHDB, HDBan.MaKH, TenKH, TenNV, Ngayban From HDBan inner join KH on HDBan.MaKH = Kh.MaKH inner join NV on HDBan.MaNV = NV.MaNV ";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            dtgHoaDon.DataSource = dt;

            conn.Close();
            conn.Dispose();
        }

        private void dtgCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int line;
            line = dtgCTHD.CurrentRow.Index;

            txtTenthuoc.Text = dtgCTHD[1, line].Value.ToString();
            txtSLg.Text = dtgCTHD[2, line].Value.ToString();
            txtDonGia.Text = dtgCTHD[3, line].Value.ToString();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            MaHD = txtHD.Text;
            frmXuatHoaDonBan f = new frmXuatHoaDonBan();
            f.Show();
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
