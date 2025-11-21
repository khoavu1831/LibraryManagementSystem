using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using Microsoft.EntityFrameworkCore;

namespace LMS.Views.Views.UserControls.QLMuonTraSach.MuonTraSach
{
    public partial class FormChiTietPhieuMuon : Form
    {
        private readonly int _idPhieuMuon;

        public FormChiTietPhieuMuon(int idPhieuMuon)
        {
            InitializeComponent();
            _idPhieuMuon = idPhieuMuon;
            this.Load += FormChiTietPhieuMuon_Load;
        }

        private void FormChiTietPhieuMuon_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigureControls();
                LoadHeader();
                LoadDetails();
                LoadStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cấu hình các controls
        /// </summary>
        private void ConfigureControls()
        {
            // Set read-only cho các textboxes
            textBoxMaPhieuMuon.ReadOnly = true;
            textBoxNhanVien.ReadOnly = true;
            textBoxDocGia.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            textBoxTrangThai.ReadOnly = true;

            // Disable DateTimePickers
            dateTimePickerNgayMuon.Enabled = false;
            dateTimePickerNgayHenTra.Enabled = false;

            // Set background cho read-only fields
            textBoxMaPhieuMuon.BackColor = Color.WhiteSmoke;
            textBoxNhanVien.BackColor = Color.WhiteSmoke;
            textBoxDocGia.BackColor = Color.WhiteSmoke;
            textBoxSDT.BackColor = Color.WhiteSmoke;

            // Configure DataGridView
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            
            // Style cho header
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // Style cho cells
            dgvChiTiet.DefaultCellStyle.Font = new Font("Segoe UI", 9.75f);
            dgvChiTiet.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvChiTiet.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Wire up button event
            btnQuayLai.Click += BtnQuayLai_Click;
        }

