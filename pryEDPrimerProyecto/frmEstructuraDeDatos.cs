using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPrimerProyecto
{
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador objDatosProgramador = new frmDatosProgramador();
            objDatosProgramador.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila objPila = new frmPila();
            objPila.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple objListaSimple = new frmListaSimple();
            objListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble objListaDoble = new frmListaDoble();
            objListaDoble.ShowDialog();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
