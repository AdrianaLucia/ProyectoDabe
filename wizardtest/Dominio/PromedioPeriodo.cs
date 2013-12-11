using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    class PromedioPeriodo
    {
        public int idREAP { get; private set; }
        public int Promedio { get; private set; }
        
        public PromedioPeriodo(int pidREAP, int pPromedio)
        {
            idREAP = pidREAP;
            Promedio = pPromedio;
        }
    }

    class SerializadorPromedioPeriodo
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorPromedioPeriodo.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(PromedioPeriodo pPromedio)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO PromedioPeriodo (idREAP,Promedio)
values(@idREAP,@Promedio)";

            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", pPromedio.idREAP);
            p[1] = new SQLiteParameter("@pro", pPromedio.Promedio);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(PromedioPeriodo pPromedio)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM PromedioPeriodo WHERE idREAP=@cod AND Promedio=@pro";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", pPromedio.idREAP);
            p[1] = new SQLiteParameter("@pro", pPromedio.Promedio);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(PromedioPeriodo pPromedio)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO PromedioPeriodo
values(@idREAP,@Promedio)";
            SQLiteParameter[] p = new SQLiteParameter[2];

            p[0] = new SQLiteParameter("@idREAP", pPromedio.idREAP);
            p[1] = new SQLiteParameter("@Promedio", pPromedio.Promedio);
            
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM PromedioPeriodo", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS PromedioPeriodo (idREAP INTEGER,Promedio INTEGER,PRIMARY KEY(idREAP,Promedio) );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
