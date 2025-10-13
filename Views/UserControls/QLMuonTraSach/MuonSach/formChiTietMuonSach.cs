using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    public partial class FormChiTietMuonSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly PhieuMuonService _phieuMuonService;
        private readonly int _idPhieuMuon;

        public FormChiTietMuonSach(int idPhieuMuon)
        {
            InitializeComponent();
            _idPhieuMuon = idPhieuMuon;

            _context = new LibraryDbContext();
            var phieuMuonRepo = new PhieuMuonRepository(_context);
            var chiTietRepo = new ChiTietPhieuMuonRepository(_context);
            var banSaoRepo = new BanSaoSachRepository(_context);
            var theThanhVienRepo = new TheThanhVienRepository(_context);

            _phieuMuonService = new PhieuMuonService(phieuMuonRepo, chiTietRepo, banSaoRepo, theThanhVienRepo);

            LoadThongTinPhieuMuon();
        }

        private void LoadThongTinPhieuMuon()
        {
            try
            {
                var phieu = _context.PhieuMuons
                    .Include(p => p.NhanVien)
                    .Include(p => p.TheThanhVien)
                        .ThenInclude(t => t.DocGias)
                    .FirstOrDefault(p => p.IdPhieuMuon == _idPhieuMuon);

                if (phieu == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                textBoxIdPhieuMuon.Text = phieu.IdPhieuMuon.ToString();
                textBoxNhanVien.Text = phieu.NhanVien?.TenNhanVien ?? "(Không có)";
                textBoxDocGia.Text = phieu.TheThanhVien?.DocGias?.TenDocGia ?? "(Không có)";
                textBoxNgayMuon.Text = phieu.NgayMuon.ToString("dd/MM/yyyy");
                textBoxNgayHenTra.Text = phieu.NgayHenTra.ToString("dd/MM/yyyy");
                textBoxTrangThai.Text = phieu.TrangThai.ToString();

                var danhSachChiTiet = _context.ChiTietPhieuMuons
                    .Include(ct => ct.BanSaoSach)
                        .ThenInclude(bs => bs.Sach)
                    .Where(ct => ct.IdPhieuMuon == _idPhieuMuon)
                    .Select(ct => new
                    {
                        IdBanSaoSach = ct.BanSaoSach.IdBanSaoSach,
                        TenSach = ct.BanSaoSach.Sach.TenSach,
                        NgayTra = ct.NgayTra.HasValue ? ct.NgayTra.Value.ToString("dd/MM/yyyy") : "Chưa trả",
                        TinhTrangTra = ct.TinhTrangTra.HasValue ? ct.TinhTrangTra.ToString() : "Chưa trả"
                    })
                    .ToList();

                dgvSachMuon.DataSource = danhSachChiTiet;

                dgvSachMuon.Columns["IdBanSaoSach"].HeaderText = "Mã Bản Sao";
                dgvSachMuon.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvSachMuon.Columns["NgayTra"].HeaderText = "Ngày Trả";
                dgvSachMuon.Columns["TinhTrangTra"].HeaderText = "Tình Trạng Trả";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
