namespace thucHanhBuoi2
{
    partial class form_ThanhToan
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
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            lbLauDon = new Label();
            label2 = new Label();
            lbNauCom = new Label();
            lbGiatUi = new Label();
            label1 = new Label();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Yu Gothic", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(177, 926);
            button1.Name = "button1";
            button1.Size = new Size(238, 58);
            button1.TabIndex = 5;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(lbLauDon, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(lbNauCom, 1, 1);
            tableLayoutPanel1.Controls.Add(lbGiatUi, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 143);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(671, 777);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 516);
            label3.Name = "label3";
            label3.Size = new Size(281, 78);
            label3.TabIndex = 7;
            label3.Text = "Nấu cơm";
            // 
            // lbLauDon
            // 
            lbLauDon.AutoSize = true;
            lbLauDon.Font = new Font("Tahoma", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lbLauDon.ForeColor = SystemColors.Highlight;
            lbLauDon.Location = new Point(290, 0);
            lbLauDon.Name = "lbLauDon";
            lbLauDon.Size = new Size(119, 40);
            lbLauDon.TabIndex = 2;
            lbLauDon.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(248, 78);
            label2.TabIndex = 3;
            label2.Text = "Lau dọn";
            // 
            // lbNauCom
            // 
            lbNauCom.AutoSize = true;
            lbNauCom.Font = new Font("Tahoma", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lbNauCom.ForeColor = SystemColors.Highlight;
            lbNauCom.Location = new Point(290, 258);
            lbNauCom.Name = "lbNauCom";
            lbNauCom.Size = new Size(119, 40);
            lbNauCom.TabIndex = 4;
            lbNauCom.Text = "label3";
            // 
            // lbGiatUi
            // 
            lbGiatUi.AutoSize = true;
            lbGiatUi.Font = new Font("Tahoma", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lbGiatUi.ForeColor = SystemColors.Highlight;
            lbGiatUi.Location = new Point(290, 516);
            lbGiatUi.Name = "lbGiatUi";
            lbGiatUi.Size = new Size(119, 40);
            lbGiatUi.TabIndex = 5;
            lbGiatUi.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 258);
            label1.Name = "label1";
            label1.Size = new Size(229, 78);
            label1.TabIndex = 6;
            label1.Text = "Giặt ủi";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Yu Gothic", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(28, 32);
            button2.Name = "button2";
            button2.Size = new Size(247, 86);
            button2.TabIndex = 8;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = false;
            // 
            // form_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(680, 986);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_ThanhToan";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbLauDon;
        private Label label2;
        private Button button2;
        private Label lbNauCom;
        private Label lbGiatUi;
        private Label label3;
        private Label label1;
    }
}