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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        DataSet ds = new DataSet();
        public form_KhachHang()
        {
            InitializeComponent();
        }
        private void Load_dgv()
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM khachhang";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, "Khachhang");

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            da_KhachHang.DataSource = ds.Tables["Khachhang"];

            connection.Close();

        }
        public void updatekh1()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    string updatestr = @"UPDATE KHACHHANG
                                           SET GIARA = CONVERT(TIME, GETDATE())";
                    SqlCommand addtg = new SqlCommand(updatestr, connection);
                    addtg.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void updateKH()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    string updatestr = @"update KHACHHANG
                                        set TONGTG= CONVERT(TIME, DATEADD(MINUTE,
                                                   DATEDIFF(MINUTE, GIOVAO, GETDATE()),
                                                   '00:00'))";
                    SqlCommand addtg = new SqlCommand(updatestr, connection);
                    addtg.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void form_KhachHang_Load(object sender, EventArgs e)
        {
            txt_kh.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            txt_giovao.DataBindings.Clear();
            txt_giora.DataBindings.Clear();
            updatekh1();
            updateKH();
            Load_dgv();
            Databingding(ds.Tables["Khachhang"]);
        }
        private void btn_timten_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM khachhang where TenKh='"+txt_TimKiem.Text+"'";
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

        private void btn_timsdt_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Thực hiện truy vấn SQL
            string query = "SELECT * FROM khachhang where SDT='" + txt_timsdt.Text + "'";
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
        void Databingding(DataTable pDT)
        {
            txt_kh.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            txt_giovao.DataBindings.Clear();
            txt_giora.DataBindings.Clear();
            txt_sogiochoi.DataBindings.Clear();


            txt_kh.DataBindings.Add("Text",pDT,"TENKH");
            txt_sdt.DataBindings.Add("Text", pDT, "SDT");
            txt_giovao.DataBindings.Add("Text", pDT, "GioVao");
            txt_giora.DataBindings.Add("Text", pDT, "Giara");
            txt_sogiochoi.DataBindings.Add("Text", pDT, "TONGTG");

        }
        public void deletekh()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    if (txt_xoa.Text.Length> 0)
                    {
                        connection.Open();
                        string updatestr = @"Delete KHACHHANG
                                                 where  MAKH= '" + txt_xoa.Text + "'";
                        SqlCommand addtg = new SqlCommand(updatestr, connection);
                        addtg.ExecuteNonQuery();

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void deletedkkh()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    if (txt_xoa.Text.Length > 0)
                    {
                        connection.Open();
                        string updatestr = @"Delete Dangky
                                                 where  MAKH= '" + txt_xoa.Text + "'";
                        SqlCommand addtg = new SqlCommand(updatestr, connection);
                        addtg.ExecuteNonQuery();

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void deletedkhd()
        {
            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    if (txt_xoa.Text.Length > 0)
                    {
                        connection.Open();
                        string updatestr = @"Delete HoaDon
                                                 where  MAKH= '" + txt_xoa.Text + "'";
                        SqlCommand addtg = new SqlCommand(updatestr, connection);
                        addtg.ExecuteNonQuery();

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            deletekh();
            deletedkkh();
            deletedkhd();
            removemon();
            Load_dgv();

        }

        public void removemon()
        {
            if (ds.Tables.Contains("Khachhang"))
            {
                ds.Tables.Remove("Khachhang");
                da_KhachHang.DataSource = null;
                da_KhachHang.Rows.Clear();
            }

        }
        private void btn_XuatTatCa_Click(object sender, EventArgs e)
        {
            removemon();
            Load_dgv();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           
            da_KhachHang.ReadOnly = false;
            for (int i = 0; i < da_KhachHang.Rows.Count - 1; i++)
            {
                da_KhachHang.Rows[i].ReadOnly = false;
            }
            da_KhachHang.Columns[0].ReadOnly = true;
            da_KhachHang.AllowUserToAddRows = false;
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da_kh = new SqlDataAdapter("SELECT * FROM KhachHang", connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_kh);

            try
            {
                connection.Open();

                // Thực hiện lưu trữ thay đổi từ DataSet vào cơ sở dữ liệu
                da_kh.Update(ds, "KhachHang");

                // Databinding có vẻ là một phần của ứng dụng WinForms, vì vậy mình giả định bạn có một hàm Databinding riêng.
                Databingding(ds.Tables["KhachHang"]);

                MessageBox.Show("Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
