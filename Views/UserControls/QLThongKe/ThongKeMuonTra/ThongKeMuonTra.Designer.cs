using System.Windows.Forms;

namespace LMS.Views.Views.UserControls.QLThongKe.ThongKeMuonTra
{
    partial class ThongKeMuonTra
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
            cbLoaiThongKe = new ComboBox();
            label1 = new Label();
            panelFilter = new Panel();
            panelNam = new Panel();
            dpFromNam = new DateTimePicker();
            dpToNam = new DateTimePicker();
            labelToNam = new Label();
            label8 = new Label();
            panelQuy = new Panel();
            dpToQuy = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dpFromQuy = new DateTimePicker();
            panelThang = new Panel();
            label5 = new Label();
            dpFromThang = new DateTimePicker();
            label4 = new Label();
            dpToThang = new DateTimePicker();
            panelNgay = new Panel();
            dpToNgay = new DateTimePicker();
            label2 = new Label();
            dpFromNgay = new DateTimePicker();
            label3 = new Label();
            panel2 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panelFilter.SuspendLayout();
            panelNam.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)dpFromNam).BeginInit();
            panelQuy.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)dpToQuy).BeginInit();
            panelThang.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)dpFromThang).BeginInit();
            //((System.ComponentModel.ISupportInitialize)dpToThang).BeginInit();
            panelNgay.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbLoaiThongKe);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 54);
            panel1.TabIndex = 0;
            // 
            // cbLoaiThongKe
            // 
            cbLoaiThongKe.FormattingEnabled = true;
            cbLoaiThongKe.Location = new Point(124, 11);
            cbLoaiThongKe.Name = "cbLoaiThongKe";
            cbLoaiThongKe.Size = new Size(121, 23);
            cbLoaiThongKe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Loại thống kê:";
            // 
            // panelFilter
            // 
            panelFilter.AccessibleName = "";
            panelFilter.Controls.Add(panelNam);
            panelFilter.Controls.Add(panelQuy);
            panelFilter.Controls.Add(panelThang);
            panelFilter.Controls.Add(panelNgay);
            panelFilter.Location = new Point(0, 54);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1060, 94);
            panelFilter.TabIndex = 1;
            // 
            // panelNam
            // 
            panelNam.Controls.Add(button1);
            panelNam.Controls.Add(dpFromNam);
            panelNam.Controls.Add(dpToNam);
            panelNam.Controls.Add(label8);
            panelNam.Controls.Add(labelToNam);
            panelNam.Location = new Point(0, 3);
            panelNam.Name = "panelNam";
            panelNam.Size = new Size(1060, 89);
            panelNam.TabIndex = 3;
            panelNam.Visible = false;
            // Label "Từ năm"
            label8.AutoSize = true;
            label8.Location = new Point(20, 30);
            label8.Name = "lblFromNam";
            label8.Size = new Size(50, 15);
            label8.Text = "Từ năm:";

            // DateTimePicker từ năm
            dpFromNam.Format = DateTimePickerFormat.Custom;
            dpFromNam.CustomFormat = "yyyy";
            dpFromNam.ShowUpDown = true; // chỉ chọn năm
            dpFromNam.Location = new Point(80, 25);
            dpFromNam.Name = "dpFromNam";
            dpFromNam.Size = new Size(80, 23);
            dpFromNam.MaxDate = DateTime.Today;


            // Label "Đến năm"
            labelToNam.AutoSize = true;
            labelToNam.Location = new Point(200, 30);
            labelToNam.Name = "lblToNam";
            labelToNam.Size = new Size(60, 15);
            labelToNam.Text = "Đến năm:";
            

            // DateTimePicker đến năm
            dpToNam.Format = DateTimePickerFormat.Custom;
            dpToNam.CustomFormat = "yyyy";
            dpToNam.ShowUpDown = true; // chỉ chọn năm
            dpToNam.Location = new Point(270, 25);
            dpToNam.Name = "dpToNam";
            dpToNam.Size = new Size(80, 23);
            dpToNam.MaxDate = DateTime.Today;

            // 
            // panelQuy
            // 
            panelQuy.Controls.Add(button2);
            panelQuy.Controls.Add(dpToQuy);
            panelQuy.Controls.Add(label7);
            panelQuy.Controls.Add(label6);
            panelQuy.Controls.Add(dpFromQuy);
            panelQuy.Location = new Point(3, 0);
            panelQuy.Name = "panelQuy";
            panelQuy.Size = new Size(1057, 92);
            panelQuy.TabIndex = 2;
            panelQuy.Visible = false;
            // 
            // dpToQuy
            // 
            dpToQuy.Location = new Point(278, 35);
            dpToQuy.Name = "dpToQuy";
            dpToQuy.Size = new Size(120, 23);
            dpToQuy.TabIndex = 4;
            dpToQuy.Format = DateTimePickerFormat.Custom;
            dpToQuy.CustomFormat = "MM/yyyy";
            dpToQuy.ShowUpDown = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 43);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 3;
            label7.Text = "Đến quý:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 43);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 2;
            label6.Text = "Từ quý:";
            // 
            // dpFromQuy
            // 
            dpFromQuy.Location = new Point(75, 35);
            dpFromQuy.Name = "dpFromQuy";
            dpFromQuy.Size = new Size(121, 23);
            dpFromQuy.TabIndex = 0;
            dpFromQuy.Format = DateTimePickerFormat.Custom;
            dpFromQuy.CustomFormat = "MM/yyyy";
            dpFromQuy.ShowUpDown = true;
            // 
            // panelThang
            // 
            panelThang.Controls.Add(button3);
            panelThang.Controls.Add(label5);
            panelThang.Controls.Add(dpFromThang);
            panelThang.Controls.Add(label4);
            panelThang.Controls.Add(dpToThang);
            panelThang.Location = new Point(0, 3);
            panelThang.Name = "panelThang";
            panelThang.Size = new Size(1060, 89);
            panelThang.TabIndex = 1;
            panelThang.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 40);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Đến tháng:";
            // 
            // dpFromThang
            // 
            dpFromThang.Location = new Point(82, 40);
            dpFromThang.Name = "dpFromThang";
            dpFromThang.Size = new Size(73, 23);
            dpFromThang.TabIndex = 9;
            dpFromThang.Format = DateTimePickerFormat.Custom;
            dpFromThang.CustomFormat = "MM/yyyy";
            dpFromThang.MaxDate = DateTime.Today;
            dpFromThang.ShowUpDown = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 40);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Từ tháng:";
            // 
            // dpToThang
            // 
            dpToThang.Location = new Point(260, 40);
            dpToThang.Name = "dpToThang";
            dpToThang.Size = new Size(73, 23);
            dpToThang.TabIndex = 0;
            dpToThang.Format = DateTimePickerFormat.Custom;
            dpToThang.CustomFormat = "MM/yyyy";
            dpToThang.MaxDate = DateTime.Today;
            dpToThang.ShowUpDown = true;
            // 
            // panelNgay
            // 
            panelNgay.Controls.Add(button4);
            panelNgay.Controls.Add(dpToNgay);
            panelNgay.Controls.Add(label2);
            panelNgay.Controls.Add(dpFromNgay);
            panelNgay.Controls.Add(label3);
            panelNgay.Location = new Point(0, 3);
            panelNgay.Name = "panelNgay";
            panelNgay.Size = new Size(1060, 89);
            panelNgay.TabIndex = 0;
            panelNgay.Visible = false;
            // 
            // dpToNgay
            // 
            dpToNgay.Location = new Point(397, 32);
            dpToNgay.Name = "dpToNgay";
            dpToNgay.Size = new Size(200, 23);
            dpToNgay.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 38);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Đến ngày";
            // 
            // dpFromNgay
            // 
            dpFromNgay.Location = new Point(97, 30);
            dpFromNgay.Name = "dpFromNgay";
            dpFromNgay.Size = new Size(200, 23);
            dpFromNgay.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 38);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Từ ngày";
            // 
            // panel2
            // 
            panel2.Controls.Add(chart1);
            panel2.Location = new Point(0, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(1060, 330);
            panel2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1057, 330);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 173);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1054, 170);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(418, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(418, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Thống kê";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(418, 40);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Thống kê";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(650, 32);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            // 
            // ThongKeMuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelFilter);
            Controls.Add(panel1);
            Name = "ThongKeMuonTra";
            Size = new Size(1060, 653);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelNam.ResumeLayout(false);
            panelNam.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)dpFromNam).EndInit();
            panelQuy.ResumeLayout(false);
            panelQuy.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)dpToQuy).EndInit();
            panelThang.ResumeLayout(false);
            panelThang.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)dpFromThang).EndInit();
            //((System.ComponentModel.ISupportInitialize)dpToThang).EndInit();
            panelNgay.ResumeLayout(false);
            panelNgay.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbLoaiThongKe;
        private Label label1;
        private Panel panelFilter;
        private Panel panelNgay;
        private Panel panelThang;
        private Label label5;
        private DateTimePicker dpFromThang;
        private Label label4;
        private DateTimePicker dpToThang;
        private DateTimePicker dpToNgay;
        private Label label2;
        private DateTimePicker dpFromNgay;
        private Label label3;
        private Panel panelQuy;
        private DateTimePicker dpToQuy;
        private Label label7;
        private Label label6;
        private DateTimePicker dpFromQuy;
        private Panel panelNam;
        private DateTimePicker dpFromNam;
        private DateTimePicker dpToNam;
        private Label label8;
        private Label labelToNam;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}