using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAO
{
    public class DAO_CTHD
    {
        DataAdapter da;
        public DAO_CTHD()
        {
            da = new DataAdapter();
        }

        public int ThemCTHD(CTHD cthd)
        {
            string sql = @"INSERT INTO CTHD VALUES (N'" + cthd.MaHD + "', N'" + cthd.MaDV +
                 "', N'" + cthd.ThoiGian + "', N'" + cthd.DonGia + "')";
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

        public int XoaCTHD(string MaHD, string MaDV)
        {
            string sql = @"DELETE CTHD WHERE MaDV = N'" + MaDV + "' AND MaHD = N'" + MaHD + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteNonQuery(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<CTHD> XemChiTietHoaDon(string MaHD) 
        {
            string sql = @"SELECT * FROM CTHD WHERE MaHD = N'" + MaHD + "'";
            string Mahd, MaDV;
            DateTime date;
            int DonGia;
            List<CTHD> lstCTHD = new List<CTHD>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    Mahd = dr[0].ToString();
                    MaDV = dr[1].ToString();
                    date = (DateTime)dr[2];
                    DonGia = (int)dr[3];

                    lstCTHD.Add(new CTHD(Mahd, MaDV, date, DonGia));
                }
                da.Disconnet();
                return lstCTHD;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DateTime LayThoiGianHD(string MaHD)
        {
            string sql = @"SELECT ThoiGian FROM HoaDon WHERE MaHD = N'" + MaHD + "'";
            try
            {
                da.Connect();
                DateTime thoigian = (DateTime)da.ExecuteScalar(sql);
                da.Disconnet();
                return thoigian;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
