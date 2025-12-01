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
            panelNavMenu.Margin = new Padding(3, 2, 3, 2);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(1060, 67);
            panelNavMenu.TabIndex = 1;
            // 
            // btnChung
            // 
            btnChung.BackColor = Color.White;
            btnChung.Dock = DockStyle.Left;
            btnChung.FlatStyle = FlatStyle.Flat;
            btnChung.Location = new Point(508, 0);
            btnChung.Name = "btnChung";
            btnChung.Size = new Size(111, 67);
            btnChung.TabIndex = 5;
            btnChung.Text = "Sách hot";
            btnChung.UseVisualStyleBackColor = false;
            btnChung.Click += btnChung_Click;
            // 
            // btnSachMuon
            // 
            btnSachMuon.BackColor = Color.White;
            btnSachMuon.Dock = DockStyle.Left;
            btnSachMuon.FlatStyle = FlatStyle.Flat;
            btnSachMuon.Location = new Point(397, 0);
            btnSachMuon.Name = "btnSachMuon";
            btnSachMuon.Size = new Size(111, 67);
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
            btnSachNhap.Location = new Point(273, 0);
            btnSachNhap.Name = "btnSachNhap";
            btnSachNhap.Size = new Size(124, 67);
            btnSachNhap.TabIndex = 3;
            btnSachNhap.Text = "Thống kê phí phạt";
            btnSachNhap.UseVisualStyleBackColor = false;
            btnSachNhap.Click += btnSachNhap_Click;
            // 
            // btnPhieuPhat
            // 
            btnPhieuPhat.BackColor = Color.White;
            btnPhieuPhat.Dock = DockStyle.Left;
            btnPhieuPhat.FlatStyle = FlatStyle.Flat;
            btnPhieuPhat.Location = new Point(111, 0);
            btnPhieuPhat.Name = "btnPhieuPhat";
            btnPhieuPhat.Size = new Size(162, 67);
            btnPhieuPhat.TabIndex = 2;
            btnPhieuPhat.Text = "Thống kê mượn - trả sách";
            btnPhieuPhat.UseVisualStyleBackColor = false;
            btnPhieuPhat.Click += btnPhieuPhat_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.BackColor = Color.White;
            btnThanhVien.Dock = DockStyle.Left;
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Location = new Point(0, 0);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(111, 67);
            btnThanhVien.TabIndex = 1;
            btnThanhVien.Text = "Thống kê sách";
            btnThanhVien.UseVisualStyleBackColor = false;
            btnThanhVien.Click += btnThanhVien_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(1060, 653);
            panelSubContent.TabIndex = 3;
            // 
            // UcQLThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcQLThongKe";
            Size = new Size(1060, 720);
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
