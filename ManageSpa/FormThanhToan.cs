using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSpa.User_Control;
namespace ManageSpa
{
    public partial class FormThanhToan : Form
    {
        XemHD xhd;
        public FormThanhToan()
        {
            xhd = new XemHD();
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Add(xhd);
        }
    }
}
