using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach.TraSach
{
    public partial class FormSuaTraSach : Form
    {
        private readonly LibraryDbContext _context;
        private readonly ChiTietPhieuMuonRepository _chiTietRepo;
        private ChiTietPhieuMuon? _chiTiet;

        public FormSuaTraSach()
        {
            InitializeComponent();
            _context = new LibraryDbContext();
            _chiTietRepo = new ChiTietPhieuMuonRepository(_context);
        }

        public void SetChiTietId(int idChiTietPhieuMuon)
        {
            _chiTiet = _chiTietRepo.GetById(idChiTietPhieuMuon);
            if (_chiTiet == null)
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            textBoxIdPhieuMuon.Text = _chiTiet.IdPhieuMuon.ToString();
            textBoxIdChiTiet.Text = _chiTiet.IdChiTietPhieuMuon.ToString();
            textBoxIdBanSao.Text = _chiTiet.IdBanSaoSach.ToString();
            textBoxTenSach.Text = _chiTiet.BanSaoSach?.Sach?.TenSach ?? "(Không có dữ liệu)";
            dateTimePickerNgayTra.Value = _chiTiet.NgayTra ?? DateTime.Now;

            comboBoxTinhTrang.SelectedItem = _chiTiet.TinhTrangTra switch
            {
                ChiTietPhieuMuon.TinhTrangTraEnum.Tot => "Tốt",
                ChiTietPhieuMuon.TinhTrangTraEnum.HuHong => "Hư hỏng",
                ChiTietPhieuMuon.TinhTrangTraEnum.Mat => "Mất",
                _ => "Tốt"
            };
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_chiTiet == null)
            {
                MessageBox.Show("Không có dữ liệu chi tiết để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tinhTrangStr = comboBoxTinhTrang.SelectedItem?.ToString() ?? "Tốt";
                var tinhTrang = tinhTrangStr switch
                {
                    "Tốt" => ChiTietPhieuMuon.TinhTrangTraEnum.Tot,
                    "Hư hỏng" => ChiTietPhieuMuon.TinhTrangTraEnum.HuHong,
                    "Mất" => ChiTietPhieuMuon.TinhTrangTraEnum.Mat,
                    _ => ChiTietPhieuMuon.TinhTrangTraEnum.Tot
                };

                _chiTiet.NgayTra = dateTimePickerNgayTra.Value;
                _chiTiet.TinhTrangTra = tinhTrang;
                _chiTietRepo.Update(_chiTiet);

                var banSao = _context.BanSaoSachs.FirstOrDefault(bs => bs.IdBanSaoSach == _chiTiet.IdBanSaoSach);
                if (banSao != null)
                {
                    banSao.TinhTrangSach = tinhTrang switch
                    {
                        ChiTietPhieuMuon.TinhTrangTraEnum.Tot => BanSaoSach.TinhTrangSachEnum.Tot,
                        ChiTietPhieuMuon.TinhTrangTraEnum.HuHong => BanSaoSach.TinhTrangSachEnum.Hong,
                        ChiTietPhieuMuon.TinhTrangTraEnum.Mat => BanSaoSach.TinhTrangSachEnum.Mat,
                        _ => BanSaoSach.TinhTrangSachEnum.Tot
                    };

                    _context.BanSaoSachs.Update(banSao);
                    _context.SaveChanges();
                }

                MessageBox.Show("Cập nhật thông tin trả sách thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
