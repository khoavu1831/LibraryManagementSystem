namespace LibraryManagementSystem.Views.UserControls.QLNhapSach.Nhap
{
    partial class UcNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 816);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(4, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 646);
            panel3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(635, 25);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Tìm kiếm";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(530, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Làm mới";
            textBox1.Size = new Size(99, 27);
            textBox1.TabIndex = 5;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.iconExc;
            button6.Location = new Point(352, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(88, 96);
            button6.TabIndex = 4;
            button6.Text = "Xuất excel";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.iconCT;
            button5.Location = new Point(264, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(88, 96);
            button5.TabIndex = 3;
            button5.Text = "Chi tiết";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.iconxoa;
            button4.Location = new Point(176, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(88, 96);
            button4.TabIndex = 2;
            button4.Text = "Xóa";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.iconsua;
            button3.Location = new Point(88, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(88, 96);
            button3.TabIndex = 1;
            button3.Text = "Sửa";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.iconthem;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(88, 96);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UcNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Name = "UcNhap";
            Size = new Size(894, 818);
            Load += UcNhap_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Panel panel3;
    }
}
