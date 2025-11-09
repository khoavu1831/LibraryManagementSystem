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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textmkm = new TextBox();
            textnhaplaimk = new TextBox();
            txtMatKhauCu = new TextBox();
            texttk = new TextBox();
            btnXong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 3, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(710, 52);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(98, 91);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Tài khoản:";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(374, 91);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 22);
            button2.TabIndex = 2;
            button2.Text = "Mật khẩu mới:";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(98, 164);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(123, 22);
            button3.TabIndex = 3;
            button3.Text = "Mật khẩu hiện tại:";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(374, 164);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(151, 22);
            button4.TabIndex = 4;
            button4.Text = "Nhập lại mật khẩu mới:";
            button4.UseVisualStyleBackColor = false;
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
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 338);
            Controls.Add(btnXong);
            Controls.Add(texttk);
            Controls.Add(txtMatKhauCu);
            Controls.Add(textnhaplaimk);
            Controls.Add(textmkm);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMatKhau";
            Text = "FormDoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textmkm;
        private TextBox textnhaplaimk;
        private TextBox txtMatKhauCu;
        private TextBox texttk;
        private Button btnXong;
    }
}