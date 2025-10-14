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
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach
{
    public partial class FormTraSach : Form
    {
        private readonly BanSaoSachService _bssService;
        private readonly PhieuMuonService _phieuMuonService;
        private int _idPhieuMuon;

        public FormTraSach(int idPhieuMuon)
        {
            InitializeComponent();
            _idPhieuMuon = idPhieuMuon;

            var context = new LibraryDbContext();
            var bssRepo = new BanSaoSachRepository(context);
            var pmRepo = new PhieuMuonRepository(context);

            _bssService = new BanSaoSachService(bssRepo);
            _phieuMuonService = new PhieuMuonService(pmRepo);
        }
        private void FormTraSach_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void LoadSach()
        {
            // Cấu hình DataGridView
            dgvChiTietMuon.Columns.Clear();
            dgvChiTietMuon.AutoGenerateColumns = false;
            dgvChiTietMuon.AllowUserToAddRows = false;

            // ===== Các cột hiển thị =====
            dgvChiTietMuon.Columns.Add("IdChiTietPhieuMuon", "ID CTPM");
            dgvChiTietMuon.Columns["IdChiTietPhieuMuon"].Visible = false;

            dgvChiTietMuon.Columns.Add("IdBanSaoSach", "Mã bản sao");
            dgvChiTietMuon.Columns.Add("TenSach", "Tên sách");
            dgvChiTietMuon.Columns.Add("NgayMuon", "Ngày mượn");
            dgvChiTietMuon.Columns.Add("NgayHenTra", "Ngày hẹn trả");
            dgvChiTietMuon.Columns.Add("TinhTrangSach", "Tình trạng hiện tại");

            // Cột combo chọn tình trạng khi trả
            var colTinhTrangTra = new DataGridViewComboBoxColumn
            {
                Name = "TinhTrangTra",
                HeaderText = "Tình trạng trả"
            };
            colTinhTrangTra.Items.AddRange("Tốt", "Hỏng", "Mất");
            dgvChiTietMuon.Columns.Add(colTinhTrangTra);

            // Cột chọn checkbox
            var colCheck = new DataGridViewCheckBoxColumn
            {
                Name = "Chon",
                HeaderText = "Trả"
            };
            dgvChiTietMuon.Columns.Add(colCheck);

            // ===== Lấy dữ liệu phiếu mượn =====
            var phieuMuon = _phieuMuonService.GetPhieuMuonChiTiet(_idPhieuMuon);
            if (phieuMuon == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Hiển thị thông tin chung
            textBoxDocGia.Text = phieuMuon.TheThanhVien?.DocGia?.TenDocGia ?? "Không xác định";
            textBoxNgayMuon.Text = phieuMuon.NgayMuon.ToString("dd/MM/yyyy");
            textBoxNgayHenTra.Text = phieuMuon.NgayHenTra.ToString("dd/MM/yyyy");

            // ===== Thêm dữ liệu vào bảng =====
            dgvChiTietMuon.Rows.Clear();

            foreach (var ct in phieuMuon.ChiTietPhieuMuons!.Where(x => x.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
            {
                dgvChiTietMuon.Rows.Add(
                    ct.IdChiTietPhieuMuon,
                    ct.BanSaoSach?.IdBanSaoSach ?? "",
                    ct.BanSaoSach?.Sach?.TenSach ?? "Không rõ",
                    phieuMuon.NgayMuon.ToString("dd/MM/yyyy"),
                    phieuMuon.NgayHenTra.ToString("dd/MM/yyyy"),
                    ct.BanSaoSach?.TinhTrangSach.ToString() ?? "Không rõ",
                    "Tốt", // mặc định khi trả
                    false  // chưa chọn
                );
            }

            // Chỉ cho chỉnh cột TinhTrangTra và Chon
            foreach (DataGridViewColumn col in dgvChiTietMuon.Columns)
            {
                col.ReadOnly = !(col.Name == "TinhTrangTra" || col.Name == "Chon");
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool daTra = false;

            foreach (DataGridViewRow row in dgvChiTietMuon.Rows)
            {
                bool chon = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (!chon) continue;

                int idCTPM = Convert.ToInt32(row.Cells["IdChiTietPhieuMuon"].Value);
                string tinhTrangTra = row.Cells["TinhTrangTra"].Value?.ToString() ?? "Tốt";

                _phieuMuonService.TraSach(idCTPM, tinhTrangTra);
                daTra = true;
            }

            if (daTra)
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}