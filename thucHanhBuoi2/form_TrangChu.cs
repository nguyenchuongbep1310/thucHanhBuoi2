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
    public partial class form_TrangChu : Form
    {
        public form_TrangChu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_DichVu form_DichVu = new form_DichVu();
            form_DichVu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TaiKhoan form_TaiKhoan = new form_TaiKhoan();
            form_TaiKhoan.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dangNhap form_DangNhap = new form_dangNhap();
            form_DangNhap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_CongDong form_CongDong = new form_CongDong();
            form_CongDong.ShowDialog();
        }
    }
}
