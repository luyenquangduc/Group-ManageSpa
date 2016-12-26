using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class Bus
    {
        public bool KiemTraDangNhap(string tk, string mk)
        {
            return new DAO_TaiKhoan().KiemTraDangNhap(tk, mk);
        }

        public int KiemSoatDangNhap(string TK, string MaNV, DateTime date)
        {
            return new DAO_TaiKhoan().KiemSoatDangNhap(TK, MaNV, date);
        }

        public int DemSoLanDangNhapTaiKhoan(string TenTK)
        {
            return new DAO_TaiKhoan().DemSoDangNhapTaiKhoan(TenTK);
        }

        public List<TaiKhoan> LoadTaiKhoanToCbBox()
        {
            return new DAO_TaiKhoan().LoadTaiKhoanToCbBox();
        }

        public List<NhanVien> XemNhanVien()
        {
            return new DAO_NhanVien().XemNhanVien();
        }

        public List<NhanVien> XemNhanVien(string TenNV) 
        {
            return new DAO_NhanVien().XemNhanVien(TenNV);
        }
        
        public List<string> XemTatCaNhanVien()
        {
            return new DAO_NhanVien().XemTatCaNhanVien();
        }

        public int ThemNhanVien(NhanVien nv)
        {
            return new DAO_NhanVien().ThemNhanVien(nv);
        }

        public int SuaNhanVien(NhanVien nv)
        {
            return new DAO_NhanVien().SuaNhanVien(nv, nv.MaNV);
        }

        public int DemNhanVien()
        {
            return new DAO_NhanVien().DemNhanVien();
        }

        public string KiemTraLoaiTaiKhoan(string tenTK)
        {
            return new DAO_TaiKhoan().KiemTraLoaiTaiKhoan(tenTK);
        }

        public int ThemTaiKhoan(DTO.TaiKhoan taikhoan)
        {
            return new DAO_TaiKhoan().ThemTaiKhoan(taikhoan);
        }

        public int XoaTaiKhoan(string tenTK)
        {
            return new DAO_TaiKhoan().XoaTaiKhoan(tenTK);
        }

        public List<TaiKhoan> XemTaiKhoan()
        {
            return new DAO_TaiKhoan().XemTaiKhoan();
        }

        public DataTable LoadKhachHangToCbBox()
        {
            return new DAO.DAO_KhachHang().LoadComboKhachHang();
        }

        public List<KhachHang> TimKhachHangTheoTen(string TenKhachHang)
        {
            return new DAO_KhachHang().XemKhachHang(TenKhachHang);
        }

        public List<KhachHang> XemKhachHang()
        {
            return new DAO_KhachHang().XemKhachHang();
        }

        public List<KhachHang> XemKhachHang(string SDT_Search)
        {
            return new DAO_KhachHang().XemKhachHang(SDT_Search);
        }

        public int DemKhachHang()
        {
            return new DAO.DAO_KhachHang().DemKhachHang();
        }

        public int ThemKhachHang(KhachHang KhachHang)
        {
            return new DAO.DAO_KhachHang().ThemKhachHang(KhachHang);
        }

        public int DemSoLanKhachHang(string MaKH)
        {
            return new DAO_KhachHang().DemSoLanKhachHang(MaKH);
        }

        public int ThongKeKhachHang(string ThongKeTheoLoai, int Thang, int Nam)
        {
            return new DAO_KhachHang().ThongKeKhachHang(ThongKeTheoLoai, Thang, Nam);
        }

        public List<string> XemTenKhachHang(string TenKH)
        {
            return new DAO_KhachHang().XemTenKhachHang(TenKH);
        }

        public string LayMaKH(string TenKH)
        {
            return new DAO_KhachHang().LayIDKhachHang(TenKH);
        }

        public string TraVeMaKHTuSDT(string SDT)
        {
            return new DAO_KhachHang().TraVeMaKHTuSDT(SDT);
        }

        public int SuaKhachHang(KhachHang KH)
        {
            return new DAO_KhachHang().SuaKhachHang(KH);
        }

        public bool KiemTraTonTaiKhachHangBangSDT(string SDT)
        {
            return new DAO_KhachHang().KiemTraTonTaiKhachHangBangSDT(SDT);
        }

        public int DemHoaDon()
        {
            return new DAO_HoaDon().DemHoaDon();
        }

        public int ThemDichVu(DichVu dv)
        {
            return new DAO_DichVu().ThemDichVu(dv);
        }

        public int XoaDichVu(string MaDV)
        {
            return new DAO_DichVu().XoaDichVu(MaDV);
        }

        public List<DichVu> XemDichVu()
        {
            return new DAO_DichVu().XemDichVu();
        }

        public DataTable XemTenDichVu()
        {
            return new DAO_DichVu().XemTenDichVu();
        }

        public int LayDonGia(string MaDV)
        {
            return new DAO_DichVu().LayDonGia(MaDV);
        }

        public int KiemTraDatChoKhachHang(string SDT)
        {
            return new DAO_KhachHang().KiemTraDatChoKhachHang(SDT);
        }

        public string TraVeTen(string SDT)
        {
            return new DAO_KhachHang().TraVeTenKH(SDT);
        }

        public string TraVeThongTinDatChoDaTonTai(string SDT)
        {
            return new DAO_KhachHang().TraVeThongTinDatChoDaTonTai(SDT);
        }

        public List<ThoiGianDangNhap> XemThongTinDangNhap(string ID)
        {
            return new DAO_TaiKhoan().ThoiGianDangNhap(ID);
        }

        public int ThemLoaiTK(LoaiTaiKhoan ltk)
        {
            return new DAO_TaiKhoan().ThemLoaiTK(ltk);
        }

        public int ThemCTHD(CTHD cthd)
        {
            return new DAO_CTHD().ThemCTHD(cthd);
        }

        public int ThemHD(HoaDon hd)
        {
            return new DAO_HoaDon().ThemHoaDon(hd);
        }

        public int TinhTienHoaDon(string MaHD)
        {
            return new DAO_HoaDon().TinhTienHoaDon(MaHD);
        }

        public int CapNhatHoaDon(HoaDon hd)
        {
            return new DAO_HoaDon().CapNhatHoaDon(hd);
        }

        public List<HoaDon> XemHoaDonCuaKhachHang(string MaKH)
        {
            return new DAO_HoaDon().XemHoaDonCuaKhachHang(MaKH);
        }

        public List<CTHD> XemChiTietHoaDon(string MaHD)
        {
            return new DAO_CTHD().XemChiTietHoaDon(MaHD);
        }

        public string LayMaKHTuMaHD(string MaHD)
        {
            return new DAO_HoaDon().LayMaKHTuMaHD(MaHD);
        }

        public DateTime LayThoiGianHD(string MaHD)
        {
            return new DAO_CTHD().LayThoiGianHD(MaHD);
        }

        public int XoaCTHD(string MaHD, string MaDV)
        {
            return new DAO_CTHD().XoaCTHD(MaHD, MaDV);
        }

        public string LayMaNV(string TenNV)
        {
            return new DAO_TaiKhoan().LayMaNV(TenNV);
        }

        public string LayMaNVTuTenNV(string TenNV)
        {
            return new DAO_NhanVien().LayMaNVTuTenNV(TenNV);
        }

        public List<DatCho> LoadThongTinDatCho()
        {
            return new DAO_DatCho().DanhSachDatCho();
        }

        public int DatCho(DatCho dc)
        {
            return new DAO_DatCho().DatCho(dc);
        }

        public int DemGiuong()
        {
            return new DAO_Giuong().DemGiuong();
        }

        public int XoaDatCho(string MaDC)
        {
            return new DAO_DatCho().XoaDatCho(MaDC);
        }

        public int SuaDatCho(DatCho dc)
        {
            return new DAO_DatCho().SuaDatCho(dc);
        }

        public int DemDatCho()
        {
            return new DAO_DatCho().DemMaDatCho();
        }

        public bool KiemTraGiuongTrong(string MaGiuong, DateTime TGDCBD, DateTime TGDCKT)
        {
            return new DAO_Giuong().KiemTraGiuongTrong(MaGiuong, TGDCBD, TGDCKT);
        }

        public List<DatCho> DanhSachDatCho()
        {
            return new DAO_DatCho().DanhSachDatCho();
        }

        public List<DatCho> DanhSachDatCho(DateTime Ngay)
        {
            return new DAO_DatCho().DanhSachDatCho(Ngay);
        }

        public int XoaGiuongDaDat(string MaGiuong)
        {
            return new DAO_Giuong().XoaGiuongDat(MaGiuong);
        }

        public int DemDichVu()
        {
            return new DAO_DichVu().DemDichVu();
        }

        public string LayTenDV(string MaDV)
        {
            return new DAO_DichVu().LayTenDichVu(MaDV);
        }

        public int LayThoiGianSuDung(string MaDV)
        {
            return new DAO_DichVu().LayThoiGianSuDung(MaDV);
        }

        public List<string> MaDichVuTrongHD(string MaHD)
        {
            return new DAO_DichVu().MaDichVuTrongHD(MaHD);
        }

        public List<string> MaDichVu()
        {
            return new DAO_DichVu().MaDichVu();
        }

        public string LayMaDVTuTenDV(string TenDV)
        {
            return new DAO_DichVu().LayMaDVTuTenDV(TenDV);
        }

        public List<bool> DanhSachDiemDanhNhanVien(string MaNV, int Thang, int Nam) 
        {
            return new DAO_Luong().DanhSachDiemDanhNhanVien(MaNV, Thang, Nam);
        }
    }   
}
