namespace LMS.Views.UserControls.QuanLy
{
    partial class FormSuaThongTin
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
            label1 = new Label();
            panel1 = new Panel();
            labelEmail = new Label();
            labelGioiTinh = new Label();
            labelDiaChi = new Label();
            labelSDT = new Label();
            labelVaiTro = new Label();
            labelNgaySinh = new Label();
            labelTen = new Label();
            button8 = new Button();
            txtEmail = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtVaiTro = new TextBox();
            txtNgaySinh = new TextBox();
            txtTen = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(779, 52);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelGioiTinh);
            panel1.Controls.Add(labelDiaChi);
            panel1.Controls.Add(labelSDT);
            panel1.Controls.Add(labelVaiTro);
            panel1.Controls.Add(labelNgaySinh);
            panel1.Controls.Add(labelTen);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtGioiTinh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtVaiTro);
            panel1.Controls.Add(txtNgaySinh);
            panel1.Controls.Add(txtTen);
            panel1.Location = new Point(0, 55);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 321);
            panel1.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(427, 182);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 21;
            labelEmail.Text = "Email:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(427, 115);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(55, 15);
            labelGioiTinh.TabIndex = 20;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(427, 54);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(46, 15);
            labelDiaChi.TabIndex = 19;
            labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(119, 249);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(79, 15);
            labelSDT.TabIndex = 18;
            labelSDT.Text = "Số điện thoại:";
            // 
            // labelVaiTro
            // 
            labelVaiTro.AutoSize = true;
            labelVaiTro.Location = new Point(119, 182);
            labelVaiTro.Name = "labelVaiTro";
            labelVaiTro.Size = new Size(43, 15);
            labelVaiTro.TabIndex = 17;
            labelVaiTro.Text = "Vai trò:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(119, 115);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(63, 15);
            labelNgaySinh.TabIndex = 16;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(119, 54);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(61, 15);
            labelTen.TabIndex = 15;
            labelTen.Text = "Họ và tên:";
            // 
            // button8
            // 
            button8.BackColor = Color.DarkSeaGreen;
            button8.Font = new Font("Segoe UI", 16F);
            button8.Location = new Point(498, 240);
            button8.Name = "button8";
            button8.Size = new Size(119, 49);
            button8.TabIndex = 14;
            button8.Text = "XONG";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(427, 199);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(427, 132);
            txtGioiTinh.Margin = new Padding(3, 2, 3, 2);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(254, 23);
            txtGioiTinh.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(427, 71);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(254, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(119, 266);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(238, 23);
            txtSDT.TabIndex = 10;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(119, 199);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(238, 23);
            txtVaiTro.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(119, 132);
            txtNgaySinh.Margin = new Padding(3, 2, 3, 2);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(238, 23);
            txtNgaySinh.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(119, 71);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(238, 23);
            txtTen.TabIndex = 7;
            // 
            // FormSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 375);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSuaThongTin";
            Text = "FormSuaThongTin";
            Load += FormSuaThongTin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtEmail;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtVaiTro;
        private TextBox txtNgaySinh;
        private TextBox txtTen;
        private Button button8;
        private Label labelEmail;
        private Label labelGioiTinh;
        private Label labelDiaChi;
        private Label labelSDT;
        private Label labelVaiTro;
        private Label labelNgaySinh;
        private Label labelTen;
    }
}