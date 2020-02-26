using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FrmEstadistica = new Form1();
            FrmEstadistica.MdiParent = this;
            FrmEstadistica.Show();

            lblFormularioActivo.Text = FrmEstadistica.Text;

        }

        private void conversoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversores FrmConversores = new conversores();
            FrmConversores.MdiParent = this; 
            FrmConversores.Show();

            lblFormularioActivo.Text = FrmConversores.Text;

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            lblStatusFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
