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
    public partial class form_ThanhToan : Form
    {
        public form_ThanhToan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbLauDon.Text = File.ReadAllText("C:\\Users\\BeP\\Desktop\\sv.txt");
            lbNauCom.Text = File.ReadAllText("C:\\Users\\BeP\\Desktop\\svnc.txt");
            lbGiatUi.Text = File.ReadAllText("C:\\Users\\BeP\\Desktop\\svgiat.txt");
            MessageBox.Show("Dat hang thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
