using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using LMS.Repository;
using LMS.Services;
using LMS.Views.LMS.Services.Services;
using Microsoft.EntityFrameworkCore;

namespace LMS.Views.UserControls.QLMuonTraSach
{
    public partial class FormThemPhieuMuonTra : Form
    {
        private readonly BanSaoSachService _bssService;
        private readonly PhieuMuonService _phieuMuonService;
        private readonly TheThanhVienService _theThanhVienService;

        // Danh sách kết quả tìm kiếm
        private List<TheThanhVien> _danhSachTimKiem = new List<TheThanhVien>();

        // Thông tin nhân viên hiện tại
        private int _idNhanVienHienTai;
        private string _tenNhanVienHienTai = string.Empty;

        public FormThemPhieuMuonTra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var context = new LibraryDbContext();

            var ctpmRepo = new ChiTietPhieuMuonRepository(context);
            var pmRepo = new PhieuMuonRepository(context);
            var bssRepo = new BanSaoSachRepository(context);
            var ttvRepo = new TheThanhVienRepository(context);

            _bssService = new BanSaoSachService(bssRepo);
            _phieuMuonService = new PhieuMuonService(pmRepo, ctpmRepo, bssRepo);
            _theThanhVienService = new TheThanhVienService(context, ttvRepo);

            // Đăng ký sự kiện
            textBoxTimThanhVien.TextChanged += textBoxTimThanhVien_TextChanged;
            comboBoxThanhVien.SelectedIndexChanged += comboBoxThanhVien_SelectedIndexChanged;
        }

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadSach();
            InitializeThanhVienControls();

            // Set ngày hiện tại cho ngày mượn
            dateTimePickerNgayLap.Value = DateTime.Now;

            // Set ngày hẹn trả mặc định = ngày hiện tại + 14 ngày
            dateTimePickerNgayHenTra.Value = DateTime.Now.AddDays(14);

