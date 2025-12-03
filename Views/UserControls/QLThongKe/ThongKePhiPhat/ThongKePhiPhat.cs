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

namespace LMS.Views.Views.UserControls.QLThongKe.ThongKePhiPhat
{
    public partial class ThongKePhiPhat : UserControl
    {
        public ThongKePhiPhat()
        {
            InitializeComponent();
            // Thêm items vào cbLoaiThongKe
            cbLoaiThongKe.Items.Add("Tổng phí phạt");
            cbLoaiThongKe.Items.Add("Thành viên bị phạt");
            cbLoaiThongKe.SelectedIndex = 0;
            // Event cho cbLoaiThongKe: switch loại và load data
            cbLoaiThongKe.SelectedIndexChanged += cbLoaiThongKe_SelectedIndexChanged;
            // Event cho button: load data khi click
            button1.Click += (s, e) => LoadFakeData();
            // Bật scroll cho DGV
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Load data lần đầu
            LoadFakeData();
        }

        private void cbLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFakeData(); // Load data sau khi switch loại
        }

        private void LoadFakeData()
        {
            DataTable dt = new DataTable();
            string loaiThongKe = cbLoaiThongKe.SelectedItem?.ToString() ?? "Tổng phí phạt";
            switch (loaiThongKe)
            {
                case "Tổng phí phạt":
                    // Dữ liệu giả cố định cho 30 ngày gần nhất (04/11/2025 - 03/12/2025), xu hướng tăng phí phạt
                    dt.Columns.Add("Ngày", typeof(string));
                    dt.Columns.Add("Tổng phí (VND)", typeof(int));
                    dt.Columns.Add("Số lần phạt", typeof(int));
                    dt.Columns.Add("Số sách quá hạn", typeof(int));
                    dt.Rows.Add("04/11/2025", 50000, 2, 3);
                    dt.Rows.Add("05/11/2025", 55000, 2, 3);
                    dt.Rows.Add("06/11/2025", 60000, 3, 4);
                    dt.Rows.Add("07/11/2025", 65000, 3, 4);
                    dt.Rows.Add("08/11/2025", 70000, 3, 5);
                    dt.Rows.Add("09/11/2025", 75000, 4, 5);
                    dt.Rows.Add("10/11/2025", 80000, 4, 6);
                    dt.Rows.Add("11/11/2025", 85000, 4, 6);
                    dt.Rows.Add("12/11/2025", 90000, 5, 7);
                    dt.Rows.Add("13/11/2025", 95000, 5, 7);
                    dt.Rows.Add("14/11/2025", 100000, 5, 8);
                    dt.Rows.Add("15/11/2025", 105000, 6, 8);
                    dt.Rows.Add("16/11/2025", 110000, 6, 9);
                    dt.Rows.Add("17/11/2025", 115000, 6, 9);
                    dt.Rows.Add("18/11/2025", 120000, 7, 10);
                    dt.Rows.Add("19/11/2025", 125000, 7, 10);
                    dt.Rows.Add("20/11/2025", 130000, 7, 11);
                    dt.Rows.Add("21/11/2025", 135000, 8, 11);
                    dt.Rows.Add("22/11/2025", 140000, 8, 12);
                    dt.Rows.Add("23/11/2025", 145000, 8, 12);
                    dt.Rows.Add("24/11/2025", 150000, 9, 13);
                    dt.Rows.Add("25/11/2025", 170000, 9, 13);
                    dt.Rows.Add("26/11/2025", 190000, 10, 14);
                    dt.Rows.Add("27/11/2025", 220000, 11, 15);
                    dt.Rows.Add("28/11/2025", 250000, 12, 16);
                    dt.Rows.Add("29/11/2025", 280000, 13, 17);
                    dt.Rows.Add("30/11/2025", 310000, 14, 18);
                    dt.Rows.Add("01/12/2025", 340000, 15, 19);
                    dt.Rows.Add("02/12/2025", 390000, 16, 20);
                    dt.Rows.Add("03/12/2025", 450000, 17, 21);
                    break;
                case "Thành viên bị phạt":
                    // Dữ liệu giả cố định cho 30 ngày gần nhất (04/11/2025 - 03/12/2025), xu hướng tăng số thành viên bị phạt
                    dt.Columns.Add("Ngày", typeof(string));
                    dt.Columns.Add("Số thành viên bị phạt", typeof(int));
                    dt.Columns.Add("Số lần vi phạm", typeof(int));
                    dt.Rows.Add("04/11/2025", 1, 2);
                    dt.Rows.Add("05/11/2025", 1, 2);
                    dt.Rows.Add("06/11/2025", 1, 3);
                    dt.Rows.Add("07/11/2025", 2, 3);
                    dt.Rows.Add("08/11/2025", 2, 3);
                    dt.Rows.Add("09/11/2025", 2, 4);
                    dt.Rows.Add("10/11/2025", 2, 4);
                    dt.Rows.Add("11/11/2025", 3, 4);
                    dt.Rows.Add("12/11/2025", 3, 5);
                    dt.Rows.Add("13/11/2025", 3, 5);
                    dt.Rows.Add("14/11/2025", 3, 5);
                    dt.Rows.Add("15/11/2025", 4, 6);
                    dt.Rows.Add("16/11/2025", 4, 6);
                    dt.Rows.Add("17/11/2025", 4, 6);
                    dt.Rows.Add("18/11/2025", 4, 7);
                    dt.Rows.Add("19/11/2025", 5, 7);
                    dt.Rows.Add("20/11/2025", 5, 7);
                    dt.Rows.Add("21/11/2025", 5, 8);
                    dt.Rows.Add("22/11/2025", 5, 8);
                    dt.Rows.Add("23/11/2025", 6, 8);
                    dt.Rows.Add("24/11/2025", 6, 9);
                    dt.Rows.Add("25/11/2025", 6, 9);
                    dt.Rows.Add("26/11/2025", 7, 10);
                    dt.Rows.Add("27/11/2025", 7, 11);
                    dt.Rows.Add("28/11/2025", 8, 12);
                    dt.Rows.Add("29/11/2025", 8, 13);
                    dt.Rows.Add("30/11/2025", 9, 14);
                    dt.Rows.Add("01/12/2025", 9, 15);
                    dt.Rows.Add("02/12/2025", 10, 16);
                    dt.Rows.Add("03/12/2025", 11, 17);
                    break;
            }
            // Bind DataTable vào DataGridView
            dataGridView1.DataSource = dt;
            // Tắt AutoSizeColumnsMode để cho phép scroll ngang
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            // Dàn đều chiều rộng các cột
            if (dt.Columns.Count > 0)
            {
                int colWidth = dataGridView1.Width / dt.Columns.Count;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.Width = colWidth;
                }
            }
            // Bind dữ liệu vào Chart (biểu đồ cột, với series tương ứng)
            chart1.Series.Clear();
            if (loaiThongKe == "Tổng phí phạt")
            {
                var seriesTongPhi = new Series("Tổng phí") { ChartType = SeriesChartType.Column };
                var seriesLanPhat = new Series("Số lần phạt") { ChartType = SeriesChartType.Column };
                var seriesQuaHan = new Series("Sách quá hạn") { ChartType = SeriesChartType.Column };
                chart1.Series.Add(seriesTongPhi);
                chart1.Series.Add(seriesLanPhat);
                chart1.Series.Add(seriesQuaHan);
                seriesTongPhi.Color = Color.Orange;
                seriesLanPhat.Color = Color.Purple;
                seriesQuaHan.Color = Color.Gray;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string label = dt.Rows[i][0].ToString();
                    seriesTongPhi.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][1]));
                    seriesLanPhat.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][2]));
                    seriesQuaHan.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][3]));
                }
            }
            else // "Thành viên bị phạt"
            {
                var seriesThanhVien = new Series("Thành viên bị phạt") { ChartType = SeriesChartType.Column };
                var seriesViPham = new Series("Số lần vi phạm") { ChartType = SeriesChartType.Column };
                chart1.Series.Add(seriesThanhVien);
                chart1.Series.Add(seriesViPham);
                seriesThanhVien.Color = Color.Red;
                seriesViPham.Color = Color.Brown;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string label = dt.Rows[i][0].ToString();
                    seriesThanhVien.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][1]));
                    seriesViPham.Points.AddXY(label, Convert.ToInt32(dt.Rows[i][2]));
                }
            }
            // Tùy chỉnh Chart
            chart1.ChartAreas[0].AxisX.Title = "Thời gian";
            chart1.ChartAreas[0].AxisY.Title = loaiThongKe == "Tổng phí phạt" ? "Số lượng / VND" : "Số lượng";
            chart1.Titles.Clear();
            chart1.Titles.Add(loaiThongKe);
        }
    }
}