namespace LibraryManagementSystem.Views.UserControls.QLNhapSach.Nhap
{
    partial class FormCTNhapsach
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel2 = new Panel();
            button7 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.Text = "CHI TIẾT PHIẾU NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 721);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button6, 0, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 0);
            tableLayoutPanel1.Location = new Point(71, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(400, 377);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 45);
            button1.TabIndex = 0;
            button1.Text = "ID Phiếu nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 54);
            button2.Name = "button2";
            button2.Size = new Size(194, 45);
            button2.TabIndex = 1;
            button2.Text = "ID Nhà cung cấp";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 105);
            button3.Name = "button3";
            button3.Size = new Size(194, 56);
            button3.TabIndex = 2;
            button3.Text = "ID Sách";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 167);
            button4.Name = "button4";
            button4.Size = new Size(194, 67);
            button4.TabIndex = 3;
            button4.Text = "Ngày nhập";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 240);
            button5.Name = "button5";
            button5.Size = new Size(194, 69);
            button5.TabIndex = 4;
            button5.Text = "Số lượng";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(3, 315);
            button6.Name = "button6";
            button6.Size = new Size(194, 59);
            button6.TabIndex = 5;
            button6.Text = "Giá tiền";
            button6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(203, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(203, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(203, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(203, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(203, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(194, 27);
            textBox5.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Location = new Point(80, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 54);
            panel2.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(189, 8);
            button7.Name = "button7";
            button7.Size = new Size(179, 46);
            button7.TabIndex = 0;
            button7.Text = "Quay lại";
            button7.UseVisualStyleBackColor = true;
            // 
            // FormCTNhapsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 629);
            Controls.Add(panel1);
            Name = "FormCTNhapsach";
            Text = "FormCTNhapsach";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}