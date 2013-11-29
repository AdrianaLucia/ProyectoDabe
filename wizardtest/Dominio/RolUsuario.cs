using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


namespace wizardtest.Dominio
{
    class RolUsuario
    {
        public int idRol { get; private set; }
        public string Nombre { get; private set; }
        public int nivelRol {get;private set;}
        public RolUsuario(int cod, string nom, int nivel)
        {
            idRol = cod;
            Nombre = nom;
            nivelRol = nivel;
        }
    }
    class SerializadorRolUsuario
    {
        static bool inicializado = false;

        static void init()
        {
            SerializadorRolUsuario.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(RolUsuario rol)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO RolUsuario (nombre,nivelRol) 
                                                    values(@nom,@nivel)";

            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@nom", rol.Nombre);
            p[1] = new SQLiteParameter("@nivel", rol.nivelRol);
            
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }


        public static Boolean eliminar(RolUsuario e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM RolUsuario WHERE idRolUsuario =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idRol);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(RolUsuario rol)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO RolUsuario 
                                                    values(@cod,@nom,@nivel)";
            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@cod", rol.idRol);
            p[1] = new SQLiteParameter("@nom", rol.Nombre);
            p[2] = new SQLiteParameter("@tipo", rol.nivelRol);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            crearTablaSiNoExiste();
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM RolUsuario", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS RolUsuario (
                                                idRolUsuario INTEGER PRIMARY KEY AUTOINCREMENT,nombre TEXT,nivelRol INTEGER
                                        );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
