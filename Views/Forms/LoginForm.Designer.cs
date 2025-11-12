namespace LMS.Forms
{
    partial class LoginForm
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
            panelLayout = new Panel();
            flowLayoutPanelRight = new FlowLayoutPanel();
            labelUsername = new Label();
            textBoxTenDangNhap = new TextBox();
            labelPassword = new Label();
            textBoxMatKhau = new TextBox();
            checkBoxAnHien = new CheckBox();
            buttonDangNhap = new Button();
            pictureBoxImage = new PictureBox();
            panelLayout.SuspendLayout();
            flowLayoutPanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Controls.Add(flowLayoutPanelRight);
            panelLayout.Controls.Add(pictureBoxImage);
            panelLayout.Dock = DockStyle.Fill;
            panelLayout.Location = new Point(0, 0);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(653, 417);
            panelLayout.TabIndex = 0;
            // 
            // flowLayoutPanelRight
            // 
            flowLayoutPanelRight.Controls.Add(labelUsername);
            flowLayoutPanelRight.Controls.Add(textBoxTenDangNhap);
            flowLayoutPanelRight.Controls.Add(labelPassword);
            flowLayoutPanelRight.Controls.Add(textBoxMatKhau);
            flowLayoutPanelRight.Controls.Add(checkBoxAnHien);
            flowLayoutPanelRight.Controls.Add(buttonDangNhap);
            flowLayoutPanelRight.Dock = DockStyle.Fill;
            flowLayoutPanelRight.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelRight.Location = new Point(428, 0);
            flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            flowLayoutPanelRight.Size = new Size(225, 417);
            flowLayoutPanelRight.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 14.25F);
            labelUsername.Location = new Point(0, 120);
            labelUsername.Margin = new Padding(0, 120, 0, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(141, 25);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Tên đăng nhập:";
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Location = new Point(3, 148);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(210, 23);
            textBoxTenDangNhap.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14.25F);
            labelPassword.Location = new Point(3, 174);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(95, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(3, 202);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(210, 23);
            textBoxMatKhau.TabIndex = 1;
            textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // checkBoxAnHien
            // 
            checkBoxAnHien.AutoSize = true;
            checkBoxAnHien.Dock = DockStyle.Right;
            checkBoxAnHien.Location = new Point(91, 231);
            checkBoxAnHien.Name = "checkBoxAnHien";
            checkBoxAnHien.Size = new Size(122, 19);
            checkBoxAnHien.TabIndex = 2;
            checkBoxAnHien.Text = "Ẩn/hiện mật khẩu";
            checkBoxAnHien.UseVisualStyleBackColor = true;
            checkBoxAnHien.CheckedChanged += checkBoxAnHien_CheckedChanged;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.BackColor = Color.LightSkyBlue;
            buttonDangNhap.Dock = DockStyle.Fill;
            buttonDangNhap.FlatStyle = FlatStyle.System;
            buttonDangNhap.ForeColor = SystemColors.ControlLightLight;
            buttonDangNhap.Location = new Point(3, 256);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(210, 23);
            buttonDangNhap.TabIndex = 3;
            buttonDangNhap.Text = "ĐĂNG NHẬP";
            buttonDangNhap.UseVisualStyleBackColor = false;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Left;
            pictureBoxImage.Image = Views.Properties.Resources.thuvien;
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(428, 417);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 417);
            Controls.Add(panelLayout);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            panelLayout.ResumeLayout(false);
            flowLayoutPanelRight.ResumeLayout(false);
            flowLayoutPanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayout;
        private FlowLayoutPanel flowLayoutPanelRight;
        private Label labelUsername;
        private TextBox textBoxMatKhau;
        private Label labelPassword;
        private PictureBox pictureBoxImage;
        private TextBox textBoxTenDangNhap;
        private CheckBox checkBoxAnHien;
        private Button buttonDangNhap;
    }
}