namespace LMS.Views.UserControls.QuanLy
{
    partial class UcQuanLy
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
            btnDoimatkhau = new Button();
            btnSua = new Button();
            panelSubContent = new Panel();
            textBox7 = new TextBox();
            btnVaitro = new Button();
            picAvatar = new PictureBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnEmail = new Button();
            btnGt = new Button();
            btnDc = new Button();
            btnSdt = new Button();
            btnNs = new Button();
            btnTen = new Button();
            panelNavMenu.SuspendLayout();
            panelSubContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.White;
            panelNavMenu.Controls.Add(btnDoimatkhau);
            panelNavMenu.Controls.Add(btnSua);
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Margin = new Padding(3, 4, 3, 4);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(984, 89);
            panelNavMenu.TabIndex = 0;
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.Dock = DockStyle.Left;
            btnDoimatkhau.Image = Properties.Resources.icondoimk;
            btnDoimatkhau.Location = new Point(127, 0);
            btnDoimatkhau.Margin = new Padding(0);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(127, 89);
            btnDoimatkhau.TabIndex = 0;
            btnDoimatkhau.TabStop = false;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoimatkhau.UseVisualStyleBackColor = false;
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Left;
            btnSua.Image = Properties.Resources.iconsua;
            btnSua.Location = new Point(0, 0);
            btnSua.Margin = new Padding(0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 89);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa thông tin";
            btnSua.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panelSubContent
            // 
            panelSubContent.BackColor = Color.White;
            panelSubContent.Controls.Add(textBox7);
            panelSubContent.Controls.Add(btnVaitro);
            panelSubContent.Controls.Add(picAvatar);
            panelSubContent.Controls.Add(textBox6);
            panelSubContent.Controls.Add(textBox5);
            panelSubContent.Controls.Add(textBox4);
            panelSubContent.Controls.Add(textBox3);
            panelSubContent.Controls.Add(textBox2);
            panelSubContent.Controls.Add(textBox1);
            panelSubContent.Controls.Add(btnEmail);
            panelSubContent.Controls.Add(btnGt);
            panelSubContent.Controls.Add(btnDc);
            panelSubContent.Controls.Add(btnSdt);
            panelSubContent.Controls.Add(btnNs);
            panelSubContent.Controls.Add(btnTen);
            panelSubContent.Enabled = false;
            panelSubContent.Location = new Point(0, 89);
            panelSubContent.Margin = new Padding(3, 4, 3, 4);
            panelSubContent.Name = "panelSubContent";
            panelSubContent.Size = new Size(984, 723);
            panelSubContent.TabIndex = 0;
            panelSubContent.TabStop = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(109, 481);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 27);
            textBox7.TabIndex = 14;
            textBox7.Text = "Quản Lý";
            // 
            // btnVaitro
            // 
            btnVaitro.Location = new Point(109, 446);
            btnVaitro.Margin = new Padding(0);
            btnVaitro.Name = "btnVaitro";
            btnVaitro.Size = new Size(94, 29);
            btnVaitro.TabIndex = 13;
            btnVaitro.Text = "Vai Trò:";
            btnVaitro.UseVisualStyleBackColor = false;
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.icon1;
            picAvatar.Location = new Point(109, 111);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(306, 288);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 12;
            picAvatar.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(554, 549);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 27);
            textBox6.TabIndex = 11;
            textBox6.Text = "b12@gmai.com";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(554, 461);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 10;
            textBox5.Text = "Nam";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(554, 372);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 9;
            textBox4.Text = "120, An Dương Vương, quận 5 ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(554, 291);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "0976124358";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(554, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "1/1/2004";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(554, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Nguyễn Văn A";
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(554, 514);
            btnEmail.Margin = new Padding(0);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(94, 29);
            btnEmail.TabIndex = 5;
            btnEmail.Text = "Email:";
            btnEmail.UseVisualStyleBackColor = false;
            // 
            // btnGt
            // 
            btnGt.Location = new Point(554, 426);
            btnGt.Margin = new Padding(0);
            btnGt.Name = "btnGt";
            btnGt.Size = new Size(94, 29);
            btnGt.TabIndex = 4;
            btnGt.Text = "Giới tính:";
            btnGt.UseVisualStyleBackColor = false;
            // 
            // btnDc
            // 
            btnDc.Location = new Point(554, 337);
            btnDc.Margin = new Padding(0);
            btnDc.Name = "btnDc";
            btnDc.Size = new Size(94, 29);
            btnDc.TabIndex = 3;
            btnDc.Text = "Địa chỉ:";
            btnDc.UseVisualStyleBackColor = false;
            // 
            // btnSdt
            // 
            btnSdt.Location = new Point(554, 256);
            btnSdt.Margin = new Padding(0);
            btnSdt.Name = "btnSdt";
            btnSdt.Size = new Size(114, 29);
            btnSdt.TabIndex = 2;
            btnSdt.Text = "Số điện thoại:";
            btnSdt.UseVisualStyleBackColor = false;
            // 
            // btnNs
            // 
            btnNs.Location = new Point(554, 165);
            btnNs.Margin = new Padding(0);
            btnNs.Name = "btnNs";
            btnNs.Size = new Size(94, 29);
            btnNs.TabIndex = 1;
            btnNs.Text = "Ngày sinh:";
            btnNs.UseVisualStyleBackColor = false;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(554, 76);
            btnTen.Margin = new Padding(0);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 0;
            btnTen.Text = "Họ và tên:";
            btnTen.UseVisualStyleBackColor = false;
            // 
            // UcQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSubContent);
            Controls.Add(panelNavMenu);
            Name = "UcQuanLy";
            Size = new Size(984, 812);
            panelNavMenu.ResumeLayout(false);
            panelSubContent.ResumeLayout(false);
            panelSubContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Button btnDoimatkhau;
        private Button btnSua;
        private Panel panelSubContent;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnEmail;
        private Button btnGt;
        private Button btnDc;
        private Button btnSdt;
        private Button btnNs;
        private Button btnTen;
        private PictureBox picAvatar;
        private TextBox textBox7;
        private Button btnVaitro;
    }
}
