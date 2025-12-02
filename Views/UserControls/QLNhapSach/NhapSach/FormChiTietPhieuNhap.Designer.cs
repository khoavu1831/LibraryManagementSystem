namespace LMS.Views.UserControls.QLNhapSach.NhapSach
{
    partial class FormChiTietPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuNhap));
            panel1 = new Panel();
            panelContent = new Panel();
            btnQuayLai = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            textBoxMaPhieuNhap = new TextBox();
            labelMaPhieuNhap = new Label();
            textBoxNhaCungCap = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxNhanVien = new TextBox();
            label4 = new Label();
            dgvDanhSach = new DataGridView();
            textBoxTongTien = new TextBox();
            label1 = new Label();
            dateTimePickerNgayNhap = new DateTimePicker();
            label2 = new Label();
            textBoxLoaiPhieuNhap = new TextBox();
            panel2 = new Panel();
            labelTitle = new Label();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContent);
            panel1.Location = new Point(1, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 429);
            panel1.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(btnQuayLai);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(913, 429);
            panelContent.TabIndex = 20;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(789, 360);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(91, 38);
            btnQuayLai.TabIndex = 18;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 4;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.Controls.Add(textBoxMaPhieuNhap, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelMaPhieuNhap, 0, 0);
            tableLayoutPanelContent.Controls.Add(textBoxNhaCungCap, 3, 0);
            tableLayoutPanelContent.Controls.Add(label5, 2, 0);
            tableLayoutPanelContent.Controls.Add(label6, 2, 1);
            tableLayoutPanelContent.Controls.Add(textBoxNhanVien, 3, 1);
            tableLayoutPanelContent.Controls.Add(label4, 2, 2);
            tableLayoutPanelContent.Controls.Add(dgvDanhSach, 0, 3);
            tableLayoutPanelContent.Controls.Add(textBoxTongTien, 3, 2);
            tableLayoutPanelContent.Controls.Add(label1, 0, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayNhap, 1, 2);
            tableLayoutPanelContent.Controls.Add(label2, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxLoaiPhieuNhap, 1, 1);
            tableLayoutPanelContent.Location = new Point(26, 24);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 5;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.Size = new Size(857, 322);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // textBoxMaPhieuNhap
            // 
            textBoxMaPhieuNhap.Location = new Point(104, 3);
            textBoxMaPhieuNhap.Name = "textBoxMaPhieuNhap";
            textBoxMaPhieuNhap.ReadOnly = true;
            textBoxMaPhieuNhap.Size = new Size(218, 23);
            textBoxMaPhieuNhap.TabIndex = 47;
            // 
            // labelMaPhieuNhap
            // 
            labelMaPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMaPhieuNhap.AutoSize = true;
            labelMaPhieuNhap.Location = new Point(3, 0);
            labelMaPhieuNhap.Name = "labelMaPhieuNhap";
            labelMaPhieuNhap.Size = new Size(95, 29);
            labelMaPhieuNhap.TabIndex = 46;
            labelMaPhieuNhap.Text = "Mã phiếu nhập:";
            labelMaPhieuNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNhaCungCap
            // 
            textBoxNhaCungCap.Location = new Point(438, 3);
            textBoxNhaCungCap.Name = "textBoxNhaCungCap";
            textBoxNhaCungCap.ReadOnly = true;
            textBoxNhaCungCap.Size = new Size(218, 23);
            textBoxNhaCungCap.TabIndex = 43;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(328, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(104, 29);
            label5.TabIndex = 5;
            label5.Text = "Nhà cung cấp:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(328, 29);
            label6.Name = "label6";
            label6.Size = new Size(104, 29);
            label6.TabIndex = 38;
            label6.Text = "Nhân viên nhập:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNhanVien
            // 
            textBoxNhanVien.Enabled = false;
            textBoxNhanVien.Location = new Point(438, 32);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(218, 23);
            textBoxNhanVien.TabIndex = 39;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(328, 58);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 44;
            label4.Text = "Tổng tiền:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelContent.SetColumnSpan(dgvDanhSach, 4);
            dgvDanhSach.Location = new Point(3, 90);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(851, 228);
            dgvDanhSach.TabIndex = 41;
            // 
            // textBoxTongTien
            // 
            textBoxTongTien.Location = new Point(438, 61);
            textBoxTongTien.Name = "textBoxTongTien";
            textBoxTongTien.ReadOnly = true;
            textBoxTongTien.Size = new Size(218, 23);
            textBoxTongTien.TabIndex = 45;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 58);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 20;
            label1.Text = "Ngày nhập:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // dateTimePickerNgayNhap
            // 
            dateTimePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayNhap.Enabled = false;
            dateTimePickerNgayNhap.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayNhap.Location = new Point(104, 61);
            dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            dateTimePickerNgayNhap.Size = new Size(218, 23);
            dateTimePickerNgayNhap.TabIndex = 34;
            dateTimePickerNgayNhap.Value = new DateTime(2025, 10, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 1;
            label2.Text = "Loại phiếu nhập:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxLoaiPhieuNhap
            // 
            textBoxLoaiPhieuNhap.Location = new Point(104, 32);
            textBoxLoaiPhieuNhap.Name = "textBoxLoaiPhieuNhap";
            textBoxLoaiPhieuNhap.ReadOnly = true;
            textBoxLoaiPhieuNhap.Size = new Size(218, 23);
            textBoxLoaiPhieuNhap.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTitle);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 94);
            panel2.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(910, 94);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "CHI TIẾT PHIẾU NHẬP";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChiTietPhieuNhap";
            Text = "Chi Tiết Phiếu Nhập";
            panel1.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelTitle;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanelContent;
        private Label label5;
        private DateTimePicker dateTimePickerNgayNhap;
        private Label label6;
        private TextBox textBoxNhanVien;
        private DataGridView dgvDanhSach;
        private Label label1;
        private Label label2;
        private TextBox textBoxNhaCungCap;
        private TextBox textBoxLoaiPhieuNhap;
        private Button btnQuayLai;
        private Label label4;
        private TextBox textBoxTongTien;
        private Label labelMaPhieuNhap;
        private TextBox textBoxMaPhieuNhap;
    }
}