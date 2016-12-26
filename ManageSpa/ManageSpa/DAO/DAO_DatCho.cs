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
    public class DAO_DatCho
    {
        DataAdapter da;
        public DAO_DatCho()
        {
            da = new DataAdapter();
        }

        public List<DatCho> DanhSachDatCho()
        {
            string sql = @"SELECT * FROM DatCho";
            List<DatCho> lstDatCho = new List<DatCho>();
            string MaDC, MaGiuong, SDT;
            DateTime TGBD, TGKT;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaDC = dr[0].ToString();
                    MaGiuong = dr[1].ToString();
                    SDT = dr[2].ToString();
                    TGBD = (DateTime)dr[3];
                    TGKT = (DateTime)dr[4];

                    lstDatCho.Add(new DatCho(MaDC, MaGiuong, SDT, TGBD, TGKT));
                }
                da.Disconnet();
                return lstDatCho;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int DatCho(DatCho dc)
        {
            string sql = @"INSERT INTO DatCho VALUES (N'" + dc.MaDC + "', N'" + dc.MaGiuong + "', N'" + dc.SDT + "', N'" + dc.ThoiGianBatDau + "', N'" + dc.ThoiGianKetThuc + "')";
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

        public int XoaDatCho(string MaDC)
        {
            string sql = @"DELETE DatCho WHERE MaDC = N'" + MaDC + "'";
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

        public int SuaDatCho(DatCho dc)
        {
            string sql = @"UPDATE DatCho SET MaGiuong = N'" + dc.MaGiuong + "', SDT = N'" + dc.SDT +
                "', ThoiGianBatDau = N'" + dc.ThoiGianBatDau + "', ThoiGianKetThuc = N'" + dc.ThoiGianKetThuc +
                "' WHERE MaDC = N'" + dc.MaDC + "'";
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

        public int DemMaDatCho()
        {
            string sql = @"SELECT COUNT(MaDC) FROM DatCho";
            try
            {
                da.Connect();
                int count = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                return count;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<DatCho> DanhSachDatCho(DateTime Ngay)
        {
            string sql = @"SELECT * FROM DatCho WHERE ThoiGianBatDau >= '" + Ngay + "' AND ThoiGianBatDau <= '" + Ngay.AddDays(1) + "'";
            string MaDC, MaGiuong, SDT;
            DateTime TGBD, TGKT;
            List<DatCho> lstDSDatCho = new List<DatCho>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while(dr.Read())
                {
                    MaDC = dr[0].ToString();
                    MaGiuong = dr[1].ToString();
                    SDT = dr[2].ToString();
                    TGBD = (DateTime)dr[3];
                    TGKT = (DateTime)dr[4];

                    lstDSDatCho.Add(new DatCho(MaDC, MaGiuong, SDT, TGBD, TGKT));
                }
                da.Disconnet();
                return lstDSDatCho;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
