using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong
    {
        private string manv;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        private int hesoluong;

        public int HeSoLuong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }

        public Luong()
        {
            manv = "";
            hesoluong = 0;
        }

        public Luong(string Manv, int Hesoluong)
        {
            manv = Manv;
            hesoluong = Hesoluong;
        }
        
    }
}
