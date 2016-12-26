using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string mahd;

        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }

        private DateTime thoigian;

        public DateTime ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private int tongtien;

        public int TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private string makh;

        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }

        public HoaDon()
        {
            mahd = "";
            thoigian = DateTime.Now;
            tongtien = 0;
            makh = "";
        }

        public HoaDon(string Mahd, DateTime date, int Tongtien, string Makh)
        {
            mahd = Mahd;
            thoigian = date;
            tongtien = Tongtien;
            makh = Makh;
        }
        
    }
}
