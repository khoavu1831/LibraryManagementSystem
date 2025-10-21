namespace LMS.Views.UserControls.QLSach
{
    partial class FormThemTacGia
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
            btnThem = new Button();
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnHuy = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            textBoxSDT = new TextBox();
            label4 = new Label();
            textBoxNoiSinh = new TextBox();
            label1 = new Label();
            textBoxTenTacGia = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(173, 34);
            btnThem.TabIndex = 5;
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
            labelTitle.Text = "THÊM TÁC GIẢ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            panelContent.Size = new Size(437, 215);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(41, 158);
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
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanelContent.Controls.Add(textBoxSDT, 1, 3);
            tableLayoutPanelContent.Controls.Add(label4, 0, 3);
            tableLayoutPanelContent.Controls.Add(textBoxNoiSinh, 1, 2);
            tableLayoutPanelContent.Controls.Add(label1, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxTenTacGia, 1, 0);
            tableLayoutPanelContent.Controls.Add(label2, 0, 0);
            tableLayoutPanelContent.Controls.Add(label3, 0, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgaySinh, 1, 1);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 4;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.Size = new Size(358, 113);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(111, 86);
            textBoxSDT.Margin = new Padding(3, 2, 3, 2);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(244, 23);
            textBoxSDT.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 84);
            label4.Name = "label4";
            label4.Size = new Size(102, 29);
            label4.TabIndex = 8;
            label4.Text = "SĐT:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNoiSinh
            // 
            textBoxNoiSinh.Location = new Point(111, 58);
            textBoxNoiSinh.Margin = new Padding(3, 2, 3, 2);
            textBoxNoiSinh.Name = "textBoxNoiSinh";
            textBoxNoiSinh.Size = new Size(244, 23);
            textBoxNoiSinh.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 3;
            label1.Text = "Ngày sinh:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTenTacGia
            // 
            textBoxTenTacGia.Location = new Point(111, 2);
            textBoxTenTacGia.Margin = new Padding(3, 2, 3, 2);
            textBoxTenTacGia.Name = "textBoxTenTacGia";
            textBoxTenTacGia.Size = new Size(244, 23);
            textBoxTenTacGia.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Tác giả:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 4;
            label3.Text = "Nơi sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(111, 31);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(244, 23);
            dateTimePickerNgaySinh.TabIndex = 2;
            dateTimePickerNgaySinh.Value = new DateTime(2025, 10, 5, 0, 0, 0, 0);
            // 
            // FormThemTacGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 309);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemTacGia";
            Text = "Thêm Tác giả";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnThem;
        private Label labelTitle;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanelButtons;
        private TableLayoutPanel tableLayoutPanelContent;
        private TextBox textBoxTenTacGia;
        private Label label2;
        private TextBox textBoxNoiSinh;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxSDT;
        private Label label4;
    }
}