namespace LibraryManagementSystem.Views.UserControls.QLPhat.TraPhat
{
    partial class FormChiTietTraPhat
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
            label6 = new Label();
            label7 = new Label();
            btnThem = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            textBoxSDT = new TextBox();
            textBoxDC = new TextBox();
            textBoxTK = new TextBox();
            myComboBoxLoaiPhat = new LibraryManagementSystem.Resources.CustomComponents.MyComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHuy = new Button();
            btnQuayLai = new Button();
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
            label2.Text = "Họ và tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxHVT
            // 
            textBoxHVT.Dock = DockStyle.Fill;
            textBoxHVT.Location = new Point(104, 2);
            textBoxHVT.Margin = new Padding(3, 2, 3, 2);
            textBoxHVT.Multiline = true;
            textBoxHVT.Name = "textBoxHVT";
            textBoxHVT.ReadOnly = true;
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
            label3.Text = "Mã phiếu mượn:";
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
            label4.Text = "Loại phạt:";
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
            label5.Text = "Ngày lập:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(95, 50);
            label6.TabIndex = 11;
            label6.Text = "Tiền phạt:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 200);
            label7.Name = "label7";
            label7.Size = new Size(95, 50);
            label7.TabIndex = 9;
            label7.Text = "Số ngày trễ:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
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
            label1.Text = "CHI TIẾT PHIẾU PHẠT ĐÃ TRẢ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(textBoxSDT, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxDC, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxTK, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxHVT, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(myComboBoxLoaiPhat, 1, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 6);
            tableLayoutPanel1.Location = new Point(60, 18);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(334, 352);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 300);
            label8.Name = "label8";
            label8.Size = new Size(95, 52);
            label8.TabIndex = 20;
            label8.Text = "Ngày trả phạt:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Location = new Point(104, 252);
            textBoxSDT.Margin = new Padding(3, 2, 3, 2);
            textBoxSDT.Multiline = true;
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.ReadOnly = true;
            textBoxSDT.Size = new Size(227, 46);
            textBoxSDT.TabIndex = 18;
            // 
            // textBoxDC
            // 
            textBoxDC.Dock = DockStyle.Fill;
            textBoxDC.Location = new Point(104, 202);
            textBoxDC.Margin = new Padding(3, 2, 3, 2);
            textBoxDC.Multiline = true;
            textBoxDC.Name = "textBoxDC";
            textBoxDC.ReadOnly = true;
            textBoxDC.Size = new Size(227, 46);
            textBoxDC.TabIndex = 17;
            // 
            // textBoxTK
            // 
            textBoxTK.Dock = DockStyle.Fill;
            textBoxTK.Location = new Point(104, 52);
            textBoxTK.Margin = new Padding(3, 2, 3, 2);
            textBoxTK.Multiline = true;
            textBoxTK.Name = "textBoxTK";
            textBoxTK.ReadOnly = true;
            textBoxTK.Size = new Size(227, 46);
            textBoxTK.TabIndex = 14;
            // 
            // myComboBoxLoaiPhat
            // 
            myComboBoxLoaiPhat.Dock = DockStyle.Fill;
            myComboBoxLoaiPhat.DrawMode = DrawMode.OwnerDrawFixed;
            myComboBoxLoaiPhat.FormattingEnabled = true;
            myComboBoxLoaiPhat.ItemHeight = 38;
            myComboBoxLoaiPhat.Location = new Point(104, 153);
            myComboBoxLoaiPhat.Name = "myComboBoxLoaiPhat";
            myComboBoxLoaiPhat.Size = new Size(227, 44);
            myComboBoxLoaiPhat.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(117, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(117, 314);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 22;
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
            panel2.Controls.Add(btnQuayLai);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 489);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel2.Location = new Point(63, 291);
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
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(143, 411);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(162, 34);
            btnQuayLai.TabIndex = 20;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 583);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "formThemPhieuPhat";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxSDT;
        private TextBox textBoxDC;
        private TextBox textBoxTK;
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
        private Label label6;
        private Label label7;
        private Button btnThem;
        private Label label1;
        private Resources.CustomComponents.MyComboBox myComboBoxLoaiPhat;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnQuayLai;
    }
}