namespace LibraryManagementSystem.Views.UserControls.QLNhanVien
{
    partial class UcTaiKhoan
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
            panelCRUD = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panelCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(textBox1);
            panelCRUD.Controls.Add(button2);
            panelCRUD.Controls.Add(button1);
            panelCRUD.Controls.Add(btnXoa);
            panelCRUD.Controls.Add(btnSua);
            panelCRUD.Controls.Add(btnThem);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Margin = new Padding(3, 4, 3, 4);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(885, 131);
            panelCRUD.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(633, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm..";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(520, 50);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.iconCT;
            button1.Location = new Point(303, 20);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(74, 91);
            button1.TabIndex = 3;
            button1.Text = "Chi tiết";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.iconxoa;
            btnXoa.Location = new Point(214, 20);
            btnXoa.Margin = new Padding(0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 91);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.iconsua;
            btnSua.Location = new Point(113, 20);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 91);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.iconthem;
            btnThem.Location = new Point(16, 20);
            btnThem.Margin = new Padding(0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 91);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // UcTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCRUD);
            Name = "UcTaiKhoan";
            Size = new Size(885, 751);
            panelCRUD.ResumeLayout(false);
            panelCRUD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}
