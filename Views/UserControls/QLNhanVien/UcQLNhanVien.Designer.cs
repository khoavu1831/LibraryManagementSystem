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
            btnNXB = new Button();
            btnTacGia = new Button();
            btnBanSaoSach = new Button();
            btnNhanVien = new Button();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.Controls.Add(btnNXB);
            panelNavMenu.Controls.Add(btnTacGia);
            panelNavMenu.Controls.Add(btnBanSaoSach);
            panelNavMenu.Controls.Add(btnNhanVien);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Margin = new Padding(3, 4, 3, 4);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(984, 89);
            panelNavMenu.TabIndex = 1;
            // 
            // btnNXB
            // 
            btnNXB.BackColor = Color.White;
            btnNXB.Dock = DockStyle.Left;
            btnNXB.FlatStyle = FlatStyle.Flat;
            btnNXB.Location = new Point(381, 0);
            btnNXB.Margin = new Padding(3, 4, 3, 4);
            btnNXB.Name = "btnNXB";
            btnNXB.Size = new Size(127, 89);
            btnNXB.TabIndex = 3;
            btnNXB.Text = "Quyền";
            btnNXB.UseVisualStyleBackColor = false;
            // 
            // btnTacGia
            // 
            btnTacGia.BackColor = Color.White;
            btnTacGia.Dock = DockStyle.Left;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Location = new Point(254, 0);
            btnTacGia.Margin = new Padding(3, 4, 3, 4);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(127, 89);
            btnTacGia.TabIndex = 2;
            btnTacGia.Text = "Vai trò";
            btnTacGia.UseVisualStyleBackColor = false;
            // 
            // btnBanSaoSach
            // 
            btnBanSaoSach.BackColor = Color.White;
            btnBanSaoSach.Dock = DockStyle.Left;
            btnBanSaoSach.FlatStyle = FlatStyle.Flat;
            btnBanSaoSach.Location = new Point(127, 0);
            btnBanSaoSach.Margin = new Padding(3, 4, 3, 4);
            btnBanSaoSach.Name = "btnBanSaoSach";
            btnBanSaoSach.Size = new Size(127, 89);
            btnBanSaoSach.TabIndex = 1;
            btnBanSaoSach.Text = "Tài khoản";
            btnBanSaoSach.UseVisualStyleBackColor = false;
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
            // UcQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNavMenu);
            Name = "UcQLNhanVien";
            Size = new Size(984, 723);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnNXB;
        private Button btnTacGia;
        private Button btnBanSaoSach;
        private Button btnNhanVien;
    }
}
