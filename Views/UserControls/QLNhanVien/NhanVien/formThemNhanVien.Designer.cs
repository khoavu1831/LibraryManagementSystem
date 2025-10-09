namespace LibraryManagementSystem.Views.UserControls.QLNhanVien
{
    partial class FormThemNhanVien
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
            label2 = new Label();
            textBoxHVT = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnThem = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxEmail = new TextBox();
            textBoxSDT = new TextBox();
            textBoxDC = new TextBox();
            textBoxNS = new TextBox();
            textBoxMK = new TextBox();
            textBoxTK = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHuy = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 42);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxHVT
            // 
            textBoxHVT.Dock = DockStyle.Fill;
            textBoxHVT.Location = new Point(117, 3);
            textBoxHVT.Multiline = true;
            textBoxHVT.Name = "textBoxHVT";
            textBoxHVT.Size = new Size(257, 36);
            textBoxHVT.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(108, 42);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 126);
            label4.Name = "label4";
            label4.Size = new Size(108, 42);
            label4.TabIndex = 7;
            label4.Text = "Năm sinh:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(108, 42);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 210);
            label6.Name = "label6";
            label6.Size = new Size(108, 42);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 168);
            label7.Name = "label7";
            label7.Size = new Size(108, 42);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 252);
            label8.Name = "label8";
            label8.Size = new Size(108, 42);
            label8.TabIndex = 13;
            label8.Text = "Email:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(179, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 125);
            label1.TabIndex = 0;
            label1.Text = "THÊM NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 6);
            tableLayoutPanel1.Controls.Add(textBoxSDT, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxDC, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxNS, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxMK, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxTK, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxHVT, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Location = new Point(69, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(377, 294);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(117, 255);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(257, 36);
            textBoxEmail.TabIndex = 19;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Location = new Point(117, 213);
            textBoxSDT.Multiline = true;
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(257, 36);
            textBoxSDT.TabIndex = 18;
            // 
            // textBoxDC
            // 
            textBoxDC.Dock = DockStyle.Fill;
            textBoxDC.Location = new Point(117, 171);
            textBoxDC.Multiline = true;
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(257, 36);
            textBoxDC.TabIndex = 17;
            // 
            // textBoxNS
            // 
            textBoxNS.Dock = DockStyle.Fill;
            textBoxNS.Location = new Point(117, 129);
            textBoxNS.Multiline = true;
            textBoxNS.Name = "textBoxNS";
            textBoxNS.Size = new Size(257, 36);
            textBoxNS.TabIndex = 16;
            // 
            // textBoxMK
            // 
            textBoxMK.Dock = DockStyle.Fill;
            textBoxMK.Location = new Point(117, 87);
            textBoxMK.Multiline = true;
            textBoxMK.Name = "textBoxMK";
            textBoxMK.Size = new Size(257, 36);
            textBoxMK.TabIndex = 15;
            // 
            // textBoxTK
            // 
            textBoxTK.Dock = DockStyle.Fill;
            textBoxTK.Location = new Point(117, 45);
            textBoxTK.Multiline = true;
            textBoxTK.Name = "textBoxTK";
            textBoxTK.Size = new Size(257, 36);
            textBoxTK.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 125);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 424);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel2.Location = new Point(72, 344);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(371, 54);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(188, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(180, 46);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 549);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormThemNhanVien";
            Text = "formThemNhanVien";
            Load += formThemNhanVien_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox textBoxHVT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnThem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxEmail;
        private TextBox textBoxSDT;
        private TextBox textBoxDC;
        private TextBox textBoxNS;
        private TextBox textBoxMK;
        private TextBox textBoxTK;
        private Panel panel1;
        private Panel panel2;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel2;
    }
}