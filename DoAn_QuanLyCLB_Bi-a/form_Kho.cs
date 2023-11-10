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
    public partial class form_Kho : Form
    {
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        DataSet ds = new DataSet();
        public form_Kho()
        {
            InitializeComponent();
        }
        public void LoadDgv_gay()
        {
            string strselect = "select*from gaybia";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "Gaybia");
            da_gay.DataSource = ds.Tables["Gaybia"];
        }
        public void LoadDgv_bia()
        {
            string strselect = "select*from Bia";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "Bia");
            da_bia.DataSource = ds.Tables["Bia"];
        }

        private void form_Kho_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = false;
            LoadDgv_gay();
            LoadDgv_bia();
        }
        public void themgay()
        {
            btn_Luu.Enabled = true;
            da_gay.AllowUserToAddRows = true;
            da_gay.ReadOnly = false;
            for (int i = 0; i < da_gay.Rows.Count - 1; i++)
            {
                da_gay.Rows[i].ReadOnly = true;
            }
            da_gay.FirstDisplayedScrollingRowIndex = da_gay.Rows.Count - 1;
        }
        public void thembia()
        {
            btn_Luu.Enabled = true;
            da_bia.AllowUserToAddRows = true;
            da_bia.ReadOnly = false;
            for (int i = 0; i < da_bia.Rows.Count - 1; i++)
            {
                da_bia.Rows[i].ReadOnly = true;
            }
            da_bia.FirstDisplayedScrollingRowIndex = da_bia.Rows.Count - 1;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            thembia();
            themgay();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            da_gay.ReadOnly = false;
            for (int i = 0; i < da_gay.Rows.Count - 1; i++)
            {
                da_gay.Rows[i].ReadOnly = false;
            }
            da_gay.Columns[0].ReadOnly = true;
            da_gay.AllowUserToAddRows = false;

            da_bia.ReadOnly = false;
            for (int i = 0; i < da_bia.Rows.Count - 1; i++)
            {
                da_bia.Rows[i].ReadOnly = false;
            }
            da_bia.Columns[0].ReadOnly = true;
            da_bia.AllowUserToAddRows = false;
        }

        public void luugay()
        {
            SqlDataAdapter da_kh = new SqlDataAdapter("SELECT * FROM GayBia", connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_kh);

            try
            {
                connection.Open();

                // Thực hiện lưu trữ thay đổi từ DataSet vào cơ sở dữ liệu
                da_kh.Update(ds, "GayBia");


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
        public void luubia()
        {
            SqlDataAdapter da_kh = new SqlDataAdapter("SELECT * FROM Bia", connection);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da_kh);

            try
            {
                connection.Open();

                // Thực hiện lưu trữ thay đổi từ DataSet vào cơ sở dữ liệu
                da_kh.Update(ds, "Bia");


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
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            luubia();
            luugay();
        }
    }
}
