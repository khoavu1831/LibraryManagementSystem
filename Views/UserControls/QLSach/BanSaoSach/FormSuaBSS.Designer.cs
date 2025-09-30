namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    partial class FormSuaBSS
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
            btnSua = new Button();
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnHuy = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            label1 = new Label();
            textBoxTenSach = new TextBox();
            label2 = new Label();
            comboBoxTinhTrang = new ComboBox();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Top;
            btnSua.Location = new Point(3, 2);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(173, 34);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
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
            labelTitle.Text = "SỬA BẢN SAO SÁCH";
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
            panelContent.Size = new Size(437, 161);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnSua, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(41, 101);
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
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanelContent.Controls.Add(label1, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxTenSach, 1, 0);
            tableLayoutPanelContent.Controls.Add(label2, 0, 0);
            tableLayoutPanelContent.Controls.Add(comboBoxTinhTrang, 1, 1);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 2;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelContent.Size = new Size(358, 56);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 3;
            label1.Text = "Tình Trạng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Enabled = false;
            textBoxTenSach.Location = new Point(111, 2);
            textBoxTenSach.Margin = new Padding(3, 2, 3, 2);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(244, 23);
            textBoxTenSach.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Sách:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTinhTrang
            // 
            comboBoxTinhTrang.FormattingEnabled = true;
            comboBoxTinhTrang.Location = new Point(111, 31);
            comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            comboBoxTinhTrang.Size = new Size(244, 23);
            comboBoxTinhTrang.TabIndex = 4;
            // 
            // FormSuaBSS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 255);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSuaBSS";
            Text = "Sửa Bản sao sách";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSua;
        private Label labelTitle;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanelButtons;
        private TableLayoutPanel tableLayoutPanelContent;
        private TextBox textBoxTenSach;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxTinhTrang;
    }
}