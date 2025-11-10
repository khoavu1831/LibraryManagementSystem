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
            labelVaiTro = new Label();
            lableEmail = new Label();
            labelGioiTinh = new Label();
            labelDiaChi = new Label();
            labelSDT = new Label();
            labelNgaySinh = new Label();
            labelTen = new Label();
            txtVaiTro = new TextBox();
            picAvatar = new PictureBox();
            txtEmail = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtNgaySinh = new TextBox();
            txtTen = new TextBox();
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
            panelSubContent.Controls.Add(labelVaiTro);
            panelSubContent.Controls.Add(lableEmail);
            panelSubContent.Controls.Add(labelGioiTinh);
            panelSubContent.Controls.Add(labelDiaChi);
            panelSubContent.Controls.Add(labelSDT);
            panelSubContent.Controls.Add(labelNgaySinh);
            panelSubContent.Controls.Add(labelTen);
            panelSubContent.Controls.Add(txtVaiTro);
            panelSubContent.Controls.Add(picAvatar);
            panelSubContent.Controls.Add(txtEmail);
            panelSubContent.Controls.Add(txtGioiTinh);
            panelSubContent.Controls.Add(txtDiaChi);
            panelSubContent.Controls.Add(txtSDT);
            panelSubContent.Controls.Add(txtNgaySinh);
            panelSubContent.Controls.Add(txtTen);
            panelSubContent.Enabled = false;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(1488, 599);
            panelSubContent.TabIndex = 0;
            panelSubContent.TabStop = true;
            // 
            // labelVaiTro
            // 
            labelVaiTro.AutoSize = true;
            labelVaiTro.Location = new Point(169, 358);
            labelVaiTro.Name = "labelVaiTro";
            labelVaiTro.Size = new Size(43, 15);
            labelVaiTro.TabIndex = 21;
            labelVaiTro.Text = "Vai trò:";
            // 
            // lableEmail
            // 
            lableEmail.AutoSize = true;
            lableEmail.Location = new Point(586, 399);
            lableEmail.Name = "lableEmail";
            lableEmail.Size = new Size(39, 15);
            lableEmail.TabIndex = 20;
            lableEmail.Text = "Email:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(586, 333);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(55, 15);
            labelGioiTinh.TabIndex = 19;
            labelGioiTinh.Text = "Giới tính:";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(586, 259);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(46, 15);
            labelDiaChi.TabIndex = 18;
            labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(586, 200);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(79, 15);
            labelSDT.TabIndex = 17;
            labelSDT.Text = "Số điện thoại:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(586, 139);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(63, 15);
            labelNgaySinh.TabIndex = 16;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(586, 66);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(61, 15);
            labelTen.TabIndex = 15;
            labelTen.Text = "Họ và tên:";
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(169, 375);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(217, 23);
            txtVaiTro.TabIndex = 14;
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
        private PictureBox picAvatar;
        private TextBox txtVaiTro;
        private Label labelVaiTro;
        private Label lableEmail;
        private Label labelGioiTinh;
        private Label labelDiaChi;
        private Label labelSDT;
        private Label labelNgaySinh;
        private Label labelTen;
    }
}
