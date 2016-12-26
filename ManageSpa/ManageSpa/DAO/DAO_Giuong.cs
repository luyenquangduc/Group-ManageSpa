using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_Giuong
    {
        DataAdapter da;
        public DAO_Giuong()
        {
            da = new DataAdapter();
        }

        public int DemGiuong()
        {
            string sql = @"SELECT COUNT(MaGiuong) FROM GiuongSpa";
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

        public int XoaGiuongDat(string MaGiuong)
        {
            string sql = @"DELETE DatCho WHERE MaGiuong = '" + MaGiuong + "'";
            try
            {
                da.Connect();
                int exe = (int)da.ExecuteNonQuery(sql);
                da.Disconnet();
                return exe;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //So sánh thời gian đặt chỗ và thời giường trống, nếu cả 2 cùng thỏa trong cùng 1 khoảng thời gian thì trả về true
        public bool KiemTraGiuongTrong(string MaGiuong, DateTime TGDCBD, DateTime TGDCKT)
        {
            string sql = @"SELECT * FROM DatCho WHERE MaGiuong = N'" + MaGiuong + "'";
            DateTime TGBD, TGKT;
            // Giá trị trống ban đầu là true, nghĩa là giường trống, sau đó xét
            bool trong = true;
            try
            {
                da.Connect();
                SqlDataReader dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    TGBD = (DateTime)dr[3];
                    TGKT = (DateTime)dr[4];   
                    // Nếu như thời gian bắt đầu hoặc kết thúc nằm trong khoảng giữa lúc bắt đầu, kết thúc thì sẽ không trống, hoặc nằm ôm
                    // lấy khoảng thời gian này thì coi như giường không trống
                    if (TGBD <= TGDCBD && TGDCBD <= TGKT)
                        trong = false;
                    else if (TGBD <= TGDCKT && TGDCKT <= TGKT)
                        trong = false;
                    else if (TGDCBD <= TGBD  && TGBD <= TGDCKT)
                        trong = false;
                    else if (TGDCBD <= TGKT && TGKT <= TGDCKT)
                        trong = false;
                    else if (TGBD <= TGDCBD && TGKT >= TGDCKT)
                        trong = false;
                    else if (TGBD >= TGDCBD && TGKT <= TGDCKT)
                        trong = false;
                }
                da.Disconnet();
                return trong;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
