namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    partial class FormSuaTraSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            labelNhanVien = new Label();
            textBoxNhanVien = new TextBox();
            labelThanhVien = new Label();
            textBoxThanhVien = new TextBox();
            labelNgayMuon = new Label();
            textBoxNgayMuon = new TextBox();
            labelHanTra = new Label();
            textBoxHanTra = new TextBox();
            labelNgayTra = new Label();
            dateTimePickerNgayTra = new DateTimePicker();
            labelSach = new Label();
            checkedListBoxSach = new CheckedListBox();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(589, 100);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SỬA PHIẾU TRẢ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(589, 100);
            panelTop.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(tableLayoutPanelButtons);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(589, 429);
            panelContent.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnLuu, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(97, 347);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(400, 50);
            tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.Dock = DockStyle.Top;
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(194, 44);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(203, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(194, 44);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelContent.Controls.Add(labelNhanVien, 0, 0);
            tableLayoutPanelContent.Controls.Add(textBoxNhanVien, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelThanhVien, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxThanhVien, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelNgayMuon, 0, 2);
            tableLayoutPanelContent.Controls.Add(textBoxNgayMuon, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelHanTra, 0, 3);
            tableLayoutPanelContent.Controls.Add(textBoxHanTra, 1, 3);
            tableLayoutPanelContent.Controls.Add(labelNgayTra, 0, 4);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayTra, 1, 4);
            tableLayoutPanelContent.Controls.Add(labelSach, 0, 5);
            tableLayoutPanelContent.Controls.Add(checkedListBoxSach, 1, 5);
            tableLayoutPanelContent.Location = new Point(50, 20);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 6;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Size = new Size(500, 300);
            tableLayoutPanelContent.TabIndex = 0;
            // 
            // labelNhanVien
            // 
            labelNhanVien.Anchor = AnchorStyles.Left;
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(3, 4);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(103, 20);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Nhân viên lập:";
            // 
            // textBoxNhanVien
            // 
            textBoxNhanVien.Dock = DockStyle.Fill;
            textBoxNhanVien.Location = new Point(153, 3);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(344, 27);
            textBoxNhanVien.TabIndex = 1;
            // 
            // labelThanhVien
            // 
            labelThanhVien.Anchor = AnchorStyles.Left;
            labelThanhVien.AutoSize = true;
            labelThanhVien.Location = new Point(3, 32);
            labelThanhVien.Name = "labelThanhVien";
            labelThanhVien.Size = new Size(83, 20);
            labelThanhVien.TabIndex = 2;
            labelThanhVien.Text = "Thành viên:";
            // 
            // textBoxThanhVien
            // 
            textBoxThanhVien.Dock = DockStyle.Fill;
            textBoxThanhVien.Location = new Point(153, 31);
            textBoxThanhVien.Name = "textBoxThanhVien";
            textBoxThanhVien.ReadOnly = true;
            textBoxThanhVien.Size = new Size(344, 27);
            textBoxThanhVien.TabIndex = 3;
            // 
            // labelNgayMuon
            // 
            labelNgayMuon.Anchor = AnchorStyles.Left;
            labelNgayMuon.AutoSize = true;
            labelNgayMuon.Location = new Point(3, 60);
            labelNgayMuon.Name = "labelNgayMuon";
            labelNgayMuon.Size = new Size(90, 20);
            labelNgayMuon.TabIndex = 4;
            labelNgayMuon.Text = "Ngày mượn:";
            // 
            // textBoxNgayMuon
            // 
            textBoxNgayMuon.Dock = DockStyle.Fill;
            textBoxNgayMuon.Location = new Point(153, 59);
            textBoxNgayMuon.Name = "textBoxNgayMuon";
            textBoxNgayMuon.ReadOnly = true;
            textBoxNgayMuon.Size = new Size(344, 27);
            textBoxNgayMuon.TabIndex = 5;
            // 
            // labelHanTra
            // 
            labelHanTra.Anchor = AnchorStyles.Left;
            labelHanTra.AutoSize = true;
            labelHanTra.Location = new Point(3, 88);
            labelHanTra.Name = "labelHanTra";
            labelHanTra.Size = new Size(61, 20);
            labelHanTra.TabIndex = 6;
            labelHanTra.Text = "Hạn trả:";
            // 
            // textBoxHanTra
            // 
            textBoxHanTra.Dock = DockStyle.Fill;
            textBoxHanTra.Location = new Point(153, 87);
            textBoxHanTra.Name = "textBoxHanTra";
            textBoxHanTra.ReadOnly = true;
            textBoxHanTra.Size = new Size(344, 27);
            textBoxHanTra.TabIndex = 7;
            // 
            // labelNgayTra
            // 
            labelNgayTra.Anchor = AnchorStyles.Left;
            labelNgayTra.AutoSize = true;
            labelNgayTra.Location = new Point(3, 116);
            labelNgayTra.Name = "labelNgayTra";
            labelNgayTra.Size = new Size(69, 20);
            labelNgayTra.TabIndex = 8;
            labelNgayTra.Text = "Ngày trả:";
            // 
            // dateTimePickerNgayTra
            // 
            dateTimePickerNgayTra.Dock = DockStyle.Fill;
            dateTimePickerNgayTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTra.Location = new Point(153, 115);
            dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            dateTimePickerNgayTra.Size = new Size(344, 27);
            dateTimePickerNgayTra.TabIndex = 9;
            // 
            // labelSach
            // 
            labelSach.Anchor = AnchorStyles.Left;
            labelSach.AutoSize = true;
            labelSach.Location = new Point(3, 144);
            labelSach.Name = "labelSach";
            labelSach.Size = new Size(85, 20);
            labelSach.TabIndex = 10;
            labelSach.Text = "Sách trả lại:";
            // 
            // checkedListBoxSach
            // 
            checkedListBoxSach.CheckOnClick = true;
            checkedListBoxSach.Dock = DockStyle.Fill;
            checkedListBoxSach.Location = new Point(153, 143);
            checkedListBoxSach.Name = "checkedListBoxSach";
            checkedListBoxSach.Size = new Size(344, 154);
            checkedListBoxSach.TabIndex = 11;
            // 
            // FormSuaTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 529);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "FormSuaTraSach";
            Text = "Sửa Phiếu Trả";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanelContent;
        private Label labelNhanVien;
        private TextBox textBoxNhanVien;
        private Label labelThanhVien;
        private TextBox textBoxThanhVien;
        private Label labelNgayMuon;
        private TextBox textBoxNgayMuon;
        private Label labelHanTra;
        private TextBox textBoxHanTra;
        private Label labelNgayTra;
        private DateTimePicker dateTimePickerNgayTra;
        private Label labelSach;
        private CheckedListBox checkedListBoxSach;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnLuu;
        private Button btnHuy;
    }
}
