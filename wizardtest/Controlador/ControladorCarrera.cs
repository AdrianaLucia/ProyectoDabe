using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorCarrera
    {
        public static bool adicionar(string pnombre,int pcodigo,string pfacultad)
        {
            Carrera aCrear = new Carrera(0, pnombre, pcodigo, pfacultad);
            SerializadorCarrera.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idActividad)
        {
            Carrera aEliminar = new Carrera(idActividad,"",0,"");
            SerializadorCarrera.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorCarrera.getListado();
        }

        public static System.Data.DataTable getDataSetPorFacultad(string fac)
        {
            return SerializadorCarrera.getListadoFacultad(fac);
        }

        public static bool modificar(int pidCarrera, string pnombre, int pcodigo, string pfacultad)
        {
            Carrera aCrear = new Carrera(pidCarrera, pnombre, pcodigo, pfacultad);
            return SerializadorCarrera.modificar(aCrear);
        }
    }
}
