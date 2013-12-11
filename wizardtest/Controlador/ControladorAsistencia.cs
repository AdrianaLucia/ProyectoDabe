using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    class ControladorAsistencia
    {
        
        public static bool eliminar(int idReap,string semana)
        {
            Asistencia aEliminar = new Asistencia(idReap,0,semana);
            SerializadorAsistencia.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorCarrera.getListado();
        }

        public static bool crearReemplazar(int idREAP, int asistencia, string fecha)
        {
            Asistencia aCrear = new Asistencia(idREAP,asistencia,fecha);
            return SerializadorAsistencia.modificar(aCrear);
        }
    }
}
