namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    partial class FormChiTietTraSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            panelTop = new Panel();
            panelContent = new Panel();
            labelIdChiTiet = new Label();
            textBoxIdChiTiet = new TextBox();
            labelIdPhieuMuon = new Label();
            textBoxIdPhieuMuon = new TextBox();
            labelNhanVien = new Label();
            textBoxNhanVien = new TextBox();
            labelDocGia = new Label();
            textBoxDocGia = new TextBox();
            labelTenSach = new Label();
            textBoxTenSach = new TextBox();
            labelNgayMuon = new Label();
            textBoxNgayMuon = new TextBox();
            labelNgayHenTra = new Label();
            textBoxNgayHenTra = new TextBox();
            labelNgayTra = new Label();
            textBoxNgayTra = new TextBox();
            labelTinhTrangTra = new Label();
            textBoxTinhTrangTra = new TextBox();
            btnDong = new Button();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
      
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(600, 70);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHI TIẾT PHIẾU TRẢ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
      
            panelTop.BackColor = SystemColors.HotTrack;
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(600, 70);
            panelTop.TabIndex = 1;
        
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(labelIdChiTiet);
            panelContent.Controls.Add(textBoxIdChiTiet);
            panelContent.Controls.Add(labelIdPhieuMuon);
            panelContent.Controls.Add(textBoxIdPhieuMuon);
            panelContent.Controls.Add(labelNhanVien);
            panelContent.Controls.Add(textBoxNhanVien);
            panelContent.Controls.Add(labelDocGia);
            panelContent.Controls.Add(textBoxDocGia);
            panelContent.Controls.Add(labelTenSach);
            panelContent.Controls.Add(textBoxTenSach);
            panelContent.Controls.Add(labelNgayMuon);
            panelContent.Controls.Add(textBoxNgayMuon);
            panelContent.Controls.Add(labelNgayHenTra);
            panelContent.Controls.Add(textBoxNgayHenTra);
            panelContent.Controls.Add(labelNgayTra);
            panelContent.Controls.Add(textBoxNgayTra);
            panelContent.Controls.Add(labelTinhTrangTra);
            panelContent.Controls.Add(textBoxTinhTrangTra);
            panelContent.Controls.Add(btnDong);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 70);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40, 20, 40, 20);
            panelContent.Size = new Size(600, 390);
            panelContent.TabIndex = 0;
      
            labelIdChiTiet.Location = new Point(30, 20);
            labelIdChiTiet.Name = "labelIdChiTiet";
            labelIdChiTiet.Size = new Size(120, 25);
            labelIdChiTiet.TabIndex = 0;
            labelIdChiTiet.Text = "Mã Chi Tiết PM:";
            labelIdChiTiet.TextAlign = ContentAlignment.MiddleLeft;
       
            textBoxIdChiTiet.Location = new Point(160, 18);
            textBoxIdChiTiet.Name = "textBoxIdChiTiet";
            textBoxIdChiTiet.ReadOnly = true;
            textBoxIdChiTiet.Size = new Size(380, 23);
            textBoxIdChiTiet.TabIndex = 1;
       
            labelIdPhieuMuon.Location = new Point(30, 53);
            labelIdPhieuMuon.Name = "labelIdPhieuMuon";
            labelIdPhieuMuon.Size = new Size(120, 25);
            labelIdPhieuMuon.TabIndex = 2;
            labelIdPhieuMuon.Text = "Mã Phiếu Mượn:";
            labelIdPhieuMuon.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxIdPhieuMuon.Location = new Point(160, 51);
            textBoxIdPhieuMuon.Name = "textBoxIdPhieuMuon";
            textBoxIdPhieuMuon.ReadOnly = true;
            textBoxIdPhieuMuon.Size = new Size(380, 23);
            textBoxIdPhieuMuon.TabIndex = 3;
        
            labelNhanVien.Location = new Point(30, 86);
            labelNhanVien.Name = "labelNhanVien";
            labelNhanVien.Size = new Size(120, 25);
            labelNhanVien.TabIndex = 4;
            labelNhanVien.Text = "Nhân Viên:";
            labelNhanVien.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxNhanVien.Location = new Point(160, 84);
            textBoxNhanVien.Name = "textBoxNhanVien";
            textBoxNhanVien.ReadOnly = true;
            textBoxNhanVien.Size = new Size(380, 23);
            textBoxNhanVien.TabIndex = 5;
      
            labelDocGia.Location = new Point(30, 119);
            labelDocGia.Name = "labelDocGia";
            labelDocGia.Size = new Size(120, 25);
            labelDocGia.TabIndex = 6;
            labelDocGia.Text = "Độc Giả:";
            labelDocGia.TextAlign = ContentAlignment.MiddleLeft;
      
            textBoxDocGia.Location = new Point(160, 117);
            textBoxDocGia.Name = "textBoxDocGia";
            textBoxDocGia.ReadOnly = true;
            textBoxDocGia.Size = new Size(380, 23);
            textBoxDocGia.TabIndex = 7;
         
            labelTenSach.Location = new Point(30, 152);
            labelTenSach.Name = "labelTenSach";
            labelTenSach.Size = new Size(120, 25);
            labelTenSach.TabIndex = 8;
            labelTenSach.Text = "Tên Sách:";
            labelTenSach.TextAlign = ContentAlignment.MiddleLeft;
         
            textBoxTenSach.Location = new Point(160, 150);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.ReadOnly = true;
            textBoxTenSach.Size = new Size(380, 23);
            textBoxTenSach.TabIndex = 9;
       
            labelNgayMuon.Location = new Point(30, 185);
            labelNgayMuon.Name = "labelNgayMuon";
            labelNgayMuon.Size = new Size(120, 25);
            labelNgayMuon.TabIndex = 10;
            labelNgayMuon.Text = "Ngày Mượn:";
            labelNgayMuon.TextAlign = ContentAlignment.MiddleLeft;
          
            textBoxNgayMuon.Location = new Point(160, 183);
            textBoxNgayMuon.Name = "textBoxNgayMuon";
            textBoxNgayMuon.ReadOnly = true;
            textBoxNgayMuon.Size = new Size(380, 23);
            textBoxNgayMuon.TabIndex = 11;
       
            labelNgayHenTra.Location = new Point(30, 218);
            labelNgayHenTra.Name = "labelNgayHenTra";
            labelNgayHenTra.Size = new Size(120, 25);
            labelNgayHenTra.TabIndex = 12;
            labelNgayHenTra.Text = "Hẹn Trả:";
            labelNgayHenTra.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxNgayHenTra.Location = new Point(160, 216);
            textBoxNgayHenTra.Name = "textBoxNgayHenTra";
            textBoxNgayHenTra.ReadOnly = true;
            textBoxNgayHenTra.Size = new Size(380, 23);
            textBoxNgayHenTra.TabIndex = 13;
       
            labelNgayTra.Location = new Point(30, 251);
            labelNgayTra.Name = "labelNgayTra";
            labelNgayTra.Size = new Size(120, 25);
            labelNgayTra.TabIndex = 14;
            labelNgayTra.Text = "Ngày Trả:";
            labelNgayTra.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxNgayTra.Location = new Point(160, 249);
            textBoxNgayTra.Name = "textBoxNgayTra";
            textBoxNgayTra.ReadOnly = true;
            textBoxNgayTra.Size = new Size(380, 23);
            textBoxNgayTra.TabIndex = 15;
        
            labelTinhTrangTra.Location = new Point(30, 284);
            labelTinhTrangTra.Name = "labelTinhTrangTra";
            labelTinhTrangTra.Size = new Size(120, 25);
            labelTinhTrangTra.TabIndex = 16;
            labelTinhTrangTra.Text = "Tình Trạng Trả:";
            labelTinhTrangTra.TextAlign = ContentAlignment.MiddleLeft;
        
            textBoxTinhTrangTra.Location = new Point(160, 282);
            textBoxTinhTrangTra.Name = "textBoxTinhTrangTra";
            textBoxTinhTrangTra.ReadOnly = true;
            textBoxTinhTrangTra.Size = new Size(380, 23);
            textBoxTinhTrangTra.TabIndex = 17;
  
            btnDong.Location = new Point(223, 332);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(140, 35);
            btnDong.TabIndex = 18;
            btnDong.Text = "Đóng";
            btnDong.Click += btnDong_Click;
     
            ClientSize = new Size(600, 460);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormChiTietTraSach";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi Tiết Phiếu Trả";
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelContent;
        private Label labelIdChiTiet;
        private TextBox textBoxIdChiTiet;
        private Label labelIdPhieuMuon;
        private TextBox textBoxIdPhieuMuon;
        private Label labelNhanVien;
        private TextBox textBoxNhanVien;
        private Label labelDocGia;
        private TextBox textBoxDocGia;
        private Label labelTenSach;
        private TextBox textBoxTenSach;
        private Label labelNgayMuon;
        private TextBox textBoxNgayMuon;
        private Label labelNgayHenTra;
        private TextBox textBoxNgayHenTra;
        private Label labelNgayTra;
        private TextBox textBoxNgayTra;
        private Label labelTinhTrangTra;
        private TextBox textBoxTinhTrangTra;
        private Button btnDong;
    }
}
