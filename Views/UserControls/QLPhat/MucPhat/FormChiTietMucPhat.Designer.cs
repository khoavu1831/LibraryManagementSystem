namespace LMS.Views.UserControls.QLPhat
{
    partial class FormChiTietMucPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietMucPhat));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            textBoxMoTa = new TextBox();
            textBoxSoTien = new TextBox();
            comboBoxLoaiPhat = new ComboBox();
            textBoxTenMucPhat = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxIDMucPhat = new TextBox();
            btnQuayLai = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            label1.Text = "CHI TIẾT MỨC PHẠT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            panel2.Controls.Add(btnQuayLai);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 269);
            panel2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2521F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.7479F));
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMoTa, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxSoTien, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxLoaiPhat, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxTenMucPhat, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxIDMucPhat, 1, 0);
            tableLayoutPanel1.Location = new Point(61, 13);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(334, 173);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 18;
            label6.Text = "Mã mức phạt:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMoTa
            // 
            textBoxMoTa.Dock = DockStyle.Fill;
            textBoxMoTa.Location = new Point(104, 114);
            textBoxMoTa.Margin = new Padding(3, 2, 3, 2);
            textBoxMoTa.Multiline = true;
            textBoxMoTa.Name = "textBoxMoTa";
            textBoxMoTa.ReadOnly = true;
            textBoxMoTa.ScrollBars = ScrollBars.Vertical;
            textBoxMoTa.Size = new Size(227, 57);
            textBoxMoTa.TabIndex = 16;
            // 
            // textBoxSoTien
            // 
            textBoxSoTien.Dock = DockStyle.Fill;
            textBoxSoTien.Location = new Point(104, 86);
            textBoxSoTien.Margin = new Padding(3, 2, 3, 2);
            textBoxSoTien.Multiline = true;
            textBoxSoTien.Name = "textBoxSoTien";
            textBoxSoTien.ReadOnly = true;
            textBoxSoTien.Size = new Size(227, 24);
            textBoxSoTien.TabIndex = 15;
            // 
            // comboBoxLoaiPhat
            // 
            comboBoxLoaiPhat.Dock = DockStyle.Fill;
            comboBoxLoaiPhat.Enabled = false;
            comboBoxLoaiPhat.FormattingEnabled = true;
            comboBoxLoaiPhat.Location = new Point(104, 59);
            comboBoxLoaiPhat.Name = "comboBoxLoaiPhat";
            comboBoxLoaiPhat.Size = new Size(227, 23);
            comboBoxLoaiPhat.TabIndex = 17;
            // 
            // textBoxTenMucPhat
            // 
            textBoxTenMucPhat.Dock = DockStyle.Fill;
            textBoxTenMucPhat.Location = new Point(104, 30);
            textBoxTenMucPhat.Margin = new Padding(3, 2, 3, 2);
            textBoxTenMucPhat.Multiline = true;
            textBoxTenMucPhat.Name = "textBoxTenMucPhat";
            textBoxTenMucPhat.ReadOnly = true;
            textBoxTenMucPhat.Size = new Size(227, 24);
            textBoxTenMucPhat.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(95, 61);
            label4.TabIndex = 7;
            label4.Text = "Mô tả:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 5;
            label5.Text = "Số tiền:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 3;
            label3.Text = "Loại phạt:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên mức phạt:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxIDMucPhat
            // 
            textBoxIDMucPhat.Dock = DockStyle.Fill;
            textBoxIDMucPhat.Location = new Point(104, 3);
            textBoxIDMucPhat.Name = "textBoxIDMucPhat";
            textBoxIDMucPhat.ReadOnly = true;
            textBoxIDMucPhat.Size = new Size(227, 23);
            textBoxIDMucPhat.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(153, 224);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(162, 34);
            btnQuayLai.TabIndex = 20;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormChiTietMucPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 363);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChiTietMucPhat";
            Text = "Chi Tiết Mức Phạt";
            Load += FormChiTietMucPhat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }
        private Panel panel1;
        private Panel panel2;

        #endregion
        private Label label1;
        private Button btnQuayLai;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxMoTa;
        private TextBox textBoxSoTien;
        private Label label3;
        private Label label4;
        private TextBox textBoxTenMucPhat;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxLoaiPhat;
        private Label label6;
        private TextBox textBoxIDMucPhat;
    }
}