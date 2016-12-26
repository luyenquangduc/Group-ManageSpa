using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DAO_HoaDon
    {
        DataAdapter da;

        public DAO_HoaDon()
        {
            da = new DataAdapter();
        }

        public int ThemHoaDon(HoaDon hd)
        {
            string sql = @"INSERT INTO HoaDon VALUES (N'"+ hd.MaHD + "', N'" + hd.ThoiGian + "', '" + hd.TongTien + "', '" + hd.MaKH + "')";
            try
            {
                da.Connect();
                int rt = da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int ThemSanPhamVaoHoaDon(string MaKH, string MaSP, int SoLuong) 
        {
            string sqlThemSP = "";
            try
            {
                da.Connect();
                int rt = da.ExecuteNonQuery(sqlThemSP);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int DemHoaDon()
        {
            int count;
            string sql = @"SELECT COUNT(MaHD) FROM HoaDon";
            try
            {
                da.Connect();
                count = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int CapNhatHoaDon(HoaDon hd)
        {
            string sql = @"UPDATE HoaDon SET ThoiGian = N'" + hd.ThoiGian + "', TongTien = N'" + hd.TongTien + "', MaKH = N'" + hd.MaKH + "' WHERE MaHD = N'" + hd.MaHD + "'";
            try
            {
                da.Connect();
                int rt = da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int TinhTienHoaDon(string MaHD)
        {
            string sql = @"SELECT DonGia FROM CTHD WHERE MaHD = N'" + MaHD + "'";
            int sum = 0;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    sum += (int)dr[0];
                }
                da.Disconnet();
                return sum;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<HoaDon> XemHoaDonCuaKhachHang(string MaKH)
        {
            string sql = @"SELECT *FROM HoaDon WHERE MaKH = N'" + MaKH + "'";
            List<HoaDon> lstHoaDon = new List<HoaDon>();
            string MaHD, Makh;
            DateTime ThoiGian;
            int TongTien;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaHD = dr[0].ToString();
                    ThoiGian = (DateTime)dr[1];
                    TongTien = (int)dr[2];
                    Makh = dr[3].ToString();

                    lstHoaDon.Add(new HoaDon(MaHD, ThoiGian, TongTien, Makh));
                }
                da.Disconnet();
                return lstHoaDon;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaKHTuMaHD(string MaHD)
        {
            string sql = @"SELECT MaKH FROM HoaDon WHERE MaHD = N'" + MaHD + "'";
            string MaKH;
            try
            {
                da.Connect();
                MaKH = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return MaKH;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
