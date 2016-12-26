using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_NhanVien
    {
        DataAdapter da;
        public DAO_NhanVien()
        {
            da = new DataAdapter();
        }

        public int DemNhanVien()
        {
            int count;
            string sqlCount = "SELECT COUNT (*) FROM NhanVien";
            try
            {
                da.Connect();
                count = (int)da.ExecuteScalar(sqlCount);
                da.Disconnet();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ThemNhanVien(NhanVien nv)
        {
            string sqlThemNV = @"INSERT INTO NhanVien VALUES ('" + nv.MaNV + "', N'" + nv.TenNV + "', N'" + nv.DiaChi + "', N'" + nv.SDT + "', N'" + nv.CMND + "', N'" + nv.HinhNV + "' )";
            try
            {
                da.Connect();
                int exe = da.ExecuteNonQuery(sqlThemNV);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int XoaNhanVien(string manv)
        {
            string sqlXoaNhanVien = @"DELETE NhanVien WHERE MaNV = '" + manv + "'";
            try
            {
                da.Connect();
                int exe  = da.ExecuteNonQuery(sqlXoaNhanVien);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int SuaNhanVien(NhanVien nv, string MaNV)
        {
            string sqlSuaNhanVien = @"UPDATE NhanVien SET MaNV = '" + nv.MaNV + "', TenNV = N'" + nv.TenNV + "', CMND = '" + nv.CMND +
                "', DiaChi = N'" + nv.DiaChi + "', SDT = '" + nv.SDT + "', HinhNV = '" + nv.HinhNV + "' WHERE MaNV = '" + MaNV + "'";
            try
            {
                da.Connect();
                int exe = da.ExecuteNonQuery(sqlSuaNhanVien);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<NhanVien> XemNhanVien(string tennhanvien)
        {
            string sqlXemNhanVien = @"SELECT * FROM NhanVien WHERE TenNV LIKE N'%" + tennhanvien + "%'";
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            SqlDataReader dr;
            string MaNV, TenNV, CMND, DiaChi, SDT, HinhNV;

            try
            {
                da.Connect();
                dr = da.ExecuteReader(sqlXemNhanVien);
                while (dr.Read())
                {
                    MaNV = dr[0].ToString();
                    TenNV = dr[1].ToString();
                    CMND = dr[2].ToString();
                    DiaChi = dr[3].ToString();
                    SDT = dr[4].ToString();
                    HinhNV = dr[5].ToString();

                    lstNhanVien.Add(new NhanVien(MaNV, TenNV, CMND, DiaChi, SDT, HinhNV));
                }
                da.Disconnet();
                return lstNhanVien;
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public List<NhanVien> XemNhanVien()
        {
            string sqlXemNhanVien = @"SELECT * FROM NhanVien WHERE MaNV LIKE N'NV%'";
            List<NhanVien> lstNhanVien = new List<NhanVien>();
            SqlDataReader dr;
            string MaNV, TenNV, CMND, DiaChi, SDT, HinhNV;

            try
            {
                da.Connect();
                dr = da.ExecuteReader(sqlXemNhanVien);
                while (dr.Read())
                {
                    MaNV = dr[0].ToString();
                    TenNV = dr[1].ToString();
                    CMND = dr[2].ToString();
                    DiaChi = dr[3].ToString();
                    SDT = dr[4].ToString();
                    HinhNV = dr[5].ToString();

                    lstNhanVien.Add(new NhanVien(MaNV, TenNV, CMND, DiaChi, SDT, HinhNV));
                }
                da.Disconnet();
                return lstNhanVien;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> XemTatCaNhanVien()
        {
            string TenNV = "";
            List<string> lstNhanVien = new List<string>();
            string sql = @"SELECT TenNV FROM NhanVien WHERE MaNV LIKE N'NV%'";
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    TenNV = dr[0].ToString();
                    lstNhanVien.Add(TenNV);
                }
                da.Disconnet();
                return lstNhanVien;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> LayTenTatCaNhanVien()
        {
            string TenNV = "";
            List<string> lstNhanVien = new List<string>();
            string sql = @"SELECT TenNV FROM NhanVien ";
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    TenNV = dr[0].ToString();
                    lstNhanVien.Add(TenNV);
                }
                da.Disconnet();
                return lstNhanVien;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string LayMaNVTuTenNV(string TenNV)
        {
            string sql = @"SELECT MaNV FROM NhanVien WHERE TenNV = N'" + TenNV + "'";
            string MaNV = "";
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaNV = dr[0].ToString();
                }
                da.Disconnet();
                return MaNV;
            }
            catch (Exception)
            {
                
                throw;
            }
        }



    }
}
