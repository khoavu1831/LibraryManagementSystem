namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    partial class FormSuaNhapsach
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 125);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN PHIẾU NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(67, 547);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 54);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(188, 5);
            button2.Name = "button2";
            button2.Size = new Size(180, 46);
            button2.TabIndex = 1;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 5);
            button1.Name = "button1";
            button1.Size = new Size(179, 46);
            button1.TabIndex = 0;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.6969681F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.3030319F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 0, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel1.Controls.Add(button7, 0, 4);
            tableLayoutPanel1.Controls.Add(button8, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 5);
            tableLayoutPanel1.Location = new Point(64, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.51773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.48227F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.Size = new Size(396, 377);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(171, 61);
            button3.TabIndex = 0;
            button3.Text = "ID Phiếu nhập";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 70);
            button4.Name = "button4";
            button4.Size = new Size(171, 68);
            button4.TabIndex = 1;
            button4.Text = "ID Nhà cung cấp";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 144);
            button5.Name = "button5";
            button5.Size = new Size(171, 57);
            button5.TabIndex = 2;
            button5.Text = "ID Sách";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(3, 207);
            button6.Name = "button6";
            button6.Size = new Size(171, 69);
            button6.TabIndex = 3;
            button6.Text = "Ngày nhập";
            button6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(180, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(180, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(180, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(180, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 7;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(3, 282);
            button7.Name = "button7";
            button7.Size = new Size(171, 40);
            button7.TabIndex = 8;
            button7.Text = "Số lượng";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(3, 328);
            button8.Name = "button8";
            button8.Size = new Size(171, 46);
            button8.TabIndex = 9;
            button8.Text = "Giá tiền";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(180, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(180, 328);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 27);
            textBox5.TabIndex = 11;
            // 
            // FormSuaNhapsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 613);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormSuaNhapsach";
            Text = "FormSuaNhapsach";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button7;
        private Button button8;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}