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

                    var dataView = phieuPhats
                        .Select(pp =>
                        {
                            var ctList = pp.ChiTietPhieuPhats ?? new List<ChiTietPhieuPhat>();
                            var tongTien = ctList.Sum(x => x.TienPhatTra);
                            var soDong = ctList.Count;
                            var docGia = ctList
                                .Select(x => x.ChiTietPhieuMuon?.PhieuMuon?.TheThanhVien?.DocGia?.TenDocGia)
                                .FirstOrDefault(n => !string.IsNullOrWhiteSpace(n)) ?? "Không rõ";

                            return new
                            {
                                IdPhieuPhat = pp.IdPhieuPhat,
                                NgayLap = pp.NgayLap,
                                DocGia = docGia,
                                SoChiTiet = soDong,
                                TongTienPhat = tongTien,
                                TrangThai = pp.TrangThai == PhieuPhat.TrangThaiEnum.DaThu ? "Đã thu" : "Chưa thu"
                            };
                        })
                        .OrderByDescending(x => x.NgayLap)
                        .ToList();

                    dgvPhat.AutoGenerateColumns = true;
                    dgvPhat.DataSource = dataView;

                    dgvPhat.Columns["IdPhieuPhat"].HeaderText = "Mã phiếu phạt";
                    dgvPhat.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgvPhat.Columns["DocGia"].HeaderText = "Độc giả";
                    dgvPhat.Columns["SoChiTiet"].HeaderText = "Số dòng phạt";
                    dgvPhat.Columns["TongTienPhat"].HeaderText = "Tổng tiền phạt";
                    dgvPhat.Columns["TrangThai"].HeaderText = "Trạng thái";

                    dgvPhat.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Format = "N0";
                    dgvPhat.Columns["TongTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvPhat.EnableHeadersVisualStyles = false;
                    dgvPhat.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                    dgvPhat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvPhat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
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

        }
    }
}
