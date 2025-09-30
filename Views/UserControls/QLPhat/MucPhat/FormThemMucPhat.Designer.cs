namespace LibraryManagementSystem.Views.UserControls.QLPhat.MucPhat
{
    partial class Form1
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
            btnThem = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxNS = new TextBox();
            textBoxMK = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHuy = new Button();
            myComboBox1 = new LibraryManagementSystem.Resources.CustomComboBox.MyComboBox();
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
            label2.Size = new Size(95, 50);
            label2.TabIndex = 1;
            label2.Text = "Tên mức phạt:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxHVT
            // 
            textBoxHVT.Dock = DockStyle.Fill;
            textBoxHVT.Location = new Point(104, 2);
            textBoxHVT.Margin = new Padding(3, 2, 3, 2);
            textBoxHVT.Multiline = true;
            textBoxHVT.Name = "textBoxHVT";
            textBoxHVT.Size = new Size(227, 46);
            textBoxHVT.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(95, 50);
            label3.TabIndex = 3;
            label3.Text = "Loại phạt:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(95, 50);
            label4.TabIndex = 7;
            label4.Text = "Mô tả:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(95, 50);
            label5.TabIndex = 5;
            label5.Text = "Số tiền:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Top;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(156, 34);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(456, 94);
            label1.TabIndex = 0;
            label1.Text = "THÊM MỨC PHẠT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(textBoxNS, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxMK, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxHVT, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(myComboBox1, 1, 1);
            tableLayoutPanel1.Location = new Point(60, 18);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(334, 200);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // textBoxNS
            // 
            textBoxNS.Dock = DockStyle.Fill;
            textBoxNS.Location = new Point(104, 152);
            textBoxNS.Margin = new Padding(3, 2, 3, 2);
            textBoxNS.Multiline = true;
            textBoxNS.Name = "textBoxNS";
            textBoxNS.Size = new Size(227, 46);
            textBoxNS.TabIndex = 16;
            // 
            // textBoxMK
            // 
            textBoxMK.Dock = DockStyle.Fill;
            textBoxMK.Location = new Point(104, 102);
            textBoxMK.Margin = new Padding(3, 2, 3, 2);
            textBoxMK.Multiline = true;
            textBoxMK.Name = "textBoxMK";
            textBoxMK.Size = new Size(227, 46);
            textBoxMK.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 94);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 302);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel2.Location = new Point(63, 238);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(325, 40);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(165, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(157, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // myComboBox1
            // 
            myComboBox1.Dock = DockStyle.Fill;
            myComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            myComboBox1.FormattingEnabled = true;
            myComboBox1.ItemHeight = 38;
            myComboBox1.Location = new Point(104, 53);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.Size = new Size(227, 44);
            myComboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 396);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "formThemPhieuPhat";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxNS;
        private TextBox textBoxMK;
        private Panel panel1;
        private Panel panel2;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel2;
        #endregion
        private Label label2;
        private TextBox textBoxHVT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Label label1;
        private Resources.CustomComboBox.MyComboBox myComboBox1;
    }
}