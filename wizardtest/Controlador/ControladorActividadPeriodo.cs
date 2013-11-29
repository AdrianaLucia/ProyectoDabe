using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorActividadPeriodo
    {
        public static bool adicionar(int idActividad, int idPeriodo)
        {
            ActividadPeriodo aCrear = new ActividadPeriodo(0,idActividad,idPeriodo);
            SerializadorActividadPeriodo.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idActividad)
        {
            ActividadPeriodo aEliminar = new ActividadPeriodo(idActividad, 0, 0);
            SerializadorActividadPeriodo.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorActividadPeriodo.getListado();
        }


        public static bool modificar(int cod, int idAct, int idPer)
        {
            ActividadPeriodo aModificar = new ActividadPeriodo(cod, idAct, idPer);
            return SerializadorActividadPeriodo.modificar(aModificar);
        }

        internal static System.Data.DataTable getDataSetTodosActividadNombre(int per)
        {
            return SerializadorActividadPeriodo.getListadoNombres(per);
        }
    }
}
