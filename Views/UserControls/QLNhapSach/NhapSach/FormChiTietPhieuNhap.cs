using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Entities;
using LMS.Helpers;
using Microsoft.EntityFrameworkCore;

namespace LMS.Views.UserControls.QLNhapSach.NhapSach
{
    public partial class FormChiTietPhieuNhap : Form
    {
        private readonly int _idPhieuNhap;

        public FormChiTietPhieuNhap(int idPhieuNhap)
        {
            InitializeComponent();
            _idPhieuNhap = idPhieuNhap;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += FormChiTietPhieuNhap_Load;
        }

        private void FormChiTietPhieuNhap_Load(object? sender, EventArgs e)
        {
            try
            {
                ConfigureControls();
                LoadHeader();
                LoadDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cấu hình các controls
        /// </summary>
        private void ConfigureControls()
        {
            // Set read-only cho các textboxes
            textBoxMaPhieuNhap.ReadOnly = true;
            textBoxLoaiPhieuNhap.ReadOnly = true;
            textBoxNhaCungCap.ReadOnly = true;
            textBoxNhanVien.ReadOnly = true;
            textBoxTongTien.ReadOnly = true;

            // Disable DateTimePicker
            dateTimePickerNgayNhap.Enabled = false;

            // Set background cho read-only fields
            textBoxMaPhieuNhap.BackColor = Color.WhiteSmoke;
            textBoxLoaiPhieuNhap.BackColor = Color.WhiteSmoke;
            textBoxNhaCungCap.BackColor = Color.WhiteSmoke;
            textBoxNhanVien.BackColor = Color.WhiteSmoke;
            textBoxTongTien.BackColor = Color.WhiteSmoke;

            // Configure DataGridView
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.EnableHeadersVisualStyles = false;
            
            // Style cho header
            dgvDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // Style cho cells
            dgvDanhSach.DefaultCellStyle.Font = new Font("Segoe UI", 9.75f);
            dgvDanhSach.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvDanhSach.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>
        /// Load thông tin header (phiếu nhập)
        /// </summary>
        private void LoadHeader()
        {
            using (var ctx = new LibraryDbContext())
            {
                var pn = ctx.PhieuNhaps
                    .Include(x => x.NhanVien)
                    .Include(x => x.NCC)
                    .AsNoTracking()
                    .FirstOrDefault(x => x.IdPhieuNhap == _idPhieuNhap);

                if (pn == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // Gán giá trị cho các controls
                textBoxMaPhieuNhap.Text = pn.IdPhieuNhap.ToString();
                textBoxLoaiPhieuNhap.Text = pn.LoaiPhieuNhap.GetDisplayName();
                textBoxNhaCungCap.Text = pn.NCC?.TenNCC ?? "N/A";
                dateTimePickerNgayNhap.Value = pn.NgayNhap;
                textBoxNhanVien.Text = pn.NhanVien?.TenNhanVien ?? "N/A";
                textBoxTongTien.Text = pn.TongTienNhap.ToString("N0") + " VNĐ";
            }
        }

        /// <summary>
        /// Load chi tiết các sách đã nhập
        /// </summary>
        private void LoadDetails()
        {
            using (var ctx = new LibraryDbContext())
            {
                var data = ctx.ChiTietPhieuNhaps
                    .Include(ct => ct.Sach!)
                        .ThenInclude(s => s.TacGias)
                    .AsNoTracking()
                    .Where(ct => ct.IdPhieuNhap == _idPhieuNhap)
                    .Select(ct => new
                    {
                        IdChiTiet = ct.IdChiTietPhieuNhap,
                        MaSach = ct.Sach!.IdSachFormat ?? "N/A",
                        TenSach = ct.Sach!.TenSach ?? "N/A",
                        TacGia = ct.Sach!.TacGias != null && ct.Sach.TacGias.Any()
                            ? ct.Sach.TacGias.First().TenTacGia ?? "N/A"
                            : "N/A",
                        SoLuong = ct.SoLuong,
                        GiaTien = ct.GiaTien,
                        ThanhTien = ct.SoLuong * ct.GiaTien
                    })
                    .OrderBy(x => x.IdChiTiet)
                    .ToList();

                dgvDanhSach.Columns.Clear();
                dgvDanhSach.AutoGenerateColumns = false;

                // Cấu hình các cột
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MaSach",
                    DataPropertyName = "MaSach",
                    HeaderText = "Mã sách",
                    Width = 100
                });
                
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TenSach",
                    DataPropertyName = "TenSach",
                    HeaderText = "Tên sách",
                    Width = 250,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TacGia",
                    DataPropertyName = "TacGia",
                    HeaderText = "Tác giả",
                    Width = 150
                });
                
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SoLuong",
                    DataPropertyName = "SoLuong",
                    HeaderText = "Số lượng",
                    Width = 80,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = "N0"
                    }
                });
                
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "GiaTien",
                    DataPropertyName = "GiaTien",
                    HeaderText = "Đơn giá",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = "N0"
                    }
                });
                
                dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ThanhTien",
                    DataPropertyName = "ThanhTien",
                    HeaderText = "Thành tiền",
                    Width = 130,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = "N0"
                    }
                });

                dgvDanhSach.DataSource = data;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Empty event handler từ Designer
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty event handler từ Designer
        }
    }
}
