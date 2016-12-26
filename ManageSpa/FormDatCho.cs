using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using ManageSpa.User_Control;

namespace ManageSpa
{
    public partial class FormDatCho : Form
    {
        DatChoCoLich dccl;
        SuaThongTinDatCho sttdc;
        public FormDatCho()
        {
            dccl = new DatChoCoLich();
            sttdc = new SuaThongTinDatCho();
            InitializeComponent();
        }

        private void FormDatCho_Load(object sender, EventArgs e)
        {
            pnlDatCho.Controls.Add(dccl);
            dccl.Show();
        }

        private void xemThongTinItemMenu_Click(object sender, EventArgs e)
        {
            pnlDatCho.Controls.Clear();
            pnlDatCho.Controls.Add(dccl);
            dccl.Show();
        }

        private void suaThongTinItemMenu_Click(object sender, EventArgs e)
        {
            pnlDatCho.Controls.Clear();
            pnlDatCho.Controls.Add(sttdc);
            sttdc.Show();
        }
    }
}
