namespace LMS.Views.UserControls.QuanLy
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            textmkm = new TextBox();
            textnhaplaimk = new TextBox();
            txtMatKhauCu = new TextBox();
            btnXong = new Button();
            labelMkcu = new Label();
            labelmkmoi = new Label();
            labelnhaplai = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnHuy = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            chkShowOldPassword = new CheckBox();
            chkShowNewPassword = new CheckBox();
            chkShowConfirmPassword = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // textmkm
            // 
            textmkm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textmkm.Location = new Point(154, 30);
            textmkm.Margin = new Padding(3, 2, 3, 2);
            textmkm.Name = "textmkm";
            textmkm.Size = new Size(176, 23);
            textmkm.TabIndex = 6;
            // 
            // textnhaplaimk
            // 
            textnhaplaimk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textnhaplaimk.Location = new Point(154, 58);
            textnhaplaimk.Margin = new Padding(3, 2, 3, 2);
            textnhaplaimk.Name = "textnhaplaimk";
            textnhaplaimk.Size = new Size(176, 23);
            textnhaplaimk.TabIndex = 7;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhauCu.BackColor = SystemColors.ButtonHighlight;
            txtMatKhauCu.ForeColor = SystemColors.WindowText;
            txtMatKhauCu.Location = new Point(154, 2);
            txtMatKhauCu.Margin = new Padding(3, 2, 3, 2);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(176, 23);
            txtMatKhauCu.TabIndex = 8;
            // 
            // btnXong
            // 
            btnXong.BackColor = Color.White;
            btnXong.Font = new Font("Segoe UI", 9F);
            btnXong.Location = new Point(3, 3);
            btnXong.Name = "btnXong";
            btnXong.Size = new Size(117, 35);
            btnXong.TabIndex = 10;
            btnXong.Text = "Đổi mật khẩu";
            btnXong.UseVisualStyleBackColor = false;
            btnXong.Click += btnXong_Click;
            // 
            // labelMkcu
            // 
            labelMkcu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMkcu.AutoSize = true;
            labelMkcu.Location = new Point(3, 0);
            labelMkcu.Name = "labelMkcu";
            labelMkcu.Size = new Size(145, 28);
            labelMkcu.TabIndex = 12;
            labelMkcu.Text = "Mật khẩu hiện tại:";
            labelMkcu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelmkmoi
            // 
            labelmkmoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelmkmoi.AutoSize = true;
            labelmkmoi.Location = new Point(3, 28);
            labelmkmoi.Name = "labelmkmoi";
            labelmkmoi.Size = new Size(145, 28);
            labelmkmoi.TabIndex = 13;
            labelmkmoi.Text = "Mật khẩu mới:";
            labelmkmoi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelnhaplai
            // 
            labelnhaplai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelnhaplai.AutoSize = true;
            labelnhaplai.Location = new Point(3, 56);
            labelnhaplai.Name = "labelnhaplai";
            labelnhaplai.Size = new Size(145, 30);
            labelnhaplai.TabIndex = 14;
            labelnhaplai.Text = "Nhập lại mật khẩu mới:";
            labelnhaplai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(511, 100);
            label1.TabIndex = 15;
            label1.Text = "ĐỔI MẬT KHẨU CÁ NHÂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel1.Controls.Add(btnXong, 0, 0);
            tableLayoutPanel1.Location = new Point(139, 265);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(246, 41);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Font = new Font("Segoe UI", 9F);
            btnHuy.Location = new Point(126, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(117, 35);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.43081F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.56919F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel2.Controls.Add(labelMkcu, 0, 0);
            tableLayoutPanel2.Controls.Add(txtMatKhauCu, 1, 0);
            tableLayoutPanel2.Controls.Add(labelmkmoi, 0, 1);
            tableLayoutPanel2.Controls.Add(textnhaplaimk, 1, 2);
            tableLayoutPanel2.Controls.Add(labelnhaplai, 0, 2);
            tableLayoutPanel2.Controls.Add(textmkm, 1, 1);
            tableLayoutPanel2.Controls.Add(chkShowOldPassword, 2, 0);
            tableLayoutPanel2.Controls.Add(chkShowNewPassword, 2, 1);
            tableLayoutPanel2.Controls.Add(chkShowConfirmPassword, 2, 2);
            tableLayoutPanel2.Location = new Point(55, 144);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(418, 86);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // chkShowOldPassword
            // 
            chkShowOldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkShowOldPassword.AutoSize = true;
            chkShowOldPassword.Location = new Point(336, 3);
            chkShowOldPassword.Name = "chkShowOldPassword";
            chkShowOldPassword.Size = new Size(79, 22);
            chkShowOldPassword.TabIndex = 15;
            chkShowOldPassword.Text = "Ẩn/ Hiện";
            chkShowOldPassword.UseVisualStyleBackColor = true;
            chkShowOldPassword.CheckedChanged += chkShowOldPassword_CheckedChanged;
            // 
            // chkShowNewPassword
            // 
            chkShowNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkShowNewPassword.AutoSize = true;
            chkShowNewPassword.Location = new Point(336, 31);
            chkShowNewPassword.Name = "chkShowNewPassword";
            chkShowNewPassword.Size = new Size(79, 22);
            chkShowNewPassword.TabIndex = 16;
            chkShowNewPassword.Text = "Ẩn/ Hiện";
            chkShowNewPassword.UseVisualStyleBackColor = true;
            chkShowNewPassword.CheckedChanged += chkShowNewPassword_CheckedChanged;
            // 
            // chkShowConfirmPassword
            // 
            chkShowConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkShowConfirmPassword.AutoSize = true;
            chkShowConfirmPassword.Location = new Point(336, 59);
            chkShowConfirmPassword.Name = "chkShowConfirmPassword";
            chkShowConfirmPassword.Size = new Size(79, 24);
            chkShowConfirmPassword.TabIndex = 17;
            chkShowConfirmPassword.Text = "Ẩn/ Hiện";
            chkShowConfirmPassword.UseVisualStyleBackColor = true;
            chkShowConfirmPassword.CheckedChanged += chkShowConfirmPassword_CheckedChanged;
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 338);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMatKhau";
            Text = "Đổi mật khẩu tài khoản cá nhân";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textmkm;
        private TextBox textnhaplaimk;
        private TextBox txtMatKhauCu;
        private Button btnXong;
        private Label labelMkcu;
        private Label labelmkmoi;
        private Label labelnhaplai;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox chkShowOldPassword;
        private CheckBox chkShowNewPassword;
        private CheckBox chkShowConfirmPassword;
    }
}