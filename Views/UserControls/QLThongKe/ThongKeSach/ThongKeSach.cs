using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Nếu chưa có, cho chart advanced

namespace LMS.Views.Views.UserControls.QLThongKe.ThongKeSach
{
    public partial class ThongKeSach : UserControl
    {
        // List dữ liệu giả để đa dạng hóa
        private readonly string[] tenSachList = { "Lập trình C# Nâng cao", "Toán học Ứng dụng", "Vật lý Đại cương", "Lịch sử Việt Nam", "Kinh tế Học", "Machine Learning", "Web Development", "Thiết kế UI/UX", "An ninh Mạng", "Dữ liệu Lớn" };
        private readonly string[] theLoaiList = { "Giáo trình", "Khoa học", "Kỹ thuật", "Văn học", "Kinh tế", "Công nghệ", "Lịch sử", "Tâm lý" };

        public ThongKeSach()
        {
            InitializeComponent();
            dgvThongKe.ScrollBars = ScrollBars.Both; // bật scrollbar
            dgvThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvThongKe.RowTemplate.Height = 25; // Fixed row height để scroll mượt hơn
            dgvThongKe.AllowUserToResizeRows = false; // Tắt resize rows để giữ height consistent

            // SỬA: Set Dock.None + Anchor cơ bản, nhưng KHÔNG set Width/Height ở đây (di chuyển sang Load)
            dgvThongKe.Dock = DockStyle.None;
            dgvThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // THÊM: Event để update size khi panel5 resize
            if (panel5 != null) panel5.Resize += Panel5_Resize;
        }

        // THÊM: Handler cho resize panel5
        private void Panel5_Resize(object sender, EventArgs e)
        {
            if (panel5 != null)
            {
                dgvThongKe.Width = panel5.Width - 20; // Margin ngang
                dgvThongKe.Height = panel5.Height - 20; // Margin dọc
                dgvThongKe.Refresh(); // Force update scroll
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ThongKeSach_Load(object sender, EventArgs e)
        {
            // SỬA: Set size ở đây, sau layout hoàn tất
            if (panel5 != null)
            {
                dgvThongKe.Width = panel5.Width - 20;
                dgvThongKe.Height = panel5.Height - 20;
            }

            dp_From.Value = DateTime.Now.AddDays(-7);
            dp_To.Value = DateTime.Now;
            cbThongKe.Items.Add("Tổng số sách");
            cbThongKe.Items.Add("Sách đang mượn");
            cbThongKe.Items.Add("Sách mất hoặc hư hỏng");
            cbThongKe.Items.Add("Sách chưa mượn");
            cbThongKe.SelectedIndex = 0; // mặc định
            btnThongKe_Click(null, null);
        }

        // THÊM: Hàm tính tổng cho một loại cụ thể (giữ nguyên để dgv)
       
       private DataTable TaoBangThongKe(string loai)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("TenSach");
                dt.Columns.Add("TheLoai");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("Ngay");

                // luôn load kèm thể loại
                var sachList = db.Sachs
                                 .Include(s => s.TheLoais)
                                 .ToList();

                // ===== TỔNG SỐ SÁCH =====
                if (loai == "Tổng số sách")
                {
                    foreach (var s in sachList)
                    {
                        string theLoaiName = (s.TheLoais != null && s.TheLoais.Any())
                                            ? string.Join(", ", s.TheLoais.Select(t => t.TenTheloai))
                                            : "";

                        dt.Rows.Add(s.TenSach, theLoaiName, s.SoLuongBanSao, DateTime.Now);
                    }
                }

                // ===== SÁCH ĐANG MƯỢN =====
                else if (loai == "Sách đang mượn")
                {
                    var data = (from ct in db.ChiTietPhieuMuons
                                join pm in db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
                                join bss in db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
                                join s in sachList on bss.IdSach equals s.IdSach
                                where pm.TrangThai == PhieuMuon.TrangThaiEnum.DangMuon
                                select new { Sach = s, Ngay = pm.NgayMuon }).ToList();

                    foreach (var row in data)
                    {
                        string theLoaiName = (row.Sach.TheLoais != null && row.Sach.TheLoais.Any())
                                            ? string.Join(", ", row.Sach.TheLoais.Select(t => t.TenTheloai))
                                            : "";

                        dt.Rows.Add(row.Sach.TenSach, theLoaiName, 1, row.Ngay);
                    }
                }

                // ===== SÁCH MẤT / HƯ =====
                else if (loai == "Sách mất hoặc hư hỏng")
                {
                    var data = (from ct in db.ChiTietPhieuMuons
                                join pm in db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
                                join bss in db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
                                join s in sachList on bss.IdSach equals s.IdSach
                                where ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                                   || ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong
                                select new { Sach = s, Ngay = pm.NgayMuon }).ToList();

                    foreach (var row in data)
                    {
                        string theLoaiName = (row.Sach.TheLoais != null && row.Sach.TheLoais.Any())
                                            ? string.Join(", ", row.Sach.TheLoais.Select(t => t.TenTheloai))
                                            : "";

                        dt.Rows.Add(row.Sach.TenSach, theLoaiName, 1, row.Ngay);
                    }
                }

                // ===== SÁCH CHƯA MƯỢN =====
                else if (loai == "Sách chưa mượn")
                {
                    var sachDaMuonIds = (from ct in db.ChiTietPhieuMuons
                                         join bss in db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
                                         select bss.IdSach).Distinct().ToList();

                    var data = sachList.Where(s => !sachDaMuonIds.Contains(s.IdSach)).ToList();

                    foreach (var s in data)
                    {
                        string theLoaiName = (s.TheLoais != null && s.TheLoais.Any())
                                            ? string.Join(", ", s.TheLoais.Select(t => t.TenTheloai))
                                            : "";

                        dt.Rows.Add(s.TenSach, theLoaiName, s.SoLuongBanSao, DateTime.Now);
                    }
                }

                return dt;
            }
        }

