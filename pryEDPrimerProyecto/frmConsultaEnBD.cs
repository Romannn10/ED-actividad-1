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
    public partial class frmConsultaEnBD : Form
    {

        clsBaseDatos objBD;
        public frmConsultaEnBD()
        {
            InitializeComponent();
        }

        private void frmConsultaEnBD_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objBD = new clsBaseDatos();
            string sql = txtConsulta.Text;
            objBD.Listar(grlMostrar, sql);


        }
    }
}
