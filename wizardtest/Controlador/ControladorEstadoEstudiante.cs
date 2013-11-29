using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorEstadoEstudiante
    {

        public static bool adicionar(string nombreEstadoEstudiante)
        {

            EstadoEstudiante aCrear = new EstadoEstudiante(0, nombreEstadoEstudiante);
            SerializadorEstadoEstudiante.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idEstadoActividad)
        {

            EstadoEstudiante aEliminar = new EstadoEstudiante(idEstadoActividad, "");
            SerializadorEstadoEstudiante.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorEstadoEstudiante.getListado();
        }


        internal static bool modificar(int id, string nombre)
        {
            EstadoEstudiante aModificar = new EstadoEstudiante(id, nombre);
            return SerializadorEstadoEstudiante.modificar(aModificar);
        }

    }

   
    
    
}
