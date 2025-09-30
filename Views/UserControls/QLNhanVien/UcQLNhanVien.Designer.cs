namespace LibraryManagementSystem.Views.UserControls.QLNhanVien
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
            btnQuyen = new Button();
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
            panelNavMenu.Controls.Add(btnQuyen);
            panelNavMenu.Controls.Add(btnVaiTro);
            panelNavMenu.Controls.Add(btnTaiKhoan);
            panelNavMenu.Controls.Add(btnNhanVien);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Margin = new Padding(3, 4, 3, 4);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(984, 89);
            panelNavMenu.TabIndex = 1;
            // 
            // btnQuyen
            // 
            btnQuyen.BackColor = Color.White;
            btnQuyen.Dock = DockStyle.Left;
            btnQuyen.FlatStyle = FlatStyle.Flat;
            btnQuyen.Location = new Point(381, 0);
            btnQuyen.Margin = new Padding(3, 4, 3, 4);
            btnQuyen.Name = "btnQuyen";
            btnQuyen.Size = new Size(127, 89);
            btnQuyen.TabIndex = 3;
            btnQuyen.Text = "Quyền";
            btnQuyen.UseVisualStyleBackColor = false;
            // 
            // btnVaiTro
            // 
            btnVaiTro.BackColor = Color.White;
            btnVaiTro.Dock = DockStyle.Left;
            btnVaiTro.FlatStyle = FlatStyle.Flat;
            btnVaiTro.Location = new Point(254, 0);
            btnVaiTro.Margin = new Padding(3, 4, 3, 4);
            btnVaiTro.Name = "btnVaiTro";
            btnVaiTro.Size = new Size(127, 89);
            btnVaiTro.TabIndex = 2;
            btnVaiTro.Text = "Vai trò";
            btnVaiTro.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = Color.White;
            btnTaiKhoan.Dock = DockStyle.Left;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Location = new Point(127, 0);
            btnTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(127, 89);
            btnTaiKhoan.TabIndex = 1;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.White;
            btnNhanVien.Dock = DockStyle.Left;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 0);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(127, 89);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 89);
            panelSubContent.Margin = new Padding(3, 4, 3, 4);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(984, 723);
            panelSubContent.TabIndex = 2;
            // 
            // UcQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQLNhanVien";
            Size = new Size(984, 812);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnQuyen;
        private Button btnVaiTro;
        private Button btnTaiKhoan;
        private Button btnNhanVien;
        private Panel panelSubContent;
    }
}
