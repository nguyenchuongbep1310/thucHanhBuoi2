namespace thucHanhBuoi2
{
    partial class form_LauDonVeSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            tbAdd = new TextBox();
            tbTime = new TextBox();
            tbDate = new TextBox();
            button1 = new Button();
            pictureBox11 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Location = new Point(60, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(605, 593);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.canho01;
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Tahoma", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 40);
            label1.TabIndex = 2;
            label1.Text = "Thông tin dịch vụ";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(3, 323);
            button4.Name = "button4";
            button4.Size = new Size(599, 267);
            button4.TabIndex = 7;
            button4.Text = "Dọn dẹp nhà cửa theo ý của chủ nhà";
            button4.UseVisualStyleBackColor = false;
            // 
            // tbAdd
            // 
            tbAdd.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbAdd.ForeColor = SystemColors.AppWorkspace;
            tbAdd.Location = new Point(60, 699);
            tbAdd.Margin = new Padding(4);
            tbAdd.Name = "tbAdd";
            tbAdd.Size = new Size(575, 52);
            tbAdd.TabIndex = 21;
            tbAdd.Text = "Địa chỉ";
            tbAdd.TextChanged += tbAdd_TextChanged;
            // 
            // tbTime
            // 
            tbTime.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbTime.ForeColor = SystemColors.AppWorkspace;
            tbTime.Location = new Point(63, 785);
            tbTime.Margin = new Padding(4);
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(575, 52);
            tbTime.TabIndex = 22;
            tbTime.Text = "Thời gian hoàn thành";
            tbTime.TextChanged += tbTime_TextChanged;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbDate.ForeColor = SystemColors.AppWorkspace;
            tbDate.Location = new Point(63, 880);
            tbDate.Margin = new Padding(4);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(575, 52);
            tbDate.TabIndex = 23;
            tbDate.Text = "Ngày bắt đầu";
            tbDate.TextChanged += tbDate_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(163, 958);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(333, 58);
            button1.TabIndex = 25;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources._2540587_notification_paper_plane_plane_send_icon;
            pictureBox11.Location = new Point(647, -3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(70, 65);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 32;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // form_LauDonVeSinh
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 1050);
            Controls.Add(pictureBox11);
            Controls.Add(button1);
            Controls.Add(tbDate);
            Controls.Add(tbTime);
            Controls.Add(tbAdd);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_LauDonVeSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_LauDonVeSinh";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button4;
        private TextBox tbAdd;
        private TextBox tbTime;
        private TextBox tbDate;
        private Button button1;
        private PictureBox pictureBox11;
    }
}