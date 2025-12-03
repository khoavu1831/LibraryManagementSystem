namespace LMS.Views.UserControls.QLPhat.TraPhat
{
    partial class FormTraPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraPhat));
            label2 = new Label();
            textBoxHoVaTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            textBoxTienPhat = new TextBox();
            textBoxSoNgayTre = new TextBox();
            textBoxIDPhieuMuon = new TextBox();
            dateTimePickerNgayLap = new DateTimePicker();
            dateTimePickerNgayTraPhat = new DateTimePicker();
            comboBoxLoaiPhat = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonThanhToan = new Button();
            buttonHuy = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxHoVaTen
            // 
            textBoxHoVaTen.Dock = DockStyle.Fill;
            textBoxHoVaTen.Location = new Point(104, 2);
            textBoxHoVaTen.Margin = new Padding(3, 2, 3, 2);
            textBoxHoVaTen.Multiline = true;
            textBoxHoVaTen.Name = "textBoxHoVaTen";
            textBoxHoVaTen.ReadOnly = true;
            textBoxHoVaTen.Size = new Size(227, 24);
            textBoxHoVaTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 28);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 3;
            label3.Text = "Mã phiếu mượn:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 84);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 7;
            label4.Text = "Loại phạt:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 56);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 5;
            label5.Text = "Ngày lập:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 140);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 11;
            label6.Text = "Tiền phạt:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 112);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 9;
            label7.Text = "Số ngày trễ:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(456, 94);
            label1.TabIndex = 0;
            label1.Text = "TRẢ PHIẾU PHẠT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(textBoxTienPhat, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxSoNgayTre, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxIDPhieuMuon, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxHoVaTen, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerNgayLap, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerNgayTraPhat, 1, 6);
            tableLayoutPanel1.Controls.Add(comboBoxLoaiPhat, 1, 3);
            tableLayoutPanel1.Location = new Point(60, 18);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(334, 198);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 168);
            label8.Name = "label8";
            label8.Size = new Size(95, 30);
            label8.TabIndex = 20;
            label8.Text = "Ngày trả phạt:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTienPhat
            // 
            textBoxTienPhat.Dock = DockStyle.Fill;
            textBoxTienPhat.Location = new Point(104, 142);
            textBoxTienPhat.Margin = new Padding(3, 2, 3, 2);
            textBoxTienPhat.Multiline = true;
            textBoxTienPhat.Name = "textBoxTienPhat";
            textBoxTienPhat.ReadOnly = true;
            textBoxTienPhat.Size = new Size(227, 24);
            textBoxTienPhat.TabIndex = 18;
            // 
            // textBoxSoNgayTre
            // 
            textBoxSoNgayTre.Dock = DockStyle.Fill;
            textBoxSoNgayTre.Location = new Point(104, 114);
            textBoxSoNgayTre.Margin = new Padding(3, 2, 3, 2);
            textBoxSoNgayTre.Multiline = true;
            textBoxSoNgayTre.Name = "textBoxSoNgayTre";
            textBoxSoNgayTre.ReadOnly = true;
            textBoxSoNgayTre.Size = new Size(227, 24);
            textBoxSoNgayTre.TabIndex = 17;
            // 
            // textBoxIDPhieuMuon
            // 
            textBoxIDPhieuMuon.Dock = DockStyle.Fill;
            textBoxIDPhieuMuon.Location = new Point(104, 30);
            textBoxIDPhieuMuon.Margin = new Padding(3, 2, 3, 2);
            textBoxIDPhieuMuon.Multiline = true;
            textBoxIDPhieuMuon.Name = "textBoxIDPhieuMuon";
            textBoxIDPhieuMuon.ReadOnly = true;
            textBoxIDPhieuMuon.Size = new Size(227, 24);
            textBoxIDPhieuMuon.TabIndex = 14;
            // 
            // dateTimePickerNgayLap
            // 
            dateTimePickerNgayLap.Dock = DockStyle.Fill;
            dateTimePickerNgayLap.Enabled = false;
            dateTimePickerNgayLap.Location = new Point(104, 59);
            dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            dateTimePickerNgayLap.Size = new Size(227, 23);
            dateTimePickerNgayLap.TabIndex = 21;
            // 
            // dateTimePickerNgayTraPhat
            // 
            dateTimePickerNgayTraPhat.Dock = DockStyle.Fill;
            dateTimePickerNgayTraPhat.Enabled = false;
            dateTimePickerNgayTraPhat.Location = new Point(104, 171);
            dateTimePickerNgayTraPhat.Name = "dateTimePickerNgayTraPhat";
            dateTimePickerNgayTraPhat.Size = new Size(227, 23);
            dateTimePickerNgayTraPhat.TabIndex = 22;
            // 
            // comboBoxLoaiPhat
            // 
            comboBoxLoaiPhat.Dock = DockStyle.Fill;
            comboBoxLoaiPhat.FormattingEnabled = true;
            comboBoxLoaiPhat.Location = new Point(104, 87);
            comboBoxLoaiPhat.Name = "comboBoxLoaiPhat";
            comboBoxLoaiPhat.Size = new Size(227, 23);
            comboBoxLoaiPhat.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 94);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 304);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonThanhToan, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonHuy, 1, 0);
            tableLayoutPanel3.Location = new Point(66, 243);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel3.Size = new Size(325, 40);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // buttonThanhToan
            // 
            buttonThanhToan.Dock = DockStyle.Top;
            buttonThanhToan.Location = new Point(3, 2);
            buttonThanhToan.Margin = new Padding(3, 2, 3, 2);
            buttonThanhToan.Name = "buttonThanhToan";
            buttonThanhToan.Size = new Size(156, 34);
            buttonThanhToan.TabIndex = 15;
            buttonThanhToan.Text = "Thanh toán";
            buttonThanhToan.UseVisualStyleBackColor = true;
            buttonThanhToan.Click += buttonThanhToan_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Dock = DockStyle.Top;
            buttonHuy.Location = new Point(165, 2);
            buttonHuy.Margin = new Padding(3, 2, 3, 2);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(157, 34);
            buttonHuy.TabIndex = 18;
            buttonHuy.Text = "Hủy";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // FormTraPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 398);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTraPhat";
            Text = "Trả Phiếu Phạt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxSDT;
        private TextBox textBoxDC;
        private TextBox textBoxTK;
        private Panel panel1;
        private Panel panel2;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel2;
        #endregion
        private Label label2;
        private TextBox textBoxHoVaTen;
        private TextBox textBoxHVT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnThem;
        private Label label1;
        private Resources.CustomComponents.MyComboBox myComboBoxLoaiPhat;
        private Label label8;
        private TextBox textBoxTienPhat;
        private TextBox textBoxSoNgayTre;
        private TextBox textBoxIDPhieuMuon;
        private DateTimePicker dateTimePickerNgayLap;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonThanhToan;
        private Button buttonHuy;
        private DateTimePicker dateTimePickerNgayTraPhat;
        private ComboBox comboBoxLoaiPhat;
    }
}