namespace LibraryManagementSystem.Views.UserControls.QuanLy
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
            label2 = new Label();
            textmkm = new TextBox();
            textnhaplaimk = new TextBox();
            txtMatKhauCu = new TextBox();
            texttk = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 4, 3, 4);
            label1.Name = "label1";
            label1.Size = new Size(811, 70);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(112, 121);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Tài khoản:";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(428, 121);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 2;
            button2.Text = "Mật khẩu mới:";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(112, 219);
            button3.Name = "button3";
            button3.Size = new Size(141, 29);
            button3.TabIndex = 3;
            button3.Text = "Mật khẩu hiện tại:";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(428, 219);
            button4.Name = "button4";
            button4.Size = new Size(173, 29);
            button4.TabIndex = 4;
            button4.Text = "Nhập lại mật khẩu mới:";
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.SpringGreen;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 341);
            label2.Name = "label2";
            label2.Size = new Size(106, 50);
            label2.TabIndex = 5;
            label2.Text = "XONG";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // textmkm
            // 
            textmkm.Location = new Point(428, 156);
            textmkm.Name = "textmkm";
            textmkm.Size = new Size(280, 27);
            textmkm.TabIndex = 6;
            // 
            // textnhaplaimk
            // 
            textnhaplaimk.Location = new Point(428, 254);
            textnhaplaimk.Name = "textnhaplaimk";
            textnhaplaimk.Size = new Size(280, 27);
            textnhaplaimk.TabIndex = 7;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BackColor = SystemColors.ControlDark;
            txtMatKhauCu.Location = new Point(112, 254);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(253, 27);
            txtMatKhauCu.TabIndex = 8;
            // 
            // texttk
            // 
            texttk.BackColor = SystemColors.ControlDark;
            texttk.Location = new Point(112, 156);
            texttk.Name = "texttk";
            texttk.Size = new Size(253, 27);
            texttk.TabIndex = 9;
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(texttk);
            Controls.Add(txtMatKhauCu);
            Controls.Add(textnhaplaimk);
            Controls.Add(textmkm);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
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
        private Label label2;
        private TextBox textmkm;
        private TextBox textnhaplaimk;
        private TextBox txtMatKhauCu;
        private TextBox texttk;
    }
}