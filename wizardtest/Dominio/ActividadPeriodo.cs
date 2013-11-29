using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using System.Data;
namespace wizardtest.Dominio
{

    class ActividadPeriodo
    {
        public int idAsociacion { get; private set; }
        public int idActividad { get; private set; }
        public int idPeriodo { get; private set; }
        public ActividadPeriodo(int pidAsociacion, int pidActividad, int pidPeriodo)
        {
            idAsociacion = pidAsociacion;
            idActividad = pidActividad;
            idPeriodo = pidPeriodo;
        }
    }

    class SerializadorActividadPeriodo
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorActividadPeriodo.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(ActividadPeriodo pActividadPeriodo)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO ActividadPeriodo (idActividad,idPeriodo)
values(@idActividad,@idPeriodo)";

            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@idAsociacion", pActividadPeriodo.idAsociacion);
            p[1] = new SQLiteParameter("@idActividad", pActividadPeriodo.idActividad);
            p[2] = new SQLiteParameter("@idPeriodo", pActividadPeriodo.idPeriodo);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(ActividadPeriodo e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM ActividadPeriodo WHERE idAsociacion =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idAsociacion);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(ActividadPeriodo pActividadPeriodo)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO ActividadPeriodo
values(@idAsociacion,@idActividad,@idPeriodo)";
            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@idAsociacion", pActividadPeriodo.idAsociacion);
            p[1] = new SQLiteParameter("@idActividad", pActividadPeriodo.idActividad);
            p[2] = new SQLiteParameter("@idPeriodo", pActividadPeriodo.idPeriodo);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM ActividadPeriodo", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS ActividadPeriodo (
idAsociacion INTEGER PRIMARY KEY AUTOINCREMENT,idActividad INTEGER,idPeriodo INTEGER );";
                adicion.ExecuteNonQuery();
            }
        }



        internal static DataTable getListadoNombres(int periodo)
        {
            DataTable resultado = new DataTable();
            try
            {
               
                SQLiteConnection conn = ConexionBD.getConexion();
                conn.Open();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT ActividadPeriodo.idAsociacion, Actividad.nombre , ActividadPeriodo.idActividad,ActividadPeriodo.idPeriodo FROM ActividadPeriodo,Actividad where Actividad.idActividad=ActividadPeriodo.idActividad AND ActividadPeriodo.idPeriodo='"+periodo.ToString()+"'", conn);
                adaptador.Fill(resultado);
                
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return resultado;
        }
    }

}
