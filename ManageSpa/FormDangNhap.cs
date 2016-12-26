using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ManageSpa
{
    public partial class FormDangNhap : Form
    {
        Bus bus;
        public static string Acc = "User";
        public FormDangNhap()
        {
            bus = new Bus();
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void KiemTraLoaiTaiKhoan()
        {
            string loaiTK = bus.KiemTraLoaiTaiKhoan(txtTaiKhoan.Text);
            if (loaiTK == "Admin")
            {
                Acc = "Admin";
            }
        }

        private void ThemThoiGianDangNhap()
        {
            DateTime date = DateTime.Now;
            if (Acc == "User")
            {
                try
                {
                    string MaNV = bus.LayMaNV(txtTaiKhoan.Text);
                    bus.KiemSoatDangNhap(txtTaiKhoan.Text, MaNV, date);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void DangNhap()
        {
            if (bus.KiemTraDangNhap(txtTaiKhoan.Text.ToString(), txtMatKhau.Text.ToString()) == true)
                {
                    Program.kiemtra = true;
                    MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KiemTraLoaiTaiKhoan();
                    ThemThoiGianDangNhap();
                    this.Close();
                }
                else
                    MessageBox.Show("Đăng nhập thất bại", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}
