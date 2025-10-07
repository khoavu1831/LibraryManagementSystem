namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            labelTitle = new Label();
            tableLayoutPanelContent = new TableLayoutPanel();
            comboBoxNCC = new ComboBox();
            textBox2 = new TextBox();
            comboBoxLoaiPN = new ComboBox();
            label1 = new Label();
            dateTimePickerNgayNhap = new DateTimePicker();
            dgvChonSach = new DataGridView();
            SachCol = new DataGridViewTextBoxColumn();
            SLTonCol = new DataGridViewTextBoxColumn();
            SLNhapCol = new DataGridViewTextBoxColumn();
            ChonCol = new DataGridViewCheckBoxColumn();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
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
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "Loại phiếu nhập:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 324);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 3;
            label3.Text = "Tổng tiền nhập:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 56);
            label4.Name = "label4";
            label4.Size = new Size(96, 240);
            label4.TabIndex = 7;
            label4.Text = "Sách nhập:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 5;
            label5.Text = "Nhà cung cấp:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(176, 34);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(769, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM PHIẾU NHẬP";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7058821F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.29412F));
            tableLayoutPanelContent.Controls.Add(comboBoxNCC, 1, 1);
            tableLayoutPanelContent.Controls.Add(textBox2, 1, 4);
            tableLayoutPanelContent.Controls.Add(label2, 0, 0);
            tableLayoutPanelContent.Controls.Add(comboBoxLoaiPN, 1, 0);
            tableLayoutPanelContent.Controls.Add(label5, 0, 1);
            tableLayoutPanelContent.Controls.Add(label4, 0, 2);
            tableLayoutPanelContent.Controls.Add(label1, 0, 3);
            tableLayoutPanelContent.Controls.Add(label3, 0, 4);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayNhap, 1, 3);
            tableLayoutPanelContent.Controls.Add(dgvChonSach, 1, 2);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 4;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelContent.Size = new Size(694, 352);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // comboBoxNCC
            // 
            comboBoxNCC.FormattingEnabled = true;
            comboBoxNCC.Location = new Point(105, 31);
            comboBoxNCC.Name = "comboBoxNCC";
            comboBoxNCC.Size = new Size(245, 23);
            comboBoxNCC.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(105, 327);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 35;
            // 
            // comboBoxLoaiPN
            // 
            comboBoxLoaiPN.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoaiPN.FormattingEnabled = true;
            comboBoxLoaiPN.Items.AddRange(new object[] { "Mua", "Tặng" });
            comboBoxLoaiPN.Location = new Point(105, 3);
            comboBoxLoaiPN.Name = "comboBoxLoaiPN";
            comboBoxLoaiPN.Size = new Size(245, 23);
            comboBoxLoaiPN.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 296);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 20;
            label1.Text = "Ngày nhập:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerNgayNhap
            // 
            dateTimePickerNgayNhap.Enabled = false;
            dateTimePickerNgayNhap.Location = new Point(105, 299);
            dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            dateTimePickerNgayNhap.Size = new Size(245, 23);
            dateTimePickerNgayNhap.TabIndex = 34;
            dateTimePickerNgayNhap.Value = new DateTime(2025, 10, 7, 0, 0, 0, 0);
            // 
            // dgvChonSach
            // 
            dgvChonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChonSach.BackgroundColor = Color.White;
            dgvChonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChonSach.Columns.AddRange(new DataGridViewColumn[] { SachCol, SLTonCol, SLNhapCol, ChonCol });
            dgvChonSach.Dock = DockStyle.Fill;
            dgvChonSach.Location = new Point(105, 59);
            dgvChonSach.Name = "dgvChonSach";
            dgvChonSach.Size = new Size(586, 234);
            dgvChonSach.TabIndex = 36;
            // 
            // SachCol
            // 
            SachCol.HeaderText = "Sách";
            SachCol.Name = "SachCol";
            // 
            // SLTonCol
            // 
            SLTonCol.HeaderText = "Số lượng tồn";
            SLTonCol.Name = "SLTonCol";
            // 
            // SLNhapCol
            // 
            SLNhapCol.HeaderText = "Số lượng nhập";
            SLNhapCol.Name = "SLNhapCol";
            // 
            // ChonCol
            // 
            ChonCol.HeaderText = "Chọn";
            ChonCol.Name = "ChonCol";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(769, 94);
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
            panelContent.Size = new Size(769, 449);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(370, 398);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelButtons.Size = new Size(364, 40);
            tableLayoutPanelButtons.TabIndex = 19;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(185, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(176, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 543);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemPhieuNhap";
            Text = "Thêm phiếu nhập";
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanelContent;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Label label1;
        private ComboBox comboBoxLoaiPN;
        private DateTimePicker dateTimePickerNgayNhap;
        private TextBox textBox2;
        private DataGridView dgvChonSach;
        private DataGridViewTextBoxColumn SachCol;
        private DataGridViewTextBoxColumn SLTonCol;
        private DataGridViewTextBoxColumn SLNhapCol;
        private DataGridViewCheckBoxColumn ChonCol;
        private ComboBox comboBoxNCC;
    }
}