namespace LMS.Views.UserControls.QLSach
{
    partial class FormChiTietNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietNXB));
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnDong = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            textBoxSDT = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxIdNXB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDiaChi = new TextBox();
            textBoxTenNXB = new TextBox();
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
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(437, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHI TIẾT NHÀ XUẤT BẢN";
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
            panelContent.Size = new Size(437, 207);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 1;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButtons.Controls.Add(btnDong, 0, 0);
            tableLayoutPanelButtons.Location = new Point(41, 156);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(358, 40);
            tableLayoutPanelButtons.TabIndex = 19;
            // 
            // btnDong
            // 
            btnDong.Dock = DockStyle.Top;
            btnDong.Location = new Point(3, 2);
            btnDong.Margin = new Padding(3, 2, 3, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(352, 34);
            btnDong.TabIndex = 18;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanelContent.Controls.Add(textBoxSDT, 1, 2);
            tableLayoutPanelContent.Controls.Add(label3, 0, 2);
            tableLayoutPanelContent.Controls.Add(label4, 0, 0);
            tableLayoutPanelContent.Controls.Add(textBoxIdNXB, 1, 0);
            tableLayoutPanelContent.Controls.Add(label1, 0, 3);
            tableLayoutPanelContent.Controls.Add(label2, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxDiaChi, 1, 3);
            tableLayoutPanelContent.Controls.Add(textBoxTenNXB, 1, 1);
            tableLayoutPanelContent.Location = new Point(41, 25);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 4;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.Size = new Size(358, 112);
            tableLayoutPanelContent.TabIndex = 17;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Enabled = false;
            textBoxSDT.Location = new Point(111, 58);
            textBoxSDT.Margin = new Padding(3, 2, 3, 2);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.ReadOnly = true;
            textBoxSDT.Size = new Size(244, 23);
            textBoxSDT.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 7;
            label4.Text = "Id NXB:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxIdNXB
            // 
            textBoxIdNXB.Enabled = false;
            textBoxIdNXB.Location = new Point(111, 2);
            textBoxIdNXB.Margin = new Padding(3, 2, 3, 2);
            textBoxIdNXB.Name = "textBoxIdNXB";
            textBoxIdNXB.ReadOnly = true;
            textBoxIdNXB.Size = new Size(244, 23);
            textBoxIdNXB.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 84);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 3;
            label1.Text = "Địa chỉ:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên NXB:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Location = new Point(111, 86);
            textBoxDiaChi.Margin = new Padding(3, 2, 3, 2);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.ReadOnly = true;
            textBoxDiaChi.Size = new Size(244, 23);
            textBoxDiaChi.TabIndex = 5;
            // 
            // textBoxTenNXB
            // 
            textBoxTenNXB.Enabled = false;
            textBoxTenNXB.Location = new Point(111, 30);
            textBoxTenNXB.Margin = new Padding(3, 2, 3, 2);
            textBoxTenNXB.Name = "textBoxTenNXB";
            textBoxTenNXB.ReadOnly = true;
            textBoxTenNXB.Size = new Size(244, 23);
            textBoxTenNXB.TabIndex = 2;
            // 
            // FormChiTietNXB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 301);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChiTietNXB";
            Text = "Chi tiết NXB";
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
        private TableLayoutPanel tableLayoutPanelContent;
        private TextBox textBoxTenNXB;
        private Label label2;
        private TextBox textBoxSDT;
        private TextBox textBoxDiaChi;
        private Label label1;
        private Label label3;
        private Button btnDong;
        private Label label4;
        private TextBox textBoxIdNXB;
    }
}