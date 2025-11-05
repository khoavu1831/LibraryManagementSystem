namespace LMS.Views.UserControls.QLNhanVien
{
    partial class UcQLNhanVien
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
            btnVaiTro = new Button();
            btnTaiKhoan = new Button();
            btnNhanVien = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnVaiTro);
            panelNavMenu.Controls.Add(btnTaiKhoan);
            panelNavMenu.Controls.Add(btnNhanVien);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 1;
            // 
            // btnVaiTro
            // 
            btnVaiTro.BackColor = Color.White;
            btnVaiTro.Dock = DockStyle.Left;
            btnVaiTro.FlatStyle = FlatStyle.Flat;
            btnVaiTro.Location = new Point(222, 0);
            btnVaiTro.Name = "btnVaiTro";
            btnVaiTro.Size = new Size(111, 67);
            btnVaiTro.TabIndex = 2;
            btnVaiTro.Text = "Vai trò";
            btnVaiTro.UseVisualStyleBackColor = false;
            btnVaiTro.Click += btnVaiTro_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = Color.White;
            btnTaiKhoan.Dock = DockStyle.Left;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Location = new Point(111, 0);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(111, 67);
            btnTaiKhoan.TabIndex = 1;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = false;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.White;
            btnNhanVien.Dock = DockStyle.Left;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(111, 67);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 2;
            // 
            // UcQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcQLNhanVien";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnVaiTro;
        private Button btnTaiKhoan;
        private Button btnNhanVien;
        private Panel panelSubContent;
    }
}
