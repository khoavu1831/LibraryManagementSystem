namespace LMS.Views.UserControls.QLPhat
{
    partial class FormChiTietPhieuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuPhat));
            labelDocGia = new Label();
            labelTrangThai = new Label();
            labelNgayLap = new Label();
            labelTongTien = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxTrangThai = new TextBox();
            labelMaPhieuPhat = new Label();
            textBoxIDPhieuPhat = new TextBox();
            textBoxDocGia = new TextBox();
            dateTimePickerNgayLap = new DateTimePicker();
            textBoxTongTienPhat = new TextBox();
            labelChiTiet = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvChiTietPhieuPhat = new DataGridView();
            btnQuayLai = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuPhat).BeginInit();
            SuspendLayout();
            // 
            // labelDocGia
            // 
            labelDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDocGia.AutoSize = true;
            labelDocGia.Location = new Point(414, 0);
            labelDocGia.Name = "labelDocGia";
            labelDocGia.Size = new Size(74, 28);
            labelDocGia.TabIndex = 1;
            labelDocGia.Text = "Độc giả:";
            labelDocGia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTrangThai
            // 
            labelTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new Point(414, 28);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(74, 28);
            labelTrangThai.TabIndex = 7;
            labelTrangThai.Text = "Trạng Thái:";
            labelTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNgayLap
            // 
            labelNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNgayLap.AutoSize = true;
            labelNgayLap.Location = new Point(3, 28);
            labelNgayLap.Name = "labelNgayLap";
            labelNgayLap.Size = new Size(123, 28);
            labelNgayLap.TabIndex = 5;
            labelNgayLap.Text = "Ngày lập:";
            labelNgayLap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTongTien
            // 
            labelTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(3, 56);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(123, 28);
            labelTongTien.TabIndex = 11;
            labelTongTien.Text = "Tổng tiền phạt:";
            labelTongTien.TextAlign = ContentAlignment.MiddleLeft;
            labelTongTien.Click += label6_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1110, 94);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT PHIẾU PHẠT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.Controls.Add(textBoxTrangThai, 3, 1);
            tableLayoutPanel1.Controls.Add(labelMaPhieuPhat, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxIDPhieuPhat, 1, 0);
            tableLayoutPanel1.Controls.Add(labelDocGia, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxDocGia, 3, 0);
            tableLayoutPanel1.Controls.Add(labelNgayLap, 0, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerNgayLap, 1, 1);
            tableLayoutPanel1.Controls.Add(labelTrangThai, 2, 1);
            tableLayoutPanel1.Controls.Add(labelTongTien, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxTongTienPhat, 1, 2);
            tableLayoutPanel1.Controls.Add(labelChiTiet, 0, 3);
            tableLayoutPanel1.Location = new Point(29, 21);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(753, 112);
            tableLayoutPanel1.TabIndex = 17;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBoxTrangThai
            // 
            textBoxTrangThai.Location = new Point(494, 31);
            textBoxTrangThai.Name = "textBoxTrangThai";
            textBoxTrangThai.ReadOnly = true;
            textBoxTrangThai.Size = new Size(227, 23);
            textBoxTrangThai.TabIndex = 28;
            // 
            // labelMaPhieuPhat
            // 
            labelMaPhieuPhat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMaPhieuPhat.AutoSize = true;
            labelMaPhieuPhat.Location = new Point(3, 0);
            labelMaPhieuPhat.Name = "labelMaPhieuPhat";
            labelMaPhieuPhat.Size = new Size(123, 28);
            labelMaPhieuPhat.TabIndex = 19;
            labelMaPhieuPhat.Text = "Mã phiếu phạt:";
            labelMaPhieuPhat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxIDPhieuPhat
            // 
            textBoxIDPhieuPhat.Location = new Point(132, 3);
            textBoxIDPhieuPhat.Name = "textBoxIDPhieuPhat";
            textBoxIDPhieuPhat.ReadOnly = true;
            textBoxIDPhieuPhat.Size = new Size(227, 23);
            textBoxIDPhieuPhat.TabIndex = 23;
            // 
            // textBoxDocGia
            // 
            textBoxDocGia.Location = new Point(494, 3);
            textBoxDocGia.Name = "textBoxDocGia";
            textBoxDocGia.ReadOnly = true;
            textBoxDocGia.Size = new Size(227, 23);
            textBoxDocGia.TabIndex = 24;
            // 
            // dateTimePickerNgayLap
            // 
            dateTimePickerNgayLap.Enabled = false;
            dateTimePickerNgayLap.Location = new Point(132, 31);
            dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            dateTimePickerNgayLap.Size = new Size(227, 23);
            dateTimePickerNgayLap.TabIndex = 26;
            // 
            // textBoxTongTienPhat
            // 
            textBoxTongTienPhat.Location = new Point(132, 59);
            textBoxTongTienPhat.Name = "textBoxTongTienPhat";
            textBoxTongTienPhat.ReadOnly = true;
            textBoxTongTienPhat.Size = new Size(227, 23);
            textBoxTongTienPhat.TabIndex = 22;
            textBoxTongTienPhat.TextChanged += textBoxTienPhat_TextChanged;
            // 
            // labelChiTiet
            // 
            labelChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelChiTiet.AutoSize = true;
            labelChiTiet.Location = new Point(3, 84);
            labelChiTiet.Name = "labelChiTiet";
            labelChiTiet.Size = new Size(123, 28);
            labelChiTiet.TabIndex = 27;
            labelChiTiet.Text = "Chi tiết phiếu phạt:";
            labelChiTiet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 94);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvChiTietPhieuPhat);
            panel2.Controls.Add(btnQuayLai);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 554);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // dgvChiTietPhieuPhat
            // 
            dgvChiTietPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuPhat.BackgroundColor = SystemColors.ButtonHighlight;
            dgvChiTietPhieuPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuPhat.GridColor = SystemColors.ActiveBorder;
            dgvChiTietPhieuPhat.Location = new Point(29, 138);
            dgvChiTietPhieuPhat.Name = "dgvChiTietPhieuPhat";
            dgvChiTietPhieuPhat.Size = new Size(1048, 366);
            dgvChiTietPhieuPhat.TabIndex = 20;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(462, 509);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(162, 34);
            btnQuayLai.TabIndex = 19;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormChiTietPhieuPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 648);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChiTietPhieuPhat";
            Text = "Chi Tiết Phiếu Phạt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuPhat).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        #endregion
        private Label labelDocGia;
        private Label labelTrangThai;
        private Label labelNgayLap;
        private Label labelTongTien;
        private Label label1;
        private Button btnQuayLai;
        private Label labelMaPhieuPhat;
        private TextBox textBoxTongTienPhat;
        private TextBox textBoxIDPhieuPhat;
        private TextBox textBoxDocGia;
        private DateTimePicker dateTimePickerNgayLap;
        private Label labelChiTiet;
        private DataGridView dgvChiTietPhieuPhat;
        private TextBox textBoxTrangThai;
    }
}