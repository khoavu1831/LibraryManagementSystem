using LMS.Views.LMS.Services.Services;
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS.Views.UserControls.QLThongKe.ThanhVien
{
    public partial class UcThanhVien : UserControl
    {
        private readonly ThongKeService _thongKeService;
        public UcThanhVien()
        {
            _thongKeService = new ThongKeService();
            InitializeComponent();
            dateTimePickerYear.MinDate = DateTime.MinValue;
            dateTimePickerYear.MaxDate = DateTime.MaxValue;
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
            LoadChart(DateTime.Now.Year);
        }
        private void LoadChart(int year)
        {
            var thongKeDict = _thongKeService.getTheThanhVienTheoNam(year);
            if (thongKeDict == null)
            {
                MessageBox.Show("không có dữ liệu", "Thông báo");
                return;
            }

            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.ChartAreas.Add(new ChartArea("MainArea"));
            chartThongKe.Titles.Add($"Thống kê thành viên theo quý - Năm {year}");

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
            chartThongKe.ChartAreas["MainArea"].AxisY.Title = "Số thành viên";
            chartThongKe.ChartAreas["MainArea"].AxisX.Interval = 1;
        }

        private void dateTimePickerYear_ValueChanged_1(object sender, EventArgs e)
        {
            LoadChart(dateTimePickerYear.Value.Year);

        }
    }
}
