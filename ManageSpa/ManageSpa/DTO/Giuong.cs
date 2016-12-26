using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Giuong
    {
        private string magiuong;

        public string MaGiuong
        {
            get { return magiuong; }
            set { magiuong = value; }
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
        
        // Giường trống là false
        public Giuong()
        {
            magiuong = "";
            thoigianbatdau = new DateTime(1999, 1, 1, 0, 0, 0);
            thoigianketthuc = new DateTime(1999, 1, 1, 0, 0, 0);
        }

        public Giuong(string Magiuong, DateTime Thoigianbatdau, DateTime Thoigianketthuc)
        {
            magiuong = Magiuong;
            thoigianbatdau = Thoigianbatdau;
            thoigianketthuc = Thoigianketthuc;
        }
        
    }
}
