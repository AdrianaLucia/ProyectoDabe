using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    class ControladorRegistroAsistencia
    {
        public static bool adicionar(int pidPeriodoActividad, int pidEstudiante, int pFechaActividad, int pAsistencia)
        {

            RegistroAsistencia aCrear = new RegistroAsistencia(0, pidPeriodoActividad, pidEstudiante, pFechaActividad, pAsistencia);
            SerializadorRegistroAsistencia.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idRegistroAsistencia)
        {

            RegistroAsistencia aEliminar = new RegistroAsistencia(idRegistroAsistencia,0,0,0,0);
            SerializadorRegistroAsistencia.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorRegistroAsistencia.getListado();
        }

        public static System.Data.DataTable getDataSetPorPeriodo(int idPeriodo)
        {
            return SerializadorRegistroAsistencia.getListadoPorPeriodo(idPeriodo);
        }


        internal static bool modificar(int pidRegistroAsistencia,int pidPeriodoActividad,int pidEstudiante,int pFechaActividad,int pAsistencia)
        {
            RegistroAsistencia aModificar = new RegistroAsistencia(pidRegistroAsistencia,pidPeriodoActividad,pidEstudiante,pFechaActividad,pAsistencia);
            return SerializadorRegistroAsistencia.modificar(aModificar);
        }
    }
}
