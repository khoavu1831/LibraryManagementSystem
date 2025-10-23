namespace LMS.Views.UserControls.QLThongKe
{
    partial class UcQLThongKe
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
            btnChung = new Button();
            btnSachMuon = new Button();
            btnSachNhap = new Button();
            btnPhieuPhat = new Button();
            btnThanhVien = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnChung);
            panelNavMenu.Controls.Add(btnSachMuon);
            panelNavMenu.Controls.Add(btnSachNhap);
            panelNavMenu.Controls.Add(btnPhieuPhat);
            panelNavMenu.Controls.Add(btnThanhVien);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(984, 89);
            panelNavMenu.TabIndex = 1;
            // 
            // btnChung
            // 
            btnChung.BackColor = Color.White;
            btnChung.Dock = DockStyle.Left;
            btnChung.FlatStyle = FlatStyle.Flat;
            btnChung.Location = new Point(508, 0);
            btnChung.Margin = new Padding(3, 4, 3, 4);
            btnChung.Name = "btnChung";
            btnChung.Size = new Size(127, 89);
            btnChung.TabIndex = 5;
            btnChung.Text = "Chung";
            btnChung.UseVisualStyleBackColor = false;
            btnChung.Click += btnChung_Click;
            // 
            // btnSachMuon
            // 
            btnSachMuon.BackColor = Color.White;
            btnSachMuon.Dock = DockStyle.Left;
            btnSachMuon.FlatStyle = FlatStyle.Flat;
            btnSachMuon.Location = new Point(381, 0);
            btnSachMuon.Margin = new Padding(3, 4, 3, 4);
            btnSachMuon.Name = "btnSachMuon";
            btnSachMuon.Size = new Size(127, 89);
            btnSachMuon.TabIndex = 4;
            btnSachMuon.Text = "Sách mượn";
            btnSachMuon.UseVisualStyleBackColor = false;
            btnSachMuon.Click += btnSachMuon_Click;
            // 
            // btnSachNhap
            // 
            btnSachNhap.BackColor = Color.White;
            btnSachNhap.Dock = DockStyle.Left;
            btnSachNhap.FlatStyle = FlatStyle.Flat;
            btnSachNhap.Location = new Point(254, 0);
            btnSachNhap.Margin = new Padding(3, 4, 3, 4);
            btnSachNhap.Name = "btnSachNhap";
            btnSachNhap.Size = new Size(127, 89);
            btnSachNhap.TabIndex = 3;
            btnSachNhap.Text = "Sách nhập";
            btnSachNhap.UseVisualStyleBackColor = false;
            btnSachNhap.Click += btnSachNhap_Click;
            // 
            // btnPhieuPhat
            // 
            btnPhieuPhat.BackColor = Color.White;
            btnPhieuPhat.Dock = DockStyle.Left;
            btnPhieuPhat.FlatStyle = FlatStyle.Flat;
            btnPhieuPhat.Location = new Point(127, 0);
            btnPhieuPhat.Margin = new Padding(3, 4, 3, 4);
            btnPhieuPhat.Name = "btnPhieuPhat";
            btnPhieuPhat.Size = new Size(127, 89);
            btnPhieuPhat.TabIndex = 2;
            btnPhieuPhat.Text = "Phiếu phạt";
            btnPhieuPhat.UseVisualStyleBackColor = false;
            btnPhieuPhat.Click += btnPhieuPhat_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.BackColor = Color.White;
            btnThanhVien.Dock = DockStyle.Left;
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Location = new Point(0, 0);
            btnThanhVien.Margin = new Padding(3, 4, 3, 4);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(127, 89);
            btnThanhVien.TabIndex = 1;
            btnThanhVien.Text = "Thành viên";
            btnThanhVien.UseVisualStyleBackColor = false;
            btnThanhVien.Click += btnThanhVien_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 89);
            panelSubContent.Margin = new Padding(3, 4, 3, 4);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(984, 723);
            panelSubContent.TabIndex = 3;
            // 
            // UcQLThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQLThongKe";
            Size = new Size(984, 812);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnChung;
        private Button btnSachMuon;
        private Button btnSachNhap;
        private Button btnPhieuPhat;
        private Button btnThanhVien;
        private Panel panelSubContent;
    }
}
