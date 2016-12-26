using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ManageSpa.User_Control
{
    public partial class ThongKeDangNhap : UserControl
    {
        Bus bus;
        public ThongKeDangNhap()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void ThongKeDangNhap_Load(object sender, EventArgs e)
        {
            LoadNhanVienToCbBox();
        }

        private void LoadNhanVienToCbBox()
        {
            try{cbTenNhanVien.DataSource = bus.XemTatCaNhanVien();}
            catch (Exception){MessageBox.Show("Load không thành công\nVui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { dataLanDangNhap.DataSource = bus.XemThongTinDangNhap(bus.LayMaNVTuTenNV(cbTenNhanVien.SelectedValue.ToString()));}
            catch (Exception){MessageBox.Show("Cập nhật thông tin thất bại\nVui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

    }
}
