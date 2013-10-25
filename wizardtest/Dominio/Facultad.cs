using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace wizardtest.Dominio
{
   
    class Facultad
    {
        public int Codigo {get;private set;}
        public String Nombre { get; private set; }
        public Facultad(int cod, string nom)
        {
            Codigo = cod;
            Nombre = nom;
        }
    }

    class SerializadorFacultad
    {
      
        static bool inicializado = false;

        static void init()
        {
            SerializadorFacultad.crearTablaSiNoExiste();
            inicializado = true;
        }

        public static Boolean adicionar(Facultad f)
        {
            if (!inicializado) { init(); }
            int filasAdicionadas  = 0;
            
            string comando = @"INSERT INTO Facultad (nombre) 
                                                    values(@nom)";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@nom", f.Nombre);
            filasAdicionadas = ConexionBD.ejecutarCambio(comando, p);
                
           
            return filasAdicionadas == 0;
        }
        
        
        public static Boolean eliminar(Facultad f)
        {
            if (!inicializado) { init(); }
            int filasModificados = 0;

            string comando = @"DELETE FROM Facultad WHERE cod=@cod";
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@cod", f.Codigo);
            filasModificados = ConexionBD.ejecutarCambio(comando, p);


            return filasModificados == 0;
        }

        static void crearTablaSiNoExiste()
        {
            using (var con = ConexionBD.getConexion())
            {
                con.Open();
                SQLiteCommand adicion = new SQLiteCommand(con);
                adicion.CommandText = @"CREATE TABLE IF NOT EXISTS Facultad(
                                              codigo INTEGER PRIMARY KEY AUTOINCREMENT,
                                              nombre TEXT
                                        );";
                adicion.ExecuteNonQuery();
            }
        }

       
    }

}
