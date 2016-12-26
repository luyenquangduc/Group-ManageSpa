using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThoiGianDangNhap
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string manv;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        
        private DateTime thoigiandangnhap;

        public DateTime ThoiGian
        {
            get { return thoigiandangnhap; }
            set { thoigiandangnhap = value; }
        }

        public ThoiGianDangNhap(string Tentk, string Manv, DateTime date)
        {
            id = Tentk;
            manv = Manv;
            thoigiandangnhap = date;
        }
    }
}
