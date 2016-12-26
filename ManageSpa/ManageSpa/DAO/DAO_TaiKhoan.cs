using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        DataAdapter da;
        public DAO_TaiKhoan()
        {
            da = new DataAdapter();
        }
        
        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string sqlKiemTra = @"SELECT COUNT(*) FROM TaiKhoan WHERE ID = '" + taiKhoan + "' AND Pass = '" + matKhau + "'";
            bool kiemTra = false;
            try
            {
                da.Connect();
                int sum = (int)da.ExecuteScalar(sqlKiemTra);
                if (sum > 0)
                {
                    kiemTra = true;
                }
                da.Disconnet();
                return kiemTra;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ThemTaiKhoan(TaiKhoan Taikhoan)
        {
            string sqlTaoTK = @"INSERT INTO TaiKhoan VALUES ('" + Taikhoan.ID + "', '" + Taikhoan.PassWord + "', N'" + Taikhoan.MaNV + "')";
            try
            {
                da.Connect();
                int exe = da.ExecuteNonQuery(sqlTaoTK);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }
        }

        public int XoaTaiKhoan(string ID)
        {
            string sqlXoa = @"DELETE TaiKhoan WHERE ID = '" + ID + "' ";
            try
            {
                da.Connect();
                int exe = (int)da.ExecuteNonQuery(sqlXoa);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string KiemTraLoaiTaiKhoan(string taiKhoan)
        {
            string loaiTK = "";
            string sql = @"SELECT * FROM TaiKhoan WHERE ID = N'" + taiKhoan + "'";
            try
            {
                List<TaiKhoan> lstLoaiTK = new List<TaiKhoan>();
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    loaiTK = dr[2].ToString();
                    lstLoaiTK.Add(new TaiKhoan("", "", loaiTK));
                }
                da.Disconnet();
                return loaiTK;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TaiKhoan> XemTaiKhoan() 
        {
            string sqlXemTK = @"SELECT * FROM TaiKhoan";
            List<TaiKhoan> lstTaiKhoan = new List<TaiKhoan>();
            SqlDataReader dr;
            string TenTaiKhoan, MatKhau, LoaiTK;
            try
            {
                da.Connect();
                dr = da.ExecuteReader(sqlXemTK);
                while (dr.Read())
                {
                    TenTaiKhoan = dr[0].ToString();
                    MatKhau = dr[1].ToString();
                    LoaiTK = dr[2].ToString();

                    lstTaiKhoan.Add(new TaiKhoan(TenTaiKhoan, MatKhau, LoaiTK));
                }
                da.Disconnet();
                return lstTaiKhoan;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int KiemSoatDangNhap(string TK, string MaNV, DateTime date)
        {
            string sql = @"INSERT INTO ThoiGianDangNhap VALUES(N'"+ TK + "', '" + MaNV + "', '" + date + "')";
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
            return 0;
        }

        public int DemSoDangNhapTaiKhoan(string TK)
        {
            string sql = @"SELECT COUNT(ID) FROM ThoiGianDangNhap WHERE ID = N'" + TK + "'";
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

        public List<TaiKhoan> LoadTaiKhoanToCbBox()
        {
            string sql = @"SELECT ID FROM TaiKhoan";
            List<TaiKhoan> lstTK = new List<TaiKhoan>();
            string TenTK;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    TenTK = dr[0].ToString();
                    lstTK.Add(new TaiKhoan(TenTK));
                }
                da.Disconnet();
                return lstTK;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<ThoiGianDangNhap> ThoiGianDangNhap(string ID)
        {
            string sql = @"SELECT * FROM ThoiGianDangNhap WHERE MaNV = N'" + ID + "'";
            List<ThoiGianDangNhap> lstDN = new List<ThoiGianDangNhap>();
            string Tentk, Manv;
            DateTime Date;
            int Count;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while(dr.Read())
                {
                    Tentk = dr[0].ToString();
                    Manv = dr[1].ToString();
                    Date = (DateTime)dr[2];
                    lstDN.Add(new ThoiGianDangNhap(Tentk, Manv, Date));
                }
                da.Disconnet();
                return lstDN;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string LayMaNV(string TenNV)
        {
            string sql = @"SELECT MaNV FROM TaiKhoan WHERE ID = N'" + TenNV + "'";
            try
            {
                da.Connect();
                string MaNV = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return MaNV;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ThemLoaiTK(LoaiTaiKhoan ltk)
        {
            string sql = @"INSERT INTO LoaiTaiKhoan VALUES ('" + ltk.ID + "', '" + ltk.LoaiTK + "')";
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
    }
}
