namespace LMS.Views.Views.UserControls.QLThongKe.ThongKeSach
{
    partial class ThongKeSach
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
            panel1 = new Panel();
            cbThongKe = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btnThongKe = new Button();
            dp_To = new DateTimePicker();
            label2 = new Label();
            dp_From = new DateTimePicker();
            label1 = new Label();
            panel4 = new Panel();
            chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel5 = new Panel();
            dgvThongKe = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartThongKe).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbThongKe);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(dp_To);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dp_From);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 54);
            panel1.TabIndex = 0;
            // 
            // cbThongKe
            // 
            cbThongKe.FormattingEnabled = true;
            cbThongKe.Location = new Point(614, 13);
            cbThongKe.Name = "cbThongKe";
            cbThongKe.Size = new Size(121, 23);
            cbThongKe.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 275);
            panel2.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(774, 12);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(75, 23);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dp_To
            // 
            dp_To.Location = new Point(385, 13);
            dp_To.Name = "dp_To";
            dp_To.Size = new Size(200, 23);
            dp_To.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 19);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            label2.Click += label2_Click;
            // 
            // dp_From
            // 
            dp_From.Location = new Point(85, 11);
            dp_From.Name = "dp_From";
            dp_From.Size = new Size(200, 23);
            dp_From.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // panel4
            // 
            panel4.Controls.Add(chartThongKe);
            panel4.Location = new Point(3, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(1054, 392);
            panel4.TabIndex = 1;
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            chartThongKe.ChartAreas.Add(chartArea1);
            chartThongKe.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartThongKe.Legends.Add(legend1);
            chartThongKe.Location = new Point(0, 0);
            chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartThongKe.Series.Add(series1);
            chartThongKe.Size = new Size(1054, 392);
            chartThongKe.TabIndex = 0;
            chartThongKe.Text = "chart1";
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(dgvThongKe);
            panel5.Location = new Point(0, 445);
            panel5.Name = "panel5";
            panel5.Size = new Size(1057, 275);
            panel5.TabIndex = 2;
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Dock = DockStyle.Fill;
            dgvThongKe.Location = new Point(0, 0);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.Size = new Size(1057, 275);
            dgvThongKe.TabIndex = 0;
            // 
            // ThongKeSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "ThongKeSach";
            Size = new Size(1060, 720);
            Load += ThongKeSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartThongKe).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThongKe;
        private DateTimePicker dp_To;
        private Label label2;
        private DateTimePicker dp_From;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private Panel panel5;
        private DataGridView dgvThongKe;
        private ComboBox cbThongKe;
    }
}
