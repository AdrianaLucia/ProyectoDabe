using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;


namespace wizardtest.Dominio
{
    class Carrera
    {
        public int idCarrera { get; private set; }
        public string nombre { get; private set; }
        public int codigo { get; private set; }
        public string facultad { get; private set; }
        public Carrera(int pidCarrera, string pnombre, int pcodigo, string pfacultad)
        {
            idCarrera = pidCarrera;
            nombre = pnombre;
            codigo = pcodigo;
            facultad = pfacultad;
        }
    }

    class SerializadorCarrera
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorCarrera.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Carrera pCarrera)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO Carrera (nombre,codigo,facultad)
values(@nombre,@codigo,@facultad)";

            SQLiteParameter[] p = new SQLiteParameter[4];
            p[0] = new SQLiteParameter("@idCarrera", pCarrera.idCarrera);
            p[1] = new SQLiteParameter("@nombre", pCarrera.nombre);
            p[2] = new SQLiteParameter("@codigo", pCarrera.codigo);
            p[3] = new SQLiteParameter("@facultad", pCarrera.facultad);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(Carrera e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Carrera WHERE idCarrera =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idCarrera);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(Carrera pCarrera)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO Carrera
values(@idCarrera,@nombre,@codigo,@facultad)";
            SQLiteParameter[] p = new SQLiteParameter[4];
            p[0] = new SQLiteParameter("@idCarrera", pCarrera.idCarrera);
            p[1] = new SQLiteParameter("@nombre", pCarrera.nombre);
            p[2] = new SQLiteParameter("@codigo", pCarrera.codigo);
            p[3] = new SQLiteParameter("@facultad", pCarrera.facultad);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Carrera", conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public static DataTable getListadoFacultad(string fac)
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Carrera where facultad='"+fac+"'", conn);
            adaptador.Fill(resultado);
            return resultado;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Carrera (
idCarrera INTEGER PRIMARY KEY AUTOINCREMENT,nombre TEXT,codigo INTEGER,facultad TEXT );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
