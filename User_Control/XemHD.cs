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
using DTO;

namespace ManageSpa.User_Control
{
    public partial class XemHD : UserControl
    {
        Bus bus;
        public XemHD()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            cbTenKH.DataSource = bus.XemTenKhachHang(txtTenKhachHang.Text);
        }

        private void XemHD_Load(object sender, EventArgs e)
        {
            cbTenKH.DataSource = bus.XemTenKhachHang("");
        }

        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataHoaDon.DataSource = bus.XemHoaDonCuaKhachHang(bus.LayMaKH(cbTenKH.SelectedValue.ToString()));
        }

        public static string MaHD;
        private void dataHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dr in dataHoaDon.SelectedRows)
            {
                MaHD = dr.Cells[0].Value.ToString();
            }
            FormCTHD fcthd = new FormCTHD();
            fcthd.Show();
        }
    }
}
