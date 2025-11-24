namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
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
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnTruoc = new Button();
            btnSau = new Button();
            labelTrang = new Label();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheThanhVien).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
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
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(774, 72);
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
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.White;
            btnChiTiet.Dock = DockStyle.Left;
            btnChiTiet.FlatAppearance.BorderSize = 0;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Image = Properties.Resources.iconCT;
            btnChiTiet.Location = new Point(154, 0);
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
            btnXoa.Location = new Point(77, 0);
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
            btnSua.Location = new Point(0, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 72);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvTheThanhVien
            // 
            dgvTheThanhVien.AllowUserToAddRows = false;
            dgvTheThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheThanhVien.BackgroundColor = Color.White;
            dgvTheThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheThanhVien.Dock = DockStyle.Fill;
            dgvTheThanhVien.Location = new Point(0, 72);
            dgvTheThanhVien.Name = "dgvTheThanhVien";
            dgvTheThanhVien.RowHeadersWidth = 51;
            dgvTheThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheThanhVien.Size = new Size(774, 427);
            dgvTheThanhVien.TabIndex = 3;
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
            tableLayoutPanelButtons.Location = new Point(0, 469);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(774, 30);
            tableLayoutPanelButtons.TabIndex = 5;
            // 
            // btnTruoc
            // 
            btnTruoc.Dock = DockStyle.Fill;
            btnTruoc.Location = new Point(3, 3);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(251, 24);
            btnTruoc.TabIndex = 2;
            btnTruoc.Text = "Trang trước";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnSau
            // 
            btnSau.Dock = DockStyle.Fill;
            btnSau.Location = new Point(517, 3);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(254, 24);
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
            labelTrang.Location = new Point(260, 0);
            labelTrang.Name = "labelTrang";
            labelTrang.Size = new Size(251, 30);
            labelTrang.TabIndex = 4;
            labelTrang.Text = "Trang 1";
            labelTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcTheThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(dgvTheThanhVien);
            Controls.Add(panelCRUD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcTheThanhVien";
            Size = new Size(774, 499);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheThanhVien).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelButtons.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnTruoc;
        private Button btnSau;
        private Label labelTrang;
    }
}
