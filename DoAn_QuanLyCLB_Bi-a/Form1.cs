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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckPassword(string username, string password)
        {
            // Remove the SqlConnection definition from here
           if(connection.State ==ConnectionState.Closed) connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT 1 FROM AUTHENTION WHERE USERNAME = @username AND PASS = @password", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true; // Credentials are correct
                    }
                }
            }
            if (connection.State == ConnectionState.Open) connection.Close();
            return false; // Credentials are not correct
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim().Length == 0 || txt_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            string username = txt_UserName.Text;
            string password = txt_Pass.Text;

            bool isLoginSuccessful = CheckPassword(username, password);

            if (isLoginSuccessful)
            {
                this.Hide();
                Form_Main f = new Form_Main();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng", "Thông báo");
            }

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
