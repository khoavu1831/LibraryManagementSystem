namespace LMS.Views.UserControls.QLThongKe.PhieuPhat
{
    partial class UcPhieuPhat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelCRUD = new Panel();
            panelSearch = new TableLayoutPanel();
            dateTimePickerYear = new DateTimePicker();
            chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCRUD.SuspendLayout();
            panelSearch.SuspendLayout();
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
            panelCRUD.TabIndex = 3;
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
            panelSearch.TabIndex = 9;
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
            // chartThongKe
            // 
            chartArea2.Name = "ChartArea1";
            chartThongKe.ChartAreas.Add(chartArea2);
            chartThongKe.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartThongKe.Legends.Add(legend2);
            chartThongKe.Location = new Point(0, 72);
            chartThongKe.Name = "chartThongKe";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartThongKe.Series.Add(series2);
            chartThongKe.Size = new Size(774, 419);
            chartThongKe.TabIndex = 4;
            chartThongKe.Text = "chart1";
            // 
            // UcPhieuPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartThongKe);
            Controls.Add(panelCRUD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcPhieuPhat";
            Size = new Size(774, 491);
            panelCRUD.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCRUD;
        private TableLayoutPanel panelSearch;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private DateTimePicker dateTimePickerYear;
    }
}
