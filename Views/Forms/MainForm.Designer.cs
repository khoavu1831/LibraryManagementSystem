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
            button8 = new Button();
            buttonQLNhanVien = new Button();
            button6 = new Button();
            bntPhat = new Button();
            button4 = new Button();
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
            panelNav.Margin = new Padding(3, 4, 3, 4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(210, 789);
            panelNav.TabIndex = 0;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(btnLogout);
            panelLogout.Dock = DockStyle.Bottom;
            panelLogout.Location = new Point(0, 720);
            panelLogout.Margin = new Padding(3, 4, 3, 4);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(208, 67);
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
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(208, 67);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(buttonQLNhanVien);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(bntPhat);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnDocGia);
            panelMenu.Controls.Add(btnQLSach);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 99);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(208, 688);
            panelMenu.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button8.Image = Properties.Resources.icon11;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 469);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(208, 67);
            button8.TabIndex = 7;
            button8.Text = "   Thống Kê";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
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
            buttonQLNhanVien.Location = new Point(0, 402);
            buttonQLNhanVien.Margin = new Padding(3, 4, 3, 4);
            buttonQLNhanVien.Name = "buttonQLNhanVien";
            buttonQLNhanVien.Size = new Size(208, 67);
            buttonQLNhanVien.TabIndex = 6;
            buttonQLNhanVien.Text = "   Nhân Viên";
            buttonQLNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonQLNhanVien.UseVisualStyleBackColor = false;
            buttonQLNhanVien.Click += buttonQLNhanVien_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button6.Image = Properties.Resources.icon7;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 335);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(208, 67);
            button6.TabIndex = 5;
            button6.Text = "   Nhập Sách";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // bntPhat
            // 
            bntPhat.BackColor = Color.White;
            bntPhat.Dock = DockStyle.Top;
            bntPhat.FlatAppearance.BorderSize = 0;
            bntPhat.FlatStyle = FlatStyle.Flat;
            bntPhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            bntPhat.Image = Properties.Resources.icon9;
            bntPhat.ImageAlign = ContentAlignment.MiddleLeft;
            bntPhat.Location = new Point(0, 200);
            bntPhat.Name = "bntPhat";
            bntPhat.Size = new Size(182, 50);
            bntPhat.TabIndex = 4;
            bntPhat.Text = "   Phạt - Trả Phạt";
            bntPhat.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntPhat.UseVisualStyleBackColor = false;
            bntPhat.Click += bntPhat_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.Image = Properties.Resources.icon5;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 201);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(208, 67);
            button4.TabIndex = 3;
            button4.Text = "   Mượn - Trả Sách";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
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
            btnDocGia.Location = new Point(0, 134);
            btnDocGia.Margin = new Padding(3, 4, 3, 4);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(208, 67);
            btnDocGia.TabIndex = 2;
            btnDocGia.Text = "   Thành viên";
            btnDocGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocGia.UseVisualStyleBackColor = false;
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
            btnQLSach.Location = new Point(0, 67);
            btnQLSach.Margin = new Padding(3, 4, 3, 4);
            btnQLSach.Name = "btnQLSach";
            btnQLSach.Size = new Size(208, 67);
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
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(208, 67);
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
            panelUser.Margin = new Padding(3, 4, 3, 4);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(208, 99);
            panelUser.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.BackColor = Color.White;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(57, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(151, 99);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Ronaldo Messi Siuu";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Dock = DockStyle.Left;
            pictureBoxAvatar.Image = Properties.Resources.icon1;
            pictureBoxAvatar.Location = new Point(0, 0);
            pictureBoxAvatar.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(57, 99);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(210, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(852, 789);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 789);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button8;
        private Button buttonQLNhanVien;
        private Button button6;
        private Button bntPhat;
        private Button button4;
        private Button btnDocGia;
        private Button btnQLSach;
        private Button btnLogout;
        private Panel panelContent;
    }
}