using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    class ControladorEstudiante
    {
        public static bool adicionar(string pNroRegistro, string pNombres, string pApellidoPaterno, string pApellidoMaterno, string pFacultad, int pCarrera, int pEstadoEstudiante, int pUsoCondicionEspecial)
        {

            Estudiante aCrear = new Estudiante(0, pNroRegistro, pNombres, pApellidoPaterno, pApellidoMaterno, pFacultad, pCarrera, pEstadoEstudiante, pUsoCondicionEspecial);
            SerializadorEstudiante.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int id)
        {

            Estudiante aEliminar = new Estudiante(id,"","","","","",0,0,0);
            SerializadorEstudiante.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorEstudiante.getListado();
        }
     


        internal static bool modificar(int id, string pNroRegistro, string pNombres, string pApellidoPaterno, string pApellidoMaterno, string pFacultad, int pCarrera, int pEstadoEstudiante, int pUsoCondicionEspecial)
        {
            Estudiante aModificar = new Estudiante(id, pNroRegistro, pNombres, pApellidoPaterno, pApellidoMaterno, pFacultad, pCarrera, pEstadoEstudiante, pUsoCondicionEspecial);
            return SerializadorEstudiante.modificar(aModificar);
        }
    }
}
