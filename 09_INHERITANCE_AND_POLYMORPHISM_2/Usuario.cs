using System;
using System.Collections.Generic;
using System.Text;

namespace _09_INHERITANCE_AND_POLYMORPHISM_2
{
    // 1. Definir clase padre
    public class Usuario
    {
        protected int usuarioID; // Se usa el modificador de acceso protected
        protected string usuarioNombre; // Se usa el modificador de acceso protected

        public void setUsuario(int pID, string pNombre)
        {
            usuarioID = pID;
            usuarioNombre = pNombre;
        }

        public string getUusario()
        {
            return "ID de usuario: " + usuarioID + ", Nombre de usuario: " + usuarioNombre;
        }
    }
}
