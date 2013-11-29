using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


using wizardtest.Dominio;

namespace wizardtest.Controlador
{
    class ControladorUsuario
    {
        public static bool adicionar(string pNombre, string pApPat, string pApMat, string pNick, string pPassword, string pPassword2, int pidRolUsuario, string pPregunta, string pRespuesta)
            {

                Usuario aCrear = new Usuario(0, pNombre, pApPat, pApMat, pNick, pPassword, pPassword2, pidRolUsuario, pPregunta, pRespuesta);
                SerializadorUsuario.adicionar(aCrear);
                return false;
            }
            public static bool eliminar(int id)
            {

                Usuario aEliminar = new Usuario(id, "", "","","","","",0,"","");
                SerializadorUsuario.eliminar(aEliminar);
                return false;
            }

            public static System.Data.DataTable getDataSetTodos()
            {
                return SerializadorUsuario.getListado();
            }


            internal static bool modificar(int id, string pNombre, string pApPat, string pApMat, string pNick, string pPassword, string pPassword2, int pidRolUsuario, string pPregunta, string pRespuesta)
            {
                Usuario aModificar = new Usuario(id, pNombre, pApPat, pApMat, pNick, pPassword, pPassword2, pidRolUsuario, pPregunta, pRespuesta);
                return SerializadorUsuario.modificar(aModificar);
            }
    }
}
