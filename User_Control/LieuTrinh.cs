using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ManageSpa.User_Control
{
    public partial class LieuTrinh : UserControl
    {
        Bus bus;
        public LieuTrinh()
        {
            bus = new Bus();
            InitializeComponent();
        }
        public static string[] GetDichVu;
        private void LieuTrinh_Load(object sender, EventArgs e)
        {
            Init();
            GetDichVu = new string [bus.DemDichVu()];
        }

        //Khởi tạo các checkbox
        private void Init()
        {
            for (int i = 1; i <= bus.DemDichVu(); i++)
            {
                CheckBox check = new CheckBox();
                check.Text = bus.LayTenDV(LayMaDV(i));
                check.Name = LayMaDV(i);
                check.Click += check_Click;
                flowLieuTrinh.Controls.Add(check);
            }
        }

        int checkCount = 0;
        void check_Click(object sender, EventArgs e)
        {
            CheckBox checkb = (CheckBox)sender;
            if (checkb.Checked)
            {
                GetDichVu[checkCount] = checkb.Name;
                checkCount++;
            }
            else
            {
                for (int i = 0; i < GetDichVu.Length; i++)
                {
                    if (GetDichVu[i] == checkb.Name)
                    {
                        GetDichVu[i] = null;
                    }
                }
            }
        }
        //Lấy mã dịch vụ
        private string LayMaDV(int i)
        {
            if (i / 10 == 0)
                return "DV00" + i.ToString();
            else if (i / 10 > 0 && i / 100 == 0)
                return "DV0" + i.ToString();
            else
                return "DV" + i.ToString();
        }

    }
}
