namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    partial class UcQLPhat
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
            btnMucPhat = new Button();
            btnTraPhat = new Button();
            btnPhat = new Button();
            panelSubContent = new Panel();
            panelNavMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnMucPhat);
            panelNavMenu.Controls.Add(btnTraPhat);
            panelNavMenu.Controls.Add(btnPhat);
            panelNavMenu.Dock = DockStyle.Top;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(861, 67);
            panelNavMenu.TabIndex = 1;
            // 
            // btnMucPhat
            // 
            btnMucPhat.BackColor = Color.White;
            btnMucPhat.Dock = DockStyle.Left;
            btnMucPhat.FlatStyle = FlatStyle.Flat;
            btnMucPhat.Location = new Point(222, 0);
            btnMucPhat.Name = "btnMucPhat";
            btnMucPhat.Size = new Size(111, 67);
            btnMucPhat.TabIndex = 2;
            btnMucPhat.Text = "Mức Phạt";
            btnMucPhat.UseVisualStyleBackColor = false;
            btnMucPhat.Click += btnMucPhat_Click;
            // 
            // btnTraPhat
            // 
            btnTraPhat.BackColor = Color.White;
            btnTraPhat.Dock = DockStyle.Left;
            btnTraPhat.FlatStyle = FlatStyle.Flat;
            btnTraPhat.Location = new Point(111, 0);
            btnTraPhat.Name = "btnTraPhat";
            btnTraPhat.Size = new Size(111, 67);
            btnTraPhat.TabIndex = 1;
            btnTraPhat.Text = "Trả Phạt";
            btnTraPhat.UseVisualStyleBackColor = false;
            btnTraPhat.Click += btnTraPhat_Click;
            // 
            // btnPhat
            // 
            btnPhat.BackColor = Color.White;
            btnPhat.Dock = DockStyle.Left;
            btnPhat.FlatStyle = FlatStyle.Flat;
            btnPhat.Location = new Point(0, 0);
            btnPhat.Name = "btnPhat";
            btnPhat.Size = new Size(111, 67);
            btnPhat.TabIndex = 0;
            btnPhat.Text = "Phạt";
            btnPhat.UseVisualStyleBackColor = false;
            btnPhat.Click += btnPhat_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.Dock = DockStyle.Fill;
            panelSubContent.Location = new Point(0, 67);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(861, 542);
            panelSubContent.TabIndex = 2;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControl1";
            Size = new Size(861, 609);
            panelNavMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnMucPhat;
        private Button btnTraPhat;
        private Button btnPhat;
        private Panel panelSubContent;
    }
}
