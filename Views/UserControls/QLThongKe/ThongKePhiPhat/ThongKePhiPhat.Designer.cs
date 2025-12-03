namespace LMS.Views.Views.UserControls.QLThongKe.ThongKePhiPhat
{
    partial class ThongKePhiPhat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dp_To = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dp_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.layoutMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // layoutMain 
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowCount = 3;
            // Menu 
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            // Chart 
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            // Grid 
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            this.layoutMain.Controls.Add(this.panelTop, 0, 0);
            this.layoutMain.Controls.Add(this.chart1, 0, 1);
            this.layoutMain.Controls.Add(this.dataGridView1, 0, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Size = new System.Drawing.Size(1060, 720);
            this.layoutMain.TabIndex = 0;

            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dp_To);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dp_From);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.cbLoaiThongKe);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1054, 54);
            this.panelTop.TabIndex = 1;

            // 
            // Controls settings
            // 
            this.dp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_To.Location = new System.Drawing.Point(544, 14);
            this.dp_To.Name = "dp_To";
            this.dp_To.Size = new System.Drawing.Size(122, 23);
            this.dp_To.TabIndex = 6;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.Text = "Đến ngày";

            this.dp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_From.Location = new System.Drawing.Point(334, 14);
            this.dp_From.Name = "dp_From";
            this.dp_From.Size = new System.Drawing.Size(122, 23);
            this.dp_From.TabIndex = 4;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.Text = "Từ ngày";

            this.button1.Location = new System.Drawing.Point(698, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;

            this.cbLoaiThongKe.FormattingEnabled = true;
            this.cbLoaiThongKe.Location = new System.Drawing.Point(124, 14);
            this.cbLoaiThongKe.Name = "cbLoaiThongKe";
            this.cbLoaiThongKe.Size = new System.Drawing.Size(135, 23);
            this.cbLoaiThongKe.TabIndex = 1;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.Text = "Loại thống kê:";

            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1054, 324);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";

            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1054, 324);
            this.dataGridView1.TabIndex = 3;

            // 
            // ThongKePhiPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.layoutMain);
            this.Name = "ThongKePhiPhat";
            this.Size = new System.Drawing.Size(1060, 720);
            this.layoutMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbLoaiThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dp_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dp_From;
        private System.Windows.Forms.Label label2;
    }
}