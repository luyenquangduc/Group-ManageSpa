using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSpa
{
    public partial class FormMain : Form
    {
        
        FormQuanTri fqt;
        FormKhachHang fkh;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnQuanTri.Hide();
            if (FormDangNhap.Acc == "Admin") 
            {
                btnQuanTri.Show();
            }
        }

        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            fqt = new FormQuanTri();
            fqt.Show();
        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            FormDatCho fdc = new FormDatCho();
            fdc.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fkh = new FormKhachHang();
            fkh.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan ftt = new FormThanhToan();
            ftt.Show();
        }

        public static bool signOut = false;
        private void menuThoat_Click(object sender, EventArgs e)
        {
            
        }

    }
}
