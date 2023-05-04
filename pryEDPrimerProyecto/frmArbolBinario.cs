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
    public partial class frmArbolBinario : Form
    {
        clsArbolBinario objArbolBinario = new clsArbolBinario();
        Nodo ObjNodo;
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ObjNodo = new Nodo();
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objArbolBinario.Agregar(ObjNodo);
            objArbolBinario.Recorrer(grlMostrar);
            objArbolBinario.Recorrer(lstListado);
            objArbolBinario.Recorrer(lstCodigo);
            objArbolBinario.Recorrer(treeView1);
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.Recorrer(grlMostrar);
            objArbolBinario.Recorrer(lstListado);
            objArbolBinario.Recorrer(lstCodigo);
            objArbolBinario.Recorrer(treeView1);
        }

        private void optInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.RecorrerDes(grlMostrar);
            objArbolBinario.RecorrerDes(lstListado);
            objArbolBinario.RecorrerDes(lstCodigo);
            objArbolBinario.RecorrerDes(treeView1);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.RecorrerPre(grlMostrar);
            objArbolBinario.RecorrerPre(lstListado);
            objArbolBinario.RecorrerPre(lstCodigo);
            objArbolBinario.RecorrerPre(treeView1);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            objArbolBinario.RecorrerPost(grlMostrar);
            objArbolBinario.RecorrerPost(lstListado);
            objArbolBinario.RecorrerPost(lstCodigo);
            objArbolBinario.RecorrerPost(treeView1);
        }

        private void grlMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mrcNuevoElemento_Enter(object sender, EventArgs e)
        {

        }
    }
}
