using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryEDPrimerProyecto
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Libreria.mdb";
        private string varCadena = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= Libreria.mdb";

        public void Listar(DataGridView dgvMostrar) 
        {
            try
            {
                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(comando);//Ejecuto Comando
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");//Llena el dataset

                dgvMostrar.DataSource = null;//vaciamos grilla
                dgvMostrar.DataSource = DS.Tables["Libro"];//llenamos grilla con el dataset
                


                conexion.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void Listar(DataGridView dgvMostrar, String varInstruccionesSQL)
        {
            try
            {
                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionesSQL;

                adaptador = new OleDbDataAdapter(comando);//Ejecuto Comando
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");//Llena el dataset

                dgvMostrar.DataSource = null;//vaciamos grilla
                dgvMostrar.DataSource = DS.Tables["Resultado"];//llenamos grilla con el dataset



                conexion.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
