namespace LMS.Views.UserControls.QLNhapSach
{
    partial class FormThemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemPhieuNhap));
            label2 = new Label();
            label5 = new Label();
            labelTitle = new Label();
            tableLayoutPanelContent = new TableLayoutPanel();
            label3 = new Label();
            comboBoxLoaiPN = new ComboBox();
            dateTimePickerNgayNhap = new DateTimePicker();
            comboBoxNCC = new ComboBox();
            label6 = new Label();
            textBoxNhanVien = new TextBox();
            dgvChonSach = new DataGridView();
            label1 = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnThem = new Button();
            btnHuy = new Button();
            tableLayoutPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChonSach).BeginInit();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(327, 29);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 1;
            label2.Text = "Loại phiếu nhập:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(327, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(104, 29);
            label5.TabIndex = 5;
            label5.Text = "Nhà cung cấp:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(710, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM PHIẾU NHẬP";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 4;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelContent.Controls.Add(label3, 0, 2);
            tableLayoutPanelContent.Controls.Add(label5, 2, 0);
            tableLayoutPanelContent.Controls.Add(label2, 2, 1);
            tableLayoutPanelContent.Controls.Add(comboBoxLoaiPN, 3, 1);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayNhap, 1, 1);
            tableLayoutPanelContent.Controls.Add(comboBoxNCC, 3, 0);
            tableLayoutPanelContent.Controls.Add(dgvChonSach, 1, 2);
            tableLayoutPanelContent.Controls.Add(label1, 0, 1);
            tableLayoutPanelContent.Controls.Add(label6, 0, 0);
            tableLayoutPanelContent.Controls.Add(textBoxNhanVien, 1, 0);
            tableLayoutPanelContent.Location = new Point(26, 24);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 5;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.Size = new Size(659, 307);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 40;
            label3.Text = "Sách nhập:";
            // 
            // comboBoxLoaiPN
            // 
            comboBoxLoaiPN.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoaiPN.FormattingEnabled = true;
            comboBoxLoaiPN.Location = new Point(437, 32);
            comboBoxLoaiPN.Name = "comboBoxLoaiPN";
            comboBoxLoaiPN.Size = new Size(218, 23);
            comboBoxLoaiPN.TabIndex = 30;
            comboBoxLoaiPN.Visible = false;
            // 
            // dateTimePickerNgayNhap
            // 
            dateTimePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayNhap.Enabled = false;
            dateTimePickerNgayNhap.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayNhap.Location = new Point(103, 32);
            dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            dateTimePickerNgayNhap.Size = new Size(218, 23);
            dateTimePickerNgayNhap.TabIndex = 34;
            dateTimePickerNgayNhap.Value = new DateTime(2025, 10, 7, 0, 0, 0, 0);
            dateTimePickerNgayNhap.ValueChanged += dateTimePickerNgayNhap_ValueChanged;
            // 
            // comboBoxNCC
            // 
            comboBoxNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNCC.FormattingEnabled = true;
            comboBoxNCC.Location = new Point(437, 3);
            comboBoxNCC.Name = "comboBoxNCC";
            comboBoxNCC.Size = new Size(218, 23);
            comboBoxNCC.TabIndex = 35;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 29);
            label6.TabIndex = 38;
            label6.Text = "Nhân viên nhập:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNhanVien
            // 
            textBoxNhanVien.Enabled = false;
            textBoxNhanVien.Location = new Point(103, 3);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(218, 23);
            textBoxNhanVien.TabIndex = 39;
            textBoxNhanVien.TextChanged += textBoxNhanVien_TextChanged;
            // 
            // dgvChonSach
            // 
            dgvChonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChonSach.BackgroundColor = Color.White;
            dgvChonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelContent.SetColumnSpan(dgvChonSach, 4);
            dgvChonSach.Location = new Point(3, 76);
            dgvChonSach.Name = "dgvChonSach";
            dgvChonSach.Size = new Size(653, 228);
            dgvChonSach.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 20;
            label1.Text = "Ngày nhập:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(710, 94);
            panelTop.TabIndex = 18;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(tableLayoutPanelButtons);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 94);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(710, 394);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(312, 344);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelButtons.Size = new Size(373, 39);
            tableLayoutPanelButtons.TabIndex = 19;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(180, 34);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(189, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(181, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 488);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemPhieuNhap";
            Text = "Thêm Phiếu Nhập";
            Load += FormThemPhieuNhap_Load;
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChonSach).EndInit();
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanelContent;
        private Panel panelTop;
        private Panel panelContent;
        private Label label1;
        private ComboBox comboBoxLoaiPN;
        private DateTimePicker dateTimePickerNgayNhap;
        private ComboBox comboBoxNCC;
        private TextBox textBoxNhanVien;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnThem;
        private Button btnHuy;
        private Label label3;
        private Label label6;
        private DataGridView dgvChonSach;
    }
}