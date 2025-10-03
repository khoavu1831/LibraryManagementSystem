namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    partial class FormChiTietMuonSach
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
            btnQuayLai = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            labelNhanVien = new Label();
            lblNhanVienValue = new Label();
            labelThanhVien = new Label();
            lblThanhVienValue = new Label();
            labelNgayMuon = new Label();
            lblNgayMuonValue = new Label();
            labelHanTra = new Label();
            lblHanTraValue = new Label();
            labelSach = new Label();
            listBoxSach = new ListBox();
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
            labelTitle.Text = "CHI TIẾT PHIẾU MƯỢN";
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
            tableLayoutPanelButtons.ColumnCount = 1;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Controls.Add(btnQuayLai, 0, 0);
            tableLayoutPanelButtons.Location = new Point(190, 360);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(200, 50);
            tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Dock = DockStyle.Fill;
            btnQuayLai.Location = new Point(3, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(194, 44);
            btnQuayLai.TabIndex = 15;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelContent.Controls.Add(labelNhanVien, 0, 0);
            tableLayoutPanelContent.Controls.Add(lblNhanVienValue, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelThanhVien, 0, 1);
            tableLayoutPanelContent.Controls.Add(lblThanhVienValue, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelNgayMuon, 0, 2);
            tableLayoutPanelContent.Controls.Add(lblNgayMuonValue, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelHanTra, 0, 3);
            tableLayoutPanelContent.Controls.Add(lblHanTraValue, 1, 3);
            tableLayoutPanelContent.Controls.Add(labelSach, 0, 4);
            tableLayoutPanelContent.Controls.Add(listBoxSach, 1, 4);
            tableLayoutPanelContent.Location = new Point(50, 20);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 5;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Size = new Size(500, 320);
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
            // lblNhanVienValue
            // 
            lblNhanVienValue.Anchor = AnchorStyles.Left;
            lblNhanVienValue.AutoSize = true;
            lblNhanVienValue.Location = new Point(153, 4);
            lblNhanVienValue.Name = "lblNhanVienValue";
            lblNhanVienValue.Size = new Size(94, 20);
            lblNhanVienValue.TabIndex = 1;
            lblNhanVienValue.Text = "(Tên NV ở đây)";
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
            // lblThanhVienValue
            // 
            lblThanhVienValue.Anchor = AnchorStyles.Left;
            lblThanhVienValue.AutoSize = true;
            lblThanhVienValue.Location = new Point(153, 32);
            lblThanhVienValue.Name = "lblThanhVienValue";
            lblThanhVienValue.Size = new Size(107, 20);
            lblThanhVienValue.TabIndex = 3;
            lblThanhVienValue.Text = "(Tên TV ở đây)";
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
            // lblNgayMuonValue
            // 
            lblNgayMuonValue.Anchor = AnchorStyles.Left;
            lblNgayMuonValue.AutoSize = true;
            lblNgayMuonValue.Location = new Point(153, 60);
            lblNgayMuonValue.Name = "lblNgayMuonValue";
            lblNgayMuonValue.Size = new Size(97, 20);
            lblNgayMuonValue.TabIndex = 5;
            lblNgayMuonValue.Text = "(dd/MM/yyyy)";
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
            // lblHanTraValue
            // 
            lblHanTraValue.Anchor = AnchorStyles.Left;
            lblHanTraValue.AutoSize = true;
            lblHanTraValue.Location = new Point(153, 88);
            lblHanTraValue.Name = "lblHanTraValue";
            lblHanTraValue.Size = new Size(97, 20);
            lblHanTraValue.TabIndex = 7;
            lblHanTraValue.Text = "(dd/MM/yyyy)";
            // 
            // labelSach
            // 
            labelSach.Anchor = AnchorStyles.Left;
            labelSach.AutoSize = true;
            labelSach.Location = new Point(3, 196);
            labelSach.Name = "labelSach";
            labelSach.Size = new Size(86, 20);
            labelSach.TabIndex = 8;
            labelSach.Text = "Sách mượn:";
            // 
            // listBoxSach
            // 
            listBoxSach.Dock = DockStyle.Fill;
            listBoxSach.FormattingEnabled = true;
            listBoxSach.ItemHeight = 20;
            listBoxSach.Location = new Point(153, 115);
            listBoxSach.Name = "listBoxSach";
            listBoxSach.SelectionMode = SelectionMode.None;
            listBoxSach.Size = new Size(344, 202);
            listBoxSach.TabIndex = 9;
            // 
            // FormChiTietMuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 529);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Name = "FormChiTietMuonSach";
            Text = "Chi Tiết Phiếu Mượn";
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
        private System.Windows.Forms.Label lblNhanVienValue;
        private System.Windows.Forms.Label labelThanhVien;
        private System.Windows.Forms.Label lblThanhVienValue;
        private System.Windows.Forms.Label labelNgayMuon;
        private System.Windows.Forms.Label lblNgayMuonValue;
        private System.Windows.Forms.Label labelHanTra;
        private System.Windows.Forms.Label lblHanTraValue;
        private System.Windows.Forms.Label labelSach;
        private System.Windows.Forms.ListBox listBoxSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnQuayLai;
    }
}
