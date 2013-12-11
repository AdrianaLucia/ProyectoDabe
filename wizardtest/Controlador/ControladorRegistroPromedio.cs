using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    
    class ControladorRegistroPromedio
    {
        public static bool adicionar(string pNroRegistro, int pPeriodo, string pNombre, int pCarrera, double pPromCarrera, int pIAA, int pIAP)
        {

            RegistroPromedios aCrear = new RegistroPromedios(pNroRegistro,pPeriodo,pNombre,pCarrera,pPromCarrera,pIAA,pIAP);
            SerializadorRegistroPromedios.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(string pNroRegistro, int pPeriodo)
        {

            RegistroPromedios aEliminar = new RegistroPromedios(pNroRegistro,pPeriodo,"",0,0,0,0);
            SerializadorRegistroPromedios.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorRegistroPromedios.getListado();
        }


        internal static bool modificar(string pNroRegistro, int pPeriodo, string pNombre, int pCarrera, double pPromCarrera, int pIAA, int pIAP)
        {
            RegistroPromedios aModificar = new RegistroPromedios(pNroRegistro, pPeriodo, pNombre, pCarrera, pPromCarrera, pIAA, pIAP);
            return SerializadorRegistroPromedios.modificar(aModificar);
        }
    }
}
