using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
namespace wizardtest.Dominio
{
    class EstadoEstudiante
    {
        public int idestudiante { get; private set; }
        public string nombreestado { get; private set; }
        public EstadoEstudiante(int pidestudiante, string pnombreestado)
        {
            idestudiante = pidestudiante;
            nombreestado = pnombreestado;
        }
    }

    class SerializadorEstadoEstudiante
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorEstadoEstudiante.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(EstadoEstudiante pEstadoEstudiante)
        {
            if (!inicializado) { init(); inicializado = true; }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO EstadoEstudiante (nombreestado)
values(@nombreestado)";

            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@idestudiante", pEstadoEstudiante.idestudiante);
            p[1] = new SQLiteParameter("@nombreestado", pEstadoEstudiante.nombreestado);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(EstadoEstudiante e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM EstadoEstudiante WHERE idestudiante =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idestudiante);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(EstadoEstudiante pEstadoEstudiante)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO EstadoEstudiante
values(@idestudiante,@nombreestado)";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@idestudiante", pEstadoEstudiante.idestudiante);
            p[1] = new SQLiteParameter("@nombreestado", pEstadoEstudiante.nombreestado);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM EstadoEstudiante", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS EstadoEstudiante (
idestudiante INTEGER PRIMARY KEY AUTOINCREMENT,nombreestado TEXT );";
                adicion.ExecuteNonQuery();
            }
        }


    }

}
