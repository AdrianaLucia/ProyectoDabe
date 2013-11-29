using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;


namespace wizardtest.Dominio
{
    //using System.Data.SQLite;
    //using System.Data;
    class Estudiante
    {
        public int idEstudiante { get; private set; }
        public string NroRegistro { get; private set; }
        public string Nombres { get; private set; }
        public string ApellidoPaterno { get; private set; }
        public string ApellidoMaterno { get; private set; }
        public string Facultad { get; private set; }
        public int Carrera { get; private set; }
        public int EstadoEstudiante { get; private set; }
        public int UsoCondicionEspecial { get; private set; }
        public Estudiante(int pidEstudiante, string pNroRegistro, string pNombres, string pApellidoPaterno, string pApellidoMaterno, string pFacultad, int pCarrera, int pEstadoEstudiante, int pUsoCondicionEspecial)
        {
            idEstudiante = pidEstudiante;
            NroRegistro = pNroRegistro;
            Nombres = pNombres;
            ApellidoPaterno = pApellidoPaterno;
            ApellidoMaterno = pApellidoMaterno;
            Facultad = pFacultad;
            Carrera = pCarrera;
            EstadoEstudiante = pEstadoEstudiante;
            UsoCondicionEspecial = pUsoCondicionEspecial;
        }
    }

    class SerializadorEstudiante
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorEstudiante.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Estudiante pEstudiante)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO Estudiante (NroRegistro,Nombres,ApellidoPaterno,ApellidoMaterno,Facultad,Carrera,EstadoEstudiante,UsoCondicionEspecial)
values(@NroRegistro,@Nombres,@ApellidoPaterno,@ApellidoMaterno,@Facultad,@Carrera,@EstadoEstudiante,@UsoCondicionEspecial)";

            SQLiteParameter[] p = new SQLiteParameter[9];
            p[0] = new SQLiteParameter("@idEstudiante", pEstudiante.idEstudiante);
            p[1] = new SQLiteParameter("@NroRegistro", pEstudiante.NroRegistro);
            p[2] = new SQLiteParameter("@Nombres", pEstudiante.Nombres);
            p[3] = new SQLiteParameter("@ApellidoPaterno", pEstudiante.ApellidoPaterno);
            p[4] = new SQLiteParameter("@ApellidoMaterno", pEstudiante.ApellidoMaterno);
            p[5] = new SQLiteParameter("@Facultad", pEstudiante.Facultad);
            p[6] = new SQLiteParameter("@Carrera", pEstudiante.Carrera);
            p[7] = new SQLiteParameter("@EstadoEstudiante", pEstudiante.EstadoEstudiante);
            p[8] = new SQLiteParameter("@UsoCondicionEspecial", pEstudiante.UsoCondicionEspecial);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(Estudiante e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Estudiante WHERE idEstudiante=@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idEstudiante);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(Estudiante pEstudiante)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO Estudiante
values(@idEstudiante,@NroRegistro,@Nombres,@ApellidoPaterno,@ApellidoMaterno,@Facultad,@Carrera,@EstadoEstudiante,@UsoCondicionEspecial)";
            SQLiteParameter[] p = new SQLiteParameter[9];
            p[0] = new SQLiteParameter("@idEstudiante", pEstudiante.idEstudiante);
            p[1] = new SQLiteParameter("@NroRegistro", pEstudiante.NroRegistro);
            p[2] = new SQLiteParameter("@Nombres", pEstudiante.Nombres);
            p[3] = new SQLiteParameter("@ApellidoPaterno", pEstudiante.ApellidoPaterno);
            p[4] = new SQLiteParameter("@ApellidoMaterno", pEstudiante.ApellidoMaterno);
            p[5] = new SQLiteParameter("@Facultad", pEstudiante.Facultad);
            p[6] = new SQLiteParameter("@Carrera", pEstudiante.Carrera);
            p[7] = new SQLiteParameter("@EstadoEstudiante", pEstudiante.EstadoEstudiante);
            p[8] = new SQLiteParameter("@UsoCondicionEspecial", pEstudiante.UsoCondicionEspecial);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Estudiante", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Estudiante (
idEstudiante INTEGER PRIMARY KEY AUTOINCREMENT,NroRegistro TEXT,Nombres TEXT,ApellidoPaterno TEXT,ApellidoMaterno TEXT,Facultad TEXT,Carrera INTEGER,EstadoEstudiante INTEGER,UsoCondicionEspecial INTEGER );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
