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
            label1 = new Label();
            textmkm = new TextBox();
            textnhaplaimk = new TextBox();
            txtMatKhauCu = new TextBox();
            texttk = new TextBox();
            btnXong = new Button();
            labelTaiKhoan = new Label();
            labelMkcu = new Label();
            labelmkmoi = new Label();
            labelnhaplai = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(710, 52);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textmkm
            // 
            textmkm.Location = new Point(374, 117);
            textmkm.Margin = new Padding(3, 2, 3, 2);
            textmkm.Name = "textmkm";
            textmkm.Size = new Size(246, 23);
            textmkm.TabIndex = 6;
            // 
            // textnhaplaimk
            // 
            textnhaplaimk.Location = new Point(374, 190);
            textnhaplaimk.Margin = new Padding(3, 2, 3, 2);
            textnhaplaimk.Name = "textnhaplaimk";
            textnhaplaimk.Size = new Size(246, 23);
            textnhaplaimk.TabIndex = 7;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BackColor = SystemColors.ControlDark;
            txtMatKhauCu.Location = new Point(98, 190);
            txtMatKhauCu.Margin = new Padding(3, 2, 3, 2);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(222, 23);
            txtMatKhauCu.TabIndex = 8;
            // 
            // texttk
            // 
            texttk.BackColor = SystemColors.ControlDark;
            texttk.Location = new Point(98, 117);
            texttk.Margin = new Padding(3, 2, 3, 2);
            texttk.Name = "texttk";
            texttk.Size = new Size(222, 23);
            texttk.TabIndex = 9;
            // 
            // btnXong
            // 
            btnXong.BackColor = Color.DarkSeaGreen;
            btnXong.Font = new Font("Segoe UI", 16F);
            btnXong.Location = new Point(293, 265);
            btnXong.Name = "btnXong";
            btnXong.Size = new Size(99, 46);
            btnXong.TabIndex = 10;
            btnXong.Text = "XONG";
            btnXong.UseVisualStyleBackColor = false;
            btnXong.Click += btnXong_Click;
            // 
            // labelTaiKhoan
            // 
            labelTaiKhoan.AutoSize = true;
            labelTaiKhoan.Location = new Point(98, 100);
            labelTaiKhoan.Name = "labelTaiKhoan";
            labelTaiKhoan.Size = new Size(61, 15);
            labelTaiKhoan.TabIndex = 11;
            labelTaiKhoan.Text = "Tài khoản:";
            // 
            // labelMkcu
            // 
            labelMkcu.AutoSize = true;
            labelMkcu.Location = new Point(98, 173);
            labelMkcu.Name = "labelMkcu";
            labelMkcu.Size = new Size(102, 15);
            labelMkcu.TabIndex = 12;
            labelMkcu.Text = "Mật khẩu hiện tại:";
            // 
            // labelmkmoi
            // 
            labelmkmoi.AutoSize = true;
            labelmkmoi.Location = new Point(374, 100);
            labelmkmoi.Name = "labelmkmoi";
            labelmkmoi.Size = new Size(84, 15);
            labelmkmoi.TabIndex = 13;
            labelmkmoi.Text = "Mật khẩu mới:";
            // 
            // labelnhaplai
            // 
            labelnhaplai.AutoSize = true;
            labelnhaplai.Location = new Point(374, 173);
            labelnhaplai.Name = "labelnhaplai";
            labelnhaplai.Size = new Size(131, 15);
            labelnhaplai.TabIndex = 14;
            labelnhaplai.Text = "Nhập lại mật khẩu mới:";
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 338);
            Controls.Add(labelnhaplai);
            Controls.Add(labelmkmoi);
            Controls.Add(labelMkcu);
            Controls.Add(labelTaiKhoan);
            Controls.Add(btnXong);
            Controls.Add(texttk);
            Controls.Add(txtMatKhauCu);
            Controls.Add(textnhaplaimk);
            Controls.Add(textmkm);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMatKhau";
            Text = "FormDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textmkm;
        private TextBox textnhaplaimk;
        private TextBox txtMatKhauCu;
        private TextBox texttk;
        private Button btnXong;
        private Label labelTaiKhoan;
        private Label labelMkcu;
        private Label labelmkmoi;
        private Label labelnhaplai;
    }
}