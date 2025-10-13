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
            labelIDPhieuMuon = new Label();
            comboBoxIDPhieuMuon = new ComboBox();
            labelNhanVien = new Label();
            textBoxNhanVien = new TextBox();
            labelThanhVien = new Label();
            textBoxThanhVien = new TextBox();
            labelNgayTra = new Label();
            dateTimePickerNgayTra = new DateTimePicker();
            labelSach = new Label();
            panelSach = new Panel();
            flowLayoutPanelSach = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            panelSach.SuspendLayout();
            SuspendLayout();
            
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(650, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "THÊM PHIẾU TRẢ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
          
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(650, 80);
            panelTop.TabIndex = 0;
        
            panelContent.Controls.Add(tableLayoutPanelButtons);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(650, 450);
            panelContent.TabIndex = 1;
      
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(150, 380);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(350, 40);
            tableLayoutPanelButtons.TabIndex = 1;
       
            btnThem.Dock = DockStyle.Fill;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 36);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
         
            btnHuy.Dock = DockStyle.Fill;
            btnHuy.Location = new Point(178, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(169, 36);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
         
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.363636F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.63636F));
            tableLayoutPanelContent.Controls.Add(labelIDPhieuMuon, 0, 0);
            tableLayoutPanelContent.Controls.Add(comboBoxIDPhieuMuon, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelNhanVien, 0, 1);
            tableLayoutPanelContent.Controls.Add(textBoxNhanVien, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelThanhVien, 0, 2);
            tableLayoutPanelContent.Controls.Add(textBoxThanhVien, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelNgayTra, 0, 3);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayTra, 1, 3);
            tableLayoutPanelContent.Controls.Add(labelSach, 0, 4);
            tableLayoutPanelContent.Controls.Add(panelSach, 1, 4);
            tableLayoutPanelContent.Location = new Point(50, 20);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 5;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Size = new Size(550, 350);
            tableLayoutPanelContent.TabIndex = 0;
      
            labelIDPhieuMuon.Anchor = AnchorStyles.Left;
            labelIDPhieuMuon.AutoSize = true;
            labelIDPhieuMuon.Location = new Point(3, 5);
            labelIDPhieuMuon.Name = "labelIDPhieuMuon";
            labelIDPhieuMuon.Size = new Size(89, 15);
            labelIDPhieuMuon.TabIndex = 8;
            labelIDPhieuMuon.Text = "ID Phiếu mượn:";
         
            comboBoxIDPhieuMuon.Dock = DockStyle.Fill;
            comboBoxIDPhieuMuon.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIDPhieuMuon.Location = new Point(104, 2);
            comboBoxIDPhieuMuon.Margin = new Padding(3, 2, 3, 2);
            comboBoxIDPhieuMuon.Name = "comboBoxIDPhieuMuon";
            comboBoxIDPhieuMuon.Size = new Size(443, 23);
            comboBoxIDPhieuMuon.TabIndex = 9;
            comboBoxIDPhieuMuon.SelectedIndexChanged += comboBoxIDPhieuMuon_SelectedIndexChanged;
        
            labelNhanVien.Anchor = AnchorStyles.Left;
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(3, 30);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(83, 15);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Nhân viên lập:";
          
            textBoxNhanVien.BackColor = SystemColors.Control;
            textBoxNhanVien.Dock = DockStyle.Fill;
            textBoxNhanVien.Location = new Point(104, 27);
            textBoxNhanVien.Margin = new Padding(3, 2, 3, 2);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(443, 23);
            textBoxNhanVien.TabIndex = 1;
          
            labelThanhVien.Anchor = AnchorStyles.Left;
            labelThanhVien.AutoSize = true;
            labelThanhVien.Location = new Point(3, 55);
            labelThanhVien.Name = "labelThanhVien";
            labelThanhVien.Size = new Size(68, 15);
            labelThanhVien.TabIndex = 2;
            labelThanhVien.Text = "Thành viên:";
            
            textBoxThanhVien.BackColor = SystemColors.Control;
            textBoxThanhVien.Dock = DockStyle.Fill;
            textBoxThanhVien.Location = new Point(104, 52);
            textBoxThanhVien.Margin = new Padding(3, 2, 3, 2);
            textBoxThanhVien.Name = "textBoxThanhVien";
            textBoxThanhVien.ReadOnly = true;
            textBoxThanhVien.Size = new Size(443, 23);
            textBoxThanhVien.TabIndex = 3;
            
            labelNgayTra.Anchor = AnchorStyles.Left;
            labelNgayTra.AutoSize = true;
            labelNgayTra.Location = new Point(3, 80);
            labelNgayTra.Name = "labelNgayTra";
            labelNgayTra.Size = new Size(55, 15);
            labelNgayTra.TabIndex = 4;
            labelNgayTra.Text = "Ngày trả:";
           
            dateTimePickerNgayTra.Dock = DockStyle.Fill;
            dateTimePickerNgayTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTra.Location = new Point(104, 77);
            dateTimePickerNgayTra.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            dateTimePickerNgayTra.Size = new Size(443, 23);
            dateTimePickerNgayTra.TabIndex = 5;
           
            labelSach.Anchor = AnchorStyles.Left;
            labelSach.AutoSize = true;
            labelSach.Location = new Point(3, 217);
            labelSach.Name = "labelSach";
            labelSach.Size = new Size(52, 15);
            labelSach.TabIndex = 6;
            labelSach.Text = "Sách trả:";
           
            panelSach.BorderStyle = BorderStyle.FixedSingle;
            panelSach.Controls.Add(flowLayoutPanelSach);
            panelSach.Dock = DockStyle.Fill;
            panelSach.Location = new Point(104, 102);
            panelSach.Margin = new Padding(3, 2, 3, 2);
            panelSach.Name = "panelSach";
            panelSach.Size = new Size(443, 246);
            panelSach.TabIndex = 7;
           
            flowLayoutPanelSach.AutoScroll = true;
            flowLayoutPanelSach.Dock = DockStyle.Fill;
            flowLayoutPanelSach.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelSach.Location = new Point(0, 0);
            flowLayoutPanelSach.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelSach.Name = "flowLayoutPanelSach";
            flowLayoutPanelSach.Size = new Size(441, 244);
            flowLayoutPanelSach.TabIndex = 0;
            flowLayoutPanelSach.WrapContents = false;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 530);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemTraSach";
            Text = "Thêm Phiếu Trả";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            panelSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private System.Windows.Forms.Label labelIDPhieuMuon;
        private System.Windows.Forms.ComboBox comboBoxIDPhieuMuon;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.TextBox textBoxNhanVien;
        private System.Windows.Forms.Label labelThanhVien;
        private System.Windows.Forms.TextBox textBoxThanhVien;
        private System.Windows.Forms.Label labelNgayTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Label labelSach;
        private System.Windows.Forms.Panel panelSach;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}
