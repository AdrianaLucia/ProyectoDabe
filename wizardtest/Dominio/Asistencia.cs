using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    class Asistencia
    {
        public int idREAP { get; private set; }
        public int Asistio { get; private set; }
        public string Fecha { get; private set; }
        public Asistencia(int pidREAP, int pAsistio, string pFecha)
        {
            idREAP = pidREAP;
            Asistio = pAsistio;
            Fecha = pFecha;
        }
    }

    class SerializadorAsistencia
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorAsistencia.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Asistencia pAsistencia)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO Asistencia (idREAP,Asistio,Fecha)
values(@idREAP,@Asistio,@Fecha)";

            SQLiteParameter[] p = new SQLiteParameter[3];
            
            p[0] = new SQLiteParameter("@idREAP", pAsistencia.idREAP);
            p[1] = new SQLiteParameter("@Asistio", pAsistencia.Asistio);
            p[2] = new SQLiteParameter("@Fecha", pAsistencia.Fecha);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(Asistencia e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Asistencia WHERE idREAP =@cod AND Fecha=@fec";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", e.idREAP);
            p[1] = new SQLiteParameter("@fec", e.Fecha);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(Asistencia pAsistencia)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO Asistencia
values(@idREAP,@Asistio,@Fecha)";
            SQLiteParameter[] p = new SQLiteParameter[3];

            p[0] = new SQLiteParameter("@idREAP", pAsistencia.idREAP);
            p[1] = new SQLiteParameter("@Asistio", pAsistencia.Asistio);
            p[2] = new SQLiteParameter("@Fecha", pAsistencia.Fecha);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Asistencia", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Asistencia (idREAP INTEGER,Asistio INTEGER,Fecha TEXT,PRIMARY KEY(idREAP,Fecha) );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
