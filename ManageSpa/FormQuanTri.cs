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
    public partial class FormQuanTri : Form
    {
        FormQuanLyTaiKhoan fqltk;
        FormNhanVien fnv;
        FormThongKe ftk;
        FormQuanLyDangNhap qldn;

        public FormQuanTri()
        {
            InitializeComponent();
        }

        private void FormQuanTri_Load(object sender, EventArgs e)
        {
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                fqltk = new FormQuanLyTaiKhoan();
                fqltk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                fnv = new FormNhanVien();
                fnv.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                ftk = new FormThongKe();
                ftk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qldn = new FormQuanLyDangNhap();
            qldn.Show();
        }

    }
}
