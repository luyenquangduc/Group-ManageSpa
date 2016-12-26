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
    public partial class ThemNhanVien : UserControl
    {
        Bus bus;
        public ThemNhanVien()
        {
            bus = new Bus();
            InitializeComponent();
        }

        string _countNhanVien;
        private void btnThem_Click(object sender, EventArgs e)
        {
            int countNhanVien;
            countNhanVien = bus.DemNhanVien();
            if (countNhanVien / 10 == 0)
                _countNhanVien = "00" + countNhanVien.ToString();
            else if (countNhanVien / 10 < 10 && countNhanVien / 10 > 0)
                _countNhanVien = "0" + countNhanVien.ToString();

            string maNhanVien = "NV" + _countNhanVien;
            string tenNhanVien = txtTenNhanVien.Text;
            string SDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string hinhNhanVien = txtURL.Text;
            string CMND = txtCMND.Text;
            try
            {
                bus.ThemNhanVien(new DTO.NhanVien(maNhanVien, tenNhanVien, diaChi, SDT, CMND, hinhNhanVien));
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại\nVui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)                 
               txtURL.Text = choofdlog.FileName;            
            else
               txtURL.Text = string.Empty; 
        }

    }
}
