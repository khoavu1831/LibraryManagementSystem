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

namespace LMS.Views.UserControls.QLMuonTraSach
{
    public partial class FormThemPhieuMuonTra : Form
    {
        private readonly BanSaoSachService _bssService;
        private readonly PhieuMuonService _phieuMuonService;

        public FormThemPhieuMuonTra()
        {
            InitializeComponent();

            var context = new LibraryDbContext();

            var ctpmRepo = new ChiTietPhieuMuonRepository(context);
            var pmRepo = new PhieuMuonRepository(context);
            var bssRepo = new BanSaoSachRepository(context);

            _bssService = new BanSaoSachService(bssRepo);
            _phieuMuonService = new PhieuMuonService(pmRepo, ctpmRepo, bssRepo);
        }

        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadSach();
            LoadThanhVien();
            textBoxNhanVien.Text = "Nhan vien hien tai ne/ Sau phai assign cho nay";
        }
        private void LoadThanhVien()
        {
            comboBoxThanhVien.Items.Add("Nguyen Van GiaLap");
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
                if (comboBoxThanhVien.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn thành viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin từ form
                var idTheThanhVien = 1; // Tạm thời hardcode, sau này lấy từ comboBox
                var idNhanVien = 1; // Tạm thời hardcode, sau này lấy từ thông tin đăng nhập
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
    }
}