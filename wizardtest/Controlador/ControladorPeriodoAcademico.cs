using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;


namespace wizardtest.Controlador
{
    class ControladorPeriodoAcademico
    {

        public static bool adicionar(int anio, string semestre)
        {
            
            PeriodoAcademico aCrear = new PeriodoAcademico(0, anio,semestre);
            SerializadorPeriodoAcademico.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idPeriodo)
        {

            PeriodoAcademico aEliminar = new PeriodoAcademico(idPeriodo, 0,"");
            SerializadorPeriodoAcademico.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorPeriodoAcademico.getListado();
        }
        public static System.Data.DataTable getDataSetTodosTexto()
        {
            return SerializadorPeriodoAcademico.getListadoConcat();
        }


        internal static bool modificar(int id, int anio, string semestre)
        {
            PeriodoAcademico aModificar = new PeriodoAcademico(id, anio, semestre);
            return SerializadorPeriodoAcademico.modificar(aModificar);
        }

    }
}
