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
    public partial class form_LauDonVeSinh : Form
    {
        public form_LauDonVeSinh()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullPath = ("C:\\Users\\BeP\\Desktop\\sv.txt");
            if (File.Exists(fullPath))
            {
                StreamWriter writer = new StreamWriter(fullPath, true);
                writer.WriteLine(tbAdd.Text + "\n" + tbTime.Text + "\n" + tbDate.Text + "\n");

                writer.Close();

                MessageBox.Show("Dat hang thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbAdd_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_ChiTietDichVu form_ChiTietDichVu = new form_ChiTietDichVu();
            form_ChiTietDichVu.ShowDialog();
        }
    }
}
