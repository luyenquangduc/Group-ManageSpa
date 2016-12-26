using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string manv;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        private string tennv;

        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }

        private string diachi;

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string cmnd;

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        private string hinhnv;

        public string HinhNV
        {
            get { return hinhnv; }
            set { hinhnv = value; }
        }

        public NhanVien()
        {
            manv = "";
            tennv = "";
            cmnd = "";
            diachi = "";
            sdt = "";
            hinhnv = "";
        }

        public NhanVien(string Manv, string Tennv, string Diachi, string Sdt, string Cmnd, string Hinhnv)
        {
            manv = Manv;
            tennv = Tennv;
            cmnd = Cmnd;
            diachi = Diachi;
            sdt = Sdt;
            hinhnv = Hinhnv;
        }
    }
}
