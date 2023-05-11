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
    public partial class form_TaiKhoan : Form
    {
        public form_TaiKhoan()
        {
            InitializeComponent();
            StyleDataGridView();

            string[] lines = File.ReadAllLines("C:\\Users\\BeP\\Desktop\\db.txt");
            foreach (string line in lines)
            {
                if (line.Contains("Save"))
                {
                    string[] array = line.Split(' ');

                    if (array[1] == "true")
                    {
                        foreach (string l in lines)
                        {
                            if (l.Contains("User"))
                            {
                                string[] arr = l.Split(' ');

                                tbHoTen.Text = arr[1];
                            }
                            if (l.Contains("Pass"))
                            {
                                string[] arr = l.Split(' ');
                                tbMatKhau.Text = arr[1];
                            }
                            if (l.Contains("Phone"))
                            {
                                string[] arr = l.Split(' ');
                                tbSdt.Text = arr[1];
                            }
                            //if (l.Contains("Email"))
                            //{
                            //    string[] arr = l.Split(' ');
                            //    tbEmail.Text = arr[1];
                            //}
                        }
                    }
                    else
                    {
                        tbHoTen.Text = "";
                        tbSdt.Text = "";
                        tbEmail.Text = "chuong@gmail.com";
                        tbMatKhau.Text = "";
                    }
                }
            }
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

        void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Dọn vệ sinh", "1h", "Hoàn thành", "*****");
            this.dataGridView1.Rows.Add("Nấu cơm", "2h", "Hoàn thành", "*****");
            this.dataGridView1.Rows.Add("Giặt ủi", "1h", "Hoàn thành", "*****");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void form_TaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
