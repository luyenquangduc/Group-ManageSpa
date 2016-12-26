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
    public partial class FormNhanVien : Form
    {
        NhanVien nv;
        ThemNhanVien tnv;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        bool Choose = true;
        private void xemNhanVien_Click(object sender, EventArgs e)
        {
                this.pnlNhanVien.Controls.Clear();
                this.pnlNhanVien.Size = new Size(800, 525);
                this.Size = new Size(821, 594);
                this.pnlNhanVien.Controls.Add(nv);
                nv.Show();
        }

        private void themNhanVien_Click(object sender, EventArgs e)
        {
            tnv = new ThemNhanVien();
                this.pnlNhanVien.Controls.Clear();
                this.pnlNhanVien.Size = new Size(586, 186);
                this.Size = new Size(604, 253);
                this.pnlNhanVien.Controls.Add(tnv);
                tnv.Show();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            nv = new NhanVien();
            this.pnlNhanVien.Size = new Size(800, 525);
            this.Size = new Size(821, 594); 
            this.pnlNhanVien.Controls.Add(nv);
            nv.Show();
        }
    }
}
