using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatCho
    {
        private string madc;

        public string MaDC
        {
            get { return madc; }
            set { madc = value; }
        }

        private string magiuong;

        public string MaGiuong
        {
            get { return magiuong; }
            set { magiuong = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }


        private DateTime thoigianbatdau;

        public DateTime ThoiGianBatDau
        {
            get { return thoigianbatdau; }
            set { thoigianbatdau = value; }
        }

        private DateTime thoigianketthuc;

        public DateTime ThoiGianKetThuc
        {
            get { return thoigianketthuc; }
            set { thoigianketthuc = value; }
        }

        public DatCho()
        {
            madc = "";
            magiuong = "";
            sdt = "";
            thoigianbatdau = new DateTime(1999, 1, 1, 0, 0, 0);
            thoigianketthuc = new DateTime(1999, 1, 1, 0, 0, 0);
        }
        public DatCho(string Madc, string Magiuong, string Sdt, DateTime Thoigianbatdau, DateTime Thoigianketthuc)
        {
            madc = Madc;
            magiuong = Magiuong;
            sdt = Sdt;
            thoigianbatdau = Thoigianbatdau;
            thoigianketthuc = Thoigianketthuc;
        }
    }
}
