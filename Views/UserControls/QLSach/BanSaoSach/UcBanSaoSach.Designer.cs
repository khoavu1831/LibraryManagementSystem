namespace LMS.Views.UserControls.QLSach
{
    partial class UcBanSaoSach
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
            btnXoa = new Button();
            btnSua = new Button();
            dgvBanSaoSach = new DataGridView();
            btnTruoc = new Button();
            btnSau = new Button();
            tableLayoutPanelButtons = new TableLayoutPanel();
            labelTrang = new Label();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanSaoSach).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Controls.Add(btnExcel);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnSua);
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
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.Dock = DockStyle.Left;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Image = Properties.Resources.iconExc;
            btnExcel.Location = new Point(154, 0);
            btnExcel.Margin = new Padding(0);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(77, 72);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "Xuất Excel";
            btnExcel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcel.UseVisualStyleBackColor = false;
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
            // dgvBanSaoSach
            // 
            dgvBanSaoSach.AccessibleRole = AccessibleRole.None;
            dgvBanSaoSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBanSaoSach.BackgroundColor = Color.White;
            dgvBanSaoSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanSaoSach.Dock = DockStyle.Fill;
            dgvBanSaoSach.Location = new Point(0, 72);
            dgvBanSaoSach.Name = "dgvBanSaoSach";
            dgvBanSaoSach.Size = new Size(774, 491);
            dgvBanSaoSach.TabIndex = 1;
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
            tableLayoutPanelButtons.Size = new Size(774, 30);
            tableLayoutPanelButtons.TabIndex = 4;
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
            // UcBanSaoSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(dgvBanSaoSach);
            Controls.Add(panelCRUD);
            Name = "UcBanSaoSach";
            Size = new Size(774, 563);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanSaoSach).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private DataGridView dgvBanSaoSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnExcel;
        private Button btnLamMoi;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnTruoc;
        private Button btnSau;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Label labelTrang;
    }
}
