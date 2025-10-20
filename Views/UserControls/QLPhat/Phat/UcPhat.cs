using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLPhat;
using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Helpers;


namespace LibraryManagementSystem.Views.UserControls.QLPhat
{
    public partial class UcPhat : UserControl
    {
        //private readonly PhatService _phatService;
        public UcPhat()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // private void LoadData()
        // {
        //     try
        //     {
        //         using (var context = new LibraryDbContext())
        //         {
        //             var phieuPhats = context.PhieuPhats
        //                 .Include(pp => pp.ChiTietPhieuPhats!)
        //                     .ThenInclude(ct => ct.ChiTietPhieuMuon!)
        //                         .ThenInclude(ctpm => ctpm.PhieuMuon!)
        //                             .ThenInclude(pm => pm.TheThanhVien!)
        //                                 .ThenInclude(ttv => ttv.DocGia)
        //                 .AsNoTracking()
        //                 .ToList();

        //             var dataView = phieuPhats
        //                 .Select(pp => new
        //                 {
        //                     IdPhieuPhat = pp.IdPhieuPhat,
        //                     NgayLap = pp.NgayLap,
        //                     DocGia = pp.ChiTietPhieuPhats?.FirstOrDefault()?.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia ?? "Không rõ",
        //                     SoChiTiet = pp.ChiTietPhieuPhats?.Count ?? 0,
        //                     TienPhatPhaiNop = pp.TienPhatPhaiNop,
        //                     TrangThai = pp.TrangThai == PhieuPhat.TrangThaiEnum.DaThu ? "Đã thu" : "Chưa thu"
        //                 })
        //                 .OrderByDescending(x => x.NgayLap)
        //                 .ToList();

        //             dgvPhat.AutoGenerateColumns = true;
        //             dgvPhat.DataSource = dataView;

        //             dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
        //             dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
        //             dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
        //             dgvPhat.Columns["SoChiTiet"].HeaderText = "Số dòng phạt";
        //             dgvPhat.Columns["TienPhatPhaiNop"].HeaderText = "Tổng tiền phạt";
        //             dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

        //             dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        //             dgvPhat.Columns["TienPhatPhaiNop"].DefaultCellStyle.Format = "N0";
        //             dgvPhat.Columns["TienPhatPhaiNop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        //             dgvPhat.EnableHeadersVisualStyles = false;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show($"Không thể tải dữ liệu phiếu phạt\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }
        // }

        // private void LoadData()
        // {
        //     try
        //     {
        //         using (var context = new LibraryDbContext())
        //         {
        //             var phieuPhats = context.PhieuPhats
        //                 .Include(pp => pp.ChiTietPhieuPhats!)
        //                     .ThenInclude(ct => ct.ChiTietPhieuMuon!)
        //                         .ThenInclude(ctpm => ctpm.PhieuMuon!)
        //                             .ThenInclude(pm => pm.TheThanhVien!)
        //                                 .ThenInclude(ttv => ttv.DocGia)
        //                 .AsNoTracking()
        //                 .ToList();

        //             var dataView = phieuPhats
        //                 .Select(pp =>
        //                 {
        //                     var ctList = pp.ChiTietPhieuPhats ?? new List<ChiTietPhieuPhat>();
        //                     var tongTien = ctList.Sum(x => x.TienPhatTra);
        //                     var soDong = ctList.Count;
        //                     var docGia = ctList
        //                         .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
        //                         .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ";

        //                     return new
        //                     {
        //                         IdPhieuPhat = pp.IdPhieuPhat,
        //                         NgayLap = pp.NgayLap,
        //                         DocGia = docGia,
        //                         SoChiTiet = soDong,
        //                         TongTienPhat = tongTien,
        //                         TrangThai = pp.TrangThai == PhieuPhat.TrangThaiEnum.DaThu ? "Đã thu" : "Chưa thu"
        //                     };
        //                 })
        //                 .OrderByDescending(x => x.NgayLap)
        //                 .ToList();

        //             dgvPhat.AutoGenerateColumns = true;
        //             dgvPhat.DataSource = dataView;

        //             dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
        //             dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
        //             dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
        //             dgvPhat.Columns["SoChiTiet"].HeaderText = "Số dòng phạt";
        //             dgvPhat.Columns["TongTienPhat"].HeaderText = "Tổng tiền phạt";
        //             dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

