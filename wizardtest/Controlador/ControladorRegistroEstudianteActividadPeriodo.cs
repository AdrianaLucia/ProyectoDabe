using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorRegistroEstudianteActividadPeriodo
    {
        public static bool adicionar(int idEstudiante,int idActividad, int idPeriodo)
        {
            RegistroEstudianteActividadPeriodo aCrear = new RegistroEstudianteActividadPeriodo(0,idEstudiante, idActividad, idPeriodo);
            SerializadorRegistroEstudianteActividadPeriodo.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idREAP)
        {
            RegistroEstudianteActividadPeriodo aEliminar = new RegistroEstudianteActividadPeriodo(idREAP, 0, 0, 0);
            SerializadorRegistroEstudianteActividadPeriodo.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorRegistroEstudianteActividadPeriodo.getListado();
        }
        public static System.Data.DataTable getDataSetEstudiantes(int idActividad,int idPeriodo)
        {
            return SerializadorRegistroEstudianteActividadPeriodo.getListadoEstudiantes(idActividad, idPeriodo);
        }


        public static bool modificar(int cod, int idEst, int idAct, int idPer)
        {
            RegistroEstudianteActividadPeriodo aModificar = new RegistroEstudianteActividadPeriodo(cod, idEst, idAct, idPer);
            return SerializadorRegistroEstudianteActividadPeriodo.modificar(aModificar);
        }

       
    }
}
