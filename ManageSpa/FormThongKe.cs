using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ManageSpa.User_Control;

namespace ManageSpa
{
    public partial class FormThongKe : Form
    {
        ThongKeKhachHang tkkh;
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            tkkh = new ThongKeKhachHang();
            grpThongKe.Controls.Add(tkkh);
        }
    }
}
