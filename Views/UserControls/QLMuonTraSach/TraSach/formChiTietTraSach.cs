using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class FormChiTietTraSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly int _idChiTietPhieuMuon;

        public FormChiTietTraSach(int idChiTietPhieuMuon)
        {
            InitializeComponent();
            _context = new LibraryDbContext();
            _idChiTietPhieuMuon = idChiTietPhieuMuon;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var ct = _context.ChiTietPhieuMuons
                    .Include(c => c.PhieuMuon)
                        .ThenInclude(pm => pm.NhanVien)
                    .Include(c => c.PhieuMuon)
                        .ThenInclude(pm => pm.TheThanhVien)
                            .ThenInclude(ttv => ttv.DocGias)
                    .Include(c => c.BanSaoSach)
                        .ThenInclude(bs => bs.Sach)
                    .FirstOrDefault(c => c.IdChiTietPhieuMuon == _idChiTietPhieuMuon);

                if (ct == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                textBoxIdChiTiet.Text = ct.IdChiTietPhieuMuon.ToString();
                textBoxIdPhieuMuon.Text = ct.IdPhieuMuon.ToString();
                textBoxNhanVien.Text = ct.PhieuMuon?.NhanVien?.TenNhanVien ?? "(Không có)";
                textBoxDocGia.Text = ct.PhieuMuon?.TheThanhVien?.DocGias?.TenDocGia ?? "(Không có)";
                textBoxTenSach.Text = ct.BanSaoSach?.Sach?.TenSach ?? "(Không có)";
                textBoxNgayMuon.Text = ct.PhieuMuon?.NgayMuon.ToString("dd/MM/yyyy") ?? "(Không có)";
                textBoxNgayHenTra.Text = ct.PhieuMuon?.NgayHenTra.ToString("dd/MM/yyyy") ?? "(Không có)";
                textBoxNgayTra.Text = ct.NgayTra?.ToString("dd/MM/yyyy") ?? "(Chưa trả)";
                textBoxTinhTrangTra.Text = ct.TinhTrangTra.HasValue ? ct.TinhTrangTra.ToString() : "(Chưa trả)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết phiếu trả:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
