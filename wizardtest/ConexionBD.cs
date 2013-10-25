﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace wizardtest
{
    class ConexionBD
    {
        //atic private SQLiteConnection conn = null;
        static private string connStr = "Data Source=mibd.db;Version=3;";
        public static SQLiteConnection getConexion(){


            return new SQLiteConnection(connStr);
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