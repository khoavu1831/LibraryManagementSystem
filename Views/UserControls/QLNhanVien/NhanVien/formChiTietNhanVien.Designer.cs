namespace LMS.Views.UserControls.QLNhanVien.NhanVien
{
    partial class FormChiTietNhanVien
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
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnQuayLai = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxEmail = new TextBox();
            textBoxSDT = new TextBox();
            textBoxDC = new TextBox();
            textBoxNS = new TextBox();
            label4 = new Label();
            textBoxHVT = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 125);
            label1.TabIndex = 2;
            label1.Text = "THÔNG TIN NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 424);
            panel2.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnQuayLai, 1, 0);
            tableLayoutPanel2.Location = new Point(158, 343);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(192, 54);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Dock = DockStyle.Top;
            btnQuayLai.Location = new Point(3, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(186, 46);
            btnQuayLai.TabIndex = 18;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnHuy_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxSDT, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxDC, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxNS, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxHVT, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(69, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999943F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999943F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(377, 294);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(117, 235);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(257, 56);
            textBoxEmail.TabIndex = 19;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Location = new Point(117, 177);
            textBoxSDT.Multiline = true;
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(257, 52);
            textBoxSDT.TabIndex = 18;
            // 
            // textBoxDC
            // 
            textBoxDC.Dock = DockStyle.Fill;
            textBoxDC.Location = new Point(117, 119);
            textBoxDC.Multiline = true;
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(257, 52);
            textBoxDC.TabIndex = 17;
            // 
            // textBoxNS
            // 
            textBoxNS.Dock = DockStyle.Fill;
            textBoxNS.Location = new Point(117, 61);
            textBoxNS.Multiline = true;
            textBoxNS.Name = "textBoxNS";
            textBoxNS.Size = new Size(257, 52);
            textBoxNS.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(108, 58);
            label4.TabIndex = 7;
            label4.Text = "Năm sinh:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxHVT
            // 
            textBoxHVT.Dock = DockStyle.Fill;
            textBoxHVT.Location = new Point(117, 3);
            textBoxHVT.Multiline = true;
            textBoxHVT.Name = "textBoxHVT";
            textBoxHVT.Size = new Size(257, 52);
            textBoxHVT.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 232);
            label8.Name = "label8";
            label8.Size = new Size(108, 62);
            label8.TabIndex = 13;
            label8.Text = "Email:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 116);
            label7.Name = "label7";
            label7.Size = new Size(108, 58);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 174);
            label6.Name = "label6";
            label6.Size = new Size(108, 58);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 58);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormChiTietNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 549);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "FormChiTietNhanVien";
            Text = "formChiTietNhanVien";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnQuayLai;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxEmail;
        private TextBox textBoxSDT;
        private TextBox textBoxDC;
        private TextBox textBoxNS;
        private Label label4;
        private TextBox textBoxHVT;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
    }
}