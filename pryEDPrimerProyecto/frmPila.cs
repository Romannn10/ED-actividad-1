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
    public partial class frmPila : Form
    {
        clsPila PilaDePersonas = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            PilaDePersonas.Agregar(objNodo);
            PilaDePersonas.Recorrer(grlMostrar);
            PilaDePersonas.Recorrer(lstListado);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";

        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDePersonas.Primero != null)
            {
                txtCodigo2.Text = PilaDePersonas.Primero.Codigo.ToString();
                txtNombre2.Text = PilaDePersonas.Primero.Nombre;
                txtTramite2.Text = PilaDePersonas.Primero.Tramite;

                PilaDePersonas.Eliminar();
                PilaDePersonas.Recorrer(grlMostrar);
                PilaDePersonas.Recorrer(lstListado);
            }
            else
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                txtTramite2.Text = "";
            }
        }
    }
}
