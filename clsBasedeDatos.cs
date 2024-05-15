using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace pryEstructuraDeDatos
{
    internal class clsBasedeDatos
    {
        //instanciamos 3 obj
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        
        private string CadenadeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        public void Listar(DataGridView Grilla)
        {
            try
            {
                Conexion.ConnectionString = CadenadeConexion;
                
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                Adaptador = new OleDbDataAdapter(Comando);
                Adaptador.Fill(DS, "Autor");
                
                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Autor"];

                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }




        }
        public void Listar1(DataGridView Grilla , String varInstruccionSQL)
        {
            try
            {
                Conexion.ConnectionString = CadenadeConexion;

                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = varInstruccionSQL;

                DataSet DS = new DataSet();
                Adaptador = new OleDbDataAdapter(Comando);
                Adaptador.Fill(DS, "ResultadoConsulta");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["ResultadoConsulta"];

                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }




        }



    }
}
