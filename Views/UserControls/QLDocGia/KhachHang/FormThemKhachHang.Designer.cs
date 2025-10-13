namespace LibraryManagementSystem.Views.UserControls.QLDocGia.KhachHang
{
    partial class FormThemKhachHang
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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            textBoxTenKhachHang = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSoDienThoai = new TextBox();
            textBoxEmail = new TextBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnThem = new Button();
            btnHuy = new Button();
            dateTimePickerDob = new DateTimePicker();
            tableLayoutPanelButtons.SuspendLayout();
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
            labelTitle.TabIndex = 1;
            labelTitle.Text = "THÊM KHÁCH HÀNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(39, 176);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(39, 225);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Địa chỉ:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(39, 280);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(39, 339);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "Số điện thoại:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(39, 392);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // textBoxTenKhachHang
            // 
            textBoxTenKhachHang.Location = new Point(189, 176);
            textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            textBoxTenKhachHang.Size = new Size(278, 27);
            textBoxTenKhachHang.TabIndex = 3;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(189, 225);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(278, 27);
            textBoxDiaChi.TabIndex = 3;
            // 
            // textBoxSoDienThoai
            // 
            textBoxSoDienThoai.Location = new Point(189, 332);
            textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            textBoxSoDienThoai.Size = new Size(278, 27);
            textBoxSoDienThoai.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(189, 385);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(278, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnThem, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanelButtons.Location = new Point(48, 460);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButtons.Size = new Size(409, 53);
            tableLayoutPanelButtons.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(198, 45);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(207, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(199, 45);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dateTimePickerDob
            // 
            dateTimePickerDob.Location = new Point(189, 283);
            dateTimePickerDob.Name = "dateTimePickerDob";
            dateTimePickerDob.Size = new Size(278, 27);
            dateTimePickerDob.TabIndex = 21;
            // 
            // FormThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 555);
            Controls.Add(dateTimePickerDob);
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSoDienThoai);
            Controls.Add(textBoxDiaChi);
            Controls.Add(textBoxTenKhachHang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Name = "FormThemKhachHang";
            Text = "FormThemKhachHang";
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private NotifyIcon notifyIcon1;
        private TextBox textBoxTenKhachHang;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSoDienThoai;
        private TextBox textBoxEmail;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnThem;
        private Button btnHuy;
        private DateTimePicker dateTimePickerDob;
    }
}