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

namespace DoAn_QuanLyCLB_Bi_a
{

    public partial class form_HoaDon : Form
    {
        // SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        DataSet ds = new DataSet();
        public form_HoaDon()
        {
            InitializeComponent();
        }
        private void Load_dgv()
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM hoadoncopy";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, "HoaDon");

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            da_KhachHang.DataSource = ds.Tables["HoaDon"];

            connection.Close();

        }
        private void form_HoaDon_Load(object sender, EventArgs e)
        {
            Load_dgv();
        }



        private void btn_timBan_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM HoaDoncopy where MABAN='" + txt_timban.Text + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();

            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM hoadoncopy WHERE CONVERT(DATE, NGAYTT) = CONVERT(DATE, @NgayTT)";
            SqlCommand command = new SqlCommand(query, connection);

            // Chuyển đổi giá trị từ MaskedTextBox sang kiểu DateTime
            if (DateTime.TryParse(txt_timngay.Text, out DateTime ngayTT))
            {
                command.Parameters.AddWithValue("@NgayTT", ngayTT);

                // Thực hiện SqlDataAdapter và cập nhật DataGridView
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                da_KhachHang.DataSource = dataTable;
            }
            else
            {
                // Xử lý lỗi khi chuyển đổi thất bại
                MessageBox.Show("Ngày không hợp lệ.");
            }

            connection.Close();

        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT *\r\nFROM hoadoncopy\r\nORDER BY NGAYTT ASC;";
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

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT sum(thanhtien) as TONG_THANHTIEN from hoadoncopy";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Tạo một DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            if (dataTable.Rows.Count > 0)
            {
                // Lấy giá trị tổng thành tiền từ DataTable (chú ý cột có tên "TONG_THANHTIEN")
                string tongThanhTien = dataTable.Rows[0]["TONG_THANHTIEN"].ToString();

                // Gán giá trị vào TextBox
                txt_XuatHD.Text = tongThanhTien;
            }
            else
            {
                // Nếu không có dữ liệu, bạn có thể gán giá trị mặc định cho TextBox hoặc thông báo cho người dùng
                txt_XuatHD.Text = "Không có dữ liệu";
            }


            connection.Close();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM HoaDoncopy where TenKh='" + txt_TimKiem.Text + "'";
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

        private void btn_sdt_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM HoaDoncopy where SDT='" + txt_TimKiem.Text + "'";
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
    }
}
