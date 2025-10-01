namespace LibraryManagementSystem.Views.UserControls.QLMuonTra
{
    partial class UcQLMuonTraSach
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

        private void InitializeComponent()
        {
            panelNavMenu = new Panel();
            btnTraSach = new Button();
            btnMuonSach = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnTraSach);
            panelNavMenu.Controls.Add(btnMuonSach);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 1;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.White;
            btnTraSach.Dock = DockStyle.Left;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Location = new Point(111, 0);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(111, 67);
            btnTraSach.TabIndex = 1;
            btnTraSach.Text = "Trả Sách";
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.BackColor = Color.White;
            btnMuonSach.Dock = DockStyle.Left;
            btnMuonSach.FlatStyle = FlatStyle.Flat;
            btnMuonSach.Location = new Point(0, 0);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(111, 67);
            btnMuonSach.TabIndex = 0;
            btnMuonSach.Text = "Mượn Sách";
            btnMuonSach.UseVisualStyleBackColor = false;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 2;
            // 
            // UcQLMuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcQLMuonTra";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnTraSach;
        private Button btnMuonSach;
        private Panel panelSubContent;
    }
}
