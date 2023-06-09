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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDeDatos = new clsBaseDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO FROM LIBRO";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void frmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnProyeccionDeMultiatributo_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO, AÑO, PRECIO FROM LIBRO";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE IDidioma = 2";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnMultiatributo_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO WHERE IdLibro > 30 AND IDidioma = 1";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string SQL = " SELECT * FROM LIBRO WHERE IDidioma = 2 " + " union " + " SELECT * FROM LIBRO WHERE IDidioma = 3 ";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string SQL = " SELECT * FROM LIBRO WHERE IdAutor = 5 and exists (SELECT * FROM LIBRO WHERE IDidioma = 3)" ;
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string SQL = "Select * from libro " +
                " where idIdioma=2 and idLibro not in " +
                " (Select idLibro from libro where IdPais = 3 )" +
                " order by 1 asc ";

            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM (select * from libro where idIdioma > 1) as X " + "Where IDPAIS = 2";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT TITULO, NOMBRE FROM LIBRO inner join PAIS on LIBRO.IDPAIS= PAIS.IDPAIS";
            objBaseDeDatos.Listar(grlMostrar, SQL);
        }
    }
}
