namespace LMS.Views.UserControls.QLMuonTraSach
{
    partial class FormThemPhieuMuonTra
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
            label2 = new Label();
            label5 = new Label();
            labelTitle = new Label();
            tableLayoutPanelContent = new TableLayoutPanel();
            label7 = new Label();
            label4 = new Label();
            dgvChonSach = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            dateTimePickerNgayLap = new DateTimePicker();
            dateTimePickerNgayHenTra = new DateTimePicker();
            comboBoxThanhVien = new ComboBox();
            label6 = new Label();
            textBoxNhanVien = new TextBox();
            textBoxTimThanhVien = new TextBox();
            textBoxSDTThanhVien = new TextBox();
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
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(89, 27);
            label2.TabIndex = 1;
            label2.Text = "Thành viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(373, 56);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 0, 0, 0);
            label5.Size = new Size(98, 28);
            label5.TabIndex = 5;
            label5.Text = "Ngày hẹn trả:";
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
            labelTitle.Size = new Size(808, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM PHIẾU MƯỢN";
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
            tableLayoutPanelContent.Controls.Add(label7, 2, 0);
            tableLayoutPanelContent.Controls.Add(label4, 0, 0);
            tableLayoutPanelContent.Controls.Add(dgvChonSach, 3, 5);
            tableLayoutPanelContent.Controls.Add(label3, 0, 5);
            tableLayoutPanelContent.Controls.Add(label1, 0, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayLap, 1, 2);
            tableLayoutPanelContent.Controls.Add(label5, 2, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayHenTra, 3, 2);
            tableLayoutPanelContent.Controls.Add(label2, 0, 1);
            tableLayoutPanelContent.Controls.Add(comboBoxThanhVien, 1, 1);
            tableLayoutPanelContent.Controls.Add(label6, 2, 1);
            tableLayoutPanelContent.Controls.Add(textBoxNhanVien, 3, 1);
            tableLayoutPanelContent.Controls.Add(textBoxTimThanhVien, 1, 0);
            tableLayoutPanelContent.Controls.Add(textBoxSDTThanhVien, 3, 0);
            tableLayoutPanelContent.Location = new Point(26, 18);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 6;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.Size = new Size(770, 534);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(373, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 29);
            label7.TabIndex = 46;
            label7.Text = "SĐT thành viên:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 29);
            label4.TabIndex = 43;
            label4.Text = "Tìm thành viên:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvChonSach
            // 
            dgvChonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChonSach.BackgroundColor = Color.White;
            dgvChonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelContent.SetColumnSpan(dgvChonSach, 4);
            dgvChonSach.Location = new Point(3, 107);
            dgvChonSach.Name = "dgvChonSach";
            dgvChonSach.Size = new Size(764, 392);
            dgvChonSach.TabIndex = 41;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 40;
            label3.Text = "Sách mượn:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 20;
            label1.Text = "Ngày lập:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerNgayLap
            // 
            dateTimePickerNgayLap.Enabled = false;
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayLap.Location = new Point(98, 59);
            dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            dateTimePickerNgayLap.Size = new Size(269, 23);
            dateTimePickerNgayLap.TabIndex = 34;
            // 
            // dateTimePickerNgayHenTra
            // 
            dateTimePickerNgayHenTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayHenTra.Location = new Point(477, 59);
            dateTimePickerNgayHenTra.Name = "dateTimePickerNgayHenTra";
            dateTimePickerNgayHenTra.Size = new Size(290, 23);
            dateTimePickerNgayHenTra.TabIndex = 42;
            // 
            // comboBoxThanhVien
            // 
            comboBoxThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThanhVien.FormattingEnabled = true;
            comboBoxThanhVien.Location = new Point(98, 32);
            comboBoxThanhVien.Name = "comboBoxThanhVien";
            comboBoxThanhVien.Size = new Size(269, 23);
            comboBoxThanhVien.TabIndex = 30;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(373, 29);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 38;
            label6.Text = "Nhân viên nhập:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNhanVien
            // 
            textBoxNhanVien.Enabled = false;
            textBoxNhanVien.Location = new Point(477, 32);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(290, 23);
            textBoxNhanVien.TabIndex = 39;
            // 
            // textBoxTimThanhVien
            // 
            textBoxTimThanhVien.Location = new Point(98, 3);
            textBoxTimThanhVien.Name = "textBoxTimThanhVien";
            textBoxTimThanhVien.Size = new Size(269, 23);
            textBoxTimThanhVien.TabIndex = 44;
            // 
            // textBoxSDTThanhVien
            // 
            textBoxSDTThanhVien.Location = new Point(477, 3);
            textBoxSDTThanhVien.Name = "textBoxSDTThanhVien";
            textBoxSDTThanhVien.ReadOnly = true;
            textBoxSDTThanhVien.Size = new Size(290, 23);
            textBoxSDTThanhVien.TabIndex = 45;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(808, 94);
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
            panelContent.Size = new Size(808, 622);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(423, 572);
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
            // FormThemPhieuMuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 716);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemPhieuMuonTra";
            Text = "Thêm phiếu mượn";
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
        private ComboBox comboBoxThanhVien;
        private DateTimePicker dateTimePickerNgayLap;
        private TextBox textBoxNhanVien;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnThem;
        private Button btnHuy;
        private Label label3;
        private Label label6;
        private DataGridView dgvChonSach;
        private DateTimePicker dateTimePickerNgayHenTra;
        private Label label7;
        private Label label4;
        private TextBox textBoxTimThanhVien;
        private TextBox textBoxSDTThanhVien;
    }
}