using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace ManageSpa.User_Control
{
    public partial class DatChoCoLich : UserControl
    {

        Bus bus;
        public DatChoCoLich()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void DatChoCoLich_Load(object sender, EventArgs e)
        {
            Init();
            LoadDataKhachHangDatCho();
        }

        // Format datetime picker
        private void Init()
        {
            datePickBegin.Format = DateTimePickerFormat.Custom;
            datePickBegin.CustomFormat = "dd-MMM-yyyy  HH:mm";
            datePickEnd.Format = DateTimePickerFormat.Custom;
            datePickEnd.CustomFormat = "dd-MMM-yyyy  HH:mm";
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text != null)
            {
                if (bus.KiemTraDatChoKhachHang(txtSDT.Text) > 0)
                {
                    string ThongTin = bus.TraVeThongTinDatChoDaTonTai(txtSDT.Text);
                    MessageBox.Show("Quý khách đã đặt chỗ với thời gian\n" + ThongTin);
                }
                else
                    txtSoDienThoai = txtSDT.Text;
            }
        }

        #region Lấy mã giường trống
        List<string> lstGiuongTrong;
        private List<string> MaGiuongTrong(DateTime TGDCBD, DateTime TGDCKT)
        {
            bool kq = false;
            lstGiuongTrong = new List<string>();
            for (int i = 1; i <= bus.DemGiuong(); i++)
            {
                try
                {
                    kq = bus.KiemTraGiuongTrong(LayMaGiuong(i), TGDCBD, TGDCKT);
                    if (kq == true)
                    {
                        lstGiuongTrong.Add(LayMaGiuong(i));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra thất bại");
                }
            }
            return lstGiuongTrong;
        }

        private string LayMaGiuong(int SoDem)
        {
            if (SoDem / 10 == 0)
                return "GI00" + SoDem.ToString();
            else if (SoDem / 10 > 0 && SoDem / 100 == 0)
                return "GI0" + SoDem.ToString();
            else
                return "GI" + SoDem.ToString();
        }
        #endregion

        // Mở form liệu trình
        private void btnLieuTrinh_Click(object sender, EventArgs e)
        {
            FormDichVu fdv = new FormDichVu();
            fdv.Show();
        }
        
        // Chọn thời gian bắt đầu, thời gian kết thúc tự động, load những giường trống để chọn
        private void datePickBegin_ValueChanged(object sender, EventArgs e)
        {
            int countTime = 0;
            for (int i = 0; i < LieuTrinh.GetDichVu.Length; i++)
            {
                if (LieuTrinh.GetDichVu[i] != null)
                    countTime += bus.LayThoiGianSuDung(LieuTrinh.GetDichVu[i]);
            }
            datePickEnd.Value = datePickBegin.Value.AddMinutes(countTime);
            MaGiuongTrong(datePickBegin.Value, datePickEnd.Value);
            try
            {
                cbGiuong.DataSource = lstGiuongTrong;
            }
            catch (Exception)
            {
                MessageBox.Show("Không còn giường trống trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public static string txtSoDienThoai;
        public static bool ThemKhachHangTuDatCho = false;
        private void btnDatCho_Click(object sender, EventArgs e)
        {
            try
            {
                bool TonTai = bus.KiemTraTonTaiKhachHangBangSDT(txtSDT.Text);
                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                }
                else
                {
                    // Thêm hóa đơn bình thường 
                    #region Thêm hóa đơn vào cơ sở dữ liệu
                    if (TonTai == true)
                    {
                        if (clickDatePick == false)
                            MessageBox.Show("Vui lòng chọn thời gian bắt đầu\nHệ thống sẽ tự động tính thời gian kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtSDT.Text != "" && clickDatePick == true) // Đặt chỗ + Thêm HD + Thêm CTHD
                        {
                            #region Đặt chỗ
                            string MaDC = "", MaGiuong = "", SDT = "";
                            DateTime TGBD = DateTime.Now, TGKT = DateTime.Now;

                            MaDC = LayMaDC(bus.DemDatCho() + 1);
                            MaGiuong = cbGiuong.SelectedValue.ToString();
                            SDT = txtSDT.Text;

                            TGBD = (DateTime)datePickBegin.Value;
                            TGKT = (DateTime)datePickEnd.Value;
                            try
                            {
                                bus.DatCho(new DatCho(MaDC, MaGiuong, SDT, TGBD, TGKT));
                                MessageBox.Show("Đặt chỗ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                XoaTrangControl();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Đặt chỗ thất bại\nVui lòng thử lại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                            #region Thêm hóa đơn
                            string MaHD = "", MaKH = "";
                            DateTime date;
                            MaHD = LayMaHD(bus.DemHoaDon() + 1);
                            date = datePickBegin.Value;
                            MaKH = bus.TraVeMaKHTuSDT(SDT);
                            try
                            {
                                bus.ThemHD(new HoaDon(MaHD, date, 0, MaKH));
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion

                            #region Thêm chi tiết hóa đơn
                            for (int i = 0; i < LieuTrinh.GetDichVu.Length; i++)
                            {
                                try
                                {
                                    if (LieuTrinh.GetDichVu[i] != null)
                                    {
                                        int DonGia = bus.LayDonGia(LieuTrinh.GetDichVu[i]);
                                        bus.ThemCTHD(new CTHD(MaHD, LieuTrinh.GetDichVu[i], date, DonGia));
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Thêm hóa đơn thất bại\nVui lòng thử lại sau", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            LieuTrinh.GetDichVu = null;
                            #endregion

                            #region Cập nhật tổng tiền hóa đơn
                            int TongTien = bus.TinhTienHoaDon(MaHD);
                            try
                            {
                                bus.CapNhatHoaDon(new HoaDon(MaHD, date, TongTien, MaKH));
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Cập nhật thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            #endregion
                        }
                    }
                    #endregion

                    // Bắt buộc thêm khách hàng rồi mới thêm hóa đơn
                    #region Mở form thêm khách hàng và thêm khách hàng
                    else if (TonTai == false)
                    {
                        FormKhachHang fkh = new FormKhachHang();
                        fkh.Size = new Size(603, 178);
                        ThemKhachHang tkh = new ThemKhachHang();
                        fkh.pnlKhachHang.Controls.Add(tkh);
                        fkh.pnlKhachHang.Size = new Size(586, 111);
                        tkh.Show();
                        ThemKhachHangTuDatCho = true;
                        fkh.ShowDialog();
                    }
                    #endregion
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra tồn tại thất bại\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Load khách hàng đặt chỗ hôm nay và ngày mai lên datagridview
        private void LoadDataKhachHangDatCho()
        {
            DateTime today = DateTime.Today;
            try{dataKhachHangHomNay.DataSource = bus.DanhSachDatCho(today);}
            catch (Exception)
            {MessageBox.Show("Cập nhật danh sách khách hàng hôm nay thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);}

            DateTime tomorrow = today.AddDays(1);
            try{ dataKhachHangNgayMai.DataSource = bus.DanhSachDatCho(tomorrow);}
            catch (Exception){ MessageBox.Show("Cập nhật danh sách khách hàng ngày mai thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);}

        }

        bool clickDatePick = false;
        private void datePickBegin_MouseDown(object sender, MouseEventArgs e)
        {
            clickDatePick = true;
        }

        private string LayMaHD(int DemHoaDon)
        {
            string MaHD = "";
            if (DemHoaDon / 10 == 0)
                MaHD = "HD00" + DemHoaDon.ToString();
            else if (DemHoaDon > 0 && DemHoaDon / 100 == 0)
                MaHD = "HD0" + DemHoaDon.ToString();
            else if (DemHoaDon/10 > 10)
                MaHD = "HD" + DemHoaDon.ToString();
            return MaHD;
        }

        public string LayMaDC(int SoDem)
        {
            if (SoDem / 10 == 0)
                return "DC00" + SoDem.ToString();
            else if (SoDem / 10 > 0 && SoDem / 100 == 0)
                return "DC0" + SoDem.ToString();
            else
                return "DC" + SoDem.ToString();
        }

        public string LayMaKH(int SoDem)
        {
            if (SoDem / 10 == 0)
                return "KH00" + SoDem.ToString();
            else if (SoDem / 10 > 0 && SoDem / 100 == 0)
                return "KH0" + SoDem.ToString();
            else
                return "KH" + SoDem.ToString();
        }

        private void XoaTrangControl()
        {
            txtSDT.Text = "";
            datePickBegin.Value = DateTime.Now;
            datePickEnd.Value = DateTime.Now;
            cbGiuong.DataSource = null;
        }
    }
}
