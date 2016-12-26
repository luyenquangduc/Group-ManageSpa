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
    public partial class FormQuanLyDangNhap : Form
    {
        ThongKeDangNhap tkdn;
        public FormQuanLyDangNhap()
        {
            tkdn = new ThongKeDangNhap();
            InitializeComponent();
        }

        private void FormQuanLyDangNhap_Load(object sender, EventArgs e)
        {
            pnlQuanLyDangNhap.Controls.Add(tkdn);
            tkdn.Show();
        }
    }
}
