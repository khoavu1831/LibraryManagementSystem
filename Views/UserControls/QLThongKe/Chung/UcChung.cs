using LMS.Views.LMS.Services.Services;
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS.Views.UserControls.QLThongKe.Chung
{
    public partial class UcChung : UserControl
    {
        private readonly ThongKeService _thongKeService;
        public UcChung()
        {
            _thongKeService = new ThongKeService();
            InitializeComponent();

            dateTimePickerYear.MinDate = DateTime.MinValue;
            dateTimePickerYear.MaxDate = DateTime.MaxValue;
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
            loadData(DateTime.Now.Year);
        }

        public void loadData(int year)
        {
            var thongKeDict = _thongKeService.getSoTienPhatTheoNam(year);
            if (thongKeDict == null)
            {
                MessageBox.Show("Không có dữ liệu, thông báo");
                return;
            }
            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.ChartAreas.Add(new ChartArea("MainArea"));
            chartThongKe.Titles.Add($"Thống kê tiền phạt theo quý - Năm {year}");

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
            chartThongKe.ChartAreas["MainArea"].AxisY.Title = "Số tiền phạt";
            chartThongKe.ChartAreas["MainArea"].AxisX.Interval = 1;
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            loadData(dateTimePickerYear.Value.Year);
        }
    }
}
