using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class UcTraSach : UserControl
    {
        private readonly PhieuMuonService _phieuMuonService;
        private readonly LibraryDbContext _context;

        public UcTraSach()
        {
            InitializeComponent();
            this.VisibleChanged += (s, e) =>
            {
                if (this.Visible)
                    LoadData();
            };

            _context = new LibraryDbContext();
            var phieuMuonRepo = new PhieuMuonRepository(_context);
            var chiTietRepo = new ChiTietPhieuMuonRepository(_context);
            var banSaoRepo = new BanSaoSachRepository(_context);
            var theThanhVienRepo = new TheThanhVienRepository(_context);

            _phieuMuonService = new PhieuMuonService(phieuMuonRepo, chiTietRepo, banSaoRepo, theThanhVienRepo);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var freshContext = new LibraryDbContext())
                {
                    var list = freshContext.ChiTietPhieuMuons
                        .Include(ct => ct.PhieuMuon)
                        .Include(ct => ct.BanSaoSach)
                            .ThenInclude(bs => bs.Sach)
                        .Where(ct => ct.NgayTra.HasValue && ct.TinhTrangTra.HasValue)
                        .OrderBy(ct => ct.IdPhieuMuon)
                        .ToList();

                    BindToGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu trả.\n[{ex.Message}]",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BindToGrid(List<ChiTietPhieuMuon> list)
        {
            dgvTraSach.DataSource = null;

            var displayList = list.Select(ct => new
            {
                IdChiTietPhieuMuon = ct.IdChiTietPhieuMuon,
                IdPhieuMuon = ct.IdPhieuMuon,
                TenSach = ct.BanSaoSach?.Sach?.TenSach ?? "(Không có)",
                NgayTra = ct.NgayTra?.ToString("dd/MM/yyyy") ?? "(Chưa trả)",
                TinhTrangTra = ct.TinhTrangTra.ToString()
            }).ToList();

            dgvTraSach.AutoGenerateColumns = true;
            dgvTraSach.DataSource = displayList;

            dgvTraSach.Columns["IdChiTietPhieuMuon"].HeaderText = "Mã Chi Tiết";
            dgvTraSach.Columns["IdPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
            dgvTraSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvTraSach.Columns["NgayTra"].HeaderText = "Ngày Trả";
            dgvTraSach.Columns["TinhTrangTra"].HeaderText = "Tình Trạng Trả";
        }
        private void btnLamMoi_Click_1(object? sender, EventArgs e)
        {
            txtBoxTimKiem.Clear();
            LoadData();
        }

        private void btnTimKiem_Click_1(object? sender, EventArgs e)
        {
            string keyword = txtBoxTimKiem.Text.Trim().ToLower();
            try
            {
                var list = _context.ChiTietPhieuMuons
                    .Include(ct => ct.PhieuMuon)
                    .Include(ct => ct.BanSaoSach)
                    .ThenInclude(bs => bs.Sach)
                    .Where(ct =>
                        ct.NgayTra.HasValue && ct.TinhTrangTra.HasValue &&
                        (ct.IdPhieuMuon.ToString().Contains(keyword) ||
                        ct.IdChiTietPhieuMuon.ToString().Contains(keyword) ||
                        (ct.BanSaoSach != null && ct.BanSaoSach.IdBanSaoSach.Contains(keyword)) ||
                        (ct.BanSaoSach != null && ct.BanSaoSach.Sach != null && ct.BanSaoSach.Sach.TenSach.ToLower().Contains(keyword))))
                    .OrderBy(ct => ct.IdPhieuMuon)
                    .ToList();

                BindToGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThem = new FormThemTraSach())
            {
                if (formThem.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (dgvTraSach.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int rowIndex = dgvTraSach.SelectedCells[0].RowIndex;
                var selectedRow = dgvTraSach.Rows[rowIndex];
                int idChiTietPhieuMuon = Convert.ToInt32(selectedRow.Cells["IdChiTietPhieuMuon"].Value);

                using (var formSua = new FormSuaTraSach())
                {
                    formSua.SetChiTietId(idChiTietPhieuMuon);
                    if (formSua.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form sửa: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvTraSach.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = dgvTraSach.SelectedCells[0].RowIndex;
            int idChiTiet = Convert.ToInt32(dgvTraSach.Rows[rowIndex].Cells["IdChiTietPhieuMuon"].Value);

            using (var f = new FormChiTietTraSach(idChiTiet))
            {
                f.ShowDialog(this);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTraSach.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int rowIndex = dgvTraSach.SelectedCells[0].RowIndex;
                var selectedRow = dgvTraSach.Rows[rowIndex];
                int idChiTietPhieuMuon = Convert.ToInt32(selectedRow.Cells["IdChiTietPhieuMuon"].Value);

                var chiTiet = _context.ChiTietPhieuMuons
                    .Include(ct => ct.PhieuMuon)
                    .FirstOrDefault(ct => ct.IdChiTietPhieuMuon == idChiTietPhieuMuon);

                if (chiTiet == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết phiếu mượn cần xóa.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa thông tin trả sách cho bản sao {chiTiet.IdBanSaoSach} (Phiếu {chiTiet.IdPhieuMuon})?\n" +
                    "(Sách sẽ quay về trạng thái cho mượn.)",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                chiTiet.NgayTra = null;
                chiTiet.TinhTrangTra = null;
                _context.ChiTietPhieuMuons.Update(chiTiet);

                var banSao = _context.BanSaoSachs
                    .FirstOrDefault(bs => bs.IdBanSaoSach == chiTiet.IdBanSaoSach);
                if (banSao != null)
                {
                    banSao.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.ChoMuon;
                    _context.BanSaoSachs.Update(banSao);
                }

                var phieuMuon = chiTiet.PhieuMuon;
                if (phieuMuon != null)
                {
                    phieuMuon.TrangThai = PhieuMuon.TrangThaiEnum.DangMuon;
                    _context.PhieuMuons.Update(phieuMuon);
                }

                _context.SaveChanges();

                LoadData();

                MessageBox.Show("Đã xóa thông tin trả sách thành công và cập nhật trạng thái phiếu mượn!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTraSach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTraSach.ClearSelection();
                foreach (DataGridViewCell cell in dgvTraSach.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }
    }
}
