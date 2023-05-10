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
    public partial class form_dangKy : Form
    {
        public form_dangKy()
        {
            InitializeComponent();
        }

        private void form_dangKy_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullPath = ("C:\\Users\\BeP\\Desktop\\db.txt");
            if (File.Exists(fullPath))
            {
                StreamWriter writer = new StreamWriter(fullPath, true);
                writer.WriteLine(txt_hoTen.Text + "\t" + txt_soDienThoai.Text + "\t" + txt_email.Text + "\t" + txt_matKhau.Text);

                writer.Close();

                MessageBox.Show("Tao tai khoan thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            form_dangNhap form_DangNhap = new form_dangNhap();
            form_DangNhap.ShowDialog();
        }
    }
}
