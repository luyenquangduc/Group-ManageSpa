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
    public partial class NhanVien : UserControl
    {
        Bus bus;
        public NhanVien()
        {
            bus = new Bus();
            InitializeComponent();
        }

        bool mode = true;
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            cbChon.Items.Clear();

            cbChon.Items.Add("Xem tất cả");
            cbChon.Items.Add("Xem theo tên");

            cbChon.SelectedItem = "Xem tất cả";

            try
            {
                dataNhanVien.DataSource = bus.XemNhanVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int TopBtn = 121;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNhanVien = lblMaNV.Text;
            string tenNhanVien = txtTenNhanVien.Text;
            string SDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string hinhNhanVien = txtURL.Text;
            string CMND = txtCMND.Text;
            try
            {
                bus.SuaNhanVien(new DTO.NhanVien(maNhanVien, tenNhanVien, CMND, diaChi, SDT, hinhNhanVien));
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        string MaNV = "";
        private void dataNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataNhanVien.SelectedRows)
            {
                MaNV = dr.Cells[0].Value.ToString();
                lblMaNV.Text = dr.Cells[0].Value.ToString();
                txtTenNhanVien.Text = dr.Cells[1].Value.ToString();
                txtCMND.Text = dr.Cells[2].Value.ToString();
                txtDiaChi.Text = dr.Cells[3].Value.ToString();
                txtSDT.Text = dr.Cells[4].Value.ToString();
                txtURL.Text = dr.Cells[5].Value.ToString();
                try
                {
                    picNhanVien.Image = Image.FromFile(txtURL.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đường dẫn không hợp lệ\nKhông tìm thấy hình ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbChon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbChon.SelectedItem.ToString() == "Xem tất cả")
            {
                btnTimKiem.Top = lblTuKhoa.Top;
                btnXoa.Top = lblTuKhoa.Top;
                lblTuKhoa.Hide();
                txtKyTuTimKiem.Hide();
                mode = true;
            }
            else
            {
                btnTimKiem.Top = TopBtn;
                btnXoa.Top = TopBtn;
                lblTuKhoa.Show();
                txtKyTuTimKiem.Show();
                mode = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                try{dataNhanVien.DataSource = bus.XemNhanVien();}
                catch (Exception){MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            {
                try{dataNhanVien.DataSource = bus.XemNhanVien(txtKyTuTimKiem.Text);}
                catch (Exception){MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                txtURL.Text = choofdlog.FileName;
            else
                txtURL.Text = string.Empty;       
        }

        public static string selectedStaff = "";
        private void dataNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dr in dataNhanVien.SelectedRows){selectedStaff = dr.Cells[5].Value.ToString();}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void txtKyTuTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtKyTuTimKiem.Text != null)
            {
                dataNhanVien.DataSource = bus.XemNhanVien(txtKyTuTimKiem.Text);
            }
            else
                dataNhanVien.DataSource = bus.XemNhanVien();
        }

    }
}
