﻿using System;
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
    public partial class Form_Main : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        public Form_Main()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pan_Main.Controls.Add(childform);
            pan_Main.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Menu());
        }

        private void btn_TinhTrangBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_TinhTrangBan());
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_LichSu());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm( new form_KhachHang());
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_HoaDon());
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_Kho());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_NhanVien());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_ThongKe());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_DangNhap form = new Form_DangNhap();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongtin());

        }
    }
}