        // THÊM: Hàm tính tổng số lượng cho tất cả 4 loại (cho chart)
        private Dictionary<string, int> TinhTongTatCaLoai()
        {
            using (var db = new LibraryDbContext())
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                // 1. Tổng số sách (tổng tất cả bản sao)
                int tongSach = db.Sachs.Sum(s => s.SoLuongBanSao);
                result["Tổng số lượng sách hiện có"] = tongSach;

                // 2. Sách đang mượn
                int sachDangMuon =
                    (from ct in db.ChiTietPhieuMuons
                     join pm in db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
                     where pm.TrangThai == PhieuMuon.TrangThaiEnum.DangMuon
                           && ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra
                     select ct.IdChiTietPhieuMuon)
                    .Count();

                result["Số lượng sách đang mượn"] = sachDangMuon;

                // 3. Sách mất hoặc hư hỏng
                int sachMatHuHong =
                    (from ct in db.ChiTietPhieuMuons
                     where ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                        || ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong
                     select ct.IdChiTietPhieuMuon)
                    .Count();

                result["Số lượng sách mất hoặc hư hỏng"] = sachMatHuHong;

                // 4. Sách chưa mượn = tổng bản sao – bản sao đang mượn
                int chuaMuon = tongSach - sachDangMuon;
                if (chuaMuon < 0) chuaMuon = 0;

                result["Số lượng sách chưa mượn"] = chuaMuon;

                return result;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cbThongKe.SelectedItem.ToString();
            DataTable dt = TaoBangThongKe(loai); // dgv vẫn show detail của loại được chọn
            dgvThongKe.DataSource = dt;
            // Auto resize cột FULL chiều rộng
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // SỬA: Thêm Suspend/Resume để tránh flicker khi load data lớn
            dgvThongKe.SuspendLayout();
            dgvThongKe.Refresh();
            dgvThongKe.FirstDisplayedScrollingRowIndex = 0; // Scroll về đầu để test dễ
            dgvThongKe.ResumeLayout();
            // THÊM: Force visible để trigger scroll nếu cần
            dgvThongKe.Visible = false;
            dgvThongKe.Visible = true;

            // THÊM: Chart với 4 cột (tổng cho từng loại)
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();
            // Title động (giữ nguyên, nhưng giờ chart luôn 4 loại)
            string title = $"Thống kê sách từ {dp_From.Value:dd/MM} đến {dp_To.Value:dd/MM}";
            chartThongKe.Titles.Add(title).Font = new Font("Arial", 12, FontStyle.Bold);
            // Tính tổng cho tất cả 4 loại
            var tongs = TinhTongTatCaLoai();
            // Tạo 4 series, mỗi cái một cột
            string[] mauSac = { "Blue", "Green", "Red", "Orange" }; // Màu fixed cho từng loại
            int index = 0;
            foreach (var kvp in tongs)
            {
                var series = chartThongKe.Series.Add(kvp.Key); // Tên series = Tên loại
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY("Số lượng", kvp.Value); // X chung = "Số lượng", Y = Tổng
                // Màu fixed
                series.Color = Color.FromName(mauSac[index % mauSac.Length]);
                index++;
                // Tooltip
                series.ToolTip = $"{kvp.Key}: {kvp.Value} sách";
            }
            // Cấu hình Chart chung (đơn giản hóa vì chỉ 1 X category)
            chartThongKe.ChartAreas[0].AxisX.Title = "";
            chartThongKe.ChartAreas[0].AxisY.Title = "Số lượng sách";
            chartThongKe.Legends[0].Enabled = true; // Bật Legend
            chartThongKe.Legends[0].Docking = Docking.Bottom; // Đặt legend dưới chart
            // Optional: Nếu muốn Pie, thay ChartType = SeriesChartType.Pie và X = "" (tự động label từ series name)
        }
    }
}