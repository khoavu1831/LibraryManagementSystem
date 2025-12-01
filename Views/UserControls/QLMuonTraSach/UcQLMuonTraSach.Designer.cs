namespace LMS.Views.UserControls.QLMuonTraSach
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
            btnMuonTraSach = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnMuonTraSach);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 1;
            // 
            // btnMuonTraSach
            // 
            btnMuonTraSach.BackColor = Color.White;
            btnMuonTraSach.Dock = DockStyle.Left;
            btnMuonTraSach.FlatStyle = FlatStyle.Flat;
            btnMuonTraSach.Location = new Point(0, 0);
            btnMuonTraSach.Name = "btnMuonTraSach";
            btnMuonTraSach.Size = new Size(111, 67);
            btnMuonTraSach.TabIndex = 0;
            btnMuonTraSach.Text = "Mượn Trả Sách";
            btnMuonTraSach.UseVisualStyleBackColor = false;
            //btnMuonTraSach.Click += btnMuonTraSach_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 2;
            // 
            // UcQLMuonTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcQLMuonTraSach";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnMuonTraSach;
        private Panel panelSubContent;
    }
}
