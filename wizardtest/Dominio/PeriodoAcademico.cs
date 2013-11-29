using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
    class PeriodoAcademico
    {
        public int idPeriodo { get; private set; }
        public int Anio { get; private set; }
        public string Semestre { get; private set; }
        public PeriodoAcademico(int pidPeriodo, int pAnio, string pSemestre)
        {
            idPeriodo = pidPeriodo;
            Anio = pAnio;
            Semestre = pSemestre;
        }
    }

    class SerializadorPeriodoAcademico
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorPeriodoAcademico.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(PeriodoAcademico pPeriodoAcademico)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO PeriodoAcademico (Anio,Semestre)
values(@Anio,@Semestre)";

            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@idPeriodo", pPeriodoAcademico.idPeriodo);
            p[1] = new SQLiteParameter("@Anio", pPeriodoAcademico.Anio);
            p[2] = new SQLiteParameter("@Semestre", pPeriodoAcademico.Semestre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(PeriodoAcademico e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM PeriodoAcademico WHERE idPeriodo=@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idPeriodo);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(PeriodoAcademico pPeriodoAcademico)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO PeriodoAcademico
values(@idPeriodo,@Anio,@Semestre)";
            SQLiteParameter[] p = new SQLiteParameter[3];
            p[0] = new SQLiteParameter("@idPeriodo", pPeriodoAcademico.idPeriodo);
            p[1] = new SQLiteParameter("@Anio", pPeriodoAcademico.Anio);
            p[2] = new SQLiteParameter("@Semestre", pPeriodoAcademico.Semestre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }
        public static DataTable getListado()
        {
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM PeriodoAcademico", conn);
            adaptador.Fill(resultado);
            return resultado;
        }

        public static DataTable getListadoConcat()
        {
            DataTable resultado = new DataTable();
            try
            {
                
                SQLiteConnection conn = ConexionBD.getConexion();
                conn.Open();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT idPeriodo,(Anio||' '||Semestre) as texto FROM PeriodoAcademico", conn);
                adaptador.Fill(resultado);
            }
            catch (Exception ex)
            {
                string tes = ex.Message ;
            }
            return resultado;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS PeriodoAcademico (
idPeriodo INTEGER PRIMARY KEY AUTOINCREMENT,Anio INTEGER,Semestre TEXT );";
                adicion.ExecuteNonQuery();
            }
        }


    }

}
