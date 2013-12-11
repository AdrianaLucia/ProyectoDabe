using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    
    class RegistroAsistencia
    {
        public int idRegistroAsistencia { get; private set; }
        public int idPeriodoActividad { get; private set; }
        public int idEstudiante { get; private set; }
        public int FechaActividad { get; private set; }
        public int Asistencia { get; private set; }
        public RegistroAsistencia(int pidRegistroAsistencia, int pidPeriodoActividad, int pidEstudiante, int pFechaActividad, int pAsistencia)
        {
            idRegistroAsistencia = pidRegistroAsistencia;
            idPeriodoActividad = pidPeriodoActividad;
            idEstudiante = pidEstudiante;
            FechaActividad = pFechaActividad;
            Asistencia = pAsistencia;
        }
    }

    class SerializadorRegistroAsistencia
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorRegistroAsistencia.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(RegistroAsistencia pRegistroAsistencia)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO RegistroAsistencia (idPeriodoActividad,idEstudiante,FechaActividad,Asistencia)
values(@idPeriodoActividad,@idEstudiante,@FechaActividad,@Asistencia)";

            SQLiteParameter[] p = new SQLiteParameter[5];
            p[0] = new SQLiteParameter("@idRegistroAsistencia", pRegistroAsistencia.idRegistroAsistencia);
            p[1] = new SQLiteParameter("@idPeriodoActividad", pRegistroAsistencia.idPeriodoActividad);
            p[2] = new SQLiteParameter("@idEstudiante", pRegistroAsistencia.idEstudiante);
            p[3] = new SQLiteParameter("@FechaActividad", pRegistroAsistencia.FechaActividad);
            p[4] = new SQLiteParameter("@Asistencia", pRegistroAsistencia.Asistencia);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(RegistroAsistencia e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM RegistroAsistencia WHERE idRegistroAsistencia =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idRegistroAsistencia);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(RegistroAsistencia pRegistroAsistencia)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO RegistroAsistencia
values(@idRegistroAsistencia,@idPeriodoActividad,@idEstudiante,@FechaActividad,@Asistencia)";
            SQLiteParameter[] p = new SQLiteParameter[5];
            p[0] = new SQLiteParameter("@idRegistroAsistencia", pRegistroAsistencia.idRegistroAsistencia);
            p[1] = new SQLiteParameter("@idPeriodoActividad", pRegistroAsistencia.idPeriodoActividad);
            p[2] = new SQLiteParameter("@idEstudiante", pRegistroAsistencia.idEstudiante);
            p[3] = new SQLiteParameter("@FechaActividad", pRegistroAsistencia.FechaActividad);
            p[4] = new SQLiteParameter("@Asistencia", pRegistroAsistencia.Asistencia);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }

        public static DataTable getListadoPorPeriodo(int idPeriodo)
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM RegistroAsistencia where idPeriodoActividad='"+idPeriodo.ToString()+"'", conn);
            adaptador.Fill(resultado);
            return resultado;
        }

        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM RegistroAsistencia", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS RegistroAsistencia (
idRegistroAsistencia INTEGER PRIMARY KEY AUTOINCREMENT,idPeriodoActividad INTEGER,idEstudiante INTEGER,FechaActividad INTEGER,Asistencia INTEGER );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
