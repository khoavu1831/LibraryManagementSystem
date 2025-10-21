namespace LMS.Views.UserControls.QLPhat
{
    partial class FormThemMucPhat
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
            textBoxTenMucPhat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxMoTa = new TextBox();
            textBoxSoTien = new TextBox();
            comboBoxLoaiPhat = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHuy = new Button();
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
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên mức phạt:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTenMucPhat
            // 
            textBoxTenMucPhat.Dock = DockStyle.Fill;
            textBoxTenMucPhat.Location = new Point(104, 2);
            textBoxTenMucPhat.Margin = new Padding(3, 2, 3, 2);
            textBoxTenMucPhat.Multiline = true;
            textBoxTenMucPhat.Name = "textBoxTenMucPhat";
            textBoxTenMucPhat.Size = new Size(227, 24);
            textBoxTenMucPhat.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 28);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 3;
            label3.Text = "Loại phạt:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 84);
            label4.Name = "label4";
            label4.Size = new Size(95, 60);
            label4.TabIndex = 7;
            label4.Text = "Mô tả:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 56);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
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
            btnThem.Size = new Size(161, 34);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
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
            tableLayoutPanel1.Controls.Add(textBoxMoTa, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxSoTien, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxTenMucPhat, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxLoaiPhat, 1, 1);
            tableLayoutPanel1.Location = new Point(60, 18);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(334, 144);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Dock = DockStyle.Fill;
            textBoxMoTa.Location = new Point(104, 86);
            textBoxMoTa.Margin = new Padding(3, 2, 3, 2);
            textBoxMoTa.Multiline = true;
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.ScrollBars = ScrollBars.Vertical;
            textBoxMoTa.Size = new Size(227, 56);
            textBoxMoTa.TabIndex = 16;
            // 
            // textBoxSoTien
            // 
            textBoxSoTien.Dock = DockStyle.Fill;
            textBoxSoTien.Location = new Point(104, 58);
            textBoxSoTien.Margin = new Padding(3, 2, 3, 2);
            textBoxSoTien.Multiline = true;
            textBoxSoTien.Name = "textBoxSoTien";
            textBoxSoTien.Size = new Size(227, 24);
            textBoxSoTien.TabIndex = 15;
            // 
            // comboBoxLoaiPhat
            // 
            comboBoxLoaiPhat.Dock = DockStyle.Fill;
            comboBoxLoaiPhat.FormattingEnabled = true;
            comboBoxLoaiPhat.Location = new Point(104, 31);
            comboBoxLoaiPhat.Name = "comboBoxLoaiPhat";
            comboBoxLoaiPhat.Size = new Size(227, 23);
            comboBoxLoaiPhat.TabIndex = 3;
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
            panel2.Size = new Size(456, 236);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnHuy, 1, 0);
            tableLayoutPanel2.Location = new Point(60, 185);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(334, 40);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btnHuy
            // 
            btnHuy.Dock = DockStyle.Top;
            btnHuy.Location = new Point(170, 2);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(161, 34);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemMucPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 330);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThemMucPhat";
            Text = "formThemPhieuPhat";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxMoTa;
        private TextBox textBoxSoTien;
        private Panel panel1;
        private Panel panel2;
        private Button btnHuy;
        private TableLayoutPanel tableLayoutPanel2;
        #endregion
        private Label label2;
        private TextBox textBoxTenMucPhat;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Label label1;
        private ComboBox comboBoxLoaiPhat;
    }
}