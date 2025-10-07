namespace LibraryManagementSystem.Views.UserControls.QLSach
{
    partial class UcQLSach
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
            panelNavMenu = new Panel();
            btnTheLoai = new Button();
            btnNXB = new Button();
            btnTacGia = new Button();
            btnBanSaoSach = new Button();
            btnSach = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnTheLoai);
            panelNavMenu.Controls.Add(btnNXB);
            panelNavMenu.Controls.Add(btnTacGia);
            panelNavMenu.Controls.Add(btnBanSaoSach);
            panelNavMenu.Controls.Add(btnSach);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 0;
            // 
            // btnTheLoai
            // 
            btnTheLoai.BackColor = Color.White;
            btnTheLoai.Dock = DockStyle.Left;
            btnTheLoai.FlatStyle = FlatStyle.Flat;
            btnTheLoai.Location = new Point(444, 0);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(111, 67);
            btnTheLoai.TabIndex = 4;
            btnTheLoai.Text = "Thể Loại";
            btnTheLoai.UseVisualStyleBackColor = false;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // btnNXB
            // 
            btnNXB.BackColor = Color.White;
            btnNXB.Dock = DockStyle.Left;
            btnNXB.FlatStyle = FlatStyle.Flat;
            btnNXB.Location = new Point(333, 0);
            btnNXB.Name = "btnNXB";
            btnNXB.Size = new Size(111, 67);
            btnNXB.TabIndex = 3;
            btnNXB.Text = "NXB";
            btnNXB.UseVisualStyleBackColor = false;
            btnNXB.Click += btnNXB_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.BackColor = Color.White;
            btnTacGia.Dock = DockStyle.Left;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Location = new Point(222, 0);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(111, 67);
            btnTacGia.TabIndex = 2;
            btnTacGia.Text = "Tác Giả";
            btnTacGia.UseVisualStyleBackColor = false;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnBanSaoSach
            // 
            btnBanSaoSach.BackColor = Color.White;
            btnBanSaoSach.Dock = DockStyle.Left;
            btnBanSaoSach.FlatStyle = FlatStyle.Flat;
            btnBanSaoSach.Location = new Point(111, 0);
            btnBanSaoSach.Name = "btnBanSaoSach";
            btnBanSaoSach.Size = new Size(111, 67);
            btnBanSaoSach.TabIndex = 1;
            btnBanSaoSach.Text = "Bản Sao Sách";
            btnBanSaoSach.UseVisualStyleBackColor = false;
            btnBanSaoSach.Click += btnBanSaoSach_Click;
            // 
            // btnSach
            // 
            btnSach.BackColor = Color.White;
            btnSach.Dock = DockStyle.Left;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Location = new Point(0, 0);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(111, 67);
            btnSach.TabIndex = 0;
            btnSach.Text = "Sách";
            btnSach.UseVisualStyleBackColor = false;
            btnSach.Click += btnSach_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 1;
            // 
            // UcQLSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQLSach";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnSach;
        private Button btnTheLoai;
        private Button btnNXB;
        private Button btnTacGia;
        private Button btnBanSaoSach;
        private Panel panelSubContent;
    }
}
