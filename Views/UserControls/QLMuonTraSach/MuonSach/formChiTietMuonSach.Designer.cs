namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    partial class FormChiTietMuonSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            btnDong = new Button();
            dgvSachMuon = new DataGridView();
            tableLayoutPanelInfo = new TableLayoutPanel();
            labelIdPhieuMuon = new Label();
            textBoxIdPhieuMuon = new TextBox();
            labelNhanVien = new Label();
            textBoxNhanVien = new TextBox();
            labelDocGia = new Label();
            textBoxDocGia = new TextBox();
            labelNgayMuon = new Label();
            textBoxNgayMuon = new TextBox();
            labelNgayHenTra = new Label();
            textBoxNgayHenTra = new TextBox();
            textBoxTrangThai = new TextBox();
            labelTrangThai = new Label();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachMuon).BeginInit();
            tableLayoutPanelInfo.SuspendLayout();
            SuspendLayout();

            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(640, 70);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHI TIẾT PHIẾU MƯỢN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(640, 70);
            panelTop.TabIndex = 1;

            panelContent.Controls.Add(btnDong);
            panelContent.Controls.Add(dgvSachMuon);
            panelContent.Controls.Add(tableLayoutPanelInfo);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 70);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(640, 425);
            panelContent.TabIndex = 0;

            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.Location = new Point(247, 378);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(140, 35);
            btnDong.TabIndex = 0;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;

            dgvSachMuon.AllowUserToAddRows = false;
            dgvSachMuon.AllowUserToDeleteRows = false;
            dgvSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachMuon.BackgroundColor = Color.White;
            dgvSachMuon.Location = new Point(40, 186);
            dgvSachMuon.Margin = new Padding(20, 10, 20, 10);
            dgvSachMuon.Name = "dgvSachMuon";
            dgvSachMuon.ReadOnly = true;
            dgvSachMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachMuon.Size = new Size(560, 180);
            dgvSachMuon.TabIndex = 1;
 
            tableLayoutPanelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelInfo.ColumnCount = 2;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelInfo.Controls.Add(labelIdPhieuMuon, 0, 0);
            tableLayoutPanelInfo.Controls.Add(textBoxIdPhieuMuon, 1, 0);
            tableLayoutPanelInfo.Controls.Add(labelNhanVien, 0, 1);
            tableLayoutPanelInfo.Controls.Add(textBoxNhanVien, 1, 1);
            tableLayoutPanelInfo.Controls.Add(labelDocGia, 0, 2);
            tableLayoutPanelInfo.Controls.Add(textBoxDocGia, 1, 2);
            tableLayoutPanelInfo.Controls.Add(labelNgayMuon, 0, 3);
            tableLayoutPanelInfo.Controls.Add(textBoxNgayMuon, 1, 3);
            tableLayoutPanelInfo.Controls.Add(labelNgayHenTra, 0, 4);
            tableLayoutPanelInfo.Controls.Add(textBoxNgayHenTra, 1, 4);
            tableLayoutPanelInfo.Controls.Add(textBoxTrangThai, 1, 5);
            tableLayoutPanelInfo.Controls.Add(labelTrangThai, 0, 5);
            tableLayoutPanelInfo.Location = new Point(40, 20);
            tableLayoutPanelInfo.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 6;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelInfo.Size = new Size(560, 154);
            tableLayoutPanelInfo.TabIndex = 2;

            labelIdPhieuMuon.Anchor = AnchorStyles.Left;
            labelIdPhieuMuon.AutoSize = true;
            labelIdPhieuMuon.Location = new Point(3, 5);
            labelIdPhieuMuon.Name = "labelIdPhieuMuon";
            labelIdPhieuMuon.Size = new Size(95, 15);
            labelIdPhieuMuon.TabIndex = 0;
            labelIdPhieuMuon.Text = "Mã Phiếu Mượn:";
            labelIdPhieuMuon.TextAlign = ContentAlignment.MiddleLeft;

            textBoxIdPhieuMuon.Dock = DockStyle.Fill;
            textBoxIdPhieuMuon.Location = new Point(171, 3);
            textBoxIdPhieuMuon.Name = "textBoxIdPhieuMuon";
            textBoxIdPhieuMuon.ReadOnly = true;
            textBoxIdPhieuMuon.Size = new Size(386, 23);
            textBoxIdPhieuMuon.TabIndex = 1;

            labelNhanVien.Anchor = AnchorStyles.Left;
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(3, 30);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(65, 15);
            labelNhanVien.TabIndex = 2;
            labelNhanVien.Text = "Nhân Viên:";
            labelNhanVien.TextAlign = ContentAlignment.MiddleLeft;

            textBoxNhanVien.Dock = DockStyle.Fill;
            textBoxNhanVien.Location = new Point(171, 28);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(386, 23);
            textBoxNhanVien.TabIndex = 3;

            labelDocGia.Anchor = AnchorStyles.Left;
            labelDocGia.AutoSize = true;
            labelDocGia.Location = new Point(3, 55);
            labelDocGia.Name = "labelDocGia";
            labelDocGia.Size = new Size(51, 15);
            labelDocGia.TabIndex = 4;
            labelDocGia.Text = "Độc Giả:";
            labelDocGia.TextAlign = ContentAlignment.MiddleLeft;

            textBoxDocGia.Dock = DockStyle.Fill;
            textBoxDocGia.Location = new Point(171, 53);
            textBoxDocGia.Name = "textBoxDocGia";
            textBoxDocGia.ReadOnly = true;
            textBoxDocGia.Size = new Size(386, 23);
            textBoxDocGia.TabIndex = 5;

            labelNgayMuon.Anchor = AnchorStyles.Left;
            labelNgayMuon.AutoSize = true;
            labelNgayMuon.Location = new Point(3, 80);
            labelNgayMuon.Name = "labelNgayMuon";
            labelNgayMuon.Size = new Size(73, 15);
            labelNgayMuon.TabIndex = 6;
            labelNgayMuon.Text = "Ngày Mượn:";
            labelNgayMuon.TextAlign = ContentAlignment.MiddleLeft;

            textBoxNgayMuon.Dock = DockStyle.Fill;
            textBoxNgayMuon.Location = new Point(171, 78);
            textBoxNgayMuon.Name = "textBoxNgayMuon";
            textBoxNgayMuon.ReadOnly = true;
            textBoxNgayMuon.Size = new Size(386, 23);
            textBoxNgayMuon.TabIndex = 7;

            labelNgayHenTra.Anchor = AnchorStyles.Left;
            labelNgayHenTra.AutoSize = true;
            labelNgayHenTra.Location = new Point(3, 105);
            labelNgayHenTra.Name = "labelNgayHenTra";
            labelNgayHenTra.Size = new Size(81, 15);
            labelNgayHenTra.TabIndex = 8;
            labelNgayHenTra.Text = "Ngày Hẹn Trả:";
            labelNgayHenTra.TextAlign = ContentAlignment.MiddleLeft;

            textBoxNgayHenTra.Dock = DockStyle.Fill;
            textBoxNgayHenTra.Location = new Point(171, 103);
            textBoxNgayHenTra.Name = "textBoxNgayHenTra";
            textBoxNgayHenTra.ReadOnly = true;
            textBoxNgayHenTra.Size = new Size(386, 23);
            textBoxNgayHenTra.TabIndex = 9;
   
            textBoxTrangThai.Dock = DockStyle.Fill;
            textBoxTrangThai.Location = new Point(171, 128);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.ReadOnly = true;
            textBoxTrangThai.Size = new Size(386, 23);
            textBoxTrangThai.TabIndex = 11;
 
            labelTrangThai.Anchor = AnchorStyles.Left;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(3, 132);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(64, 15);
            labelTrangThai.TabIndex = 10;
            labelTrangThai.Text = "Trạng Thái:";
            labelTrangThai.TextAlign = ContentAlignment.MiddleLeft;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 495);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormChiTietMuonSach";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi Tiết Phiếu Mượn";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSachMuon).EndInit();
            tableLayoutPanelInfo.ResumeLayout(false);
            tableLayoutPanelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanelInfo;
        private Label labelIdPhieuMuon;
        private TextBox textBoxIdPhieuMuon;
        private Label labelNhanVien;
        private TextBox textBoxNhanVien;
        private Label labelDocGia;
        private TextBox textBoxDocGia;
        private Label labelNgayMuon;
        private TextBox textBoxNgayMuon;
        private Label labelNgayHenTra;
        private TextBox textBoxNgayHenTra;
        private Label labelTrangThai;
        private TextBox textBoxTrangThai;
        private DataGridView dgvSachMuon;
        private Button btnDong;
    }
}
