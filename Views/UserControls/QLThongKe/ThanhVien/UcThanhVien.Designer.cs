namespace LMS.Views.UserControls.QLThongKe.ThanhVien
{
    partial class UcThanhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelCRUD = new Panel();
            panelSearch = new TableLayoutPanel();
            dateTimePickerYear = new DateTimePicker();
            ThanhViendataGridView = new DataGridView();
            chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThanhViendataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartThongKe).BeginInit();
            SuspendLayout();
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.White;
            panelCRUD.Controls.Add(panelSearch);
            panelCRUD.Dock = DockStyle.Top;
            panelCRUD.Location = new Point(0, 0);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(774, 72);
            panelCRUD.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.ColumnCount = 3;
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8620682F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.3448257F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.08046F));
            panelSearch.Controls.Add(dateTimePickerYear, 1, 0);
            panelSearch.Dock = DockStyle.Right;
            panelSearch.Location = new Point(426, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.RowCount = 1;
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            panelSearch.Size = new Size(348, 72);
            panelSearch.TabIndex = 11;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Anchor = AnchorStyles.None;
            dateTimePickerYear.Location = new Point(93, 24);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(200, 23);
            dateTimePickerYear.TabIndex = 0;
            dateTimePickerYear.ValueChanged += dateTimePickerYear_ValueChanged_1;
            // 
            // ThanhViendataGridView
            // 
            ThanhViendataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ThanhViendataGridView.Dock = DockStyle.Fill;
            ThanhViendataGridView.Location = new Point(0, 72);
            ThanhViendataGridView.Margin = new Padding(3, 2, 3, 2);
            ThanhViendataGridView.Name = "ThanhViendataGridView";
            ThanhViendataGridView.RowHeadersWidth = 51;
            ThanhViendataGridView.Size = new Size(774, 419);
            ThanhViendataGridView.TabIndex = 3;
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            chartThongKe.ChartAreas.Add(chartArea1);
            chartThongKe.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartThongKe.Legends.Add(legend1);
            chartThongKe.Location = new Point(0, 72);
            chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartThongKe.Series.Add(series1);
            chartThongKe.Size = new Size(774, 419);
            chartThongKe.TabIndex = 8;
            chartThongKe.Text = "chart1";
            // 
            // UcThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartThongKe);
            Controls.Add(ThanhViendataGridView);
            Controls.Add(panelCRUD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcThanhVien";
            Size = new Size(774, 491);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ThanhViendataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnLamMoi;
        private DataGridView ThanhViendataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private DateTimePicker dateTimePickerYear;
    }
}