        //             dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
        //             dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
        //             dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        //             dgvPhat.EnableHeadersVisualStyles = false;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //             dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show($"Không thể tải dữ liệu phiếu phạt\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //     }
        // }

        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var phieuPhats = context.PhieuPhats
                        .Include(pp => pp.ChiTietPhieuPhats!)
                            .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                                .ThenInclude(ctpm => ctpm.PhieuMuon!)
                                    .ThenInclude(pm => pm.TheThanhVien!)
                                        .ThenInclude(ttv => ttv.DocGia)
                        .AsNoTracking()
                        .ToList();

                    // Bỏ SoChiTiet, chỉ giữ các cột cần
                    var dataView = phieuPhats
                        .Select(pp => new
                        {
                            IdPhieuPhat = pp.IdPhieuPhat,
                            NgayLap = pp.NgayLap,
                            DocGia = pp.ChiTietPhieuPhats?
                                        .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
                                        .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ",
                            TongTienPhat = pp.ChiTietPhieuPhats?.Sum(x => x.TienPhatTra) ?? 0m,
                            TrangThai = pp.TrangThai.GetDisplayName()
                        })
                        .OrderByDescending(x => x.NgayLap)
                        .ToList();

                    dgvPhat.Columns.Clear(); // tránh giữ cột cũ
                    dgvPhat.AutoGenerateColumns = true;
                    dgvPhat.DataSource = dataView;

                    dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
                    dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
                    dgvPhat.Columns["TongTienPhat"].HeaderText = "Tổng tiền phạt";
                    dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

                    dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvPhat.EnableHeadersVisualStyles = false;
                    dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                    dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Thêm nút Thanh toán ở ngoài cùng
                    if (dgvPhat.Columns["ThanhToan"] == null)
                    {
                        var btnCol = new DataGridViewButtonColumn
                        {
                            Name = "ThanhToan",
                            HeaderText = "Thanh toán",
                            Text = "Thanh toán",
                            UseColumnTextForButtonValue = true,
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        };
                        dgvPhat.Columns.Add(btnCol);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu phạt\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuPhat = new FormThemPhieuPhat())
            {
                formThemPhieuPhat.ShowDialog(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu phạt để hủy.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvPhat.SelectedRows[0];
            var idValue = row.Cells["IdPhieuPhat"].Value;
            var trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";
            if (idValue == null)
            {
                MessageBox.Show("Không xác định được phiếu phạt.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.Equals(trangThai, "Chưa thu", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ có thể hủy phiếu phạt ở trạng thái Chưa thu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPhieuPhat = Convert.ToInt32(idValue);

            var confirm = MessageBox.Show("Bạn chắc chắn muốn hủy phiếu phạt này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var context = new LibraryDbContext())
                {
                    var repo = new PhieuPhatRepository(context);
                    var pp = repo.GetById(idPhieuPhat);
                    if (pp == null)
                    {
                        MessageBox.Show("Không tìm thấy phiếu phạt.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (pp.TrangThai != PhieuPhat.TrangThaiEnum.ChuaThu)
                    {
                        MessageBox.Show("Phiếu phạt không ở trạng thái Chưa thu.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    pp.TrangThai = PhieuPhat.TrangThaiEnum.DaHuy;
                    repo.Update(pp); // lưu trạng thái Hủy
                }

                MessageBox.Show("Đã hủy phiếu phạt.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hủy thất bại.\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            using (var formChiTietPhieuPhat = new FormChiTietPhieuPhat())
            {
                formChiTietPhieuPhat.ShowDialog(this);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvPhat.Columns[e.ColumnIndex].Name == "ThanhToan")
            {
                var idValue = dgvPhat.Rows[e.RowIndex].Cells["IdPhieuPhat"].Value;
                if (idValue == null) return;

                int idPhieuPhat = Convert.ToInt32(idValue);

                // Tạm thời báo; sau sẽ mở form thanh toán
                MessageBox.Show($"Thanh toán phiếu phạt #{idPhieuPhat} (sẽ implement sau).",
                    "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: mở form thanh toán:
                // using (var form = new FormTraPhat(idPhieuPhat)) { if (form.ShowDialog(this) == DialogResult.OK) LoadData(); }
            }
        }
    }
}
