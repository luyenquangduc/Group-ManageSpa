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
    public class DAO_KhachHang
    {
        DataAdapter da;
        public DAO_KhachHang()
        {
            da = new DataAdapter();
        }

        public List<KhachHang> XemKhachHang()
        {
            string sqlXemKhachHang = @"SELECT * FROM KhachHang";
            try
            {
                List<KhachHang> lstKhachHang = new List<KhachHang>();

                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sqlXemKhachHang);
                string MaKH, TenKH, DiaChi, SDT;
                int soLan;
                while (dr.Read())
                {
                    MaKH = dr[0].ToString();
                    TenKH = dr[1].ToString();
                    SDT = dr[2].ToString();
                    DiaChi = dr[3].ToString();
                    soLan = (int)dr[4];
                    lstKhachHang.Add(new KhachHang(MaKH, TenKH, SDT, DiaChi, soLan));
                }
                da.Disconnet();
                return lstKhachHang;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<KhachHang> XemKhachHang(string SDT_Search)
        {
            string sqlXemKhachHang = @"SELECT * FROM KhachHang WHERE SDT LIKE N'%" + SDT_Search + "%'";
            try
            {
                List<KhachHang> lstKhachHang = new List<KhachHang>();
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sqlXemKhachHang);
                string MaKH, TenKH, DiaChi, SDT;
                int soLan;
                while (dr.Read())
                {
                    MaKH = dr[0].ToString();
                    TenKH = dr[1].ToString();
                    SDT = dr[2].ToString();
                    DiaChi = dr[3].ToString();
                    soLan = (int)dr[4];
                    lstKhachHang.Add(new KhachHang(MaKH, TenKH, SDT, DiaChi, soLan));
                }
                da.Disconnet();
                return lstKhachHang;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ThemKhachHang(KhachHang kh)
        {
            string sqlThemKH = @"INSERT INTO KhachHang VALUES (N'" + kh.MaKH + "', N'" + kh.TenKH + "', N'" + kh.DiaChi + "', N'" + kh.SDT + "', '" + kh.SoLan + "')";
            try
            {
                da.Connect();
                int exe = da.ExecuteNonQuery(sqlThemKH);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int SuaKhachHang(KhachHang kh)
        {
            string sqlSuaKH = @"UPDATE KhachHang SET TenKH = N'" + kh.TenKH + "', SDT = '" + kh.SDT +
                "', DiaChi = N'" + kh.DiaChi + "' WHERE MaKH = '" + kh.MaKH + "'";

            try
            {
                da.Connect();
                int exe = da.ExecuteNonQuery(sqlSuaKH);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int XoaKhachHang(string makh)
        {
            string sqlXoaKH = @"DELETE KhachHang WHERE MaKH = '" + makh + "'";
            try
            {
                da.Connect();
                int exe = (int)da.ExecuteNonQuery(sqlXoaKH);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable LoadComboKhachHang()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\JEIDO3INS;Initial Catalog=ManageSpa;Integrated Security=True");
                con.Open();
                string strCmd = @"SELECT TenKH FROM KhachHang";
                SqlCommand cmd = new SqlCommand(strCmd, con);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                con.Close();

                return dt;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int DemKhachHang()
        {
            string sql = "SELECT COUNT(*) FROM KhachHang";
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

        public int ThongKeKhachHang(string ThongKeTheoLoai, int Thang, int Nam)
        {
            string sqlThongKe = "";
            int soKhachHang = 0;
            try
            {
                if (ThongKeTheoLoai == "TheoThang")
                {
                    sqlThongKe = @"SELECT COUNT( DISTINCT HoaDon.MaKH)
                           FROM HoaDon, KhachHang
                           WHERE HoaDon.MaKH = KhachHang.MaKH AND MONTH(HoaDon.ThoiGian) = N'" + Thang + "' AND YEAR(HoaDon.ThoiGian) = N'" + Nam + "'"; // Đếm khách hàng theo tháng
                }
                else if (ThongKeTheoLoai == "TheoNam")
                {
                    sqlThongKe = @"SELECT COUNT( DISTINCT HoaDon.MaKhachHang)
                           FROM HoaDon, KhachHang
                           WHERE HoaDon.MaKhachHang = KhachHang.MaKH AND YEAR(HoaDon.ThoiGian) = N'" + Nam + "'"; // Đếm khách hàng theo năm
                }
                da.Connect();
                soKhachHang = (int)da.ExecuteScalar(sqlThongKe);
                da.Disconnet();
                return soKhachHang;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string LayIDKhachHang(string TenKH)
        {
            string MaKH;
            string sql = @"SELECT MaKH FROM KhachHang WHERE TenKH = N'" + TenKH + "'";
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

        public int KiemTraDatChoKhachHang(string SDT)
        {
            string sqlKiemTra = @"SELECT COUNT(*) FROM DatCho WHERE SDT = '" + SDT + "'";
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteScalar(sqlKiemTra);
                da.Disconnet();
                return rt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string TraVeTenKH(string SDT)
        {
            string sqlLayTenKhachHang = @"SELECT TenKH FROM KhachHang WHERE SDT = N'" + SDT + "'";
            try
            {
                da.Connect();
                string TenKH = (string)da.ExecuteScalar(sqlLayTenKhachHang);
                da.Disconnet();
                return TenKH;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string TraVeThongTinDatChoDaTonTai(string SDT)
        {
            string sql = @"SELECT * FROM DatCho WHERE SDT = N'" + SDT + "'";
            string ThongTin = "\n";
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while(dr.Read()) 
                    ThongTin += dr[3].ToString() + "\n";
                da.Disconnet();
                return ThongTin;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string TraVeMaKHTuSDT(string SDT)
        {
            string sql = @"SELECT MaKH FROM KhachHang WHERE SDT = N'" + SDT + "'";
            try
            {
                da.Connect();
                string MaKH = (string)da.ExecuteScalar(sql);
                da.Disconnet();
                return MaKH;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool KiemTraTonTaiKhachHangBangSDT(string SDT)
        {
            string sql = @"SELECT COUNT(*) FROM KhachHang WHERE SDT = N'" + SDT + "'";
            bool TonTai;
            try
            {
                da.Connect();
                int rt = (int)da.ExecuteScalar(sql);
                da.Disconnet();
                if (rt > 0)
                    TonTai = true;
                else
                    TonTai = false;
                return TonTai;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int DemSoLanKhachHang(string MaKH)
        {
            string sql = @"SELECT SoLan FROM KhachHang WHERE MaKH = N'" + MaKH + "'";
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

        public List<string> XemTenKhachHang(string TenKH) 
        {
            string sql = @"SELECT * FROM KhachHang WHERE TenKH LIKE N'%" + TenKH + "%'";
            try
            {
                da.Connect();
                List<string> lstTenKH = new List<string>();
                SqlDataReader dr = da.ExecuteReader(sql);
                string Tenkh = "";
                while (dr.Read())
                {
                    Tenkh = dr[1].ToString();

                    lstTenKH.Add(Tenkh);
                }
                da.Disconnet();
                return lstTenKH;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
