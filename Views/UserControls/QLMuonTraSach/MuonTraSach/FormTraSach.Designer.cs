namespace LMS.Views.UserControls.QLMuonTraSach
{
    partial class FormTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraSach));
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDocGia = new TextBox();
            textBoxNgayMuon = new TextBox();
            textBoxNgayHenTra = new TextBox();
            dgvChiTietMuon = new DataGridView();
            label4 = new Label();
            btnHuy = new Button();
            btnXacNhan = new Button();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietMuon).BeginInit();
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
            labelTitle.Size = new Size(679, 94);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "TRẢ SÁCH";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(679, 94);
            panelTop.TabIndex = 18;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(tableLayoutPanel1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 94);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(679, 493);
            panelContent.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(textBoxDocGia, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNgayMuon, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxNgayHenTra, 3, 1);
            tableLayoutPanel1.Controls.Add(dgvChiTietMuon, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(btnHuy, 3, 4);
            tableLayoutPanel1.Controls.Add(btnXacNhan, 1, 4);
            tableLayoutPanel1.Location = new Point(22, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(636, 467);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Độc giả:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày mượn:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(328, 34);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày trả:";
            // 
            // textBoxDocGia
            // 
            tableLayoutPanel1.SetColumnSpan(textBoxDocGia, 2);
            textBoxDocGia.Location = new Point(88, 3);
            textBoxDocGia.Name = "textBoxDocGia";
            textBoxDocGia.ReadOnly = true;
            textBoxDocGia.Size = new Size(227, 23);
            textBoxDocGia.TabIndex = 3;
            // 
            // textBoxNgayMuon
            // 
            textBoxNgayMuon.Location = new Point(88, 31);
            textBoxNgayMuon.Name = "textBoxNgayMuon";
            textBoxNgayMuon.ReadOnly = true;
            textBoxNgayMuon.Size = new Size(226, 23);
            textBoxNgayMuon.TabIndex = 4;
            // 
            // textBoxNgayHenTra
            // 
            textBoxNgayHenTra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNgayHenTra.Location = new Point(405, 31);
            textBoxNgayHenTra.Name = "textBoxNgayHenTra";
            textBoxNgayHenTra.ReadOnly = true;
            textBoxNgayHenTra.Size = new Size(228, 23);
            textBoxNgayHenTra.TabIndex = 5;
            // 
            // dgvChiTietMuon
            // 
            dgvChiTietMuon.BackgroundColor = Color.White;
            dgvChiTietMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvChiTietMuon, 4);
            dgvChiTietMuon.Location = new Point(3, 117);
            dgvChiTietMuon.Name = "dgvChiTietMuon";
            dgvChiTietMuon.Size = new Size(630, 300);
            dgvChiTietMuon.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 4);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(202, 72);
            label4.Name = "label4";
            label4.Size = new Size(231, 25);
            label4.TabIndex = 6;
            label4.Text = "DANH SÁCH SÁCH MƯỢN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(390, 422);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(174, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(88, 422);
            btnXacNhan.Margin = new Padding(3, 2, 3, 2);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(174, 34);
            btnXacNhan.TabIndex = 15;
            btnXacNhan.Text = "Xác nhận trả";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // FormTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 587);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTraSach";
            Text = "Trả Sách";
            Load += FormTraSach_Load;
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietMuon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitle;
        private Panel panelTop;
        private Panel panelContent;
        private Button btnXacNhan;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDocGia;
        private TextBox textBoxNgayMuon;
        private TextBox textBoxNgayHenTra;
        private Label label4;
        private DataGridView dgvChiTietMuon;
    }
}