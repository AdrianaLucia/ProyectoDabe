using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace wizardtest
{
    class ConexionBD
    {
        //atic private SQLiteConnection conn = null;
        static private string connStr = "Data Source="+Properties.Settings.Default.dbpath+";Version=3;";
        public static SQLiteConnection getConexion(){

            return new SQLiteConnection(connStr);
        }

        private static int ejecutarComandoString(string queryString)
        {
            int result = 0;
            using (SQLiteConnection connection = ConexionBD.getConexion())
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(queryString, connection))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        public static int ejecutarCambio(string sql, SQLiteParameter[] parameters)
        {
            int result = 0;
            using (SQLiteConnection connection = ConexionBD.getConexion())
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddRange(parameters);
                  
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

    }
}
