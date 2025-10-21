namespace LMS.Views.UserControls.QLNhanVien.TaiKhoan
{
    partial class FormChiTietTaiKhoan
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
            textBoxVT = new TextBox();
            textBoxMK = new TextBox();
            label3 = new Label();
            textBoxHVT = new TextBox();
            label2 = new Label();
            label5 = new Label();
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
            label1.Text = "THÔNG TIN TÀI KHOẢN";
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
            panel2.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnQuayLai, 0, 0);
            tableLayoutPanel2.Location = new Point(163, 333);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(173, 54);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Dock = DockStyle.Fill;
            btnQuayLai.Location = new Point(3, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(167, 48);
            btnQuayLai.TabIndex = 19;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(textBoxVT, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxMK, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxHVT, 1, 0);
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
            // textBoxVT
            // 
            textBoxVT.Dock = DockStyle.Fill;
            textBoxVT.Location = new Point(117, 87);
            textBoxVT.Multiline = true;
            textBoxVT.Name = "textBoxVT";
            textBoxVT.Size = new Size(257, 36);
            textBoxVT.TabIndex = 15;
            // 
            // textBoxMK
            // 
            textBoxMK.Dock = DockStyle.Fill;
            textBoxMK.Location = new Point(117, 45);
            textBoxMK.Multiline = true;
            textBoxMK.Name = "textBoxMK";
            textBoxMK.Size = new Size(257, 36);
            textBoxMK.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(108, 42);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 42);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(108, 42);
            label5.TabIndex = 5;
            label5.Text = "Vai trò";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormChiTietTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 549);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "FormChiTietTaiKhoan";
            Text = "formChiTietTaiKhoan";
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
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxVT;
        private TextBox textBoxMK;
        private Label label3;
        private TextBox textBoxHVT;
        private Label label2;
        private Label label5;
        private Button btnQuayLai;
    }
}