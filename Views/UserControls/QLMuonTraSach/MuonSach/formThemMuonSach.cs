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
    public partial class FormThemMuonSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly PhieuMuonService _phieuMuonService;
        private List<dynamic> _banSaoList = new();

        public FormThemMuonSach()
        {
            InitializeComponent();

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

                var banSaoList = _context.BanSaoSachs
                    .Include(bs => bs.Sach)
                    .Where(bs => bs.TinhTrangSach == BanSaoSach.TinhTrangSachEnum.Tot)
                    .Select(bs => new
                    {
                        Id = bs.IdBanSaoSach,
                        Display = $"{bs.IdBanSaoSach} - {(bs.Sach != null ? bs.Sach.TenSach : "")}"
                    })
                    .ToList();

                checkedListBoxSach.DataSource = null;
                checkedListBoxSach.Items.Clear();

                foreach (var item in banSaoList)
                {
                    checkedListBoxSach.Items.Add(new DisplayItem(item.Id, item.Display), false);
                }

                dateTimePickerNgayMuon.Value = DateTime.Now.Date;
                dateTimePickerHanTra.Value = DateTime.Now.Date.AddDays(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được dữ liệu lookup: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên lập phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (comboBoxThanhVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idNhanVien = Convert.ToInt32(comboBoxNhanVien.SelectedValue);
                var idTheThanhVien = Convert.ToInt32(comboBoxThanhVien.SelectedValue);
                var ngayMuon = dateTimePickerNgayMuon.Value.Date;
                var ngayHenTra = dateTimePickerHanTra.Value.Date;

                if (ngayHenTra <= ngayMuon)
                {
                    MessageBox.Show("Ngày hạn trả phải > ngày mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSachIdBanSao = new List<string>();
                foreach (var checkedItem in checkedListBoxSach.CheckedItems)
                {
                    var prop = checkedItem.GetType().GetProperty("Id");
                    if (prop != null)
                    {
                        var val = prop.GetValue(checkedItem);
                        if (val != null)
                        {
                            danhSachIdBanSao.Add(val.ToString()!);
                        }
                    }
                }

                if (danhSachIdBanSao.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 bản sao sách để mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var phieuMuonSaved = _phieuMuonService.TaoPhieuMuon(
                    idNhanVien,
                    idTheThanhVien,
                    ngayMuon,
                    ngayHenTra,
                    danhSachIdBanSao
                );

                MessageBox.Show($"Tạo phiếu mượn thành công (ID: {phieuMuonSaved.IdPhieuMuon})", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tạo phiếu mượn:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
