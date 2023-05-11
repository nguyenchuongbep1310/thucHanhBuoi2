using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class form_dangNhap : Form
    {
        public form_dangNhap()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("C:\\Users\\BeP\\Desktop\\db.txt");
            foreach (string line in lines)
            {
                if (line.Contains("Save"))
                {
                    string[] array = line.Split(' ');

                    if (array[1] == "true")
                    {
                        cbSave.CheckState = CheckState.Checked;
                        foreach (string l in lines)
                        {
                            if (l.Contains("User"))
                            {
                                string[] arr = l.Split(' ');

                                tbUser.Text = arr[1];
                            }
                            if (l.Contains("Pass"))
                            {
                                string[] arr = l.Split(' ');
                                tbPass.Text = arr[1];
                            }
                        }
                    }
                    else
                    {
                        cbSave.CheckState = CheckState.Unchecked;
                        tbPass.Text = "";
                        tbUser.Text = "";
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\BeP\\Desktop\\db.txt");
            int flag = 0;
            foreach (string line in lines)
            {
                if (line.Contains("User"))
                {
                    string[] array = line.Split(' ');

                    if (tbUser.Text.Equals(array[1]))
                    {
                        flag++;
                    }
                }
                if (line.Contains("Pass"))
                {
                    string[] array = line.Split(' ');

                    if (tbPass.Text.Equals(array[1]))
                    {
                        flag++;
                    }
                }
            }
            if (cbSave.Checked)
            {
                using (StreamWriter w = File.AppendText("C:\\Users\\BeP\\Desktop\\db.txt"))
                {
                    w.WriteLine("Save: " + "true");
                }
            }
            else
            {
                using (StreamWriter w = File.AppendText("C:\\Users\\BeP\\Desktop\\db.txt"))
                {
                    w.WriteLine("Save: " + "false");
                }
            }
            if (flag == 2)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                form_TrangChu form_TrangChu = new form_TrangChu();
                form_TrangChu.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void cbSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
