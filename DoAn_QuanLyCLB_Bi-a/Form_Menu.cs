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
    public partial class Form_Menu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");        DataSet ds;
        SqlDataAdapter da;
        public Form_Menu()
        {
            InitializeComponent();
        }
        public void Load_cboBan()
        {
            DataSet ds = new DataSet();

            // Define the SQL query
            string strselect = "SELECT * FROM BANBIA";

            // Create a SqlDataAdapter and fill the DataSet
            SqlDataAdapter da = new SqlDataAdapter(strselect, conn);
            da.Fill(ds, "BANBIA");

            // Set the data source and display value and value member for the ComboBox
            cbo_Ban.DataSource = ds.Tables["BANBIA"];
            cbo_Ban.DisplayMember = "TenBan";
            cbo_Ban.ValueMember = "MaBan";

        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Load_cboBan();
        }

    }
}
