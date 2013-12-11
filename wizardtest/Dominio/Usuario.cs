using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;


namespace wizardtest.Dominio
{
    public class Usuario
    {
        public int idPersona { get; private set; }
        public string Nombre { get; private set; }
        public string ApPat { get; private set; }
        public string ApMat { get; private set; }
        public string Nick { get; private set; }
        public string Password { get; private set; }
      //  public string Password2 { get; private set; }
        public int idRolUsuario { get; private set; }
        public string Pregunta { get; private set; }
        public string Respuesta { get; private set; }
        public Usuario(int pidPersona, string pNombre, string pApPat, string pApMat, string pNick, string pPassword, /*string pPassword2,*/ int pidRolUsuario, string pPregunta, string pRespuesta)
        {
            idPersona = pidPersona;
            Nombre = pNombre;
            ApPat = pApPat;
            ApMat = pApMat;
            Nick = pNick;
            Password = pPassword;
            //Password2 = pPassword2;
            idRolUsuario = pidRolUsuario;
            Pregunta = pPregunta;
            Respuesta = pRespuesta;
        }
    }


    class SerializadorUsuario
    {

        static bool inicializado = false;

        static void init()
        {
            SerializadorUsuario.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Usuario pUsuario)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"INSERT INTO Usuario (Nombre,ApPat,ApMat,Nick,Password,idRolUsuario,Pregunta,Respuesta)
values(@Nombre,@ApPat,@ApMat,@Nick,@Password,@idRolUsuario,@Pregunta,@Respuesta)";

            SQLiteParameter[] p = new SQLiteParameter[9];
            p[0] = new SQLiteParameter("@idPersona", pUsuario.idPersona);
            p[1] = new SQLiteParameter("@Nombre", pUsuario.Nombre);
            p[2] = new SQLiteParameter("@ApPat", pUsuario.ApPat);
            p[3] = new SQLiteParameter("@ApMat", pUsuario.ApMat);
            p[4] = new SQLiteParameter("@Nick", pUsuario.Nick);
            p[5] = new SQLiteParameter("@Password", pUsuario.Password);
           // p[6] = new SQLiteParameter("@Password2", pUsuario.Password2);
            p[6] = new SQLiteParameter("@idRolUsuario", pUsuario.idRolUsuario);
            p[7] = new SQLiteParameter("@Pregunta", pUsuario.Pregunta);
            p[8] = new SQLiteParameter("@Respuesta", pUsuario.Respuesta);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
            return filasAdicionadas > 0;
        }

        public static Boolean eliminar(Usuario e)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Usuario WHERE idPersona =@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", e.idPersona);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }


        internal static bool modificar(Usuario pUsuario)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas = 0;

            string comando = @"REPLACE INTO Usuario
values(@idPersona,@Nombre,@ApPat,@ApMat,@Nick,@Password,@idRolUsuario,@Pregunta,@Respuesta)";
            SQLiteParameter[] p = new SQLiteParameter[9];
            p[0] = new SQLiteParameter("@idPersona", pUsuario.idPersona);
            p[1] = new SQLiteParameter("@Nombre", pUsuario.Nombre);
            p[2] = new SQLiteParameter("@ApPat", pUsuario.ApPat);
            p[3] = new SQLiteParameter("@ApMat", pUsuario.ApMat);
            p[4] = new SQLiteParameter("@Nick", pUsuario.Nick);
            p[5] = new SQLiteParameter("@Password", pUsuario.Password);
           // p[6] = new SQLiteParameter("@Password2", pUsuario.Password2);
            p[6] = new SQLiteParameter("@idRolUsuario", pUsuario.idRolUsuario);
            p[7] = new SQLiteParameter("@Pregunta", pUsuario.Pregunta);
            p[8] = new SQLiteParameter("@Respuesta", pUsuario.Respuesta);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);


            return filasAdicionadas > 0;
        }

        public static Usuario getUsuario(string Nick, string PW)
        {
            DataTable resultado = new DataTable();
            try
            {
                SQLiteConnection conn = ConexionBD.getConexion();
                conn.Open();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * from Usuario WHERE Nick='" + Nick + "';", conn);
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0) return null;
                return new Usuario(Convert.ToInt32(resultado.Rows[0]["idPersona"].ToString()),
                    resultado.Rows[0]["Nombre"].ToString(),
                    resultado.Rows[0]["ApPat"].ToString(),
                    resultado.Rows[0]["ApMat"].ToString(),
                    resultado.Rows[0]["Nick"].ToString(),
                    resultado.Rows[0]["Password"].ToString(),
                    Convert.ToInt32(resultado.Rows[0]["idRolUsuario"].ToString()),
                    resultado.Rows[0]["Pregunta"].ToString(),
                    resultado.Rows[0]["Respuesta"].ToString());   
            }
            catch (Exception ex)
            {
                string tes = ex.Message;
            }
            return null;
        }

        public static DataTable getListado()
        {
            crearTablaSiNoExiste();
            DataTable resultado = new DataTable();
            SQLiteConnection conn = ConexionBD.getConexion();
            conn.Open();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM Usuario", conn);
            adaptador.Fill(resultado);
            return resultado;
        }


        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Usuario (
idPersona INTEGER PRIMARY KEY AUTOINCREMENT,Nombre TEXT,ApPat TEXT,ApMat TEXT,Nick TEXT,Password TEXT,idRolUsuario INTEGER,Pregunta TEXT,Respuesta TEXT );";
                adicion.ExecuteNonQuery();
            }
        }


    }
}