        /// <summary>
        /// Load thông tin header (phiếu mượn)
        /// </summary>
        private void LoadHeader()
        {
            using (var ctx = new LibraryDbContext())
            {
                var pm = ctx.PhieuMuons
                    .Include(x => x.NhanVien)
                    .Include(x => x.TheThanhVien!)
                        .ThenInclude(ttv => ttv.DocGia)
                    .AsNoTracking()
                    .FirstOrDefault(x => x.IdPhieuMuon == _idPhieuMuon);

                if (pm == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // Gán giá trị cho các controls
                textBoxMaPhieuMuon.Text = pm.IdPhieuMuon.ToString();
                textBoxNhanVien.Text = pm.NhanVien?.TenNhanVien ?? "N/A";
                textBoxDocGia.Text = pm.TheThanhVien?.DocGia?.TenDocGia ?? "N/A";
                textBoxSDT.Text = pm.TheThanhVien?.DocGia?.SDT ?? "N/A";
                
                dateTimePickerNgayMuon.Value = pm.NgayMuon;
                dateTimePickerNgayHenTra.Value = pm.NgayHenTra;
                
                textBoxTrangThai.Text = pm.TrangThai.GetDisplayName();
                
                // Đổi màu theo trạng thái
                switch (pm.TrangThai)
                {
                    case PhieuMuon.TrangThaiEnum.DangMuon:
                        textBoxTrangThai.BackColor = Color.FromArgb(255, 243, 205); // Vàng
                        textBoxTrangThai.ForeColor = Color.FromArgb(133, 100, 4);
                        break;
                    case PhieuMuon.TrangThaiEnum.DaTra:
                        textBoxTrangThai.BackColor = Color.FromArgb(209, 231, 221); // Xanh
                        textBoxTrangThai.ForeColor = Color.FromArgb(15, 81, 50);
                        break;
                    case PhieuMuon.TrangThaiEnum.DaHuy:
                        textBoxTrangThai.BackColor = Color.FromArgb(248, 215, 218); // Đỏ
                        textBoxTrangThai.ForeColor = Color.FromArgb(114, 28, 36);
                        break;
                }
            }
        }

        /// <summary>
        /// Load chi tiết các sách đã mượn
        /// </summary>
        private void LoadDetails()
        {
            using (var ctx = new LibraryDbContext())
            {
                var data = ctx.ChiTietPhieuMuons
                    .Include(ct => ct.BanSaoSach!)
                        .ThenInclude(bss => bss.Sach!)
                            .ThenInclude(s => s.TacGias)
                    .AsNoTracking()
                    .Where(ct => ct.IdPhieuMuon == _idPhieuMuon)
                    .Select(ct => new
                    {
                        IdChiTiet = ct.IdChiTietPhieuMuon,
                        MaBanSao = ct.IdBanSaoSach ?? "N/A",
                        TenSach = ct.BanSaoSach!.Sach!.TenSach ?? "N/A",
                        TacGia = ct.BanSaoSach!.Sach!.TacGias != null && ct.BanSaoSach.Sach.TacGias.Any()
                            ? ct.BanSaoSach.Sach.TacGias.First().TenTacGia ?? "N/A"
                            : "N/A",
                        NgayTra = ct.NgayTra.HasValue 
                            ? ct.NgayTra.Value.ToString("dd/MM/yyyy") 
                            : "",
                        TinhTrangTra = ct.TinhTrangTra.HasValue 
                            ? ct.TinhTrangTra.Value.GetDisplayName() 
                            : "Chưa trả",
                        // Để cell formatting
                        TinhTrangTraRaw = ct.TinhTrangTra
                    })
                    .OrderBy(x => x.IdChiTiet)
                    .ToList();

                dgvChiTiet.Columns.Clear();
                dgvChiTiet.AutoGenerateColumns = false;

                // Cấu hình các cột
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "IdChiTiet",
                    DataPropertyName = "IdChiTiet",
                    HeaderText = "Mã CT",
                    Width = 60
                });
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MaBanSao",
                    DataPropertyName = "MaBanSao",
                    HeaderText = "Mã bản sao",
                    Width = 100
                });
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenSach",
                    DataPropertyName = "TenSach",
                    HeaderText = "Tên sách",
                    Width = 300,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TacGia",
                    DataPropertyName = "TacGia",
                    HeaderText = "Tác giả",
                    Width = 150
                });
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NgayTra",
                    DataPropertyName = "NgayTra",
                    HeaderText = "Ngày trả",
                    Width = 100
                });
                dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TinhTrangTra",
                    DataPropertyName = "TinhTrangTra",
                    HeaderText = "Tình trạng",
                    Width = 120
                });

                dgvChiTiet.DataSource = data;

                // Thêm cell formatting cho màu sắc
                dgvChiTiet.CellFormatting += DgvChiTiet_CellFormatting;
            }
        }

        /// <summary>
        /// Thêm màu sắc cho từng dòng theo tình trạng
        /// </summary>
        private void DgvChiTiet_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvChiTiet.Rows[e.RowIndex];
            var tinhTrang = row.Cells["TinhTrangTra"].Value?.ToString();

            if (string.IsNullOrEmpty(tinhTrang) || tinhTrang == "Chưa trả")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205); // Vàng nhạt
                row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);
            }
            else if (tinhTrang == "Tốt")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(209, 231, 221); // Xanh nhạt
                row.DefaultCellStyle.ForeColor = Color.FromArgb(15, 81, 50);
            }
            else if (tinhTrang == "Hư hỏng" || tinhTrang == "Mất")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218); // Đỏ nhạt
                row.DefaultCellStyle.ForeColor = Color.FromArgb(114, 28, 36);
            }
        }

        /// <summary>
        /// Load thống kê
        /// </summary>
        private void LoadStatistics()
        {
            using (var ctx = new LibraryDbContext())
            {
                var chiTiets = ctx.ChiTietPhieuMuons
                    .Where(ct => ct.IdPhieuMuon == _idPhieuMuon)
                    .AsNoTracking()
                    .ToList();

                int tongSo = chiTiets.Count;
                int daTra = chiTiets.Count(ct => ct.NgayTra.HasValue);
                int chuaTra = tongSo - daTra;

                labelTongSo.Text = $"Tổng số sách: {tongSo}";
                labelTongSo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                
                labelDaTra.Text = $"Đã trả: {daTra}";
                labelDaTra.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                labelDaTra.ForeColor = Color.Green;
                
                labelChuaTra.Text = $"Chưa trả: {chuaTra}";
                labelChuaTra.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                labelChuaTra.ForeColor = Color.OrangeRed;
            }
        }

        private void BtnQuayLai_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTitle_Click_1(object sender, EventArgs e)
        {
            // Empty event handler từ Designer
        }

        private void labelTrangThai_Click(object sender, EventArgs e)
        {
            // Empty event handler từ Designer
        }
    }
}
