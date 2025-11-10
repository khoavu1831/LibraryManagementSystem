using LMS.Views.LMS.Services.Services;
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS.Views.UserControls.QLThongKe.SachNhap
{
    public partial class UcSachNhap : UserControl
    {
        private readonly ThongKeService _thongKeService;

        public UcSachNhap()
        {
            _thongKeService = new ThongKeService();
            InitializeComponent();
            dateTimePickerYear.MinDate = DateTime.MinValue; // min 1753
            dateTimePickerYear.MaxDate = DateTime.MaxValue; // max 9998
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy"; // chỉ hiển thị năm
            dateTimePickerYear.ShowUpDown = true;      // để chỉ tăng giảm năm
            LoadChart(DateTime.Now.Year);
        }
        private void LoadChart(int year)
        {
            var thongKeDict = _thongKeService.getSachNhapTheoNam(year);
            if (thongKeDict == null)
            {
                MessageBox.Show("không có dữ liệu", "Thông báo");
                return;
            }

            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.ChartAreas.Add(new ChartArea("MainArea"));
            chartThongKe.Titles.Add($"Thống kê sách nhập theo quý - Năm {year}");

            var series = new Series("Số lượng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                ChartArea = "MainArea",
                IsXValueIndexed = true
            };

            chartThongKe.Series.Add(series);

            foreach (var item in thongKeDict)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chartThongKe.ChartAreas["MainArea"].AxisX.Title = "Quý";
            chartThongKe.ChartAreas["MainArea"].AxisY.Title = "Số sách nhập";
            chartThongKe.ChartAreas["MainArea"].AxisX.Interval = 1;
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            LoadChart(dateTimePickerYear.Value.Year);
        }
    }
}
