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
    public partial class FormQuanLyTaiKhoan : Form
    {
        DangKyTaiKhoan dktk;
        XoaTaiKhoan xtk;

        public FormQuanLyTaiKhoan()
        {
            dktk = new DangKyTaiKhoan();
            xtk = new XoaTaiKhoan();
            InitializeComponent();
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.Size = new Size(511, 250);
            this.pnlTaiKhoan.Size = new Size(500, 184);
            this.pnlTaiKhoan.Controls.Add(xtk);
            dktk.Show(); 
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlTaiKhoan.Controls.Clear();
            this.Size = new Size(320, 270);
            this.pnlTaiKhoan.Size = new Size(309, 202);
            this.pnlTaiKhoan.Controls.Add(dktk);
            dktk.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlTaiKhoan.Controls.Clear();
            this.Size = new Size(511, 250);
            this.pnlTaiKhoan.Size = new Size(463, 184);
            this.pnlTaiKhoan.Controls.Add(xtk);
            dktk.Show();
        }
    }
}
