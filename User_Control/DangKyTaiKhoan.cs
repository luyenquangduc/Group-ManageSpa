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
    public partial class DangKyTaiKhoan : UserControl
    {
        Bus bus;
        public DangKyTaiKhoan()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            Init();
        }

        void Init()
        {
            this.cbLoaiTK.Items.Add("Người quản trị");
            this.cbLoaiTK.Items.Add("Nhân viên");

            LoadNhanVien();
        }

        string loaiTK;
        private void Thêm_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            try
            {
                bus.ThemTaiKhoan(new DTO.TaiKhoan(tenTK, matKhau, bus.LayMaNVTuTenNV(nguoiDung)));
                MessageBox.Show("Thêm tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm tài khoản không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                bus.ThemLoaiTK(new LoaiTaiKhoan(tenTK, loaiTK));
                MessageBox.Show("Thêm loại tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm loại tài khoản không thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLoaiTK_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiTK.SelectedItem.ToString() == "Người quản trị")
                loaiTK = "Admin";
            else
                loaiTK = "User";
        }

        private void LoadNhanVien()
        {
            cbNhanVien.DataSource = bus.XemTatCaNhanVien();
        }

        string nguoiDung = "";
        private void cbNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            nguoiDung = cbNhanVien.SelectedValue.ToString();
        }
    }
}
