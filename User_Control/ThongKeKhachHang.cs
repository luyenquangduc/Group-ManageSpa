using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace ManageSpa.User_Control
{
    public partial class ThongKeKhachHang : UserControl
    {
        Bus bus;
        public ThongKeKhachHang()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void ThongKeKhachHang_Load(object sender, EventArgs e)
        {
            cbThongKe.Items.Add("Thống kê theo tháng");
            cbThongKe.Items.Add("Thống kê theo năm");
            cbThongKe.SelectedItem = "Thống kê theo tháng"; 
        }

        string LoaiThongKe = "";
        private void LoadChart()
        {
            DateTime date = DateTime.Now;
            if (LoaiThongKe == "TheoThang")
            {
                chartKhachHang.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chartKhachHang.ChartAreas["ChartArea1"].AxisY.Title = "Giá trị";
                DataTable dt = new DataTable();
                DataRow dr = dt.NewRow();
                for (int i = 0; i <= 30; i++)
                {
                    dr[i] = bus.ThongKeKhachHang(LoaiThongKe, date.Month, date.Year);
                }
                    chartKhachHang.Series["Series1"].XValueMember = "";
                chartKhachHang.Series["Series1"].YValueMembers = "";
            }
            else
            {
                
            }
        }

        private void cbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKe.SelectedItem.ToString() == "Thống kê theo tháng")
                LoaiThongKe = "TheoThang";
            else
                LoaiThongKe = "TheoNam";
        }
    }
}
