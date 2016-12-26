using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string password;

        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        private string manv;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        public TaiKhoan()
        {
            id = "";
            password = "";
            manv = "";
        }

        public TaiKhoan(string Id, string Password, string Manv)
        {
            id = Id;
            password = Password;
            manv = Manv;
        }

        public TaiKhoan(string TenTK)
        {
            id = TenTK;
        }
    }
}
