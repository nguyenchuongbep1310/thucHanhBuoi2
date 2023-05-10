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
            tbPass = new TextBox();
            tbUser = new TextBox();
            cbSave = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(627, 959);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 93);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbPass.ForeColor = SystemColors.AppWorkspace;
            tbPass.Location = new Point(101, 417);
            tbPass.Margin = new Padding(4);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(493, 52);
            tbPass.TabIndex = 21;
            tbPass.Text = "Mật khẩu";
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Tahoma", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            tbUser.ForeColor = SystemColors.AppWorkspace;
            tbUser.Location = new Point(101, 346);
            tbUser.Margin = new Padding(4);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(493, 52);
            tbUser.TabIndex = 20;
            tbUser.Text = "Email";
            // 
            // cbSave
            // 
            cbSave.AutoSize = true;
            cbSave.Checked = true;
            cbSave.CheckState = CheckState.Checked;
            cbSave.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbSave.Location = new Point(60, 514);
            cbSave.Margin = new Padding(4);
            cbSave.Name = "cbSave";
            cbSave.Size = new Size(376, 41);
            cbSave.TabIndex = 22;
            cbSave.Text = "Lưu thông tin đăng nhập";
            cbSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(444, 514);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 23;
            label1.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(101, 570);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(486, 102);
            button1.TabIndex = 24;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(207, 714);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 38);
            label2.TabIndex = 28;
            label2.Text = "Hoặc đăng nhập bằng";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3643728_balloon_chat_conversation_speak_word_icon;
            pictureBox2.Location = new Point(162, 801);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(394, 801);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(135, 916);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 34);
            label3.TabIndex = 31;
            label3.Text = "Gửi mã OTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(372, 916);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 34);
            label4.TabIndex = 32;
            label4.Text = "Facebook";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(714, 317);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // form_dangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(714, 1050);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbSave);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "form_dangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_dangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbPass;
        private TextBox tbUser;
        private CheckBox cbSave;
        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
    }
}