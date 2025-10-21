namespace LMS.Views.UserControls.QLNhapSach
{
    partial class UcNCC
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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvNCC = new DataGridView();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnExcel);
            panelCRUD.Controls.Add(btnChiTiet);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnThem);
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
            btnTimKiem.TabIndex = 6;
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
            txtBoxTimKiem.TabIndex = 5;
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
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Dock = DockStyle.Left;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.iconxoa;
            btnXoa.Location = new Point(154, 0);
            btnXoa.Margin = new Padding(0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 72);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Dock = DockStyle.Left;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.iconsua;
            btnSua.Location = new Point(77, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 72);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            // dgvNCC
            // 
            dgvNCC.AccessibleRole = AccessibleRole.None;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.Location = new Point(0, 72);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.Size = new Size(774, 491);
            dgvNCC.TabIndex = 1;
            // 
            // UcNCC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNCC);
            Controls.Add(panelCRUD);
            Name = "UcNCC";
            Size = new Size(774, 563);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private Button btnThem;
        private DataGridView dgvNCC;
        private Button btnXoa;
        private Button btnSua;
        private Button btnChiTiet;
        private Button btnExcel;
        private Button btnLamMoi;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
    }
}
