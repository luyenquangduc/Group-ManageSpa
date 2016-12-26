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
    public partial class FormKhachHang : Form
    {
        ThemKhachHang tkh;
        XemKhachHang xkh;
        public FormKhachHang()
        {
            tkh = new ThemKhachHang();
            xkh = new XemKhachHang();
            InitializeComponent();
        }

        bool Choose; 
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            Choose = true; // true là thêm khách hàng, false là xem khách hàng, chỉ người quản trị mới có thể xem thông tin khách hàng
            if (FormDangNhap.Acc == "Admin")
                xemKhachHang.Enabled = true;
            else
                xemKhachHang.Enabled = false;

            pnlKhachHang.Controls.Add(tkh);
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Choose == false)
                Choose = true;
            if (Choose == true)
            {
                pnlKhachHang.Controls.Clear();
                pnlKhachHang.Controls.Add(tkh);
                tkh.Show();
            }

            this.Size = new Size(603, 178);
            this.pnlKhachHang.Size = new Size(586, 111);
        }

        private void xemKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Choose == true)
                Choose = false;
            if (Choose == false)
            {
                pnlKhachHang.Controls.Clear();
                pnlKhachHang.Controls.Add(xkh);
                xkh.Show();
            }

            this.Size = new Size(703, 568);
            this.pnlKhachHang.Size = new Size(685, 500);
        }

        private void FormKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThemKhachHang.CanExit == false && DatChoCoLich.ThemKhachHangTuDatCho == true)
            {
                MessageBox.Show("Vui lòng hoàn thành việc thêm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

    }
}
