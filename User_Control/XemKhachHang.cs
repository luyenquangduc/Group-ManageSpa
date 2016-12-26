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
    public partial class XemKhachHang : UserControl
    {
        Bus bus;
        public XemKhachHang()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void XemKhachHang_Load(object sender, EventArgs e)
        {
            dataKhachHang.DataSource = bus.XemKhachHang();
            TopBtn = btnTimKiem.Top;
            InitUserControlKhachHang();
        }

        bool mode = true;// Tìm kiếm theo chế độ tìm tất cả, không cần từ khóa
        int TopBtn;
        private void cbChon_SelectedValueChanged(object sender, EventArgs e)
        {

            string cbBoxSelected = cbChon.SelectedItem.ToString();
            if (cbBoxSelected == "Xem tất cả ") // Chế độ tìm tất cả, textBox từ khóa ẩn, đẩy cao btnTimKiem
            {
                btnTimKiem.Top = lblTuKhoa.Top;
                lblTuKhoa.Hide();
                txtKyTuTimKiem.Hide();
                mode = true;
            }
            else
            {
                btnTimKiem.Top = TopBtn;
                lblTuKhoa.Show();
                txtKyTuTimKiem.Show();
                mode = false;
            }
        }

        void InitUserControlKhachHang()
        {
            cbChon.Items.Clear();

            cbChon.Items.Add("Xem tất cả ");
            cbChon.Items.Add("Xem bằng SDT");

            cbChon.SelectedItem = "Xem tất cả ";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                try
                {
                    dataKhachHang.DataSource = bus.XemKhachHang();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tìm kiếm khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    dataKhachHang.DataSource = bus.XemKhachHang(txtKyTuTimKiem.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tìm kiếm khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void dataKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataKhachHang.SelectedRows)
            {
                lblMaKH.Text = dr.Cells[0].Value.ToString();
                txtTenKhachHang.Text = dr.Cells[1].Value.ToString();
                txtSDT.Text = dr.Cells[2].Value.ToString();
                txtDiaChi.Text = dr.Cells[3].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MaKH, TenKH, SDT, DiaChi;
            int SoLan;

            MaKH = lblMaKH.Text;
            TenKH = txtTenKhachHang.Text;
            SDT = txtSDT.Text;
            DiaChi = txtDiaChi.Text;
            SoLan = bus.DemSoLanKhachHang(MaKH);
            try
            {
                SoLan = bus.DemSoLanKhachHang(MaKH);
                bus.SuaKhachHang(new KhachHang(MaKH, TenKH, SDT, DiaChi, SoLan = bus.DemSoLanKhachHang(MaKH)));
                MessageBox.Show("Sửa khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa khách hàng thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKyTuTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtKyTuTimKiem.Text != null)
                dataKhachHang.DataSource = bus.XemKhachHang(txtKyTuTimKiem.Text);
        }
    }
}
