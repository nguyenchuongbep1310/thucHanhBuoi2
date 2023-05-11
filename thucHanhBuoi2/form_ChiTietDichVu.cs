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
    public partial class form_ChiTietDichVu : Form
    {
        public form_ChiTietDichVu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form_ChiTietDichVu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TrangChu form_TrangChu = new form_TrangChu();
            form_TrangChu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_LauDonVeSinh lauDonVeSinh = new form_LauDonVeSinh();
            lauDonVeSinh.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            from_NauCom from_NauCom = new from_NauCom();
            from_NauCom.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_GiatUI form_GiatUI = new form_GiatUI();
            form_GiatUI.ShowDialog();
        }
    }
}
