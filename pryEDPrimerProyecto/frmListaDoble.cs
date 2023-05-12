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
    public partial class frmListaDoble : Form
    {
        clsListaDoble Lista = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            lstCodigo.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            if (optAscendente.Checked == true)
            {
                Lista.Recorrer(grlMostrar);
                Lista.Recorrer(lstListado);
                Lista.Recorrer(lstCodigo);
            }
            else if (optDescendente.Checked == true) 
            {
                Lista.RecorrerDes(grlMostrar);
                Lista.RecorrerDes(lstListado);
                Lista.RecorrerDes(lstCodigo);
            }
            



            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(lstCodigo.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(grlMostrar);
                Lista.Recorrer(lstListado);
                Lista.Recorrer(lstCodigo);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(grlMostrar);
            Lista.Recorrer(lstListado);
            Lista.Recorrer(lstCodigo);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(grlMostrar);
            Lista.RecorrerDes(lstListado);
            Lista.RecorrerDes(lstCodigo);
        }
    }
}
