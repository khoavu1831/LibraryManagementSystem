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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxNS = new TextBox();
            textBoxMK = new TextBox();
            myComboBoxLoaiPhat = new LibraryManagementSystem.Resources.CustomComponents.MyComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnQuayLai = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(myComboBoxLoaiPhat, 1, 1);
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
            textBoxNS.ReadOnly = true;
            textBoxNS.ScrollBars = ScrollBars.Vertical;
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
            textBoxMK.ReadOnly = true;
            textBoxMK.Size = new Size(227, 46);
            textBoxMK.TabIndex = 15;
            // 
            // myComboBoxLoaiPhat
            // 
            myComboBoxLoaiPhat.Dock = DockStyle.Fill;
            myComboBoxLoaiPhat.DrawMode = DrawMode.OwnerDrawFixed;
            myComboBoxLoaiPhat.Enabled = false;
            myComboBoxLoaiPhat.FormattingEnabled = true;
            myComboBoxLoaiPhat.ItemHeight = 38;
            myComboBoxLoaiPhat.Location = new Point(104, 53);
            myComboBoxLoaiPhat.Name = "myComboBoxLoaiPhat";
            myComboBoxLoaiPhat.Size = new Size(227, 44);
            myComboBoxLoaiPhat.TabIndex = 17;
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 302);
            panel2.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(151, 244);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(162, 34);
            btnQuayLai.TabIndex = 20;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
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
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxNS;
        private TextBox textBoxMK;
        private Panel panel1;
        private Panel panel2;
        #endregion
        private Label label2;
        private TextBox textBoxHVT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Resources.CustomComponents.MyComboBox myComboBoxLoaiPhat;
        private Button btnQuayLai;
    }
}