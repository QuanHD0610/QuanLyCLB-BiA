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

namespace DoAn_QuanLyCLB_Bi_a
{
 
    public partial class form_LichSu : Form
    {

        SqlConnection connection;

        public form_LichSu()
        {
            connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
            InitializeComponent();
        }
        private void Load_dgv()
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM HoaDon,DANGKY WHERE HOADON.MADON = DANGKY.MADON";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Tạo một DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            da_LichSu.DataSource = dataTable;

            connection.Close();

        }
        private void form_LichSu_Load(object sender, EventArgs e)
        {
            Load_dgv();
        }

        private void btn_TongKet_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT SUM(TONGTIEN) AS TONGTIENNGAY FROM HOADON ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Tạo một DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            da_LichSu.DataSource = dataTable;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Thực hiện truy vấn SQL sử dụng tham số
                string query = "SELECT * FROM KHACHHANG WHERE SDT = @SDT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SDT", txtTimkiem.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                da_LichSu.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
