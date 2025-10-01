namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    partial class FormThemTraSach
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
            btnThem = new Button();
            btnHuy = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            labelNhanVien = new Label();
            comboBoxNhanVien = new ComboBox();
            labelThanhVien = new Label();
            comboBoxThanhVien = new ComboBox();
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
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(589, 100);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM PHIẾU TRẢ";
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
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(97, 347);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(400, 50);
            tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(194, 44);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(203, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(194, 44);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelContent.Controls.Add(labelNhanVien, 0, 0);
            tableLayoutPanelContent.Controls.Add(comboBoxNhanVien, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelThanhVien, 0, 1);
            tableLayoutPanelContent.Controls.Add(comboBoxThanhVien, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelNgayTra, 0, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayTra, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelSach, 0, 3);
            tableLayoutPanelContent.Controls.Add(checkedListBoxSach, 1, 3);
            tableLayoutPanelContent.Location = new Point(50, 20);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 4;
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
            // comboBoxNhanVien
            // 
            comboBoxNhanVien.Dock = DockStyle.Fill;
            comboBoxNhanVien.Location = new Point(153, 3);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(344, 28);
            comboBoxNhanVien.TabIndex = 1;
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
            // comboBoxThanhVien
            // 
            comboBoxThanhVien.Dock = DockStyle.Fill;
            comboBoxThanhVien.Location = new Point(153, 31);
            comboBoxThanhVien.Name = "comboBoxThanhVien";
            comboBoxThanhVien.Size = new Size(344, 28);
            comboBoxThanhVien.TabIndex = 3;
            // 
            // labelNgayTra
            // 
            labelNgayTra.Anchor = AnchorStyles.Left;
            labelNgayTra.AutoSize = true;
            labelNgayTra.Location = new Point(3, 60);
            labelNgayTra.Name = "labelNgayTra";
            labelNgayTra.Size = new Size(69, 20);
            labelNgayTra.TabIndex = 4;
            labelNgayTra.Text = "Ngày trả:";
            // 
            // dateTimePickerNgayTra
            // 
            dateTimePickerNgayTra.Dock = DockStyle.Fill;
            dateTimePickerNgayTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTra.Location = new Point(153, 59);
            dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            dateTimePickerNgayTra.Size = new Size(344, 27);
            dateTimePickerNgayTra.TabIndex = 5;
            // 
            // labelSach
            // 
            labelSach.Anchor = AnchorStyles.Left;
            labelSach.AutoSize = true;
            labelSach.Location = new Point(3, 182);
            labelSach.Name = "labelSach";
            labelSach.Size = new Size(65, 20);
            labelSach.TabIndex = 6;
            labelSach.Text = "Sách trả:";
            // 
            // checkedListBoxSach
            // 
            checkedListBoxSach.CheckOnClick = true;
            checkedListBoxSach.Dock = DockStyle.Fill;
            checkedListBoxSach.Location = new Point(153, 87);
            checkedListBoxSach.Name = "checkedListBoxSach";
            checkedListBoxSach.Size = new Size(344, 210);
            checkedListBoxSach.TabIndex = 7;
            // 
            // FormThemTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 529);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "FormThemTraSach";
            Text = "Thêm Phiếu Trả";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.Label labelThanhVien;
        private System.Windows.Forms.ComboBox comboBoxThanhVien;
        private System.Windows.Forms.Label labelNgayTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label labelSach;
        private System.Windows.Forms.CheckedListBox checkedListBoxSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}
