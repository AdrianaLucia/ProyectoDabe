using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorPromedioPeriodo
    {

        public static bool eliminar(int idReap, int pPromedio)
        {
            PromedioPeriodo aEliminar = new PromedioPeriodo(idReap, pPromedio);
            SerializadorPromedioPeriodo.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorPromedioPeriodo.getListado();
        }

        public static bool crearReemplazar(int idREAP,int promedio )
        {
            PromedioPeriodo aCrear = new PromedioPeriodo(idREAP, promedio);
            return SerializadorPromedioPeriodo.modificar(aCrear);
        }

    }
}
