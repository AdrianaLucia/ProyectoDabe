using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
namespace wizardtest.Dominio
{
    class Actividad
    {
        public int idActividad {get ; private set;}
        public string Nombre { get; private set; }
        public int tipoActividad {get; private set;}
        public int estadoActividad { get; private set; }
        public int Dia { get; private set; }
        public DateTime horaInicio { get; private set; }
        public DateTime horaFin { get; private set; }
        public string Ubicacion { get; private set; }
        public Actividad(int cod, string nom,int tipo,int estado,int dia,DateTime horaini,DateTime horafin,string ubi)
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
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@nom", actividad.Nombre);
            p[1] = new SQLiteParameter("@nom", actividad.Nombre);
            p[2] = new SQLiteParameter("@nom", actividad.Nombre);
            p[3] = new SQLiteParameter("@nom", actividad.Nombre);
            p[0] = new SQLiteParameter("@nom", actividad.Nombre);
     
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas == 0;
        }

        /*        public static DataSet getListado()
                {
                //    SQl
                }
                */
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


    }
}
