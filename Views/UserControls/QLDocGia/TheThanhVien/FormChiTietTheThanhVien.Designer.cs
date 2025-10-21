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
            labelTitle = new Label();
            panel1 = new Panel();
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
            btnQuayLai = new Button();
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
            labelTitle.Size = new Size(499, 125);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "CHI TIẾT THẺ THÀNH VIÊN";
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
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 430);
            panel1.TabIndex = 28;
            // 
            // dateTimePickerNgayCap
            // 
            dateTimePickerNgayCap.Enabled = false;
            dateTimePickerNgayCap.Location = new Point(185, 154);
            dateTimePickerNgayCap.Name = "dateTimePickerNgayCap";
            dateTimePickerNgayCap.Size = new Size(278, 27);
            dateTimePickerNgayCap.TabIndex = 35;
            // 
            // dateTimePickerNgayHetHan
            // 
            dateTimePickerNgayHetHan.Enabled = false;
            dateTimePickerNgayHetHan.Location = new Point(185, 213);
            dateTimePickerNgayHetHan.Name = "dateTimePickerNgayHetHan";
            dateTimePickerNgayHetHan.Size = new Size(278, 27);
            dateTimePickerNgayHetHan.TabIndex = 36;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.Enabled = false;
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Location = new Point(185, 266);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(278, 28);
            comboBoxTrangThai.TabIndex = 34;
            // 
            // textBoxIDKhachHang
            // 
            textBoxIDKhachHang.Location = new Point(185, 99);
            textBoxIDKhachHang.Name = "textBoxIDKhachHang";
            textBoxIDKhachHang.ReadOnly = true;
            textBoxIDKhachHang.Size = new Size(278, 27);
            textBoxIDKhachHang.TabIndex = 32;
            // 
            // textBoxIDTheThanhVien
            // 
            textBoxIDTheThanhVien.Location = new Point(185, 50);
            textBoxIDTheThanhVien.Name = "textBoxIDTheThanhVien";
            textBoxIDTheThanhVien.ReadOnly = true;
            textBoxIDTheThanhVien.Size = new Size(278, 27);
            textBoxIDTheThanhVien.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(35, 266);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 27;
            label5.Text = "Trạng thái:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(35, 213);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 28;
            label4.Text = "Ngày hết hạn:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(35, 154);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 29;
            label3.Text = "Ngày cấp:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(35, 99);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 30;
            label1.Text = "ID khách hàng:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(35, 50);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 31;
            label2.Text = "ID thẻ thành viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(156, 340);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(180, 40);
            btnQuayLai.TabIndex = 37;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // FormChiTietTheThanhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 555);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
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