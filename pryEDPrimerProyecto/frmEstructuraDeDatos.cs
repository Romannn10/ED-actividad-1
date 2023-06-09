﻿using System;
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

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario objAB = new frmArbolBinario();
            objAB.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void operacionesConTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos objBaseDeDatos = new frmBaseDeDatos();
            objBaseDeDatos.ShowDialog();
        }

        private void consultasEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEnBD objConsultaEnBD = new frmConsultaEnBD();
            objConsultaEnBD.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepasoOperaciones objRepaso = new frmRepasoOperaciones();
            objRepaso.ShowDialog();
        }
    }
}
