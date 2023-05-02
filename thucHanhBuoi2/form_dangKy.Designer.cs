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
            button1 = new Button();
            checkBox1 = new CheckBox();
            txt_xacNhanMatKhau = new TextBox();
            txt_matKhau = new TextBox();
            txt_email = new TextBox();
            txt_soDienThoai = new TextBox();
            txt_hoTen = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(106, 690);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(488, 101);
            button1.TabIndex = 17;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(106, 610);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(492, 34);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Tôi đã đọc và đồng ý với các điều khoản sử dụng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_xacNhanMatKhau
            // 
            txt_xacNhanMatKhau.Location = new Point(106, 519);
            txt_xacNhanMatKhau.Margin = new Padding(4);
            txt_xacNhanMatKhau.Name = "txt_xacNhanMatKhau";
            txt_xacNhanMatKhau.Size = new Size(486, 35);
            txt_xacNhanMatKhau.TabIndex = 14;
            txt_xacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txt_matKhau
            // 
            txt_matKhau.Location = new Point(106, 441);
            txt_matKhau.Margin = new Padding(4);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Size = new Size(486, 35);
            txt_matKhau.TabIndex = 13;
            txt_matKhau.Text = "Mật khẩu";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(106, 370);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(486, 35);
            txt_email.TabIndex = 12;
            txt_email.Text = "Email";
            // 
            // txt_soDienThoai
            // 
            txt_soDienThoai.Location = new Point(106, 304);
            txt_soDienThoai.Margin = new Padding(4);
            txt_soDienThoai.Name = "txt_soDienThoai";
            txt_soDienThoai.Size = new Size(486, 35);
            txt_soDienThoai.TabIndex = 11;
            txt_soDienThoai.Text = "Số điện thoại";
            // 
            // txt_hoTen
            // 
            txt_hoTen.Location = new Point(106, 237);
            txt_hoTen.Margin = new Padding(4);
            txt_hoTen.Name = "txt_hoTen";
            txt_hoTen.Size = new Size(486, 35);
            txt_hoTen.TabIndex = 10;
            txt_hoTen.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 117);
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
            pictureBox1.Location = new Point(621, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 83);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // form_dangKy
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 1050);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private TextBox txt_xacNhanMatKhau;
        private TextBox txt_matKhau;
        private TextBox txt_email;
        private TextBox txt_soDienThoai;
        private TextBox txt_hoTen;
        private Label label1;
        private PictureBox pictureBox1;
    }
}