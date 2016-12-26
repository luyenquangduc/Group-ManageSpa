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
    public partial class FormDichVu : Form
    {
        LieuTrinh lt;
        public FormDichVu()
        {
            lt = new LieuTrinh();
            InitializeComponent();
        }

        public static string close = "Open";
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            pnlDV.Controls.Add(lt);
            lt.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
