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
    public partial class frmRepasoOperaciones : Form
    {
        clsBaseDatos objBD;
        public frmRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void frmRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objBD=new clsBaseDatos();
            string sql = "";
            switch (lstElegir.SelectedIndex)
            {
                case 0:
                    txtConsulta.Text = lstElegir.Text+"Paises que no tienen libros";
                    sql = "select * from pais WHERE idPais not in (select idPais from libro)";
                    break;
                    case 1:
                    txtConsulta.Text = lstElegir.Text + "Paises que si tienen libros";
                    sql = "select * from pais WHERE idPais in (select idPais from libro)";
                    break;
            }
            objBD.Listar(grlMostrar, sql);
        }
    }
}
