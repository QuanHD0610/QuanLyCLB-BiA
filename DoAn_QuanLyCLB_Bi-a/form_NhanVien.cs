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
    public partial class form_NhanVien : Form
    {
       // SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        DataSet ds = new DataSet();
        public form_NhanVien()
        {
            InitializeComponent();
        }
        void Databingding(DataTable pDT)
        {
            txt_kh.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_tuoi.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_chucvu.DataBindings.Clear();
            txt_calam.DataBindings.Clear();
            txt_luong.DataBindings.Clear();

            txt_kh.DataBindings.Add("Text",pDT,"MANV");
            txt_sdt.DataBindings.Add("Text", pDT, "SDT");
            txt_hoten.DataBindings.Add("Text", pDT, "TENNV");
            txt_tuoi.DataBindings.Add("Text", pDT, "TUOI");
            txt_diachi.DataBindings.Add("Text", pDT, "DIACHI");
            txt_chucvu.DataBindings.Add("Text", pDT, "CHUCVU");
            txt_calam.DataBindings.Add("Text", pDT, "CALAM");
            txt_luong.DataBindings.Add("Text", pDT, "LUONG");

        }
        private void Load_dgv()
        {
            try
            {
                if(connection.State != ConnectionState.Open) {
                    connection.Open();
                    // Thực hiện truy vấn SQL
                    string query = "SELECT*FROM NHANVIEN";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.Fill(ds, "NhanVien");

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    da_NhanVien.DataSource = ds.Tables["NhanVien"];
                }

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

        private void form_NhanVien_Load(object sender, EventArgs e)
        {
            Load_dgv();
            Databingding(ds.Tables["NhanVien"]);
        }

        private void btn_timten_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM NHANVIEN WHERE TenNV = @TenNV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenNV", txt_TimKiem.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                da_NhanVien.DataSource = dataTable;
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

        private void btn_timsdt_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM NHANVIEN WHERE SDT = @SDT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SDT", txt_timsdt.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                da_NhanVien.DataSource = dataTable;
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
        public void removemon()
        {
            if (ds.Tables.Contains("NhanVien"))
            {
                ds.Tables.Remove("NhanVien");
                da_NhanVien.DataSource = null;
                da_NhanVien.Rows.Clear();
            }

        }
        private void btn_XuatTatCa_Click(object sender, EventArgs e)
        {
            removemon();
            Load_dgv();
        }

        private void btn_XoaNhanVien_Click(object sender, EventArgs e)
        {
            string deleteSelect = "Delete NhanVien where MANV='" + txt_kh.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(deleteSelect, connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "Nhanvien");
            MessageBox.Show("Thành công");
            btn_XoaNhanVien.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            da_NhanVien.AllowUserToAddRows = true;
            da_NhanVien.ReadOnly = false;
            for (int i = 0; i < da_NhanVien.Rows.Count - 1; i++)
            {
                da_NhanVien.Rows[i].ReadOnly = true;
            }
            da_NhanVien.FirstDisplayedScrollingRowIndex = da_NhanVien.Rows.Count - 1;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            da_NhanVien.ReadOnly = false;
            for (int i = 0; i < da_NhanVien.Rows.Count - 1; i++)
            {
                da_NhanVien.Rows[i].ReadOnly = false;
            }
            da_NhanVien.Columns[0].ReadOnly = true;
            da_NhanVien.AllowUserToAddRows = false;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da_kh = new SqlDataAdapter("SELECT * FROM NhanVien", connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_kh);

            try
            {
                connection.Open();

                // Thực hiện lưu trữ thay đổi từ DataSet vào cơ sở dữ liệu
                da_kh.Update(ds, "NhanVien");

                // Databinding có vẻ là một phần của ứng dụng WinForms, vì vậy mình giả định bạn có một hàm Databinding riêng.
                Databingding(ds.Tables["NhanVien"]);

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
