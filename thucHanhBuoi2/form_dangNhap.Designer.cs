namespace thucHanhBuoi2
{
    partial class form_dangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dangNhap));
            pictureBox1 = new PictureBox();
            txt_matKhau = new TextBox();
            txt_email = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(621, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 93);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Location = new Point(98, 224);
            txt_matKhau.Margin = new Padding(4);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Size = new Size(493, 35);
            txt_matKhau.TabIndex = 21;
            txt_matKhau.Text = "Mật khẩu";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(98, 153);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(493, 35);
            txt_email.TabIndex = 20;
            txt_email.Text = "Email";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(98, 310);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(270, 34);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Lưu thông tin đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 310);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 23;
            label1.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            button1.Location = new Point(98, 412);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(495, 111);
            button1.TabIndex = 24;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 632);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(495, 111);
            button2.TabIndex = 25;
            button2.Text = "OTP/SMS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(98, 752);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(495, 111);
            button3.TabIndex = 26;
            button3.Text = "Facebook";
            button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(288, 867);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 30);
            linkLabel1.TabIndex = 27;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 561);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 28;
            label2.Text = "Hoặc đăng nhập bằng";
            // 
            // form_dangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 1050);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(txt_matKhau);
            Controls.Add(txt_email);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "form_dangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_dangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_matKhau;
        private TextBox txt_email;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}