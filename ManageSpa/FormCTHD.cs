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
using ManageSpa.User_Control;

namespace ManageSpa
{
    public partial class FormCTHD : Form
    {
        Bus bus;
        public FormCTHD()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            CapNhatForm();
        }

        private void CapNhatForm()
        {
            dataCTHD.DataSource = bus.XemChiTietHoaDon(XemHD.MaHD);
            cbDichVu.DataSource = LoadTenDichVuConLai(LoadDichVuConLai(XemHD.MaHD));
        }

        private void CapNhatDatabase()
        {
            DateTime ThoiGian = new DateTime();
            string MaKH = "";
            try
            {
                int TongTien = bus.TinhTienHoaDon(XemHD.MaHD);
                ThoiGian = bus.LayThoiGianHD(XemHD.MaHD);
                MaKH = bus.LayMaKHTuMaHD(XemHD.MaHD);
                bus.CapNhatHoaDon(new DTO.HoaDon(XemHD.MaHD, ThoiGian, TongTien, MaKH));
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại\nVui lòng kiểm tra lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            XemHD xhd = new XemHD();
            xhd.Refresh();
        }

        private List<string> LoadDichVuConLai(string MaHD)
        {
            List<string> lstTatCaLieuTrinh = new List<string>();
            List<string> lstLieuTrinhTrongHD = new List<string>();
            List<string> lstLieuTrinhConLai = new List<string>();
            try
            {
                lstTatCaLieuTrinh = bus.MaDichVu();
                lstLieuTrinhTrongHD = bus.MaDichVuTrongHD(MaHD);
                lstLieuTrinhConLai = new List<string>();
                int chenhLech = lstTatCaLieuTrinh.Count - lstLieuTrinhTrongHD.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật danh sách hóa đơn thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int j = 0; j < lstTatCaLieuTrinh.Count; j++)
                {
                    bool trung = false;
                    for (int k = 0; k < lstLieuTrinhTrongHD.Count; k++)
                    {
                        if (KiemTraTrungLieuTrinh(lstTatCaLieuTrinh[j], lstLieuTrinhTrongHD[k]) == true)
                        {
                            trung = true;
                            break;
                        }
                    }
                    if (trung == false)
                    {
                        lstLieuTrinhConLai.Add(lstTatCaLieuTrinh[j]);
                    }
                }
                return lstLieuTrinhConLai;
        }

        private List<string> LoadTenDichVuConLai(List<string> MaDVConLai)
        {
            List<string> TenDVConLai = new List<string>();
            try
            {
                for (int i = 0; i < MaDVConLai.Count; i++)
                {
                    TenDVConLai.Add(bus.LayTenDV(MaDVConLai[i]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật danh sách dịch vụ còn lại thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return TenDVConLai;
        }

        private bool KiemTraTrungLieuTrinh(string LT1, string LT2)
        {
            if (LT1 == LT2)
                return true;
            else
                return false;
        }

        //Thêm dịch vụ trong CTHD
        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenDV = cbDichVu.SelectedValue.ToString();
            string MaDV = "";
            DateTime ThoiGian = new DateTime();
            try
            {
                MaDV = bus.LayMaDVTuTenDV(TenDV);
                int DonGia = bus.LayDonGia(MaDV);
                ThoiGian = bus.LayThoiGianHD(XemHD.MaHD);
                bus.ThemCTHD(new DTO.CTHD(XemHD.MaHD, MaDV, ThoiGian, DonGia));
                MessageBox.Show("Cập nhật hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CapNhatForm();
            CapNhatDatabase();
        }

        // Xóa dịch vụ trong CTHD
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataCTHD.SelectedRows)
            {
                try
                {
                    bus.XoaCTHD(XemHD.MaHD, dr.Cells[1].Value.ToString());
                    MessageBox.Show("Xoá thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CapNhatForm();
            CapNhatDatabase();
        }

    }
}
