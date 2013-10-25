using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
namespace wizardtest.Dominio
{
    class Actividad
    {
        public int idActividad {get ; private set;}
        public string Nombre { get; private set; }
        public int tipoActividad {get; private set;}
        public int estadoActividad { get; private set; }
        public int Dia { get; private set; }
        public string horaInicio { get; private set; }
        public string horaFin { get; private set; }
        public string Ubicacion { get; private set; }
        public Actividad(int cod, string nom,int tipo,int estado,int dia,string horaini, string horafin,string ubi)
        {
            idActividad = cod;
            Nombre = nom;
            tipoActividad = tipo;
            estadoActividad = estado;
            Dia = dia;
            horaInicio = horaini;
            horaFin = horafin;
            Ubicacion = ubi;
        }
    }

    class SerializadorActividad
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorActividad.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Actividad actividad)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO Actividad (nombre,tipoActividad,estadoActividad,dia,horaInicio,horaFin,ubicacion) 
                                                    values(@nom,@tipo,@estado,@dia,@horaini,@horafin,@ubi)";

            SQLiteParameter[] p = new SQLiteParameter[7];
            p[0] = new SQLiteParameter("@nom", actividad.Nombre);
            p[1] = new SQLiteParameter("@tipo", actividad.tipoActividad);
            p[2] = new SQLiteParameter("@estado", actividad.estadoActividad);
            p[3] = new SQLiteParameter("@dia", actividad.Dia);
            p[4] = new SQLiteParameter("@horaini", actividad.horaInicio);
            p[5] = new SQLiteParameter("@horafin", actividad.horaFin);
            p[6] = new SQLiteParameter("@ubi", actividad.Ubicacion);
     
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }

       
        public static Boolean eliminar(Actividad e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Actividad WHERE idactividad =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idActividad);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(Actividad actividad)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO Actividad 
                                                    values(@cod,@nom,@tipo,@estado,@dia,@horaini,@horafin,@ubi)";
            SQLiteParameter[] p = new SQLiteParameter[8];
            p[0] = new SQLiteParameter("@cod", actividad.idActividad);
            p[1] = new SQLiteParameter("@nom", actividad.Nombre);
            p[2] = new SQLiteParameter("@tipo", actividad.tipoActividad);
            p[3] = new SQLiteParameter("@estado", actividad.estadoActividad);
            p[4] = new SQLiteParameter("@dia", actividad.Dia);
            p[5] = new SQLiteParameter("@horaini", actividad.horaInicio);
            p[6] = new SQLiteParameter("@horafin", actividad.horaFin);
            p[7] = new SQLiteParameter("@ubi", actividad.Ubicacion);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Actividad", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Actividad (
                                                idactividad INTEGER PRIMARY KEY AUTOINCREMENT,nombre TEXT,tipoActividad INTEGER,estadoActividad INTEGER,dia INTEGER,horaInicio TEXT,horaFin TEXT,ubicacion TEXT
                                        );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
