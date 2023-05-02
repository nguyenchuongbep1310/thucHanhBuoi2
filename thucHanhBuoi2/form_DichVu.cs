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
    public partial class form_DichVu : Form
    {
        public form_DichVu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_ChiTietDichVu form_ChiTietDichVu = new form_ChiTietDichVu();
            form_ChiTietDichVu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_ChiTietDichVu form_ChiTietDichVu = new form_ChiTietDichVu();
            form_ChiTietDichVu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_ChiTietDichVu form_ChiTietDichVu = new form_ChiTietDichVu();
            form_ChiTietDichVu.ShowDialog();
        }
    }
}
