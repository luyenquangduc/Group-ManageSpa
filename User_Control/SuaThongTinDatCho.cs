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
    public partial class SuaThongTinDatCho : UserControl
    {
        Bus bus;
        public SuaThongTinDatCho()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void SuaThongTinDatCho_Load(object sender, EventArgs e)
        {
            dataThongTinDatCho.DataSource = bus.DanhSachDatCho();
        }

        string MaDC, MaGiuong, SDT;
        DateTime TGBD, TGKT;
        private void dataThongTinDatCho_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataThongTinDatCho.SelectedRows)
            {
                MaDC = dr.Cells[0].Value.ToString();
                MaGiuong = dr.Cells[1].Value.ToString();
                SDT = dr.Cells[2].Value.ToString();
                TGBD = (DateTime)dr.Cells[3].Value;
                TGKT = (DateTime)dr.Cells[4].Value;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLieuTrinh_Click(object sender, EventArgs e)
        {

        }
    }
}
