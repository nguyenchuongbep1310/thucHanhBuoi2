namespace thucHanhBuoi2
{
    partial class form_dangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dangKy));
            checkBox1 = new CheckBox();
            txt_xacNhanMatKhau = new TextBox();
            txt_matKhau = new TextBox();
            txt_email = new TextBox();
            txt_soDienThoai = new TextBox();
            txt_hoTen = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(13, 852);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(689, 42);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Tôi đã đọc và đồng ý với các điều khoản sử dụng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_xacNhanMatKhau
            // 
            txt_xacNhanMatKhau.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            txt_xacNhanMatKhau.Location = new Point(104, 750);
            txt_xacNhanMatKhau.Margin = new Padding(4);
            txt_xacNhanMatKhau.Name = "txt_xacNhanMatKhau";
            txt_xacNhanMatKhau.Size = new Size(486, 52);
            txt_xacNhanMatKhau.TabIndex = 14;
            txt_xacNhanMatKhau.Text = "Xác nhận mật khẩu";
            txt_xacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            txt_matKhau.Location = new Point(104, 676);
            txt_matKhau.Margin = new Padding(4);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Size = new Size(486, 52);
            txt_matKhau.TabIndex = 13;
            txt_matKhau.Text = "Mật khẩu";
            txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            txt_email.Location = new Point(104, 605);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(486, 52);
            txt_email.TabIndex = 12;
            txt_email.Text = "Email";
            // 
            // txt_soDienThoai
            // 
            txt_soDienThoai.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            txt_soDienThoai.Location = new Point(104, 539);
            txt_soDienThoai.Margin = new Padding(4);
            txt_soDienThoai.Name = "txt_soDienThoai";
            txt_soDienThoai.Size = new Size(486, 52);
            txt_soDienThoai.TabIndex = 11;
            txt_soDienThoai.Text = "Số điện thoại";
            // 
            // txt_hoTen
            // 
            txt_hoTen.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            txt_hoTen.Location = new Point(104, 472);
            txt_hoTen.Margin = new Padding(4);
            txt_hoTen.Name = "txt_hoTen";
            txt_hoTen.Size = new Size(486, 52);
            txt_hoTen.TabIndex = 10;
            txt_hoTen.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 327);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(402, 62);
            label1.TabIndex = 9;
            label1.Text = "Tạo tài khoản mới";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(634, 968);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 83);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(113, 902);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(486, 102);
            button2.TabIndex = 25;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, -4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(714, 317);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // form_dangKy
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 1050);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(txt_xacNhanMatKhau);
            Controls.Add(txt_matKhau);
            Controls.Add(txt_email);
            Controls.Add(txt_soDienThoai);
            Controls.Add(txt_hoTen);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "form_dangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_dangKy";
            Load += form_dangKy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private TextBox txt_xacNhanMatKhau;
        private TextBox txt_matKhau;
        private TextBox txt_email;
        private TextBox txt_soDienThoai;
        private TextBox txt_hoTen;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox4;
    }
}