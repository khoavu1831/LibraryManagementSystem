namespace LibraryManagementSystem.Views.UserControls.QLNhapSach.NCC
{
    partial class UcNCC
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(4, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 99);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.iconthem;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(88, 96);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.iconsua;
            button2.Location = new Point(88, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(88, 96);
            button2.TabIndex = 2;
            button2.Text = "Sửa";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.iconxoa;
            button3.Location = new Point(176, 0);
            button3.Name = "button3";
            button3.Size = new Size(88, 96);
            button3.TabIndex = 3;
            button3.Text = "Xóa";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.iconCT;
            button4.Location = new Point(264, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(88, 96);
            button4.TabIndex = 4;
            button4.Text = "Chi tiết";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.iconExc;
            button5.Location = new Point(352, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(88, 96);
            button5.TabIndex = 5;
            button5.Text = "Xuất excel";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Location = new Point(523, 28);
            button6.Name = "button6";
            button6.Size = new Size(99, 30);
            button6.TabIndex = 6;
            button6.Text = "Làm mới";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(0, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 692);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(3, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 524);
            panel3.TabIndex = 1;
            // 
            // UcNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Name = "UcNCC";
            Size = new Size(906, 695);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private Panel panel1;
        private Panel panel4;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
    }
}
