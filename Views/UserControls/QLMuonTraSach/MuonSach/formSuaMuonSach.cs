using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.MuonSach
{
    public partial class FormSuaMuonSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly PhieuMuonService _phieuMuonService;
        private readonly int _idPhieuMuon;

        private PhieuMuon _phieuMuonHienTai;

        public FormSuaMuonSach(int idPhieuMuon)
        {
            InitializeComponent();

            _idPhieuMuon = idPhieuMuon;

            _context = new LibraryDbContext();
            var phieuMuonRepo = new PhieuMuonRepository(_context);
            var chiTietRepo = new ChiTietPhieuMuonRepository(_context);
            var banSaoRepo = new BanSaoSachRepository(_context);
            var theThanhVienRepo = new TheThanhVienRepository(_context);

            _phieuMuonService = new PhieuMuonService(phieuMuonRepo, chiTietRepo, banSaoRepo, theThanhVienRepo);

            LoadLookupData();
        }

        private void LoadLookupData()
        {
            try
            {
                _phieuMuonHienTai = _context.PhieuMuons
                    .Include(pm => pm.NhanVien)
                    .Include(pm => pm.TheThanhVien)
                        .ThenInclude(tv => tv.DocGias)
                    .Include(pm => pm.ChiTietPhieuMuons)
                        .ThenInclude(ct => ct.BanSaoSach)
                            .ThenInclude(bs => bs.Sach)
                    .FirstOrDefault(pm => pm.IdPhieuMuon == _idPhieuMuon);

                if (_phieuMuonHienTai == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

               
                var nhanViens = _context.NhanViens
                    .Select(nv => new
                    {
                        Id = nv.IdNhanVien,
                        Name = nv.TenNhanVien ?? $"NV{nv.IdNhanVien}"
                    })
                    .ToList();

                comboBoxNhanVien.DataSource = nhanViens;
                comboBoxNhanVien.DisplayMember = "Name";
                comboBoxNhanVien.ValueMember = "Id";
                comboBoxNhanVien.SelectedValue = _phieuMuonHienTai.IdNhanVien;
                comboBoxNhanVien.Enabled = false; 

                
                var theThanhViens = _context.TheThanhViens
                    .Include(tv => tv.DocGias)
                    .Select(tv => new
                    {
                        Id = tv.IdTheThanhVien,
                        Name = tv.DocGias != null
                            ? (tv.DocGias.TenDocGia ?? $"TV{tv.IdTheThanhVien}")
                            : $"TV{tv.IdTheThanhVien}"
                    })
                    .ToList();

                comboBoxThanhVien.DataSource = theThanhViens;
                comboBoxThanhVien.DisplayMember = "Name";
                comboBoxThanhVien.ValueMember = "Id";
                comboBoxThanhVien.SelectedValue = _phieuMuonHienTai.IdTheThanhVien;
                comboBoxThanhVien.Enabled = false; 

                dateTimePickerNgayMuon.Value = _phieuMuonHienTai.NgayMuon;
                dateTimePickerNgayMuon.Enabled = false;

                dateTimePickerHanTra.Value = _phieuMuonHienTai.NgayHenTra;
                dateTimePickerHanTra.Enabled = true; 

                var idBanSaoDangMuonTrongPhieu = _phieuMuonHienTai.ChiTietPhieuMuons
                    .Where(ct => ct.NgayTra == null)
                    .Select(ct => ct.IdBanSaoSach)
                    .ToList();

                var banSaoList = _context.BanSaoSachs
                    .Include(bs => bs.Sach)
                    .Where(bs => bs.TinhTrangSach == BanSaoSach.TinhTrangSachEnum.Tot
                                 || idBanSaoDangMuonTrongPhieu.Contains(bs.IdBanSaoSach))
                    .OrderBy(bs => bs.IdBanSaoSach)
                    .ToList();

                checkedListBoxSach.Items.Clear();

                foreach (var banSao in banSaoList)
                {
                    string tenSach = banSao.Sach?.TenSach ?? "Không rõ tên";
                    string display = $"{banSao.IdBanSaoSach} - {tenSach}";

                    bool isChecked = idBanSaoDangMuonTrongPhieu.Contains(banSao.IdBanSaoSach);

                    checkedListBoxSach.Items.Add(
                        new DisplayItem(banSao.IdBanSaoSach, display),
                        isChecked
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}\n\nStack trace: {ex.StackTrace}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private class DisplayItem
        {
            public string Id { get; set; }
            public string Display { get; set; }

            public DisplayItem(string id, string display)
            {
                Id = id;
                Display = display;
            }

            public override string ToString()
            {
                return Display;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var ngayHenTraMoi = dateTimePickerHanTra.Value.Date;

                if (ngayHenTraMoi <= _phieuMuonHienTai.NgayMuon)
                {
                    MessageBox.Show("Ngày hạn trả phải sau ngày mượn.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSachIdBanSao = new List<string>();
                foreach (var checkedItem in checkedListBoxSach.CheckedItems)
                {
                    if (checkedItem is DisplayItem displayItem)
                    {
                        danhSachIdBanSao.Add(displayItem.Id);
                    }
                }

                if (danhSachIdBanSao.Count == 0)
                {
                    MessageBox.Show("Độc giả phải mượn ít nhất 1 bản sao. Trong trường hợp hủy mượn vui lòng xóa phiếu mượn", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var phieuMuonUpdated = _phieuMuonService.SuaPhieuMuon(
                    _idPhieuMuon,
                    ngayHenTraMoi,
                    danhSachIdBanSao
                );

                MessageBox.Show($"Cập nhật phiếu mượn thành công (ID: {phieuMuonUpdated.IdPhieuMuon})",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể cập nhật phiếu mượn:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}