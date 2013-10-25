using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

using wizardtest.Dominio;


namespace wizardtest.Controlador
{
    class GestionTipoActividad
    {


        public static bool adicionar(string nombreTipoActividad)
        {

            TipoActividad aCrear = new TipoActividad(0, nombreTipoActividad);

            return SerializadorTipoActividad.adicionar(aCrear); ;
        }
        public static bool eliminar(int idTipoActividad)
        {

            TipoActividad aEliminar = new TipoActividad(idTipoActividad,"");

            return SerializadorTipoActividad.eliminar(aEliminar); ;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorTipoActividad.getListado();
        }


        internal static bool modificar(int id, string nombre)
        {
            TipoActividad aModificar = new TipoActividad(id, nombre);
            return SerializadorTipoActividad.modificar(aModificar);
        }
    }
}
