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

namespace LMS.Views.UserControls.QLNhapSach
{
    public partial class FormThemPhieuNhap : Form
    {
        private readonly SachService _sachService;
        private readonly NCCService _nccService;
        private readonly PhieuNhapService _phieuNhapService;
        private int _idNhanVienHienTai;

        public FormThemPhieuNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            var context = new LibraryDbContext();

            var sachRepo = new SachRepository(context);
            var nccRepo = new NCCRepository(context);
            var pnRepo = new PhieuNhapRepository(context);
            var ctpnRepo = new ChiTietPhieuNhapRepository(context);
            var bssRepo = new BanSaoSachRepository(context);

            _sachService = new SachService(sachRepo);
            _nccService = new NCCService(nccRepo);
            _phieuNhapService = new PhieuNhapService(pnRepo, ctpnRepo, bssRepo, sachRepo);


        }

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadLoaiPhieuNhap();
            LoadNCC();
            LoadSach();
            LoadNhanVienHienTai();

            dateTimePickerNgayNhap.Value = DateTime.Now;
        }

        private void LoadNhanVienHienTai()
        {
            try
            {
                if (CurrentUserContext.CurrentUser == null)
                {
                    textBoxNhanVien.Text = "Chưa đăng nhập";
                    _idNhanVienHienTai = 0;
                    return;
                }

                var idTaiKhoan = CurrentUserContext.CurrentUser.IdTaiKhoan;

                // Tìm nhân viên từ tài khoản hiện tại
                using (var context = new LibraryDbContext())
                {
                    var nhanVien = context.NhanViens
                        .FirstOrDefault(nv => nv.IdTaiKhoan == idTaiKhoan);

                    if (nhanVien != null)
                    {
                        _idNhanVienHienTai = nhanVien.IdNhanVien;
                        textBoxNhanVien.Text = nhanVien.TenNhanVien ?? "N/A";
                    }
                    else
                    {
                        textBoxNhanVien.Text = "Không tìm thấy nhân viên";
                        _idNhanVienHienTai = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                textBoxNhanVien.Text = $"Lỗi: {ex.Message}";
                _idNhanVienHienTai = 0;
            }
        }
        private void LoadLoaiPhieuNhap()
        {
            var loaiPhieuNhapList = Enum.GetValues(typeof(PhieuNhap.LoaiPhieuNhapEnum))
                .Cast<PhieuNhap.LoaiPhieuNhapEnum>()
                .Select(e => new { Value = e, Display = e.GetDisplayName() })
                .ToList();

            comboBoxLoaiPN.DataSource = loaiPhieuNhapList;
            comboBoxLoaiPN.DisplayMember = "Display";
            comboBoxLoaiPN.ValueMember = "Value";
        }
        private void LoadNCC()
        {
            var nccList = _nccService.GetAllNCC();
            nccList.ForEach(ncc => comboBoxNCC.Items.Add(ncc.TenNCC!));
        }
        private void LoadSach()
        {
            var sachList = _sachService.GetAllSach();

            // Tạo bảng thủ công
            dgvChonSach.Columns.Clear();
            dgvChonSach.AutoGenerateColumns = false;
            dgvChonSach.AllowUserToAddRows = false;

            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdSach";
            colId.HeaderText = "IdSach";
            colId.Visible = false; // Ẩn cột thật
            dgvChonSach.Columns.Add(colId);

            dgvChonSach.Columns.Add("IdSachFormat", "Mã sách");
            dgvChonSach.Columns.Add("TenSach", "Sách");
            dgvChonSach.Columns.Add("GiaSach", "Giá sách");
            dgvChonSach.Columns.Add("SoLuongTon", "Số lượng tồn");

            var colNhap = new DataGridViewTextBoxColumn();
            colNhap.Name = "SoLuongNhap";
            colNhap.HeaderText = "Số lượng nhập";
            dgvChonSach.Columns.Add(colNhap);

            var colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "Chon";
            colCheck.HeaderText = "Chọn";
            dgvChonSach.Columns.Add(colCheck);

            // Thêm data cho bảng
            foreach (var sach in sachList)
            {
                dgvChonSach.Rows.Add(
                    sach.IdSach,
                    sach.IdSachFormat,
                    sach.TenSach,
                    sach.GiaTien,
                    sach.SoLuongBanSao,
                    0,
                    false
                );
            }

            // Chỉ cho nhập cột SoLuongNhap và check cột Chon
            foreach (DataGridViewColumn col in dgvChonSach.Columns)
            {
                if (col.Name != "SoLuongNhap" && col.Name != "Chon")
                    col.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboBoxNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp.");
                return;
            }
            var loaiPhieuNhap = comboBoxLoaiPN.SelectedValue;

            var ncc = _nccService.GetAllNCC().FirstOrDefault(n => n.TenNCC == comboBoxNCC.SelectedItem!.ToString());
            var ngayNhap = DateTime.Now;

            var selectedSachs = new List<(int IdSach, int SoLuong, decimal GiaTien)>();

            foreach (DataGridViewRow row in dgvChonSach.Rows)
            {
                if (row.IsNewRow) continue;

                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value ?? false);

                if (chon)
                {
                    string soLuongNhapString = row.Cells["SoLuongNhap"].Value?.ToString() ?? "0";

                    if (!Regex.IsMatch(soLuongNhapString, @"^\d+$"))
                    {
                        MessageBox.Show($"Số lượng nhập không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int soLuongNhap = Convert.ToInt32(soLuongNhapString);

                    if (soLuongNhap <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0 cho sách đã chọn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idSach = Convert.ToInt32(row.Cells["IdSach"].Value);
                    decimal giaTien = Convert.ToDecimal(row.Cells["GiaSach"].Value);

                    selectedSachs.Add((idSach, soLuongNhap, giaTien));
                }
            }

            if (selectedSachs.Count == 0)
            {
                MessageBox.Show("Chưa chọn sách nào để nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tính tổng số lượng và tổng tiền
            int tongSL = selectedSachs.Sum(x => x.SoLuong);
            decimal tongTien = selectedSachs.Sum(x => x.SoLuong * x.GiaTien);

            // Lưu phiếu nhập
            var phieuNhap = new PhieuNhap
            {
                IdNCC = ncc!.IdNCC,
                NgayNhap = ngayNhap,
                SoLuongSach = tongSL,
                LoaiPhieuNhap = (PhieuNhap.LoaiPhieuNhapEnum)loaiPhieuNhap!,
                TongTienNhap = tongTien,
                IdNhanVien = _idNhanVienHienTai != 0 ? _idNhanVienHienTai : 1,
                TrangThai = PhieuNhap.TrangThaiEnum.DangHoatDong
            };

            _phieuNhapService.AddPhieuNhap(phieuNhap, selectedSachs);

            MessageBox.Show("Thêm sách thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dateTimePickerNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}