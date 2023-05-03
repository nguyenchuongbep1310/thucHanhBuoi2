using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thucHanhBuoi2
{
    public partial class form_TaiKhoan : Form
    {
        public form_TaiKhoan()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TrangChu form_TrangChu = new form_TrangChu();
            form_TrangChu.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Dọn vệ sinh", "1h", "Hoàn thành", "*****");
            this.dataGridView1.Rows.Add("Nấu cơm", "2h", "Hoàn thành", "*****");
            this.dataGridView1.Rows.Add("Giặt ủi", "1h", "Hoàn thành", "*****");
        }
    }
}
