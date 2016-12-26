using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTaiKhoan
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string loaitk;

        public string LoaiTK
        {
            get { return loaitk; }
            set { loaitk = value; }
        }

        public LoaiTaiKhoan()
        {
            id = "";
            loaitk = "";
        }

        public LoaiTaiKhoan(string Id, string Loaitk)
        {
            id = Id;
            loaitk = Loaitk;
        }
    }
}
