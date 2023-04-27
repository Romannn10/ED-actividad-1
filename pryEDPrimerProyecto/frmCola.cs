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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonas = new clsCola();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtCodigo2.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtNombre2.Text = FilaDePersonas.Primero.Nombre;
                txtTramite2.Text = FilaDePersonas.Primero.Tramite;

                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(grlMostrar);
                FilaDePersonas.Recorrer(lstListado);


            }
            else
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                txtTramite2.Text = "";
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objnodo = new Nodo();
            objnodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objnodo.Nombre = txtNombre.Text;
            objnodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(objnodo);
            FilaDePersonas.Recorrer(grlMostrar);
            FilaDePersonas.Recorrer(lstListado);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
