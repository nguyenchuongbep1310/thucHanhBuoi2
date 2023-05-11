namespace thucHanhBuoi2
{
    partial class from_NauCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(from_NauCom));
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tbDate = new TextBox();
            tbTime = new TextBox();
            tbAdd = new TextBox();
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
            tableLayoutPanel1.Controls.Add(button5, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(48, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(605, 593);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(3, 323);
            button5.Name = "button5";
            button5.Size = new Size(599, 270);
            button5.TabIndex = 8;
            button5.Text = "Nấu các món ăn theo yêu cầu của chủ nhà";
            button5.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(162, 971);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(333, 58);
            button1.TabIndex = 29;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbDate.ForeColor = SystemColors.AppWorkspace;
            tbDate.Location = new Point(62, 893);
            tbDate.Margin = new Padding(4);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(575, 52);
            tbDate.TabIndex = 28;
            tbDate.Text = "Ngày bắt đầu";
            // 
            // tbTime
            // 
            tbTime.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbTime.ForeColor = SystemColors.AppWorkspace;
            tbTime.Location = new Point(62, 798);
            tbTime.Margin = new Padding(4);
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(575, 52);
            tbTime.TabIndex = 27;
            tbTime.Text = "Thời gian hoàn thành";
            // 
            // tbAdd
            // 
            tbAdd.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbAdd.ForeColor = SystemColors.AppWorkspace;
            tbAdd.Location = new Point(59, 712);
            tbAdd.Margin = new Padding(4);
            tbAdd.Name = "tbAdd";
            tbAdd.Size = new Size(575, 52);
            tbAdd.TabIndex = 26;
            tbAdd.Text = "Địa chỉ";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources._2540587_notification_paper_plane_plane_send_icon;
            pictureBox11.Location = new Point(642, 1);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(70, 65);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 33;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // from_NauCom
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 1050);
            Controls.Add(pictureBox11);
            Controls.Add(button1);
            Controls.Add(tbDate);
            Controls.Add(tbTime);
            Controls.Add(tbAdd);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "from_NauCom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "from_NauCom";
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
        private Button button1;
        private TextBox tbDate;
        private TextBox tbTime;
        private TextBox tbAdd;
        private Button button5;
        private PictureBox pictureBox11;
    }
}