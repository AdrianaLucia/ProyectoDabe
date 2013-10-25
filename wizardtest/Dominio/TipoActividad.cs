using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    class TipoActividad
    {
        public int idTipoActividad {get; private set;}
        public string Nombre { get; private set; }
        public TipoActividad(int cod, string nom)
        {
            idTipoActividad = cod;
            Nombre = nom;
        }
    }

    class SerializadorTipoActividad
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorTipoActividad.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(TipoActividad t)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO TipoActividad (nombre) 
                                                    values(@nom)";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@nom", t.Nombre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }

        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM TipoActividad", conn);
            adaptador.Fill(resultado);
            return resultado;
        }

        public static bool eliminar(TipoActividad t)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM TipoActividad WHERE idtipo=@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", t.idTipoActividad);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados > 0;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS TipoActividad(
                                              idtipo INTEGER PRIMARY KEY AUTOINCREMENT,
                                              nombre TEXT
                                        );";
                adicion.ExecuteNonQuery();
            }
        }



        internal static bool modificar(TipoActividad t)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO TipoActividad 
                                                    values(@cod,@nom)";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", t.idTipoActividad);
            p[1] = new SQLiteParameter("@nom", t.Nombre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
    }


}
