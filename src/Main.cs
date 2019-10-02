using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class Main : Form
    {

        private static FormPelanggan Fpel;
        private static FormPengiriman Fpen;
        private static FormBarang Fbar;
        private static FormKurir Fkur;
        private static FormStatusPengiriman Fstat;

        public Main()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            Fpel = new FormPelanggan();
            Fpel.MdiParent = this;

            Fpen = new FormPengiriman();
            Fpen.MdiParent = this;

            Fbar = new FormBarang();
            Fbar.MdiParent = this;

            Fkur = new FormKurir();
            Fkur.MdiParent = this;
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fpel.Visible)
            {
                return;
            }

            Fpel = new FormPelanggan();
            Fpel.MdiParent = this;
            Fpel.Show();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fbar.Visible)
            {
                return;
            }

            Fbar = new FormBarang();
            Fbar.MdiParent = this;
            Fbar.Show();
        }

        private void kurirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fkur.Visible)
            {
                return;
            }

            Fkur = new FormKurir();
            Fkur.MdiParent = this;
            Fkur.Show();
        }

        private void pengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fpen.Visible)
            {
                return;
            }

            Fpen = new FormPengiriman();
            Fpen.MdiParent = this;
            Fpen.Show();
        }

        private void statusPengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fstat.Visible)
            {
                return;
            }

        }
    }
}
