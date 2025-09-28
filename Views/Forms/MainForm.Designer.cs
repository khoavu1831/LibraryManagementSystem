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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
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
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnDocGia);
            panelMenu.Controls.Add(btnQLSach);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 74);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(182, 516);
            panelMenu.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.icon3;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 350);
            button8.Name = "button8";
            button8.Size = new Size(182, 50);
            button8.TabIndex = 7;
            button8.Text = "Sách";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.icon3;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 300);
            button7.Name = "button7";
            button7.Size = new Size(182, 50);
            button7.TabIndex = 6;
            button7.Text = "Sách";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.icon3;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 250);
            button6.Name = "button6";
            button6.Size = new Size(182, 50);
            button6.TabIndex = 5;
            button6.Text = "Sách";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.icon3;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 200);
            button5.Name = "button5";
            button5.Size = new Size(182, 50);
            button5.TabIndex = 4;
            button5.Text = "Sách";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.icon3;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 150);
            button4.Name = "button4";
            button4.Size = new Size(182, 50);
            button4.TabIndex = 3;
            button4.Text = "Sách";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // btnDocGia
            // 
            btnDocGia.BackColor = Color.White;
            btnDocGia.Dock = DockStyle.Top;
            btnDocGia.FlatAppearance.BorderSize = 0;
            btnDocGia.FlatStyle = FlatStyle.Flat;
            btnDocGia.Image = Properties.Resources.icon4;
            btnDocGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocGia.Location = new Point(0, 100);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(182, 50);
            btnDocGia.TabIndex = 2;
            btnDocGia.Text = "Độc Giả";
            btnDocGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDocGia.UseVisualStyleBackColor = false;
            // 
            // btnQLSach
            // 
            btnQLSach.BackColor = Color.White;
            btnQLSach.Dock = DockStyle.Top;
            btnQLSach.FlatAppearance.BorderSize = 0;
            btnQLSach.FlatStyle = FlatStyle.Flat;
            btnQLSach.Image = Properties.Resources.icon3;
            btnQLSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLSach.Location = new Point(0, 50);
            btnQLSach.Name = "btnQLSach";
            btnQLSach.Size = new Size(182, 50);
            btnQLSach.TabIndex = 1;
            btnQLSach.Text = "Sách";
            btnQLSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLSach.UseVisualStyleBackColor = false;
            btnQLSach.Click += BtnQLSach_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.White;
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Image = Properties.Resources.icon2;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(182, 50);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += BtnTrangChu_Click;
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
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnDocGia;
        private Button btnQLSach;
        private Button btnLogout;
        private Panel panelContent;
    }
}