using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class GestionEstadoActividad
    {


        public static bool adicionar(string nombreEstadoActividad)
        {

            EstadoActividad aCrear = new EstadoActividad(0, nombreEstadoActividad);
            SerializadorEstadoActividad.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idEstadoActividad)
        {

            EstadoActividad aEliminar = new EstadoActividad(idEstadoActividad, "");
            SerializadorEstadoActividad.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorEstadoActividad.getListado();
        }


        internal static bool modificar(int id, string nombre)
        {
            EstadoActividad aModificar = new EstadoActividad(id, nombre);
            return SerializadorEstadoActividad.modificar(aModificar);
        }

    }
}
