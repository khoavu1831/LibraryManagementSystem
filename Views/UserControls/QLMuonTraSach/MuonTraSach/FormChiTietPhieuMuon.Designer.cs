namespace LMS.Views.Views.UserControls.QLMuonTraSach.MuonTraSach
{
    partial class FormChiTietPhieuMuon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuMuon));
            panelTop = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelNgayHenTra = new Label();
            labelNgayMuon = new Label();
            labelSDT = new Label();
            labelDocGia = new Label();
            labelNhanVien = new Label();
            label1 = new Label();
            textBoxMaPhieuMuon = new TextBox();
            textBoxNhanVien = new TextBox();
            textBoxDocGia = new TextBox();
            textBoxSDT = new TextBox();
            labelTrangThai = new Label();
            textBoxTrangThai = new TextBox();
            dateTimePickerNgayMuon = new DateTimePicker();
            dateTimePickerNgayHenTra = new DateTimePicker();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTongSo = new Label();
            labelDaTra = new Label();
            labelChuaTra = new Label();
            panelChiTiet = new Panel();
            dgvChiTiet = new DataGridView();
            btnQuayLai = new Button();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Location = new Point(1, 1);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1174, 100);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1174, 100);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "CHI TIẾT PHIẾU MƯỢN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Click += labelTitle_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 205);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.1843948F));
            tableLayoutPanel1.Controls.Add(labelNgayHenTra, 0, 5);
            tableLayoutPanel1.Controls.Add(labelNgayMuon, 0, 4);
            tableLayoutPanel1.Controls.Add(labelSDT, 0, 3);
            tableLayoutPanel1.Controls.Add(labelDocGia, 0, 2);
            tableLayoutPanel1.Controls.Add(labelNhanVien, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMaPhieuMuon, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNhanVien, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxDocGia, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxSDT, 1, 3);
            tableLayoutPanel1.Controls.Add(labelTrangThai, 0, 6);
            tableLayoutPanel1.Controls.Add(textBoxTrangThai, 1, 6);
            tableLayoutPanel1.Controls.Add(dateTimePickerNgayMuon, 1, 4);
            tableLayoutPanel1.Controls.Add(dateTimePickerNgayHenTra, 1, 5);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(282, 197);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // labelNgayHenTra
            // 
            labelNgayHenTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNgayHenTra.AutoSize = true;
            labelNgayHenTra.Location = new Point(3, 140);
            labelNgayHenTra.Name = "labelNgayHenTra";
            labelNgayHenTra.Size = new Size(95, 28);
            labelNgayHenTra.TabIndex = 10;
            labelNgayHenTra.Text = "Ngày hẹn trả:";
            labelNgayHenTra.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNgayMuon
            // 
            labelNgayMuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNgayMuon.AutoSize = true;
            labelNgayMuon.Location = new Point(3, 112);
            labelNgayMuon.Name = "labelNgayMuon";
            labelNgayMuon.Size = new Size(95, 28);
            labelNgayMuon.TabIndex = 9;
            labelNgayMuon.Text = "Ngày mượn:";
            labelNgayMuon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSDT
            // 
            labelSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(3, 84);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(95, 28);
            labelSDT.TabIndex = 8;
            labelSDT.Text = "Số điện thoại:";
            labelSDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDocGia
            // 
            labelDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDocGia.AutoSize = true;
            labelDocGia.Location = new Point(3, 56);
            labelDocGia.Name = "labelDocGia";
            labelDocGia.Size = new Size(95, 28);
            labelDocGia.TabIndex = 7;
            labelDocGia.Text = "Độc giả:";
            labelDocGia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNhanVien
            // 
            labelNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(3, 28);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(95, 28);
            labelNhanVien.TabIndex = 6;
            labelNhanVien.Text = "Nhân viên:";
            labelNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu mượn:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMaPhieuMuon
            // 
            textBoxMaPhieuMuon.Location = new Point(104, 3);
            textBoxMaPhieuMuon.Name = "textBoxMaPhieuMuon";
            textBoxMaPhieuMuon.Size = new Size(175, 23);
            textBoxMaPhieuMuon.TabIndex = 1;
            // 
            // textBoxNhanVien
            // 
            textBoxNhanVien.Location = new Point(104, 31);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.Size = new Size(175, 23);
            textBoxNhanVien.TabIndex = 2;
            // 
            // textBoxDocGia
            // 
            textBoxDocGia.Location = new Point(104, 59);
            textBoxDocGia.Name = "textBoxDocGia";
            textBoxDocGia.Size = new Size(175, 23);
            textBoxDocGia.TabIndex = 3;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(104, 87);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(175, 23);
            textBoxSDT.TabIndex = 4;
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(3, 168);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(95, 29);
            labelTrangThai.TabIndex = 11;
            labelTrangThai.Text = "Trạng thái:";
            labelTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            labelTrangThai.Click += labelTrangThai_Click;
            // 
            // textBoxTrangThai
            // 
            textBoxTrangThai.Location = new Point(104, 171);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.Size = new Size(175, 23);
            textBoxTrangThai.TabIndex = 5;
            // 
            // dateTimePickerNgayMuon
            // 
            dateTimePickerNgayMuon.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayMuon.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayMuon.Location = new Point(104, 115);
            dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            dateTimePickerNgayMuon.Size = new Size(175, 23);
            dateTimePickerNgayMuon.TabIndex = 12;
            // 
            // dateTimePickerNgayHenTra
            // 
            dateTimePickerNgayHenTra.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayHenTra.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayHenTra.Location = new Point(104, 143);
            dateTimePickerNgayHenTra.Name = "dateTimePickerNgayHenTra";
            dateTimePickerNgayHenTra.Size = new Size(175, 23);
            dateTimePickerNgayHenTra.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 441);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 151);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new Point(12, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 99);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(labelTongSo, 0, 0);
            tableLayoutPanel2.Controls.Add(labelDaTra, 0, 1);
            tableLayoutPanel2.Controls.Add(labelChuaTra, 0, 2);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(279, 92);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelTongSo
            // 
            labelTongSo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTongSo.AutoSize = true;
            labelTongSo.Location = new Point(3, 0);
            labelTongSo.Name = "labelTongSo";
            labelTongSo.Size = new Size(273, 28);
            labelTongSo.TabIndex = 1;
            labelTongSo.Text = "Tổng số:";
            labelTongSo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDaTra
            // 
            labelDaTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDaTra.AutoSize = true;
            labelDaTra.Location = new Point(3, 28);
            labelDaTra.Name = "labelDaTra";
            labelDaTra.Size = new Size(273, 28);
            labelDaTra.TabIndex = 2;
            labelDaTra.Text = "Đã trả:";
            labelDaTra.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelChuaTra
            // 
            labelChuaTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelChuaTra.AutoSize = true;
            labelChuaTra.Location = new Point(3, 56);
            labelChuaTra.Name = "labelChuaTra";
            labelChuaTra.Size = new Size(273, 36);
            labelChuaTra.TabIndex = 3;
            labelChuaTra.Text = "Chưa trả:";
            labelChuaTra.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelChiTiet
            // 
            panelChiTiet.Controls.Add(dgvChiTiet);
            panelChiTiet.Location = new Point(306, 107);
            panelChiTiet.Name = "panelChiTiet";
            panelChiTiet.Size = new Size(857, 430);
            panelChiTiet.TabIndex = 3;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.BackgroundColor = SystemColors.ButtonHighlight;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.GridColor = Color.DarkGray;
            dgvChiTiet.Location = new Point(3, 6);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(851, 421);
            dgvChiTiet.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(69, 485);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(162, 34);
            btnQuayLai.TabIndex = 20;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // FormChiTietPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 551);
            Controls.Add(btnQuayLai);
            Controls.Add(panelChiTiet);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChiTietPhieuMuon";
            Text = "Chi tiết phiếu mượn";
            panelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelTitle;
        private Panel panelChiTiet;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBoxMaPhieuMuon;
        private TextBox textBoxNhanVien;
        private TextBox textBoxDocGia;
        private TextBox textBoxSDT;
        private TextBox textBoxTrangThai;
        private Label labelNgayHenTra;
        private Label labelNgayMuon;
        private Label labelSDT;
        private Label labelDocGia;
        private Label labelNhanVien;
        private Label labelTrangThai;
        private DateTimePicker dateTimePickerNgayHenTra;
        private Button btnQuayLai;
        private DataGridView dgvChiTiet;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTongSo;
        private Label labelDaTra;
        private Label labelChuaTra;
        private DateTimePicker dateTimePickerNgayMuon;
    }
}