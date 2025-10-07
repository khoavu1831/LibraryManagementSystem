namespace LibraryManagementSystem.Views.Forms
{
    partial class MainForm
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
            panelNav = new Panel();
            panelLogout = new Panel();
            btnLogout = new Button();
            panelMenu = new Panel();
            btnQLThongKe = new Button();
            buttonQLNhanVien = new Button();
            btnNhapSach = new Button();
            btnPhat = new Button();
            buttonQLMuonTraSach = new Button();
            btnDocGia = new Button();
            btnQLSach = new Button();
            btnTrangChu = new Button();
            panelUser = new Panel();
            labelUsername = new Label();
            pictureBoxAvatar = new PictureBox();
            panelContent = new Panel();
            panelNav.SuspendLayout();
            panelLogout.SuspendLayout();
            panelMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.White;
            panelNav.BorderStyle = BorderStyle.FixedSingle;
            panelNav.Controls.Add(panelLogout);
            panelNav.Controls.Add(panelMenu);
            panelNav.Controls.Add(panelUser);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(184, 592);
            panelNav.TabIndex = 0;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(btnLogout);
            panelLogout.Dock = DockStyle.Bottom;
            panelLogout.Location = new Point(0, 540);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(182, 50);
            panelLogout.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Image = Properties.Resources.icon12;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(182, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnQLThongKe);
            panelMenu.Controls.Add(buttonQLNhanVien);
            panelMenu.Controls.Add(btnNhapSach);
            panelMenu.Controls.Add(btnPhat);
            panelMenu.Controls.Add(buttonQLMuonTraSach);
            panelMenu.Controls.Add(btnDocGia);
            panelMenu.Controls.Add(btnQLSach);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 74);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(182, 516);
            panelMenu.TabIndex = 1;
            // 
            // btnQLThongKe
            // 
            btnQLThongKe.BackColor = Color.White;
            btnQLThongKe.Dock = DockStyle.Top;
            btnQLThongKe.FlatAppearance.BorderSize = 0;
            btnQLThongKe.FlatStyle = FlatStyle.Flat;
            btnQLThongKe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnQLThongKe.Image = Properties.Resources.icon11;
            btnQLThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLThongKe.Location = new Point(0, 338);
            btnQLThongKe.Name = "btnQLThongKe";
            btnQLThongKe.Size = new Size(182, 50);
            btnQLThongKe.TabIndex = 7;
            btnQLThongKe.Text = "   Thống Kê";
            btnQLThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLThongKe.UseVisualStyleBackColor = false;
            btnQLThongKe.Click += btnQLThongKe_Click;
            // 
            // buttonQLNhanVien
            // 
            buttonQLNhanVien.BackColor = Color.White;
            buttonQLNhanVien.Dock = DockStyle.Top;
            buttonQLNhanVien.FlatAppearance.BorderSize = 0;
            buttonQLNhanVien.FlatStyle = FlatStyle.Flat;
            buttonQLNhanVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonQLNhanVien.Image = Properties.Resources.icon41;
            buttonQLNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLNhanVien.Location = new Point(0, 288);
            buttonQLNhanVien.Name = "buttonQLNhanVien";
            buttonQLNhanVien.Size = new Size(182, 50);
            buttonQLNhanVien.TabIndex = 6;
            buttonQLNhanVien.Text = "   Nhân Viên";
            buttonQLNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLNhanVien.UseVisualStyleBackColor = false;
            buttonQLNhanVien.Click += buttonQLNhanVien_Click;
            // 
            // btnNhapSach
            // 
            btnNhapSach.BackColor = Color.White;
            btnNhapSach.Dock = DockStyle.Top;
            btnNhapSach.FlatAppearance.BorderSize = 0;
            btnNhapSach.FlatStyle = FlatStyle.Flat;
            btnNhapSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNhapSach.Image = Properties.Resources.icon7;
            btnNhapSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapSach.Location = new Point(0, 238);
            btnNhapSach.Name = "btnNhapSach";
            btnNhapSach.Size = new Size(182, 50);
            btnNhapSach.TabIndex = 5;
            btnNhapSach.Text = "   Nhập Sách";
            btnNhapSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapSach.UseVisualStyleBackColor = false;
            btnNhapSach.Click += btnQLNhapSach_Click;
            // 
            // btnPhat
            // 
            btnPhat.BackColor = Color.White;
            btnPhat.Dock = DockStyle.Top;
            btnPhat.FlatAppearance.BorderSize = 0;
            btnPhat.FlatStyle = FlatStyle.Flat;
            btnPhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPhat.Image = Properties.Resources.icon9;
            btnPhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhat.Location = new Point(0, 200);
            btnPhat.Margin = new Padding(3, 2, 3, 2);
            btnPhat.Name = "btnPhat";
            btnPhat.Size = new Size(182, 38);
            btnPhat.TabIndex = 4;
            btnPhat.Text = "   Phạt - Trả Phạt";
            btnPhat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhat.UseVisualStyleBackColor = false;
            btnPhat.Click += bntPhat_Click;
            // 
            // buttonQLMuonTraSach
            // 
            buttonQLMuonTraSach.BackColor = Color.White;
            buttonQLMuonTraSach.Dock = DockStyle.Top;
            buttonQLMuonTraSach.FlatAppearance.BorderSize = 0;
            buttonQLMuonTraSach.FlatStyle = FlatStyle.Flat;
            buttonQLMuonTraSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            buttonQLMuonTraSach.Image = Properties.Resources.icon5;
            buttonQLMuonTraSach.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQLMuonTraSach.Location = new Point(0, 150);
            buttonQLMuonTraSach.Name = "buttonQLMuonTraSach";
            buttonQLMuonTraSach.Size = new Size(182, 50);
            buttonQLMuonTraSach.TabIndex = 3;
            buttonQLMuonTraSach.Text = "   Mượn - Trả Sách";
            buttonQLMuonTraSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLMuonTraSach.UseVisualStyleBackColor = false;
            buttonQLMuonTraSach.Click += buttonQLMuonTraSach_Click;
            // 
            // btnDocGia
            // 
            btnDocGia.BackColor = Color.White;
            btnDocGia.Dock = DockStyle.Top;
            btnDocGia.FlatAppearance.BorderSize = 0;
            btnDocGia.FlatStyle = FlatStyle.Flat;
            btnDocGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDocGia.Image = Properties.Resources.icon10;
            btnDocGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocGia.Location = new Point(0, 100);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(182, 50);
            btnDocGia.TabIndex = 2;
            btnDocGia.Text = "   Thành viên";
            btnDocGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocGia.UseVisualStyleBackColor = false;
            btnDocGia.Click += btnDocGia_Click;
            // 
            // btnQLSach
            // 
            btnQLSach.BackColor = Color.White;
            btnQLSach.Dock = DockStyle.Top;
            btnQLSach.FlatAppearance.BorderSize = 0;
            btnQLSach.FlatStyle = FlatStyle.Flat;
            btnQLSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnQLSach.Image = Properties.Resources.icon3;
            btnQLSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLSach.Location = new Point(0, 50);
            btnQLSach.Name = "btnQLSach";
            btnQLSach.Size = new Size(182, 50);
            btnQLSach.TabIndex = 1;
            btnQLSach.Text = "   Sách";
            btnQLSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLSach.UseVisualStyleBackColor = false;
            btnQLSach.Click += btnQLSach_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.White;
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTrangChu.Image = Properties.Resources.icon2;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(182, 50);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "   Trang Chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(labelUsername);
            panelUser.Controls.Add(pictureBoxAvatar);
            panelUser.Dock = DockStyle.Top;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(182, 74);
            panelUser.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.BackColor = Color.White;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(50, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(132, 74);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Ronaldo Messi Siuu";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            labelUsername.Click += labelUsername_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Dock = DockStyle.Left;
            pictureBoxAvatar.Image = Properties.Resources.icon1;
            pictureBoxAvatar.Location = new Point(0, 0);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(50, 74);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(184, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(745, 592);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 592);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Name = "MainForm";
            Text = "MainForm";
            panelNav.ResumeLayout(false);
            panelLogout.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Panel panelLogout;
        private Panel panelMenu;
        private Panel panelUser;
        private Button btnTrangChu;
        private Label labelUsername;
        private PictureBox pictureBoxAvatar;
        private Button btnQLThongKe;
        private Button buttonQLNhanVien;
        private Button btnNhapSach;
        private Button btnPhat;
        private Button buttonQLMuonTraSach;
        private Button btnDocGia;
        private Button btnQLSach;
        private Button btnLogout;
        private Panel panelContent;
    }
}