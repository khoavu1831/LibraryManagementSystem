namespace LMS.Views.UserControls.QLPhat
{
    partial class UcPhat
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
            btnExcel = new Button();
            btnChiTiet = new Button();
            btnHuy = new Button();
            btnDSHuy = new Button();
            btnDSThu = new Button();
            dgvPhat = new DataGridView();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhat).BeginInit();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnExcel);
            panelCRUD.Controls.Add(btnChiTiet);
            panelCRUD.Controls.Add(btnHuy);
            panelCRUD.Controls.Add(btnDSHuy);
            panelCRUD.Controls.Add(btnDSThu);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(774, 72);
            panelCRUD.TabIndex = 0;
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
            btnTimKiem.Click += btnTimKiem_Click;
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
            btnExcel.TabIndex = 4;
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
            btnChiTiet.TabIndex = 3;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Dock = DockStyle.Left;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Image = Properties.Resources.iconxoa;
            btnHuy.Location = new Point(154, 0);
            btnHuy.Margin = new Padding(0);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(77, 72);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Huỷ Phiếu";
            btnHuy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnXoa_Click;
            // 
            // btnDSHuy
            // 
            btnDSHuy.BackColor = Color.White;
            btnDSHuy.Dock = DockStyle.Left;
            btnDSHuy.FlatAppearance.BorderSize = 0;
            btnDSHuy.FlatStyle = FlatStyle.Flat;
            btnDSHuy.Image = Properties.Resources.iconRac2;
            btnDSHuy.Location = new Point(77, 0);
            btnDSHuy.Margin = new Padding(0);
            btnDSHuy.Name = "btnDSHuy";
            btnDSHuy.Size = new Size(77, 72);
            btnDSHuy.TabIndex = 1;
            btnDSHuy.Text = "DS Đã Huỷ";
            btnDSHuy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDSHuy.UseVisualStyleBackColor = false;
            btnDSHuy.Click += btnDSHuy_Click;
            // 
            // btnDSThu
            // 
            btnDSThu.BackColor = Color.White;
            btnDSThu.Dock = DockStyle.Left;
            btnDSThu.FlatAppearance.BorderSize = 0;
            btnDSThu.FlatStyle = FlatStyle.Flat;
            btnDSThu.Image = Properties.Resources.check;
            btnDSThu.Location = new Point(0, 0);
            btnDSThu.Margin = new Padding(0);
            btnDSThu.Name = "btnDSThu";
            btnDSThu.Size = new Size(77, 72);
            btnDSThu.TabIndex = 0;
            btnDSThu.Text = "DS Đã Thu";
            btnDSThu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDSThu.UseVisualStyleBackColor = false;
            btnDSThu.Click += btnDSThu_Click;
            // 
            // dgvPhat
            // 
            dgvPhat.AccessibleRole = AccessibleRole.None;
            dgvPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhat.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhat.Dock = DockStyle.Fill;
            dgvPhat.Location = new Point(0, 72);
            dgvPhat.Name = "dgvPhat";
            dgvPhat.Size = new Size(774, 491);
            dgvPhat.TabIndex = 1;
            dgvPhat.CellContentClick += dgvPhat_CellContentClick;
            // 
            // UcPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPhat);
            Controls.Add(panelCRUD);
            Name = "UcPhat";
            Size = new Size(774, 563);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private Button btnDSThu;
        private DataGridView dgvPhat;
        private Button btnHuy;
        private Button btnDSHuy;
        private Button btnChiTiet;
        private Button btnExcel;
        private Button btnLamMoi;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
    }
}
