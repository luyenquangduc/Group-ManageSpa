namespace ManageSpa.User_Control
{
    partial class ThongKeKhachHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cbThongKe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKhachHang
            // 
            chartArea1.BorderWidth = 10;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            chartArea4.Name = "ChartArea4";
            chartArea5.BorderColor = System.Drawing.Color.Maroon;
            chartArea5.Name = "ChartArea5";
            chartArea6.Name = "ChartArea6";
            chartArea7.Name = "ChartArea7";
            chartArea8.Name = "ChartArea8";
            chartArea9.Name = "ChartArea9";
            chartArea10.Name = "ChartArea10";
            chartArea11.Name = "ChartArea11";
            chartArea12.Name = "ChartArea12";
            this.chartKhachHang.ChartAreas.Add(chartArea1);
            this.chartKhachHang.ChartAreas.Add(chartArea2);
            this.chartKhachHang.ChartAreas.Add(chartArea3);
            this.chartKhachHang.ChartAreas.Add(chartArea4);
            this.chartKhachHang.ChartAreas.Add(chartArea5);
            this.chartKhachHang.ChartAreas.Add(chartArea6);
            this.chartKhachHang.ChartAreas.Add(chartArea7);
            this.chartKhachHang.ChartAreas.Add(chartArea8);
            this.chartKhachHang.ChartAreas.Add(chartArea9);
            this.chartKhachHang.ChartAreas.Add(chartArea10);
            this.chartKhachHang.ChartAreas.Add(chartArea11);
            this.chartKhachHang.ChartAreas.Add(chartArea12);
            legend1.Name = "Legend1";
            this.chartKhachHang.Legends.Add(legend1);
            this.chartKhachHang.Location = new System.Drawing.Point(228, 17);
            this.chartKhachHang.Name = "chartKhachHang";
            this.chartKhachHang.Size = new System.Drawing.Size(637, 326);
            this.chartKhachHang.TabIndex = 0;
            this.chartKhachHang.Text = "Khách hàng";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cbThongKe
            // 
            this.cbThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThongKe.FormattingEnabled = true;
            this.cbThongKe.Items.AddRange(new object[] {
            "Thống kê theo tháng",
            "Thống kê theo năm"});
            this.cbThongKe.Location = new System.Drawing.Point(23, 30);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(189, 21);
            this.cbThongKe.TabIndex = 2;
            this.cbThongKe.SelectedIndexChanged += new System.EventHandler(this.cbThongKe_SelectedIndexChanged);
            // 
            // ThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbThongKe);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chartKhachHang);
            this.Name = "ThongKeKhachHang";
            this.Size = new System.Drawing.Size(880, 386);
            this.Load += new System.EventHandler(this.ThongKeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhachHang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cbThongKe;
    }
}
