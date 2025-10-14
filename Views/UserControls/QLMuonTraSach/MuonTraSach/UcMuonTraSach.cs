using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Views.UserControls.QLSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views.UserControls.QLMuonTraSach
{
    public partial class UcMuonTraSach : UserControl
    {
        private bool _isColumnConfigured = false;
        public UcMuonTraSach()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var pmRepo = new PhieuMuonRepository(context);
                    var pmService = new PhieuMuonService(pmRepo);

                    var pmList = pmService.GetAllPhieuMuon();

                    var pmDataView = pmList.Select(pm => new
                    {
                        IdPhieuMuon = pm.IdPhieuMuon,
                        TenNhanVien = pm.NhanVien != null ? pm.NhanVien.TenNhanVien : "Chưa có",
                        TenThanhVien = pm.TheThanhVien != null && pm.TheThanhVien.DocGia != null
                            ? pm.TheThanhVien.DocGia.TenDocGia
                            : "Chưa có",
                        NgayMuon = pm.NgayMuon.ToString("dd/MM/yyyy"),
                        NgayHenTra = pm.NgayHenTra.ToString("dd/MM/yyyy"),
                        TrangThai = pm.TrangThai.GetDisplayName()
                    }).ToList();

                    dgvPhieuMuonTra.DataSource = pmDataView;

                    // ===== Cấu hình các cột =====
                    if (!_isColumnConfigured)
                    {
                        dgvPhieuMuonTra.Columns.Clear();
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "IdPhieuMuon",
                            DataPropertyName = "IdPhieuMuon",
                            HeaderText = "Mã phiếu mượn"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TenNhanVien",
                            DataPropertyName = "TenNhanVien",
                            HeaderText = "Nhân viên"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TenThanhVien",
                            DataPropertyName = "TenThanhVien",
                            HeaderText = "Độc giả"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "NgayMuon",
                            DataPropertyName = "NgayMuon",
                            HeaderText = "Ngày mượn"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "NgayHenTra",
                            DataPropertyName = "NgayHenTra",
                            HeaderText = "Ngày hẹn trả"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewTextBoxColumn()
                        {
                            Name = "TrangThai",
                            DataPropertyName = "TrangThai",
                            HeaderText = "Trạng thái"
                        });
                        dgvPhieuMuonTra.Columns.Add(new DataGridViewButtonColumn
                        {
                            Name = "Tra",
                            HeaderText = "Trả sách",
                            Text = "Trả",
                            UseColumnTextForButtonValue = false
                        });

                        
                        // Cấu hình event
                        dgvPhieuMuonTra.CellClick += dgvPhieuMuonTra_CellClick!;
                        dgvPhieuMuonTra.CellFormatting += dgvPhieuMuonTra_CellFormatting!;

                        _isColumnConfigured = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu phiếu mượn\n[{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPhieuMuonTra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "Tra" && e.RowIndex >= 0)
            {
                string trangThai = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString() ?? "";

                if (trangThai.Equals("Đang mượn", StringComparison.OrdinalIgnoreCase))
                {
                    dgvPhieuMuonTra.Rows[e.RowIndex].Cells["Tra"].Value = "Trả";
                }
                else
                {
                    dgvPhieuMuonTra.Rows[e.RowIndex].Cells["Tra"].Value = "Hoàn tất";
                }
            }
        }

        private void dgvPhieuMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                if (dgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "Tra")
                {
                    var trangThai = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["TrangThai"].Value?.ToString();

                    // Nếu đã hoàn tất → không cho click
                    if (!string.Equals(trangThai, "Đang mượn", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Phiếu mượn này đã hoàn tất thủ tục trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Nếu đang mượn → mở form trả
                    var idValue = dgvPhieuMuonTra.Rows[e.RowIndex].Cells["IdPhieuMuon"].Value;
                    if (idValue == null) return;

                    int idPhieuMuon = Convert.ToInt32(idValue);
                    using (var formTraSach = new FormTraSach(idPhieuMuon))
                    {
                        if (formTraSach.ShowDialog(this) == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var formThemPhieuMuonTra = new FormThemPhieuMuonTra())
            {
                if (formThemPhieuMuonTra.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }  
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnListHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
