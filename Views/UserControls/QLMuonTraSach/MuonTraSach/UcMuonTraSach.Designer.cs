using LMS.Views.Properties;

namespace LMS.Views.UserControls.QLMuonTraSach
{
    partial class UcMuonTraSach
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
            btnExcel = new Button();
            btnChiTiet = new Button();
            btnListHuy = new Button();
            panelSearch = new TableLayoutPanel();
            btnTimKiem = new Button();
            txtBoxTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnHuy = new Button();
            btnThem = new Button();
            dgvPhieuMuonTra = new DataGridView();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuonTra).BeginInit();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(btnExcel);
            panelCRUD.Controls.Add(btnChiTiet);
            panelCRUD.Controls.Add(btnListHuy);
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnHuy);
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(774, 72);
            panelCRUD.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.Dock = DockStyle.Left;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Image = Properties.Resources.iconExc;
            btnExcel.Location = new Point(308, 0);
            btnExcel.Margin = new Padding(0);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(77, 72);
            btnExcel.TabIndex = 13;
            btnExcel.Text = "Xuất Excel";
            btnExcel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.White;
            btnChiTiet.Dock = DockStyle.Left;
            btnChiTiet.FlatAppearance.BorderSize = 0;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Image = Properties.Resources.iconCT;
            btnChiTiet.Location = new Point(231, 0);
            btnChiTiet.Margin = new Padding(0);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(77, 72);
            btnChiTiet.TabIndex = 12;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnListHuy
            // 
            btnListHuy.BackColor = Color.White;
            btnListHuy.Dock = DockStyle.Left;
            btnListHuy.FlatAppearance.BorderSize = 0;
            btnListHuy.FlatStyle = FlatStyle.Flat;
            btnListHuy.Image = Properties.Resources.iconRac;
            btnListHuy.Location = new Point(154, 0);
            btnListHuy.Margin = new Padding(0);
            btnListHuy.Name = "btnListHuy";
            btnListHuy.Size = new Size(77, 72);
            btnListHuy.TabIndex = 10;
            btnListHuy.Text = "DS Hủy";
            btnListHuy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnListHuy.UseVisualStyleBackColor = false;
            btnListHuy.Click += btnListHuy_Click;
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
            panelSearch.Location = new Point(426, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.RowCount = 1;
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelSearch.Size = new Size(348, 72);
            panelSearch.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.FlatAppearance.BorderColor = Color.Black;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(3, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(83, 24);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtBoxTimKiem
            // 
            txtBoxTimKiem.Anchor = AnchorStyles.None;
            txtBoxTimKiem.Location = new Point(92, 24);
            txtBoxTimKiem.Name = "txtBoxTimKiem";
            txtBoxTimKiem.PlaceholderText = "Tìm kiếm...";
            txtBoxTimKiem.Size = new Size(203, 23);
            txtBoxTimKiem.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Image = Properties.Resources.iconRefesh;
            btnLamMoi.Location = new Point(298, 0);
            btnLamMoi.Margin = new Padding(0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(50, 72);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Dock = DockStyle.Left;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Image = Properties.Resources.iconxoa;
            btnHuy.Location = new Point(77, 0);
            btnHuy.Margin = new Padding(0);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(77, 72);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Dock = DockStyle.Left;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.iconthem;
            btnThem.Location = new Point(0, 0);
            btnThem.Margin = new Padding(0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 72);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvPhieuMuonTra
            // 
            dgvPhieuMuonTra.AccessibleRole = AccessibleRole.None;
            dgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuonTra.Dock = DockStyle.Fill;
            dgvPhieuMuonTra.Location = new Point(0, 72);
            dgvPhieuMuonTra.Name = "dgvPhieuMuonTra";
            dgvPhieuMuonTra.Size = new Size(774, 491);
            dgvPhieuMuonTra.TabIndex = 1;
            // 
            // UcMuonTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPhieuMuonTra);
            Controls.Add(panelCRUD);
            Name = "UcMuonTraSach";
            Size = new Size(774, 563);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuonTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private DataGridView dgvPhieuMuonTra;
        private Button btnHuy;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnExcel;
        private Button btnChiTiet;
        private Button btnListHuy;
    }
}
