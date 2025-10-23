﻿namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    partial class UcTheThanhVien
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
            panelCRUD = new Panel();
            panelSearch = new TableLayoutPanel();
            btnTimKiem = new Button();
            txtBoxTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnChiTiet = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dgvTheThanhVien = new DataGridView();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheThanhVien).BeginInit();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnChiTiet);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Margin = new Padding(3, 4, 3, 4);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(885, 96);
            panelCRUD.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.ColumnCount = 3;
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8620682F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.3448257F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.08046F));
            panelSearch.Controls.Add(btnTimKiem, 0, 0);
            panelSearch.Controls.Add(txtBoxTimKiem, 1, 0);
            panelSearch.Controls.Add(btnLamMoi, 2, 0);
            panelSearch.Dock = DockStyle.Right;
            panelSearch.Location = new Point(487, 0);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.RowCount = 1;
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelSearch.Size = new Size(398, 96);
            panelSearch.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.FlatAppearance.BorderColor = Color.Black;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(3, 32);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(96, 32);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtBoxTimKiem
            // 
            txtBoxTimKiem.Anchor = AnchorStyles.None;
            txtBoxTimKiem.Location = new Point(106, 34);
            txtBoxTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtBoxTimKiem.Name = "txtBoxTimKiem";
            txtBoxTimKiem.PlaceholderText = "Tìm kiếm...";
            txtBoxTimKiem.Size = new Size(231, 27);
            txtBoxTimKiem.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Image = Properties.Resources.iconRefesh;
            btnLamMoi.Location = new Point(341, 0);
            btnLamMoi.Margin = new Padding(0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(57, 96);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.White;
            btnChiTiet.Dock = DockStyle.Left;
            btnChiTiet.FlatAppearance.BorderSize = 0;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Image = Properties.Resources.iconCT;
            btnChiTiet.Location = new Point(176, 0);
            btnChiTiet.Margin = new Padding(0);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(88, 96);
            btnChiTiet.TabIndex = 3;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Dock = DockStyle.Left;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.iconxoa;
            btnXoa.Location = new Point(88, 0);
            btnXoa.Margin = new Padding(0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 96);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Dock = DockStyle.Left;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.iconsua;
            btnSua.Location = new Point(0, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(88, 96);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvTheThanhVien
            // 
            dgvTheThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheThanhVien.Dock = DockStyle.Fill;
            dgvTheThanhVien.Location = new Point(0, 96);
            dgvTheThanhVien.Margin = new Padding(3, 4, 3, 4);
            dgvTheThanhVien.Name = "dgvTheThanhVien";
            dgvTheThanhVien.RowHeadersWidth = 51;
            dgvTheThanhVien.Size = new Size(885, 569);
            dgvTheThanhVien.TabIndex = 3;
            // 
            // UcTheThanhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTheThanhVien);
            Controls.Add(panelCRUD);
            Name = "UcTheThanhVien";
            Size = new Size(885, 665);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheThanhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnLamMoi;
        private Button btnChiTiet;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvTheThanhVien;
    }
}
