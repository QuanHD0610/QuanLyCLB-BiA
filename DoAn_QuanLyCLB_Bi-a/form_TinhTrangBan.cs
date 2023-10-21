using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyCLB_Bi_a
{
    public partial class form_TinhTrangBan : Form
    {
        public form_TinhTrangBan()
        {
            InitializeComponent();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Đã thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
    }
}
