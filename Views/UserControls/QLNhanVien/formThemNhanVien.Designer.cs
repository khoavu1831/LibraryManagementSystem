namespace LibraryManagementSystem.Views.UserControls.QLNhanVien
{
    partial class formThemNhanVien
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(173, 44);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 0;
            label1.Text = "Thêm nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 124);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 172);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản";
            label3.Click += this.label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 265);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Năm sinh";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 27);
            textBox4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 217);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 354);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 27);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 357);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(200, 306);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(231, 27);
            textBox6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 309);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 400);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(231, 27);
            textBox7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 403);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 13;
            label8.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(110, 485);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 15;
            button1.Text = "Thêm nhân viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(271, 485);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 16;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = true;
            // 
            // formThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 574);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "formThemNhanVien";
            Text = "formThemNhanVien";
            Load += formThemNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}