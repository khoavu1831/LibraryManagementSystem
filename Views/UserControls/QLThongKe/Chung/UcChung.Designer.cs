namespace LMS.Views.UserControls.QLThongKe.Chung
{
    partial class UcChung
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
            ChungdataGridView = new DataGridView();
            chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChungdataGridView).BeginInit();
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
            panelCRUD.TabIndex = 4;
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
            panelSearch.TabIndex = 10;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Anchor = AnchorStyles.None;
            dateTimePickerYear.Location = new Point(93, 24);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(200, 23);
            dateTimePickerYear.TabIndex = 0;
            dateTimePickerYear.ValueChanged += dateTimePickerYear_ValueChanged;
            // 
            // ChungdataGridView
            // 
            ChungdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChungdataGridView.Dock = DockStyle.Fill;
            ChungdataGridView.Location = new Point(0, 72);
            ChungdataGridView.Margin = new Padding(3, 2, 3, 2);
            ChungdataGridView.Name = "ChungdataGridView";
            ChungdataGridView.RowHeadersWidth = 51;
            ChungdataGridView.Size = new Size(774, 419);
            ChungdataGridView.TabIndex = 6;
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
            chartThongKe.TabIndex = 7;
            chartThongKe.Text = "chart1";
            // 
            // UcChung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartThongKe);
            Controls.Add(ChungdataGridView);
            Controls.Add(panelCRUD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcChung";
            Size = new Size(774, 491);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChungdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private TableLayoutPanel panelSearch;
        private Button btnTimKiem;
        private TextBox txtBoxTimKiem;
        private Button btnLamMoi;
        private DataGridView ChungdataGridView;
        private DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}
