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
    public partial class XoaTaiKhoan : UserControl
    {
        Bus bus;
        public XoaTaiKhoan()
        {
            bus = new Bus();
            InitializeComponent();
        }

        private void XoaTaiKhoan_Load(object sender, EventArgs e)
        {
            dtTaiKhoan.DataSource = bus.XemTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bus.XoaTaiKhoan(ID);
                MessageBox.Show("Thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTaiKhoan.DataSource = bus.XemTaiKhoan();
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại", "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string ID;
        private void dtTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dtTaiKhoan.CurrentRow != null)
            {
                ID = dtTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
