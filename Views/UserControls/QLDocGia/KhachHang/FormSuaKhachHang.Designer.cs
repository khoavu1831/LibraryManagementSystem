namespace LibraryManagementSystem.Views.UserControls.QLDocGia.KhachHang
{
    partial class FormSuaKhachHang
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
            labelTitle = new Label();
            panel1 = new Panel();
            textBoxEmail = new TextBox();
            textBoxSoDienThoai = new TextBox();
            textBoxNgaySinh = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxTenKhachHang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnSua = new Button();
            btnHuy = new Button();
            panel1.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(499, 125);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "SỬA KHÁCH HÀNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanelButtons);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxSoDienThoai);
            panel1.Controls.Add(textBoxNgaySinh);
            panel1.Controls.Add(textBoxDiaChi);
            panel1.Controls.Add(textBoxTenKhachHang);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 430);
            panel1.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(200, 259);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(278, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxSoDienThoai
            // 
            textBoxSoDienThoai.Location = new Point(200, 206);
            textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            textBoxSoDienThoai.Size = new Size(278, 27);
            textBoxSoDienThoai.TabIndex = 10;
            // 
            // textBoxNgaySinh
            // 
            textBoxNgaySinh.Location = new Point(200, 147);
            textBoxNgaySinh.Name = "textBoxNgaySinh";
            textBoxNgaySinh.Size = new Size(278, 27);
            textBoxNgaySinh.TabIndex = 11;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(200, 99);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(278, 27);
            textBoxDiaChi.TabIndex = 12;
            // 
            // textBoxTenKhachHang
            // 
            textBoxTenKhachHang.Location = new Point(200, 50);
            textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            textBoxTenKhachHang.Size = new Size(278, 27);
            textBoxTenKhachHang.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(50, 266);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(50, 213);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(50, 154);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(50, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Địa chỉ:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(50, 50);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên khách hàng:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnSua, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(50, 328);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButtons.Size = new Size(409, 53);
            tableLayoutPanelButtons.TabIndex = 21;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Top;
            btnSua.Location = new Point(3, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(198, 45);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(207, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(199, 45);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormSuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 555);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Name = "FormSuaKhachHang";
            Text = "FormSuaKhachHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private TextBox textBoxEmail;
        private TextBox textBoxSoDienThoai;
        private TextBox textBoxNgaySinh;
        private TextBox textBoxDiaChi;
        private TextBox textBoxTenKhachHang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnSua;
        private Button btnHuy;
    }
}