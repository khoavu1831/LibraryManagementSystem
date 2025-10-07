namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    partial class FormThemSach
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
            textBoxTenSach = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnThem = new Button();
            labelTitle = new Label();
            tableLayoutPanelContent = new TableLayoutPanel();
            label6 = new Label();
            checkedListBoxTheLoai = new CheckedListBox();
            textBoxMoTa = new TextBox();
            label1 = new Label();
            checkedListBoxTacGia = new CheckedListBox();
            numericUpDownNamXB = new NumericUpDown();
            numericUpDownSoTrang = new NumericUpDown();
            textBoxGiaSach = new TextBox();
            comboBoxNXB = new ComboBox();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnHuy = new Button();
            tableLayoutPanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamXB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoTrang).BeginInit();
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
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên sách:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Location = new Point(111, 2);
            textBoxTenSach.Margin = new Padding(3, 2, 3, 2);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(244, 23);
            textBoxTenSach.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 196);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Năm xuất bản:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 28);
            label4.Name = "label4";
            label4.Size = new Size(102, 70);
            label4.TabIndex = 7;
            label4.Text = "Tác giả:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 168);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 5;
            label5.Text = "Nhà xuất bản:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 98);
            label7.Name = "label7";
            label7.Size = new Size(102, 70);
            label7.TabIndex = 9;
            label7.Text = "Thể loại:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 252);
            label8.Name = "label8";
            label8.Size = new Size(102, 70);
            label8.TabIndex = 13;
            label8.Text = "Mô tả:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(173, 34);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(437, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM SÁCH";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanelContent.Controls.Add(label6, 0, 7);
            tableLayoutPanelContent.Controls.Add(checkedListBoxTheLoai, 1, 2);
            tableLayoutPanelContent.Controls.Add(textBoxMoTa, 1, 6);
            tableLayoutPanelContent.Controls.Add(textBoxTenSach, 1, 0);
            tableLayoutPanelContent.Controls.Add(label2, 0, 0);
            tableLayoutPanelContent.Controls.Add(label1, 0, 5);
            tableLayoutPanelContent.Controls.Add(label4, 0, 1);
            tableLayoutPanelContent.Controls.Add(label7, 0, 2);
            tableLayoutPanelContent.Controls.Add(label3, 0, 4);
            tableLayoutPanelContent.Controls.Add(label5, 0, 3);
            tableLayoutPanelContent.Controls.Add(checkedListBoxTacGia, 1, 1);
            tableLayoutPanelContent.Controls.Add(numericUpDownNamXB, 1, 4);
            tableLayoutPanelContent.Controls.Add(numericUpDownSoTrang, 1, 5);
            tableLayoutPanelContent.Controls.Add(label8, 0, 6);
            tableLayoutPanelContent.Controls.Add(textBoxGiaSach, 1, 7);
            tableLayoutPanelContent.Controls.Add(comboBoxNXB, 1, 3);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 8;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.Size = new Size(358, 352);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 322);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 28;
            label6.Text = "Giá sách:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkedListBoxTheLoai
            // 
            checkedListBoxTheLoai.Dock = DockStyle.Fill;
            checkedListBoxTheLoai.FormattingEnabled = true;
            checkedListBoxTheLoai.Location = new Point(111, 101);
            checkedListBoxTheLoai.Name = "checkedListBoxTheLoai";
            checkedListBoxTheLoai.Size = new Size(244, 64);
            checkedListBoxTheLoai.TabIndex = 24;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Dock = DockStyle.Fill;
            textBoxMoTa.Location = new Point(111, 254);
            textBoxMoTa.Margin = new Padding(3, 2, 3, 2);
            textBoxMoTa.Multiline = true;
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.ScrollBars = ScrollBars.Vertical;
            textBoxMoTa.Size = new Size(244, 66);
            textBoxMoTa.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 224);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 20;
            label1.Text = "Số trang:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkedListBoxTacGia
            // 
            checkedListBoxTacGia.Dock = DockStyle.Fill;
            checkedListBoxTacGia.FormattingEnabled = true;
            checkedListBoxTacGia.Location = new Point(111, 31);
            checkedListBoxTacGia.Name = "checkedListBoxTacGia";
            checkedListBoxTacGia.Size = new Size(244, 64);
            checkedListBoxTacGia.TabIndex = 23;
            // 
            // numericUpDownNamXB
            // 
            numericUpDownNamXB.Location = new Point(111, 199);
            numericUpDownNamXB.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownNamXB.Name = "numericUpDownNamXB";
            numericUpDownNamXB.Size = new Size(244, 23);
            numericUpDownNamXB.TabIndex = 25;
            // 
            // numericUpDownSoTrang
            // 
            numericUpDownSoTrang.Location = new Point(111, 227);
            numericUpDownSoTrang.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownSoTrang.Name = "numericUpDownSoTrang";
            numericUpDownSoTrang.Size = new Size(244, 23);
            numericUpDownSoTrang.TabIndex = 26;
            // 
            // textBoxGiaSach
            // 
            textBoxGiaSach.Location = new Point(111, 325);
            textBoxGiaSach.Name = "textBoxGiaSach";
            textBoxGiaSach.Size = new Size(244, 23);
            textBoxGiaSach.TabIndex = 27;
            // 
            // comboBoxNXB
            // 
            comboBoxNXB.FormattingEnabled = true;
            comboBoxNXB.Location = new Point(111, 171);
            comboBoxNXB.Name = "comboBoxNXB";
            comboBoxNXB.Size = new Size(244, 23);
            comboBoxNXB.TabIndex = 29;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(437, 94);
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
            panelContent.Size = new Size(437, 455);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(41, 396);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanelButtons.Size = new Size(358, 40);
            tableLayoutPanelButtons.TabIndex = 19;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(182, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(173, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 549);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemSach";
            Text = "v";
            Load += formThemNhanVien_Load;
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamXB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoTrang).EndInit();
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox textBoxTenSach;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button btnThem;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanelContent;
        private TextBox textBoxMoTa;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Label label1;
        private CheckedListBox checkedListBoxTacGia;
        private CheckedListBox checkedListBoxTheLoai;
        private NumericUpDown numericUpDownNamXB;
        private NumericUpDown numericUpDownSoTrang;
        private Label label6;
        private TextBox textBoxGiaSach;
        private ComboBox comboBoxNXB;
    }
}