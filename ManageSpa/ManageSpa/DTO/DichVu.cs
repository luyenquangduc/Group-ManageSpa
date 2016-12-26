using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {
        private string madv;

        public string MaDV
        {
            get { return madv; }
            set { madv = value; }
        }

        private string tendv;

        public string TenDV
        {
            get { return tendv; }
            set { tendv = value; }
        }

        private int gia;

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private int thoigiansudung;

        public int ThoiGianSuDung
        {
            get { return thoigiansudung; }
            set { thoigiansudung = value; }
        }
        

        public DichVu() 
        {
            madv = "";
            tendv = "";
            gia = 0;
            thoigiansudung = 0;
        }

        public DichVu(string Madv, string Tendv, int GiaTien, int Thoigiansudung) 
        {
            madv = Madv;
            tendv = Tendv;
            gia = GiaTien;
            thoigiansudung = Thoigiansudung;
        }
        
    }
}
