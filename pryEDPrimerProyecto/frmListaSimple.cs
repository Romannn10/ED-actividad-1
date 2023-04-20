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
    public partial class frmListaSimple : Form
    {
        clsListaSimple Lista = new clsListaSimple();
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(grlMostrar);
            Lista.Recorrer(lstListado);
            Lista.Recorrer(lstCodigo);
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            clsListaSimple objLista = new clsListaSimple();
            
            if (Lista.Primero!=null)
            {
                Int32 cod = Convert.ToInt32(lstCodigo.Text);
                Lista.Eliminar(cod);
                Lista.Recorrer(grlMostrar);
                Lista.Recorrer(lstListado);
                Lista.Recorrer(lstCodigo);
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }

        }
    }
}
