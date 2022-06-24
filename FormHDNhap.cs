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
    public partial class FormHDNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public static string MaHD;

        public FormHDNhap()
        {
            InitializeComponent();
        }

        
        private void FormHDNhap_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-744AGTM;Initial Catalog=QLNT;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select SoHDN, HDNhap.MaNCC, TenNCC, TenNV, Ngaynhap From HDNhap inner join NCC on HDNhap.MaNCC = NCC.MaNCC inner join NV on HDNhap.MaNV = NV.MaNV ";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgHDN.DataSource = dt;

            conn.Close();
            conn.Dispose();
        }

        private void dtgHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int line;
            line = dtgHDN.CurrentRow.Index;
      
            txtMaHD.Text = dtgHDN[0, line].Value.ToString();
            txtNCC.Text = dtgHDN[2, line].Value.ToString();
            dtpNgayHD.Value = DateTime.Parse(dtgHDN[4, line].Value.ToString());
            conn = new SqlConnection(constr);
            sql = "Select HDNhap.SoHDN as 'Mã HD', Tenthuoc as 'Tên thuốc', SLN as 'Số lượng', Giavon as 'Đơn giá', Tongtien as 'Thành tiền' From HDNhap inner join CTHDNhap on HDNhap.SoHDN = CTHDNhap.SoHDN inner join Thuoc on CTHDNhap.Mathuoc=Thuoc.Mathuoc where HDNhap.SoHDN = N'" + dtgHDN[0, line].Value.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dtgCTHD.DataSource = dt;

            conn.Close();
            conn.Dispose();
        }


        private void dtgCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int line;
            line = dtgCTHD.CurrentRow.Index;

            txtThuoc.Text = dtgCTHD[1, line].Value.ToString();
            txtSL.Text = dtgCTHD[2, line].Value.ToString();
            txtDonGia.Text = dtgCTHD[3, line].Value.ToString();
        }


        private void btnIN_Click(object sender, EventArgs e)
        {
            MaHD = txtMaHD.Text;
            FormXuatHoaDonNhap f = new FormXuatHoaDonNhap();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
