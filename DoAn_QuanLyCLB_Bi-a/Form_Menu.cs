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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAn_QuanLyCLB_Bi_a
{
    public partial class Form_Menu : Form
    {
        SqlConnection connection;
        DataSet ds;
        SqlDataAdapter da;
        public Form_Menu()
        {
            connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
            InitializeComponent();
        }
        public void Load_cboBan()
        {
            DataSet ds = new DataSet();

            // Define the SQL query
            string strselect = "SELECT * FROM BANBIA where TinhTrang='Trống'";

            // Create a SqlDataAdapter and fill the DataSet
            SqlDataAdapter da = new SqlDataAdapter(strselect, connection);
            da.Fill(ds, "BANBIA");

            // Set the data source and display value and value member for the ComboBox
            cbo_Ban.DataSource = ds.Tables["BANBIA"];
            cbo_Ban.DisplayMember = "TenBan";
            cbo_Ban.ValueMember = "MaBan";

        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            // Lấy giờ và phút hiện tại
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;

            // Định dạng thành chuỗi thời gian hh:mm
            string currentTime = string.Format("{0:D2}:{1:D2}", currentHour, currentMinute);

            // Đặt giá trị mặc định cho MaskedTextBox
            maks_time.Text = currentTime;

            lstv_menu.View = View.Details;
            Load_cboBan();
        }

        public void ThemNuoc(string drinkName, string drinkCode)
        {
            int quantity = 1;

            // Kiểm tra xem món hàng đã tồn tại trong ListView chưa
            bool itemExists = false;

            foreach (ListViewItem item in lstv_menu.Items)
            {
                if (item.SubItems[0].Text == drinkName)
                {
                    // Món hàng đã tồn tại, tăng số lượng
                    int currentQuantity = int.Parse(item.SubItems[1].Text);
                    currentQuantity += quantity;
                    item.SubItems[1].Text = currentQuantity.ToString();
                    itemExists = true;

                    // Cập nhật thuộc tính Value kiểu string
                    item.Tag = drinkCode;
                    break;
                }
            }

            if (!itemExists)
            {
                // Món hàng chưa tồn tại, thêm mới
                ListViewItem item = new ListViewItem(drinkName);
                item.SubItems.Add(quantity.ToString());
                item.Tag = drinkCode; // Đặt thuộc tính Value kiểu string
                lstv_menu.Items.Add(item);
            }
        }
        private void btn_datCoCa_Click(object sender, EventArgs e)
        {
            string drinkName = "Nước ngọt CocaCola";
            string drinkCode = "DV01";
            ThemNuoc(drinkName, drinkCode);
        }

        private void btn_datPessi_Click(object sender, EventArgs e)
        {
            string drinkName = "Nước ngọt Pessi";
            string drinkCode = "DV02";
            ThemNuoc(drinkName,drinkCode);
        }

        private void btn_datSting_Click(object sender, EventArgs e)
        {
            string drinkName = "Nước ngọt String";
            string drinkCode = "DV07";
            ThemNuoc(drinkName, drinkCode);
        }

        private void btn_datTraDa_Click(object sender, EventArgs e)
        {
            string drinkName = "Trà đá";
            string drinkCode = "DV08";
            ThemNuoc(drinkName, drinkCode);
        }

        private void btn_CafeSua_Click(object sender, EventArgs e)
        {
            string drinkName = "Cafe sữa";
            string drinkCode = "DV09";
            ThemNuoc(drinkName, drinkCode);
        }

        private void btn_BacXiu_Click(object sender, EventArgs e)
        {
            string drinkName = "Bạc xỉu";
            string drinkCode = "DV010";
            ThemNuoc(drinkName, drinkCode);
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            lstv_menu.Items.Clear();
        }

        private void lstv_menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstv_menu_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lstv_menu.Items.Count > 0)
            {
                // Kiểm tra xem có ít nhất một mục trong ListView
                lstv_menu.Items.RemoveAt(lstv_menu.Items.Count - 1);
            }

        }

        private void lstv_menu_ItemActivate(object sender, EventArgs e)
        {
            if (lstv_menu.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn
                ListViewItem selectedItem = lstv_menu.SelectedItems[0];

                // Cho phép sửa giá trị của cột thứ hai (số lượng)
                lstv_menu.LabelEdit = true;

                // Đặt dòng được chọn vào chế độ sửa đổi
                selectedItem.BeginEdit();
            }
        }
        public bool ktkhoa(string ma)
        {
            try
            {
                connection.Open();
                string selectString = "SELECT COUNT(*) FROM KhachHang WHERE MAKH = @MaKh";
                SqlCommand cmd = new SqlCommand(selectString, connection);
                cmd.Parameters.AddWithValue("@MaKh", ma);
                int count = (int)cmd.ExecuteScalar();
                connection.Close();
                return count < 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ktdv(string ma)
        {
            try
            {
                connection.Open();
                string selectString = "SELECT COUNT(*) FROM KhachHang WHERE MADON = @Madon";
                SqlCommand cmd = new SqlCommand(selectString, connection);
                cmd.Parameters.AddWithValue("@Madon", ma);
                int count = (int)cmd.ExecuteScalar();
                connection.Close();
                return count < 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btn_datban_Click(object sender, EventArgs e)
        {
            if (txt_SDT.Text.Length <= 0 || txt_TenKH.Text.Length <= 0 || txt_maKh.Text.Length <= 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng");
                return;
            }
            try
            {
                if (ktkhoa(txt_maKh.Text))
                {
                    connection.Open();
                    string insertString = "INSERT INTO KhachHang (MAKH, TENKH, SDT, GIOVAO) VALUES (@MaKh, @TenKH, @SDT, @GioVao)";
                    SqlCommand cmd = new SqlCommand(insertString, connection);
                    cmd.Parameters.AddWithValue("@MaKh", txt_maKh.Text);
                    cmd.Parameters.AddWithValue("@TenKH", txt_TenKH.Text);
                    cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                    cmd.Parameters.AddWithValue("@GioVao", maks_time.Text);
                    cmd.ExecuteNonQuery();

                    string insertDK = "INSERT INTO DANGKI (MADON, MAKH, MABAN, MADV) VALUES (@MADON, @MAKH, @MABAN @GioVao)";
                    SqlCommand cmd1 = new SqlCommand(insertDK, connection);
                    cmd.Parameters.AddWithValue("@MADON", txt_maKh.Text);
                    cmd.Parameters.AddWithValue("@MAKH", txt_TenKH.Text);
                    cmd.Parameters.AddWithValue("@MABAN", cbo_Ban.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MADV", maks_time.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
    }
}
