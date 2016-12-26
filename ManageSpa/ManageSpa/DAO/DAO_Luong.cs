using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Luong
    {
        DataAdapter da;
        public DAO_Luong()
        {
            da = new DataAdapter();
        }
        public double TinhLuongNV(string MaNV, DateTime thoigian)
        {
            string sql = @"SELECT HeSoLuong FROM Luong WHERE MaNV = N'" + MaNV + "'";
            double HeSoLuong = 0;
            int Month = thoigian.Month;
            try
            {
                da.Connect();
                int TongLuongThang = (int)da.ExecuteScalar(sql);
                //double HeSoLuong = (double)TongLuongThang/Month);

                da.Disconnet();
                return HeSoLuong;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<double> DanhSachDiemDanhNhanVien(string MaNV, int Thang, int Nam) 
        {
            List<double> lstDiemDanh = new List<double>();
            int rt;
            for (int i = 1; i < TraVeSoNgay(Thang, Nam); i++)
            {
                string sql = @"SELECT COUNT(" + MaNV + ") FROM ThoiGianDangNhap WHERE ThoiGianDangNhap > '" +
                    Nam + "-" + Thang + "-" + i + " 00:00:00.001' AND ThoiGianDangNhap < '" +
                    Nam + "-" + Thang + "-" + i + " 23:59:59.999'";

                try
                {
                    da.Connect();
                    rt = (int)da.ExecuteScalar(sql);
                    da.Disconnet();
                }
                catch (Exception) { throw;}
                if (rt > 0)
                {
                    string sqlMaxTimeInDate = @"SELECT MAX(ThoiGianDangNhap) FROM ThoiGianDangNhap WHERE ThoiGianDangNhap > '" +
                    Nam + "-" + Thang + "-" + i + " 00:00:00.001' AND ThoiGianDangNhap < '" +
                    Nam + "-" + Thang + "-" + i + " 23:59:59.999'";
                    string sqlMinTimeInDate = @"SELECT MIN(ThoiGianDangNhap) FROM ThoiGianDangNhap WHERE ThoiGianDangNhap > '" +
                    Nam + "-" + Thang + "-" + i + " 00:00:00.001' AND ThoiGianDangNhap < '" +
                    Nam + "-" + Thang + "-" + i + " 23:59:59.999'";
                    
                }
                else
                    lstDiemDanh.Add(0.0);
            }
            return lstDiemDanh;
        }

        private int TraVeSoNgay(int Thang, int Nam)
        {
            int soNgay = 0;
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30;
                    break;
                case 2:
                    if (Nam / 4 == 0)
                        soNgay = 28;
                    else
                        soNgay = 29;
                    break;
            }
            return soNgay;
        }
    }
}
