using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string makh;

        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }

        private string tenkh;

        public string TenKH
        {
            get { return tenkh; }
            set { tenkh = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string diachi;

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public KhachHang()
        {
            makh = "";
            tenkh = "";
            sdt = "";
            diachi = "";
        }

        private int solan;

        public int SoLan
        {
            get { return solan; }
            set { solan = value; }
        }

        public KhachHang(string Makh, string Tenkh, string Diachi, string Sdt, int Solan)
        {
            makh = Makh;
            tenkh = Tenkh;
            sdt = Sdt;
            diachi = Diachi;
            solan = Solan;
        }

        public KhachHang(string Tenkh)
        {
            tenkh = Tenkh;
        }
    }
}
