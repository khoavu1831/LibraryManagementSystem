    using LMS.Data;
    using LMS.Entities;
    using LMS.Services;
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
    using System.Windows.Forms.DataVisualization.Charting; 

    namespace LMS.Views.Views.UserControls.QLThongKe.ThongKeSach
    {
        public partial class ThongKeSach : UserControl
        {
            private readonly ThongKeSachService _service;
            public ThongKeSach()
            {
                InitializeComponent();
                _service = new ThongKeSachService();

                dgvThongKe.ScrollBars = ScrollBars.Both;
                dgvThongKe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvThongKe.RowTemplate.Height = 25;
                dgvThongKe.AllowUserToResizeRows = false;

                dgvThongKe.Dock = DockStyle.Fill;
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


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cbThongKe.SelectedItem.ToString();

            // LẤY DỮ LIỆU
            DataTable dt = _service.TaoBangThongKe(loai, dp_From.Value, dp_To.Value);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // VẼ CHART
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.Titles.Add(
                $"Thống kê từ {dp_From.Value:dd/MM} đến {dp_To.Value:dd/MM}"
            ).Font = new Font("Arial", 12, FontStyle.Bold);

            var totals = _service.TinhTongTatCaLoai();
            foreach (var item in totals)
            {
                var s = chartThongKe.Series.Add(item.Key);
                s.ChartType = SeriesChartType.Column;
                s.Points.AddXY("Số lượng", item.Value);
            }


            // ⭐ CHỈNH MÀU

            // MAP Combobox 
            Dictionary<string, string> map = new Dictionary<string, string>()
    {
        { "Tổng số sách", "Tổng số lượng sách hiện có" },
        { "Sách đang mượn", "Số lượng sách đang mượn" },
        { "Sách mất hoặc hư hỏng", "Số lượng sách mất hoặc hư hỏng" },
        { "Sách chưa mượn", "Số lượng sách chưa mượn" }
    };

            // 4 màu cố định cho Tổng
            Color[] fullColors =
            {
        Color.RoyalBlue,
        Color.SeaGreen,
        Color.Goldenrod,
        Color.IndianRed
    };

            if (loai == "Tổng số sách")
            {
                int i = 0;
                foreach (var s in chartThongKe.Series)
                {
                    s.Color = fullColors[i++];
                }
            }
            else
            {
                string seriesName = map[loai]; 
                Color highlight = Color.CornflowerBlue;
                Color gray = Color.LightGray;

                foreach (var s in chartThongKe.Series)
                {
                    if (s.Name == seriesName)
                        s.Color = highlight;
                    else
                        s.Color = gray;
                }
            }
        }
        }
    }