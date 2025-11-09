namespace LMS.Views.UserControls.QuanLy
{
    partial class UcQuanLy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavMenu = new Panel();
            btnDoimatkhau = new Button();
            btnSua = new Button();
            panelSubContent = new Panel();
            txtVaiTro = new TextBox();
            btnVaitro = new Button();
            picAvatar = new PictureBox();
            txtEmail = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtNgaySinh = new TextBox();
            txtTen = new TextBox();
            btnEmail = new Button();
            btnGt = new Button();
            btnDc = new Button();
            btnSdt = new Button();
            btnNs = new Button();
            btnTen = new Button();
            panelNavMenu.SuspendLayout();
            panelSubContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnDoimatkhau);
            panelNavMenu.Controls.Add(btnSua);
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(1485, 67);
            panelNavMenu.TabIndex = 0;
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.Dock = DockStyle.Left;
            btnDoimatkhau.Image = Properties.Resources.icondoimk;
            btnDoimatkhau.Location = new Point(111, 0);
            btnDoimatkhau.Margin = new Padding(0);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(111, 67);
            btnDoimatkhau.TabIndex = 0;
            btnDoimatkhau.TabStop = false;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoimatkhau.UseVisualStyleBackColor = false;
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Left;
            btnSua.Image = Properties.Resources.iconsua;
            btnSua.Location = new Point(0, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(111, 67);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa thông tin";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.BackColor = Color.White;
            panelSubContent.Controls.Add(txtVaiTro);
            panelSubContent.Controls.Add(btnVaitro);
            panelSubContent.Controls.Add(picAvatar);
            panelSubContent.Controls.Add(txtEmail);
            panelSubContent.Controls.Add(txtGioiTinh);
            panelSubContent.Controls.Add(txtDiaChi);
            panelSubContent.Controls.Add(txtSDT);
            panelSubContent.Controls.Add(txtNgaySinh);
            panelSubContent.Controls.Add(txtTen);
            panelSubContent.Controls.Add(btnEmail);
            panelSubContent.Controls.Add(btnGt);
            panelSubContent.Controls.Add(btnDc);
            panelSubContent.Controls.Add(btnSdt);
            panelSubContent.Controls.Add(btnNs);
            panelSubContent.Controls.Add(btnTen);
            panelSubContent.Enabled = false;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(1488, 599);
            panelSubContent.TabIndex = 0;
            panelSubContent.TabStop = true;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(169, 375);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(217, 23);
            txtVaiTro.TabIndex = 14;
            // 
            // btnVaitro
            // 
            btnVaitro.Location = new Point(169, 337);
            btnVaitro.Margin = new Padding(0);
            btnVaitro.Name = "btnVaitro";
            btnVaitro.Size = new Size(82, 22);
            btnVaitro.TabIndex = 13;
            btnVaitro.Text = "Vai Trò:";
            btnVaitro.UseVisualStyleBackColor = false;
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.icon1;
            picAvatar.Location = new Point(153, 83);
            picAvatar.Margin = new Padding(3, 2, 3, 2);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(268, 234);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 12;
            picAvatar.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(586, 416);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(586, 350);
            txtGioiTinh.Margin = new Padding(3, 2, 3, 2);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(322, 23);
            txtGioiTinh.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(586, 276);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(322, 23);
            txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(586, 217);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(322, 23);
            txtSDT.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(586, 156);
            txtNgaySinh.Margin = new Padding(3, 2, 3, 2);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(322, 23);
            txtNgaySinh.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(586, 83);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(322, 23);
            txtTen.TabIndex = 6;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(586, 392);
            btnEmail.Margin = new Padding(0);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(82, 22);
            btnEmail.TabIndex = 5;
            btnEmail.Text = "Email:";
            btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnGt
            // 
            btnGt.Location = new Point(586, 316);
            btnGt.Margin = new Padding(0);
            btnGt.Name = "btnGt";
            btnGt.Size = new Size(82, 22);
            btnGt.TabIndex = 4;
            btnGt.Text = "Giới tính:";
            btnGt.UseVisualStyleBackColor = false;
            // 
            // btnDc
            // 
            btnDc.Location = new Point(586, 252);
            btnDc.Margin = new Padding(0);
            btnDc.Name = "btnDc";
            btnDc.Size = new Size(82, 22);
            btnDc.TabIndex = 3;
            btnDc.Text = "Địa chỉ:";
            btnDc.UseVisualStyleBackColor = false;
            // 
            // btnSdt
            // 
            btnSdt.Location = new Point(586, 193);
            btnSdt.Margin = new Padding(0);
            btnSdt.Name = "btnSdt";
            btnSdt.Size = new Size(100, 22);
            btnSdt.TabIndex = 2;
            btnSdt.Text = "Số điện thoại:";
            btnSdt.UseVisualStyleBackColor = false;
            // 
            // btnNs
            // 
            btnNs.Location = new Point(586, 126);
            btnNs.Margin = new Padding(0);
            btnNs.Name = "btnNs";
            btnNs.Size = new Size(82, 28);
            btnNs.TabIndex = 1;
            btnNs.Text = "Ngày sinh:";
            btnNs.UseVisualStyleBackColor = false;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(586, 59);
            btnTen.Margin = new Padding(0);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(82, 22);
            btnTen.TabIndex = 0;
            btnTen.Text = "Họ và tên:";
            btnTen.UseVisualStyleBackColor = false;
            // 
            // UcQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcQuanLy";
            Size = new Size(1488, 669);
            Load += UcQuanLy_Load_1;
            panelNavMenu.ResumeLayout(false);
            panelSubContent.ResumeLayout(false);
            panelSubContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnDoimatkhau;
        private Button btnSua;
        private Panel panelSubContent;
        private TextBox txtEmail;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtNgaySinh;
        private TextBox txtTen;
        private Button btnEmail;
        private Button btnGt;
        private Button btnDc;
        private Button btnSdt;
        private Button btnNs;
        private Button btnTen;
        private PictureBox picAvatar;
        private TextBox txtVaiTro;
        private Button btnVaitro;
    }
}
