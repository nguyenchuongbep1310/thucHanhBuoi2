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
            form_DichVu form_DichVu = new form_DichVu();
            form_DichVu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_TaiKhoan form_TaiKhoan = new form_TaiKhoan();
            form_TaiKhoan.ShowDialog();
        }
    }
}
