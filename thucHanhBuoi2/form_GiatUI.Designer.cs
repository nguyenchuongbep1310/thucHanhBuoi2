namespace thucHanhBuoi2
{
    partial class form_GiatUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GiatUI));
            tableLayoutPanel1 = new TableLayoutPanel();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            tableLayoutPanel1.Controls.Add(button6, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(50, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(605, 593);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Blue;
            button6.Location = new Point(3, 323);
            button6.Name = "button6";
            button6.Size = new Size(599, 270);
            button6.TabIndex = 9;
            button6.Text = "Giặt giũ thảm và quần áo";
            button6.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(153, 932);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(333, 58);
            button1.TabIndex = 30;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbDate.ForeColor = SystemColors.AppWorkspace;
            tbDate.Location = new Point(53, 854);
            tbDate.Margin = new Padding(4);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(575, 52);
            tbDate.TabIndex = 29;
            tbDate.Text = "Ngày bắt đầu";
            // 
            // tbTime
            // 
            tbTime.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbTime.ForeColor = SystemColors.AppWorkspace;
            tbTime.Location = new Point(53, 759);
            tbTime.Margin = new Padding(4);
            tbTime.Name = "tbTime";
            tbTime.Size = new Size(575, 52);
            tbTime.TabIndex = 28;
            tbTime.Text = "Thời gian hoàn thành";
            // 
            // tbAdd
            // 
            tbAdd.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbAdd.ForeColor = SystemColors.AppWorkspace;
            tbAdd.Location = new Point(50, 673);
            tbAdd.Margin = new Padding(4);
            tbAdd.Name = "tbAdd";
            tbAdd.Size = new Size(575, 52);
            tbAdd.TabIndex = 27;
            tbAdd.Text = "Địa chỉ";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources._2540587_notification_paper_plane_plane_send_icon;
            pictureBox11.Location = new Point(634, -1);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(70, 65);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 31;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // form_GiatUI
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 1050);
            Controls.Add(pictureBox11);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(tbDate);
            Controls.Add(tbTime);
            Controls.Add(tbAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_GiatUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_GiatUI";
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
        private Button button6;
        private PictureBox pictureBox11;
    }
}