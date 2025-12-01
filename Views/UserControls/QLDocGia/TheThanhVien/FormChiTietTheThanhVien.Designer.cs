namespace LMS.Views.UserControls.QLDocGia.TheThanhVien
{
    partial class FormChiTietTheThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietTheThanhVien));
            labelTitle = new Label();
            panel1 = new Panel();
            btnQuayLai = new Button();
            dateTimePickerNgayCap = new DateTimePicker();
            dateTimePickerNgayHetHan = new DateTimePicker();
            comboBoxTrangThai = new ComboBox();
            textBoxIDKhachHang = new TextBox();
            textBoxIDTheThanhVien = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.HotTrack;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(437, 94);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "THÔNG TIN THẺ THÀNH VIÊN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnQuayLai);
            panel1.Controls.Add(dateTimePickerNgayCap);
            panel1.Controls.Add(dateTimePickerNgayHetHan);
            panel1.Controls.Add(comboBoxTrangThai);
            panel1.Controls.Add(textBoxIDKhachHang);
            panel1.Controls.Add(textBoxIDTheThanhVien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 94);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 322);
            panel1.TabIndex = 28;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(136, 255);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(158, 30);
            btnQuayLai.TabIndex = 37;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dateTimePickerNgayCap
            // 
            dateTimePickerNgayCap.CalendarMonthBackground = Color.White;
            dateTimePickerNgayCap.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayCap.Enabled = false;
            dateTimePickerNgayCap.Location = new Point(162, 116);
            dateTimePickerNgayCap.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayCap.Name = "dateTimePickerNgayCap";
            dateTimePickerNgayCap.Size = new Size(244, 23);
            dateTimePickerNgayCap.TabIndex = 35;
            // 
            // dateTimePickerNgayHetHan
            // 
            dateTimePickerNgayHetHan.CalendarMonthBackground = Color.White;
            dateTimePickerNgayHetHan.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayHetHan.Enabled = false;
            dateTimePickerNgayHetHan.Location = new Point(162, 160);
            dateTimePickerNgayHetHan.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNgayHetHan.Name = "dateTimePickerNgayHetHan";
            dateTimePickerNgayHetHan.Size = new Size(244, 23);
            dateTimePickerNgayHetHan.TabIndex = 36;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.BackColor = Color.White;
            comboBoxTrangThai.Enabled = false;
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(162, 200);
            comboBoxTrangThai.Margin = new Padding(3, 2, 3, 2);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(244, 23);
            comboBoxTrangThai.TabIndex = 34;
            // 
            // textBoxIDKhachHang
            // 
            textBoxIDKhachHang.BackColor = Color.White;
            textBoxIDKhachHang.Location = new Point(162, 74);
            textBoxIDKhachHang.Margin = new Padding(3, 2, 3, 2);
            textBoxIDKhachHang.Name = "textBoxIDKhachHang";
            textBoxIDKhachHang.ReadOnly = true;
            textBoxIDKhachHang.Size = new Size(244, 23);
            textBoxIDKhachHang.TabIndex = 32;
            // 
            // textBoxIDTheThanhVien
            // 
            textBoxIDTheThanhVien.BackColor = Color.White;
            textBoxIDTheThanhVien.Location = new Point(162, 38);
            textBoxIDTheThanhVien.Margin = new Padding(3, 2, 3, 2);
            textBoxIDTheThanhVien.Name = "textBoxIDTheThanhVien";
            textBoxIDTheThanhVien.ReadOnly = true;
            textBoxIDTheThanhVien.Size = new Size(244, 23);
            textBoxIDTheThanhVien.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(31, 200);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 27;
            label5.Text = "Trạng thái:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(31, 160);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 28;
            label4.Text = "Ngày hết hạn:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(31, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 29;
            label3.Text = "Ngày cấp:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(31, 74);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 30;
            label1.Text = "ID khách hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(31, 38);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 31;
            label2.Text = "ID thẻ thành viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormChiTietTheThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 416);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChiTietTheThanhVien";
            Text = "FormChiTietTheThanhVien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private DateTimePicker dateTimePickerNgayCap;
        private DateTimePicker dateTimePickerNgayHetHan;
        private ComboBox comboBoxTrangThai;
        private TextBox textBoxIDKhachHang;
        private TextBox textBoxIDTheThanhVien;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnQuayLai;
    }
}