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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QuanLyCLB_Bi_a
{
 
    public partial class form_LichSu : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");

        public form_LichSu()
        {
            InitializeComponent();
        }
        private void Load_dgv()
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV";
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
            string query = "SELECT SUM(T.THANHTIEN) AS TONG_THANHTIEN\r\nFROM (\r\n    SELECT KHACHHANG.MAKH, SUM(SOLUONG * GIA) AS THANHTIEN\r\n    FROM DANGKY\r\n    JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH\r\n    JOIN BANBIA ON DANGKY.MABAN = BANBIA.MABAN\r\n    JOIN DICHVU ON DANGKY.MADV = DICHVU.MADV\r\n    GROUP BY KHACHHANG.MAKH\r\n) AS T; ";
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
                txt_tongket.Text = tongThanhTien;
            }
            else
            {
                // Nếu không có dữ liệu, bạn có thể gán giá trị mặc định cho TextBox hoặc thông báo cho người dùng
                txt_tongket.Text = "Không có dữ liệu";
            }


            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Thực hiện truy vấn SQL sử dụng tham số
                string query = "SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV AND MAKH='"+txtTimkiem.Text+"'";
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

        private void da_LichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                // Thực hiện truy vấn SQL
                string query = "SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV";
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
        }

        private void btn_timban_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Thực hiện truy vấn SQL sử dụng tham sốBAN
                string query = "SELECT MAKH,DICHVU.MADV,MABAN,TENDV,SOLUONG,NGAYDANGKY FROM DANGKY,DICHVU WHERE  DANGKY.MADV =DICHVU.MADV AND MABAN='" + txt_tkban.Text + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}
