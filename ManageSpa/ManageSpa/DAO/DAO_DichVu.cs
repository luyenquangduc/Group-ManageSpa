using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DAO_DichVu
    {
        DataAdapter da;
        public DAO_DichVu()
        {
            da = new DataAdapter();
        }
        public List<DichVu> XemDichVu() 
        {
            string sql = @"SELECT * FROM DichVu";
            List<DichVu> lstDv = new List<DichVu>();
            string MaDV, TenDV;
            int DonGia, ThoiGianSuDung;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaDV = dr[0].ToString();
                    TenDV = dr[1].ToString();
                    DonGia = (int)dr[2];
                    ThoiGianSuDung = (int)dr[3];
                    lstDv.Add(new DichVu(MaDV, TenDV, DonGia, ThoiGianSuDung));
                }
                da.Disconnet();
                return lstDv;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable XemTenDichVu()
        {
            string sql = @"SELECT TenDV FROM DichVu";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                    con.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ThemDichVu(DichVu dv)
        {
            string sql = @"INSERT INTO DichVu VALUES('" + dv.MaDV + "', N'" + dv.TenDV+ "', " + dv.Gia + "', '" 
            + dv.ThoiGianSuDung +   "')";
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

        public int DemDichVu()
        {
            string sql = @"SELECT COUNT(MaDV) FROM DichVu";
            try
            {
                da.Connect();
                int sumDV = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                return sumDV;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int XoaDichVu(string MaDV)
        {
            string sql = @"DELETE DichVu WHERE MaDV = N'" + MaDV + "'";
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

        public string LayTenDichVu(string MaDV)
        {
            string sql = @"SELECT TenDV FROM DichVu WHERE MaDV = N'" + MaDV + "'";
            try
            {
                da.Connect();
                string TenDV = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return TenDV;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int LayThoiGianSuDung(string MaDV)
        {
            string sql = @"SELECT ThoiGianSuDung FROM DichVu WHERE MaDV = N'" + MaDV + "'";
            try
            {
                da.Connect();
                int time = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                return time;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int LayDonGia(string MaDV)
        {
            string sql = @"SELECT DonGia FROM DichVu WHERE MaDV = N'" + MaDV + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<string> MaDichVuTrongHD(string MaHD)
        {
            string sql = @"SELECT MaDV FROM CTHD WHERE MaHD = N'" + MaHD + "'";

            List<string> lstHienCo = new List<string>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    lstHienCo.Add(dr[0].ToString());
                }
                da.Disconnet();
                return lstHienCo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> MaDichVu()
        {
            string sql = @"SELECT MaDV FROM DichVu";
            List<string> lstDichVu = new List<string>();
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                    lstDichVu.Add(dr[0].ToString());
                da.Disconnet();
                return lstDichVu;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaDVTuTenDV(string TenDV)
        {
            string sql = @"SElECT MaDV FROM DichVu WHERE TenDV = N'" + TenDV + "'";
            try
            {
                da.Connect();
                string MaDV = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return MaDV;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