            // Lấy thông tin nhân viên hiện tại từ CurrentUserContext
            LoadNhanVienHienTai();
        }

        /// <summary>
        /// Lấy thông tin nhân viên hiện tại từ CurrentUserContext
        /// </summary>
        private void LoadNhanVienHienTai()
        {
            try
            {
                if (CurrentUserContext.CurrentUser == null)
                {
                    textBoxNhanVien.Text = "Chưa đăng nhập";
                    _idNhanVienHienTai = 0;
                    _tenNhanVienHienTai = string.Empty;
                    return;
                }

                var idTaiKhoan = CurrentUserContext.CurrentUser.IdTaiKhoan;

                // Tìm nhân viên từ tài khoản hiện tại
                var context = new LibraryDbContext();
                var nhanVien = context.NhanViens
                    .FirstOrDefault(nv => nv.IdTaiKhoan == idTaiKhoan);

                if (nhanVien != null)
                {
                    _idNhanVienHienTai = nhanVien.IdNhanVien;
                    _tenNhanVienHienTai = nhanVien.TenNhanVien ?? "N/A";
                    textBoxNhanVien.Text = _tenNhanVienHienTai;
                }
                else
                {
                    textBoxNhanVien.Text = "Không tìm thấy nhân viên";
                    _idNhanVienHienTai = 0;
                    _tenNhanVienHienTai = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin nhân viên: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNhanVien.Text = "Lỗi";
                _idNhanVienHienTai = 0;
                _tenNhanVienHienTai = string.Empty;
            }
        }

        /// <summary>
        /// Khởi tạo các control thành viên
        /// </summary>
        private void InitializeThanhVienControls()
        {
            comboBoxThanhVien.Items.Clear();
            comboBoxThanhVien.Items.Add("-- Nhập để tìm kiếm --");
            comboBoxThanhVien.SelectedIndex = 0;
            comboBoxThanhVien.Enabled = false;

            textBoxSDTThanhVien.Text = "";
            textBoxSDTThanhVien.ReadOnly = true;
        }

        /// <summary>
        /// Xử lý sự kiện tìm kiếm thành viên
        /// </summary>
        private void textBoxTimThanhVien_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimThanhVien.Text.Trim();

            // Reset
            comboBoxThanhVien.Items.Clear();
            textBoxSDTThanhVien.Text = "";
            _danhSachTimKiem.Clear();

            // Yêu cầu ít nhất 2 ký tự
            if (keyword.Length < 2)
            {
                comboBoxThanhVien.Items.Add("-- Nhập ít nhất 2 ký tự --");
                comboBoxThanhVien.SelectedIndex = 0;
                comboBoxThanhVien.Enabled = false;
                return;
            }

            try
            {
                // Gọi Service để tìm kiếm
                _danhSachTimKiem = _theThanhVienService.TimKiemThanhVien(keyword);

                if (_danhSachTimKiem.Count == 0)
                {
                    comboBoxThanhVien.Items.Add("-- Không tìm thấy --");
                    comboBoxThanhVien.SelectedIndex = 0;
                    comboBoxThanhVien.Enabled = false;
                }
                else
                {
                    foreach (var ttv in _danhSachTimKiem)
                    {
                        var docGia = ttv.DocGia;
                        var displayText = $"{docGia?.TenDocGia} - Mã: {ttv.IdTheThanhVien}";
                        comboBoxThanhVien.Items.Add(displayText);
                    }

                    comboBoxThanhVien.Enabled = true;

                    // Nếu chỉ có 1 kết quả, tự động chọn
                    if (_danhSachTimKiem.Count == 1)
                    {
                        comboBoxThanhVien.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện khi chọn thành viên trong ComboBox
        /// </summary>
        private void comboBoxThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThanhVien.SelectedIndex < 0 ||
                _danhSachTimKiem.Count == 0 ||
                comboBoxThanhVien.SelectedIndex >= _danhSachTimKiem.Count)
            {
                textBoxSDTThanhVien.Text = "";
                return;
            }

            // Lấy thành viên được chọn và cập nhật SĐT
            var thanhVienDuocChon = _danhSachTimKiem[comboBoxThanhVien.SelectedIndex];
            var docGia = thanhVienDuocChon.DocGia;
            textBoxSDTThanhVien.Text = docGia?.SDT ?? "Chưa có SĐT";
        }
        private void LoadSach()
        {
            // Tạo bảng thủ công
            dgvChonSach.Columns.Clear();
            dgvChonSach.AutoGenerateColumns = false;
            dgvChonSach.AllowUserToAddRows = false;

            dgvChonSach.Columns.Add("IdBanSaoSach", "Mã bản sao");
            dgvChonSach.Columns.Add("TenSach", "Tên sách");
            dgvChonSach.Columns.Add("TinhTrangSach", "Trạng thái");

            var colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "Chon";
            colCheck.HeaderText = "Chọn";
            dgvChonSach.Columns.Add(colCheck);

            // Chỉ lấy sách có tình trạng Tốt
            var bssTotList = _bssService.GetBanSaoSachByTinhTrang(BanSaoSach.TinhTrangSachEnum.Tot);
            // Thêm data cho bảng
            foreach (var bss in bssTotList)
            {
                dgvChonSach.Rows.Add(
                    bss.IdBanSaoSach,
                    bss.Sach!.TenSach,
                    bss.TinhTrangSach.GetDisplayName()
                );
            }

            // Chỉ cho nhập cột Chon
            foreach (DataGridViewColumn col in dgvChonSach.Columns)
            {
                if (col.Name != "Chon")
                    col.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn thành viên hợp lệ chưa
                if (comboBoxThanhVien.SelectedIndex < 0 ||
                    _danhSachTimKiem.Count == 0 ||
                    comboBoxThanhVien.SelectedIndex >= _danhSachTimKiem.Count)
                {
                    MessageBox.Show("Vui lòng tìm và chọn thành viên!",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra có nhân viên hợp lệ không
                if (_idNhanVienHienTai <= 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên. Vui lòng đăng nhập lại!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy ID thành viên từ danh sách đã chọn
                var thanhVienDuocChon = _danhSachTimKiem[comboBoxThanhVien.SelectedIndex];
                var idTheThanhVien = thanhVienDuocChon.IdTheThanhVien;

                var idNhanVien = _idNhanVienHienTai; // Lấy từ CurrentUserContext
                var ngayMuon = dateTimePickerNgayLap.Value;
                var ngayHenTra = dateTimePickerNgayHenTra.Value;

                // Lấy danh sách bản sao sách đã chọn
                var bssDaChonList = new List<string>();

                foreach (DataGridViewRow row in dgvChonSach.Rows)
                {
                    if (row.Cells["Chon"].Value is bool isChecked && isChecked)
                    {
                        bssDaChonList.Add(row.Cells["IdBanSaoSach"].Value.ToString()!);
                    }
                }

                if (!bssDaChonList.Any())
                {
                    MessageBox.Show("Vui lòng chọn ít nhất 1 sách để mượn!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo phiếu mượn
                var phieuMuon = new PhieuMuon
                {
                    IdNhanVien = idNhanVien,
                    IdTheThanhVien = idTheThanhVien,
                    NgayMuon = ngayMuon,
                    NgayHenTra = ngayHenTra,
                    TrangThai = PhieuMuon.TrangThaiEnum.DangMuon
                };

                // Xử lý thêm phiếu mượn và chi tiết phiếu mượn
                _phieuMuonService.AddPhieuMuon(phieuMuon, bssDaChonList);

                MessageBox.Show("Thêm phiếu mượn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Lỗi khi thêm phiếu mượn trả:");
                sb.AppendLine(ex.Message);

                if (ex.InnerException != null)
                {
                    sb.AppendLine("\n--- INNER EXCEPTION ---");
                    sb.AppendLine(ex.InnerException.Message);
                }

                if (ex.InnerException?.InnerException != null)
                {
                    sb.AppendLine("\n--- INNER INNER EXCEPTION ---");
                    sb.AppendLine(ex.InnerException.InnerException.Message);
                }

                MessageBox.Show(sb.ToString(), "Lỗi chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}