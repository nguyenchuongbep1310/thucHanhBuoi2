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
    public partial class form_CongDong : Form
    {
        public form_CongDong()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TrangChu form_TrangChu = new form_TrangChu();
            form_TrangChu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TrangChu form_TrangChu = new form_TrangChu();
            form_TrangChu.ShowDialog();
        }
    }
}
