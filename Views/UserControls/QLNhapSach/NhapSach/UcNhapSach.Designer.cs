namespace LMS.Views.UserControls.QLNhapSach
{
    partial class UcNhapSach
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
            buttonNhapExcel = new Button();
            btnExcel = new Button();
            btnChiTiet = new Button();
            btnListHuy = new Button();
            panelSearch = new TableLayoutPanel();
            btnTimKiem = new Button();
            txtBoxTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dgvPhieuNhap = new DataGridView();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnTruoc = new Button();
            btnSau = new Button();
            labelTrang = new Label();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(buttonNhapExcel);
            panelCRUD.Controls.Add(btnExcel);
            panelCRUD.Controls.Add(btnChiTiet);
            panelCRUD.Controls.Add(btnListHuy);
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(972, 72);
            panelCRUD.TabIndex = 0;
            // 
            // buttonNhapExcel
            // 
            buttonNhapExcel.BackColor = Color.White;
            buttonNhapExcel.Dock = DockStyle.Left;
            buttonNhapExcel.FlatAppearance.BorderSize = 0;
            buttonNhapExcel.FlatStyle = FlatStyle.Flat;
            buttonNhapExcel.Image = Properties.Resources.iconExc;
            buttonNhapExcel.Location = new Point(385, 0);
            buttonNhapExcel.Margin = new Padding(0);
            buttonNhapExcel.Name = "buttonNhapExcel";
            buttonNhapExcel.Size = new Size(77, 72);
            buttonNhapExcel.TabIndex = 14;
            buttonNhapExcel.Text = "Nhập Excel";
            buttonNhapExcel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonNhapExcel.UseVisualStyleBackColor = false;
            buttonNhapExcel.Click += buttonNhapExcel_Click;
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
            panelSearch.Location = new Point(624, 0);
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
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Dock = DockStyle.Left;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.iconxoa;
            btnXoa.Location = new Point(77, 0);
            btnXoa.Margin = new Padding(0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 72);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Hủy";
            btnXoa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AccessibleRole = AccessibleRole.None;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(0, 72);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.Size = new Size(972, 491);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelButtons.Controls.Add(btnTruoc, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnSau, 2, 0);
            tableLayoutPanelButtons.Controls.Add(labelTrang, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Bottom;
            tableLayoutPanelButtons.Location = new Point(0, 533);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(972, 30);
            tableLayoutPanelButtons.TabIndex = 7;
            // 
            // btnTruoc
            // 
            btnTruoc.Dock = DockStyle.Fill;
            btnTruoc.Location = new Point(3, 3);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(317, 24);
            btnTruoc.TabIndex = 2;
            btnTruoc.Text = "Trang trước";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnSau
            // 
            btnSau.Dock = DockStyle.Fill;
            btnSau.Location = new Point(649, 3);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(320, 24);
            btnSau.TabIndex = 3;
            btnSau.Text = "Trang sau";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnSau_Click;
            // 
            // labelTrang
            // 
            labelTrang.AutoSize = true;
            labelTrang.BorderStyle = BorderStyle.FixedSingle;
            labelTrang.Dock = DockStyle.Fill;
            labelTrang.Location = new Point(326, 0);
            labelTrang.Name = "labelTrang";
            labelTrang.Size = new Size(317, 30);
            labelTrang.TabIndex = 4;
            labelTrang.Text = "Trang 1";
            labelTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcNhapSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(panelCRUD);
            Name = "UcNhapSach";
            Size = new Size(972, 563);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private DataGridView dgvPhieuNhap;
        private Button btnXoa;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnLamMoi;
        private Button btnThem;
        private Button btnExcel;
        private Button btnChiTiet;
        private Button btnListHuy;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnTruoc;
        private Button btnSau;
        private Label labelTrang;
        private Button buttonNhapExcel;
    }
}
