using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wizardtest.Dominio;
namespace wizardtest.Controlador
{
    class ControladorActividad
    {
        public static bool adicionar(string nom, int tipo, int estado, int dia, string horaini, string horafin, string ubi)
        {
            Actividad aCrear = new Actividad(0,nom, tipo,  estado,  dia,  horaini,  horafin, ubi);
            SerializadorActividad.adicionar(aCrear);
            return false;
        }
        public static bool eliminar(int idActividad)
        {
            Actividad aEliminar = new Actividad(idActividad, "", 0, 0, 0, "","", "");
            SerializadorActividad.eliminar(aEliminar);
            return false;
        }

        public static System.Data.DataTable getDataSetTodos()
        {
            return SerializadorActividad.getListado();
        }


        public static bool modificar(int cod, string nom, int tipo, int estado, int dia, string horaini, string horafin, string ubi)
        {
            Actividad aModificar = new Actividad(cod, nom, tipo, estado, dia, horaini, horafin, ubi);
            return SerializadorActividad.modificar(aModificar);
        }
    }
}
