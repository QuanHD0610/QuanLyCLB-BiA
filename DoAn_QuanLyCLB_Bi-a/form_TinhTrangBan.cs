﻿using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DoAn_QuanLyCLB_Bi_a
{
    public partial class form_TinhTrangBan : Form
    {
        SqlConnection connection;
        DataSet ds =new DataSet();
        public form_TinhTrangBan()
        {
            connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
            InitializeComponent();
        }
 
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Xác nhận đã thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        void Databingding(DataTable pDT)
        {
            cbo_ban.DataBindings.Clear();
            txt_Tienban.DataBindings.Clear();
            txt_tenkh.DataBindings.Clear();
            maked_giovao.DataBindings.Clear();
            txt_tinhtrang.DataBindings.Clear(); 
            txt_SDT.DataBindings.Clear();
            maker_sogio.DataBindings.Clear();
            txt_MaKH.DataBindings.Clear();
            txt_MaBan.DataBindings.Clear();

            cbo_ban.DataBindings.Add("Text", pDT, "TENBAN");
            txt_Tienban.DataBindings.Add("Text", pDT, "GIATIEN");
            txt_tenkh.DataBindings.Add("Text", pDT, "TENKH");
            maked_giovao.DataBindings.Add("Text", pDT, "GIOVAO");
            txt_tinhtrang.DataBindings.Add("Text", pDT, "TINHTRANG");
            txt_SDT.DataBindings.Add("Text", pDT, "SDT");
            maker_sogio.DataBindings.Add("Text", pDT, "TONGTG");
            txt_MaKH.DataBindings.Add("Text", pDT, "MAKH");
            txt_MaBan.DataBindings.Add("Text", pDT, "MABAN");
        }
        public void LoadDgv_Ban()
        {
            string strselect = "SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH,\r\n CONVERT(TIME, DATEADD(MINUTE,\r\n      DATEDIFF(MINUTE, GIOVAO, GETDATE()),\r\n   '00:00:00')) AS TONGTG\r\nFROM BANBIA\r\nLEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN\r\nLEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH;";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "BanBiA");
            dtv_DanhSachBan.DataSource = ds.Tables["BanBiA"];

            // Ẩn các cột không cần thiết
            dtv_DanhSachBan.Columns["TenKh"].Visible = false;
            dtv_DanhSachBan.Columns["TenBan"].Visible = false;
        }

        private void form_TinhTrangBan_Load(object sender, EventArgs e)
        {
            LoadDgv_Ban();
            dtv_DanhSachBan.ReadOnly = true;
            dtv_DanhSachBan.AllowUserToAddRows = false;
            txt_tenkh.ReadOnly = txt_Tienban.ReadOnly = true;
            maked_giovao.ReadOnly = true;
            maker_sogio.ReadOnly = true;
            Databingding(ds.Tables["BanBiA"]);
        }

        public void removemon()
        {
            if (ds.Tables.Contains("DVNUOC"))
            {
                ds.Tables.Remove("DVNUOC");
                dtv_DsNuoc.DataSource = null;
                dtv_DsNuoc.Rows.Clear();
            }
           
        }
        public void Loadlst_Mon()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    removemon();
                    string queryString = @"
                                            SELECT
                                                DICHVU.TENDV,
                                                DANGKY.SOLUONG,
                                                DICHVU.GIA * DANGKY.SOLUONG AS TotalCost
                                            FROM BANBIA
                                            LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN
                                            LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH
                                            LEFT JOIN DICHVU ON DICHVU.MADV = DANGKY.MADV
                                            WHERE BANBIA.TINHTRANG = N'Đang sử dụng'
                                                AND BANBIA.MABAN = '" + txt_MaBan.Text + "'";

                        SqlDataAdapter da = new SqlDataAdapter(queryString, connection);
                            da.Fill(ds, "DVNUOC");
                            dtv_DsNuoc.DataSource = ds.Tables["DVNUOC"];

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }

        }
        public void XuatTien()
        {

        }
        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection != null && connection.State != ConnectionState.Open)
                {
                    connection.Open();                 
                    string updatestr = @"UPDATE KHACHHANG
                                 SET TONGTG = CONVERT(TIME, DATEADD(MINUTE,
                                                 DATEDIFF(MINUTE, KHACHHANG.GIOVAO, GETDATE()),
                                                 '00:00:00'))
                                 FROM KHACHHANG";
                        SqlCommand addtg = new SqlCommand(updatestr, connection);
                        addtg.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }     
            Loadlst_Mon();      
            

 
        }

        private void btn_timban_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Thực hiện truy vấn SQL sử dụng tham số MABAN
                string query = "SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH, CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG " +
                               "FROM BANBIA " +
                               "LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN " +
                               "LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH " +                            
                               "Where BANBIA.MABAN = @MABAN";

                SqlCommand command = new SqlCommand(query, connection);

                // Sử dụng SqlParameter để tránh SQL Injection
                command.Parameters.Add(new SqlParameter("@MABAN", SqlDbType.NVarChar));
                command.Parameters["@MABAN"].Value = txt_timban.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dtv_DanhSachBan.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            Databingding(ds.Tables["BanBiA"]);
        }

        private void btn_bantrong_Click_1(object sender, EventArgs e)
        {
            string strselect = "SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH, " +
                "CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG " +
                "FROM BANBIA " +
                "LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN " +
                "LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH " +
                "WHERE BANBIA.TINHTRANG = N'Trống';";

            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "Bantrong");
            dtv_DanhSachBan.DataSource = ds.Tables["Bantrong"];

            // Ẩn các cột không cần thiết
            dtv_DanhSachBan.Columns["TenKH"].Visible = false;
            dtv_DanhSachBan.Columns["TenBAN"].Visible = false;
            Databingding(ds.Tables["BanBiA"]);
        }

        private void btn_dangsudung_Click_1(object sender, EventArgs e)
        {
            string strselectt = "SELECT BANBIA.MABAN, TENBAN, GIATIEN, TINHTRANG, TINHTRANGTT, KHACHHANG.MAKH, SDT, GIOVAO, TENKH, " +
                "CONVERT(TIME, DATEADD(MINUTE, DATEDIFF(MINUTE, GIOVAO, GETDATE()), '00:00:00')) AS TONGTG " +
                "FROM BANBIA " +
                "LEFT JOIN DANGKY ON DANGKY.MABAN = BANBIA.MABAN " +
                "LEFT JOIN KHACHHANG ON DANGKY.MAKH = KHACHHANG.MAKH " +
                "WHERE BANBIA.TINHTRANG = N'Đang sử dụng';";

            SqlDataAdapter da = new SqlDataAdapter(strselectt, connection);
            da.Fill(ds, "Bansudung");
            dtv_DanhSachBan.DataSource = ds.Tables["Bansudung"];

            // Ẩn các cột không cần thiết
            dtv_DanhSachBan.Columns["TenKH"].Visible = false;
            dtv_DanhSachBan.Columns["TenBAN"].Visible = false;
            Databingding(ds.Tables["BanBiA"]);
        }
    }
}