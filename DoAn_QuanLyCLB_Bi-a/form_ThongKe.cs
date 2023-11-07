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
    public partial class form_ThongKe : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47T7FNC\\SQLEXPRESS;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QLPHONGBIA;Integrated Security=True");
        public form_ThongKe()
        {
            InitializeComponent();
        }
    }
}
