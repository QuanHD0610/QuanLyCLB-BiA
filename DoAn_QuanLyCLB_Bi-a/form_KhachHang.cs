using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_QuanLyCLB_Bi_a
{
    public partial class form_KhachHang : Form
    {
        SqlConnection connection;
        public form_KhachHang()
        {
            connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
            InitializeComponent();
        }
        private void Load_dgv()
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM khachhang";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Tạo một DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            da_KhachHang.DataSource = dataTable;

            connection.Close();

        }
        private void form_KhachHang_Load(object sender, EventArgs e)
        {
            Load_dgv();
        }
    }
}
