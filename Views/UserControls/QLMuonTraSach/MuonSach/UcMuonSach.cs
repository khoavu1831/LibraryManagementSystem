using LibraryManagementSystem.Data;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    public partial class UcMuonSach : UserControl
    {
        private readonly PhieuMuonService _phieuMuonService;
        private List<PhieuMuon> _listPhieuMuon = new();

        public UcMuonSach()
        {
            InitializeComponent();
            this.VisibleChanged += (s, e) =>
            {
                if (this.Visible)
                    LoadData();
            };
            var context = new LibraryDbContext();
            var phieuMuonRepo = new PhieuMuonRepository(context);
            var chiTietRepo = new ChiTietPhieuMuonRepository(context);
            var banSaoRepo = new BanSaoSachRepository(context);
            var theThanhVienRepo = new TheThanhVienRepository(context);

            _phieuMuonService = new PhieuMuonService(phieuMuonRepo, chiTietRepo, banSaoRepo, theThanhVienRepo);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _listPhieuMuon = _phieuMuonService.GetAllPhieuMuon()
                    .OrderBy(pm => pm.IdPhieuMuon)
                    .ToList();

                BindToGrid(_listPhieuMuon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu mượn.\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindToGrid(List<PhieuMuon> list)
        {
            dgvMuonSach.DataSource = null;
            dgvMuonSach.AutoGenerateColumns = true;

            var displayList = list.Select(pm => new
            {
                IdPhieuMuon = pm.IdPhieuMuon,
                TenNhanVien = pm.NhanVien?.TenNhanVien ?? "(Không có)",
                TenDocGia = pm.TheThanhVien?.DocGias?.TenDocGia ?? "(Không có)",
                NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                NgayHanTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                TrangThai = pm.TrangThai.ToString()
            }).ToList();

            dgvMuonSach.DataSource = displayList;
            dgvMuonSach.Columns["IdPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
            dgvMuonSach.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
            dgvMuonSach.Columns["TenDocGia"].HeaderText = "Độc Giả";
            dgvMuonSach.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dgvMuonSach.Columns["NgayHanTra"].HeaderText = "Hạn Trả";
            dgvMuonSach.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string keyword = txtBoxTimKiem.Text.Trim();
            try
            {
                var result = _phieuMuonService.SearchPhieuMuon(keyword);
                BindToGrid(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void btnLamMoi_Click_1(object? sender, EventArgs e)
        {
            txtBoxTimKiem.Clear();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThem = new FormThemMuonSach())
            {
                if (formThem.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu mượn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idPhieuMuon = Convert.ToInt32(dgvMuonSach.Rows[rowIndex].Cells["IdPhieuMuon"].Value);

                using (var formSua = new FormSuaMuonSach(idPhieuMuon))
                {
                    if (formSua.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form sửa:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_Click(object? sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu mượn để xem chi tiết.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPhieuMuon = Convert.ToInt32(dgvMuonSach.Rows[rowIndex].Cells["IdPhieuMuon"].Value);

            using (var formChiTiet = new FormChiTietMuonSach(idPhieuMuon))
            {
                formChiTiet.ShowDialog(this);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idPhieuMuon = Convert.ToInt32(dgvMuonSach.Rows[rowIndex].Cells["IdPhieuMuon"].Value);

                var phieuMuon = _phieuMuonService
                    .GetAllPhieuMuon()
                    .FirstOrDefault(pm => pm.IdPhieuMuon == idPhieuMuon);

                if (phieuMuon == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn để xóa.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa phiếu mượn #{idPhieuMuon}?\n\n" +
                    "- Tất cả chi tiết phiếu mượn của phiếu này sẽ bị xóa.\n" +
                    "- Tất cả bản sao sách liên quan sẽ được đặt lại trạng thái 'Tốt'.\n" +
                    "- Hành động này không thể hoàn tác.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                using (var context = new LibraryDbContext())
                {
                    var chiTietRepo = new ChiTietPhieuMuonRepository(context);
                    var banSaoRepo = new BanSaoSachRepository(context);
                    var phieuRepo = new PhieuMuonRepository(context);

                    var chiTietList = chiTietRepo.GetByPhieuMuonId(idPhieuMuon);

                    foreach (var ct in chiTietList)
                    {
                        var banSao = banSaoRepo.GetAll()
                            .FirstOrDefault(bs => bs.IdBanSaoSach == ct.IdBanSaoSach);

                        if (banSao != null)
                        {
                            banSao.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.Tot;
                            context.BanSaoSachs.Update(banSao);
                        }

                        context.ChiTietPhieuMuons.Remove(ct);
                    }

                    var pm = context.PhieuMuons.FirstOrDefault(p => p.IdPhieuMuon == idPhieuMuon);
                    if (pm != null)
                    {
                        context.PhieuMuons.Remove(pm);
                    }

                    context.SaveChanges();
                }

                LoadData();

                MessageBox.Show("Đã xóa phiếu mượn và cập nhật trạng thái sách thành công.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phiếu mượn: {ex.Message}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMuonSach_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvMuonSach.ClearSelection();
                foreach (DataGridViewCell cell in dgvMuonSach.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }

        private int GetSelectedRowIndex()
        {
            if (dgvMuonSach.SelectedCells.Count > 0)
            {
                return dgvMuonSach.SelectedCells[0].RowIndex;
            }
            return -1;
        }
    }
}
