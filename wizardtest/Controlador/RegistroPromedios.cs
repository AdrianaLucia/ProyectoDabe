using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace wizardtest.Controlador
{
    class RegistroPromedios
    {
        public int NroRegistro { get; private set; }
        public int Periodo { get; private set; }
        public string Nombre { get; private set; }
        public int Carrera { get; private set; }
        public double PromCarrera { get; private set; }
        public double IAA { get; private set; }
        public double IAP { get; private set; }

        public RegistroPromedios(int pNroRegistro, int pPeriodo, string pNombre, int pCarrera, double pPromCarrera, int pIAA, int pIAP)
        {
            NroRegistro = pNroRegistro;
            Periodo = pPeriodo;
            Nombre = pNombre;
            Carrera = pCarrera;
            PromCarrera = pPromCarrera;
            IAA = pIAA;
            IAP = pIAP;
        }
    }

    class SerializadorRegistroPromedios
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorRegistroPromedios.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(RegistroPromedios pRegistroPromedios)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO RegistroPromedios (Periodo,Nombre,Carrera,PromCarrera,IAA,IAP)
values(@Periodo,@Nombre,@Carrera,@PromCarrera,@IAA,@IAP)";

            SQLiteParameter[] p = new SQLiteParameter[7];
            p[0] = new SQLiteParameter("@NroRegistro", pRegistroPromedios.NroRegistro);
            p[1] = new SQLiteParameter("@Periodo", pRegistroPromedios.Periodo);
            p[2] = new SQLiteParameter("@Nombre", pRegistroPromedios.Nombre);
            p[3] = new SQLiteParameter("@Carrera", pRegistroPromedios.Carrera);
            p[4] = new SQLiteParameter("@PromCarrera", pRegistroPromedios.PromCarrera);
            p[5] = new SQLiteParameter("@IAA", pRegistroPromedios.IAA);
            p[6] = new SQLiteParameter("@IAP", pRegistroPromedios.IAP);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(RegistroPromedios e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM RegistroPromedios WHERE NroRegistro=@num AND Periodo =@per";
            SQLiteParameter[] p = new SQLiteParameter[2];
            p[0] = new SQLiteParameter("@cod", e.NroRegistro);
            p[1] = new SQLiteParameter("@per", e.Periodo);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }



        internal static bool modificar(RegistroPromedios pRegistroPromedios)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO RegistroPromedios
values(@NroRegistro,@Periodo,@Nombre,@Carrera,@PromCarrera,@IAA,@IAP)";
            SQLiteParameter[] p = new SQLiteParameter[7];
            p[0] = new SQLiteParameter("@NroRegistro", pRegistroPromedios.NroRegistro);
            p[1] = new SQLiteParameter("@Periodo", pRegistroPromedios.Periodo);
            p[2] = new SQLiteParameter("@Nombre", pRegistroPromedios.Nombre);
            p[3] = new SQLiteParameter("@Carrera", pRegistroPromedios.Carrera);
            p[4] = new SQLiteParameter("@PromCarrera", pRegistroPromedios.PromCarrera);
            p[5] = new SQLiteParameter("@IAA", pRegistroPromedios.IAA);
            p[6] = new SQLiteParameter("@IAP", pRegistroPromedios.IAP);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM RegistroPromedios", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS RegistroPromedios (NroRegistro INTEGER ,Periodo INTEGER,Nombre TEXT,Carrera INTEGER,PromCarrera REAL,IAA INTEGER,IAP INTEGER ,PRIMARY KEY(NroRegistro,Periodo) );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
