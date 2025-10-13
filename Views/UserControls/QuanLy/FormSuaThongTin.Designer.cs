namespace LibraryManagementSystem.Views.UserControls.QuanLy
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
            label2 = new Label();
            txtEmail = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtVaiTro = new TextBox();
            txtNgaySinh = new TextBox();
            txtTen = new TextBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            label1.Size = new Size(890, 70);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtGioiTinh);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtVaiTro);
            panel1.Controls.Add(txtNgaySinh);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 428);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.SpringGreen;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(570, 332);
            label2.Name = "label2";
            label2.Size = new Size(120, 50);
            label2.TabIndex = 14;
            label2.Text = "XONG";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(488, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(488, 176);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(290, 27);
            txtGioiTinh.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(488, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(290, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(136, 355);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(272, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(136, 265);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(272, 27);
            txtVaiTro.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(136, 176);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(272, 27);
            txtNgaySinh.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(136, 95);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(272, 27);
            txtTen.TabIndex = 7;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(136, 320);
            button7.Name = "button7";
            button7.Size = new Size(123, 29);
            button7.TabIndex = 6;
            button7.Text = "Số điện thoại:";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(488, 230);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "Email:";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(136, 230);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Vai trò:";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(488, 141);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Giới tính:";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(136, 141);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Ngày sinh:";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(488, 60);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Địa chỉ:";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(136, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Họ và tên:";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 500);
            Controls.Add(panel1);
            Controls.Add(label1);
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
        private Button button1;
        private TextBox txtEmail;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtVaiTro;
        private TextBox txtNgaySinh;
        private TextBox txtTen;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
    }
}