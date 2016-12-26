using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHD
    {
        private string mahd;

        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string madv;

        public string MaDV
        {
            get { return madv; }
            set { madv = value; }
        }

        private DateTime thoigian;

        public DateTime ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private int dongia;

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public CTHD()
        {
            mahd = "";
            madv = "";
            dongia = 0;
            thoigian = DateTime.Now;
        }
        public CTHD(string Mahd, string Madv, DateTime Thoigian, int Dongia)
        {
            mahd = Mahd;
            madv = Madv;
            thoigian = Thoigian;
            dongia = Dongia;
        }
    }
}
