using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorRolUsuario
    {

        public static bool adicionar(string nom,int niv)
        {

            RolUsuario aCrear = new RolUsuario(0,nom,niv);
            SerializadorRolUsuario.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int id)
        {

            RolUsuario aEliminar = new RolUsuario(id, "",0);
            SerializadorRolUsuario.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorRolUsuario.getListado();
        }


        internal static bool modificar(int id, string nombre, int niv)
        {
            RolUsuario aModificar = new RolUsuario(id, nombre,niv);
            return SerializadorRolUsuario.modificar(aModificar);
        }
    }
}
