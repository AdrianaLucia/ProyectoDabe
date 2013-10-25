using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    class EstadoActividad
    {
        public int idEstadoActividad {get; private set;}
        public string Nombre { get; private set; }
        public EstadoActividad(int cod, string nom)
        {
            idEstadoActividad = cod;
            Nombre = nom;
        }
    }

    class SerializadorEstadoActividad
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorEstadoActividad.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(EstadoActividad e)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO EstadoActividad (nombre) 
                                                    values(@nom)";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@nom", e.Nombre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas == 0;
        }

        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM EstadoActividad", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        public static Boolean eliminar(EstadoActividad e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM EstadoActividad WHERE idestado=@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idEstadoActividad);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS EstadoActividad(
                                              idestado INTEGER PRIMARY KEY AUTOINCREMENT,
                                              nombre TEXT
                                        );";
                adicion.ExecuteNonQuery();
            }
        }

        internal static bool modificar(EstadoActividad t)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO EstadoActividad 
                                                    values(@cod,@nom)";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", t.idEstadoActividad);
            p[1] = new SQLiteParameter("@nom", t.Nombre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
    }
}
