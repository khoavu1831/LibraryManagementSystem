using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Ngày", typeof(DateTime)); // Cột ngày để filter
            Random rand = new Random();
            int soLuongHang = 500; // THÊM: Tăng lên 500 hàng để dgv có nhiều dữ liệu hơn nữa, test scroll tốt hơn
            DateTime startDate = DateTime.Now.AddMonths(-6); // Fake data trong 6 tháng qua
            for (int i = 0; i < soLuongHang; i++)
            {
                // Random tên sách và thể loại từ list
                string tenSach = tenSachList[rand.Next(tenSachList.Length)] + $" ({i + 1})"; // Đa dạng + số thứ tự
                string theLoai = theLoaiList[rand.Next(theLoaiList.Length)];
                int soLuong = 0;
                if (loai == "Tổng số sách")
                {
                    soLuong = rand.Next(10, 100); // Nhiều sách
                }
                else if (loai == "Sách đang mượn")
                {
                    soLuong = rand.Next(0, 50); // Ít hơn
                }
                else if (loai == "Sách mất hoặc hư hỏng")
                {
                    soLuong = rand.Next(0, 5); // Rất ít
                }
                else if (loai == "Sách chưa mượn")
                {
                    soLuong = rand.Next(0, 30); // Trung bình
                }
                // Random ngày trong 6 tháng qua
                int daysOffset = rand.Next(0, 180); // 6 tháng ~180 ngày
                DateTime ngay = startDate.AddDays(daysOffset);
                dt.Rows.Add(tenSach, theLoai, soLuong, ngay);
            }
            // Filter theo ngày (dp_From to dp_To)
            DataView dv = new DataView(dt);
            dv.RowFilter = $"Ngày >= '{dp_From.Value:yyyy-MM-dd}' AND Ngày <= '{dp_To.Value:yyyy-MM-dd}'";
            DataTable dtFiltered = dv.ToTable();
            return dtFiltered; // Trả về data đã filter
        }

        // THÊM: Hàm tính tổng số lượng cho tất cả 4 loại (cho chart)
        private Dictionary<string, int> TinhTongTatCaLoai()
        {
            Dictionary<string, int> tongs = new Dictionary<string, int>();
            string[] cacLoai = { "Tổng số sách", "Sách đang mượn", "Sách mất hoặc hư hỏng", "Sách chưa mượn" };
            string[] tenCot = { "Tổng số lượng sách hiện có", "Số lượng sách mượn", "Số lượng sách mất hoặc hư hỏng", "Số lượng sách chưa mượn" };
            Random rand = new Random(); // Để seed giống nhau, nhưng thực tế có thể dùng data chung
            for (int i = 0; i < cacLoai.Length; i++)
            {
                DataTable dtLoai = TaoBangThongKe(cacLoai[i]); // Generate data riêng cho từng loại
                int tong = 0;
                foreach (DataRow row in dtLoai.Rows)
                {
                    tong += (int)row["Số lượng"];
                }
                tongs[tenCot[i]] = tong;
            }
            return tongs;
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