namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    partial class FormSuaTraSach
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
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnLuu = new Button();
            btnHuy = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            labelIdPhieuMuon = new Label();
            textBoxIdPhieuMuon = new TextBox();
            labelIdChiTiet = new Label();
            textBoxIdChiTiet = new TextBox();
            labelIdBanSao = new Label();
            textBoxIdBanSao = new TextBox();
            labelTenSach = new Label();
            textBoxTenSach = new TextBox();
            labelNgayTra = new Label();
            dateTimePickerNgayTra = new DateTimePicker();
            labelTinhTrang = new Label();
            comboBoxTinhTrang = new ComboBox();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            SuspendLayout();
    
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(437, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SỬA TRẢ SÁCH";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(437, 94);
            panelTop.TabIndex = 1;
    
            panelContent.Controls.Add(tableLayoutPanelButtons);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 94);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(437, 275);
            panelContent.TabIndex = 0;
     
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnLuu, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(41, 212);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(358, 40);
            tableLayoutPanelButtons.TabIndex = 0;
       
            btnLuu.Dock = DockStyle.Top;
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(173, 34);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
       
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(182, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(173, 34);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
       
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanelContent.Controls.Add(labelIdPhieuMuon, 0, 0);
            tableLayoutPanelContent.Controls.Add(textBoxIdPhieuMuon, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelIdChiTiet, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxIdChiTiet, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelIdBanSao, 0, 2);
            tableLayoutPanelContent.Controls.Add(textBoxIdBanSao, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelTenSach, 0, 3);
            tableLayoutPanelContent.Controls.Add(textBoxTenSach, 1, 3);
            tableLayoutPanelContent.Controls.Add(labelNgayTra, 0, 4);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayTra, 1, 4);
            tableLayoutPanelContent.Controls.Add(labelTinhTrang, 0, 5);
            tableLayoutPanelContent.Controls.Add(comboBoxTinhTrang, 1, 5);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 6;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.Size = new Size(358, 168);
            tableLayoutPanelContent.TabIndex = 1;
       
            labelIdPhieuMuon.Anchor = AnchorStyles.Left;
            labelIdPhieuMuon.AutoSize = true;
            labelIdPhieuMuon.Location = new Point(3, 6);
            labelIdPhieuMuon.Name = "labelIdPhieuMuon";
            labelIdPhieuMuon.Size = new Size(95, 15);
            labelIdPhieuMuon.TabIndex = 0;
            labelIdPhieuMuon.Text = "Mã Phiếu Mượn:";
            labelIdPhieuMuon.TextAlign = ContentAlignment.MiddleLeft;
       
            textBoxIdPhieuMuon.Location = new Point(111, 3);
            textBoxIdPhieuMuon.Name = "textBoxIdPhieuMuon";
            textBoxIdPhieuMuon.ReadOnly = true;
            textBoxIdPhieuMuon.Size = new Size(244, 23);
            textBoxIdPhieuMuon.TabIndex = 1;
        
            labelIdChiTiet.Anchor = AnchorStyles.Left;
            labelIdChiTiet.AutoSize = true;
            labelIdChiTiet.Location = new Point(3, 34);
            labelIdChiTiet.Name = "labelIdChiTiet";
            labelIdChiTiet.Size = new Size(70, 15);
            labelIdChiTiet.TabIndex = 2;
            labelIdChiTiet.Text = "Mã Chi Tiết:";
            labelIdChiTiet.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxIdChiTiet.Location = new Point(111, 31);
            textBoxIdChiTiet.Name = "textBoxIdChiTiet";
            textBoxIdChiTiet.ReadOnly = true;
            textBoxIdChiTiet.Size = new Size(244, 23);
            textBoxIdChiTiet.TabIndex = 3;
      
            labelIdBanSao.Anchor = AnchorStyles.Left;
            labelIdBanSao.AutoSize = true;
            labelIdBanSao.Location = new Point(3, 62);
            labelIdBanSao.Name = "labelIdBanSao";
            labelIdBanSao.Size = new Size(72, 15);
            labelIdBanSao.TabIndex = 4;
            labelIdBanSao.Text = "Mã Bản Sao:";
            labelIdBanSao.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxIdBanSao.Location = new Point(111, 59);
            textBoxIdBanSao.Name = "textBoxIdBanSao";
            textBoxIdBanSao.ReadOnly = true;
            textBoxIdBanSao.Size = new Size(244, 23);
            textBoxIdBanSao.TabIndex = 5;
        
            labelTenSach.Anchor = AnchorStyles.Left;
            labelTenSach.AutoSize = true;
            labelTenSach.Location = new Point(3, 90);
            labelTenSach.Name = "labelTenSach";
            labelTenSach.Size = new Size(56, 15);
            labelTenSach.TabIndex = 6;
            labelTenSach.Text = "Tên Sách:";
            labelTenSach.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxTenSach.Location = new Point(111, 87);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.ReadOnly = true;
            textBoxTenSach.Size = new Size(244, 23);
            textBoxTenSach.TabIndex = 7;
      
            labelNgayTra.Anchor = AnchorStyles.Left;
            labelNgayTra.AutoSize = true;
            labelNgayTra.Location = new Point(3, 118);
            labelNgayTra.Name = "labelNgayTra";
            labelNgayTra.Size = new Size(56, 15);
            labelNgayTra.TabIndex = 8;
            labelNgayTra.Text = "Ngày Trả:";
            labelNgayTra.TextAlign = ContentAlignment.MiddleLeft;
         
            dateTimePickerNgayTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTra.Location = new Point(111, 115);
            dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            dateTimePickerNgayTra.Size = new Size(244, 23);
            dateTimePickerNgayTra.TabIndex = 9;
        
            labelTinhTrang.Anchor = AnchorStyles.Left;
            labelTinhTrang.AutoSize = true;
            labelTinhTrang.Location = new Point(3, 146);
            labelTinhTrang.Name = "labelTinhTrang";
            labelTinhTrang.Size = new Size(65, 15);
            labelTinhTrang.TabIndex = 10;
            labelTinhTrang.Text = "Tình Trạng:";
            labelTinhTrang.TextAlign = ContentAlignment.MiddleLeft;
         
            comboBoxTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTinhTrang.Items.AddRange(new object[] { "Tốt", "Hư hỏng", "Mất" });
            comboBoxTinhTrang.Location = new Point(111, 143);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(244, 23);
            comboBoxTinhTrang.TabIndex = 11;
         
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 369);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "FormSuaTraSach";
            Text = "Sửa Trả Sách";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelTop;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnLuu;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanelContent;
        private Label labelIdPhieuMuon;
        private TextBox textBoxIdPhieuMuon;
        private Label labelIdChiTiet;
        private TextBox textBoxIdChiTiet;
        private Label labelIdBanSao;
        private TextBox textBoxIdBanSao;
        private Label labelTenSach;
        private TextBox textBoxTenSach;
        private Label labelNgayTra;
        private DateTimePicker dateTimePickerNgayTra;
        private Label labelTinhTrang;
        private ComboBox comboBoxTinhTrang;
    }
}
