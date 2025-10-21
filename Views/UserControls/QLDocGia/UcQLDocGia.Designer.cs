namespace LMS.Views.UserControls.QLDocGia
{
    partial class UcQLDocGia
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
            btnTheThanhVien = new Button();
            btnKhachHang = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnTheThanhVien);
            panelNavMenu.Controls.Add(btnKhachHang);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Margin = new Padding(3, 4, 3, 4);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(984, 89);
            panelNavMenu.TabIndex = 2;
            // 
            // btnTheThanhVien
            // 
            btnTheThanhVien.BackColor = Color.White;
            btnTheThanhVien.Dock = DockStyle.Left;
            btnTheThanhVien.FlatStyle = FlatStyle.Flat;
            btnTheThanhVien.Location = new Point(127, 0);
            btnTheThanhVien.Margin = new Padding(3, 4, 3, 4);
            btnTheThanhVien.Name = "btnTheThanhVien";
            btnTheThanhVien.Size = new Size(127, 89);
            btnTheThanhVien.TabIndex = 1;
            btnTheThanhVien.Text = "Thẻ thành viên";
            btnTheThanhVien.UseVisualStyleBackColor = false;
            btnTheThanhVien.Click += btnTheThanhVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.White;
            btnKhachHang.Dock = DockStyle.Left;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 0);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(127, 89);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 89);
            panelSubContent.Margin = new Padding(3, 4, 3, 4);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(984, 723);
            panelSubContent.TabIndex = 4;
            // 
            // UcQLDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQLDocGia";
            Size = new Size(984, 812);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnTheThanhVien;
        private Button btnKhachHang;
        private Panel panelSubContent;
    }
}
