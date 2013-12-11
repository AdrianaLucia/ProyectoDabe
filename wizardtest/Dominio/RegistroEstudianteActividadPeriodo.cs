using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
namespace wizardtest.Dominio
{
    class RegistroEstudianteActividadPeriodo
    {
        public int id { get; private set; }
        public int idEstudiante { get; private set; }
        public int idActividad { get; private set; }
        public int idPeriodo { get; private set; }
        public RegistroEstudianteActividadPeriodo(int pid, int pidEstudiante, int pidActividad, int pidPeriodo)
        {
            id = pid;
            idEstudiante = pidEstudiante;
            idActividad = pidActividad;
            idPeriodo = pidPeriodo;
        }
    }

    class SerializadorRegistroEstudianteActividadPeriodo
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorRegistroEstudianteActividadPeriodo.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(RegistroEstudianteActividadPeriodo pRegistroEstudianteActividadPeriodo)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO RegistroEstudianteActividadPeriodo (idEstudiante,idActividad,idPeriodo)
values(@idEstudiante,@idActividad,@idPeriodo)";

            SQLiteParameter[] p = new SQLiteParameter[4];
            p[0] = new SQLiteParameter("@id", pRegistroEstudianteActividadPeriodo.id);
            p[1] = new SQLiteParameter("@idEstudiante", pRegistroEstudianteActividadPeriodo.idEstudiante);
            p[2] = new SQLiteParameter("@idActividad", pRegistroEstudianteActividadPeriodo.idActividad);
            p[3] = new SQLiteParameter("@idPeriodo", pRegistroEstudianteActividadPeriodo.idPeriodo);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(RegistroEstudianteActividadPeriodo e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM RegistroEstudianteActividadPeriodo WHERE id =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.id);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(RegistroEstudianteActividadPeriodo pRegistroEstudianteActividadPeriodo)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO RegistroEstudianteActividadPeriodo
values(@id,@idEstudiante,@idActividad,@idPeriodo)";
            SQLiteParameter[] p = new SQLiteParameter[4];
            p[0] = new SQLiteParameter("@id", pRegistroEstudianteActividadPeriodo.id);
            p[1] = new SQLiteParameter("@idEstudiante", pRegistroEstudianteActividadPeriodo.idEstudiante);
            p[2] = new SQLiteParameter("@idActividad", pRegistroEstudianteActividadPeriodo.idActividad);
            p[3] = new SQLiteParameter("@idPeriodo", pRegistroEstudianteActividadPeriodo.idPeriodo);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM RegistroEstudianteActividadPeriodo", conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public static DataTable getListadoEstudiantes(int idActividad, int idPeriodo)
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(@"SELECT REAP.id as id, ES.NroRegistro as NumeroRegistro ,(ES.Nombres||' '||ES.ApellidoPaterno||' '||ES.ApellidoMaterno) as Nombre
                                                                    FROM RegistroEstudianteActividadPeriodo REAP,Estudiante ES 
                                                                    WHERE ES.idEstudiante=REAP.idEstudiante AND idPeriodo=" + idPeriodo+" AND idActividad="+idActividad+";", conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public static DataTable getListadoEstudiantesNoRegistrados(int idPeriodo)
        {
            crearTablaSiNoExiste();
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Estudiante where idEstudiante NOT IN (SELECT idEstudiante from RegistroEstudianteActividadPeriodo where idPeriodo=" + idPeriodo + ");", conn);
            adaptador.Fill(resultado);
            return resultado;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS RegistroEstudianteActividadPeriodo (
id INTEGER PRIMARY KEY AUTOINCREMENT,idEstudiante INTEGER,idActividad INTEGER,idPeriodo INTEGER );";
                adicion.ExecuteNonQuery();
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Asistencia (idREAP INTEGER,Asistio INTEGER,Fecha TEXT,PRIMARY KEY(idREAP,Fecha) );";
                adicion.ExecuteNonQuery();
            }
        }



        internal static DataTable getListadoEstudiantesSemana(int idActividad, int idPeriodo, string semana)
        {
            crearTablaSiNoExiste();
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(@"SELECT REAP.id as id, ES.NroRegistro as NumeroRegistro ,(ES.Nombres||' '||ES.ApellidoPaterno||' '||ES.ApellidoMaterno) "+
                                                                    " as Nombre, IFNULL((SELECT Asistio FROM Asistencia ASIS where ASIS.idREAP=REAP.id AND ASIS.Fecha='"+semana+"'),'0') as Asistio "+
                                                                    "FROM RegistroEstudianteActividadPeriodo REAP,Estudiante ES "+
                                                                    "WHERE ES.idEstudiante=REAP.idEstudiante AND idPeriodo=" + idPeriodo + " AND idActividad=" + idActividad + ";", conn);
            adaptador.Fill(resultado);
            return resultado;
        }
    }
}
