namespace LibraryManagementSystem.Forms
{
    partial class NXBFormTest
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
            tenTxtBox = new TextBox();
            diachiTxtBox = new TextBox();
            sdtTxtBox = new TextBox();
            idTxtBox = new TextBox();
            idTxt = new Label();
            tenTxt = new Label();
            diaChiTxt = new Label();
            sdtTxt = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ThemBtn = new Button();
            SuaBtn = new Button();
            XoaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tenTxtBox
            // 
            tenTxtBox.Location = new Point(93, 28);
            tenTxtBox.Name = "tenTxtBox";
            tenTxtBox.Size = new Size(346, 23);
            tenTxtBox.TabIndex = 0;
            // 
            // diachiTxtBox
            // 
            diachiTxtBox.Location = new Point(93, 53);
            diachiTxtBox.Name = "diachiTxtBox";
            diachiTxtBox.Size = new Size(346, 23);
            diachiTxtBox.TabIndex = 1;
            // 
            // sdtTxtBox
            // 
            sdtTxtBox.Location = new Point(93, 79);
            sdtTxtBox.Name = "sdtTxtBox";
            sdtTxtBox.Size = new Size(346, 23);
            sdtTxtBox.TabIndex = 2;
            // 
            // idTxtBox
            // 
            idTxtBox.Enabled = false;
            idTxtBox.Location = new Point(93, 3);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(346, 23);
            idTxtBox.TabIndex = 3;
            idTxtBox.TextChanged += idTxtBox_TextChanged;
            // 
            // idTxt
            // 
            idTxt.AutoSize = true;
            idTxt.Location = new Point(3, 0);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(18, 15);
            idTxt.TabIndex = 4;
            idTxt.Text = "ID";
            // 
            // tenTxt
            // 
            tenTxt.AutoSize = true;
            tenTxt.Location = new Point(3, 25);
            tenTxt.Name = "tenTxt";
            tenTxt.Size = new Size(51, 15);
            tenTxt.TabIndex = 5;
            tenTxt.Text = "Ten NXB";
            // 
            // diaChiTxt
            // 
            diaChiTxt.AutoSize = true;
            diaChiTxt.Location = new Point(3, 50);
            diaChiTxt.Name = "diaChiTxt";
            diaChiTxt.Size = new Size(45, 15);
            diaChiTxt.TabIndex = 6;
            diaChiTxt.Text = "Dia Chi";
            // 
            // sdtTxt
            // 
            sdtTxt.AutoSize = true;
            sdtTxt.Location = new Point(3, 76);
            sdtTxt.Name = "sdtTxt";
            sdtTxt.Size = new Size(26, 15);
            sdtTxt.TabIndex = 7;
            sdtTxt.Text = "SDT";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 275);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3619919F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.63801F));
            tableLayoutPanel1.Controls.Add(sdtTxtBox, 1, 3);
            tableLayoutPanel1.Controls.Add(diachiTxtBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sdtTxt, 0, 3);
            tableLayoutPanel1.Controls.Add(idTxtBox, 1, 0);
            tableLayoutPanel1.Controls.Add(idTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(tenTxtBox, 1, 1);
            tableLayoutPanel1.Controls.Add(tenTxt, 0, 1);
            tableLayoutPanel1.Controls.Add(diaChiTxt, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(442, 102);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // ThemBtn
            // 
            ThemBtn.Location = new Point(448, 12);
            ThemBtn.Name = "ThemBtn";
            ThemBtn.Size = new Size(75, 23);
            ThemBtn.TabIndex = 10;
            ThemBtn.Text = "Thêm";
            ThemBtn.UseVisualStyleBackColor = true;
            ThemBtn.Click += ThemBtn_Click;
            // 
            // SuaBtn
            // 
            SuaBtn.Location = new Point(448, 41);
            SuaBtn.Name = "SuaBtn";
            SuaBtn.Size = new Size(75, 23);
            SuaBtn.TabIndex = 11;
            SuaBtn.Text = "Sửa";
            SuaBtn.UseVisualStyleBackColor = true;
            SuaBtn.Click += SuaBtn_Click;
            // 
            // XoaBtn
            // 
            XoaBtn.Location = new Point(448, 70);
            XoaBtn.Name = "XoaBtn";
            XoaBtn.Size = new Size(75, 23);
            XoaBtn.TabIndex = 12;
            XoaBtn.Text = "Xóa";
            XoaBtn.UseVisualStyleBackColor = true;
            XoaBtn.Click += XoaBtn_Click;
            // 
            // NXBFormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 407);
            Controls.Add(XoaBtn);
            Controls.Add(SuaBtn);
            Controls.Add(ThemBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "NXBFormTest";
            Text = "NXBtest";
            Load += NXBFormTest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tenTxtBox;
        private TextBox diachiTxtBox;
        private TextBox sdtTxtBox;
        private TextBox idTxtBox;
        private Label idTxt;
        private Label tenTxt;
        private Label diaChiTxt;
        private Label sdtTxt;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ThemBtn;
        private Button SuaBtn;
        private Button XoaBtn;
    }
}