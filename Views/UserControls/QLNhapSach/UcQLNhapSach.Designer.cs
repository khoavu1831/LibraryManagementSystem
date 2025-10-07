namespace LibraryManagementSystem.Views.UserControls.QLNhapSach
{
    partial class UcQLNhapSach
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
            btnNCC = new Button();
            btnNhapSach = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnNCC);
            panelNavMenu.Controls.Add(btnNhapSach);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 0;
            // 
            // btnNCC
            // 
            btnNCC.BackColor = Color.White;
            btnNCC.Dock = DockStyle.Left;
            btnNCC.FlatStyle = FlatStyle.Flat;
            btnNCC.Location = new Point(111, 0);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(111, 67);
            btnNCC.TabIndex = 1;
            btnNCC.Text = "Nhà Cung Cấp";
            btnNCC.UseVisualStyleBackColor = false;
            btnNCC.Click += btnNCC_Click;
            // 
            // btnNhapSach
            // 
            btnNhapSach.BackColor = Color.White;
            btnNhapSach.Dock = DockStyle.Left;
            btnNhapSach.FlatStyle = FlatStyle.Flat;
            btnNhapSach.Location = new Point(0, 0);
            btnNhapSach.Name = "btnNhapSach";
            btnNhapSach.Size = new Size(111, 67);
            btnNhapSach.TabIndex = 0;
            btnNhapSach.Text = "Nhập Sách";
            btnNhapSach.UseVisualStyleBackColor = false;
            btnNhapSach.Click += btnNhapSach_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 1;
            // 
            // UcQLNhapSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQLNhapSach";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnNhapSach;
        private Button btnNCC;
        private Panel panelSubContent;
    }
}
