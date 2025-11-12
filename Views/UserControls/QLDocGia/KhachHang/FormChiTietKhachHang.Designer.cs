namespace LMS.Views.UserControls.QLDocGia.KhachHang
{
    partial class FormChiTietKhachHang
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
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnQuayLai = new Button();
            textBoxEmail = new TextBox();
            textBoxSoDienThoai = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxTenKhachHang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerDob = new DateTimePicker();
            panel1.SuspendLayout();
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
            labelTitle.Size = new Size(437, 94);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "CHI TIẾT KHÁCH HÀNG";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePickerDob);
            panel1.Controls.Add(tableLayoutPanelButtons);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxSoDienThoai);
            panel1.Controls.Add(textBoxDiaChi);
            panel1.Controls.Add(textBoxTenKhachHang);
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
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 1;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnQuayLai, 0, 0);
            tableLayoutPanelButtons.Location = new Point(129, 248);
            tableLayoutPanelButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanelButtons.Size = new Size(163, 34);
            tableLayoutPanelButtons.TabIndex = 21;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Dock = DockStyle.Top;
            btnQuayLai.Location = new Point(3, 2);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(157, 30);
            btnQuayLai.TabIndex = 15;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(175, 194);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(244, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxSoDienThoai
            // 
            textBoxSoDienThoai.Location = new Point(175, 154);
            textBoxSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            textBoxSoDienThoai.ReadOnly = true;
            textBoxSoDienThoai.Size = new Size(244, 23);
            textBoxSoDienThoai.TabIndex = 10;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(175, 74);
            textBoxDiaChi.Margin = new Padding(3, 2, 3, 2);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.ReadOnly = true;
            textBoxDiaChi.Size = new Size(244, 23);
            textBoxDiaChi.TabIndex = 12;
            // 
            // textBoxTenKhachHang
            // 
            textBoxTenKhachHang.Location = new Point(175, 38);
            textBoxTenKhachHang.Margin = new Padding(3, 2, 3, 2);
            textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            textBoxTenKhachHang.ReadOnly = true;
            textBoxTenKhachHang.Size = new Size(244, 23);
            textBoxTenKhachHang.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(44, 200);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(44, 160);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(44, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(44, 74);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Địa chỉ:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(44, 38);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 8;
            label2.Text = "Tên khách hàng:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDob
            // 
            dateTimePickerDob.Location = new Point(175, 116);
            dateTimePickerDob.Name = "dateTimePickerDob";
            dateTimePickerDob.Size = new Size(241, 23);
            dateTimePickerDob.TabIndex = 22;
            // 
            // FormChiTietKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 416);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChiTietKhachHang";
            Text = "FormChiTietKhachHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnQuayLai;
        private TextBox textBoxEmail;
        private TextBox textBoxSoDienThoai;
        private TextBox textBoxDiaChi;
        private TextBox textBoxTenKhachHang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerDob;
    }
}