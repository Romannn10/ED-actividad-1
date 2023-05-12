using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            lstCodigo.SelectedIndex = -1;
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
            objArbolBinario.RecorrerPre(treeView1);
            
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {


            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.Recorrer(grlMostrar);
                objArbolBinario.Recorrer(lstListado);
                objArbolBinario.Recorrer(lstCodigo);
                objArbolBinario.RecorrerPre(treeView1);
            }

        }

        private void optInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {

            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.RecorrerDes(grlMostrar);
                objArbolBinario.RecorrerDes(lstListado);
                objArbolBinario.RecorrerDes(lstCodigo);
                objArbolBinario.RecorrerPre(treeView1);
            }

        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {

            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.RecorrerPre(grlMostrar);
                objArbolBinario.RecorrerPre(lstListado);
                objArbolBinario.RecorrerPre(lstCodigo);
                objArbolBinario.RecorrerPre(treeView1);
            }

        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {


            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.RecorrerPost(grlMostrar);
                objArbolBinario.RecorrerPost(lstListado);
                objArbolBinario.RecorrerPost(lstCodigo);
                objArbolBinario.RecorrerPre(treeView1);
            }

        }

        private void grlMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mrcNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(lstCodigo.Text);
            objArbolBinario.Eliminar(Codigo);

            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.Recorrer(grlMostrar);
                objArbolBinario.Recorrer(lstListado);
                objArbolBinario.Recorrer(lstCodigo);

                if (objArbolBinario.Raiz != null)
                {
                    objArbolBinario.Equilibrar();
                }

            }
            else
            {
                MessageBox.Show("El dato que quiere eliminar no existe", "Error");
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            
            
            txtCodigo.Focus();
            

        }
        private void ChequeoBotones()
        {
            if (txtCodigo.Text !="" && txtNombre.Text != "" && txtTramite.Text!="")
            {
                btnAgregar.Enabled = true;
               
            }
            else
            {
                btnAgregar.Enabled=false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ChequeoBotones();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ChequeoBotones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ChequeoBotones();
        }

        private void txtGrabar_Click(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                StreamWriter sw = new StreamWriter("Archivo.csv");
                if (optInOrdenAsc.Checked == true)
                {
                    objArbolBinario.Recorrer(sw);
                }
                else if (optInOrdenDes.Checked == true)
                {
                    objArbolBinario.RecorrerDes(sw);
                }
                if (optPostOrden.Checked == true)
                {
                    objArbolBinario.RecorrerPost(sw);
                }

                if (optPreOrden.Checked == true)
                {
                    objArbolBinario.RecorrerPre(sw);
                }

                sw.Close();
                sw.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione un boton para el orden en que quiera listar");
                
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
