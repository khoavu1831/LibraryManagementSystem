namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    partial class FormSuaMuonSach
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
            btnSua = new Button();
            btnHuy = new Button();
            tableLayoutPanelContent = new TableLayoutPanel();
            labelNhanVien = new Label();
            comboBoxNhanVien = new ComboBox();
            labelThanhVien = new Label();
            comboBoxThanhVien = new ComboBox();
            labelNgayMuon = new Label();
            dateTimePickerNgayMuon = new DateTimePicker();
            labelHanTra = new Label();
            dateTimePickerHanTra = new DateTimePicker();
            labelSach = new Label();
            checkedListBoxSach = new CheckedListBox();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelContent.SuspendLayout();
            SuspendLayout();

            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(515, 75);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SỬA PHIẾU MƯỢN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(515, 75);
            panelTop.TabIndex = 0;

            panelContent.Controls.Add(tableLayoutPanelButtons);
            panelContent.Controls.Add(tableLayoutPanelContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 75);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(515, 322);
            panelContent.TabIndex = 1;
 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnSua, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(85, 260);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(350, 38);
            tableLayoutPanelButtons.TabIndex = 1;

            btnSua.Dock = DockStyle.Top;
            btnSua.Location = new Point(3, 2);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 33);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
      
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(178, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(169, 33);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
    
            tableLayoutPanelContent.ColumnCount = 2;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.287672F));
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.712326F));
            tableLayoutPanelContent.Controls.Add(labelNhanVien, 0, 0);
            tableLayoutPanelContent.Controls.Add(comboBoxNhanVien, 1, 0);
            tableLayoutPanelContent.Controls.Add(labelThanhVien, 0, 1);
            tableLayoutPanelContent.Controls.Add(comboBoxThanhVien, 1, 1);
            tableLayoutPanelContent.Controls.Add(labelNgayMuon, 0, 2);
            tableLayoutPanelContent.Controls.Add(dateTimePickerNgayMuon, 1, 2);
            tableLayoutPanelContent.Controls.Add(labelHanTra, 0, 3);
            tableLayoutPanelContent.Controls.Add(dateTimePickerHanTra, 1, 3);
            tableLayoutPanelContent.Controls.Add(labelSach, 0, 4);
            tableLayoutPanelContent.Controls.Add(checkedListBoxSach, 1, 4);
            tableLayoutPanelContent.Location = new Point(44, 15);
            tableLayoutPanelContent.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 5;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Size = new Size(438, 225);
            tableLayoutPanelContent.TabIndex = 0;
       
            labelNhanVien.Anchor = AnchorStyles.Left;
            labelNhanVien.AutoSize = true;
            labelNhanVien.Location = new Point(3, 3);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(83, 15);
            labelNhanVien.TabIndex = 0;
            labelNhanVien.Text = "Nhân viên lập:";
   
            comboBoxNhanVien.Dock = DockStyle.Fill;
            comboBoxNhanVien.Location = new Point(105, 2);
            comboBoxNhanVien.Margin = new Padding(3, 2, 3, 2);
            comboBoxNhanVien.Name = "comboBoxNhanVien";
            comboBoxNhanVien.Size = new Size(330, 23);
            comboBoxNhanVien.TabIndex = 1;
     
            labelThanhVien.Anchor = AnchorStyles.Left;
            labelThanhVien.AutoSize = true;
            labelThanhVien.Location = new Point(3, 24);
            labelThanhVien.Name = "labelThanhVien";
            labelThanhVien.Size = new Size(68, 15);
            labelThanhVien.TabIndex = 2;
            labelThanhVien.Text = "Thành viên:";
        
            comboBoxThanhVien.Dock = DockStyle.Fill;
            comboBoxThanhVien.Location = new Point(105, 23);
            comboBoxThanhVien.Margin = new Padding(3, 2, 3, 2);
            comboBoxThanhVien.Name = "comboBoxThanhVien";
            comboBoxThanhVien.Size = new Size(330, 23);
            comboBoxThanhVien.TabIndex = 3;
       
            labelNgayMuon.Anchor = AnchorStyles.Left;
            labelNgayMuon.AutoSize = true;
            labelNgayMuon.Location = new Point(3, 45);
            labelNgayMuon.Name = "labelNgayMuon";
            labelNgayMuon.Size = new Size(73, 15);
            labelNgayMuon.TabIndex = 4;
            labelNgayMuon.Text = "Ngày mượn:";
         
            dateTimePickerNgayMuon.Dock = DockStyle.Fill;
            dateTimePickerNgayMuon.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayMuon.Location = new Point(105, 44);
            dateTimePickerNgayMuon.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            dateTimePickerNgayMuon.Size = new Size(330, 23);
            dateTimePickerNgayMuon.TabIndex = 5;
     
            labelHanTra.Anchor = AnchorStyles.Left;
            labelHanTra.AutoSize = true;
            labelHanTra.Location = new Point(3, 66);
            labelHanTra.Name = "labelHanTra";
            labelHanTra.Size = new Size(49, 15);
            labelHanTra.TabIndex = 6;
            labelHanTra.Text = "Hạn trả:";
      
            dateTimePickerHanTra.Dock = DockStyle.Fill;
            dateTimePickerHanTra.Format = DateTimePickerFormat.Short;
            dateTimePickerHanTra.Location = new Point(105, 65);
            dateTimePickerHanTra.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerHanTra.Name = "dateTimePickerHanTra";
            dateTimePickerHanTra.Size = new Size(330, 23);
            dateTimePickerHanTra.TabIndex = 7;
       
            labelSach.Anchor = AnchorStyles.Left;
            labelSach.AutoSize = true;
            labelSach.Location = new Point(3, 147);
            labelSach.Name = "labelSach";
            labelSach.Size = new Size(70, 15);
            labelSach.TabIndex = 8;
            labelSach.Text = "Sách mượn:";
     
            checkedListBoxSach.CheckOnClick = true;
            checkedListBoxSach.Dock = DockStyle.Fill;
            checkedListBoxSach.Location = new Point(105, 86);
            checkedListBoxSach.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxSach.Name = "checkedListBoxSach";
            checkedListBoxSach.Size = new Size(330, 137);
            checkedListBoxSach.TabIndex = 9;
        
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 397);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSuaMuonSach";
            Text = "Sửa Phiếu Mượn";
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
        private System.Windows.Forms.Label labelNgayMuon;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayMuon;
        private System.Windows.Forms.Label labelHanTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerHanTra;
        private System.Windows.Forms.Label labelSach;
        private System.Windows.Forms.CheckedListBox checkedListBoxSach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
    }
}
