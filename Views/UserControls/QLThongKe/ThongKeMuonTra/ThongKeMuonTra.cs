using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS.Views.Views.UserControls.QLThongKe.ThongKeMuonTra
{
    public partial class ThongKeMuonTra : UserControl
    {
        public ThongKeMuonTra()
        {
            InitializeComponent();
            cbLoaiThongKe.Items.Add("Theo ngày");
            cbLoaiThongKe.Items.Add("Theo tháng");
            cbLoaiThongKe.Items.Add("Theo quý");
            cbLoaiThongKe.Items.Add("Theo năm");
            cbLoaiThongKe.SelectedIndex = 0;
            // Event cho cbLoaiThongKe
            cbLoaiThongKe.SelectedIndexChanged += cbLoaiThongKe_SelectedIndexChanged;
            // Event cho filter controls: khi thay đổi, load data
            dp_From.ValueChanged += (s, e) => LoadFakeData();
            dp_To.ValueChanged += (s, e) => LoadFakeData();
            numericUpDown1.ValueChanged += (s, e) => LoadFakeData();
            numericUpDown2.ValueChanged += (s, e) => LoadFakeData();
            comboBox2.SelectedIndexChanged += (s, e) => LoadFakeData();
            numericUpDown3.ValueChanged += (s, e) => LoadFakeData();
            numericUpDown4.ValueChanged += (s, e) => LoadFakeData();
            // BẬT AutoScroll cho UserControl để có thể scroll toàn bộ nếu cần (nhưng ưu tiên scroll DGV)
            this.AutoScroll = true;
            // Cho phép scroll ngang và dọc cho DataGridView
            dataGridView1.ScrollBars = ScrollBars.Both;
            // Anchor DGV để fill đầy panel3 (hỗ trợ resize)
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Load data lần đầu
            LoadFakeData();
        }

        private void cbLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelNgay.Visible = false;
            panelThang.Visible = false;
            panelQuy.Visible = false;
            panelNam.Visible = false;
            switch (cbLoaiThongKe.SelectedItem.ToString())
            {
                case "Theo ngày":
                    panelNgay.Visible = true;
                    break;
                case "Theo tháng":
                    panelThang.Visible = true;
                    break;
                case "Theo quý":
                    panelQuy.Visible = true;
                    // Populate comboBox2 nếu chưa
                    break;
                case "Theo năm":
                    panelNam.Visible = true;
                    break;
            }
            LoadFakeData(); // Load data sau khi switch
        }

        private void LoadFakeData()
        {
            DataTable dt = new DataTable();
            string loaiThongKe = cbLoaiThongKe.SelectedItem?.ToString() ?? "Theo ngày";
            switch (loaiThongKe)
            {
                case "Theo ngày":
                    // Dữ liệu giả cố định cho 8 ngày gần nhất (26/11/2025 - 03/12/2025), xu hướng tăng
                    dt.Columns.Add("Ngày", typeof(string));
                    dt.Columns.Add("Số sách mượn", typeof(int));
                    dt.Columns.Add("Số sách trả", typeof(int));
                    dt.Columns.Add("Số sách quá hạn", typeof(int));
                    dt.Rows.Add("26/11/2025", 19, 15, 1);
                    dt.Rows.Add("27/11/2025", 24, 24, 3);
                    dt.Rows.Add("28/11/2025", 26, 26, 3);
                    dt.Rows.Add("29/11/2025", 31, 28, 1);
                    dt.Rows.Add("30/11/2025", 31, 27, 2);
                    dt.Rows.Add("01/12/2025", 33, 29, 1);
                    dt.Rows.Add("02/12/2025", 37, 36, 0);
                    dt.Rows.Add("03/12/2025", 39, 34, 0);
                    break;
                case "Theo tháng":
                    // Dữ liệu giả cố định cho 12 tháng năm 2025, xu hướng tăng
                    dt.Columns.Add("Tháng", typeof(string));
                    dt.Columns.Add("Số sách mượn", typeof(int));
                    dt.Columns.Add("Số sách trả", typeof(int));
                    dt.Columns.Add("Số sách quá hạn", typeof(int));
                    dt.Rows.Add("1/2025", 343, 269, 53);
                    dt.Rows.Add("2/2025", 397, 324, 53);
                    dt.Rows.Add("3/2025", 424, 326, 48);
                    dt.Rows.Add("4/2025", 470, 410, 39);
                    dt.Rows.Add("5/2025", 492, 397, 40);
                    dt.Rows.Add("6/2025", 530, 444, 41);
                    dt.Rows.Add("7/2025", 575, 518, 47);
                    dt.Rows.Add("8/2025", 636, 550, 57);
                    dt.Rows.Add("9/2025", 672, 590, 34);
                    dt.Rows.Add("10/2025", 720, 670, 43);
                    dt.Rows.Add("11/2025", 743, 666, 46);
                    dt.Rows.Add("12/2025", 775, 680, 54);
                    break;
                case "Theo quý":
                    // Dữ liệu giả cố định cho 4 quý năm 2025, xu hướng tăng
                    dt.Columns.Add("Quý", typeof(string));
                    dt.Columns.Add("Số sách mượn", typeof(int));
                    dt.Columns.Add("Số sách trả", typeof(int));
                    dt.Columns.Add("Số sách quá hạn", typeof(int));
                    dt.Rows.Add("Quý 1/2025", 1782, 1477, 159);
                    dt.Rows.Add("Quý 2/2025", 2170, 1820, 120);
                    dt.Rows.Add("Quý 3/2025", 2414, 2168, 140);
                    dt.Rows.Add("Quý 4/2025", 2657, 2420, 174);
                    break;
                case "Theo năm":
                    // Dữ liệu giả cố định cho 5 năm (2021-2025), xu hướng tăng
                    dt.Columns.Add("Năm", typeof(string));
                    dt.Columns.Add("Số sách mượn", typeof(int));
                    dt.Columns.Add("Số sách trả", typeof(int));
                    dt.Columns.Add("Số sách quá hạn", typeof(int));
                    dt.Rows.Add("2021", 8190, 6827, 1087);
                    dt.Rows.Add("2022", 9185, 8087, 1071);
                    dt.Rows.Add("2023", 10039, 8770, 1033);
                    dt.Rows.Add("2024", 11128, 10004, 1384);
                    dt.Rows.Add("2025", 11832, 10163, 1322);
                    break;
            }
            // Bind DataTable vào DataGridView
            dataGridView1.DataSource = dt;
            // Tắt AutoSizeColumnsMode để cho phép scroll ngang nếu cột rộng
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            // Dàn đều chiều rộng các cột (chiều rộng tổng chia đều cho số cột), nhưng nếu tổng > width thì sẽ scroll ngang
            if (dt.Columns.Count > 0)
            {
                int colWidth = dataGridView1.Width / dt.Columns.Count;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.Width = colWidth;
                }
            }
            // Bind dữ liệu vào Chart (biểu đồ cột, với 3 series: Mượn, Trả, Quá hạn)
            chart1.Series.Clear();
            var seriesMuon = new Series("Mượn") { ChartType = SeriesChartType.Column };
            var seriesTra = new Series("Trả") { ChartType = SeriesChartType.Column };
            var seriesQuaHan = new Series("Quá hạn") { ChartType = SeriesChartType.Column };
            chart1.Series.Add(seriesMuon);
            chart1.Series.Add(seriesTra);
            chart1.Series.Add(seriesQuaHan);
            // Màu sắc cho series (tùy chọn)
            seriesMuon.Color = Color.Blue;
            seriesTra.Color = Color.Green;
            seriesQuaHan.Color = Color.Red;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string label = dt.Rows[i][0].ToString(); // Cột thời gian làm X-axis label
                seriesMuon.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][1]));
                seriesTra.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][2]));
                seriesQuaHan.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][3]));
            }
            // Tùy chỉnh Chart
            chart1.ChartAreas[0].AxisX.Title = "Thời gian";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng sách";
            chart1.Titles.Clear();
            chart1.Titles.Add(loaiThongKe + " Mượn/Trả Sách");
        }
    }
}