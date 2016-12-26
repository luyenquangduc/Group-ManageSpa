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
    public partial class ThemKhachHang : UserControl
    {
        Bus bus;
        public ThemKhachHang()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            if (DatChoCoLich.ThemKhachHangTuDatCho == true)
            {
                CanExit = false;
                txtSDT.Text = DatChoCoLich.txtSoDienThoai;
                txtSDT.Enabled = false;
            }
            else
            {
                btnChangeCanExit.Hide();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int SumKH = 0;
            string MaKH, TenKH, DiaChi, SDT;

            // Thêm khách hàng chủ động
            #region Thêm khách hàng bình thường 
            if (DatChoCoLich.ThemKhachHangTuDatCho == false)
            {
                try{ SumKH = bus.DemKhachHang();}
                catch (Exception){ MessageBox.Show("Không tìm thấy thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                MaKH = LayMaKH(SumKH + 1);
                TenKH = txtTenKhachHang.Text;
                DiaChi = txtDiaChi.Text;
                SDT = txtSDT.Text;
                try
                {
                    bus.ThemKhachHang(new DTO.KhachHang(MaKH, TenKH, DiaChi, SDT, 0));
                    MessageBox.Show("Thêm khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaThongTinThemKH();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm khách hàng thất bại\n Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion

            // Bắt buộc thêm khách hàng thành công mới có thể thoát
            #region Thêm khách hàng từ đặt chỗ
            else
            {
                try { SumKH = bus.DemKhachHang(); }
                catch (Exception) { MessageBox.Show("Không tìm thấy thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                MaKH = LayMaKH(SumKH + 1);
                TenKH = txtTenKhachHang.Text;
                DiaChi = txtDiaChi.Text;
                SDT = txtSDT.Text;
                try
                {
                    bus.ThemKhachHang(new DTO.KhachHang(MaKH, TenKH, DiaChi, SDT, 1));
                    CanExit = true;
                    MessageBox.Show("Thêm khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaThongTinThemKH();
                }
                catch (Exception)
                {
                    CanExit = false;
                    MessageBox.Show("Thêm khách hàng thất bại\n Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ThayDoiThongTin() == false)
                    CanExit = false;
            }
            #endregion
        }

        public static bool CanExit = true;
        private string LayMaKH(int Dem)
        {
            string MaKH = "";
            if (Dem / 10 == 0)
                MaKH = "KH00" + Dem.ToString();
            else if (Dem / 10 > 0 && Dem / 10 > 0)
                MaKH = "KH0" + Dem.ToString();
            else
                MaKH = "KH" + Dem.ToString();
            return MaKH;
        }

        private bool ThayDoiThongTin()
        {
            bool thaydoi = false;
            if (txtTenKhachHang.Text != null && txtDiaChi.Text != null && txtSDT.Text != null)
                thaydoi = true;
            return thaydoi;
        }

        private void btnChangeCanExit_Click(object sender, EventArgs e)
        {
            CanExit = true;
        }

        private void XoaThongTinThemKH()
        {
            txtTenKhachHang.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
        }
    }
}
