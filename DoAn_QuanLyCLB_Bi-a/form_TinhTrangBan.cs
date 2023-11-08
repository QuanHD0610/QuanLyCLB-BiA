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
            //txt_Tienban.DataBindings.Clear();
            txt_tenkh.DataBindings.Clear();
            maker_sogio.DataBindings.Clear();

            cbo_ban.DataBindings.Add("Text", pDT, "TENBAN");
            //txt_Tienban.DataBindings.Add("Text", pDT, "TongTien");
            txt_tenkh.DataBindings.Add("Text", pDT, "TENKH");
            maker_sogio.DataBindings.Add("Text", pDT, "GIOVAO");
        }
        public void LoadDgv_Ban()
        {
            string strselect = "SELECT KHACHHANG.MAKH, BANBIA.MABAN, TENKH, SDT, GIOVAO, TENBAN, TINHTRANG FROM DANGKY, KHACHHANG, BANBIA WHERE DANGKY.MABAN = BANBIA.MABAN  and KHACHHANG.MAKH=DANGKY.MAKH";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "BanBiA");
            dtv_DanhSachBan.DataSource = ds.Tables["BanBiA"];

            // Ẩn các cột không cần thiết
            dtv_DanhSachBan.Columns["MAKH"].Visible = false;
            dtv_DanhSachBan.Columns["MABAN"].Visible = false;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
