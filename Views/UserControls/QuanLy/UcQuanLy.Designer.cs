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
            pictureBox1 = new PictureBox();
            labelVaiTro = new Label();
            lableEmail = new Label();
            labelGioiTinh = new Label();
            labelDiaChi = new Label();
            labelSDT = new Label();
            labelNgaySinh = new Label();
            labelTen = new Label();
            txtVaiTro = new TextBox();
            txtEmail = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtNgaySinh = new TextBox();
            txtTen = new TextBox();
            panelNavMenu.SuspendLayout();
            panelSubContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnDoimatkhau);
            panelNavMenu.Controls.Add(btnSua);
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(1187, 67);
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
            panelSubContent.Controls.Add(pictureBox1);
            panelSubContent.Controls.Add(labelVaiTro);
            panelSubContent.Controls.Add(lableEmail);
            panelSubContent.Controls.Add(labelGioiTinh);
            panelSubContent.Controls.Add(labelDiaChi);
            panelSubContent.Controls.Add(labelSDT);
            panelSubContent.Controls.Add(labelNgaySinh);
            panelSubContent.Controls.Add(labelTen);
            panelSubContent.Controls.Add(txtVaiTro);
            panelSubContent.Controls.Add(txtEmail);
            panelSubContent.Controls.Add(txtGioiTinh);
            panelSubContent.Controls.Add(txtDiaChi);
            panelSubContent.Controls.Add(txtSDT);
            panelSubContent.Controls.Add(txtNgaySinh);
            panelSubContent.Controls.Add(txtTen);
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(1190, 690);
            panelSubContent.TabIndex = 0;
            panelSubContent.TabStop = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.staff_symbol_svgrepo_com;
            pictureBox1.Location = new Point(57, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // labelVaiTro
            // 
            labelVaiTro.AutoSize = true;
            labelVaiTro.Location = new Point(90, 341);
            labelVaiTro.Name = "labelVaiTro";
            labelVaiTro.Size = new Size(43, 15);
            labelVaiTro.TabIndex = 21;
            labelVaiTro.Text = "Vai trò:";
            // 
            // lableEmail
            // 
            lableEmail.AutoSize = true;
            lableEmail.Location = new Point(405, 341);
            lableEmail.Name = "lableEmail";
            lableEmail.Size = new Size(39, 15);
            lableEmail.TabIndex = 20;
            lableEmail.Text = "Email:";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Location = new Point(729, 341);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(55, 15);
            labelGioiTinh.TabIndex = 19;
            labelGioiTinh.Text = "Giới tính:";
            labelGioiTinh.Visible = false;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(405, 269);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(46, 15);
            labelDiaChi.TabIndex = 18;
            labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(405, 201);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(79, 15);
            labelSDT.TabIndex = 17;
            labelSDT.Text = "Số điện thoại:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(405, 133);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(63, 15);
            labelNgaySinh.TabIndex = 16;
            labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(405, 60);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(61, 15);
            labelTen.TabIndex = 15;
            labelTen.Text = "Họ và tên:";
            // 
            // txtVaiTro
            // 
            txtVaiTro.BackColor = SystemColors.InactiveBorder;
            txtVaiTro.Location = new Point(90, 358);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.ReadOnly = true;
            txtVaiTro.Size = new Size(217, 23);
            txtVaiTro.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.Location = new Point(405, 358);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BackColor = SystemColors.InactiveBorder;
            txtGioiTinh.Location = new Point(729, 358);
            txtGioiTinh.Margin = new Padding(3, 2, 3, 2);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.Size = new Size(265, 23);
            txtGioiTinh.TabIndex = 10;
            txtGioiTinh.Visible = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.InactiveBorder;
            txtDiaChi.Location = new Point(405, 286);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(265, 23);
            txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.InactiveBorder;
            txtSDT.Location = new Point(405, 218);
            txtSDT.Margin = new Padding(3, 2, 3, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(265, 23);
            txtSDT.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.BackColor = SystemColors.InactiveBorder;
            txtNgaySinh.Location = new Point(405, 150);
            txtNgaySinh.Margin = new Padding(3, 2, 3, 2);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.ReadOnly = true;
            txtNgaySinh.Size = new Size(265, 23);
            txtNgaySinh.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.BackColor = SystemColors.InactiveBorder;
            txtTen.Location = new Point(405, 77);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(265, 23);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtVaiTro;
        private Label labelVaiTro;
        private Label lableEmail;
        private Label labelGioiTinh;
        private Label labelDiaChi;
        private Label labelSDT;
        private Label labelNgaySinh;
        private Label labelTen;
        private PictureBox pictureBox1;
    }
}
