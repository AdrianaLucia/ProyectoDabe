using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    class GestionFacultad
    {
        

        public static bool adicionar(string cadena)
        {

            Facultad aCrear = new Facultad(0,cadena);
            SerializadorFacultad.adicionar(aCrear);
            return false;
        }
    }
}
