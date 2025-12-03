using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LMS.Views.Views.UserControls.QLThongKe.ThongKePhiPhat
{
    public partial class ThongKePhiPhat : UserControl
    {
        public ThongKePhiPhat()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
            // ComboBox 
            cbLoaiThongKe.Items.Clear();
            cbLoaiThongKe.Items.Add("Tổng phí phạt");      // Index = 0
            cbLoaiThongKe.Items.Add("Thành viên bị phạt"); // Index = 1
            cbLoaiThongKe.SelectedIndex = 0; 

            // DateTimePicker
            dp_To.Value = DateTime.Now;
            dp_From.Value = DateTime.Now.AddDays(-30);

            // Event
            cbLoaiThongKe.SelectedIndexChanged += (s, e) => LoadRealData();
            button1.Click += (s, e) => LoadRealData();

            // Grid
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Chart (Trục X)
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(50, Color.Gray);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(50, Color.Gray);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                LoadRealData();
            }
        }

        private void LoadRealData()
        {
            int selectedIndex = cbLoaiThongKe.SelectedIndex;
            DateTime fromDate = dp_From.Value.Date;
            DateTime toDate = dp_To.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();

            using (var context = new LibraryDbContext())
            {
                // CASE 0: TỔNG PHÍ PHẠT
                if (selectedIndex == 0)
                {
                    dt.Columns.Add("Ngày", typeof(DateTime));
                    dt.Columns.Add("Tổng tiền phạt (VNĐ)", typeof(decimal));
                    dt.Columns.Add("Số lỗi vi phạm", typeof(int));

                    var data = context.ChiTietPhieuPhats
                        .Include(ct => ct.PhieuPhat)
                        .Where(ct => ct.PhieuPhat.NgayLap >= fromDate && ct.PhieuPhat.NgayLap < toDate.AddDays(1))
                        .AsEnumerable()
                        .GroupBy(ct => ct.PhieuPhat.NgayLap.Date)
                        .Select(g => new
                        {
                            Ngay = g.Key,
                            TongTien = g.Sum(x => x.TienPhatTra),
                            SoLoi = g.Count()
                        })
                        .OrderBy(x => x.Ngay)
                        .ToList();

                    foreach (var item in data)
                    {
                        dt.Rows.Add(item.Ngay, item.TongTien, item.SoLoi);
                    }

                    SetupChartTongPhi(dt);
                }
                // CASE 1: THÀNH VIÊN BỊ PHẠT
                else
                {
                    dt.Columns.Add("Ngày", typeof(DateTime));
                    dt.Columns.Add("Số thành viên bị phạt", typeof(int));
                    dt.Columns.Add("Tổng số lần vi phạm", typeof(int));

                    var query = from ctpp in context.ChiTietPhieuPhats
                                join pp in context.PhieuPhats on ctpp.IdPhieuPhat equals pp.IdPhieuPhat
                                join ctpm in context.ChiTietPhieuMuons on ctpp.IdChiTietPhieuMuon equals ctpm.IdChiTietPhieuMuon
                                join pm in context.PhieuMuons on ctpm.IdPhieuMuon equals pm.IdPhieuMuon
                                join ttv in context.TheThanhViens on pm.IdTheThanhVien equals ttv.IdTheThanhVien
                                join dg in context.DocGias on ttv.IdDocGia equals dg.IdDocGia
                                where pp.NgayLap >= fromDate && pp.NgayLap < toDate.AddDays(1)
                                select new { pp.NgayLap, dg.IdDocGia };

                    var data = query.AsEnumerable()
                                    .GroupBy(x => x.NgayLap.Date)
                                    .Select(g => new
                                    {
                                        Ngay = g.Key,
                                        SoThanhVien = g.Select(x => x.IdDocGia).Distinct().Count(),
                                        SoLanViPham = g.Count()
                                    })
                                    .OrderBy(x => x.Ngay)
                                    .ToList();

                    foreach (var item in data)
                    {
                        dt.Rows.Add(item.Ngay, item.SoThanhVien, item.SoLanViPham);
                    }

                    SetupChartThanhVien(dt);
                }
            }

            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns["Ngày"] != null) dataGridView1.Columns["Ngày"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dataGridView1.Columns["Tổng tiền phạt (VNĐ)"] != null) dataGridView1.Columns["Tổng tiền phạt (VNĐ)"].DefaultCellStyle.Format = "N0";
        }

        //RESET BIỂU ĐỒ 
        private void ResetChart()
        {
            var ca = chart1.ChartAreas[0];

            // 1. Xóa Series cũ
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // 2. Reset Trục Y 
            ca.AxisY.Minimum = Double.NaN;
            ca.AxisY.Maximum = Double.NaN;
            ca.AxisY.LabelStyle.Format = ""; // Xóa format cũ

            // 3. Tính lại scale
            ca.RecalculateAxesScale();
        }

        private void SetupChartTongPhi(DataTable dt)
        {
            ResetChart(); // Gọi reset 

            chart1.Titles.Add($"Thống kê Tổng Phí Phạt ({dp_From.Value:dd/MM} - {dp_To.Value:dd/MM})");

            var seriesTien = new Series("Tổng tiền (VNĐ)")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Orange,
                IsXValueIndexed = true
            };
            seriesTien["PixelPointWidth"] = "50";

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = (DateTime)row["Ngày"];
                decimal tien = (decimal)row["Tổng tiền phạt (VNĐ)"];

                DataPoint point = new DataPoint();
                point.AxisLabel = ngay.ToString("dd/MM");
                point.YValues = new double[] { (double)tien };
                point.ToolTip = $"Ngày: {ngay:dd/MM/yyyy}\nTiền: {tien:N0} VNĐ";

                seriesTien.Points.Add(point);
            }

            chart1.Series.Add(seriesTien);

            // Set format tiền tệ
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
        }

        private void SetupChartThanhVien(DataTable dt)
        {
            ResetChart(); // Gọi reset 

            chart1.Titles.Add($"Thống kê Thành Viên Bị Phạt ({dp_From.Value:dd/MM} - {dp_To.Value:dd/MM})");

            var seriesThanhVien = new Series("Số thành viên")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsXValueIndexed = true
            };
            seriesThanhVien["PixelPointWidth"] = "50";

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = (DateTime)row["Ngày"];
                int soTV = (int)row["Số thành viên bị phạt"];
                string labelNgay = ngay.ToString("dd/MM");

                DataPoint p1 = new DataPoint();
                p1.AxisLabel = labelNgay;
                p1.YValues = new double[] { soTV };
                p1.ToolTip = $"Ngày: {ngay:dd/MM/yyyy}\nSố thành viên: {soTV}";

                seriesThanhVien.Points.Add(p1);
            }

            chart1.Series.Add(seriesThanhVien);

            // Set format số nguyên
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0";
        }
    }
}